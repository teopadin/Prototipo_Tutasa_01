using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.ClasesResumenHDRDistribucion;
using DestinatarioGuiaResumen = Prototipos_TUTASA.ClasesResumenHDRDistribucion.DestinatarioGuia;
using EstadoHojaDeRutaEntidadEnum = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum;
using GuiaAlmacen = Prototipos_TUTASA.Almacenes.GuiaAlmacen;
using GuiaEntidad = Prototipos_TUTASA.Almacenes.GuiaEntidad;
using HojaDeRutaDistribucionAlmacen = Prototipos_TUTASA.Almacenes.HojaDeRutaDistribucionAlmacen;
using HojaDeRutaDistribucionEntidad = Prototipos_TUTASA.Almacenes.HojaDeRutaDistribucionEntidad;
using TransportistaLocalAlmacen = Prototipos_TUTASA.Almacenes.TransportistaLocalAlmacen;
using TransportistaLocalEntidad = Prototipos_TUTASA.Almacenes.TransportistaLocalEntidad;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRDistribucion
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaDeRutaDistribucion> hojasDeRuta = new List<HojaDeRutaDistribucion>();
        private readonly Dictionary<string, DestinatarioGuiaResumen> destinatariosPorGuia = new Dictionary<string, DestinatarioGuiaResumen>(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<int, HojaDeRutaDistribucionEntidad> hojasEntidadPorNroHDR = new Dictionary<int, HojaDeRutaDistribucionEntidad>();
        private List<HojaDeRutaDistribucion> hojasSeleccionadas = new List<HojaDeRutaDistribucion>();
        private int ultimoNroResumen;

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);
        public int UltimoNroResumenGenerado => ultimoNroResumen;

        public ModeloResumenHDRDistribucion()
        {
            CargarDatosDesdeAlmacenes();
        }

        private bool BuscarHojasAsignadas(TransportistaLocal transportista, DateTime fecha, out List<HojaDeRutaDistribucion> hojas)
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

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaDeRutaDistribucion> hojas))
            {
                mensaje = "No hay Hojas de Ruta de Distribución asignadas al fletero para la fecha seleccionada.";
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

        public List<HojaDeRutaDistribucion> ObtenerHojasSeleccionadas()
        {
            return hojasSeleccionadas.ToList();
        }

        public bool GenerarResumen(out string mensaje)
        {
            mensaje = string.Empty;

            if (!HayHojasSeleccionadas)
            {
                mensaje = "No hay Hojas de Ruta de Distribución asignadas al fletero para la fecha seleccionada.";
                return false;
            }

            if (!ValidarHojas(hojasSeleccionadas, out mensaje))
            {
                return false;
            }

            ultimoNroResumen++;
            CambiarHojasSeleccionadasAEnCurso();
            HojaDeRutaDistribucionAlmacen.Guardar();
            LimpiarSeleccion();
            return true;
        }

        private void CambiarHojasSeleccionadasAEnCurso()
        {
            foreach (HojaDeRutaDistribucion hoja in hojasSeleccionadas)
            {
                hoja.estado = EstadoHojaDeRutaEnum.EnCurso;

                if (hojasEntidadPorNroHDR.TryGetValue(hoja.NroHDR, out HojaDeRutaDistribucionEntidad hojaEntidad))
                {
                    hojaEntidad.estado = EstadoHojaDeRutaEntidadEnum.EnCurso;
                }
            }
        }

        private bool ValidarHojas(List<HojaDeRutaDistribucion> hojas, out string mensaje)
        {
            mensaje = string.Empty;

            foreach (HojaDeRutaDistribucion hoja in hojas)
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    mensaje = $"La Hoja de Ruta de Distribución N° {hoja.NroHDR} no tiene guías asociadas.";
                    return false;
                }

                if (!hojasEntidadPorNroHDR.TryGetValue(hoja.NroHDR, out HojaDeRutaDistribucionEntidad hojaEntidad))
                {
                    mensaje = $"La Hoja de Ruta de Distribución N° {hoja.NroHDR} no existe.";
                    return false;
                }

                if (hojaEntidad.estado != EstadoHojaDeRutaEntidadEnum.Generada)
                {
                    mensaje = $"La Hoja de Ruta de Distribución N° {hoja.NroHDR} no se encuentra en estado Generada.";
                    return false;
                }
            }

            return true;
        }

        public void LimpiarSeleccion()
        {
            hojasSeleccionadas = new List<HojaDeRutaDistribucion>();
        }

        public int ObtenerCantidadBultos(HojaDeRutaDistribucion hoja)
        {
            return hoja.DetalleGuias.Count;
        }

        public DestinatarioGuiaResumen ObtenerDestinatarioPrincipal(HojaDeRutaDistribucion hoja)
        {
            if (hoja.DetalleGuias.Count == 0)
            {
                return new DestinatarioGuiaResumen();
            }

            return ObtenerDestinatario(hoja.DetalleGuias[0]);
        }

        private int CalcularTotalBultos(List<HojaDeRutaDistribucion> hojas)
        {
            int total = 0;

            foreach (HojaDeRutaDistribucion hoja in hojas)
            {
                total += ObtenerCantidadBultos(hoja);
            }

            return total;
        }

        private int CalcularTotalDomicilios(List<HojaDeRutaDistribucion> hojas)
        {
            var domicilios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (HojaDeRutaDistribucion hoja in hojas)
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
            DestinatarioGuiaResumen guia = ObtenerDestinatario(nroGuia);
            return $"{guia.calle}|{guia.altura}|{guia.codigoPostal}".ToUpperInvariant();
        }

        private DestinatarioGuiaResumen ObtenerDestinatario(string nroGuia)
        {
            if (destinatariosPorGuia.TryGetValue(nroGuia, out DestinatarioGuiaResumen destinatario))
            {
                return destinatario;
            }

            return new DestinatarioGuiaResumen();
        }

        private void RegistrarDestinatariosPorGuia()
        {
            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.Guias)
            {
                destinatariosPorGuia[guiaEntidad.NroGuia] = new DestinatarioGuiaResumen
                {
                    Dni = guiaEntidad.Destinatario.Dni,
                    calle = guiaEntidad.Destinatario.calle,
                    altura = guiaEntidad.Destinatario.altura,
                    codigoPostal = guiaEntidad.Destinatario.codigoPostal
                };
            }
        }

        private void CargarDatosDesdeAlmacenes()
        {
            RegistrarDestinatariosPorGuia();

            foreach (TransportistaLocalEntidad transportistaEntidad in TransportistaLocalAlmacen.transportistas)
            {
                transportistas.Add(new TransportistaLocal
                {
                    dniTransportista = transportistaEntidad.dniTransportista,
                    nombre = transportistaEntidad.nombre,
                    apellido = transportistaEntidad.apellido
                });
            }

            foreach (HojaDeRutaDistribucionEntidad hojaEntidad in HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion)
            {
                hojasEntidadPorNroHDR[hojaEntidad.NroHDR] = hojaEntidad;

                hojasDeRuta.Add(new HojaDeRutaDistribucion
                {
                    NroHDR = hojaEntidad.NroHDR,
                    Fecha = hojaEntidad.Fecha,
                    dniTransportistaAsignado = hojaEntidad.dniTransportistaAsignado,
                    DetalleGuias = hojaEntidad.DetalleGuias.ToList(),
                    estado = MapearEstado(hojaEntidad.estado)
                });
            }
        }

        private EstadoHojaDeRutaEnum MapearEstado(EstadoHojaDeRutaEntidadEnum estado)
        {
            if (estado == EstadoHojaDeRutaEntidadEnum.Generada)
            {
                return EstadoHojaDeRutaEnum.Generada;
            }

            return EstadoHojaDeRutaEnum.EnCurso;
        }
    }
}
