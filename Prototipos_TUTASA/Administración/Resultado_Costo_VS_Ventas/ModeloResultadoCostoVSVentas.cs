using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ModeloResultadoCostoVSVentas
    {
        public List<EmpresaTransporteEntidad> EmpresasTransporte { get; set; }
        public List<ServicioMediaDistanciaEntidad> Servicios { get; set; }
        public List<HojaDeRutaTransporteEntidad> HojasDeRutaTransporte { get; set; }
        public List<ArrendamientoBodegaEntidad> ArrendamientosBodega { get; set; }

        public ModeloResultadoCostoVSVentas()
        {
            EmpresaTransporteEntidad empresaSur = new EmpresaTransporteEntidad { IdEmpresa = 1, RazonSocial = "Transportes del Sur SA", ConvenioVigente = true };
            EmpresaTransporteEntidad empresaNorte = new EmpresaTransporteEntidad { IdEmpresa = 2, RazonSocial = "Logística Norte SRL", ConvenioVigente = true };
            EmpresaTransporteEntidad empresaEste = new EmpresaTransporteEntidad { IdEmpresa = 3, RazonSocial = "Rápido del Este", ConvenioVigente = true };

            EmpresasTransporte = new List<EmpresaTransporteEntidad>
            {
                empresaSur, empresaNorte, empresaEste
            };

            ServicioMediaDistanciaEntidad servicioSur = new ServicioMediaDistanciaEntidad { IdServicio = 1, Empresa = empresaSur };
            ServicioMediaDistanciaEntidad servicioNorte = new ServicioMediaDistanciaEntidad { IdServicio = 2, Empresa = empresaNorte };

            Servicios = new List<ServicioMediaDistanciaEntidad>
            {
                servicioSur, servicioNorte
            };

            HojasDeRutaTransporte = new List<HojaDeRutaTransporteEntidad>
            {
                new HojaDeRutaTransporteEntidad
                {
                    NroHDR = 100,
                    FechaGeneracion = new DateTime(2026, 5, 3),
                    FechaDespacho = new DateTime(2026, 5, 3),
                    FechaRecepcion = new DateTime(2026, 5, 4),
                    Servicio = servicioSur,
                    Guias = new List<GuiaResultadoEntidad>
                    {
                        new GuiaResultadoEntidad { NroGuia = "CD01-0001", FechaImposicion = new DateTime(2026, 5, 1), FechaEntrega = new DateTime(2026, 5, 5), ImporteVenta = 15000, Estado = EstadoGuiaResultado.Entregada },
                        new GuiaResultadoEntidad { NroGuia = "CD01-0002", FechaImposicion = new DateTime(2026, 5, 2), FechaEntrega = new DateTime(2026, 5, 6), ImporteVenta = 21000, Estado = EstadoGuiaResultado.Entregada },
                        new GuiaResultadoEntidad { NroGuia = "CD01-0003", FechaImposicion = new DateTime(2026, 5, 2), FechaEntrega = DateTime.MinValue, ImporteVenta = 18000, Estado = EstadoGuiaResultado.EnTransito }
                    }
                },
                new HojaDeRutaTransporteEntidad
                {
                    NroHDR = 101,
                    FechaGeneracion = new DateTime(2026, 5, 10),
                    FechaDespacho = new DateTime(2026, 5, 10),
                    FechaRecepcion = new DateTime(2026, 5, 11),
                    Servicio = servicioNorte,
                    Guias = new List<GuiaResultadoEntidad>
                    {
                        new GuiaResultadoEntidad { NroGuia = "CD02-0001", FechaImposicion = new DateTime(2026, 5, 9), FechaEntrega = new DateTime(2026, 5, 12), ImporteVenta = 30000, Estado = EstadoGuiaResultado.Entregada }
                    }
                },
                new HojaDeRutaTransporteEntidad
                {
                    NroHDR = 102,
                    FechaGeneracion = new DateTime(2026, 4, 20),
                    FechaDespacho = new DateTime(2026, 4, 20),
                    FechaRecepcion = new DateTime(2026, 4, 21),
                    Servicio = servicioSur,
                    Guias = new List<GuiaResultadoEntidad>
                    {
                        new GuiaResultadoEntidad { NroGuia = "CD01-0090", FechaImposicion = new DateTime(2026, 4, 19), FechaEntrega = new DateTime(2026, 4, 22), ImporteVenta = 19000, Estado = EstadoGuiaResultado.Entregada }
                    }
                }
            };

            ArrendamientosBodega = new List<ArrendamientoBodegaEntidad>
            {
                new ArrendamientoBodegaEntidad { IdArrendamiento = 1, Empresa = empresaSur, Periodo = new DateTime(2026, 5, 1), ImporteMensual = 26000 },
                new ArrendamientoBodegaEntidad { IdArrendamiento = 2, Empresa = empresaNorte, Periodo = new DateTime(2026, 5, 1), ImporteMensual = 18000 },
                new ArrendamientoBodegaEntidad { IdArrendamiento = 3, Empresa = empresaSur, Periodo = new DateTime(2026, 4, 1), ImporteMensual = 24000 }
            };
        }

        public List<EmpresaTransporteEntidad> ObtenerEmpresasTransporte()
        {
            return EmpresasTransporte
                .Where(e => e.ConvenioVigente)
                .OrderBy(e => e.RazonSocial)
                .ToList();
        }

        public ResultadoCostoVentaEntidad ConsultarResultado(EmpresaTransporteEntidad empresa, DateTime periodo)
        {
            decimal ventas = ObtenerVentas(empresa, periodo);
            decimal costos = ObtenerCostos(empresa, periodo);

            if (ventas == 0 && costos == 0)
                return null;

            return new ResultadoCostoVentaEntidad
            {
                Empresa = empresa,
                Periodo = new DateTime(periodo.Year, periodo.Month, 1),
                Ventas = ventas,
                Costos = costos
            };
        }

        private decimal ObtenerVentas(EmpresaTransporteEntidad empresa, DateTime periodo)
        {
            decimal totalVentas = 0;

            foreach (HojaDeRutaTransporteEntidad hdr in HojasDeRutaTransporte)
            {
                if (hdr.Servicio.Empresa.IdEmpresa != empresa.IdEmpresa)
                    continue;

                foreach (GuiaResultadoEntidad guia in hdr.Guias)
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

        private decimal ObtenerCostos(EmpresaTransporteEntidad empresa, DateTime periodo)
        {
            decimal totalCostos = 0;

            foreach (ArrendamientoBodegaEntidad arrendamiento in ArrendamientosBodega)
            {
                if (arrendamiento.Empresa.IdEmpresa != empresa.IdEmpresa)
                    continue;

                if (arrendamiento.Periodo.Year != periodo.Year || arrendamiento.Periodo.Month != periodo.Month)
                    continue;

                totalCostos += arrendamiento.ImporteMensual;
            }

            return totalCostos;
        }
    }
}

// comentario santi 