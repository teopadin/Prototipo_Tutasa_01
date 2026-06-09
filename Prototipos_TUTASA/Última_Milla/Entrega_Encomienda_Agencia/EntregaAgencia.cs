using System;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public partial class EntregaAgencia : Form
    {
        private readonly ModeloEntregaAgencia modelo = new ModeloEntregaAgencia();

        public EntregaAgencia()
        {
            InitializeComponent();

            // Paso 1: el nombre de la agencia actual se muestra fijo en pantalla.
            // Protegemos contra valores nulos que podrían venir desde el modelo.
            lblAgencia.Text = modelo.AgenciaActual?.Nombre ?? string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lvGuia.Items.Clear();

            if (!modelo.BuscarGuia(txtGuia.Text, out Guia guia, out string mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ListViewItem(guia.Destinatario.Nombre);
            item.SubItems.Add(guia.Destinatario.Apellido);
            item.SubItems.Add(guia.Destinatario.Dni.ToString());
            item.Tag = guia;
            lvGuia.Items.Add(item);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (lvGuia.Items.Count == 0)
            {
                MessageBox.Show("Debe buscar una guía válida antes de registrar la entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guia guia = lvGuia.Items[0].Tag as Guia;
            if (guia == null)
            {
                MessageBox.Show("La guía seleccionada no es válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.RegistrarEntrega(guia.NroGuia, txtNombre.Text, txtApellido.Text, txtDNI.Text, chkDNI.Checked, out string mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Entrega registrada con éxito para la guía N° {guia.NroGuia}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarFormulario()
        {
            txtGuia.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            chkDNI.Checked = false;
            lvGuia.Items.Clear();
        }
    }
}
