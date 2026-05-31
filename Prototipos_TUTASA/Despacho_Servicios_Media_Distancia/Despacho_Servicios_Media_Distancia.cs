using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Despacho_Servicios_Media_Distancia;


namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    public partial class Despacho_Servicios_Media_Distancia : Form
    {
        private readonly ModeloDespachoServiciosMediaDistancia modelo = new ModeloDespachoServiciosMediaDistancia();
        private HojaRutaTransporte hdrSeleccionada = null;

        public Despacho_Servicios_Media_Distancia()
        {
            InitializeComponent();
        }

        private void Despacho_Servicios_Media_Distancia_Load(object sender, EventArgs e)
        {
            FechaDtp.Value = DateTime.Today;
            FechaDtp.MaxDate = DateTime.Today;

            CargarCombobox();
            LimpiarPantalla();
        }

        private void CargarCombobox()
        {
            ServicioCmb.Items.Clear();
            foreach (var hdr in modelo.ObtenerHDRsPendientes())
            {
                ServicioCmb.Items.Add(hdr);
            }
        }

        private void ServicioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicioCmb.SelectedItem == null)
            {
                LimpiarPantalla();
                return;
            }

            hdrSeleccionada = (HojaRutaTransporte)ServicioCmb.SelectedItem;

            // Autocompletar usando los nuevos objetos
            CdDestinoTxtb.Text = hdrSeleccionada.CDDestino.Nombre;
            EmpresaTxtb.Text = hdrSeleccionada.Empresa;
            IdServicioTxtb.Text = hdrSeleccionada.IdServicio;

            DespachoLst.Items.Clear();
            foreach (var g in hdrSeleccionada.Guias)
            {
                var item = new ListViewItem(g.NroGuia);
                item.SubItems.Add(g.ClienteRemitente.RazonSocial);
                item.SubItems.Add(g.DestinatarioFinal.NombreCompleto);
                item.SubItems.Add(g.TipoBulto.ToString());
                DespachoLst.Items.Add(item);
            }

            BultoTxtb.Text = modelo.CalcularBultosEnS(hdrSeleccionada).ToString();
            TotalBultoTxtb.Text = modelo.CalcularTotalBultos(hdrSeleccionada).ToString();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (hdrSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar un Servicio.");
                return;
            }

            if (FechaDtp.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser futura.");
                return;
            }

            var confirma = MessageBox.Show(
                "¿Confirma el despacho del Servicio " + hdrSeleccionada.NroHDR + "?\n" +
                "Se emitirán 3 copias de la HDR Transporte.",
                "Confirmar despacho",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            if (!modelo.ConfirmarDespacho(hdrSeleccionada))
            {
                return;
            }

            MessageBox.Show("Despacho registrado con éxito. Se emiten 3 copias de la HDR " + hdrSeleccionada.NroHDR + ".");

            // Recargamos para que desaparezca la que acabamos de despachar
            CargarCombobox();
            LimpiarPantalla();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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