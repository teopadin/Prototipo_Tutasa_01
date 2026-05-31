using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Resumen_HDR_Retiro : Form
    {
        private readonly ModeloResumenHDRRetiro modelo = new ModeloResumenHDRRetiro();
        private List<HojaDeRutaRetiroEntidad> hojasSeleccionadas = new List<HojaDeRutaRetiroEntidad>();
        private bool hayHojasSeleccionadas = false;

        public Resumen_HDR_Retiro()
        {
            InitializeComponent();
        }

        private void ResumenHDR_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
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
                MessageBox.Show("No hay Hojas de Ruta de Retiro asignadas al fletero para la fecha seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResumenHDRRetiroEntidad resumen = modelo.GenerarResumen(hojasSeleccionadas);
            textBox4.Text = resumen.TotalDomicilios.ToString();
            textBox5.Text = resumen.TotalBultos.ToString();

            MessageBox.Show($"Resumen de HDR de Retiro Nro {resumen.NroResumen} generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarFleteros()
        {
            comboBox1.Items.Clear();

            foreach (var fletero in modelo.Fleteros)
            {
                comboBox1.Items.Add(new FleteroResumenRetiroItem(fletero));
            }
        }

        private void CargarHojasAsignadas()
        {
            LimpiarResumen();

            if (comboBox1.SelectedItem is not FleteroResumenRetiroItem itemSeleccionado)
            {
                return;
            }

            if (!modelo.BuscarHojasAsignadas(itemSeleccionado.Fletero, dateTimePicker1.Value.Date, out List<HojaDeRutaRetiroEntidad> hojas))
            {
                return;
            }

            hojasSeleccionadas = hojas;
            hayHojasSeleccionadas = true;

            foreach (HojaDeRutaRetiroEntidad hoja in hojasSeleccionadas)
            {
                if (hoja.Guias == null || hoja.Guias.Count == 0)
                {
                    continue;
                }

                DatosRetiroResumen datos = modelo.ObtenerDatosRetiro(hoja.Guias[0]);
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
            hojasSeleccionadas = new List<HojaDeRutaRetiroEntidad>();
            hayHojasSeleccionadas = false;
            listView1.Items.Clear();
            textBox4.Text = "0";
            textBox5.Text = "0";
        }
    }
}
