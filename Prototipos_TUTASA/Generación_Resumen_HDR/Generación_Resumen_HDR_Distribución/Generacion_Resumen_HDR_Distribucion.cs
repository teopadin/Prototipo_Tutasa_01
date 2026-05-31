using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Generacion_Resumen_HDR_Distribucion : Form
    {
        private readonly ModeloResumenHDRDistribucion modelo = new ModeloResumenHDRDistribucion();
        private List<HojaDeRutaDistribucionEntidad> hojasSeleccionadas = new List<HojaDeRutaDistribucionEntidad>();
        private bool hayHojasSeleccionadas = false;

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

            if (!hayHojasSeleccionadas)
            {
                MessageBox.Show("No hay Hojas de Ruta de Distribución asignadas al fletero para la fecha seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResumenHDRDistribucionEntidad resumen = modelo.GenerarResumen(hojasSeleccionadas);
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

            foreach (var fletero in modelo.ObtenerFleterosConHojasAsignadas(DateTime.Today))
            {
                comboBox1.Items.Add(new FleteroResumenItem(fletero));
            }

            button1.Enabled = comboBox1.Items.Count > 0;
        }

        private void CargarHojasAsignadas()
        {
            LimpiarResumen();

            if (comboBox1.SelectedItem is not FleteroResumenItem itemSeleccionado)
            {
                return;
            }

            if (!modelo.BuscarHojasAsignadas(itemSeleccionado.Fletero, dateTimePicker1.Value.Date, out List<HojaDeRutaDistribucionEntidad> hojas))
            {
                return;
            }

            hojasSeleccionadas = hojas;
            hayHojasSeleccionadas = true;

            foreach (HojaDeRutaDistribucionEntidad hoja in hojasSeleccionadas)
            {
                if (hoja.Guias == null || hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosDestinoResumen datos = modelo.ObtenerDatosDestino(hoja.Guias[0]);
                var item = new ListViewItem(hoja.NroHDR.ToString());
                item.SubItems.Add(datos.Nombre);
                item.SubItems.Add(datos.Calle);
                item.SubItems.Add(datos.Altura.ToString());
                item.SubItems.Add(datos.CodigoPostal);
                item.SubItems.Add(modelo.CalcularTotalBultos(hoja).ToString());
                item.Tag = hoja;
                listView1.Items.Add(item);
            }

            textBox4.Text = modelo.CalcularTotalDomicilios(hojasSeleccionadas).ToString();
            textBox5.Text = modelo.CalcularTotalBultos(hojasSeleccionadas).ToString();
        }

        private void LimpiarResumen()
        {
            hojasSeleccionadas = new List<HojaDeRutaDistribucionEntidad>();
            hayHojasSeleccionadas = false;
            listView1.Items.Clear();
            textBox4.Text = "0";
            textBox5.Text = "0";
        }
    }
}
