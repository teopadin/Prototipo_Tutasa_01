using System;
using System.Collections.Generic;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ModeloGenerarHDRTransporte
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<EmpresaTransporte> Empresas { get; set; }
        public List<Guia> Guias { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public bool Actualizando { get; set; } = false;

        public ModeloGenerarHDRTransporte()
        {
            // ---- CENTROS DE DISTRIBUCION ----
            CentrosDeDistribucion = new List<CentroDistribucion>();
            foreach (var cd in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                CentrosDeDistribucion.Add(new CentroDistribucion
                {
                    idCD = cd.idCD,
                    nombre = cd.nombre
                });
            }

            CdEmisor = BuscarCD(1); // CD fijo (Capital) hasta tener el CD logueado

            // ---- EMPRESAS ----
            Empresas = new List<EmpresaTransporte>();
            foreach (var emp in EmpresaTransporteAlmacen.empresas)
            {
                Empresas.Add(new EmpresaTransporte
                {
                    idEmpresa = emp.idEmpresa,
                    razonSocial = emp.razonSocial
                });
            }

            // ---- SERVICIOS ----
            Servicios = new List<ServicioMediaDistancia>();
            foreach (var s in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
            {
                var servicioDominio = new ServicioMediaDistancia
                {
                    idServicio = s.idServicio,                      
                    idEmpresa = s.idEmpresa,
                    tipoArrendamiento = (TipoArrendamientoEnum)s.tipoArrendamiento, // casteo
                    idCDOrigen = s.idCDOrigen,
                    idCDDestino = s.idCDDestino,
                    fechaSalida = s.fechaSalida
                };
               
                servicioDominio.capacidadUsada = servicioDominio.CapacidadMaxima - s.capacidadDisponible;
                Servicios.Add(servicioDominio);
            }

            // ---- GUIAS ----
            Guias = new List<Guia>();
            foreach (var g in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = g.NroGuia,
                    TipoBulto = (TiposBultoEnum)g.TipoBulto,       // casteo
                    Estado = (EstadoGuiaEnum)g.estado,             // casteo
                    idCDOrigen = g.idCDOrigen,
                    idCDDestino = g.idCDDestino,
                    idCDActual = g.idCDActual,
                    EquivalenteS = g.EquivalenteS                  // <-- esto faltaba (si no, bultos da 0)
                });
            }
        }

        public bool TieneCapacidadSuficiente(ServicioMediaDistancia servicio, int totalBultos)
        {
            return servicio.CapacidadDisponible >= totalBultos;
        }

        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (var cd in CentrosDeDistribucion)
                if (cd.idCD == idCD) return cd;
            return null;
        }

        public EmpresaTransporte BuscarEmpresa(int idEmpresa)
        {
            foreach (var empresa in Empresas)
                if (empresa.idEmpresa == idEmpresa) return empresa;
            return null;
        }

        private GuiaEntidad BuscarGuiaEntidad(string nroGuia)
        {
            foreach (var g in GuiaAlmacen.Guias)
                if (g.NroGuia == nroGuia) return g;
            return null;
        }

        private ServicioMediaDistanciaEntidad BuscarServicioEntidad(string idServicio)
        {
            foreach (var s in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
                if (s.idServicio == idServicio) return s;
            return null;
        }

        private int ProximoNroHDR()
        {
            int max = 0;
            foreach (var hdr in HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte)
                if (hdr.nroHDR > max) max = hdr.nroHDR;
            return max + 1;
        }

        public HojaDeRutaTransporteEntidad GenerarHDR(List<Guia> guias, ServicioMediaDistancia servicio)
        {
            var nuevaHDR = new HojaDeRutaTransporteEntidad();
            nuevaHDR.nroHDR = ProximoNroHDR();
            nuevaHDR.fechaGeneracion = DateTime.Now;
            nuevaHDR.estado = Auxiliares.EstadoHojaDeRutaEnum.Generada;   // entidad -> Auxiliares
            nuevaHDR.idCDOrigen = CdEmisor.idCD;
            nuevaHDR.idCDDestino = servicio.idCDDestino;
            nuevaHDR.idServicio = servicio.idServicio;

            int totalBultos = 0;
            foreach (var guia in guias)
            {
                nuevaHDR.DetalleGuias.Add(guia.NroGuia);
                totalBultos += guia.EquivalenteS;

                guia.Estado = EstadoGuiaEnum.PendienteDeDespacho;   // dominio (para que desaparezca de la lista al refrescar)

                GuiaEntidad guiaEntidad = BuscarGuiaEntidad(guia.NroGuia);
                if (guiaEntidad != null)
                    guiaEntidad.estado = Auxiliares.EstadoGuiaEnum.PendienteDeDespacho;   // entidad (persiste)
            }

            // Capacidad: descuento bultos
            servicio.capacidadUsada += totalBultos;   // dominio
            ServicioMediaDistanciaEntidad servicioEntidad = BuscarServicioEntidad(servicio.idServicio);
            if (servicioEntidad != null)
                servicioEntidad.capacidadDisponible -= totalBultos;   // entidad (persiste)

            // Persistencia
            HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte.Add(nuevaHDR);
            HojaDeRutaTransporteAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            ServicioMediaDistanciaAlmacen.Guardar();

            return nuevaHDR;
        }
    }
}