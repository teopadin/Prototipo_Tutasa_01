using System;
using System.Collections.Generic;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class ModeloGenerarHDRDistribucion
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<Agencia> Agencias { get; set; }
        public List<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public bool Actualizando { get; set; } = false;

        public ModeloGenerarHDRDistribucion()
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

            // CD emisor fijo (Capital, idCD = 1) hasta tener el CD logueado
            CdEmisor = BuscarCD(1);

            // ---- AGENCIAS ----
            Agencias = new List<Agencia>();
            foreach (var ag in AgenciaAlmacen.Agencias)
            {
                Agencias.Add(new Agencia
                {
                    idAgencia = ag.idAgencia,
                    razonSocial = ag.razonSocial,
                    calle = ag.calle,
                    altura = ag.altura,
                    piso = ag.piso,
                    codigoPostal = ag.codigoPostal,
                    ciudad = ag.ciudad,
                    idCD = ag.idCD
                });
            }

            // ---- TRANSPORTISTAS ----
            Transportistas = new List<TransportistaLocal>();
            foreach (var t in TransportistaLocalAlmacen.transportistas)
            {
                Transportistas.Add(new TransportistaLocal
                {
                    dniTransportista = t.dniTransportista,
                    nombre = t.nombre,
                    apellido = t.apellido,
                    idCD = t.idCD,
                    HdrAsignadas = t.HdrAsignadas
                });
            }

            // ---- GUIAS ----
            Guias = new List<Guia>();
            foreach (var g in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = g.NroGuia,
                    modalidadEntrega = (ModalidadEntregaEnum)g.modalidadEntrega,   
                    estado = (EstadoGuiaEnum)g.estado,                             
                    idCDOrigen = g.idCDOrigen,
                    idCDDestino = g.idCDDestino,
                    Destinatario = new DestinatarioGuia                            
                    {
                        Dni = g.Destinatario.Dni,
                        nombre = g.Destinatario.nombre,
                        apellido = g.Destinatario.apellido,
                        calle = g.Destinatario.calle,
                        altura = g.Destinatario.altura,
                        piso = g.Destinatario.piso,
                        codigoPostal = g.Destinatario.codigoPostal,
                        ciudad = g.Destinatario.ciudad
                    },
                    idAgenciaDestino = g.idAgenciaDestino == 0 ? (int?)null : g.idAgenciaDestino
                });
            }
        }

        private CentroDistribucion BuscarCD(int idCD)
        {
            foreach (var cd in CentrosDeDistribucion)
                if (cd.idCD == idCD) return cd;
            return null;
        }

        public Agencia BuscarAgencia(int idAgencia)
        {
            foreach (var agencia in Agencias)
                if (agencia.idAgencia == idAgencia) return agencia;
            return null;
        }

        private GuiaEntidad BuscarGuiaEntidad(string nroGuia)
        {
            foreach (var g in GuiaAlmacen.Guias)
                if (g.NroGuia == nroGuia) return g;
            return null;
        }

        private TransportistaLocalEntidad BuscarTransportistaEntidad(int dni)
        {
            foreach (var t in TransportistaLocalAlmacen.transportistas)
                if (t.dniTransportista == dni) return t;
            return null;
        }

        private int ProximoNroHDR()
        {
            int max = 0;
            foreach (var hdr in HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion)
                if (hdr.NroHDR > max) max = hdr.NroHDR;
            return max + 1;
        }

        public HojaDeRutaDistribucionEntidad GenerarHDR(List<Guia> guias, TransportistaLocal transportista, DateTime fecha)
        {
            var nuevaHDR = new HojaDeRutaDistribucionEntidad();
            nuevaHDR.NroHDR = ProximoNroHDR();
            nuevaHDR.Fecha = fecha;
            nuevaHDR.estado = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum.Generada;
            nuevaHDR.dniTransportistaAsignado = transportista.dniTransportista;


            Guia guiaRef = guias[0];
            if (guiaRef.modalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
            {
                nuevaHDR.Calle = guiaRef.Destinatario.calle;
                nuevaHDR.Altura = guiaRef.Destinatario.altura;
                nuevaHDR.Piso = guiaRef.Destinatario.piso;
                nuevaHDR.CodigoPostal = guiaRef.Destinatario.codigoPostal;
                nuevaHDR.Destinatario = guiaRef.Destinatario.nombre + " " + guiaRef.Destinatario.apellido;
            }
            else
            {
                Agencia agencia = BuscarAgencia(guiaRef.idAgenciaDestino.Value);
                nuevaHDR.Calle = agencia.calle;
                nuevaHDR.Altura = agencia.altura;
                nuevaHDR.Piso = agencia.piso;
                nuevaHDR.CodigoPostal = agencia.codigoPostal;
                nuevaHDR.Destinatario = agencia.razonSocial;
            }


            foreach (var guia in guias)
            {
                nuevaHDR.DetalleGuias.Add(guia.NroGuia);

                GuiaEntidad guiaEntidad = BuscarGuiaEntidad(guia.NroGuia);
                if (guiaEntidad != null)
                    guiaEntidad.estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnDistribucion;
            }

            // Incremento HDR asignadas del transportista EN EL ALMACEN
            TransportistaLocalEntidad transportistaEntidad = BuscarTransportistaEntidad(transportista.dniTransportista);
            if (transportistaEntidad != null)
                transportistaEntidad.HdrAsignadas++;

            // Persistencia
            HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion.Add(nuevaHDR);
            HojaDeRutaDistribucionAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            TransportistaLocalAlmacen.Guardar();

            return nuevaHDR;
        }
    }
}