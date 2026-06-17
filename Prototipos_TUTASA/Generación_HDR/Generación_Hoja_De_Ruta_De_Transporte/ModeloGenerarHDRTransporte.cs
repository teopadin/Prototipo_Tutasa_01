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
            CentrosDeDistribucion = new List<CentroDistribucion>();
            foreach (var cd in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                CentrosDeDistribucion.Add(new CentroDistribucion
                {
                    idCD = cd.idCD,
                    nombre = cd.nombre
                });
            }

            CdEmisor = BuscarCD(Program.CodigoCDActual);
            if (CdEmisor == null && CentrosDeDistribucion.Count > 0)
            {
                CdEmisor = CentrosDeDistribucion[0];
            }

            Empresas = new List<EmpresaTransporte>();
            foreach (var emp in EmpresaTransporteAlmacen.empresas)
            {
                Empresas.Add(new EmpresaTransporte
                {
                    idEmpresa = emp.idEmpresa,
                    razonSocial = emp.razonSocial
                });
            }

            Servicios = new List<ServicioMediaDistancia>();
            foreach (var s in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
            {
                if (s.fechaSalida.Date < DateTime.Today)
                {
                    continue;
                }

                if (s.fechaLlegada != null || s.fechaRecepcion != null)
                {
                    continue;
                }

                var servicioDominio = new ServicioMediaDistancia
                {
                    idServicio = s.idServicio,
                    idEmpresa = s.idEmpresa,
                    tipoArrendamiento = ConvertirTipoArrendamiento(s.tipoArrendamiento),
                    idCDOrigen = s.idCDOrigen,
                    idCDDestino = s.idCDDestino,
                    fechaSalida = s.fechaSalida
                };

                servicioDominio.capacidadUsada = servicioDominio.CapacidadMaxima - s.capacidadDisponible;
                Servicios.Add(servicioDominio);
            }

            Guias = new List<Guia>();
            foreach (var g in GuiaAlmacen.Guias)
            {
                if (g.estado != Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Admitida)
                {
                    continue;
                }

                if (g.idCDActual != CdEmisor.idCD)
                {
                    continue;
                }

                if (g.idCDDestino == CdEmisor.idCD)
                {
                    continue;
                }

                Guias.Add(new Guia
                {
                    NroGuia = g.NroGuia,
                    TipoBulto = ConvertirTipoBulto(g.TipoBulto),
                    Estado = EstadoGuiaEnum.Admitida,
                    idCDOrigen = g.idCDOrigen,
                    idCDDestino = g.idCDDestino,
                    idCDActual = g.idCDActual,
                    EquivalenteS = g.EquivalenteS
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

        private GuiaEntidad BuscarGuiaEntidad(List<GuiaEntidad> guiasArchivo, string nroGuia)
        {
            foreach (var g in guiasArchivo)
                if (g.NroGuia == nroGuia) return g;

            return null;
        }

        private ServicioMediaDistanciaEntidad BuscarServicioEntidad(List<ServicioMediaDistanciaEntidad> serviciosArchivo, string idServicio)
        {
            foreach (var s in serviciosArchivo)
                if (s.idServicio == idServicio) return s;

            return null;
        }

        private int ProximoNroHDR(List<HojaDeRutaTransporteEntidad> hojasArchivo)
        {
            int max = 0;

            foreach (var hdr in hojasArchivo)
                if (hdr.nroHDR > max) max = hdr.nroHDR;

            return max + 1;
        }

        public HojaDeRutaTransporteEntidad GenerarHDR(List<Guia> guias, ServicioMediaDistancia servicio)
        {
            var nuevaHDR = new HojaDeRutaTransporteEntidad();
            nuevaHDR.nroHDR = ProximoNroHDR(HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte);
            nuevaHDR.fechaGeneracion = DateTime.Now;
            nuevaHDR.estado = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum.Generada;
            nuevaHDR.idCDOrigen = CdEmisor.idCD;
            nuevaHDR.idCDDestino = servicio.idCDDestino;
            nuevaHDR.idServicio = servicio.idServicio;

            int totalBultos = 0;

            foreach (var guia in guias)
            {
                nuevaHDR.DetalleGuias.Add(guia.NroGuia);
                totalBultos += guia.EquivalenteS;

                guia.Estado = EstadoGuiaEnum.PendienteDeDespacho;

                GuiaEntidad guiaEntidad = BuscarGuiaEntidad(GuiaAlmacen.Guias, guia.NroGuia);
                if (guiaEntidad != null)
                {
                    guiaEntidad.estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.PendienteDeDespacho;

                    guiaEntidad.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = DateTime.Today,
                        Estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.PendienteDeDespacho,
                        Donde = CdEmisor.nombre
                    });
                }
            }

            servicio.capacidadUsada += totalBultos;

            ServicioMediaDistanciaEntidad servicioEntidad = BuscarServicioEntidad(ServicioMediaDistanciaAlmacen.serviciosMediaDistancia, servicio.idServicio);
            if (servicioEntidad != null)
            {
                servicioEntidad.capacidadDisponible -= totalBultos;
                servicioEntidad.DetalleHDRs.Add(nuevaHDR.nroHDR);
            }

            HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte.Add(nuevaHDR);

            GuiaAlmacen.Guardar();
            ServicioMediaDistanciaAlmacen.Guardar();
            HojaDeRutaTransporteAlmacen.Guardar();

            return nuevaHDR;
        }

        private TiposBultoEnum ConvertirTipoBulto(Prototipos_TUTASA.Auxiliares.TiposBultoEnum tipo)
        {
            return (TiposBultoEnum)Enum.Parse(typeof(TiposBultoEnum), tipo.ToString());
        }

        private TipoArrendamientoEnum ConvertirTipoArrendamiento(Prototipos_TUTASA.Auxiliares.TipoArrendamientoEnum tipo)
        {
            return (TipoArrendamientoEnum)Enum.Parse(typeof(TipoArrendamientoEnum), tipo.ToString());
        }
    }
}