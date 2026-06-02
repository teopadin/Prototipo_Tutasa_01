using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion;


namespace Prototipos_TUTASA.Rendiciones_HDR
{
    public partial class Rendir_HDR_De_Distribucion : Form
    {
        private readonly Rendir_HDR_De_Distribucion_Modelo modelo = new Rendir_HDR_De_Distribucion_Modelo();

        public Rendir_HDR_De_Distribucion()
        {
            InitializeComponent();
        }

        private void Rendir_HDR_De_Distribucion_Load(object sender, EventArgs e)
        {
            FechaDtp.Value = DateTime.Today;
            FechaDtp.MaxDate = DateTime.Today;

            FleteroCMB.Items.Clear();
            foreach (var t in modelo.ObtenerTransportistas())
            {
                FleteroCMB.Items.Add(t);
            }

            MotivoCmb.Items.Clear();
            foreach (var m in modelo.ObtenerMotivos())
            {
                MotivoCmb.Items.Add(m);
            }

            MotivoCmb.Enabled = false;
            CumplidaRdb.Enabled = false;
            NoCumplidaRdb.Enabled = false;
            AplicarBtn.Enabled = false;

            ActualizarTotales();
        }

        private void FleteroCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            HdrRendidasLst.Items.Clear();
            modelo.SetHdrSeleccionada(null);
            LimpiarGroupBox();

            if (FleteroCMB.SelectedItem == null) return;

            var transportista = (TransportistaLocal)FleteroCMB.SelectedItem;
            var hdrs = modelo.ObtenerHDRsPorTransportista(transportista.DniTransportista);

            if (hdrs.Count == 0)
            {
                MessageBox.Show("El transportista seleccionado no tiene HDR de distribucion pendientes de rendicion.");
                return;
            }

            foreach (var hdr in hdrs)
            {
                var detalle = hdr.DetalleGuias[0];
                var item = new ListViewItem(hdr.NroHDR.ToString());
                item.SubItems.Add(detalle.Destinatario);
                item.SubItems.Add(detalle.Calle);
                item.SubItems.Add(detalle.Altura.ToString());
                item.SubItems.Add(detalle.CP);
                item.SubItems.Add(hdr.Estado.ToString());
                item.Tag = hdr;
                HdrRendidasLst.Items.Add(item);
            }

            ActualizarTotales();
        }

        private void HdrRendidasLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HdrRendidasLst.SelectedItems.Count == 0)
            {
                modelo.SetHdrSeleccionada(null);
                LimpiarGroupBox();
                return;
            }

            modelo.SetHdrSeleccionada((HDRDistribucion)HdrRendidasLst.SelectedItems[0].Tag);
            var hdr = modelo.GetHdrSeleccionada();

            groupBox1.Text = "Estado de la HDR seleccionada (" + hdr.NroHDR + ")";

            CumplidaRdb.Enabled = true;
            NoCumplidaRdb.Enabled = true;
            AplicarBtn.Enabled = true;

            CumplidaRdb.Checked = hdr.Estado == EstadoHDR.Cumplida;
            NoCumplidaRdb.Checked = hdr.Estado == EstadoHDR.NoCumplida;

            if (hdr.MotivoNoCumplida != null)
                MotivoCmb.SelectedItem = hdr.MotivoNoCumplida;
            else
                MotivoCmb.SelectedIndex = -1;

            MotivoCmb.Enabled = NoCumplidaRdb.Checked;
        }

        private void CumplidaRdb_CheckedChanged(object sender, EventArgs e)
        {
            if (CumplidaRdb.Checked)
            {
                MotivoCmb.Enabled = false;
                MotivoCmb.SelectedIndex = -1;
            }
        }

        private void NoCumplidaRdb_CheckedChanged(object sender, EventArgs e)
        {
            if (NoCumplidaRdb.Checked)
                MotivoCmb.Enabled = true;
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            if (modelo.GetHdrSeleccionada() == null)
            {
                MessageBox.Show("Debe seleccionar una HDR de la lista.");
                return;
            }

            if (!CumplidaRdb.Checked && !NoCumplidaRdb.Checked)
            {
                MessageBox.Show("Debe seleccionar Cumplida o No Cumplida para la HDR.");
                return;
            }

            MotivoNoCumplidaDistribucion? motivo = null;
            if (NoCumplidaRdb.Checked)
            {
                if (MotivoCmb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un motivo cuando la HDR es No Cumplida.");
                    return;
                }
                motivo = (MotivoNoCumplidaDistribucion)MotivoCmb.SelectedItem;
            }

            if (!modelo.AplicarEstado(CumplidaRdb.Checked, motivo))
                return;

            var item = HdrRendidasLst.SelectedItems[0];
            item.SubItems[5].Text = modelo.GetHdrSeleccionada().Estado.ToString();

            ActualizarTotales();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (HdrRendidasLst.Items.Count == 0)
            {
                MessageBox.Show("No hay HDR para rendir.");
                return;
            }

            var lista = new List<HDRDistribucion>();
            foreach (ListViewItem item in HdrRendidasLst.Items)
            {
                lista.Add((HDRDistribucion)item.Tag);
            }

            if (!modelo.RegistrarRendicion(lista))
                return;

            MessageBox.Show("Rendicion registrada con exito. Total HDR rendidas: " + lista.Count);
            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarTotales()
        {
            int rendidas = 0, cumplidas = 0, noCumplidas = 0;

            foreach (ListViewItem item in HdrRendidasLst.Items)
            {
                var hdr = (HDRDistribucion)item.Tag;
                if (hdr.Estado == EstadoHDR.Cumplida) { rendidas++; cumplidas++; }
                else if (hdr.Estado == EstadoHDR.NoCumplida) { rendidas++; noCumplidas++; }
            }

            TotalRendidasTxtb.Text = rendidas.ToString();
            TotalCumplidasTxtb.Text = cumplidas.ToString();
            TotalNoCumplidasTxtb.Text = noCumplidas.ToString();
        }

        private void LimpiarGroupBox()
        {
            groupBox1.Text = "Estado de la HDR seleccionada (\"\")";
            CumplidaRdb.Checked = false;
            NoCumplidaRdb.Checked = false;
            CumplidaRdb.Enabled = false;
            NoCumplidaRdb.Enabled = false;
            MotivoCmb.SelectedIndex = -1;
            MotivoCmb.Enabled = false;
            AplicarBtn.Enabled = false;
        }
    }
}
