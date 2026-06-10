using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            txtCuit.Text = cliente.cuit.ToString();
            txtEstadoCuenta.Text = modelo.ObtenerEstadoCuentaTexto(cuenta);
            txtSaldoActual.Text = modelo.ObtenerSaldoActualTexto(cuenta);
        }

        private void CargarDetallesPendientes(Cliente cliente)
        {
            lvServiciosPendientes.Items.Clear();

            List<DetalleFactura> detalles = modelo.ObtenerDetallesPendientes(cliente);

            foreach (DetalleFactura detalle in detalles)
            {
                ListViewItem item = new ListViewItem(modelo.ObtenerFechaGuia(detalle.nroGuia).ToShortDateString());
                item.SubItems.Add(detalle.nroGuia);
                item.SubItems.Add(modelo.ObtenerTipoServicio(detalle.nroGuia));
                item.SubItems.Add(modelo.ObtenerOrigen(detalle.nroGuia));
                item.SubItems.Add(modelo.ObtenerDestino(detalle.nroGuia));
                item.SubItems.Add(detalle.importe.ToString("C"));
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

            Factura factura = modelo.EmitirFactura(modelo.ClienteSeleccionado);

            string nrosGuia = string.Join(", ", factura.detalles.Select(d => d.nroGuia));

            MessageBox.Show(
                $"Factura {factura.nroFactura} emitida con éxito.\nGuías facturadas: {nrosGuia}",
                "Factura",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

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

        private void lblSaldoActual_Click(object sender, EventArgs e)
        {

        }
    }
}