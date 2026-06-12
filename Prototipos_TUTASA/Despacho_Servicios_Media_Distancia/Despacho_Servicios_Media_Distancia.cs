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

        private void ServicioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiamos antes de buscar para evitar que queden datos de una selección previa
            if (ServicioCmb.SelectedItem == null)
            {
                LimpiarPantalla(); // Asegurate de que esta función limpie todos los TextBoxes
                TotalGeneralTxtb.Text = modelo.CalcularTotalGeneralPendiente().ToString();
                return;
            }

            var hdrSeleccionada = (HojaDeRutaTransporte)ServicioCmb.SelectedItem;

            // 1. Destino dinámico
            var cd = modelo.BuscarCD(hdrSeleccionada.idCDDestino);
            CdDestinoTxtb.Text = cd != null ? cd.nombre : "Centro de Distribución Desconocido";

            // 2. ID del Servicio
            IdServicioTxtb.Text = hdrSeleccionada.idServicio;

            // 3. Búsqueda de Servicio y Empresa (SIN INT.TRYPARSE)
            // Como tu ID es "SMD-001", usamos directamente el string
            var servicioAsociado = modelo.BuscarServicioPorId(hdrSeleccionada.idServicio);

            if (servicioAsociado != null)
            {
                var empresaAsociada = modelo.BuscarEmpresa(servicioAsociado.idEmpresa);
                EmpresaTxtb.Text = empresaAsociada != null ? empresaAsociada.razonSocial : "Empresa no encontrada";
            }
            else
            {
                EmpresaTxtb.Text = "Servicio no encontrado";
            }

            // 4. Llenado de la lista (ListView)
            DespachoLst.Items.Clear();

            if (hdrSeleccionada.DetalleGuias != null)
            {
                foreach (string nroGuia in hdrSeleccionada.DetalleGuias)
                {
                    var guiaReal = modelo.BuscarGuia(nroGuia);
                    if (guiaReal != null)
                    {
                        var item = new ListViewItem(guiaReal.NroGuia);

                        var cliente = modelo.BuscarCliente(guiaReal.IdCliente);
                        item.SubItems.Add(cliente != null ? cliente.razonSocial : "Desconocido");
                        item.SubItems.Add(guiaReal.Destinatario.nombre + " " + guiaReal.Destinatario.apellido);
                        item.SubItems.Add(guiaReal.TipoBulto.ToString());

                        DespachoLst.Items.Add(item);
                    }
                }
            }

            // 5. Cálculos
            BultoTxtb.Text = modelo.CalcularBultosEnS(hdrSeleccionada).ToString();
            TotalBultoTxtb.Text = modelo.CalcularTotalBultos(hdrSeleccionada).ToString();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            var hdrSeleccionada = ServicioCmb.SelectedItem as HojaDeRutaTransporte;

            if (hdrSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar un Servicio/HDR.");
                return;
            }

            if (FechaDtp.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser futura.");
                return;
            }

            var confirma = MessageBox.Show(
                "¿Confirma el despacho del Servicio de la HDR N° " + hdrSeleccionada.NroHDR + "?\n" +
                "Se emitirán 3 copias de la HDR Transporte.",
                "Confirmar despacho",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes) return;

            // Al pasarle la HDR al modelo, el modelo se va a encargar de buscar 
            // su servicio asociado, clavarle el DateTime.Now y guardar el JSON.
            if (!modelo.ConfirmarDespacho(hdrSeleccionada))
            {
                MessageBox.Show("Ocurrió un error al registrar el despacho.");
                return;
            }

            MessageBox.Show("Despacho registrado con éxito. Se emiten 3 copias de la HDR N° " + hdrSeleccionada.NroHDR + ".");

            // Al recargar el combo, la HDR que acabamos de despachar ya no va a aparecer
            CargarCombobox();
            LimpiarPantalla();
        }

        private void CargarCombobox()
        {
            ServicioCmb.DataSource = null;
            ServicioCmb.DataSource = modelo.ObtenerHDRsPendientes();
            ServicioCmb.DisplayMember = "NroHDR";
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