using System;
using System.Windows.Forms;
using Prototipos_TUTASA.ClasesResumenHDRRetiro;
using HojaRetiroResumen = Prototipos_TUTASA.ClasesResumenHDRRetiro.HojaDeRutaRetiro;

namespace Prototipos_TUTASA
{
    public partial class Resumen_HDR_Retiro : Form
    {
        private readonly ModeloResumenHDRRetiro modelo = new ModeloResumenHDRRetiro();

        public Resumen_HDR_Retiro()
        {
            InitializeComponent();
        }

        private void ResumenHDR_Load(object sender, EventArgs e)
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
                MessageBox.Show("No hay Hojas de Ruta de Retiro asignadas al fletero para la fecha seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!modelo.GenerarResumen(out string mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Resumen de HDR de Retiro se ha generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            foreach (HojaRetiroResumen hoja in modelo.ObtenerHojasSeleccionadas())
            {
                if (hoja.DetalleGuias.Count == 0)
                {
                    continue;
                }

                Cliente guia = hoja.DetalleGuias[0];
                var item = new ListViewItem(hoja.NroHDR.ToString());
                item.SubItems.Add(guia.IdCliente.ToString());
                item.SubItems.Add(guia.Calle);
                item.SubItems.Add(guia.Altura.ToString());
                item.SubItems.Add(guia.CodigoPostal);
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
