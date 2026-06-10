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
        private Dictionary<string, decimal> importesVentaPorGuia;
        private Dictionary<string, DateTime> fechasEntregaPorGuia;

        public ModeloResultadoCostoVSVentas()
        {
            EmpresasTransporte = new List<EmpresaTransporte>
            {
                new EmpresaTransporte { idEmpresa = 1, razonSocial = "Transportes del Sur SA", convenioVigente = true },
                new EmpresaTransporte { idEmpresa = 2, razonSocial = "Logística Norte SRL", convenioVigente = true },
                new EmpresaTransporte { idEmpresa = 3, razonSocial = "Rápido del Este", convenioVigente = true }
            };

            Servicios = new List<ServicioMediaDistancia>
            {
                CrearServicio("SMD-001", 1, new DateTime(2026, 5, 3), 1, 2, 42),
                CrearServicio("SMD-002", 2, new DateTime(2026, 5, 10), 1, 3, 37),
                CrearServicio("SMD-003", 1, new DateTime(2026, 4, 20), 1, 2, 45),
                CrearServicio("SMD-004", 1, new DateTime(2026, 3, 15), 1, 2, 38),
                CrearServicio("SMD-005", 2, new DateTime(2026, 3, 22), 1, 3, 35),
                CrearServicio("SMD-006", 2, new DateTime(2026, 2, 8), 1, 3, 36),
                CrearServicio("SMD-007", 1, new DateTime(2026, 1, 12), 1, 2, 44)
            };

            HojasDeRutaTransporte = new List<HojaDeRutaTransporte>
            {
                CrearHDR(100, "SMD-001", new DateTime(2026, 5, 3), 1, 2, "CD01-0001", "CD01-0002", "CD01-0003"),
                CrearHDR(101, "SMD-002", new DateTime(2026, 5, 10), 1, 3, "CD02-0001"),
                CrearHDR(102, "SMD-003", new DateTime(2026, 4, 20), 1, 2, "CD01-0090"),
                CrearHDR(103, "SMD-004", new DateTime(2026, 3, 15), 1, 2, "CD01-0080", "CD01-0081"),
                CrearHDR(104, "SMD-005", new DateTime(2026, 3, 22), 1, 3, "CD02-0080"),
                CrearHDR(105, "SMD-006", new DateTime(2026, 2, 8), 1, 3, "CD02-0070", "CD02-0071"),
                CrearHDR(106, "SMD-007", new DateTime(2026, 1, 12), 1, 2, "CD01-0060", "CD01-0061")
            };

            ArrendamientosBodega = new List<ArrendamientoBodega>
            {
                CrearArrendamiento(1, "SMD-001", new DateTime(2026, 5, 1), TipoArrendamientoEnum.A, 26000),
                CrearArrendamiento(2, "SMD-002", new DateTime(2026, 5, 1), TipoArrendamientoEnum.B, 18000),
                CrearArrendamiento(3, "SMD-003", new DateTime(2026, 4, 1), TipoArrendamientoEnum.A, 24000),
                CrearArrendamiento(4, "SMD-004", new DateTime(2026, 3, 1), TipoArrendamientoEnum.A, 23500),
                CrearArrendamiento(5, "SMD-005", new DateTime(2026, 3, 1), TipoArrendamientoEnum.B, 18500),
                CrearArrendamiento(6, "SMD-006", new DateTime(2026, 2, 1), TipoArrendamientoEnum.B, 19500),
                CrearArrendamiento(7, "SMD-007", new DateTime(2026, 1, 1), TipoArrendamientoEnum.A, 22500)
            };

            importesVentaPorGuia = new Dictionary<string, decimal>
            {
                { "CD01-0001", 15000 }, { "CD01-0002", 21000 }, { "CD01-0003", 18000 },
                { "CD02-0001", 30000 }, { "CD01-0090", 19000 }, { "CD01-0080", 22000 },
                { "CD01-0081", 17500 }, { "CD02-0080", 28700 }, { "CD02-0070", 26500 },
                { "CD02-0071", 31200 }, { "CD01-0060", 20500 }, { "CD01-0061", 18500 }
            };

            fechasEntregaPorGuia = new Dictionary<string, DateTime>
            {
                { "CD01-0001", new DateTime(2026, 5, 5) }, { "CD01-0002", new DateTime(2026, 5, 6) },
                { "CD01-0003", DateTime.MinValue }, { "CD02-0001", new DateTime(2026, 5, 12) },
                { "CD01-0090", new DateTime(2026, 4, 22) }, { "CD01-0080", new DateTime(2026, 3, 18) },
                { "CD01-0081", new DateTime(2026, 3, 20) }, { "CD02-0080", new DateTime(2026, 3, 25) },
                { "CD02-0070", new DateTime(2026, 2, 11) }, { "CD02-0071", new DateTime(2026, 2, 13) },
                { "CD01-0060", new DateTime(2026, 1, 14) }, { "CD01-0061", new DateTime(2026, 1, 16) }
            };
        }

        public List<EmpresaTransporte> ObtenerEmpresasTransporte()
        {
            return EmpresasTransporte
                .Where(e => e.convenioVigente)
                .OrderBy(e => e.razonSocial)
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

            decimal ventas = ObtenerVentas(empresa.idEmpresa, periodo);
            decimal costos = ObtenerCostos(empresa.idEmpresa, periodo);

            if (ventas == 0 && costos == 0)
                return null;

            return new ResultadoCostoVenta
            {
                IdEmpresa = empresa.idEmpresa,
                Periodo = new DateTime(periodo.Year, periodo.Month, 1),
                Ventas = ventas,
                Costos = costos
            };
        }

        private decimal ObtenerVentas(int idEmpresa, DateTime periodo)
        {
            decimal totalVentas = 0;
            List<string> idsServicioEmpresa = Servicios
                .Where(s => s.IdEmpresa == idEmpresa)
                .Select(s => s.IdServicio)
                .ToList();

            foreach (HojaDeRutaTransporte hdr in HojasDeRutaTransporte)
            {
                if (!idsServicioEmpresa.Contains(hdr.idServicio))
                    continue;

                if (hdr.Estado != EstadoHojaDeRutaEnum.Cumplida)
                    continue;

                foreach (string nroGuia in hdr.detalleGuias)
                {
                    if (!fechasEntregaPorGuia.ContainsKey(nroGuia))
                        continue;

                    DateTime fechaEntrega = fechasEntregaPorGuia[nroGuia];
                    if (fechaEntrega == DateTime.MinValue)
                        continue;

                    if (fechaEntrega.Year != periodo.Year || fechaEntrega.Month != periodo.Month)
                        continue;

                    totalVentas += importesVentaPorGuia[nroGuia];
                }
            }

            return totalVentas;
        }

        private decimal ObtenerCostos(int idEmpresa, DateTime periodo)
        {
            decimal totalCostos = 0;
            List<string> idsServicioEmpresa = Servicios
                .Where(s => s.IdEmpresa == idEmpresa)
                .Select(s => s.IdServicio)
                .ToList();

            foreach (ArrendamientoBodega arrendamiento in ArrendamientosBodega)
            {
                if (!idsServicioEmpresa.Contains(arrendamiento.idServicio))
                    continue;

                if (arrendamiento.periodo.Year != periodo.Year || arrendamiento.periodo.Month != periodo.Month)
                    continue;

                totalCostos += arrendamiento.importeMensual;
            }

            return totalCostos;
        }

        private ServicioMediaDistancia CrearServicio(string idServicio, int idEmpresa, DateTime fechaSalida, int idCDOrigen, int idCDDestino, int capacidadDisponible)
        {
            return new ServicioMediaDistancia
            {
                IdServicio = idServicio,
                IdEmpresa = idEmpresa,
                FechaSalida = fechaSalida,
                FechaLlegada = fechaSalida.AddDays(1),
                FechaRecepcion = fechaSalida.AddDays(2),
                CapacidadDisponible = capacidadDisponible,
                IdCDOrigen = idCDOrigen,
                IdCDDestino = idCDDestino
            };
        }

        private HojaDeRutaTransporte CrearHDR(int nroHDR, string idServicio, DateTime fechaGeneracion, int idCDOrigen, int idCDDestino, params string[] guias)
        {
            HojaDeRutaTransporte hdr = new HojaDeRutaTransporte
            {
                nroHDR = nroHDR,
                fechaGeneracion = fechaGeneracion,
                idCDOrigen = idCDOrigen,
                idCDDestino = idCDDestino,
                Estado = EstadoHojaDeRutaEnum.Cumplida,
                idServicio = idServicio,
                detalleGuias = guias.ToList()
            };

            ServicioMediaDistancia servicio = Servicios.FirstOrDefault(s => s.IdServicio == idServicio);
            if (servicio != null)
            {
                servicio.DetalleHDRs.Add(nroHDR);
            }

            return hdr;
        }

        private ArrendamientoBodega CrearArrendamiento(int id, string idServicio, DateTime periodo, TipoArrendamientoEnum tipo, decimal importeMensual)
        {
            return new ArrendamientoBodega
            {
                idArrendamiento = id,
                idServicio = idServicio,
                periodo = periodo,
                tipoArrendamiento = tipo,
                importeMensual = importeMensual
            };
        }
    }
}
