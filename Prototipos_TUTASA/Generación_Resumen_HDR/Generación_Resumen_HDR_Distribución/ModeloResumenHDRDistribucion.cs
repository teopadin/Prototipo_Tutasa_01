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
                .Where(h => h.DniTransportistaAsignado == transportista.DniTransportista
                    && h.Fecha.Date == fecha.Date
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
                hoja.Estado = EstadoHojaDeRutaEnum.EnCurso;
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
            return $"{guia.Calle}|{guia.Altura}|{guia.CodigoPostal}".ToUpperInvariant();
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez" };
            var laura = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 40123456, Nombre = "Ana", Apellido = "Perez", Calle = "Av. Rivadavia", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" },
                new DestinatarioGuia { Dni = 40123456, Nombre = "Ana", Apellido = "Perez", Calle = "Av. Rivadavia", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 0, Nombre = "Agencia Norte SA", Apellido = string.Empty, Calle = "Av. Corrientes", Altura = 1234, Piso = "PB", CodigoPostal = "1043", Ciudad = "Buenos Aires" },
                new DestinatarioGuia { Dni = 0, Nombre = "Agencia Norte SA", Apellido = string.Empty, Calle = "Av. Corrientes", Altura = 1234, Piso = "PB", CodigoPostal = "1043", Ciudad = "Buenos Aires" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 42345678, Nombre = "Luis", Apellido = "Gomez", Calle = "Belgrano", Altura = 750, Piso = "PB", CodigoPostal = "5000", Ciudad = "Córdoba" }
            });

            AgregarHojaDeRuta(4, DateTime.Today.AddDays(1), carlos, new List<DestinatarioGuia>
            {
                new DestinatarioGuia { Dni = 0, Nombre = "Agencia Sur SRL", Apellido = string.Empty, Calle = "San Martin", Altura = 500, Piso = "1", CodigoPostal = "1043", Ciudad = "Buenos Aires" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<DestinatarioGuia> detalleGuias)
        {
            hojasDeRuta.Add(new HojaDeRutaDistribucion
            {
                NroHDR = nroHDR,
                Fecha = fecha,
                DniTransportistaAsignado = transportista.DniTransportista,
                DetalleGuias = detalleGuias,
                Estado = EstadoHojaDeRutaEnum.Generada
            });
        }
    }
}
