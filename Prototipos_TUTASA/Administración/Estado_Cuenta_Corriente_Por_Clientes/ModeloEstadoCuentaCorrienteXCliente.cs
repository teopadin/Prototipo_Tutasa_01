using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class ModeloEstadoCuentaCorrienteXCliente
    {
        public List<Cliente> Clientes { get; set; }
        public List<CuentaCorrienteCliente> CuentasCorrientes { get; set; }
        public List<Factura> Facturas { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }
        public Cliente ClienteSeleccionado { get; private set; }

        public ModeloEstadoCuentaCorrienteXCliente()
        {
            Clientes = new List<Cliente>
            {
                new Cliente { idCliente = 1, razonSocial = "Electro Centro SA", cuit = 30711122234 },
                new Cliente { idCliente = 2, razonSocial = "Textiles Norte SRL", cuit = 30700011128 },
                new Cliente { idCliente = 3, razonSocial = "Mercado Sur", cuit = 27188899991 },
                new Cliente { idCliente = 4, razonSocial = "Cliente Con Saldo a Favor SA", cuit = 30699988870 }
            };

            CuentasCorrientes = new List<CuentaCorrienteCliente>
            {
                new CuentaCorrienteCliente { idCuentaCorriente = 1, idCliente = 1, saldoActual = 125000 },
                new CuentaCorrienteCliente { idCuentaCorriente = 2, idCliente = 2, saldoActual = 43000 },
                new CuentaCorrienteCliente { idCuentaCorriente = 3, idCliente = 3, saldoActual = 240000 },
                new CuentaCorrienteCliente { idCuentaCorriente = 4, idCliente = 4, saldoActual = -67500 }
            };

            foreach (CuentaCorrienteCliente cuenta in CuentasCorrientes)
            {
                ActualizarEstadoCuenta(cuenta);
            }

            DetallesFactura = new List<DetalleFactura>
            {
                CrearDetallePendiente(1, "CD01-0001", 15000),
                CrearDetallePendiente(2, "CD01-0002", 4200),
                CrearDetallePendiente(3, "CD02-0001", 3100),
                CrearDetallePendiente(4, "CD03-0004", 18500),
                CrearDetallePendiente(5, "CD04-0007", 3900)
            };

            Facturas = new List<Factura>();
            ClienteSeleccionado = null;
        }

        public List<Cliente> ObtenerClientes()
        {
            return Clientes.OrderBy(c => c.razonSocial).ToList();
        }

        public void SeleccionarCliente(Cliente cliente)
        {
            ClienteSeleccionado = cliente;
        }

        public void LimpiarSeleccion()
        {
            ClienteSeleccionado = null;
        }

        public CuentaCorrienteCliente ObtenerCuentaCorriente(Cliente cliente)
        {
            return CuentasCorrientes.FirstOrDefault(c => c.idCliente == cliente.idCliente);
        }

        public string ObtenerEstadoCuentaTexto(CuentaCorrienteCliente cuenta)
        {
            if (cuenta == null || cuenta.saldoActual == 0)
                return "Sin saldo";

            if (cuenta.saldoActual > 0)
                return "Saldo pendiente";

            return "Saldo a favor";
        }

        public string ObtenerSaldoActualTexto(CuentaCorrienteCliente cuenta)
        {
            if (cuenta == null || cuenta.saldoActual == 0)
                return "$0,00";

            if (cuenta.saldoActual > 0)
                return "Debe " + cuenta.saldoActual.ToString("C");

            return "A favor " + Math.Abs(cuenta.saldoActual).ToString("C");
        }

        private void ActualizarEstadoCuenta(CuentaCorrienteCliente cuenta)
        {
            if (cuenta.saldoActual > 0)
                cuenta.estadoCuenta = EstadoCuentaCorrienteEnum.SaldoPendiente;
            else if (cuenta.saldoActual < 0)
                cuenta.estadoCuenta = EstadoCuentaCorrienteEnum.SaldoAFavor;
            else
                cuenta.estadoCuenta = EstadoCuentaCorrienteEnum.SinSaldo;
        }

        public List<DetalleFactura> ObtenerDetallesPendientes(Cliente cliente)
        {
            return DetallesFactura
                .Where(d => d.nroFactura == 0)
                .Where(d => ObtenerIdClientePorGuia(d.nroGuia) == cliente.idCliente)
                .OrderBy(d => d.nroGuia)
                .ToList();
        }

        public int CalcularCantidadDetallesPendientes(Cliente cliente)
        {
            return ObtenerDetallesPendientes(cliente).Count;
        }

        public decimal CalcularTotalAFacturar(Cliente cliente)
        {
            decimal total = 0;

            foreach (DetalleFactura detalle in ObtenerDetallesPendientes(cliente))
            {
                total += detalle.tarifaCalculada;
            }

            return total;
        }

        public Factura EmitirFactura(Cliente cliente)
        {
            List<DetalleFactura> detallesPendientes = ObtenerDetallesPendientes(cliente);

            Factura factura = new Factura();
            factura.nroFactura = Facturas.Count + 1;
            factura.fechaEmision = DateTime.Today;
            factura.idCliente = cliente.idCliente;

            foreach (DetalleFactura detalle in detallesPendientes)
            {
                detalle.nroFactura = factura.nroFactura;
                factura.detalles.Add(detalle);
            }

            CuentaCorrienteCliente cuenta = ObtenerCuentaCorriente(cliente);
            cuenta.saldoActual += factura.ImporteTotal;
            ActualizarEstadoCuenta(cuenta);

            Facturas.Add(factura);

            return factura;
        }

        public DateTime ObtenerFechaGuia(string nroGuia)
        {
            if (nroGuia.StartsWith("CD01")) return new DateTime(2026, 5, 2);
            if (nroGuia.StartsWith("CD02")) return new DateTime(2026, 5, 5);
            if (nroGuia.StartsWith("CD03")) return new DateTime(2026, 5, 8);
            if (nroGuia.StartsWith("CD04")) return new DateTime(2026, 5, 11);

            return DateTime.Today;
        }

        public string ObtenerTipoServicio(string nroGuia)
        {
            if (nroGuia.StartsWith("CD01")) return "Transporte media distancia";
            if (nroGuia.StartsWith("CD02")) return "Retiro en agencia";
            if (nroGuia.StartsWith("CD03")) return "Transporte media distancia";
            if (nroGuia.StartsWith("CD04")) return "Entrega domicilio";

            return "Guía";
        }

        public string ObtenerOrigen(string nroGuia)
        {
            if (nroGuia.StartsWith("CD03")) return "Centro - Córdoba";
            if (nroGuia.StartsWith("CD04")) return "Sur - Viedma";

            return "Capital y GBA";
        }

        public string ObtenerDestino(string nroGuia)
        {
            if (nroGuia.StartsWith("CD03")) return "Norte - Tucumán";
            if (nroGuia.StartsWith("CD04")) return "Viedma";

            return "Centro - Córdoba";
        }

        private int ObtenerIdClientePorGuia(string nroGuia)
        {
            if (nroGuia.StartsWith("CD01") || nroGuia.StartsWith("CD02")) return 1;
            if (nroGuia.StartsWith("CD03")) return 2;
            if (nroGuia.StartsWith("CD04")) return 3;

            return 0;
        }

        private DetalleFactura CrearDetallePendiente(int idDetalle, string nroGuia, decimal importe)
        {
            return new DetalleFactura
            {
                idDetalleFactura = idDetalle,
                nroFactura = 0,
                nroGuia = nroGuia,
                tarifaCalculada = importe
            };
        }
    }
}