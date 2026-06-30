using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.Almacenes;
using EstadoGuiaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum;
using EstadoHojaDeRutaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum;
using TipoBultoAlmacen = Prototipos_TUTASA.Auxiliares.TiposBultoEnum;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class ModeloRecibirHDRDistribucionAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public List<HojaDeRutaDistribucion> HojasDeRutaDistribucion { get; set; }

        public HojaDeRutaDistribucion HdrActual { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public List<Guia> Guias { get; set; }
        public List<Agencia> Agencias { get; set; }

        public ModeloRecibirHDRDistribucionAgencia()
        {
            CargarAgencias();
            CargarTransportistas();
            CargarGuias();
            CargarHojasDeRutaDistribucion();
        }

        private void CargarAgencias()
        {
            Agencias = new List<Agencia>();

            foreach (AgenciaEntidad agenciaEntidad in AgenciaAlmacen.Agencias)
            {
                Agencias.Add(new Agencia
                {
                    idAgencia = agenciaEntidad.idAgencia,
                    razonSocial = agenciaEntidad.razonSocial
                });
            }

            AgenciaLogueada = BuscarAgencia(Program.CodigoAgenciaActual);

            if (AgenciaLogueada == null && Agencias.Count > 0)
            {
                AgenciaLogueada = Agencias[0];
            }
        }

        private void CargarTransportistas()
        {
            Transportistas = new List<TransportistaLocal>();

            foreach (TransportistaLocalEntidad transportistaEntidad in TransportistaLocalAlmacen.transportistas)
            {
                Transportistas.Add(new TransportistaLocal
                {
                    dniTransportistaAsignado = transportistaEntidad.dniTransportista,
                    nombre = transportistaEntidad.nombre,
                    apellido = transportistaEntidad.apellido
                });
            }
        }

        private void CargarGuias()
        {
            Guias = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    TipoBulto = ConvertirTipoBulto(guiaEntidad.TipoBulto),
                    idAgenciaDestino = guiaEntidad.idAgenciaDestino,
                    estado = ConvertirEstadoGuia(guiaEntidad.estado)
                });
            }
        }

        private void CargarHojasDeRutaDistribucion()
        {
            HojasDeRutaDistribucion = new List<HojaDeRutaDistribucion>();

            foreach (HojaDeRutaDistribucionEntidad hojaEntidad in HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion)
            {
                HojasDeRutaDistribucion.Add(new HojaDeRutaDistribucion
                {
                    NroHDR = hojaEntidad.NroHDR,
                    Fecha = hojaEntidad.Fecha,
                    idAgenciaDestino = hojaEntidad.idAgenciaDestino ?? BuscarAgenciaDestinoDesdeGuias(hojaEntidad.DetalleGuias),
                    dniTransportistaAsignado = hojaEntidad.dniTransportistaAsignado,
                    DetalleGuias = new List<string>(hojaEntidad.DetalleGuias),
                    estado = ConvertirEstadoHojaDeRuta(hojaEntidad.estado)
                });
            }
        }

        public TransportistaLocal BuscarTransportista(int dni)
        {
            return Transportistas.FirstOrDefault(t => t.dniTransportistaAsignado == dni);
        }
        public Guia BuscarGuia(string nroGuia)
        {
            return Guias.FirstOrDefault(g => g.NroGuia == nroGuia);
        }
        public Agencia BuscarAgencia(int? idAgencia)
        {
            return Agencias.FirstOrDefault(a => a.idAgencia == idAgencia);
        }

        private int BuscarAgenciaDestinoDesdeGuias(List<string> detalleGuias)
        {
            foreach (string nroGuia in detalleGuias)
            {
                Guia guia = BuscarGuia(nroGuia);

                if (guia != null && guia.idAgenciaDestino > 0)
                {
                    return guia.idAgenciaDestino;
                }
            }

            return 0;
        }

        public void ConfirmarRecepcion()
        {
            if (HdrActual == null)
            {
                return;
            }

            DateTime fechaRecepcion = DateTime.Now;

            // Actualizo el DTO para que la pantalla quede consistente
            HdrActual.Fecha = fechaRecepcion;
            HdrActual.estado = EstadoHojaDeRutaEnum.Recibida;

            // HDR: busco la ENTIDAD REAL del Almacén y la modifico
            HojaDeRutaDistribucionEntidad hojaEntidad = HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion
                .FirstOrDefault(h => h.NroHDR == HdrActual.NroHDR);

            if (hojaEntidad != null)
            {
                hojaEntidad.Fecha = fechaRecepcion;
                hojaEntidad.estado = EstadoHojaDeRutaAlmacen.Recibida;
            }

            // Guías: cada una pasa a PendienteDeRetiroEnAgencia en la entidad real
            foreach (string nroGuia in HdrActual.DetalleGuias)
            {
                // DTO (para la pantalla)
                Guia guiaDto = BuscarGuia(nroGuia);
                if (guiaDto != null)
                {
                    guiaDto.estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia;
                }

                // Entidad real del Almacén
                GuiaEntidad guiaEntidad = GuiaAlmacen.Guias
                    .FirstOrDefault(g => g.NroGuia == nroGuia);

                if (guiaEntidad != null)
                {
                    guiaEntidad.estado = EstadoGuiaAlmacen.PendienteDeRetiroEnAgencia;

                    guiaEntidad.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = fechaRecepcion,
                        Estado = EstadoGuiaAlmacen.PendienteDeRetiroEnAgencia,
                        Donde = AgenciaLogueada.razonSocial
                    });
                }
            }

            GuiaAlmacen.Guardar();
            HojaDeRutaDistribucionAlmacen.Guardar();
        }

        private static TiposBultoEnum ConvertirTipoBulto(TipoBultoAlmacen tipoBulto)
        {
            return tipoBulto switch
            {
                TipoBultoAlmacen.M => TiposBultoEnum.M,
                TipoBultoAlmacen.L => TiposBultoEnum.L,
                TipoBultoAlmacen.XL => TiposBultoEnum.XL,
                _ => TiposBultoEnum.S
            };
        }

        private static EstadoGuiaEnum ConvertirEstadoGuia(EstadoGuiaAlmacen estado)
        {
            if (estado == EstadoGuiaAlmacen.PendienteDeRetiroEnAgencia)
            {
                return EstadoGuiaEnum.PendienteDeRetiroEnAgencia;
            }

            return EstadoGuiaEnum.EnDistribucion;
        }

        private static EstadoHojaDeRutaEnum ConvertirEstadoHojaDeRuta(EstadoHojaDeRutaAlmacen estado)
        {
            if (estado == EstadoHojaDeRutaAlmacen.Recibida)
            {
                return EstadoHojaDeRutaEnum.Recibida;
            }

            return EstadoHojaDeRutaEnum.EnCurso;
        }
    }

}
