using System;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_CD
{
    public partial class EntregaEncomiendaCD : Form
    {
        private readonly ModeloEntregaEnCD modelo = new ModeloEntregaEnCD();

        public EntregaEncomiendaCD()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lvGuia.Items.Clear();

            if (!modelo.BuscarGuia(txtGuia.Text, out string mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ListViewItem(modelo.NombreDestinatarioSeleccionado);
            item.SubItems.Add(modelo.ApellidoDestinatarioSeleccionado);
            item.SubItems.Add(modelo.DniDestinatarioSeleccionado);
            lvGuia.Items.Add(item);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!modelo.RegistrarEntrega(txtGuia.Text, txtNombre.Text, txtApellido.Text, txtDNI.Text, chkDNI.Checked, out string mensaje, out int nroRecibo))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nroGuia = modelo.NroGuiaSeleccionada;

            MessageBox.Show($"Guía N° {nroGuia} entregada correctamente. Recibo N° {nroRecibo}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblValidacion_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarFormulario()
        {
            txtGuia.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            chkDNI.Checked = false;
            lvGuia.Items.Clear();
            modelo.LimpiarSeleccion();
        }
    }
}
