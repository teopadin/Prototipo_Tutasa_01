using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    public partial class Recepcion_HDR_Distribucion_Agencia : Form
    {
        private ModeloRecibirHDRDistribucionAgencia modelo = new ModeloRecibirHDRDistribucionAgencia();



        public Recepcion_HDR_Distribucion_Agencia()
        {
            InitializeComponent();
        }

        private void Recepcion_HDR_Distribucion_Agencia_Load(object sender, EventArgs e)
        {
            dtpFechaRecepcion.Value = DateTime.Today;

            txtAgencia.Clear();
            txtFletero.Clear();
            txtTotalGuias.Clear();

            listView1.Items.Clear();
        }
        private void CargarHDR(HojaDeRutaDistribucion hdr)
        {
            txtAgencia.Text = hdr.AgenciaHDR.RazonSocial;

            txtFletero.Text =
                $"{hdr.Transportista.Nombre} {hdr.Transportista.Apellido}";

            listView1.Items.Clear();

            foreach (var guia in hdr.DetalleGuias)
            {
                ListViewItem item = new ListViewItem(guia.NroGuia);
                item.SubItems.Add(guia.TipoBulto.ToString());

                listView1.Items.Add(item);
            }

            txtTotalGuias.Text = hdr.DetalleGuias.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarHDR(txtNroHDR.Text);
        }

        private void buscarHDR(string nroHDRTexto)
        {
            if (string.IsNullOrWhiteSpace(nroHDRTexto))
            {
                MessageBox.Show("Debe ingresar un número de HDR para realizar la búsqueda.");
                return;
            }

            int nroHDR;

            if (!int.TryParse(nroHDRTexto, out nroHDR))
            {
                MessageBox.Show("Debe ingresar un número de HDR válido.");
                return;
            }

            var hdr = modelo.HojasDeRutaDistribucion.FirstOrDefault(h => h.NroHDR == nroHDR);

            if (hdr == null)
            {
                MessageBox.Show("No se encontró ninguna hoja de ruta con el número ingresado. Verifique e intente nuevamente.");

                txtNroHDR.Clear();
                return;
            }

            // Excepción 3
            if (hdr.AgenciaHDR.IdAgencia != modelo.AgenciaLogueada.IdAgencia)
            {
                MessageBox.Show("La hoja de ruta ingresada no corresponde a su agencia.");

                txtNroHDR.Clear();
                return;
            }

            // Excepción 4
            if (hdr.Estado == EstadoHojaDeRuta.Recibida)
            {
                MessageBox.Show("La hoja de ruta ingresada ya fue confirmada como recibida.");

                txtNroHDR.Clear();
                return;
            }

            modelo.HdrActual = hdr;

            CargarHDR(hdr);
        }

        private void btnConfirmarRecepcion_Click(object sender, EventArgs e)
        {
            if (modelo.HdrActual == null)
            {
                MessageBox.Show("Debe buscar una HDR antes de confirmar la recepción.");

                return;
            }

            confirmarRecepcion();

            MessageBox.Show($"Recepción de HDR N° {modelo.HdrActual.NroHDR} confirmada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void confirmarRecepcion()
        {
            registrarRecepcion();

            actualizarEstadoHDR(modelo.HdrActual);

            actualizarEstadoGuia(modelo.HdrActual);
        }

        private void registrarRecepcion()
        {
            modelo.HdrActual.Fecha = DateTime.Now;
        }

        private void actualizarEstadoHDR(HojaDeRutaDistribucion hdr)
        {
            hdr.Estado = EstadoHojaDeRuta.Recibida;
        }

        private void actualizarEstadoGuia(HojaDeRutaDistribucion hdr)
        {
            foreach (var guia in hdr.DetalleGuias)
            {
                guia.Estado = EstadoGuia.PendienteDeRetiroEnAgencia;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("La recepción no será registrada. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblFletero_Click(object sender, EventArgs e)
        {

        }
    }
}
