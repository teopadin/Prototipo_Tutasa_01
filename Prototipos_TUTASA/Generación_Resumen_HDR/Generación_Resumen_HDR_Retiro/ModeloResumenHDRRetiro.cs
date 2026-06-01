using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly ModeloGenerarHDRRetiro modeloBase = new ModeloGenerarHDRRetiro();
        private readonly List<ResumenHDRRetiro> resumenes = new List<ResumenHDRRetiro>();
        private List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro> hojasSeleccionadas = new List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro>();

        private List<TransportistaLocal> Fleteros
        {
            get { return modeloBase.Transportistas.Where(t => t.CD.IdCD == modeloBase.CdEmisor.IdCD).ToList(); }
        }

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRRetiro()
        {
            CargarHojasDeRutaDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal fletero, DateTime fecha, out List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro> hojas)
        {
            hojas = new List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro>();

            foreach (Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro hdr in modeloBase.HojasDeRuta)
            {
                if (hdr.Transportista.DniTransportista == fletero.DniTransportista
                    && hdr.FechaEmision.Date == fecha.Date
                    && hdr.Estado == EstadoHojaDeRutaRetiro.Generada)
                {
                    hojas.Add(hdr);
                }
            }

            hojas = hojas.OrderBy(h => h.NroHDR).ToList();
            return hojas.Count > 0;
        }

        public bool SeleccionarHojasAsignadas(TransportistaLocal fletero, DateTime fecha)
        {
            LimpiarSeleccion();

            if (!BuscarHojasAsignadas(fletero, fecha, out List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro> hojas))
            {
                return false;
            }

            hojasSeleccionadas = hojas;
            return true;
        }

        public List<TransportistaLocal> ObtenerFleterosConHojasAsignadas(DateTime fecha)
        {
            var fleterosConHojas = new List<TransportistaLocal>();

            foreach (TransportistaLocal fletero in Fleteros)
            {
                if (BuscarHojasAsignadas(fletero, fecha, out _))
                {
                    fleterosConHojas.Add(fletero);
                }
            }

            return fleterosConHojas;
        }

        private DatosRetiroResumen ObtenerDatosRetiro(Guia guia)
        {
            if (guia.ModalidadEntrega == ModalidadEntrega.PuertaAPuerta)
            {
                return new DatosRetiroResumen
                {
                    Nombre = guia.Cliente.RazonSocial,
                    Calle = guia.Cliente.Calle,
                    Altura = guia.Cliente.Altura,
                    CodigoPostal = guia.Cliente.CodigoPostal
                };
            }

            return new DatosRetiroResumen
            {
                Nombre = guia.Agencia.RazonSocial,
                Calle = guia.Agencia.Calle,
                Altura = guia.Agencia.Altura,
                CodigoPostal = guia.Agencia.CodigoPostal
            };
        }

        public List<DatosRetiroResumen> ObtenerDatosHojasSeleccionadas()
        {
            var datosHojas = new List<DatosRetiroResumen>();

            foreach (Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro hoja in hojasSeleccionadas)
            {
                if (hoja.Guias == null || hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosRetiroResumen datos = ObtenerDatosRetiro(hoja.Guias[0]);
                datos.NroHDR = hoja.NroHDR;
                datos.CantidadBultos = CalcularTotalBultos(hoja);
                datosHojas.Add(datos);
            }

            return datosHojas;
        }

        private int CalcularTotalBultos(Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro hoja)
        {
            if (hoja.Guias == null)
            {
                return 0;
            }

            return hoja.Guias.Count;
        }

        private int CalcularTotalBultos(List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro> hojas)
        {
            int total = 0;

            foreach (Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro hoja in hojas)
            {
                total += CalcularTotalBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro hoja in hojas)
            {
                if (hoja.Guias == null || hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosRetiroResumen datos = ObtenerDatosRetiro(hoja.Guias[0]);
                domicilios.Add(datos.ClaveDomicilio);
            }

            return domicilios.Count;
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
                FechaGeneracion = DateTime.Now,
                TotalDomicilios = TotalDomiciliosSeleccionados,
                TotalBultos = TotalBultosSeleccionados
            };

            foreach (Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaRetiro.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro>();
        }

        private void CargarHojasDeRutaDePrueba()
        {
            if (!BuscarTransportista(12345678, out TransportistaLocal carlos))
            {
                return;
            }

            bool existeLaura = BuscarTransportista(23456789, out TransportistaLocal laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, PrepararGuias("CD01-0001", "CD01-0002"));
            AgregarHojaDeRuta(2, DateTime.Today, carlos, PrepararGuias("A001-0001", "A001-0002"));

            if (existeLaura)
            {
                AgregarHojaDeRuta(3, DateTime.Today, laura, PrepararGuias("A002-0001"));
            }
        }

        private bool BuscarTransportista(int dni, out TransportistaLocal transportistaEncontrado)
        {
            foreach (TransportistaLocal transportista in modeloBase.Transportistas)
            {
                if (transportista.DniTransportista == dni)
                {
                    transportistaEncontrado = transportista;
                    return true;
                }
            }

            transportistaEncontrado = new TransportistaLocal();
            return false;
        }

        private bool BuscarGuia(string nroGuia, out Guia guiaEncontrada)
        {
            foreach (Guia guia in modeloBase.Guias)
            {
                if (string.Equals(guia.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase))
                {
                    guiaEncontrada = guia;
                    return true;
                }
            }

            guiaEncontrada = new Guia();
            return false;
        }

        private List<Guia> PrepararGuias(params string[] numerosGuia)
        {
            var guias = new List<Guia>();

            foreach (string nroGuia in numerosGuia)
            {
                if (BuscarGuia(nroGuia, out Guia guia))
                {
                    guia.Estado = EstadoGuia.PendienteDeRetiroPorTransportista;
                    guias.Add(guia);
                }
            }

            return guias;
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal fletero, List<Guia> guias)
        {
            if (guias.Count == 0)
            {
                return;
            }

            modeloBase.HojasDeRuta.Add(new Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro
            {
                NroHDR = nroHDR,
                FechaEmision = fecha,
                CdEmisor = modeloBase.CdEmisor,
                Transportista = fletero,
                Guias = guias,
                Estado = EstadoHojaDeRutaRetiro.Generada
            });
        }
    }
}
