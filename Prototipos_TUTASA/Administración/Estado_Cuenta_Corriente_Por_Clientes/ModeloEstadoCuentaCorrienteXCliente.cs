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
                new Cliente { IdCliente = 1, RazonSocial = "Electro Centro SA", Cuit = 30711122234, Telefono = "3514567890", Calle = "Av. Colón", Altura = 1250, Piso = "3", CodigoPostal = "5000", Ciudad = "Córdoba" },
                new Cliente { IdCliente = 2, RazonSocial = "Textiles Norte SRL", Cuit = 30700011128, Telefono = "3814556677", Calle = "San Martín", Altura = 870, Piso = "", CodigoPostal = "4000", Ciudad = "San Miguel de Tucumán" },
                new Cliente { IdCliente = 3, RazonSocial = "Mercado Sur", Cuit = 27188899991, Telefono = "2920445566", Calle = "Roca", Altura = 230, Piso = "1", CodigoPostal = "8500", Ciudad = "Viedma" },
                new Cliente { IdCliente = 4, RazonSocial = "Cliente Sin Pendientes SA", Cuit = 30699988870, Telefono = "3514223344", Calle = "Belgrano", Altura = 550, Piso = "", CodigoPostal = "5000", Ciudad = "Córdoba" }
            };

            CuentasCorrientes = new List<CuentaCorrienteCliente>
            {
                new CuentaCorrienteCliente { IdCuentaCorriente = 1, IdCliente = 1, EstadoCuenta = EstadoCuentaCorrienteEnum.Activa, SaldoActual = 125000 },
                new CuentaCorrienteCliente { IdCuentaCorriente = 2, IdCliente = 2, EstadoCuenta = EstadoCuentaCorrienteEnum.Activa, SaldoActual = 43000 },
                new CuentaCorrienteCliente { IdCuentaCorriente = 3, IdCliente = 3, EstadoCuenta = EstadoCuentaCorrienteEnum.Bloqueada, SaldoActual = 240000 },
                new CuentaCorrienteCliente { IdCuentaCorriente = 4, IdCliente = 4, EstadoCuenta = EstadoCuentaCorrienteEnum.Activa, SaldoActual = 0 }
            };

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
            return Clientes.OrderBy(c => c.RazonSocial).ToList();
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
            return CuentasCorrientes.FirstOrDefault(c => c.IdCliente == cliente.IdCliente);
        }

        public List<DetalleFactura> ObtenerDetallesPendientes(Cliente cliente)
        {
            return DetallesFactura
                .Where(d => d.NroFactura == 0)
                .Where(d => ObtenerIdClientePorGuia(d.NroGuia) == cliente.IdCliente)
                .OrderBy(d => d.NroGuia)
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
                total += detalle.Importe;
            }

            return total;
        }

        public bool ClienteHabilitadoParaFacturar(Cliente cliente)
        {
            CuentaCorrienteCliente cuenta = ObtenerCuentaCorriente(cliente);
            return cuenta != null && cuenta.EstadoCuenta == EstadoCuentaCorrienteEnum.Activa;
        }

        public string ObtenerCondicionFacturacion(Cliente cliente)
        {
            if (ClienteHabilitadoParaFacturar(cliente))
                return "Habilitado";

            return "Bloqueado";
        }

        public Factura EmitirFactura(Cliente cliente)
        {
            List<DetalleFactura> detallesPendientes = ObtenerDetallesPendientes(cliente);

            Factura factura = new Factura();
            factura.NroFactura = Facturas.Count + 1;
            factura.FechaEmision = DateTime.Today;
            factura.IdCliente = cliente.IdCliente;

            foreach (DetalleFactura detalle in detallesPendientes)
            {
                detalle.NroFactura = factura.NroFactura;
                factura.Detalles.Add(detalle);
            }

            CuentaCorrienteCliente cuenta = ObtenerCuentaCorriente(cliente);
            cuenta.SaldoActual += factura.ImporteTotal;
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
                IdDetalleFactura = idDetalle,
                NroFactura = 0,
                NroGuia = nroGuia,
                Importe = importe
            };
        }
    }
}
