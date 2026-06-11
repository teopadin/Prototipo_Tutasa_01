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
        public List<Guia> Guias { get; set; }

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
                CrearServicio("SMD-001", 1), CrearServicio("SMD-002", 2), CrearServicio("SMD-003", 1),
                CrearServicio("SMD-004", 1), CrearServicio("SMD-005", 2), CrearServicio("SMD-006", 2),
                CrearServicio("SMD-007", 1), CrearServicio("SMD-008", 3), CrearServicio("SMD-009", 4),
                CrearServicio("SMD-010", 3), CrearServicio("SMD-011", 4), CrearServicio("SMD-012", 3),
                CrearServicio("SMD-013", 4), CrearServicio("SMD-014", 3), CrearServicio("SMD-015", 4)
            };

            HojasDeRutaTransporte = new List<HojaDeRutaTransporte>
            {
                CrearHDR(100, "SMD-001", "CD01-0001", "CD01-0002", "CD01-0003"),
                CrearHDR(101, "SMD-002", "CD02-0001"),
                CrearHDR(102, "SMD-003", "CD01-0090"),
                CrearHDR(103, "SMD-004", "CD01-0080", "CD01-0081"),
                CrearHDR(104, "SMD-005", "CD02-0080"),
                CrearHDR(105, "SMD-006", "CD02-0070", "CD02-0071"),
                CrearHDR(106, "SMD-007", "CD01-0060", "CD01-0061"),
                CrearHDR(107, "SMD-008", "CD03-0100", "CD03-0101"),
                CrearHDR(108, "SMD-009", "CD04-0100", "CD04-0101", "CD04-0102"),
                CrearHDR(109, "SMD-010", "CD03-0090", "CD03-0091"),
                CrearHDR(110, "SMD-011", "CD04-0090"),
                CrearHDR(111, "SMD-012", "CD03-0080", "CD03-0081", "CD03-0082"),
                CrearHDR(112, "SMD-013", "CD04-0080", "CD04-0081"),
                CrearHDR(113, "SMD-014", "CD03-0070"),
                CrearHDR(114, "SMD-015", "CD04-0070", "CD04-0071")
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

            // Guías con su tarifa calculada y su historial.
            // La fecha MinValue significa "no entregada" → no se le registra el estado Entregada.
            Guias = new List<Guia>
            {
                CrearGuia("CD01-0001", 15000, new DateTime(2026, 5, 5)),
                CrearGuia("CD01-0002", 21000, new DateTime(2026, 5, 6)),
                CrearGuia("CD01-0003", 18000, DateTime.MinValue),
                CrearGuia("CD02-0001", 30000, new DateTime(2026, 5, 12)),
                CrearGuia("CD01-0090", 19000, new DateTime(2026, 4, 22)),
                CrearGuia("CD01-0080", 22000, new DateTime(2026, 3, 18)),
                CrearGuia("CD01-0081", 17500, new DateTime(2026, 3, 20)),
                CrearGuia("CD02-0080", 28700, new DateTime(2026, 3, 25)),
                CrearGuia("CD02-0070", 26500, new DateTime(2026, 2, 11)),
                CrearGuia("CD02-0071", 31200, new DateTime(2026, 2, 13)),
                CrearGuia("CD01-0060", 20500, new DateTime(2026, 1, 14)),
                CrearGuia("CD01-0061", 18500, new DateTime(2026, 1, 16)),
                CrearGuia("CD03-0100", 33400, new DateTime(2026, 6, 4)),
                CrearGuia("CD03-0101", 29800, new DateTime(2026, 6, 5)),
                CrearGuia("CD04-0100", 24100, new DateTime(2026, 6, 8)),
                CrearGuia("CD04-0101", 26700, new DateTime(2026, 6, 9)),
                CrearGuia("CD04-0102", 31000, DateTime.MinValue),
                CrearGuia("CD03-0090", 22500, new DateTime(2026, 5, 20)),
                CrearGuia("CD03-0091", 28600, new DateTime(2026, 5, 21)),
                CrearGuia("CD04-0090", 35700, new DateTime(2026, 5, 27)),
                CrearGuia("CD03-0080", 19200, new DateTime(2026, 4, 10)),
                CrearGuia("CD03-0081", 21300, new DateTime(2026, 4, 11)),
                CrearGuia("CD03-0082", 24900, new DateTime(2026, 4, 12)),
                CrearGuia("CD04-0080", 27600, new DateTime(2026, 4, 16)),
                CrearGuia("CD04-0081", 22800, new DateTime(2026, 4, 18)),
                CrearGuia("CD03-0070", 30400, new DateTime(2026, 3, 8)),
                CrearGuia("CD04-0070", 26300, new DateTime(2026, 2, 22)),
                CrearGuia("CD04-0071", 29200, new DateTime(2026, 2, 23))
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

        // Ventas: empresa -> servicios -> sus HDR (DetalleHDRs) -> guías de la HDR -> tarifa de cada guía entregada en el periodo
        private decimal ObtenerVentas(int idEmpresa, DateTime periodo)
        {
            decimal totalVentas = 0;

            foreach (ServicioMediaDistancia servicio in Servicios)
            {
                if (servicio.idEmpresa != idEmpresa)
                    continue;

                foreach (int nroHDR in servicio.DetalleHDRs)
                {
                    HojaDeRutaTransporte hdr = BuscarHDR(nroHDR);
                    if (hdr == null)
                        continue;

                    foreach (string nroGuia in hdr.DetalleGuias)
                    {
                        Guia guia = BuscarGuia(nroGuia);
                        if (guia == null)
                            continue;

                        DateTime fechaEntrega = ObtenerFechaEntrega(guia);

                        // Si no tiene fecha de entrega, la guía no se entregó todavía
                        if (fechaEntrega == DateTime.MinValue)
                            continue;

                        // Solo cuentan las entregas del periodo consultado
                        if (fechaEntrega.Year != periodo.Year || fechaEntrega.Month != periodo.Month)
                            continue;

                        totalVentas += guia.TarifaCalculada.TarifaTotal;
                    }
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

        // Busca una HDR por su número. Devuelve null si no existe.
        private HojaDeRutaTransporte BuscarHDR(int nroHDR)
        {
            foreach (HojaDeRutaTransporte hdr in HojasDeRutaTransporte)
            {
                if (hdr.nroHDR == nroHDR)
                    return hdr;
            }
            return null;
        }

        // Busca una guía por su número. Devuelve null si no existe.
        private Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia guia in Guias)
            {
                if (guia.NroGuia == nroGuia)
                    return guia;
            }
            return null;
        }

        // Obtiene la fecha de entrega de una guía desde su historial (estado Entregada).
        // Devuelve MinValue si la guía no fue entregada.
        private DateTime ObtenerFechaEntrega(Guia guia)
        {
            foreach (HistorialEstadoGuia registro in guia.Historial)
            {
                if (registro.Estado == EstadoGuiaEnum.Entregada)
                    return registro.FechaCambio;
            }
            return DateTime.MinValue;
        }

        private ServicioMediaDistancia CrearServicio(string idServicio, int idEmpresa)
        {
            return new ServicioMediaDistancia
            {
                idServicio = idServicio,
                idEmpresa = idEmpresa
            };
        }

        private HojaDeRutaTransporte CrearHDR(int nroHDR, string idServicio, params string[] guias)
        {
            HojaDeRutaTransporte hdr = new HojaDeRutaTransporte
            {
                nroHDR = nroHDR,
                idServicio = idServicio,
                DetalleGuias = guias.ToList()
            };

            ServicioMediaDistancia servicio = Servicios.FirstOrDefault(s => s.idServicio == idServicio);

            if (servicio != null)
                servicio.DetalleHDRs.Add(nroHDR);

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

        private Guia CrearGuia(string nroGuia, decimal tarifaTotal, DateTime fechaEntrega)
        {
            Guia guia = new Guia
            {
                NroGuia = nroGuia,
                TarifaCalculada = new TarifaCalculadaGuia { TarifaTotal = tarifaTotal },
                Historial = new List<HistorialEstadoGuia>()
            };

            // Solo registra la entrega si efectivamente se entregó
            if (fechaEntrega != DateTime.MinValue)
            {
                guia.Historial.Add(new HistorialEstadoGuia
                {
                    FechaCambio = fechaEntrega,
                    Estado = EstadoGuiaEnum.Entregada
                });
            }

            return guia;
        }
    }
}