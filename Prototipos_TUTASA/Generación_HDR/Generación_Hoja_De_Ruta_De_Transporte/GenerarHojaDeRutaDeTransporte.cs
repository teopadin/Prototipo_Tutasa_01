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
                if (cd.Nombre != modelo.CdEmisor.Nombre)
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
            modelo.Actualizando = true;
            lvGuiasPendientes.Items.Clear();

            CentroDistribucion cdSeleccionado = (CentroDistribucion)cmbCDDestino.SelectedItem;

            foreach (var guia in modelo.Guias)
            {
                if (guia.Estado != EstadoGuiaEnum.Admitida || guia.CdActual.Nombre != modelo.CdEmisor.Nombre)
                    continue;

                var item = new ListViewItem(guia.NroGuia);
                item.SubItems.Add(guia.FechaImposicion.ToShortDateString());
                item.SubItems.Add(guia.TipoBulto.ToString());
                item.SubItems.Add(guia.CdDestino.Nombre);
                item.Tag = guia;

                lvGuiasPendientes.Items.Add(item);
            }

            modelo.Actualizando = false;
        }

        private void lvGuiasPendientes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (modelo.Actualizando) return;

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
                    Guia guia = (Guia)item.Tag;
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
                    Guia guia = (Guia)item.Tag;
                    totalBultos += guia.EquivalenteS;
                }
            }

            if (totalBultos == 0)
                return;

            CentroDistribucion cdSeleccionado = (CentroDistribucion)cmbCDDestino.SelectedItem;

            foreach (var servicio in modelo.Servicios)
            {
                if (servicio.CdOrigen.Nombre != modelo.CdEmisor.Nombre || servicio.CdDestino.Nombre != cdSeleccionado.Nombre)
                    continue;

                if (!modelo.TieneCapacidadSuficiente(servicio, totalBultos))
                    continue;

                var item = new ListViewItem(servicio.IdServicio.ToString());
                item.SubItems.Add(servicio.Empresa.RazonSocial);
                item.SubItems.Add(servicio.TipoArrendamiento.ToString());
                item.SubItems.Add(servicio.CapacidadDisponible.ToString());
                item.SubItems.Add(servicio.HorarioSalida.ToString(@"hh\:mm"));
                item.Tag = servicio;
                lvServicios.Items.Add(item);
            }

            if (lvServicios.Items.Count == 0 && totalBultos > 0)
                MessageBox.Show("No hay servicios disponibles con capacidad suficiente para los bultos seleccionados. Modifique la selección de guías.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGenerarHDR_Click(object sender, EventArgs e)
        {
            // Validar que haya al menos una guía seleccionada
            List<Guia> guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((Guia)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un servicio de transporte antes de generar la hoja de ruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya un servicio seleccionado
            ServicioMediaDistancia servicioSeleccionado = null;
            if (lvServicios.SelectedItems.Count > 0)
                servicioSeleccionado = (ServicioMediaDistancia)lvServicios.SelectedItems[0].Tag;

            if (servicioSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un servicio de transporte antes de generar la hoja de ruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HojaDeRutaTransporte nuevaHDR = new HojaDeRutaTransporte();
            nuevaHDR.NroHDR = modelo.HojasDeRuta.Count + 1;

            // Actualizar capacidad usada del servicio
            int totalBultos = 0;
            foreach (var guia in guiasSeleccionadas)
            {
                totalBultos += guia.EquivalenteS;
                guia.Estado = EstadoGuiaEnum.PendienteDeDespacho;
            }
            servicioSeleccionado.CapacidadUsada += totalBultos;

            modelo.HojasDeRuta.Add(nuevaHDR);

            MessageBox.Show($"Hoja de Ruta de Transporte {nuevaHDR.NroHDR} generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
