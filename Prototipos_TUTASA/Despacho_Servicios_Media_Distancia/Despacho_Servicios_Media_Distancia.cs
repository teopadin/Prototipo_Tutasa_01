using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Despacho_Servicios_Media_Distancia;


namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    public partial class Despacho_Servicios_Media_Distancia : Form
    {
        private readonly ModeloDespachoServiciosMediaDistancia modelo = new ModeloDespachoServiciosMediaDistancia();

        public Despacho_Servicios_Media_Distancia()
        {
            InitializeComponent();
        }

        private void Despacho_Servicios_Media_Distancia_Load(object sender, EventArgs e)
        {
            FechaDtp.Value = DateTime.Today;
            FechaDtp.MaxDate = DateTime.Today;

            CargarCombobox();
            LimpiarPantalla();
        }

        private void CargarCombobox()
        {
            ServicioCmb.Items.Clear();
            foreach (var hdr in modelo.ObtenerHDRsPendientes())
            {
                ServicioCmb.Items.Add(hdr);
            }

            TotalGeneralTxtb.Text = modelo.CalcularTotalGeneralPendiente().ToString();
        }

        private void ServicioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicioCmb.SelectedItem == null)
            {
                TotalGeneralTxtb.Text = modelo.CalcularTotalGeneralPendiente().ToString();
                LimpiarPantalla();
                return;
            }

            var hdrSeleccionada = (HDRTransporte)ServicioCmb.SelectedItem;

            // 1. Destino dinámico según el IdCDDestino del diagrama
            switch (hdrSeleccionada.IdCDDestino)
            {
                case 1: CdDestinoTxtb.Text = "CD Córdoba - Terminal Central"; break;
                case 2: CdDestinoTxtb.Text = "CD Mendoza - Terminal Del Sol"; break;
                case 3: CdDestinoTxtb.Text = "CD Rosario - Terminal Mariano Moreno"; break;
                case 4: CdDestinoTxtb.Text = "CD Mar del Plata - Terminal Ferroautomotora"; break;
                case 5: CdDestinoTxtb.Text = "CD Bariloche - Terminal Río Negro"; break;
                default: CdDestinoTxtb.Text = "Centro de Distribución Desconocido"; break;
            }

            // 2. Mostramos el ID del Servicio directo en el TextBox
            IdServicioTxtb.Text = hdrSeleccionada.IdServicio.ToString();

            // 3. Buscamos el objeto Servicio real en el modelo mediante la conexión del ID
            var servicioAsociado = modelo.BuscarServicioPorId(hdrSeleccionada.IdServicio);
            if (servicioAsociado != null)
            {
                // Pintamos la Razón Social de la empresa asociada a ese servicio
                EmpresaTxtb.Text = servicioAsociado.Empresa.RazonSocial;
            }
            else
            {
                EmpresaTxtb.Text = "Sin Empresa Asignada";
            }

            DespachoLst.Items.Clear();

            foreach (var g in hdrSeleccionada.DetalleGuias)
            {
                var item = new ListViewItem(g.NroGuia);
                item.SubItems.Add(g.Cliente.RazonSocial);
                item.SubItems.Add(g.Destinatario.Nombre + " " + g.Destinatario.Apellido);
                item.SubItems.Add(g.TipoBulto.ToString());
                DespachoLst.Items.Add(item);
            }

            BultoTxtb.Text = modelo.CalcularBultosEnS(hdrSeleccionada).ToString();
            TotalBultoTxtb.Text = modelo.CalcularTotalBultos(hdrSeleccionada).ToString();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            // Instanciamos la selección localmente para verificar
            var hdrSeleccionada = ServicioCmb.SelectedItem as HDRTransporte;

            if (hdrSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar un Servicio.");
                return;
            }

            if (FechaDtp.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser futura.");
                return;
            }

            var confirma = MessageBox.Show(
                "¿Confirma el despacho del Servicio " + hdrSeleccionada.NroHDR + "?\n" +
                "Se emitirán 3 copias de la HDR Transporte.",
                "Confirmar despacho",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            // Le pasamos la HDR seleccionada al modelo
            if (!modelo.ConfirmarDespacho(hdrSeleccionada))
            {
                return;
            }

            MessageBox.Show("Despacho registrado con éxito. Se emiten 3 copias de la HDR " + hdrSeleccionada.NroHDR + ".");

            CargarCombobox();
            LimpiarPantalla();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarPantalla()
        {
            // Ya no hay que limpiar "hdrSeleccionada = null" porque ya no existe a nivel global
            CdDestinoTxtb.Text = "";
            EmpresaTxtb.Text = "";
            IdServicioTxtb.Text = "";
            DespachoLst.Items.Clear();
            BultoTxtb.Text = "";
            TotalBultoTxtb.Text = "";

            TotalGeneralTxtb.Text = modelo.CalcularTotalGeneralPendiente().ToString();
        }
    }
}