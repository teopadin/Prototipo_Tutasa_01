using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    public partial class resultadocostosvsventas : Form
    {
        private ModeloResultadoCostoVSVentas modelo = new ModeloResultadoCostoVSVentas();

        public resultadocostosvsventas()
        {
            InitializeComponent();
        }

        private void resultadocostosvsventas_Load(object sender, EventArgs e)
        {
            CargarEmpresasTransporte();
            dtpPeriodo.Value = DateTime.Today;
            lvResultados.Items.Clear();
        }

        private void CargarEmpresasTransporte()
        {
            cmbEmpresaTransporte.Items.Clear();

            foreach (EmpresaTransporte empresa in modelo.ObtenerEmpresasTransporte())
            {
                cmbEmpresaTransporte.Items.Add(empresa);
            }

            cmbEmpresaTransporte.DisplayMember = "RazonSocial";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lvResultados.Items.Clear();

            if (cmbEmpresaTransporte.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una empresa de transporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EmpresaTransporte empresaSeleccionada = (EmpresaTransporte)cmbEmpresaTransporte.SelectedItem;
            DateTime periodo = dtpPeriodo.Value;

            if (modelo.PeriodoEsFuturo(periodo))
            {
                MessageBox.Show("Ingrese un periodo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResultadoCostoVenta resultado = modelo.ConsultarResultado(empresaSeleccionada, periodo);

            if (resultado == null)
            {
                MessageBox.Show("No existe información disponible para la empresa y el periodo seleccionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem item = new ListViewItem(resultado.Periodo.ToString("MM/yyyy"));
            item.SubItems.Add(resultado.Ventas.ToString("C"));
            item.SubItems.Add(resultado.Costos.ToString("C"));
            item.SubItems.Add(resultado.Resultado.ToString("C"));

            lvResultados.Items.Add(item);
        }
    }
}
