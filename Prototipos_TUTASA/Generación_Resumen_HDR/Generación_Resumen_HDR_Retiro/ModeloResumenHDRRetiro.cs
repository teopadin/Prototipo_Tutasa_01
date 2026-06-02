using System;
using System.Collections.Generic;
using System.Linq;
using TransportistaLocal = Prototipos_TUTASA.ClasesResumenHDRRetiro.TransportistaLocal;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaDeRutaRetiroResumen> hojasDeRuta = new List<HojaDeRutaRetiroResumen>();
        private readonly List<ResumenHDRRetiro> resumenes = new List<ResumenHDRRetiro>();
        private List<HojaDeRutaRetiroResumen> hojasSeleccionadas = new List<HojaDeRutaRetiroResumen>();

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);

        public ModeloResumenHDRRetiro()
        {
            CargarDatosDePrueba();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaDeRutaRetiroResumen> hojas)
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

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaDeRutaRetiroResumen> hojas))
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

        public List<DatosRetiroResumen> ObtenerDatosHojasSeleccionadas()
        {
            var datosHojas = new List<DatosRetiroResumen>();

            foreach (HojaDeRutaRetiroResumen hoja in hojasSeleccionadas)
            {
                if (hoja.Guias.Count == 0)
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

            foreach (HojaDeRutaRetiroResumen hoja in hojasSeleccionadas)
            {
                hoja.Estado = EstadoHojaDeRutaResumen.EnCurso;
            }

            resumenes.Add(resumen);
            LimpiarSeleccion();
            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaDeRutaRetiroResumen>();
        }

        private DatosRetiroResumen ObtenerDatosRetiro(GuiaRetiroResumen guia)
        {
            return new DatosRetiroResumen
            {
                Nombre = guia.Remitente,
                Calle = guia.Calle,
                Altura = guia.Altura,
                CodigoPostal = guia.CodigoPostal
            };
        }

        private int CalcularTotalBultos(HojaDeRutaRetiroResumen hoja)
        {
            return hoja.Guias.Count;
        }

        private int CalcularTotalBultos(List<HojaDeRutaRetiroResumen> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaRetiroResumen hoja in hojas)
            {
                total += CalcularTotalBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaDeRutaRetiroResumen> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaRetiroResumen hoja in hojas)
            {
                if (hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosRetiroResumen datos = ObtenerDatosRetiro(hoja.Guias[0]);
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

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<GuiaRetiroResumen>
            {
                new GuiaRetiroResumen { NroGuia = "CD01-0001", Remitente = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" },
                new GuiaRetiroResumen { NroGuia = "CD01-0002", Remitente = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, CodigoPostal = "1406" }
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<GuiaRetiroResumen>
            {
                new GuiaRetiroResumen { NroGuia = "A001-0001", Remitente = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" },
                new GuiaRetiroResumen { NroGuia = "A001-0002", Remitente = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, CodigoPostal = "1043" }
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<GuiaRetiroResumen>
            {
                new GuiaRetiroResumen { NroGuia = "A002-0001", Remitente = "Agencia Sur SRL", Calle = "San Martin", Altura = 500, CodigoPostal = "1043" }
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<GuiaRetiroResumen> guias)
        {
            hojasDeRuta.Add(new HojaDeRutaRetiroResumen
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
