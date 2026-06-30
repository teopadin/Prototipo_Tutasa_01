using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.Almacenes;
using EstadoHojaDeRutaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum;
using TipoBultoAlmacen = Prototipos_TUTASA.Auxiliares.TiposBultoEnum;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class ModeloRecibirHDRRetiroAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public HojaDeRutaRetiro HdrActual { get; set; }

        public List<HojaDeRutaRetiro> HojasDeRutaRetiro { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public List<Guia> Guias { get; set; }
        public List<Agencia> Agencias { get; set; }

        public ModeloRecibirHDRRetiroAgencia()
        {
            CargarTransportistas();
            CargarAgencias();
            CargarGuias();
            CargarHojasDeRutaRetiro();
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

        private void CargarGuias()
        {
            Guias = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    TipoBulto = ConvertirTipoBulto(guiaEntidad.TipoBulto),
                    idAgenciaOrigen = guiaEntidad.idAgenciaOrigen
                });
            }
        }

        private void CargarHojasDeRutaRetiro()
        {
            HojasDeRutaRetiro = new List<HojaDeRutaRetiro>();

            foreach (HojaDeRutaRetiroEntidad hojaEntidad in HojaDeRutaRetiroAlmacen.hojasDeRutaRetiro)
            {
                HojasDeRutaRetiro.Add(new HojaDeRutaRetiro
                {
                    NroHDR = hojaEntidad.NroHDR,
                    Fecha = hojaEntidad.Fecha,
                    idAgenciaOrigen = hojaEntidad.idAgenciaOrigen,
                    dniTransportistaAsignado = hojaEntidad.dniTransportistaAsignado,
                    estado = ConvertirEstadoHojaDeRuta(hojaEntidad.estado),
                    DetalleGuias = new List<string>(hojaEntidad.DetalleGuias)
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

            // Busco la ENTIDAD REAL del Almacén y la modifico
            HojaDeRutaRetiroEntidad hojaEntidad = HojaDeRutaRetiroAlmacen.hojasDeRutaRetiro
                .FirstOrDefault(h => h.NroHDR == HdrActual.NroHDR);

            if (hojaEntidad != null)
            {
                hojaEntidad.Fecha = fechaRecepcion;
                hojaEntidad.estado = EstadoHojaDeRutaAlmacen.Recibida;
            }

            HojaDeRutaRetiroAlmacen.Guardar();
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
