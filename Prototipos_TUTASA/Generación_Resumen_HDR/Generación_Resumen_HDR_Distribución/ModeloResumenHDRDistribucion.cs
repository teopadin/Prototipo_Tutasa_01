using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.ClasesResumenHDRDistribucion;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRDistribucion
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaDeRutaDistribucion> hojasDeRuta = new List<HojaDeRutaDistribucion>();
        private readonly List<ResumenHDRDistribucion> resumenes = new List<ResumenHDRDistribucion>();
        private List<HojaDeRutaDistribucion> hojasSeleccionadas = new List<HojaDeRutaDistribucion>();

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRDistribucion()
        {
            CargarDatosDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaDeRutaDistribucion> hojas)
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

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaDeRutaDistribucion> hojas))
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

        public List<HojaDeRutaDistribucion> ObtenerHojasSeleccionadas()
        {
            return hojasSeleccionadas.ToList();
        }

        public bool GenerarResumen(out ResumenHDRDistribucion resumen, out string mensaje)
        {
            resumen = new ResumenHDRDistribucion();
            mensaje = string.Empty;

            if (!HayHojasSeleccionadas)
            {
                mensaje = "No hay Hojas de Ruta de Distribución asignadas al fletero para la fecha seleccionada.";
                return false;
            }

            resumen = new ResumenHDRDistribucion
            {
                NroResumen = resumenes.Count + 1,
                TotalDomicilios = TotalDomiciliosSeleccionados,
                TotalBultos = TotalBultosSeleccionados
            };

            foreach (HojaDeRutaDistribucion hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaEnum.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaDeRutaDistribucion>();
        }

        public int ObtenerCantidadBultos(HojaDeRutaDistribucion hoja)
        {
            return hoja.DetalleGuias.Count;
        }

        private int CalcularTotalBultos(List<HojaDeRutaDistribucion> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaDistribucion hoja in hojas)
            {
                total += ObtenerCantidadBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaDeRutaDistribucion> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaDistribucion hoja in hojas)
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    continue;
                }

                domicilios.Add(ObtenerClaveDomicilio(hoja.DetalleGuias[0]));
            }

            return domicilios.Count;
        }

        private string ObtenerClaveDomicilio(DetalleGuiaDistribucion guia)
        {
            return $"{guia.Calle}|{guia.Altura}|{guia.CodigoPostal}".ToUpperInvariant();
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez" };
            var laura = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<DetalleGuiaDistribucion>
            {
                new DetalleGuiaDistribucion { Destinatario = "Ana Perez", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" },
                new DetalleGuiaDistribucion { Destinatario = "Ana Perez", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<DetalleGuiaDistribucion>
            {
                new DetalleGuiaDistribucion { Destinatario = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" },
                new DetalleGuiaDistribucion { Destinatario = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<DetalleGuiaDistribucion>
            {
                new DetalleGuiaDistribucion { Destinatario = "Luis Gomez", Calle = "Belgrano", Altura = 750, CodigoPostal = "5000" }
            });

            AgregarHojaDeRuta(4, DateTime.Today.AddDays(1), carlos, new List<DetalleGuiaDistribucion>
            {
                new DetalleGuiaDistribucion { Destinatario = "Agencia Sur SRL", Calle = "San Martin", Altura = 500, CodigoPostal = "1043" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<DetalleGuiaDistribucion> detalleGuias)
        {
            hojasDeRuta.Add(new HojaDeRutaDistribucion
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
