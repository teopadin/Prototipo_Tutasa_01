using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.ClasesResumenHDRRetiro;
using HojaRetiroResumen = Prototipos_TUTASA.ClasesResumenHDRRetiro.HojaDeRutaRetiro;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaRetiroResumen> hojasDeRuta = new List<HojaRetiroResumen>();
        private readonly List<ResumenHDRRetiro> resumenes = new List<ResumenHDRRetiro>();
        private List<HojaRetiroResumen> hojasSeleccionadas = new List<HojaRetiroResumen>();

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRRetiro()
        {
            CargarDatosDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaRetiroResumen> hojas)
        {
            hojas = hojasDeRuta
                .Where(h => h.DniTransportistaAsignado == transportista.DniTransportista
                    && h.FechaEmision.Date == fecha.Date
                    && h.Estado == EstadoHojaDeRutaEnum.Generada)
                .OrderBy(h => h.NroHDR)
                .ToList();

            return hojas.Count > 0;
        }

        public bool SeleccionarHojasAsignadas(TransportistaLocal transportista, DateTime fecha)
        {
            LimpiarSeleccion();

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaRetiroResumen> hojas))
            {
                return false;
            }

            hojasSeleccionadas = hojas;
            return true;
        }

        public List<TransportistaLocal> ObtenerTransportistasConHojasAsignadas(DateTime fecha)
        {
            var transportistasConHojas = new List<TransportistaLocal>();

            foreach (TransportistaLocal transportista in transportistas)
            {
                if (BuscarHojasAsignadas(transportista, fecha, out _))
                {
                    transportistasConHojas.Add(transportista);
                }
            }

            return transportistasConHojas;
        }

        public List<HojaRetiroResumen> ObtenerHojasSeleccionadas()
        {
            return hojasSeleccionadas.ToList();
        }

        public bool GenerarResumen(out ResumenHDRRetiro resumen, out string mensaje)
        {
            resumen = new ResumenHDRRetiro();
            mensaje = string.Empty;

            if (!HayHojasSeleccionadas)
            {
                mensaje = "No hay Hojas de Ruta de Retiro asignadas al fletero para la fecha seleccionada.";
                return false;
            }

            resumen = new ResumenHDRRetiro
            {
                NroResumen = resumenes.Count + 1,
                TotalDomicilios = TotalDomiciliosSeleccionados,
                TotalBultos = TotalBultosSeleccionados
            };

            foreach (HojaRetiroResumen hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaEnum.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaRetiroResumen>();
        }

        public int ObtenerCantidadBultos(HojaRetiroResumen hoja)
        {
            return hoja.DetalleGuias.Count;
        }

        private int CalcularTotalBultos(List<HojaRetiroResumen> hojas)
        {
            int total = 0;

            foreach (HojaRetiroResumen hoja in hojas)
            {
                total += ObtenerCantidadBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaRetiroResumen> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaRetiroResumen hoja in hojas)
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    continue;
                }

                domicilios.Add(ObtenerClaveDomicilio(hoja.DetalleGuias[0]));
            }

            return domicilios.Count;
        }

        private string ObtenerClaveDomicilio(Cliente guia)
        {
            return $"{guia.Calle}|{guia.Altura}|{guia.CodigoPostal}".ToUpperInvariant();
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez" };
            var laura = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<Cliente>
            {
                new Cliente { Remitente = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" },
                new Cliente { Remitente = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<Cliente>
            {
                new Cliente { Remitente = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" },
                new Cliente { Remitente = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<Cliente>
            {
                new Cliente { Remitente = "Agencia Sur SRL", Calle = "San Martin", Altura = 500, CodigoPostal = "1043" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<Cliente> detalleGuias)
        {
            hojasDeRuta.Add(new HojaRetiroResumen
            {
                NroHDR = nroHDR,
                FechaEmision = fecha,
                DniTransportistaAsignado = transportista.DniTransportista,
                DetalleGuias = detalleGuias,
                Estado = EstadoHojaDeRutaEnum.Generada
            });
        }
    }
}
