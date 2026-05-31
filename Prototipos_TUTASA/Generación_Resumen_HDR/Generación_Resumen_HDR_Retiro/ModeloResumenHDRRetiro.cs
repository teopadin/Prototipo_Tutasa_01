using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly ModeloGenerarHDRRetiro modeloBase = new ModeloGenerarHDRRetiro();
        private readonly List<ResumenHDRRetiroEntidad> resumenes = new List<ResumenHDRRetiroEntidad>();

        public List<TransportistaLocalEntidad> Fleteros
        {
            get { return modeloBase.Transportistas.Where(t => t.CD.IdCD == modeloBase.CdEmisor.IdCD).ToList(); }
        }

        public ModeloResumenHDRRetiro()
        {
            CargarHojasDeRutaDePrueba();
        }

        public bool BuscarHojasAsignadas(TransportistaLocalEntidad fletero, DateTime fecha, out List<HojaDeRutaRetiroEntidad> hojas)
        {
            hojas = new List<HojaDeRutaRetiroEntidad>();

            foreach (HojaDeRutaRetiroEntidad hdr in modeloBase.HojasDeRuta)
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

        public DatosRetiroResumen ObtenerDatosRetiro(GuiaEntidad guia)
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

        public int CalcularTotalBultos(HojaDeRutaRetiroEntidad hoja)
        {
            if (hoja.Guias == null)
            {
                return 0;
            }

            return hoja.Guias.Count;
        }

        public int CalcularTotalBultos(List<HojaDeRutaRetiroEntidad> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaRetiroEntidad hoja in hojas)
            {
                total += CalcularTotalBultos(hoja);
            }

            return total;
        }

        public int CalcularTotalDomicilios(List<HojaDeRutaRetiroEntidad> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaRetiroEntidad hoja in hojas)
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

        public ResumenHDRRetiroEntidad GenerarResumen(List<HojaDeRutaRetiroEntidad> hojas)
        {
            ResumenHDRRetiroEntidad resumen = new ResumenHDRRetiroEntidad
            {
                NroResumen = resumenes.Count + 1,
                FechaGeneracion = DateTime.Now,
                HojasDeRuta = new List<HojaDeRutaRetiroEntidad>(hojas),
                Fletero = hojas[0].Transportista,
                TotalDomicilios = CalcularTotalDomicilios(hojas),
                TotalBultos = CalcularTotalBultos(hojas)
            };

            resumenes.Add(resumen);
            return resumen;
        }

        private void CargarHojasDeRutaDePrueba()
        {
            if (!BuscarTransportista(12345678, out TransportistaLocalEntidad carlos))
            {
                return;
            }

            bool existeLaura = BuscarTransportista(23456789, out TransportistaLocalEntidad laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, PrepararGuias("CD01-0001", "CD01-0002"));
            AgregarHojaDeRuta(2, DateTime.Today, carlos, PrepararGuias("A001-0001", "A001-0002"));

            if (existeLaura)
            {
                AgregarHojaDeRuta(3, DateTime.Today, laura, PrepararGuias("A002-0001"));
            }
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
                    guia.Estado = EstadoGuia.PendienteDeRetiroPorTransportista;
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

            modeloBase.HojasDeRuta.Add(new HojaDeRutaRetiroEntidad
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
