using System;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class EntregaEncomiendaCD : Form
    {
        private readonly ModeloEntregaEnCD modelo = new ModeloEntregaEnCD();
        private GuiaEntregaCD guiaSeleccionada = new GuiaEntregaCD();
        private bool hayGuiaSeleccionada = false;

        public EntregaEncomiendaCD()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lvGuia.Items.Clear();
            hayGuiaSeleccionada = false;

            string nroGuia = txtGuia.Text.Trim();
            if (string.IsNullOrWhiteSpace(nroGuia))
            {
                MessageBox.Show("Debe ingresar un número de guía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsFormatoGuiaValido(nroGuia))
            {
                MessageBox.Show("El número de guía debe tener un formato válido, por ejemplo CD02-0002, AG01-0001 o A001-0001.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.BuscarGuia(nroGuia, out GuiaEntregaCD guia))
            {
                MessageBox.Show("No se encontró una guía con el número ingresado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guia.CdDestino == null || guia.Destinatario == null)
            {
                MessageBox.Show("La guía no tiene datos completos para registrar la entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guia.CdDestino.IdCD != modelo.CdActual.IdCD)
            {
                MessageBox.Show("La guía ingresada no corresponde al Centro de Distribución actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guia.Estado != EstadoGuiaEntregaCD.PendienteDeRetiroEnCD)
            {
                MessageBox.Show("La guía no se encuentra pendiente de retiro en CD.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            guiaSeleccionada = guia;
            hayGuiaSeleccionada = true;

            var item = new ListViewItem(guia.Destinatario.Nombre);
            item.SubItems.Add(guia.Destinatario.Apellido);
            item.SubItems.Add(guia.Destinatario.Dni.ToString());
            item.Tag = guia;
            lvGuia.Items.Add(item);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!hayGuiaSeleccionada)
            {
                MessageBox.Show("Debe buscar una guía válida antes de registrar la entrega.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dniTexto = txtDNI.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dniTexto))
            {
                MessageBox.Show("Debe completar nombre, apellido y DNI de quien retira.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsDniValido(dniTexto, out int dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkDNI.Checked)
            {
                MessageBox.Show("Debe confirmar que el documento de identidad fue presentado y verificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.CoincideDestinatario(guiaSeleccionada, nombre, apellido, dni))
            {
                MessageBox.Show("Los datos de quien retira no coinciden con el destinatario de la guía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReciboEntregaCD recibo = modelo.RegistrarEntrega(guiaSeleccionada, nombre, apellido, dni);

            MessageBox.Show($"Guía N° {guiaSeleccionada.NroGuia} entregada correctamente. Recibo N° {recibo.NroRecibo}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            hayGuiaSeleccionada = false;
        }

        private static bool EsDniValido(string dniTexto, out int dni)
        {
            dni = 0;

            if (dniTexto.Length < 7 || dniTexto.Length > 8)
            {
                return false;
            }

            foreach (char caracter in dniTexto)
            {
                if (!char.IsDigit(caracter))
                {
                    return false;
                }
            }

            return int.TryParse(dniTexto, out dni) && dni > 0;
        }

        private static bool EsFormatoGuiaValido(string nroGuia)
        {
            if (nroGuia.Length != 9 || nroGuia[4] != '-')
            {
                return false;
            }

            int cantidadLetras = 0;
            while (cantidadLetras < 4 && EsLetraAscii(nroGuia[cantidadLetras]))
            {
                cantidadLetras++;
            }

            if (cantidadLetras < 1 || cantidadLetras > 2)
            {
                return false;
            }

            for (int i = cantidadLetras; i < 4; i++)
            {
                if (!char.IsDigit(nroGuia[i]))
                {
                    return false;
                }
            }

            for (int i = 5; i < nroGuia.Length; i++)
            {
                if (!char.IsDigit(nroGuia[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool EsLetraAscii(char caracter)
        {
            return (caracter >= 'A' && caracter <= 'Z')
                || (caracter >= 'a' && caracter <= 'z');
        }
    }
}
