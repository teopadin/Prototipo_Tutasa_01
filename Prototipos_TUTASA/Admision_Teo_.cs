using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Admision_Teo_ : Form
    {
        private class Guia
        {
            public string NumeroGuia { get; set; }
            public string Remitente { get; set; }
            public string Destinatario { get; set; }
            public string TipoBulto { get; set; }
            public string CdDestino { get; set; }
            public string TipoEntrega { get; set; }
        }

        private List<Guia> guias = new List<Guia>();
        private Guia guiaActual = null;

        public Admision_Teo_()
        {
            InitializeComponent();
            CargarDatosIniciales();
            ConfigurarPantalla();
            AsociarEventos();
        }

        private void CargarDatosIniciales()
        {
            guias = new List<Guia>
            {
                new Guia
                {
                    NumeroGuia = "CABA-0001",
                    Remitente = "Acme SA",
                    Destinatario = "Lopez Juan",
                    TipoBulto = "M",
                    CdDestino = "ROS",
                    TipoEntrega = "Puerta a puerta"
                },
                new Guia
                {
                    NumeroGuia = "CABA-0002",
                    Remitente = "Acme SA",
                    Destinatario = "Perez Ana",
                    TipoBulto = "S",
                    CdDestino = "MDZ",
                    TipoEntrega = "Retiro en agencia"
                },
                new Guia
                {
                    NumeroGuia = "CABA-0003",
                    Remitente = "Distribuidora Norte",
                    Destinatario = "Martinez Raul",
                    TipoBulto = "L",
                    CdDestino = "COR",
                    TipoEntrega = "Retiro en CD"
                }
            };
        }

        private void ConfigurarPantalla()
        {
            dtpFechaAdmision.Value = DateTime.Now;
            txtCdReceptor.Text = "CABA";

            txtRemitente.ReadOnly = true;
            txtDestinatario.ReadOnly = true;
            txtTipoBulto.ReadOnly = true;
            txtCdDestino.ReadOnly = true;
            txtTipoEntrega.ReadOnly = true;

            LimpiarDatosGuia();
        }

        private void AsociarEventos()
        {
            btnBuscar.Click += btnBuscar_Click;
            btnConfirmarAdmision.Click += btnConfirmarAdmision_Click;
            btnRechazarAdmision.Click += btnRechazarAdmision_Click;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroGuia = txtNumeroGuia.Text.Trim();

            if (string.IsNullOrWhiteSpace(numeroGuia))
            {
                MessageBox.Show(
                    "Debe ingresar un numero de guia.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Guia guiaEncontrada = guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guiaEncontrada == null)
            {
                guiaActual = null;
                LimpiarDatosGuia();

                MessageBox.Show(
                    "No se encontro la guia ingresada.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            guiaActual = guiaEncontrada;
            MostrarDatosGuia(guiaActual);
        }

        private void MostrarDatosGuia(Guia guia)
        {
            txtRemitente.Text = guia.Remitente;
            txtDestinatario.Text = guia.Destinatario;
            txtTipoBulto.Text = guia.TipoBulto;
            txtCdDestino.Text = guia.CdDestino;
            txtTipoEntrega.Text = guia.TipoEntrega;
        }

        private void LimpiarDatosGuia()
        {
            txtRemitente.Clear();
            txtDestinatario.Clear();
            txtTipoBulto.Clear();
            txtCdDestino.Clear();
            txtTipoEntrega.Clear();
        }

        private void btnConfirmarAdmision_Click(object sender, EventArgs e)
        {
            if (guiaActual == null)
            {
                MessageBox.Show(
                    "Debe buscar una guia primero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "La guia " + guiaActual.NumeroGuia + " fue admitida correctamente.",
                "Admision",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnRechazarAdmision_Click(object sender, EventArgs e)
        {
            if (guiaActual == null)
            {
                MessageBox.Show(
                    "Debe buscar una guia primero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "La guia " + guiaActual.NumeroGuia + " fue rechazada.",
                "Admision",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
