using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class ModeloEstadoCuentaCorrienteXCliente
    {
        public List<ClienteCuentaCorriente> Clientes { get; set; }
        public List<CuentaCorrienteCliente> CuentasCorrientes { get; set; }
        public List<ServicioPendienteFacturaEntidad> ServiciosPendientesFactura { get; set; }
        public List<Factura> Facturas { get; set; }
        public ClienteCuentaCorriente ClienteSeleccionado { get; private set; }

        public ModeloEstadoCuentaCorrienteXCliente()
        {
            ClienteCuentaCorriente cliente1 = new ClienteCuentaCorriente { IdCliente = 1, RazonSocial = "Electro Centro SA", Cuit = "30-71112223-4" };
            ClienteCuentaCorriente cliente2 = new ClienteCuentaCorriente { IdCliente = 2, RazonSocial = "Textiles Norte SRL", Cuit = "30-70001112-8" };
            ClienteCuentaCorriente cliente3 = new ClienteCuentaCorriente { IdCliente = 3, RazonSocial = "Mercado Sur", Cuit = "27-18889999-1" };
            ClienteCuentaCorriente cliente4 = new ClienteCuentaCorriente { IdCliente = 4, RazonSocial = "Cliente Sin Pendientes SA", Cuit = "30-69998887-0" };

            Clientes = new List<ClienteCuentaCorriente>
            {
                cliente1, cliente2, cliente3, cliente4
            };

            CuentasCorrientes = new List<CuentaCorrienteCliente>
            {
                new CuentaCorrienteCliente { IdCuentaCorriente = 1, Cliente = cliente1, EstadoCuenta = EstadoCuentaCorriente.Activa, SaldoActual = 125000 },
                new CuentaCorrienteCliente { IdCuentaCorriente = 2, Cliente = cliente2, EstadoCuenta = EstadoCuentaCorriente.Activa, SaldoActual = 43000 },
                new CuentaCorrienteCliente { IdCuentaCorriente = 3, Cliente = cliente3, EstadoCuenta = EstadoCuentaCorriente.Bloqueada, SaldoActual = 240000 },
                new CuentaCorrienteCliente { IdCuentaCorriente = 4, Cliente = cliente4, EstadoCuenta = EstadoCuentaCorriente.Activa, SaldoActual = 0 }
            };

            ServiciosPendientesFactura = new List<ServicioPendienteFacturaEntidad>
            {
                CrearServicio(1, cliente1, new DateTime(2026, 5, 2), "CD01-0001", "Transporte media distancia", "Capital y GBA", "Centro - Córdoba", 15000),
                CrearServicio(2, cliente1, new DateTime(2026, 5, 3), "CD01-0002", "Entrega domicilio", "Centro - Córdoba", "Córdoba", 4200),
                CrearServicio(3, cliente1, new DateTime(2026, 5, 5), "CD02-0001", "Retiro en agencia", "Agencia Nueva Córdoba", "Centro - Córdoba", 3100),
                CrearServicio(4, cliente2, new DateTime(2026, 5, 8), "CD03-0004", "Transporte media distancia", "Centro - Córdoba", "Norte - Tucumán", 18500),
                CrearServicio(5, cliente3, new DateTime(2026, 5, 11), "CD04-0007", "Entrega domicilio", "Sur - Viedma", "Viedma", 3900)
            };

            Facturas = new List<Factura>();
            ClienteSeleccionado = null;
        }

        public List<ClienteCuentaCorriente> ObtenerClientes()
        {
            return Clientes
                .OrderBy(c => c.RazonSocial)
                .ToList();
        }

        public void SeleccionarCliente(ClienteCuentaCorriente cliente)
        {
            ClienteSeleccionado = cliente;
        }

        public void LimpiarSeleccion()
        {
            ClienteSeleccionado = null;
        }

        public CuentaCorrienteCliente ObtenerCuentaCorriente(ClienteCuentaCorriente cliente)
        {
            return CuentasCorrientes
                .FirstOrDefault(c => c.Cliente.IdCliente == cliente.IdCliente);
        }

        public List<ServicioPendienteFacturaEntidad> ObtenerServiciosPendientes(ClienteCuentaCorriente cliente)
        {
            return ServiciosPendientesFactura
                .Where(s => s.Cliente.IdCliente == cliente.IdCliente)
                .Where(s => !s.Facturado)
                .OrderBy(s => s.Fecha)
                .ToList();
        }

        public int CalcularCantidadServicios(ClienteCuentaCorriente cliente)
        {
            return ObtenerServiciosPendientes(cliente).Count;
        }

        public decimal CalcularTotalAFacturar(ClienteCuentaCorriente cliente)
        {
            decimal total = 0;

            foreach (ServicioPendienteFacturaEntidad servicio in ObtenerServiciosPendientes(cliente))
            {
                total += servicio.Importe;
            }

            return total;
        }

        public Factura EmitirFactura(ClienteCuentaCorriente cliente)
        {
            List<ServicioPendienteFacturaEntidad> servicios = ObtenerServiciosPendientes(cliente);

            Factura factura = new Factura();
            factura.NroFactura = Facturas.Count + 1;
            factura.FechaEmision = DateTime.Today;
            factura.Cliente = cliente;

            int idDetalle = 1;
            foreach (ServicioPendienteFacturaEntidad servicio in servicios)
            {
                factura.Detalles.Add(new DetalleFactura
                {
                    IdDetalleFactura = idDetalle,
                    NroFactura = factura.NroFactura,
                    NroGuia = servicio.NroServicioGuia,
                    Importe = servicio.Importe
                });

                servicio.Facturado = true;
                idDetalle++;
            }

            CuentaCorrienteCliente cuenta = ObtenerCuentaCorriente(cliente);
            cuenta.SaldoActual += factura.ImporteTotal;
            Facturas.Add(factura);

            return factura;
        }

        private ServicioPendienteFacturaEntidad CrearServicio(int idServicio, ClienteCuentaCorriente cliente, DateTime fecha, string nroGuia, string tipoServicio, string origen, string destino, decimal importe)
        {
            return new ServicioPendienteFacturaEntidad
            {
                IdServicio = idServicio,
                Cliente = cliente,
                Fecha = fecha,
                NroServicioGuia = nroGuia,
                TipoServicio = tipoServicio,
                Origen = origen,
                Destino = destino,
                Importe = importe,
                Facturado = false
            };
        }
    }
}
