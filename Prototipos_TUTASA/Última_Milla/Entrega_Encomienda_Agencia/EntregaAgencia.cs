using System;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public partial class EntregaAgencia : Form
    {
        private readonly ModeloEntregaAgencia modelo = new ModeloEntregaAgencia();
        private GuiaEntidad guiaSeleccionada = null;

        public EntregaAgencia()
        {
            InitializeComponent();

            // Paso 1: el nombre de la agencia actual se muestra fijo en pantalla.
            lblAgencia.Text = modelo.AgenciaActual.Nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lvGuia.Items.Clear();
            guiaSeleccionada = null;

            string nroGuia = txtGuia.Text.Trim();
            if (string.IsNullOrWhiteSpace(nroGuia))
            {
                MessageBox.Show("Debe ingresar un número de guía para realizar la búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuiaEntidad guia = modelo.BuscarGuia(nroGuia);

            // Excepción 1: la guía no existe.
            if (guia == null)
            {
                MessageBox.Show("No se encontró una guía con el número ingresado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Paso 3 / Excepción 2: la guía debe estar en estado "Pendiente de retiro en Agencia".
            if (guia.Estado != EstadoGuia.PendienteDeRetiroEnAgencia)
            {
                MessageBox.Show("La guía ingresada no se encuentra en estado \"Pendiente de retiro en Agencia\".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            guiaSeleccionada = guia;

            // Paso 4: muestra Nombre, Apellido y DNI del destinatario.
            var item = new ListViewItem(guia.Destinatario.Nombre);
            item.SubItems.Add(guia.Destinatario.Apellido);
            item.SubItems.Add(guia.Destinatario.Dni.ToString());
            item.Tag = guia;
            lvGuia.Items.Add(item);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (guiaSeleccionada == null)
            {
                MessageBox.Show("Debe buscar una guía válida antes de registrar la entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = txtDNI.Text.Trim();

            // Excepción 3: datos de validación incompletos.
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Debe completar todos los datos de validación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Excepción 4: no se confirmó la presentación del DNI.
            if (!chkDNI.Checked)
            {
                MessageBox.Show("Debe confirmar que el destinatario presentó DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Paso 8: registra la entrega y pasa la guía a "Entregada".
            modelo.RegistrarEntrega(guiaSeleccionada, nombre, apellido, dni);

            // Paso 9: mensaje de éxito referenciando el número de guía.
            MessageBox.Show($"Entrega registrada con éxito para la guía N° {guiaSeleccionada.NroGuia}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            guiaSeleccionada = null;
        }
    }
}
