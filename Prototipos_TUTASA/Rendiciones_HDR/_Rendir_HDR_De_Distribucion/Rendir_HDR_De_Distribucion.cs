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

        private readonly ModeloRendirHDRDeDistribucion modelo = new ModeloRendirHDRDeDistribucion();
        private HDRDistribucion hdrSeleccionada = null;

        public Rendir_HDR_De_Distribucion()
        {
            InitializeComponent();
        }

        private void Rendir_HDR_De_Distribucion_Load(object sender, EventArgs e)
        {
            // Fecha actual
            FechaDtp.Value = DateTime.Now;
            FechaDtp.MaxDate = DateTime.Today;

            // Cargar fleteros
            FleteroCMB.Items.Clear();
            foreach (var f in modelo.ObtenerFleteros())
            {
                FleteroCMB.Items.Add(f);
            }
            FleteroCMB.DisplayMember = "Nombre"; // Usa ToString() igualmente

            // Cargar motivos
            MotivoCmb.Items.Clear();
            foreach (var m in modelo.ObtenerMotivos())
            {
                MotivoCmb.Items.Add(m);
            }

            // Estado inicial: motivo y aplicar deshabilitados hasta que seleccionen HDR
            MotivoCmb.Enabled = false;
            CumplidaRdb.Enabled = false;
            NoCumplidaRdb.Enabled = false;
            AplicarBtn.Enabled = false;

            // Inicializar totales
            ActualizarTotales();
        }

        private void FleteroCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            HdrRendidasLst.Items.Clear();
            hdrSeleccionada = null;
            LimpiarGroupBox();

            if (FleteroCMB.SelectedItem == null) return;

            var fletero = (TransportistaLocal)FleteroCMB.SelectedItem;
            var hdrs = modelo.ObtenerHDRsPorFletero(fletero.Id);

            if (hdrs.Count == 0)
            {
                MessageBox.Show("El fletero seleccionado no tiene HDR de distribucion pendientes de rendicion.");
                return;
            }

            foreach (var hdr in hdrs)
            {
                var item = new ListViewItem(hdr.NroHDR.ToString());
                item.SubItems.Add(hdr.Destinatario);
                item.SubItems.Add(hdr.Calle);
                item.SubItems.Add(hdr.Altura.ToString());
                item.SubItems.Add(hdr.CP);
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
                hdrSeleccionada = null;
                LimpiarGroupBox();
                return;
            }

            hdrSeleccionada = (HDRDistribucion)HdrRendidasLst.SelectedItems[0].Tag;
            groupBox1.Text = "Estado de la HDR seleccionada (" + hdrSeleccionada.NroHDR + ")";

            CumplidaRdb.Enabled = true;
            NoCumplidaRdb.Enabled = true;
            AplicarBtn.Enabled = true;

            // Reflejar estado actual de la HDR en los radios
            CumplidaRdb.Checked = hdrSeleccionada.Estado == EstadoHDR.Cumplida;
            NoCumplidaRdb.Checked = hdrSeleccionada.Estado == EstadoHDR.NoCumplida;

            if (hdrSeleccionada.MotivoNoCumplida != null)
            {
                MotivoCmb.SelectedItem = hdrSeleccionada.MotivoNoCumplida;
            }
            else
            {
                MotivoCmb.SelectedIndex = -1;
            }

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
            // Validar que haya una HDR seleccionada
            if (hdrSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una HDR de la lista.");
                return;
            }

            // Validar que haya seleccionado un estado
            if (!CumplidaRdb.Checked && !NoCumplidaRdb.Checked)
            {
                MessageBox.Show("Debe seleccionar Cumplida o No Cumplida para la HDR.");
                return;
            }

            // Si es no cumplida, debe haber motivo
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

            // Pedirle al modelo que aplique
            if (!modelo.AplicarEstado(hdrSeleccionada, CumplidaRdb.Checked, motivo))
            {
                return;
            }

            // Actualizar la fila de la lista
            var item = HdrRendidasLst.SelectedItems[0];
            item.SubItems[5].Text = hdrSeleccionada.Estado.ToString();

            // Recalcular totales
            ActualizarTotales();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (HdrRendidasLst.Items.Count == 0)
            {
                MessageBox.Show("No hay HDR para rendir.");
                return;
            }

            // Armar lista de HDR a registrar
            var lista = new List<HDRDistribucion>();
            foreach (ListViewItem item in HdrRendidasLst.Items)
            {
                lista.Add((HDRDistribucion)item.Tag);
            }

            if (!modelo.RegistrarRendicion(lista))
            {
                return;
            }

            MessageBox.Show("Rendicion registrada con exito. Total HDR rendidas: " + lista.Count);
            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // AUXILIARES
        private void ActualizarTotales()
        {
            int rendidas = 0;
            int cumplidas = 0;
            int noCumplidas = 0;

            foreach (ListViewItem item in HdrRendidasLst.Items)
            {
                var hdr = (HDRDistribucion)item.Tag;
                if (hdr.Estado == EstadoHDR.Cumplida)
                {
                    rendidas++;
                    cumplidas++;
                }
                else if (hdr.Estado == EstadoHDR.NoCumplida)
                {
                    rendidas++;
                    noCumplidas++;
                }
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
