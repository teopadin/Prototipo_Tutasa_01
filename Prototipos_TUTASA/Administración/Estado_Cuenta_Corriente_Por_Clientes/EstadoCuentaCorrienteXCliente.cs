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

            foreach (ClienteCuentaCorrienteEntidad cliente in modelo.ObtenerClientes())
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

            modelo.SeleccionarCliente((ClienteCuentaCorrienteEntidad)cboRazonSocial.SelectedItem);
            MostrarDatosCliente(modelo.ClienteSeleccionado);
            CargarServiciosPendientes(modelo.ClienteSeleccionado);
        }

        private void MostrarDatosCliente(ClienteCuentaCorrienteEntidad cliente)
        {
            txtCuit.Text = cliente.Cuit;
            txtEstadoCuenta.Text = cliente.EstadoCuenta;
            txtSaldoActual.Text = cliente.SaldoActual.ToString("C");
            txtCondicionFacturacion.Text = cliente.CondicionFacturacion;
        }

        private void CargarServiciosPendientes(ClienteCuentaCorrienteEntidad cliente)
        {
            lvServiciosPendientes.Items.Clear();

            List<ServicioPendienteFacturaEntidad> servicios = modelo.ObtenerServiciosPendientes(cliente);

            foreach (ServicioPendienteFacturaEntidad servicio in servicios)
            {
                ListViewItem item = new ListViewItem(servicio.Fecha.ToShortDateString());
                item.SubItems.Add(servicio.NroServicioGuia);
                item.SubItems.Add(servicio.TipoServicio);
                item.SubItems.Add(servicio.Origen);
                item.SubItems.Add(servicio.Destino);
                item.SubItems.Add(servicio.Importe.ToString("C"));
                item.SubItems.Add("Pendiente de facturación");
                item.Tag = servicio;

                lvServiciosPendientes.Items.Add(item);
            }

            txtCantidadServicios.Text = servicios.Count.ToString();
            txtTotalFacturar.Text = modelo.CalcularTotalAFacturar(cliente).ToString("C");
        }

        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            if (modelo.ClienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar una razón social para continuar con la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (modelo.CalcularCantidadServicios(modelo.ClienteSeleccionado) == 0)
            {
                MessageBox.Show("El cliente seleccionado no posee servicios pendientes de facturación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.ClienteSeleccionado.HabilitadoParaFacturar)
            {
                MessageBox.Show("El cliente seleccionado no se encuentra habilitado para facturación. No es posible emitir la factura correspondiente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FacturaEntidad factura = modelo.EmitirFactura(modelo.ClienteSeleccionado);

            MessageBox.Show("Factura emitida con éxito", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MostrarDatosCliente(modelo.ClienteSeleccionado);
            CargarServiciosPendientes(modelo.ClienteSeleccionado);
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
