using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototipos_TUTASA.Almacenes;

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
            Clientes = ClienteAlmacen.Clientes
                .Select(c => new Cliente
                {
                    idCliente = c.idCliente,
                    razonSocial = c.razonSocial,
                    cuit = c.cuit
                })
                .ToList();

            CuentasCorrientes = CuentaCorrienteClienteAlmacen.cuentasCorrientes
                .Select(c => new CuentaCorrienteCliente
                {
                    idCliente = c.idCliente,
                    saldoActual = c.saldoActual,
                    estadoCuenta = MapearEstadoCuenta(c.estadoCuenta.ToString())
                })
                .ToList();

            Facturas = FacturaAlmacen.facturas
                .Select(f => new Factura
                {
                    nroFactura = f.nroFactura,
                    fechaEmision = f.fechaEmision,
                    idCliente = f.idCliente,
                    detalles = DetalleFacturaAlmacen.detallesFactura
                        .Where(d => f.DetalleFactura.Contains(d.idDetalleFactura.ToString()))
                        .Select(MapearDetalleFactura)
                        .ToList()
                })
                .ToList();

            DetallesFactura = DetalleFacturaAlmacen.detallesFactura
                .Select(MapearDetalleFactura)
                .ToList();

            AgregarGuiasEntregadasPendientesDeFacturacion();

            foreach (CuentaCorrienteCliente cuenta in CuentasCorrientes)
            {
                ActualizarEstadoCuenta(cuenta);
            }

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
                cuenta.estadoCuenta = EstadoCuentaCorrienteEnum.SaldoAdeudado;
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
            factura.nroFactura = ObtenerProximoNumeroFactura();
            factura.fechaEmision = DateTime.Today;
            factura.idCliente = cliente.idCliente;

            foreach (DetalleFactura detalle in detallesPendientes)
            {
                detalle.nroFactura = factura.nroFactura;
                factura.detalles.Add(detalle);
                ActualizarDetalleEnAlmacen(detalle);
            }

            CuentaCorrienteCliente cuenta = ObtenerCuentaCorriente(cliente);
            cuenta.saldoActual += factura.ImporteTotal;
            ActualizarEstadoCuenta(cuenta);
            ActualizarCuentaEnAlmacen(cuenta);

            Facturas.Add(factura);

            FacturaAlmacen.facturas.Add(new FacturaEntidad
            {
                nroFactura = factura.nroFactura,
                fechaEmision = factura.fechaEmision,
                idCliente = factura.idCliente,
                DetalleFactura = factura.detalles
                    .Select(d => d.idDetalleFactura.ToString())
                    .ToList(),
                importeTotal = factura.ImporteTotal
            });

            DetalleFacturaAlmacen.Guardar();
            CuentaCorrienteClienteAlmacen.Guardar();
            FacturaAlmacen.Guardar();

            return factura;
        }

        public DateTime ObtenerFechaGuia(string nroGuia)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);

            if (guia == null)
                return DateTime.Today;

            var entrega = guia.Historial
                .FirstOrDefault(h => h.Estado.ToString() == "Entregada");

            if (entrega == null)
                return DateTime.Today;

            return entrega.FechaCambio;
        }

        public string ObtenerTipoServicio(string nroGuia)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);

            if (guia == null)
                return "Guía";

            return "Guía " + guia.TipoImposicion.ToString();
        }

        public string ObtenerOrigen(string nroGuia)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);

            if (guia == null)
                return "";

            if (guia.idAgenciaOrigen > 0)
                return "Agencia " + guia.idAgenciaOrigen;

            return "CD " + guia.idCDOrigen;
        }

        public string ObtenerDestino(string nroGuia)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);

            if (guia == null)
                return "";

            if (guia.idAgenciaDestino > 0)
                return "Agencia " + guia.idAgenciaDestino;

            return "CD " + guia.idCDDestino;
        }

        private int ObtenerIdClientePorGuia(string nroGuia)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);

            if (guia == null)
                return 0;

            return guia.IdCliente;
        }

        private GuiaEntidad BuscarGuia(string nroGuia)
        {
            return GuiaAlmacen.Guias.FirstOrDefault(g => g.NroGuia == nroGuia);
        }

        private DetalleFactura MapearDetalleFactura(DetalleFacturaEntidad detalle)
        {
            return new DetalleFactura
            {
                idDetalleFactura = detalle.idDetalleFactura,
                nroFactura = detalle.nroFactura,
                nroGuia = detalle.nroGuia,
                tarifaCalculada = detalle.tarifaCalculada
            };
        }

        private EstadoCuentaCorrienteEnum MapearEstadoCuenta(string estadoCuenta)
        {
            if (estadoCuenta == "SaldoAFavor")
                return EstadoCuentaCorrienteEnum.SaldoAFavor;

            if (estadoCuenta == "SinSaldo")
                return EstadoCuentaCorrienteEnum.SinSaldo;

            return EstadoCuentaCorrienteEnum.SaldoAdeudado;
        }

        private void AgregarGuiasEntregadasPendientesDeFacturacion()
        {
            foreach (GuiaEntidad guia in GuiaAlmacen.Guias)
            {
                if (guia.estado.ToString() != "Entregada")
                    continue;

                if (guia.TarifaCalculada == null || guia.TarifaCalculada.TarifaTotal <= 0)
                    continue;

                bool yaExisteDetalle = DetallesFactura.Any(d => d.nroGuia == guia.NroGuia);

                if (yaExisteDetalle)
                    continue;

                DetallesFactura.Add(new DetalleFactura
                {
                    idDetalleFactura = ObtenerProximoIdDetalleFactura(),
                    nroFactura = 0,
                    nroGuia = guia.NroGuia,
                    tarifaCalculada = guia.TarifaCalculada.TarifaTotal
                });
            }
        }

        private int ObtenerProximoIdDetalleFactura()
        {
            if (!DetallesFactura.Any())
                return 1;

            return DetallesFactura.Max(d => d.idDetalleFactura) + 1;
        }

        private int ObtenerProximoNumeroFactura()
        {
            if (!Facturas.Any())
                return 1;

            return Facturas.Max(f => f.nroFactura) + 1;
        }

        private void ActualizarDetalleEnAlmacen(DetalleFactura detalle)
        {
            DetalleFacturaEntidad detalleEntidad = DetalleFacturaAlmacen.detallesFactura
                .FirstOrDefault(d => d.idDetalleFactura == detalle.idDetalleFactura);

            if (detalleEntidad == null)
            {
                detalleEntidad = new DetalleFacturaEntidad
                {
                    idDetalleFactura = detalle.idDetalleFactura,
                    nroFactura = detalle.nroFactura,
                    nroGuia = detalle.nroGuia,
                    tarifaCalculada = detalle.tarifaCalculada
                };

                DetalleFacturaAlmacen.detallesFactura.Add(detalleEntidad);
                return;
            }

            detalleEntidad.nroFactura = detalle.nroFactura;
            detalleEntidad.nroGuia = detalle.nroGuia;
            detalleEntidad.tarifaCalculada = detalle.tarifaCalculada;
        }

        private void ActualizarCuentaEnAlmacen(CuentaCorrienteCliente cuenta)
        {
            CuentaCorrienteClienteEntidad cuentaEntidad = CuentaCorrienteClienteAlmacen.cuentasCorrientes
                .FirstOrDefault(c => c.idCliente == cuenta.idCliente);

            if (cuentaEntidad == null)
                return;

            cuentaEntidad.saldoActual = cuenta.saldoActual;
        }
    }
}