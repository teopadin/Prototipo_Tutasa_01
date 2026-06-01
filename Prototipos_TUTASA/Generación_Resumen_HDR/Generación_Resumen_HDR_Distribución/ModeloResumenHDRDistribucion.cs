using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRDistribucion
    {
        private readonly ModeloGenerarHDRDistribucion modeloBase = new ModeloGenerarHDRDistribucion();
        private readonly List<ResumenHDRDistribucion> resumenes = new List<ResumenHDRDistribucion>();
        private List<HojaDeRutaDistribucionEntidad> hojasSeleccionadas = new List<HojaDeRutaDistribucionEntidad>();

        private List<TransportistaLocalEntidad> Fleteros
        {
            get { return modeloBase.Transportistas.Where(t => t.CD.IdCD == modeloBase.CdEmisor.IdCD).ToList(); }
        }

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRDistribucion()
        {
            CargarHojasDeRutaDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocalEntidad fletero, DateTime fecha, out List<HojaDeRutaDistribucionEntidad> hojas)
        {
            hojas = new List<HojaDeRutaDistribucionEntidad>();

            foreach (HojaDeRutaDistribucionEntidad hdr in modeloBase.HojasDeRuta)
            {
                if (hdr.Transportista.DniTransportista == fletero.DniTransportista
                    && hdr.FechaEmision.Date == fecha.Date
                    && hdr.Estado == EstadoHojaDeRutaDistribucion.Generada)
                {
                    hojas.Add(hdr);
                }
            }

            hojas = hojas.OrderBy(h => h.NroHDR).ToList();
            return hojas.Count > 0;
        }

        public bool SeleccionarHojasAsignadas(TransportistaLocalEntidad fletero, DateTime fecha)
        {
            LimpiarSeleccion();

            if (!BuscarHojasAsignadas(fletero, fecha, out List<HojaDeRutaDistribucionEntidad> hojas))
            {
                return false;
            }

            hojasSeleccionadas = hojas;
            return true;
        }

        public List<TransportistaLocalEntidad> ObtenerFleterosConHojasAsignadas(DateTime fecha)
        {
            var fleterosConHojas = new List<TransportistaLocalEntidad>();

            foreach (TransportistaLocalEntidad fletero in Fleteros)
            {
                if (BuscarHojasAsignadas(fletero, fecha, out _))
                {
                    fleterosConHojas.Add(fletero);
                }
            }

            return fleterosConHojas;
        }

        private DatosDestinoResumen ObtenerDatosDestino(GuiaEntidad guia)
        {
            if (guia.ModalidadEntrega == ModalidadEntrega.PuertaAPuerta)
            {
                return new DatosDestinoResumen
                {
                    Nombre = $"{guia.Destinatario.Nombre} {guia.Destinatario.Apellido}",
                    Calle = guia.Destinatario.Calle,
                    Altura = guia.Destinatario.Altura,
                    CodigoPostal = guia.Destinatario.CodigoPostal
                };
            }

            return new DatosDestinoResumen
            {
                Nombre = guia.Agencia.RazonSocial,
                Calle = guia.Agencia.Calle,
                Altura = guia.Agencia.Altura,
                CodigoPostal = guia.Agencia.CodigoPostal
            };
        }

        public List<DatosDestinoResumen> ObtenerDatosHojasSeleccionadas()
        {
            var datosHojas = new List<DatosDestinoResumen>();

            foreach (HojaDeRutaDistribucionEntidad hoja in hojasSeleccionadas)
            {
                if (hoja.Guias == null || hoja.Guias.Count == 0)
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

        private int CalcularTotalBultos(HojaDeRutaDistribucionEntidad hoja)
        {
            if (hoja.Guias == null)
            {
                return 0;
            }

            return hoja.Guias.Count;
        }

        private int CalcularTotalBultos(List<HojaDeRutaDistribucionEntidad> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaDistribucionEntidad hoja in hojas)
            {
                total += CalcularTotalBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaDeRutaDistribucionEntidad> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaDistribucionEntidad hoja in hojas)
            {
                if (hoja.Guias == null || hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosDestinoResumen datos = ObtenerDatosDestino(hoja.Guias[0]);
                domicilios.Add(datos.ClaveDomicilio);
            }

            return domicilios.Count;
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

            foreach (HojaDeRutaDistribucionEntidad hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaDistribucion.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaDeRutaDistribucionEntidad>();
        }

        private void CargarHojasDeRutaDePrueba()
        {
            if (!BuscarTransportista(12345678, out TransportistaLocalEntidad carlos))
            {
                return;
            }

            bool existeLaura = BuscarTransportista(23456789, out TransportistaLocalEntidad laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, PrepararGuias("CD03-0001", "CD03-0002"));
            AgregarHojaDeRuta(2, DateTime.Today, carlos, PrepararGuias("A001-0001", "A001-0002"));

            if (existeLaura)
            {
                AgregarHojaDeRuta(3, DateTime.Today, laura, PrepararGuias("CD02-0001"));
            }

            AgregarHojaDeRuta(4, DateTime.Today.AddDays(1), carlos, PrepararGuias("A002-0001"));
        }

        private bool BuscarTransportista(int dni, out TransportistaLocalEntidad transportistaEncontrado)
        {
            foreach (TransportistaLocalEntidad transportista in modeloBase.Transportistas)
            {
                if (transportista.DniTransportista == dni)
                {
                    transportistaEncontrado = transportista;
                    return true;
                }
            }

            transportistaEncontrado = new TransportistaLocalEntidad();
            return false;
        }

        private bool BuscarGuia(string nroGuia, out GuiaEntidad guiaEncontrada)
        {
            foreach (GuiaEntidad guia in modeloBase.Guias)
            {
                if (string.Equals(guia.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase))
                {
                    guiaEncontrada = guia;
                    return true;
                }
            }

            guiaEncontrada = new GuiaEntidad();
            return false;
        }

        private List<GuiaEntidad> PrepararGuias(params string[] numerosGuia)
        {
            var guias = new List<GuiaEntidad>();

            foreach (string nroGuia in numerosGuia)
            {
                if (BuscarGuia(nroGuia, out GuiaEntidad guia))
                {
                    guia.Estado = EstadoGuia.EnDistribucion;
                    guias.Add(guia);
                }
            }

            return guias;
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocalEntidad fletero, List<GuiaEntidad> guias)
        {
            if (guias.Count == 0)
            {
                return;
            }

            modeloBase.HojasDeRuta.Add(new HojaDeRutaDistribucionEntidad
            {
                NroHDR = nroHDR,
                FechaEmision = fecha,
                CdEmisor = modeloBase.CdEmisor,
                Transportista = fletero,
                Guias = guias,
                Estado = EstadoHojaDeRutaDistribucion.Generada
            });
        }
    }
}
