using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    public partial class Despacho_Servicios_Media_Distancia : Form
    {
        private readonly Despacho_Servicios_Media_Distancia_Modelo modelo = new Despacho_Servicios_Media_Distancia_Modelo();
        private HDRTransporte hdrSeleccionada = null;

        public Despacho_Servicios_Media_Distancia()
        {
            InitializeComponent();
        }

        private void Despacho_Servicios_Media_Distancia_Load(object sender, EventArgs e)
        {
            // Fecha actual y no se puede elegir fecha futura
            FechaDtp.Value = DateTime.Today;
            FechaDtp.MaxDate = DateTime.Today;

            // Cargar HDRs disponibles para despachar
            ServicioCmb.Items.Clear();
            foreach (var hdr in modelo.ObtenerHDRsPendientes())
            {
                ServicioCmb.Items.Add(hdr);
            }

            // Limpiar todo lo demas
            LimpiarPantalla();
        }

        private void ServicioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicioCmb.SelectedItem == null)
            {
                LimpiarPantalla();
                return;
            }

            hdrSeleccionada = (HDRTransporte)ServicioCmb.SelectedItem;

            // Autocompletar campos ReadOnly
            CdDestinoTxtb.Text = hdrSeleccionada.CdDestino;
            EmpresaTxtb.Text = hdrSeleccionada.Empresa;
            IdServicioTxtb.Text = hdrSeleccionada.IdServicio;

            // Cargar guias en la lista
            DespachoLst.Items.Clear();
            foreach (var g in hdrSeleccionada.Guias)
            {
                var item = new ListViewItem(g.NroGuia.ToString());
                item.SubItems.Add(g.Remitente);
                item.SubItems.Add(g.Destinatario);
                item.SubItems.Add(g.TipoBulto);
                DespachoLst.Items.Add(item);
            }

            // Calcular bultos en S y total
            BultoTxtb.Text = modelo.CalcularBultosEnS(hdrSeleccionada).ToString();
            TotalBultoTxtb.Text = modelo.CalcularTotalBultos(hdrSeleccionada).ToString();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            // Validar que haya HDR seleccionada
            if (hdrSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una HDR de Transporte.");
                return;
            }

            // Validar que la fecha no sea futura (doble chequeo por si acaso)
            if (FechaDtp.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser futura.");
                return;
            }

            // Confirmacion explicita al operador
            var confirma = MessageBox.Show(
                "¿Confirma el despacho de la HDR Nro " + hdrSeleccionada.NroHDR + "?\n" +
                "Se emitiran 3 copias de la HDR de Transporte.",
                "Confirmar despacho",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            // Pedirle al modelo que confirme
            if (!modelo.ConfirmarDespacho(hdrSeleccionada))
            {
                return;
            }

            MessageBox.Show("Despacho registrado con exito. Se emiten 3 copias de la HDR Nro " + hdrSeleccionada.NroHDR + ".");
            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // AUXILIAR
        private void LimpiarPantalla()
        {
            hdrSeleccionada = null;
            CdDestinoTxtb.Text = "";
            EmpresaTxtb.Text = "";
            IdServicioTxtb.Text = "";
            DespachoLst.Items.Clear();
            BultoTxtb.Text = "";
            TotalBultoTxtb.Text = "";
        }
    }
}
