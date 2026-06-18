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

            ServicioMediaDistancia servicio =
                (ServicioMediaDistancia)cmboIDServicio.SelectedItem;

            modelo.ServicioActual = servicio;

            txtEmpresaTransporte.Text =
                modelo.BuscarEmpresa(servicio.idEmpresa).razonSocial;

            dateTimeFechaDespacho.Value = servicio.fechaLlegada.Value;

            lvGuias.Items.Clear();

            int cantidadGuias = 0;

            foreach (int nroHDR in servicio.DetalleHDRs)
            {
                HojaDeRutaTransporte hdr = modelo.BuscarHDR(nroHDR);

                if (hdr == null)
                    continue;

                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia guia = modelo.BuscarGuia(nroGuia);

                    if (guia == null)
                        continue;

                    CentroDistribucion cdOrigen =
                        modelo.BuscarCD(guia.idCDOrigen);

                    ListViewItem item =
                        new ListViewItem(guia.NroGuia);

                    item.SubItems.Add(guia.TipoBulto.ToString());
                    item.SubItems.Add(hdr.NroHDR.ToString());

                    if (cdOrigen != null)
                        item.SubItems.Add(cdOrigen.nombre);
                    else
                        item.SubItems.Add("");

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
            modelo.ConfirmarRecepcion();
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
