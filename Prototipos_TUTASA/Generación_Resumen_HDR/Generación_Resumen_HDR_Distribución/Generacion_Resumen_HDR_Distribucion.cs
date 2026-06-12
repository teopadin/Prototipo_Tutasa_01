using System;
using System.Windows.Forms;
using Prototipos_TUTASA.ClasesResumenHDRDistribucion;

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
            if (comboBox1.SelectedItem is not TransportistaLocal transportistaSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un fletero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.SeleccionarHojasAsignadas(transportistaSeleccionado, dateTimePicker1.Value.Date, out string mensaje)
                || !modelo.GenerarResumen(out mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Resumen de HDR de Distribución se ha generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            foreach (HojaDeRutaDistribucion hoja in modelo.ObtenerHojasSeleccionadas())
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    continue;
                }

                DestinatarioGuia guia = modelo.ObtenerDestinatarioPrincipal(hoja);
                var item = new ListViewItem(hoja.NroHDR.ToString());
                item.SubItems.Add(guia.Dni.ToString());
                item.SubItems.Add(guia.calle);
                item.SubItems.Add(guia.altura.ToString());
                item.SubItems.Add(guia.codigoPostal);
                item.SubItems.Add(modelo.ObtenerCantidadBultos(hoja).ToString());
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
