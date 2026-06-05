using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ModeloResultadoCostoVSVentas
    {
        public List<EmpresaTransporte> EmpresasTransporte { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public List<HojaDeRutaTransporte> HojasDeRutaTransporte { get; set; }
        public List<ArrendamientoBodega> ArrendamientosBodega { get; set; }

        public ModeloResultadoCostoVSVentas()
        {
            EmpresaTransporte empresaSur = new EmpresaTransporte { IdEmpresa = 1, RazonSocial = "Transportes del Sur SA", ConvenioVigente = true };
            EmpresaTransporte empresaNorte = new EmpresaTransporte { IdEmpresa = 2, RazonSocial = "Logística Norte SRL", ConvenioVigente = true };
            EmpresaTransporte empresaEste = new EmpresaTransporte { IdEmpresa = 3, RazonSocial = "Rápido del Este", ConvenioVigente = true };

            EmpresasTransporte = new List<EmpresaTransporte>
            {
                empresaSur, empresaNorte, empresaEste
            };

            ServicioMediaDistancia servicioSur = new ServicioMediaDistancia { IdServicio = 1, Empresa = empresaSur, TipoArrendamiento = TipoArrendamiento.A };
            ServicioMediaDistancia servicioNorte = new ServicioMediaDistancia { IdServicio = 2, Empresa = empresaNorte, TipoArrendamiento = TipoArrendamiento.B };

            Servicios = new List<ServicioMediaDistancia>
            {
                servicioSur, servicioNorte
            };

            HojasDeRutaTransporte = new List<HojaDeRutaTransporte>
            {
                CrearHDR(100, new DateTime(2026, 5, 3), servicioSur, new List<GuiaResultado>
                {
                    CrearGuia("CD01-0001", new DateTime(2026, 5, 1), new DateTime(2026, 5, 5), 15000, EstadoGuiaResultado.Entregada),
                    CrearGuia("CD01-0002", new DateTime(2026, 5, 2), new DateTime(2026, 5, 6), 21000, EstadoGuiaResultado.Entregada),
                    CrearGuia("CD01-0003", new DateTime(2026, 5, 2), DateTime.MinValue, 18000, EstadoGuiaResultado.EnTransito)
                }),
                CrearHDR(101, new DateTime(2026, 5, 10), servicioNorte, new List<GuiaResultado>
                {
                    CrearGuia("CD02-0001", new DateTime(2026, 5, 9), new DateTime(2026, 5, 12), 30000, EstadoGuiaResultado.Entregada)
                }),
                CrearHDR(102, new DateTime(2026, 4, 20), servicioSur, new List<GuiaResultado>
                {
                    CrearGuia("CD01-0090", new DateTime(2026, 4, 19), new DateTime(2026, 4, 22), 19000, EstadoGuiaResultado.Entregada)
                }),
                CrearHDR(103, new DateTime(2026, 3, 15), servicioSur, new List<GuiaResultado>
                {
                    CrearGuia("CD01-0080", new DateTime(2026, 3, 14), new DateTime(2026, 3, 18), 22000, EstadoGuiaResultado.Entregada),
                    CrearGuia("CD01-0081", new DateTime(2026, 3, 15), new DateTime(2026, 3, 20), 17500, EstadoGuiaResultado.Entregada)
                }),
                CrearHDR(104, new DateTime(2026, 3, 22), servicioNorte, new List<GuiaResultado>
                {
                    CrearGuia("CD02-0080", new DateTime(2026, 3, 21), new DateTime(2026, 3, 25), 28700, EstadoGuiaResultado.Entregada)
                }),
                CrearHDR(105, new DateTime(2026, 2, 8), servicioNorte, new List<GuiaResultado>
                {
                    CrearGuia("CD02-0070", new DateTime(2026, 2, 7), new DateTime(2026, 2, 11), 26500, EstadoGuiaResultado.Entregada),
                    CrearGuia("CD02-0071", new DateTime(2026, 2, 8), new DateTime(2026, 2, 13), 31200, EstadoGuiaResultado.Entregada)
                }),
                CrearHDR(106, new DateTime(2026, 1, 12), servicioSur, new List<GuiaResultado>
                {
                    CrearGuia("CD01-0060", new DateTime(2026, 1, 10), new DateTime(2026, 1, 14), 20500, EstadoGuiaResultado.Entregada),
                    CrearGuia("CD01-0061", new DateTime(2026, 1, 11), new DateTime(2026, 1, 16), 18500, EstadoGuiaResultado.Entregada)
                })
            };

            ArrendamientosBodega = new List<ArrendamientoBodega>
            {
                CrearArrendamiento(1, servicioSur, new DateTime(2026, 5, 1), 26000),
                CrearArrendamiento(2, servicioNorte, new DateTime(2026, 5, 1), 18000),
                CrearArrendamiento(3, servicioSur, new DateTime(2026, 4, 1), 24000),
                CrearArrendamiento(4, servicioSur, new DateTime(2026, 3, 1), 23500),
                CrearArrendamiento(5, servicioNorte, new DateTime(2026, 3, 1), 18500),
                CrearArrendamiento(6, servicioNorte, new DateTime(2026, 2, 1), 19500),
                CrearArrendamiento(7, servicioSur, new DateTime(2026, 1, 1), 22500)
            };
        }

        public List<EmpresaTransporte> ObtenerEmpresasTransporte()
        {
            return EmpresasTransporte
                .Where(e => e.ConvenioVigente)
                .OrderBy(e => e.RazonSocial)
                .ToList();
        }

        public bool PeriodoEsFuturo(DateTime periodo)
        {
            DateTime periodoNormalizado = new DateTime(periodo.Year, periodo.Month, 1);
            DateTime mesActual = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            return periodoNormalizado > mesActual;
        }

        public ResultadoCostoVenta ConsultarResultado(EmpresaTransporte empresa, DateTime periodo)
        {
            if (empresa == null || PeriodoEsFuturo(periodo))
                return null;

            decimal ventas = ObtenerVentas(empresa, periodo);
            decimal costos = ObtenerCostos(empresa, periodo);

            if (ventas == 0 && costos == 0)
                return null;

            return new ResultadoCostoVenta
            {
                Empresa = empresa,
                Periodo = new DateTime(periodo.Year, periodo.Month, 1),
                Ventas = ventas,
                Costos = costos
            };
        }

        private decimal ObtenerVentas(EmpresaTransporte empresa, DateTime periodo)
        {
            decimal totalVentas = 0;

            foreach (HojaDeRutaTransporte hdr in HojasDeRutaTransporte)
            {
                if (hdr.Servicio.Empresa.IdEmpresa != empresa.IdEmpresa)
                    continue;

                foreach (GuiaResultado guia in hdr.Guias)
                {
                    if (guia.Estado != EstadoGuiaResultado.Entregada)
                        continue;

                    if (guia.FechaEntrega.Year != periodo.Year || guia.FechaEntrega.Month != periodo.Month)
                        continue;

                    totalVentas += guia.ImporteVenta;
                }
            }

            return totalVentas;
        }

        private decimal ObtenerCostos(EmpresaTransporte empresa, DateTime periodo)
        {
            decimal totalCostos = 0;

            foreach (ArrendamientoBodega arrendamiento in ArrendamientosBodega)
            {
                if (arrendamiento.Servicio.Empresa.IdEmpresa != empresa.IdEmpresa)
                    continue;

                if (arrendamiento.Periodo.Year != periodo.Year || arrendamiento.Periodo.Month != periodo.Month)
                    continue;

                totalCostos += arrendamiento.ImporteMensual;
            }

            return totalCostos;
        }

        private HojaDeRutaTransporte CrearHDR(int nroHDR, DateTime fecha, ServicioMediaDistancia servicio, List<GuiaResultado> guias)
        {
            return new HojaDeRutaTransporte
            {
                NroHDR = nroHDR,
                FechaGeneracion = fecha,
                FechaDespacho = fecha,
                FechaRecepcion = fecha.AddDays(1),
                Servicio = servicio,
                Guias = guias
            };
        }

        private GuiaResultado CrearGuia(string nroGuia, DateTime fechaImposicion, DateTime fechaEntrega, decimal importeVenta, EstadoGuiaResultado estado)
        {
            return new GuiaResultado
            {
                NroGuia = nroGuia,
                FechaImposicion = fechaImposicion,
                FechaEntrega = fechaEntrega,
                ImporteVenta = importeVenta,
                Estado = estado
            };
        }

        private ArrendamientoBodega CrearArrendamiento(int id, ServicioMediaDistancia servicio, DateTime periodo, decimal importeMensual)
        {
            return new ArrendamientoBodega
            {
                IdArrendamiento = id,
                Servicio = servicio,
                Periodo = periodo,
                TipoArrendamiento = servicio.TipoArrendamiento,
                ImporteMensual = importeMensual
            };
        }
    }
}
