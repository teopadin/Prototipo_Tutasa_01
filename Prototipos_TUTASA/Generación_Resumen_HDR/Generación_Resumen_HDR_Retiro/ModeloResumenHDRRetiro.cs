using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.ClasesResumenHDRRetiro;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaDeRutaRetiro> hojasDeRuta = new List<HojaDeRutaRetiro>();
        private readonly List<ResumenHDRRetiro> resumenes = new List<ResumenHDRRetiro>();
        private List<HojaDeRutaRetiro> hojasSeleccionadas = new List<HojaDeRutaRetiro>();

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRRetiro()
        {
            CargarDatosDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaDeRutaRetiro> hojas)
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

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaDeRutaRetiro> hojas))
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

        public List<HojaDeRutaRetiro> ObtenerHojasSeleccionadas()
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

            foreach (HojaDeRutaRetiro hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaEnum.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaDeRutaRetiro>();
        }

        public int ObtenerCantidadBultos(HojaDeRutaRetiro hoja)
        {
            return hoja.Guias.Count;
        }

        private int CalcularTotalBultos(List<HojaDeRutaRetiro> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaRetiro hoja in hojas)
            {
                total += ObtenerCantidadBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaDeRutaRetiro> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaRetiro hoja in hojas)
            {
                if (hoja.Guias.Count == 0)
                {
                    continue;
                }

                domicilios.Add(ObtenerClaveDomicilio(hoja.Guias[0]));
            }

            return domicilios.Count;
        }

        private string ObtenerClaveDomicilio(Guia guia)
        {
            return $"{guia.Calle}|{guia.Altura}|{guia.CodigoPostal}".ToUpperInvariant();
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez" };
            var laura = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<Guia>
            {
                new Guia { Remitente = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" },
                new Guia { Remitente = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<Guia>
            {
                new Guia { Remitente = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" },
                new Guia { Remitente = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<Guia>
            {
                new Guia { Remitente = "Agencia Sur SRL", Calle = "San Martin", Altura = 500, CodigoPostal = "1043" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<Guia> guias)
        {
            hojasDeRuta.Add(new HojaDeRutaRetiro
            {
                NroHDR = nroHDR,
                FechaEmision = fecha,
                DniTransportistaAsignado = transportista.DniTransportista,
                Guias = guias,
                Estado = EstadoHojaDeRutaEnum.Generada
            });
        }
    }
}
