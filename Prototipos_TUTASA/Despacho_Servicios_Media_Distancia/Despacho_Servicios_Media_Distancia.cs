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

            var hdrSeleccionada = (HojaDeRutaTransporte)ServicioCmb.SelectedItem;

            // 1. Destino dinámico consultando al Modelo (mucho más limpio que el switch)
            var cd = modelo.BuscarCD(hdrSeleccionada.idCDDestino);
            CdDestinoTxtb.Text = cd != null ? cd.nombre : "Centro de Distribución Desconocido";

            // 2. Mostramos el ID del Servicio (ya es string en la HDR)
            IdServicioTxtb.Text = hdrSeleccionada.idServicio;

            // 3. Buscamos el objeto Servicio real. Como en la HDR es string y en el Servicio es int, lo parseamos
            if (int.TryParse(hdrSeleccionada.idServicio, out int idServicioInt))
            {
                var servicioAsociado = modelo.BuscarServicioPorId(idServicioInt);

                if (servicioAsociado != null)
                {
                    var empresaAsociada = modelo.BuscarEmpresa(servicioAsociado.idEmpresa);
                    EmpresaTxtb.Text = empresaAsociada != null ? empresaAsociada.razonSocial : "Empresa no encontrada";
                }
                else
                {
                    EmpresaTxtb.Text = "Servicio no encontrado";
                }
            }

            DespachoLst.Items.Clear();

            // 4. Llenamos la grilla buscando cada guía a través de su string (NroGuia)
            foreach (string nroGuia in hdrSeleccionada.DetalleGuias)
            {
                // Le pedimos la guía real al modelo
                var guiaReal = modelo.BuscarGuia(nroGuia);

                if (guiaReal != null)
                {
                    var item = new ListViewItem(guiaReal.NroGuia);

                    // Buscamos el cliente en el modelo usando el IdCliente de la guía
                    var cliente = modelo.BuscarCliente(guiaReal.IdCliente);
                    item.SubItems.Add(cliente != null ? cliente.razonSocial : "Desconocido");

                    item.SubItems.Add(guiaReal.Destinatario.nombre + " " + guiaReal.Destinatario.apellido);
                    item.SubItems.Add(guiaReal.TipoBulto.ToString());

                    DespachoLst.Items.Add(item);
                }
            }

            BultoTxtb.Text = modelo.CalcularBultosEnS(hdrSeleccionada).ToString();
            TotalBultoTxtb.Text = modelo.CalcularTotalBultos(hdrSeleccionada).ToString();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            var hdrSeleccionada = ServicioCmb.SelectedItem as HojaDeRutaTransporte;

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

            // Ojo acá: es NroHDR con mayúscula inicial según tu clase
            var confirma = MessageBox.Show(
                "¿Confirma el despacho del Servicio " + hdrSeleccionada.NroHDR + "?\n" +
                "Se emitirán 3 copias de la HDR Transporte.",
                "Confirmar despacho",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            if (!modelo.ConfirmarDespacho(hdrSeleccionada))
            {
                return;
            }

            // Ojo acá: también NroHDR mayúscula
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