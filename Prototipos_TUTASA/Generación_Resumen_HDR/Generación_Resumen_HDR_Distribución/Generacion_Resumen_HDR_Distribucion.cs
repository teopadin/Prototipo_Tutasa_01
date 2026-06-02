using System;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Generacion_Resumen_HDR_Distribucion : Form
    {
        private readonly ModeloResumenHDRDistribucion modelo = new ModeloResumenHDRDistribucion();

        public Generacion_Resumen_HDR_Distribucion()
        {
            InitializeComponent();
        }

        private void Generacion_Resumen_HDR_Distribucion_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Enabled = false;
            CargarFleteros();
            LimpiarResumen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHojasAsignadas();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarHojasAsignadas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un fletero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.HayHojasSeleccionadas)
            {
                MessageBox.Show("No hay Hojas de Ruta de Distribución asignadas al fletero para la fecha seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.GenerarResumen(out ResumenHDRDistribucion resumen, out string mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox4.Text = resumen.TotalDomicilios.ToString();
            textBox5.Text = resumen.TotalBultos.ToString();

            MessageBox.Show($"Resumen de HDR de Distribución Nro {resumen.NroResumen} generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarFleteros();
            LimpiarResumen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarFleteros()
        {
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = string.Empty;

            foreach (var transportista in modelo.ObtenerTransportistasConHojasAsignadas(DateTime.Today))
            {
                comboBox1.Items.Add(transportista);
            }

            button1.Enabled = comboBox1.Items.Count > 0;
        }

        private void CargarHojasAsignadas()
        {
            LimpiarResumen();

            if (comboBox1.SelectedItem is not TransportistaLocal transportistaSeleccionado)
            {
                return;
            }

            if (!modelo.SeleccionarHojasAsignadas(transportistaSeleccionado, dateTimePicker1.Value.Date))
            {
                return;
            }

            foreach (DatosDestinoResumen datos in modelo.ObtenerDatosHojasSeleccionadas())
            {
                var item = new ListViewItem(datos.NroHDR.ToString());
                item.SubItems.Add(datos.Nombre);
                item.SubItems.Add(datos.Calle);
                item.SubItems.Add(datos.Altura.ToString());
                item.SubItems.Add(datos.CodigoPostal);
                item.SubItems.Add(datos.CantidadBultos.ToString());
                listView1.Items.Add(item);
            }

            textBox4.Text = modelo.TotalDomiciliosSeleccionados.ToString();
            textBox5.Text = modelo.TotalBultosSeleccionados.ToString();
        }

        private void LimpiarResumen()
        {
            modelo.LimpiarSeleccion();
            listView1.Items.Clear();
            textBox4.Text = "0";
            textBox5.Text = "0";
        }
    }
}
