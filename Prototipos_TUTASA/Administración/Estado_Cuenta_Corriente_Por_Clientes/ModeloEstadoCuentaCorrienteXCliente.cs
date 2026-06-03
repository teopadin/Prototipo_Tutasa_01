using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class ModeloEstadoCuentaCorrienteXCliente
    {
        public List<ClienteCuentaCorrienteEntidad> Clientes { get; set; }
        public List<ServicioPendienteFacturaEntidad> ServiciosPendientesFactura { get; set; }
        public List<FacturaEntidad> FacturasAPagar { get; set; }
        public ClienteCuentaCorrienteEntidad ClienteSeleccionado { get; private set; }

        public ModeloEstadoCuentaCorrienteXCliente()
        {
            ClienteCuentaCorrienteEntidad cliente1 = new ClienteCuentaCorrienteEntidad
            {
                IdCliente = 1,
                RazonSocial = "Electro Centro SA",
                Cuit = "30-71112223-4",
                EstadoCuenta = "Activa",
                SaldoActual = 125000,
                HabilitadoParaFacturar = true
            };

            ClienteCuentaCorrienteEntidad cliente2 = new ClienteCuentaCorrienteEntidad
            {
                IdCliente = 2,
                RazonSocial = "Textiles Norte SRL",
                Cuit = "30-70001112-8",
                EstadoCuenta = "Activa",
                SaldoActual = 43000,
                HabilitadoParaFacturar = true
            };

            ClienteCuentaCorrienteEntidad cliente3 = new ClienteCuentaCorrienteEntidad
            {
                IdCliente = 3,
                RazonSocial = "Mercado Sur",
                Cuit = "27-18889999-1",
                EstadoCuenta = "Bloqueada por mora",
                SaldoActual = 240000,
                HabilitadoParaFacturar = false
            };

            ClienteCuentaCorrienteEntidad cliente4 = new ClienteCuentaCorrienteEntidad
            {
                IdCliente = 4,
                RazonSocial = "Cliente Sin Pendientes SA",
                Cuit = "30-69998887-0",
                EstadoCuenta = "Activa",
                SaldoActual = 0,
                HabilitadoParaFacturar = true
            };

            Clientes = new List<ClienteCuentaCorrienteEntidad>
            {
                cliente1, cliente2, cliente3, cliente4
            };

            ServiciosPendientesFactura = new List<ServicioPendienteFacturaEntidad>
            {
                new ServicioPendienteFacturaEntidad { IdServicio = 1, Fecha = new DateTime(2026, 5, 2), NroServicioGuia = "CD01-0001", TipoServicio = "Transporte media distancia", Origen = "Capital y GBA", Destino = "Centro - Córdoba", Importe = 15000, Estado = EstadoServicioFacturacion.PendienteDeFacturacion, Cliente = cliente1 },
                new ServicioPendienteFacturaEntidad { IdServicio = 2, Fecha = new DateTime(2026, 5, 3), NroServicioGuia = "CD01-0002", TipoServicio = "Entrega domicilio", Origen = "Centro - Córdoba", Destino = "Córdoba", Importe = 4200, Estado = EstadoServicioFacturacion.PendienteDeFacturacion, Cliente = cliente1 },
                new ServicioPendienteFacturaEntidad { IdServicio = 3, Fecha = new DateTime(2026, 5, 5), NroServicioGuia = "CD02-0001", TipoServicio = "Retiro en agencia", Origen = "Agencia Nueva Córdoba", Destino = "Centro - Córdoba", Importe = 3100, Estado = EstadoServicioFacturacion.PendienteDeFacturacion, Cliente = cliente1 },
                new ServicioPendienteFacturaEntidad { IdServicio = 4, Fecha = new DateTime(2026, 5, 8), NroServicioGuia = "CD03-0004", TipoServicio = "Transporte media distancia", Origen = "Centro - Córdoba", Destino = "Norte - Tucumán", Importe = 18500, Estado = EstadoServicioFacturacion.PendienteDeFacturacion, Cliente = cliente2 },
                new ServicioPendienteFacturaEntidad { IdServicio = 5, Fecha = new DateTime(2026, 5, 11), NroServicioGuia = "CD04-0007", TipoServicio = "Entrega domicilio", Origen = "Sur - Viedma", Destino = "Viedma", Importe = 3900, Estado = EstadoServicioFacturacion.PendienteDeFacturacion, Cliente = cliente3 }
            };

            FacturasAPagar = new List<FacturaEntidad>();
            ClienteSeleccionado = null;
        }

        public List<ClienteCuentaCorrienteEntidad> ObtenerClientes()
        {
            return Clientes
                .OrderBy(c => c.RazonSocial)
                .ToList();
        }

        public void SeleccionarCliente(ClienteCuentaCorrienteEntidad cliente)
        {
            ClienteSeleccionado = cliente;
        }

        public void LimpiarSeleccion()
        {
            ClienteSeleccionado = null;
        }

        public List<ServicioPendienteFacturaEntidad> ObtenerServiciosPendientes(ClienteCuentaCorrienteEntidad cliente)
        {
            return ServiciosPendientesFactura
                .Where(s => s.Cliente.IdCliente == cliente.IdCliente)
                .Where(s => s.Estado == EstadoServicioFacturacion.PendienteDeFacturacion)
                .OrderBy(s => s.Fecha)
                .ToList();
        }

        public int CalcularCantidadServicios(ClienteCuentaCorrienteEntidad cliente)
        {
            return ObtenerServiciosPendientes(cliente).Count;
        }

        public decimal CalcularTotalAFacturar(ClienteCuentaCorrienteEntidad cliente)
        {
            decimal total = 0;

            foreach (ServicioPendienteFacturaEntidad servicio in ObtenerServiciosPendientes(cliente))
            {
                total += servicio.Importe;
            }

            return total;
        }

        public FacturaEntidad EmitirFactura(ClienteCuentaCorrienteEntidad cliente)
        {
            List<ServicioPendienteFacturaEntidad> servicios = ObtenerServiciosPendientes(cliente);

            FacturaEntidad factura = new FacturaEntidad();
            factura.NroFactura = FacturasAPagar.Count + 1;
            factura.FechaEmision = DateTime.Today;
            factura.Cliente = cliente;
            factura.ServiciosFacturados = new List<ServicioPendienteFacturaEntidad>(servicios);
            factura.ImporteTotal = CalcularTotalAFacturar(cliente);

            foreach (ServicioPendienteFacturaEntidad servicio in servicios)
            {
                servicio.Estado = EstadoServicioFacturacion.Facturado;
            }

            cliente.SaldoActual += factura.ImporteTotal;
            FacturasAPagar.Add(factura);

            return factura;
        }
    }
}
