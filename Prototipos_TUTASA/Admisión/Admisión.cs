using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Admisión
{
    public partial class Admisión : Form
    {
        private ModeloAdmision modelo = new ModeloAdmision();
        public Admisión()
        {
            InitializeComponent();
            dtpFechaAdmision.Value = DateTime.Now;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroGuia = txtNroGuia.Text;

            if (nroGuia == "")
            {
                MessageBox.Show("Debe ingresar un número de guía");
                return;
            }

            Guia guia = modelo.BuscarGuia(nroGuia);

            if (guia == null)
            {
                MessageBox.Show("La guía N° " + nroGuia + " no existe");
                LimpiarInformacion();
                return;
            }

            if (!modelo.EsAdmisible(guia))
            {
                MessageBox.Show("La guía N° " + nroGuia + " no está disponible para admitir");
                LimpiarInformacion();
                return;
            }

            // Búsqueda de los datos relacionados
            Cliente cliente = modelo.BuscarCliente(guia.IdCliente);
            CentroDistribucion cd = modelo.BuscarCD(guia.IdCDDestino);
            DestinatarioGuia dest = guia.Destinatario;

            // Mostrar info en pantalla
            txtCliente.Text = cliente.razonSocial;
            txtCDDestino.Text = cd.nombre;
            txtDestinatario.Text = dest.apellido + ", " + dest.nombre + " (DNI: " + dest.Dni + ")";
            txtTipoBulto.Text = modelo.TextoBulto(guia.TipoBulto);
            txtTipoEntrega.Text = modelo.TextoModalidad(guia.ModalidadEntrega);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe buscar una guía válida primero");
                return;
            }

            string nroGuia = txtNroGuia.Text;
            DateTime fechaAdmision = dtpFechaAdmision.Value;

            modelo.ConfirmarAdmision(nroGuia, fechaAdmision);

            MessageBox.Show("Guía N° " + nroGuia + " admitida con éxito");
            LimpiarPantalla();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe buscar una guía válida primero");
                return;
            }

            string nroGuia = txtNroGuia.Text;
            DateTime fechaAdmision = dtpFechaAdmision.Value;

            modelo.RechazarAdmision(nroGuia, fechaAdmision);

            MessageBox.Show("Guía N° " + nroGuia + " cancelada");
            LimpiarPantalla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Limpia solo los campos de información (cuando se hace una búsqueda inválida)
        private void LimpiarInformacion()
        {
            txtCliente.Text = "";
            txtCDDestino.Text = "";
            txtDestinatario.Text = "";
            txtTipoBulto.Text = "";
            txtTipoEntrega.Text = "";
        }

        // Limpia toda la pantalla después de confirmar o rechazar
        private void LimpiarPantalla()
        {
            txtNroGuia.Text = "";
            LimpiarInformacion();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
