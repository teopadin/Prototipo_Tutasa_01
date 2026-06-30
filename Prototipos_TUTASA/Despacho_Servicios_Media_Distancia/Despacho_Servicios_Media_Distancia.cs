using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    public partial class Despacho_Servicios_Media_Distancia : Form
    {
        private ModeloDespachoServiciosMediaDistancia modelo = new ModeloDespachoServiciosMediaDistancia();

        public Despacho_Servicios_Media_Distancia()
        {
            InitializeComponent();
        }

        private void Despacho_Servicios_Media_Distancia_Load(object sender, EventArgs e)
        {
            CargarComboServicios();
            LimpiarPantalla();

            if (ServicioCmb.Items.Count == 0)
            {
                MessageBox.Show("No existen servicios pendientes de despacho.");
            }
        }

        private void CargarComboServicios()
        {
            ServicioCmb.DataSource = null;
            ServicioCmb.DisplayMember = "idServicio";
            ServicioCmb.ValueMember = "idServicio";
            ServicioCmb.DataSource = modelo.Servicios.FindAll(s => s.fechaLlegada == null && s.fechaRecepcion == null);
            ServicioCmb.SelectedIndex = -1;
        }

        private void ServicioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicioCmb.SelectedItem == null)
            {
                modelo.ServicioActual = null;
                LimpiarPantalla();
                return;
            }

            ServicioMediaDistancia servicio = (ServicioMediaDistancia)ServicioCmb.SelectedItem;
            modelo.ServicioActual = servicio;

            CentroDistribucion cdDestino = modelo.BuscarCD(servicio.idCDDestino);
            CdDestinoTxtb.Text = cdDestino != null ? cdDestino.nombre : "";

            EmpresaTransporte empresa = modelo.BuscarEmpresa(servicio.idEmpresa);
            EmpresaTxtb.Text = empresa != null ? empresa.razonSocial : "";

            DespachoLst.Items.Clear();
            foreach (int nroHDR in servicio.DetalleHDRs)
            {
                HojaDeRutaTransporte hdr = modelo.BuscarHDR(nroHDR);
                if (hdr == null) continue;

                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia guia = modelo.BuscarGuia(nroGuia);
                    if (guia == null) continue;

                    Cliente cliente = modelo.BuscarCliente(guia.IdCliente);

                    var item = new ListViewItem(guia.NroGuia);
                    item.SubItems.Add(cliente != null ? cliente.razonSocial : "");
                    item.SubItems.Add(guia.Destinatario.nombre + " " + guia.Destinatario.apellido);
                    item.SubItems.Add(guia.TipoBulto.ToString());
                    item.SubItems.Add(hdr.NroHDR.ToString());
                    DespachoLst.Items.Add(item);
                }
            }

            BultoTxtb.Text = modelo.CalcularBultosEnS(servicio).ToString();
            TotalBultoTxtb.Text = modelo.CalcularTotalBultos(servicio).ToString();
            TotalGeneralTxtb.Text = modelo.CalcularTotalGeneralPendiente().ToString();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (modelo.ServicioActual == null)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
                return;
            }

            var confirma = MessageBox.Show(
                "¿Confirma el despacho del Servicio N° " + modelo.ServicioActual.idServicio + "?\n" +
                "Se emitirán 3 copias de la HDR Transporte.",
                "Confirmar despacho",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            modelo.ConfirmarDespacho();

            MessageBox.Show("Servicio N° " + modelo.ServicioActual.idServicio + " despachado con éxito.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "El despacho no será registrado. ¿Desea continuar?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes) this.Close();
        }

        //Limpiar
        private void LimpiarPantalla()
        {
            CdDestinoTxtb.Text = "";
            EmpresaTxtb.Text = "";
            DespachoLst.Items.Clear();
            BultoTxtb.Text = "";
            TotalBultoTxtb.Text = "";
            TotalGeneralTxtb.Text = modelo.CalcularTotalGeneralPendiente().ToString();
        }
    }
}