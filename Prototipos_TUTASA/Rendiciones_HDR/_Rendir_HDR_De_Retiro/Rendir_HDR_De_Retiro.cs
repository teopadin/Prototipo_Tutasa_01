using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro;

namespace Prototipos_TUTASA.Rendiciones_HDR
{
    public partial class Rendir_HDR_De_Retiro : Form
    {
        private readonly Rendir_HDR_De_Retiro_Modelo modelo = new Rendir_HDR_De_Retiro_Modelo();
        private HDRRetiro hdrSeleccionada = null;

        public Rendir_HDR_De_Retiro()
        {
            InitializeComponent();
        }

        private void Rendir_HDR_De_Retiro_Load(object sender, EventArgs e)
        {
            FechaDtp.Value = DateTime.Today;
            FechaDtp.MaxDate = DateTime.Today;

            FleteroCmb.Items.Clear();
            foreach (var f in modelo.ObtenerFleteros())
            {
                FleteroCmb.Items.Add(f);
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

        private void FleteroCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDRRendidaLst.Items.Clear();
            hdrSeleccionada = null;
            LimpiarGroupBox();

            if (FleteroCmb.SelectedItem == null) return;

            var fletero = (Fletero)FleteroCmb.SelectedItem;
            var hdrs = modelo.ObtenerHDRsPorFletero(fletero.Id);

            if (hdrs.Count == 0)
            {
                MessageBox.Show("El fletero seleccionado no tiene HDR de retiro pendientes de rendicion.");
                return;
            }

            foreach (var hdr in hdrs)
            {
                var item = new ListViewItem(hdr.NroHDR.ToString());
                item.SubItems.Add(hdr.Remitente);
                item.SubItems.Add(hdr.Calle);
                item.SubItems.Add(hdr.Altura.ToString());
                item.SubItems.Add(hdr.CP);
                item.SubItems.Add(hdr.Estado.ToString());
                item.Tag = hdr;
                HDRRendidaLst.Items.Add(item);
            }

            ActualizarTotales();
        }

        private void HDRRendidaLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HDRRendidaLst.SelectedItems.Count == 0)
            {
                hdrSeleccionada = null;
                LimpiarGroupBox();
                return;
            }

            hdrSeleccionada = (HDRRetiro)HDRRendidaLst.SelectedItems[0].Tag;
            groupBox1.Text = "Estado de la HDR seleccionada (" + hdrSeleccionada.NroHDR + ")";

            CumplidaRdb.Enabled = true;
            NoCumplidaRdb.Enabled = true;
            AplicarBtn.Enabled = true;

            CumplidaRdb.Checked = hdrSeleccionada.Estado == EstadoHDR.Cumplida;
            NoCumplidaRdb.Checked = hdrSeleccionada.Estado == EstadoHDR.NoCumplida;

            if (hdrSeleccionada.MotivoNoCumplida != null)
                MotivoCmb.SelectedItem = hdrSeleccionada.MotivoNoCumplida;
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
            {
                MotivoCmb.Enabled = true;
            }
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            if (hdrSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una HDR de la lista.");
                return;
            }

            if (!CumplidaRdb.Checked && !NoCumplidaRdb.Checked)
            {
                MessageBox.Show("Debe seleccionar Cumplida o No Cumplida para la HDR.");
                return;
            }

            MotivoNoCumplidaRetiro? motivo = null;
            if (NoCumplidaRdb.Checked)
            {
                if (MotivoCmb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un motivo cuando la HDR es No Cumplida.");
                    return;
                }
                motivo = (MotivoNoCumplidaRetiro)MotivoCmb.SelectedItem;
            }

            if (!modelo.AplicarEstado(hdrSeleccionada, CumplidaRdb.Checked, motivo))
                return;

            var item = HDRRendidaLst.SelectedItems[0];
            item.SubItems[5].Text = hdrSeleccionada.Estado.ToString();

            ActualizarTotales();
        }

        private void RegistratBtn_Click(object sender, EventArgs e)
        {
            if (HDRRendidaLst.Items.Count == 0)
            {
                MessageBox.Show("No hay HDR para rendir.");
                return;
            }

            var lista = new List<HDRRetiro>();
            foreach (ListViewItem item in HDRRendidaLst.Items)
            {
                lista.Add((HDRRetiro)item.Tag);
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

            foreach (ListViewItem item in HDRRendidaLst.Items)
            {
                var hdr = (HDRRetiro)item.Tag;
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

        private void label5_Click(object sender, EventArgs e) { }
    }
}