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
                new EmpresaTransporte { idEmpresa = 3, razonSocial = "Rápido del Este", convenioVigente = true },
                new EmpresaTransporte { idEmpresa = 4, razonSocial = "Expreso Mediterráneo", convenioVigente = true },
                new EmpresaTransporte { idEmpresa = 5, razonSocial = "Cargas Patagonia SRL", convenioVigente = false }
            };

            Servicios = new List<ServicioMediaDistancia>
            {
                CrearServicio("SMD-001", 1, new DateTime(2026, 5, 3), 1, 2, 42),
                CrearServicio("SMD-002", 2, new DateTime(2026, 5, 10), 1, 3, 37),
                CrearServicio("SMD-003", 1, new DateTime(2026, 4, 20), 1, 2, 45),
                CrearServicio("SMD-004", 1, new DateTime(2026, 3, 15), 1, 2, 38),
                CrearServicio("SMD-005", 2, new DateTime(2026, 3, 22), 1, 3, 35),
                CrearServicio("SMD-006", 2, new DateTime(2026, 2, 8), 1, 3, 36),
                CrearServicio("SMD-007", 1, new DateTime(2026, 1, 12), 1, 2, 44),
                CrearServicio("SMD-008", 3, new DateTime(2026, 6, 2), 2, 4, 40),
                CrearServicio("SMD-009", 4, new DateTime(2026, 6, 6), 1, 4, 32),
                CrearServicio("SMD-010", 3, new DateTime(2026, 5, 18), 2, 3, 28),
                CrearServicio("SMD-011", 4, new DateTime(2026, 5, 24), 1, 2, 31),
                CrearServicio("SMD-012", 3, new DateTime(2026, 4, 8), 2, 4, 39),
                CrearServicio("SMD-013", 4, new DateTime(2026, 4, 14), 1, 3, 34),
                CrearServicio("SMD-014", 3, new DateTime(2026, 3, 5), 2, 3, 30),
                CrearServicio("SMD-015", 4, new DateTime(2026, 2, 19), 1, 4, 29)
            };

            HojasDeRutaTransporte = new List<HojaDeRutaTransporte>
            {
                CrearHDR(100, "SMD-001", new DateTime(2026, 5, 3), 1, 2, "CD01-0001", "CD01-0002", "CD01-0003"),
                CrearHDR(101, "SMD-002", new DateTime(2026, 5, 10), 1, 3, "CD02-0001"),
                CrearHDR(102, "SMD-003", new DateTime(2026, 4, 20), 1, 2, "CD01-0090"),
                CrearHDR(103, "SMD-004", new DateTime(2026, 3, 15), 1, 2, "CD01-0080", "CD01-0081"),
                CrearHDR(104, "SMD-005", new DateTime(2026, 3, 22), 1, 3, "CD02-0080"),
                CrearHDR(105, "SMD-006", new DateTime(2026, 2, 8), 1, 3, "CD02-0070", "CD02-0071"),
                CrearHDR(106, "SMD-007", new DateTime(2026, 1, 12), 1, 2, "CD01-0060", "CD01-0061"),
                CrearHDR(107, "SMD-008", new DateTime(2026, 6, 2), 2, 4, "CD03-0100", "CD03-0101"),
                CrearHDR(108, "SMD-009", new DateTime(2026, 6, 6), 1, 4, "CD04-0100", "CD04-0101", "CD04-0102"),
                CrearHDR(109, "SMD-010", new DateTime(2026, 5, 18), 2, 3, "CD03-0090", "CD03-0091"),
                CrearHDR(110, "SMD-011", new DateTime(2026, 5, 24), 1, 2, "CD04-0090"),
                CrearHDR(111, "SMD-012", new DateTime(2026, 4, 8), 2, 4, "CD03-0080", "CD03-0081", "CD03-0082"),
                CrearHDR(112, "SMD-013", new DateTime(2026, 4, 14), 1, 3, "CD04-0080", "CD04-0081"),
                CrearHDR(113, "SMD-014", new DateTime(2026, 3, 5), 2, 3, "CD03-0070"),
                CrearHDR(114, "SMD-015", new DateTime(2026, 2, 19), 1, 4, "CD04-0070", "CD04-0071")
            };

            ArrendamientosBodega = new List<ArrendamientoBodega>
            {
                CrearArrendamiento(1, 1, new DateTime(2026, 5, 1), 26000),
                CrearArrendamiento(2, 2, new DateTime(2026, 5, 1), 18000),
                CrearArrendamiento(3, 1, new DateTime(2026, 4, 1), 24000),
                CrearArrendamiento(4, 1, new DateTime(2026, 3, 1), 23500),
                CrearArrendamiento(5, 2, new DateTime(2026, 3, 1), 18500),
                CrearArrendamiento(6, 2, new DateTime(2026, 2, 1), 19500),
                CrearArrendamiento(7, 1, new DateTime(2026, 1, 1), 22500),
                CrearArrendamiento(8, 3, new DateTime(2026, 6, 1), 27500),
                CrearArrendamiento(9, 4, new DateTime(2026, 6, 1), 22400),
                CrearArrendamiento(10, 3, new DateTime(2026, 5, 1), 25100),
                CrearArrendamiento(11, 4, new DateTime(2026, 5, 1), 20900),
                CrearArrendamiento(12, 3, new DateTime(2026, 4, 1), 24600),
                CrearArrendamiento(13, 4, new DateTime(2026, 4, 1), 19800),
                CrearArrendamiento(14, 3, new DateTime(2026, 3, 1), 23200),
                CrearArrendamiento(15, 4, new DateTime(2026, 2, 1), 21400)
            };

            importesVentaPorGuia = new Dictionary<string, decimal>
            {
                { "CD01-0001", 15000 }, { "CD01-0002", 21000 }, { "CD01-0003", 18000 },
                { "CD02-0001", 30000 }, { "CD01-0090", 19000 }, { "CD01-0080", 22000 },
                { "CD01-0081", 17500 }, { "CD02-0080", 28700 }, { "CD02-0070", 26500 },
                { "CD02-0071", 31200 }, { "CD01-0060", 20500 }, { "CD01-0061", 18500 },
                { "CD03-0100", 33400 }, { "CD03-0101", 29800 },
                { "CD04-0100", 24100 }, { "CD04-0101", 26700 }, { "CD04-0102", 31000 },
                { "CD03-0090", 22500 }, { "CD03-0091", 28600 },
                { "CD04-0090", 35700 },
                { "CD03-0080", 19200 }, { "CD03-0081", 21300 }, { "CD03-0082", 24900 },
                { "CD04-0080", 27600 }, { "CD04-0081", 22800 },
                { "CD03-0070", 30400 },
                { "CD04-0070", 26300 }, { "CD04-0071", 29200 }
            };

            fechasEntregaPorGuia = new Dictionary<string, DateTime>
            {
                { "CD01-0001", new DateTime(2026, 5, 5) }, { "CD01-0002", new DateTime(2026, 5, 6) },
                { "CD01-0003", DateTime.MinValue }, { "CD02-0001", new DateTime(2026, 5, 12) },
                { "CD01-0090", new DateTime(2026, 4, 22) }, { "CD01-0080", new DateTime(2026, 3, 18) },
                { "CD01-0081", new DateTime(2026, 3, 20) }, { "CD02-0080", new DateTime(2026, 3, 25) },
                { "CD02-0070", new DateTime(2026, 2, 11) }, { "CD02-0071", new DateTime(2026, 2, 13) },
                { "CD01-0060", new DateTime(2026, 1, 14) }, { "CD01-0061", new DateTime(2026, 1, 16) },
                { "CD03-0100", new DateTime(2026, 6, 4) }, { "CD03-0101", new DateTime(2026, 6, 5) },
                { "CD04-0100", new DateTime(2026, 6, 8) }, { "CD04-0101", new DateTime(2026, 6, 9) },
                { "CD04-0102", DateTime.MinValue },
                { "CD03-0090", new DateTime(2026, 5, 20) }, { "CD03-0091", new DateTime(2026, 5, 21) },
                { "CD04-0090", new DateTime(2026, 5, 27) },
                { "CD03-0080", new DateTime(2026, 4, 10) }, { "CD03-0081", new DateTime(2026, 4, 11) },
                { "CD03-0082", new DateTime(2026, 4, 12) },
                { "CD04-0080", new DateTime(2026, 4, 16) }, { "CD04-0081", new DateTime(2026, 4, 18) },
                { "CD03-0070", new DateTime(2026, 3, 8) },
                { "CD04-0070", new DateTime(2026, 2, 22) }, { "CD04-0071", new DateTime(2026, 2, 23) }
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
                idEmpresa = empresa.idEmpresa,
                Periodo = new DateTime(periodo.Year, periodo.Month, 1),
                Ventas = ventas,
                Costos = costos
            };
        }

        private decimal ObtenerVentas(int idEmpresa, DateTime periodo)
        {
            decimal totalVentas = 0;

            List<string> idsServicioEmpresa = Servicios
                .Where(s => s.idEmpresa == idEmpresa)
                .Select(s => s.idServicio)
                .ToList();

            foreach (HojaDeRutaTransporte hdr in HojasDeRutaTransporte)
            {
                if (!idsServicioEmpresa.Contains(hdr.idServicio))
                    continue;


                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    if (!fechasEntregaPorGuia.ContainsKey(nroGuia))
                        continue;

                    if (!importesVentaPorGuia.ContainsKey(nroGuia))
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

            foreach (ArrendamientoBodega arrendamiento in ArrendamientosBodega)
            {
                if (arrendamiento.idEmpresa != idEmpresa)
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
                idServicio = idServicio,
                idEmpresa = idEmpresa,

            };
        }

        private HojaDeRutaTransporte CrearHDR(int nroHDR, string idServicio, DateTime fechaGeneracion, int idCDOrigen, int idCDDestino, params string[] guias)
        {
            HojaDeRutaTransporte hdr = new HojaDeRutaTransporte
            {
                nroHDR = nroHDR,
                idServicio = idServicio,
                DetalleGuias = guias.ToList()
            };

            ServicioMediaDistancia servicio = Servicios.FirstOrDefault(s => s.idServicio == idServicio);

            if (servicio != null)
            {
                servicio.DetalleHDRs.Add(nroHDR);
            }

            return hdr;
        }

        private ArrendamientoBodega CrearArrendamiento(int id, int idEmpresa, DateTime periodo, decimal importeMensual)
        {
            return new ArrendamientoBodega
            {
                idArrendamiento = id,
                idEmpresa = idEmpresa,
                periodo = periodo,
                importeMensual = importeMensual
            };
        }
    }
}