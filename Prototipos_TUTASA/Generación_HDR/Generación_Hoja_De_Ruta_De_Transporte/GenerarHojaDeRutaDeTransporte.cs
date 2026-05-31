using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte;
using Prototipos_TUTASA.Generación_HDR.Generacion_Hoja_De_Ruta_De_Transporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Generación_Hoja_De_Ruta_De_Transporte
{
    public partial class GenerarHojaDeRutaDeTransporte : Form
    {
        private ModeloGenerarHDRTransporte modelo = new ModeloGenerarHDRTransporte();
        private bool actualizando = false;
        public GenerarHojaDeRutaDeTransporte()
        {
            InitializeComponent();
        }

        private void GenerarHojaDeRutaDeTransporte_Load(object sender, EventArgs e)
        {
            CargarCDDestino();
        }

        private void CargarCDDestino()
        {
            cmbCDDestino.Items.Clear();

            foreach (var cd in modelo.CentrosDeDistribucion)
            {
                if (cd.IdCD != modelo.CdEmisor.IdCD)
                    cmbCDDestino.Items.Add(cd);
            }

            cmbCDDestino.DisplayMember = "Nombre";

            if (cmbCDDestino.Items.Count == 0)
            {
                MessageBox.Show("No hay centros de distribución habilitados disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void cmbCDDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            lvGuiasPendientes.Items.Clear();
            lvServicios.Items.Clear();
            txtBultos.Text = "0";

            if (cmbCDDestino.SelectedItem == null)
                return;

            CargarGuiasPendientes();

            if (lvGuiasPendientes.Items.Count == 0)
                MessageBox.Show("No hay encomiendas pendientes para ese CD destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CargarGuiasPendientes()
        {
            actualizando = true;
            lvGuiasPendientes.Items.Clear();

            CentroDistribucionEntidad cdSeleccionado = (CentroDistribucionEntidad)cmbCDDestino.SelectedItem;

            foreach (var guia in modelo.Guias)
            {
                if (guia.Estado != EstadoGuia.Admitida || guia.CdOrigen.IdCD != modelo.CdEmisor.IdCD || guia.CdDestino.IdCD != cdSeleccionado.IdCD)
                    continue;

                var item = new ListViewItem(guia.NroGuia);
                item.SubItems.Add(guia.FechaImposicion.ToShortDateString());
                item.SubItems.Add(guia.TipoBulto.ToString());
                item.Tag = guia;

                lvGuiasPendientes.Items.Add(item);
            }

            actualizando = false;
        }

        private void lvGuiasPendientes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (actualizando) return;

            ActualizarBultos();
            CargarServicios();
        }

        private void ActualizarBultos()
        {
            int totalBultos = 0;
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                if (item.Checked)
                {
                    GuiaEntidad guia = (GuiaEntidad)item.Tag;
                    totalBultos += guia.EquivalenteS;
                }
            }
            txtBultos.Text = totalBultos.ToString();
        }

        private void CargarServicios()
        {
            lvServicios.Items.Clear();

            if (cmbCDDestino.SelectedItem == null)
                return;

            int totalBultos = 0;
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                if (item.Checked)
                {
                    GuiaEntidad guia = (GuiaEntidad)item.Tag;
                    totalBultos += guia.EquivalenteS;
                }
            }

            if (totalBultos == 0)
                return;

            CentroDistribucionEntidad cdSeleccionado = (CentroDistribucionEntidad)cmbCDDestino.SelectedItem;

            foreach (var servicio in modelo.Servicios)
            {
                if (servicio.CdOrigen.IdCD != modelo.CdEmisor.IdCD || servicio.CdDestino.IdCD != cdSeleccionado.IdCD)
                    continue;

                if (servicio.CapacidadDisponible < totalBultos)
                    continue;

                var item = new ListViewItem(servicio.IdServicio.ToString());
                item.SubItems.Add(servicio.Empresa.RazonSocial);
                item.SubItems.Add(servicio.TipoArrendamiento.ToString());
                item.SubItems.Add(servicio.CapacidadDisponible.ToString());
                item.SubItems.Add("-"); // horario salida, por ahora vacío
                item.Tag = servicio;
                lvServicios.Items.Add(item);
            }

            if (lvServicios.Items.Count == 0 && totalBultos > 0)
                MessageBox.Show("No hay servicios disponibles con capacidad suficiente para los bultos seleccionados. Modifique la selección de guías.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGenerarHDR_Click(object sender, EventArgs e)
        {
            // Validar que haya al menos una guía seleccionada
            List<GuiaEntidad> guiasSeleccionadas = new List<GuiaEntidad>();
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((GuiaEntidad)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un servicio de transporte antes de generar la hoja de ruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya un servicio seleccionado
            ServicioMediaDistanciaEntidad servicioSeleccionado = null;
            if (lvServicios.SelectedItems.Count > 0)
                servicioSeleccionado = (ServicioMediaDistanciaEntidad)lvServicios.SelectedItems[0].Tag;

            if (servicioSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un servicio de transporte antes de generar la hoja de ruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la HDR
            HojaDeRutaTransporteEntidad nuevaHDR = new HojaDeRutaTransporteEntidad();
            nuevaHDR.NroHDR = modelo.HojasDeRuta.Count + 1;
            nuevaHDR.FechaEmision = DateTime.Today;
            nuevaHDR.CdOrigen = modelo.CdEmisor;
            nuevaHDR.CdDestino = (CentroDistribucionEntidad)cmbCDDestino.SelectedItem;
            nuevaHDR.Servicio = servicioSeleccionado;
            nuevaHDR.Guias = guiasSeleccionadas;
            nuevaHDR.Estado = EstadoHojaDeRutaTransporte.Generada;

            // Actualizar capacidad usada del servicio
            int totalBultos = 0;
            foreach (var guia in guiasSeleccionadas)
            {
                totalBultos += guia.EquivalenteS;
                guia.Estado = EstadoGuia.PendienteDeDespacho;
            }
            servicioSeleccionado.CapacidadUsada += totalBultos;

            // Registrar la HDR
            modelo.HojasDeRuta.Add(nuevaHDR);

            MessageBox.Show($"Hoja de Ruta de Transporte Nro {nuevaHDR.NroHDR} generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar la pantalla para una nueva operación
            lvServicios.Items.Clear();
            txtBultos.Text = "0";
            CargarGuiasPendientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
