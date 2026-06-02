using System;
using System.Collections.Generic;
using System.Linq;
using TransportistaLocal = Prototipos_TUTASA.ClasesResumenHDRDistribucion.TransportistaLocal;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRDistribucion
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaDeRutaDistribucionResumen> hojasDeRuta = new List<HojaDeRutaDistribucionResumen>();
        private readonly List<ResumenHDRDistribucion> resumenes = new List<ResumenHDRDistribucion>();
        private List<HojaDeRutaDistribucionResumen> hojasSeleccionadas = new List<HojaDeRutaDistribucionResumen>();

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRDistribucion()
        {
            CargarDatosDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaDeRutaDistribucionResumen> hojas)
        {
            hojas = hojasDeRuta
                .Where(h => h.Transportista.DniTransportista == transportista.DniTransportista
                    && h.FechaEmision.Date == fecha.Date
                    && h.Estado == EstadoHojaDeRutaResumen.Generada)
                .OrderBy(h => h.NroHDR)
                .ToList();

            return hojas.Count > 0;
        }

        public bool SeleccionarHojasAsignadas(TransportistaLocal transportista, DateTime fecha)
        {
            LimpiarSeleccion();

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaDeRutaDistribucionResumen> hojas))
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

        public List<DatosDestinoResumen> ObtenerDatosHojasSeleccionadas()
        {
            var datosHojas = new List<DatosDestinoResumen>();

            foreach (HojaDeRutaDistribucionResumen hoja in hojasSeleccionadas)
            {
                if (hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosDestinoResumen datos = ObtenerDatosDestino(hoja.Guias[0]);
                datos.NroHDR = hoja.NroHDR;
                datos.CantidadBultos = CalcularTotalBultos(hoja);
                datosHojas.Add(datos);
            }

            return datosHojas;
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
                FechaGeneracion = DateTime.Now,
                TotalDomicilios = TotalDomiciliosSeleccionados,
                TotalBultos = TotalBultosSeleccionados
            };

            foreach (HojaDeRutaDistribucionResumen hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaResumen.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaDeRutaDistribucionResumen>();
        }

        private DatosDestinoResumen ObtenerDatosDestino(GuiaDistribucionResumen guia)
        {
            return new DatosDestinoResumen
            {
                Nombre = guia.Destinatario,
                Calle = guia.Calle,
                Altura = guia.Altura,
                CodigoPostal = guia.CodigoPostal
            };
        }

        private int CalcularTotalBultos(HojaDeRutaDistribucionResumen hoja)
        {
            return hoja.Guias.Count;
        }

        private int CalcularTotalBultos(List<HojaDeRutaDistribucionResumen> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaDistribucionResumen hoja in hojas)
            {
                total += CalcularTotalBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaDeRutaDistribucionResumen> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaDistribucionResumen hoja in hojas)
            {
                if (hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosDestinoResumen datos = ObtenerDatosDestino(hoja.Guias[0]);
                domicilios.Add(datos.ClaveDomicilio);
            }

            return domicilios.Count;
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez" };
            var laura = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<GuiaDistribucionResumen>
            {
                new GuiaDistribucionResumen { NroGuia = "CD03-0001", Destinatario = "Ana Perez", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" },
                new GuiaDistribucionResumen { NroGuia = "CD03-0002", Destinatario = "Ana Perez", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<GuiaDistribucionResumen>
            {
                new GuiaDistribucionResumen { NroGuia = "A001-0001", Destinatario = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" },
                new GuiaDistribucionResumen { NroGuia = "A001-0002", Destinatario = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<GuiaDistribucionResumen>
            {
                new GuiaDistribucionResumen { NroGuia = "CD02-0001", Destinatario = "Luis Gomez", Calle = "Belgrano", Altura = 750, CodigoPostal = "5000" }
            });

            AgregarHojaDeRuta(4, DateTime.Today.AddDays(1), carlos, new List<GuiaDistribucionResumen>
            {
                new GuiaDistribucionResumen { NroGuia = "A002-0001", Destinatario = "Agencia Sur SRL", Calle = "San Martin", Altura = 500, CodigoPostal = "1043" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<GuiaDistribucionResumen> guias)
        {
            hojasDeRuta.Add(new HojaDeRutaDistribucionResumen
            {
                NroHDR = nroHDR,
                FechaEmision = fecha,
                Transportista = transportista,
                Guias = guias,
                Estado = EstadoHojaDeRutaResumen.Generada
            });
        }
    }
}
