using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototipos_TUTASA.Almacenes;

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
            EmpresasTransporte = new List<EmpresaTransporte>();
            foreach (var empresaEntidad in EmpresaTransporteAlmacen.empresas)
            {
                EmpresasTransporte.Add(new EmpresaTransporte
                {
                    idEmpresa = empresaEntidad.idEmpresa,
                    razonSocial = empresaEntidad.razonSocial,
                    convenioVigente = empresaEntidad.convenioVigente
                });
            }

            Servicios = new List<ServicioMediaDistancia>();
            foreach (var servicioEntidad in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
            {
                Servicios.Add(new ServicioMediaDistancia
                {
                    idServicio = servicioEntidad.idServicio,
                    idEmpresa = servicioEntidad.idEmpresa,
                    DetalleHDRs = servicioEntidad.DetalleHDRs != null
                        ? new List<int>(servicioEntidad.DetalleHDRs)
                        : new List<int>()
                });
            }

            HojasDeRutaTransporte = new List<HojaDeRutaTransporte>();
            foreach (var hdrEntidad in HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte)
            {
                HojasDeRutaTransporte.Add(new HojaDeRutaTransporte
                {
                    nroHDR = hdrEntidad.nroHDR,
                    idServicio = hdrEntidad.idServicio,
                    DetalleGuias = hdrEntidad.DetalleGuias != null
                        ? new List<string>(hdrEntidad.DetalleGuias)
                        : new List<string>()
                });
            }

            ArrendamientosBodega = new List<ArrendamientoBodega>();
            foreach (var arrendamientoEntidad in ArrendamientoBodegaAlmacen.arrendamientos)
            {
                ArrendamientosBodega.Add(new ArrendamientoBodega
                {
                    idArrendamiento = arrendamientoEntidad.idArrendamiento,
                    idEmpresa = arrendamientoEntidad.idEmpresa,
                    periodo = arrendamientoEntidad.periodo,
                    importeMensual = arrendamientoEntidad.importeMensual
                });
            }

            Guias = new List<Guia>();
            foreach (var guiaEntidad in GuiaAlmacen.Guias)
            {
                Guias.Add(MapearGuia(guiaEntidad));
            }
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

                        if (fechaEntrega == DateTime.MinValue)
                            continue;

                        if (fechaEntrega.Year != periodo.Year || fechaEntrega.Month != periodo.Month)
                            continue;

                        if (guia.TarifaCalculada == null)
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

        private HojaDeRutaTransporte BuscarHDR(int nroHDR)
        {
            foreach (HojaDeRutaTransporte hdr in HojasDeRutaTransporte)
            {
                if (hdr.nroHDR == nroHDR)
                    return hdr;
            }
            return null;
        }

        private Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia guia in Guias)
            {
                if (guia.NroGuia == nroGuia)
                    return guia;
            }
            return null;
        }

        private DateTime ObtenerFechaEntrega(Guia guia)
        {
            if (guia.Historial == null)
                return DateTime.MinValue;

            foreach (HistorialEstadoGuia registro in guia.Historial)
            {
                if (registro.Estado == EstadoGuiaEnum.Entregada)
                    return registro.FechaCambio;
            }
            return DateTime.MinValue;
        }

        private Guia MapearGuia(GuiaEntidad guiaEntidad)
        {
            Guia guia = new Guia
            {
                NroGuia = guiaEntidad.NroGuia,
                TarifaCalculada = new TarifaCalculadaGuia
                {
                    TarifaTotal = guiaEntidad.TarifaCalculada != null
                        ? guiaEntidad.TarifaCalculada.TarifaTotal
                        : 0
                },
                Historial = new List<HistorialEstadoGuia>()
            };

            if (guiaEntidad.Historial != null)
            {
                foreach (var historialEntidad in guiaEntidad.Historial)
                {
                    if (historialEntidad.Estado != Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Entregada)
                        continue;

                    guia.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = historialEntidad.FechaCambio,
                        Estado = EstadoGuiaEnum.Entregada
                    });
                }
            }

            return guia;
        }
    }
}
