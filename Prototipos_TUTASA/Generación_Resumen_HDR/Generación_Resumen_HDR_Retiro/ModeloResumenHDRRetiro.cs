using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.Almacenes;
using Prototipos_TUTASA.ClasesResumenHDRRetiro;
using EstadoHojaDeRutaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum;
using HojaRetiroResumen = Prototipos_TUTASA.ClasesResumenHDRRetiro.HojaDeRutaRetiro;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaRetiroResumen> hojasDeRuta = new List<HojaRetiroResumen>();
        private readonly Dictionary<string, Cliente> clientesPorGuia = new Dictionary<string, Cliente>(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<int, HojaDeRutaRetiroEntidad> hojasEntidadPorNroHDR = new Dictionary<int, HojaDeRutaRetiroEntidad>();
        private List<HojaRetiroResumen> hojasSeleccionadas = new List<HojaRetiroResumen>();
        private int ultimoNroResumen;

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);
        public int UltimoNroResumenGenerado => ultimoNroResumen;

        public ModeloResumenHDRRetiro()
        {
            CargarDatosDesdeAlmacenes();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaRetiroResumen> hojas)
        {
            hojas = hojasDeRuta
                .Where(h => h.dniTransportistaAsignado == transportista.dniTransportista
                    && h.Fecha.Date == fecha.Date
                    && h.estado == EstadoHojaDeRutaEnum.Generada)
                .OrderBy(h => h.NroHDR)
                .ToList();

            return hojas.Count > 0;
        }

        public bool SeleccionarHojasAsignadas(TransportistaLocal transportista, DateTime fecha)
        {
            string mensaje;
            return SeleccionarHojasAsignadas(transportista, fecha, out mensaje);
        }

        public bool SeleccionarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out string mensaje)
        {
            LimpiarSeleccion();
            mensaje = string.Empty;

            if (transportista == null)
            {
                mensaje = "Debe seleccionar un fletero.";
                return false;
            }

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaRetiroResumen> hojas))
            {
                mensaje = "No hay Hojas de Ruta de Retiro asignadas al fletero para la fecha seleccionada.";
                return false;
            }

            if (!ValidarHojas(hojas, out mensaje))
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

        public List<HojaRetiroResumen> ObtenerHojasSeleccionadas()
        {
            return hojasSeleccionadas.ToList();
        }

        public bool GenerarResumen(out string mensaje)
        {
            mensaje = string.Empty;

            if (!HayHojasSeleccionadas)
            {
                mensaje = "No hay Hojas de Ruta de Retiro asignadas al fletero para la fecha seleccionada.";
                return false;
            }

            if (!ValidarHojas(hojasSeleccionadas, out mensaje))
            {
                return false;
            }

            ultimoNroResumen++;
            CambiarHojasSeleccionadasAEnCurso();
            HojaDeRutaRetiroAlmacen.Guardar();
            LimpiarSeleccion();
            return true;
        }

        private void CambiarHojasSeleccionadasAEnCurso()
        {
            foreach (HojaRetiroResumen hoja in hojasSeleccionadas)
            {
                hoja.estado = EstadoHojaDeRutaEnum.EnCurso;

                if (hojasEntidadPorNroHDR.TryGetValue(hoja.NroHDR, out HojaDeRutaRetiroEntidad hojaEntidad))
                {
                    hojaEntidad.estado = EstadoHojaDeRutaAlmacen.EnCurso;
                }
            }
        }

        private bool ValidarHojas(List<HojaRetiroResumen> hojas, out string mensaje)
        {
            mensaje = string.Empty;

            foreach (HojaRetiroResumen hoja in hojas)
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    mensaje = $"La Hoja de Ruta de Retiro N° {hoja.NroHDR} no tiene guías asociadas.";
                    return false;
                }

                if (!hojasEntidadPorNroHDR.TryGetValue(hoja.NroHDR, out HojaDeRutaRetiroEntidad hojaEntidad))
                {
                    mensaje = $"La Hoja de Ruta de Retiro N° {hoja.NroHDR} no existe.";
                    return false;
                }

                if (hojaEntidad.estado != EstadoHojaDeRutaAlmacen.Generada)
                {
                    mensaje = $"La Hoja de Ruta de Retiro N° {hoja.NroHDR} no se encuentra en estado Generada.";
                    return false;
                }
            }

            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaRetiroResumen>();
        }

        public int ObtenerCantidadBultos(HojaRetiroResumen hoja)
        {
            return hoja.DetalleGuias.Count;
        }

        public Cliente ObtenerClientePrincipal(HojaRetiroResumen hoja)
        {
            if (hoja.DetalleGuias.Count == 0)
            {
                return new Cliente();
            }

            return ObtenerCliente(hoja.DetalleGuias[0]);
        }

        private int CalcularTotalBultos(List<HojaRetiroResumen> hojas)
        {
            int total = 0;

            foreach (HojaRetiroResumen hoja in hojas)
            {
                total += ObtenerCantidadBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaRetiroResumen> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaRetiroResumen hoja in hojas)
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    continue;
                }

                domicilios.Add(ObtenerClaveDomicilio(hoja.DetalleGuias[0]));
            }

            return domicilios.Count;
        }

        private string ObtenerClaveDomicilio(string nroGuia)
        {
            Cliente guia = ObtenerCliente(nroGuia);
            return $"{guia.calle}|{guia.altura}|{guia.codigoPostal}".ToUpperInvariant();
        }

        private Cliente ObtenerCliente(string nroGuia)
        {
            if (clientesPorGuia.TryGetValue(nroGuia, out Cliente cliente))
            {
                return cliente;
            }

            return new Cliente();
        }

        private void RegistrarGuia(string nroGuia)
        {
            GuiaEntidad guiaEntidad = GuiaAlmacen.Guias
                .FirstOrDefault(g => string.Equals(g.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase));

            if (guiaEntidad == null)
            {
                return;
            }

            ClienteEntidad clienteEntidad = ClienteAlmacen.Clientes
                .FirstOrDefault(c => c.idCliente == guiaEntidad.IdCliente);

            if (clienteEntidad == null)
            {
                return;
            }

            clientesPorGuia[nroGuia] = new Cliente
            {
                idCliente = clienteEntidad.idCliente,
                calle = clienteEntidad.calle,
                altura = clienteEntidad.altura,
                codigoPostal = clienteEntidad.codigoPostal
            };
        }

        private void CargarDatosDesdeAlmacenes()
        {
            foreach (TransportistaLocalEntidad transportistaEntidad in TransportistaLocalAlmacen.transportistas)
            {
                transportistas.Add(new TransportistaLocal
                {
                    dniTransportista = transportistaEntidad.dniTransportista,
                    nombre = transportistaEntidad.nombre,
                    apellido = transportistaEntidad.apellido
                });
            }

            foreach (HojaDeRutaRetiroEntidad hojaEntidad in HojaDeRutaRetiroAlmacen.hojasDeRutaRetiro)
            {
                hojasEntidadPorNroHDR[hojaEntidad.NroHDR] = hojaEntidad;

                foreach (string nroGuia in hojaEntidad.DetalleGuias)
                {
                    RegistrarGuia(nroGuia);
                }

                hojasDeRuta.Add(new HojaRetiroResumen
                {
                    NroHDR = hojaEntidad.NroHDR,
                    Fecha = hojaEntidad.Fecha,
                    dniTransportistaAsignado = hojaEntidad.dniTransportistaAsignado,
                    DetalleGuias = hojaEntidad.DetalleGuias.ToList(),
                    estado = ConvertirEstado(hojaEntidad.estado)
                });
            }
        }

        private EstadoHojaDeRutaEnum ConvertirEstado(EstadoHojaDeRutaAlmacen estado)
        {
            switch (estado)
            {
                case EstadoHojaDeRutaAlmacen.EnCurso:
                    return EstadoHojaDeRutaEnum.EnCurso;
                default:
                    return EstadoHojaDeRutaEnum.Generada;
            }
        }
    }
}
