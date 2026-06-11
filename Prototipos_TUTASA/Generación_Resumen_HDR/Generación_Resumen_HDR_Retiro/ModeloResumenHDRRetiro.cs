using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.ClasesResumenHDRRetiro;
using HojaRetiroResumen = Prototipos_TUTASA.ClasesResumenHDRRetiro.HojaDeRutaRetiro;

namespace Prototipos_TUTASA
{
    internal class ModeloResumenHDRRetiro
    {
        private readonly List<TransportistaLocal> transportistas = new List<TransportistaLocal>();
        private readonly List<HojaRetiroResumen> hojasDeRuta = new List<HojaRetiroResumen>();
        private readonly Dictionary<string, Cliente> clientesPorGuia = new Dictionary<string, Cliente>(StringComparer.OrdinalIgnoreCase);
        private List<HojaRetiroResumen> hojasSeleccionadas = new List<HojaRetiroResumen>();
        private int ultimoNroResumen;

        public bool HayHojasSeleccionadas => hojasSeleccionadas.Count > 0;
        public int TotalDomiciliosSeleccionados => CalcularTotalDomicilios(hojasSeleccionadas);
        public int TotalBultosSeleccionados => CalcularTotalBultos(hojasSeleccionadas);
        public int UltimoNroResumenGenerado => ultimoNroResumen;

        public ModeloResumenHDRRetiro()
        {
            CargarDatosDePrueba();
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
            LimpiarSeleccion();

            if (!BuscarHojasAsignadas(transportista, fecha, out List<HojaRetiroResumen> hojas))
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

            ultimoNroResumen++;

            foreach (HojaRetiroResumen hoja in hojasSeleccionadas)
            {
                hoja.estado = EstadoHojaDeRutaEnum.EnCurso;
            }

            LimpiarSeleccion();
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

        private string RegistrarGuia(string nroGuia, Cliente cliente)
        {
            clientesPorGuia[nroGuia] = cliente;
            return nroGuia;
        }

        private void CargarDatosDePrueba()
        {
            var carlos = new TransportistaLocal { dniTransportista = 12345678, nombre = "Carlos", apellido = "Gomez" };
            var laura = new TransportistaLocal { dniTransportista = 23456789, nombre = "Laura", apellido = "Martinez" };

            transportistas.Add(carlos);
            transportistas.Add(laura);

            AgregarHojaDeRuta(1, DateTime.Today, carlos, new List<string>
            {
                RegistrarGuia("RET-0001", new Cliente { idCliente = 1, calle = "Av. Rivadavia", altura = 3200, codigoPostal = "1406" }),
                RegistrarGuia("RET-0002", new Cliente { idCliente = 1, calle = "Av. Rivadavia", altura = 3200, codigoPostal = "1406" })
            });

            AgregarHojaDeRuta(2, DateTime.Today, carlos, new List<string>
            {
                RegistrarGuia("RET-0003", new Cliente { idCliente = 2, calle = "Av. Corrientes", altura = 1234, codigoPostal = "1043" }),
                RegistrarGuia("RET-0004", new Cliente { idCliente = 2, calle = "Av. Corrientes", altura = 1234, codigoPostal = "1043" })
            });

            AgregarHojaDeRuta(3, DateTime.Today, laura, new List<string>
            {
                RegistrarGuia("RET-0005", new Cliente { idCliente = 3, calle = "San Martin", altura = 500, codigoPostal = "1043" })
            });
        }

        private void AgregarHojaDeRuta(int nroHDR, DateTime fecha, TransportistaLocal transportista, List<string> detalleGuias)
        {
            hojasDeRuta.Add(new HojaRetiroResumen
            {
                NroHDR = nroHDR,
                Fecha = fecha,
                dniTransportistaAsignado = transportista.dniTransportista,
                DetalleGuias = detalleGuias,
                estado = EstadoHojaDeRutaEnum.Generada
            });
        }
    }
}
