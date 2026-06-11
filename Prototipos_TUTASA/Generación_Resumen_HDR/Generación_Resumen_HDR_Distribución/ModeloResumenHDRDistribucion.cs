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
        private List<HojaDeRutaDistribucion> hojasSeleccionadas = new List<HojaDeRutaDistribucion>();
        private int ultimoNroResumen;

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);
        public int UltimoNroResumenGenerado => ultimoNroResumen;

        public ModeloResumenHDRDistribucion()
        {
            CargarDatosDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaDeRutaDistribucion> hojas)
        {
            hojas = hojasDeRuta
                .Where(h => h.dniTransportistaAsignado == transportista.dniTransportista
                    && h.Fecha.Date == fecha.Date
                    && h.estado == EstadoHojaDeRutaEnum.Generada)
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

        public bool GenerarResumen(out string mensaje)
        {
            mensaje = string.Empty;

            if (!HayHojasSeleccionadas)
            {
                mensaje = "No hay Hojas de Ruta de Distribución asignadas al fletero para la fecha seleccionada.";
                return false;
            }

            ultimoNroResumen++;

            foreach (HojaDeRutaDistribucion hoja in hojasSeleccionadas)
            {
                hoja.estado = EstadoHojaDeRutaEnum.EnCurso;
            }

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

        private string ObtenerClaveDomicilio(DestinatarioGuia guia)
        {
            return $"{guia.calle}|{guia.altura}|{guia.codigoPostal}".ToUpperInvariant();
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { dniTransportista = 12345678, nombre = "Carlos", apellido = "Gomez" };
            var laura = new TransportistaLocal { dniTransportista = 23456789, nombre = "Laura", apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 40123456, calle = "Av. Rivadavia", altura = 3200, codigoPostal = "1406" },
                new DestinatarioGuia { Dni = 40123456, calle = "Av. Rivadavia", altura = 3200, codigoPostal = "1406" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 0, calle = "Av. Corrientes", altura = 1234, codigoPostal = "1043" },
                new DestinatarioGuia { Dni = 0, calle = "Av. Corrientes", altura = 1234, codigoPostal = "1043" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 42345678, calle = "Belgrano", altura = 750, codigoPostal = "5000" }
            });

            AgregarHojaDeRuta(4, DateTime.Today.AddDays(1), carlos, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 0, calle = "San Martin", altura = 500, codigoPostal = "1043" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<DestinatarioGuia> detalleGuias)
        {
            hojasDeRuta.Add(new HojaDeRutaDistribucion
            {
                NroHDR = nroHDR,
                Fecha = fecha,
                dniTransportistaAsignado = transportista.dniTransportista,
                DetalleGuias = detalleGuias,
                estado = EstadoHojaDeRutaEnum.Generada
            });
        }
    }
}
