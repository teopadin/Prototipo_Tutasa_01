using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    public partial class EstadoCuentaCorrienteXCliente : Form
    {
        private ModeloEstadoCuentaCorrienteXCliente modelo = new ModeloEstadoCuentaCorrienteXCliente();

        public EstadoCuentaCorrienteXCliente()
        {
            InitializeComponent();
        }

        private void EstadoCuentaCorrienteXCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
            LimpiarDatosCliente();
        }

        private void CargarClientes()
        {
            cboRazonSocial.Items.Clear();

            foreach (Cliente cliente in modelo.ObtenerClientes())
            {
                cboRazonSocial.Items.Add(cliente);
            }

            cboRazonSocial.DisplayMember = "RazonSocial";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (cboRazonSocial.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una razón social para continuar con la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modelo.SeleccionarCliente((Cliente)cboRazonSocial.SelectedItem);
            MostrarDatosCliente(modelo.ClienteSeleccionado);
            CargarDetallesPendientes(modelo.ClienteSeleccionado);
        }

        private void MostrarDatosCliente(Cliente cliente)
        {
            CuentaCorrienteCliente cuenta = modelo.ObtenerCuentaCorriente(cliente);

            txtCuit.Text = cliente.Cuit.ToString();
            txtEstadoCuenta.Text = cuenta.EstadoCuenta.ToString();
            txtSaldoActual.Text = cuenta.SaldoActual.ToString("C");
            txtCondicionFacturacion.Text = modelo.ObtenerCondicionFacturacion(cliente);
        }

        private void CargarDetallesPendientes(Cliente cliente)
        {
            lvServiciosPendientes.Items.Clear();

            List<DetalleFactura> detalles = modelo.ObtenerDetallesPendientes(cliente);

            foreach (DetalleFactura detalle in detalles)
            {
                ListViewItem item = new ListViewItem(modelo.ObtenerFechaGuia(detalle.NroGuia).ToShortDateString());
                item.SubItems.Add(detalle.NroGuia);
                item.SubItems.Add(modelo.ObtenerTipoServicio(detalle.NroGuia));
                item.SubItems.Add(modelo.ObtenerOrigen(detalle.NroGuia));
                item.SubItems.Add(modelo.ObtenerDestino(detalle.NroGuia));
                item.SubItems.Add(detalle.Importe.ToString("C"));
                item.SubItems.Add("Pendiente de facturación");
                item.Tag = detalle;

                lvServiciosPendientes.Items.Add(item);
            }

            txtCantidadServicios.Text = detalles.Count.ToString();
            txtTotalFacturar.Text = modelo.CalcularTotalAFacturar(cliente).ToString("C");
        }

        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            if (modelo.ClienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar una razón social para continuar con la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (modelo.CalcularCantidadDetallesPendientes(modelo.ClienteSeleccionado) == 0)
            {
                MessageBox.Show("El cliente seleccionado no posee guías pendientes de facturación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.ClienteHabilitadoParaFacturar(modelo.ClienteSeleccionado))
            {
                MessageBox.Show("El cliente seleccionado no se encuentra habilitado para facturación. No es posible emitir la factura correspondiente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Factura factura = modelo.EmitirFactura(modelo.ClienteSeleccionado);

            MessageBox.Show("Factura emitida con éxito", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MostrarDatosCliente(modelo.ClienteSeleccionado);
            CargarDetallesPendientes(modelo.ClienteSeleccionado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarDatosCliente()
        {
            modelo.LimpiarSeleccion();
            txtCuit.Text = "";
            txtEstadoCuenta.Text = "";
            txtSaldoActual.Text = "";
            txtCondicionFacturacion.Text = "";
            txtCantidadServicios.Text = "0";
            txtTotalFacturar.Text = "0";
            lvServiciosPendientes.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoCuenta_Click(object sender, EventArgs e)
        {

        }
    }
}
