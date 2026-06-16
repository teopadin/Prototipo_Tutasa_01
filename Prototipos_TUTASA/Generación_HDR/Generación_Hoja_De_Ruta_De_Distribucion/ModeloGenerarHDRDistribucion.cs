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

            Guias = new List<Guia>();
            foreach (var g in GuiaAlmacen.Guias)
            {
                bool esEnCDDestino = g.estado == Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnCDDestino &&
                                     g.idCDDestino == CdEmisor.idCD;

                bool esAdmitidaLocal = g.estado == Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Admitida &&
                                       g.idCDOrigen == CdEmisor.idCD &&
                                       g.idCDDestino == CdEmisor.idCD;

                if (!esEnCDDestino && !esAdmitidaLocal)
                {
                    continue;
                }

                Guias.Add(new Guia
                {
                    NroGuia = g.NroGuia,
                    modalidadEntrega = ConvertirModalidadEntrega(g.modalidadEntrega),
                    estado = ConvertirEstadoGuia(g.estado),
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

        public CentroDistribucion BuscarCD(int idCD)
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

        private GuiaEntidad BuscarGuiaEntidad(List<GuiaEntidad> guiasArchivo, string nroGuia)
        {
            foreach (var g in guiasArchivo)
                if (g.NroGuia == nroGuia) return g;

            return null;
        }

        private TransportistaLocalEntidad BuscarTransportistaEntidad(List<TransportistaLocalEntidad> transportistasArchivo, int dni)
        {
            foreach (var t in transportistasArchivo)
                if (t.dniTransportista == dni) return t;

            return null;
        }

        private int ProximoNroHDR(List<HojaDeRutaDistribucionEntidad> hojasArchivo)
        {
            int max = 0;

            foreach (var hdr in hojasArchivo)
                if (hdr.NroHDR > max) max = hdr.NroHDR;

            return max + 1;
        }

        public HojaDeRutaDistribucionEntidad GenerarHDR(List<Guia> guias, TransportistaLocal transportista, DateTime fecha)
        {
            var nuevaHDR = new HojaDeRutaDistribucionEntidad();
            nuevaHDR.NroHDR = ProximoNroHDR(HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion);
            nuevaHDR.Fecha = fecha;
            nuevaHDR.estado = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum.Generada;
            nuevaHDR.dniTransportistaAsignado = transportista.dniTransportista;
            nuevaHDR.motivoNoCumplida = Prototipos_TUTASA.Auxiliares.MotivoNoCumplidaDistribucionEnum.DestinatarioAusente;

            Guia guiaRef = guias[0];

            if (guiaRef.modalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
            {
                nuevaHDR.Calle = guiaRef.Destinatario.calle;
                nuevaHDR.Altura = guiaRef.Destinatario.altura;
                nuevaHDR.Piso = guiaRef.Destinatario.piso;
                nuevaHDR.CodigoPostal = guiaRef.Destinatario.codigoPostal;
                nuevaHDR.Destinatario = guiaRef.Destinatario.nombre + " " + guiaRef.Destinatario.apellido;
                nuevaHDR.idAgenciaDestino = null;
            }
            else
            {
                Agencia agencia = BuscarAgencia(guiaRef.idAgenciaDestino.Value);

                nuevaHDR.Calle = agencia.calle;
                nuevaHDR.Altura = agencia.altura;
                nuevaHDR.Piso = agencia.piso;
                nuevaHDR.CodigoPostal = agencia.codigoPostal;
                nuevaHDR.Destinatario = agencia.razonSocial;
                nuevaHDR.idAgenciaDestino = agencia.idAgencia;
            }

            foreach (var guia in guias)
            {
                nuevaHDR.DetalleGuias.Add(guia.NroGuia);

                guia.estado = EstadoGuiaEnum.EnDistribucion;

                GuiaEntidad guiaEntidad = BuscarGuiaEntidad(GuiaAlmacen.Guias, guia.NroGuia);
                if (guiaEntidad != null)
                {
                    guiaEntidad.estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnDistribucion;

                    guiaEntidad.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = DateTime.Today,
                        Estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnDistribucion,
                        Donde = CdEmisor.nombre
                    });
                }
            }

            transportista.HdrAsignadas++;

            TransportistaLocalEntidad transportistaEntidad = BuscarTransportistaEntidad(TransportistaLocalAlmacen.transportistas, transportista.dniTransportista);
            if (transportistaEntidad != null)
            {
                transportistaEntidad.HdrAsignadas++;
            }

            HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion.Add(nuevaHDR);

            GuiaAlmacen.Guardar();
            TransportistaLocalAlmacen.Guardar();
            HojaDeRutaDistribucionAlmacen.Guardar();

            return nuevaHDR;
        }

        private ModalidadEntregaEnum ConvertirModalidadEntrega(Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum modalidad)
        {
            return (ModalidadEntregaEnum)Enum.Parse(typeof(ModalidadEntregaEnum), modalidad.ToString());
        }

        private EstadoGuiaEnum ConvertirEstadoGuia(Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum estado)
        {
            return (EstadoGuiaEnum)Enum.Parse(typeof(EstadoGuiaEnum), estado.ToString());
        }
    }
}