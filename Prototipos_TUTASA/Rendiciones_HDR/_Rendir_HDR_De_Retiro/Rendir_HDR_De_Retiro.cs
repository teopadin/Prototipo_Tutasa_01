using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro;


namespace Prototipos_TUTASA.Rendiciones_HDR
{
    public partial class Rendir_HDR_De_Retiro : Form
{
        private readonly ModeloRendirHojaDeRutaDeRetiro modelo = new ModeloRendirHojaDeRutaDeRetiro();

        public Rendir_HDR_De_Retiro()
        {
            InitializeComponent();
        }

        private void Rendir_HDR_De_Retiro_Load(object sender, EventArgs e)
        {
            FechaDtp.Value = DateTime.Today;
            FechaDtp.MaxDate = DateTime.Today;

            FleteroCmb.Items.Clear();
            foreach (var t in modelo.ObtenerTransportistas())
            {
                FleteroCmb.Items.Add(t);
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
            modelo.SetHdrSeleccionada(null);
            LimpiarGroupBox();

            if (FleteroCmb.SelectedItem == null) return;

            var transportista = (TransportistaLocal)FleteroCmb.SelectedItem;
            var hdrs = modelo.ObtenerHDRsPorTransportista(transportista.dniTransportista);

            if (hdrs.Count == 0)
            {
                MessageBox.Show("El transportista seleccionado no tiene HDR de retiro pendientes de rendicion.");
                return;
            }

            foreach (var hdr in hdrs)
            {
                var item = new ListViewItem(hdr.NroHDR.ToString());
                item.SubItems.Add(hdr.Remitente);
                item.SubItems.Add(hdr.Calle);
                item.SubItems.Add(hdr.Altura.ToString());
                item.SubItems.Add(hdr.Piso);
                item.SubItems.Add(hdr.CodigoPostal);
                item.SubItems.Add(hdr.estado.ToString());
                item.Tag = hdr;
                HDRRendidaLst.Items.Add(item);
            }

            ActualizarTotales();
        }

        private void HDRRendidaLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HDRRendidaLst.SelectedItems.Count == 0)
            {
                modelo.SetHdrSeleccionada(null);
                LimpiarGroupBox();
                return;
            }

            modelo.SetHdrSeleccionada((_Rendir_HDR_De_Retiro.HojaDeRutaRetiro)HDRRendidaLst.SelectedItems[0].Tag);
            var hdr = modelo.GetHdrSeleccionada();

            groupBox1.Text = "Estado de la HDR seleccionada (" + hdr.NroHDR + ")";

            CumplidaRdb.Enabled = true;
            NoCumplidaRdb.Enabled = true;
            AplicarBtn.Enabled = true;

            CumplidaRdb.Checked = hdr.estado == EstadoHojaDeRutaEnum.Cumplida;
            NoCumplidaRdb.Checked = hdr.estado == EstadoHojaDeRutaEnum.NoCumplida;

            if (hdr.motivoNoCumplida != null)
                MotivoCmb.SelectedItem = hdr.motivoNoCumplida;
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

            MotivoNoCumplidaRetiroEnum? motivo = null;
            if (NoCumplidaRdb.Checked)
            {
                if (MotivoCmb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un motivo cuando la HDR es No Cumplida.");
                    return;
                }
                motivo = (MotivoNoCumplidaRetiroEnum)MotivoCmb.SelectedItem;
            }

            if (!modelo.AplicarEstado(CumplidaRdb.Checked, motivo))
                return;

            var item = HDRRendidaLst.SelectedItems[0];
            item.SubItems[6].Text = modelo.GetHdrSeleccionada().estado.ToString();

            ActualizarTotales();
        }

        private void RegistratBtn_Click(object sender, EventArgs e)
        {
            if (HDRRendidaLst.Items.Count == 0)
            {
                MessageBox.Show("No hay HDR para rendir.");
                return;
            }

            var lista = new List<_Rendir_HDR_De_Retiro.HojaDeRutaRetiro>();
            foreach (ListViewItem item in HDRRendidaLst.Items)
            {
                lista.Add((_Rendir_HDR_De_Retiro.HojaDeRutaRetiro)item.Tag);
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
                var hdr = (_Rendir_HDR_De_Retiro.HojaDeRutaRetiro)item.Tag;
                if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida) { rendidas++; cumplidas++; }
                else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida) { rendidas++; noCumplidas++; }
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
