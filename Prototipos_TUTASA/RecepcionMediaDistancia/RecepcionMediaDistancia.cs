using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    public partial class RecepcionMediaDistancia : Form
    {
        private ModeloRecibirServicioMediaDistancia modelo = new ModeloRecibirServicioMediaDistancia();
        public RecepcionMediaDistancia()
        {
            InitializeComponent();
        }
        private void RecepcionMediaDistancia_Load(object sender, EventArgs e)
        {
            cmboIDServicio.DisplayMember = "IdServicio";
            cmboIDServicio.ValueMember = "IdServicio";
            cmboIDServicio.DataSource = modelo.Servicios.FindAll(s => s.fechaLlegada != null && s.fechaRecepcion == null);
            txtEmpresaTransporte.Clear();
            txtCantidadGuias.Clear();
            dateTimeFechaDespacho.Value = DateTime.Today;
            lvGuias.Items.Clear();
            btnConfirmarRecepcion.Enabled = false;
            if (cmboIDServicio.Items.Count == 0)
            {
                MessageBox.Show("No existen servicios pendientes de recepción.");
            }
        }
        private void cmboIDServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionarServicio();
        }

        private void seleccionarServicio()
        {
            if (cmboIDServicio.SelectedItem == null)
                return;
            ServicioMediaDistancia servicio = (ServicioMediaDistancia)cmboIDServicio.SelectedItem;
            modelo.ServicioActual = servicio;
            txtEmpresaTransporte.Text = servicio.EmpresaTransporte.razonSocial;
            dateTimeFechaDespacho.Value = servicio.fechaLlegada.Value;
            lvGuias.Items.Clear();
            int cantidadGuias = 0;

            foreach (var hdr in servicio.DetalleHDRs)
            {
                foreach (var guia in hdr.DetalleGuias)
                {
                    ListViewItem item = new ListViewItem(guia.NroGuia);
                    item.SubItems.Add(guia.TipoBulto.ToString());
                    item.SubItems.Add(hdr.NroHDR.ToString());
                    item.SubItems.Add(guia.CDOrigen.nombre);
                    lvGuias.Items.Add(item);
                    cantidadGuias++;
                }
            }

            txtCantidadGuias.Text = cantidadGuias.ToString();

            btnConfirmarRecepcion.Enabled = true;
        }

        private void btnConfirmarRecepcion_Click(object sender,EventArgs e)
        {
            if (modelo.ServicioActual == null)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
                return;
            }

            confirmarRecepcion();

            MessageBox.Show($"Servicio Nº {modelo.ServicioActual.idServicio} recibido con éxito.","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void confirmarRecepcion()
        {
            registrarRecepcion();

            foreach (var hdr in modelo.ServicioActual.DetalleHDRs)
            {
                actualizarEstadoHDR(hdr);

                foreach (var guia in hdr.DetalleGuias)
                {
                    actualizarEstadoGuia(guia);
                }
            }
        }

        private void registrarRecepcion()
        {
            modelo.ServicioActual.fechaRecepcion = DateTime.Now;
        }

        private void actualizarEstadoHDR(HojaDeRutaTransporte hdr)
        {
            hdr.estado = EstadoHojaDeRuta.Recibida;
        }

        private void actualizarEstadoGuia(Guia guia)
        {
            if (guia.CDActual == guia.CDDestino)
            {
                if (guia.modalidadEntrega == ModalidadEntrega.EntregaCD)
                {
                    guia.estado = EstadoGuia.PendienteDeRetiroEnCD;
                }
                else
                {
                    guia.estado = EstadoGuia.EnCDDestino;
                }
            }
            else
            {
                guia.estado = EstadoGuia.Admitida;
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



    }
}
