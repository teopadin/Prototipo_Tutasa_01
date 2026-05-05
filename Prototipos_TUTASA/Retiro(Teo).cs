using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Retiro_Teo_ : Form
    {
        private int ultimoNumeroHdr = 1;

        private class GuiaPendiente
        {
            public string NumeroGuia { get; set; }
            public string Remitente { get; set; }
            public string TelefonoRemitente { get; set; }
            public string DomicilioRetiro { get; set; }
            public string CiudadRetiro { get; set; }
            public string TipoBulto { get; set; }
            public string Destinatario { get; set; }
            public string CdDestino { get; set; }
            public string TipoEntrega { get; set; }
        }

        private List<GuiaPendiente> guiasPendientes = new List<GuiaPendiente>();

        public Retiro_Teo_()
        {
            InitializeComponent();
            CargarDatosIniciales();
            ConfigurarPantalla();
            CargarGuiasBase();
            AsociarEventos();
        }

        private void AsociarEventos()
        {
            cboGuiaBase.SelectedIndexChanged += cboGuiaBase_SelectedIndexChanged;
            btnGenerarHdr.Click += btnGenerarHdr_Click;
        }

        private void CargarDatosIniciales()
        {
            cboFleteroAsignado.Items.Clear();
            cboFleteroAsignado.Items.Add("Juan Perez");
            cboFleteroAsignado.Items.Add("Mario Gomez");
            cboFleteroAsignado.Items.Add("Luis Fernandez");

            guiasPendientes = new List<GuiaPendiente>
            {
                new GuiaPendiente
                {
                    NumeroGuia = "CABA-0001",
                    Remitente = "Acme SA",
                    TelefonoRemitente = "1155551111",
                    DomicilioRetiro = "Corrientes 1234",
                    CiudadRetiro = "CABA",
                    TipoBulto = "M",
                    Destinatario = "Lopez Juan",
                    CdDestino = "ROS",
                    TipoEntrega = "Puerta a puerta"
                },
                new GuiaPendiente
                {
                    NumeroGuia = "CABA-0002",
                    Remitente = "Acme SA",
                    TelefonoRemitente = "1155551111",
                    DomicilioRetiro = "Corrientes 1234",
                    CiudadRetiro = "CABA",
                    TipoBulto = "S",
                    Destinatario = "Perez Ana",
                    CdDestino = "MDZ",
                    TipoEntrega = "Retiro en agencia"
                },
                new GuiaPendiente
                {
                    NumeroGuia = "CABA-0003",
                    Remitente = "Distribuidora Norte",
                    TelefonoRemitente = "1133337777",
                    DomicilioRetiro = "Belgrano 456",
                    CiudadRetiro = "Cordoba",
                    TipoBulto = "L",
                    Destinatario = "Martinez Raul",
                    CdDestino = "COR",
                    TipoEntrega = "Retiro en CD"
                }
            };
        }

        private void ConfigurarPantalla()
        {
            dtpFecha.Value = DateTime.Now;
            txtEstadoHdr.Text = "Pendiente";
            txtCdEmisor.Text = "CABA";

            txtRemitente.Clear();
            txtTelefonoRemitente.Clear();
            txtDomicilioRetiro.Clear();
            txtCiudadRetiro.Clear();
            txtCantidadGuias.Clear();

            cboFleteroAsignado.SelectedIndex = -1;
            cboGuiaBase.SelectedIndex = -1;

            lvGuias.Items.Clear();
        }

        private void CargarGuiasBase()
        {
            cboGuiaBase.Items.Clear();

            foreach (GuiaPendiente guia in guiasPendientes)
            {
                cboGuiaBase.Items.Add(guia.NumeroGuia);
            }
        }

        private void cboGuiaBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGuiaBase.SelectedIndex == -1)
            {
                LimpiarDetalle();
                return;
            }

            string numeroGuiaSeleccionada = cboGuiaBase.Text;

            GuiaPendiente guiaBase = guiasPendientes
                .FirstOrDefault(g => g.NumeroGuia == numeroGuiaSeleccionada);

            if (guiaBase == null)
            {
                LimpiarDetalle();
                return;
            }

            List<GuiaPendiente> guiasDelMismoDomicilio = guiasPendientes
                .Where(g => g.DomicilioRetiro == guiaBase.DomicilioRetiro)
                .ToList();

            txtRemitente.Text = guiaBase.Remitente;
            txtTelefonoRemitente.Text = guiaBase.TelefonoRemitente;
            txtDomicilioRetiro.Text = guiaBase.DomicilioRetiro;
            txtCiudadRetiro.Text = guiaBase.CiudadRetiro;
            txtCantidadGuias.Text = guiasDelMismoDomicilio.Count.ToString();

            CargarDetalleGuias(guiasDelMismoDomicilio);
        }

        private void CargarDetalleGuias(List<GuiaPendiente> guias)
        {
            lvGuias.Items.Clear();

            foreach (GuiaPendiente guia in guias)
            {
                ListViewItem item = new ListViewItem(guia.NumeroGuia);
                item.SubItems.Add(guia.Destinatario);
                item.SubItems.Add(guia.TipoBulto);
                item.SubItems.Add(guia.CdDestino);
                item.SubItems.Add(guia.TipoEntrega);
                lvGuias.Items.Add(item);
            }
        }


        private void LimpiarDetalle()
        {
            txtRemitente.Clear();
            txtTelefonoRemitente.Clear();
            txtDomicilioRetiro.Clear();
            txtCiudadRetiro.Clear();
            txtCantidadGuias.Clear();
            lvGuias.Items.Clear();
        }

        private void btnGenerarHdr_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            string numeroHdrGenerado = GenerarNumeroHdr();

            MessageBox.Show(
                "HDR " + numeroHdrGenerado + " generada correctamente.",

                            "HDR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string GenerarNumeroHdr()
        {
            string numero = "HDR-" + ultimoNumeroHdr.ToString("D4");
            ultimoNumeroHdr++;
            return numero;
        }

        private bool ValidarFormulario()
        {
            if (cboGuiaBase.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una guia base.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (cboFleteroAsignado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un fletero asignado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (lvGuias.Items.Count == 0)
            {
                MessageBox.Show(
                    "No hay guias para generar la HDR.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
