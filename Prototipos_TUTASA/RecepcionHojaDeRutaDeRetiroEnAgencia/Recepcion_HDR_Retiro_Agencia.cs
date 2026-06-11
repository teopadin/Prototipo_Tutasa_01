using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    public partial class Recepcion_HDR_Retiro_Agencia : Form
    {
        //Instancia del modelo de recepcion de hdr de retiro en Agencia
        private ModeloRecibirHDRRetiroAgencia modelo = new ModeloRecibirHDRRetiroAgencia();
        public Recepcion_HDR_Retiro_Agencia()
        {
            InitializeComponent();
        }

        private void Recepcion_HDR_Retiro_Agencia_Load(object sender, EventArgs e)
        {
            dtpFechaRecepcion.Value = DateTime.Today;

            txtAgencia.Clear();
            txtFletero.Clear();
            txtTotalGuias.Clear();

            listViewGuiasRetiradas.Items.Clear();
        }

        private void CargarHDR(HojaDeRutaRetiro hdr)
        {
            txtAgencia.Text = hdr.AgenciaHDR.razonSocial;

            txtFletero.Text =$"{hdr.Transportista.nombre} {hdr.Transportista.apellido}";

            listViewGuiasRetiradas.Items.Clear();

            foreach (var guia in hdr.DetalleGuias)
            {
                ListViewItem item = new ListViewItem(guia.NroGuia);
                item.SubItems.Add(guia.TipoBulto.ToString());

                listViewGuiasRetiradas.Items.Add(item);
            }

            txtTotalGuias.Text = hdr.DetalleGuias.Count.ToString();
        }

        private void buscarHDR(int nroHDR)
        {
            var hdr = modelo.HojasDeRutaRetiro.FirstOrDefault(h => h.NroHDR == nroHDR);

            // Excepción 2
            if (hdr == null)
            {
                MessageBox.Show("No se encontró ninguna hoja de ruta con el número ingresado. Verifique e intente nuevamente.");
                txtNroHDR.Clear();
                return;
            }

            // Excepción 3
            if (hdr.AgenciaHDR.idAgencia != modelo.AgenciaLogueada.idAgencia)
            {
                MessageBox.Show("La hoja de ruta ingresada no corresponde a su agencia.");
                txtNroHDR.Clear();
                return;
            }

            // Excepción 4
            if (hdr.estado == EstadoHojaDeRutaEnum.Recibida)
            {
                MessageBox.Show("La hoja de ruta ingresada ya fue confirmada como recibida.");
                txtNroHDR.Clear();
                return;
            }

            modelo.HdrActual = hdr;

            CargarHDR(hdr);
        }

        private void confirmarRecepcion()
        {
            registrarRecepcion();
            actualizarEstadoHDR(modelo.HdrActual);
        }

        private void registrarRecepcion()
        {
            modelo.HdrActual.Fecha = DateTime.Now;
        }

        private void actualizarEstadoHDR(HojaDeRutaRetiro hdr)
        {
            hdr.estado = EstadoHojaDeRutaEnum.Recibida;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Excepción 1
            if (string.IsNullOrWhiteSpace(txtNroHDR.Text))
            {
                MessageBox.Show("Debe ingresar un número de HDR para realizar la búsqueda.");
                return;
            }

            int nroHDR;

            if (!int.TryParse(txtNroHDR.Text, out nroHDR))
            {
                MessageBox.Show("Debe ingresar un número de HDR válido.");
                return;
            }

            buscarHDR(nroHDR);
        }

        private void btnConfirmarRecepcion_Click(object sender, EventArgs e)
        {
            if (modelo.HdrActual == null)
            {
                MessageBox.Show("Debe buscar una HDR antes de confirmar la recepción.");
                return;
            }

            confirmarRecepcion();

            MessageBox.Show($"Recepción de HDR N° {modelo.HdrActual.NroHDR} confirmada con éxito.","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("La recepción no será registrada. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
