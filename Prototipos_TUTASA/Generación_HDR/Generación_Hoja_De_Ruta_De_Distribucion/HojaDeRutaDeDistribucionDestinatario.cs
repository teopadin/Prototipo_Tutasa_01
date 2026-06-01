using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.HojaDeRutaDeDistribucion
{
    public partial class HojaDeRutaDeDistribucionDestinatario : Form
    {
        private ModeloGenerarHDRDistribucion modelo = new ModeloGenerarHDRDistribucion();

        public HojaDeRutaDeDistribucionDestinatario()
        {
            InitializeComponent();
        }

        private void HojaDeRutaDeDistribucionDestinatario_Load(object sender, EventArgs e)
        {
            txtCdEmisor.Text = modelo.CdEmisor.Nombre;
            dtpFecha.Value = DateTime.Today;
            CargarGuiasPendientes();
        }

        private void CargarGuiasPendientes()
        {
            modelo.Actualizando = true;
            listViewGuiasADistribuir.Items.Clear();

            foreach (var guia in modelo.Guias)
            {
                bool esEnCDDestino = guia.Estado == EstadoGuia.EnCDDestino && guia.CdDestino.IdCD == modelo.CdEmisor.IdCD;
                bool esAdmitidaLocal = guia.Estado == EstadoGuia.Admitida && guia.CdOrigen.IdCD == modelo.CdEmisor.IdCD && guia.CdDestino.IdCD == modelo.CdEmisor.IdCD;

                if (!esEnCDDestino && !esAdmitidaLocal)
                    continue;

                string razonSocial, dni, calle, altura, piso, cp, ciudad;

                if (guia.ModalidadEntrega == ModalidadEntrega.PuertaAPuerta)
                {
                    razonSocial = $"{guia.Destinatario.Nombre} {guia.Destinatario.Apellido}";
                    dni = guia.Destinatario.Dni.ToString();
                    calle = guia.Destinatario.Calle;
                    altura = guia.Destinatario.Altura.ToString();
                    piso = guia.Destinatario.Piso;
                    cp = guia.Destinatario.CodigoPostal;
                    ciudad = guia.Destinatario.Ciudad;
                }
                else
                {
                    razonSocial = guia.Agencia.RazonSocial;
                    dni = "-";
                    calle = guia.Agencia.Calle;
                    altura = guia.Agencia.Altura.ToString();
                    piso = guia.Agencia.Piso;
                    cp = guia.Agencia.CodigoPostal;
                    ciudad = guia.Agencia.Ciudad;
                }

                var item = new ListViewItem(guia.NroGuia);
                item.SubItems.Add(guia.FechaImposicion.ToShortDateString());
                item.SubItems.Add(guia.ModalidadEntrega.ToString());
                item.SubItems.Add(razonSocial);
                item.SubItems.Add(dni);
                item.SubItems.Add(calle);
                item.SubItems.Add(altura);
                item.SubItems.Add(piso);
                item.SubItems.Add(cp);
                item.SubItems.Add(ciudad);
                item.Tag = guia;

                listViewGuiasADistribuir.Items.Add(item);
            }

            modelo.Actualizando = false;
        }

        private void listViewGuiasADistribuir_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (modelo.Actualizando) return;

            if (e.Item.ForeColor == System.Drawing.Color.Gray && e.Item.Checked)
            {
                modelo.Actualizando = true;
                e.Item.Checked = false;
                modelo.Actualizando = false;
                return;
            }

            ActualizarGuiasFiltradas();
            ActualizarCantGuias();
            CargarFleteros();
        }

        private void ActualizarGuiasFiltradas()
        {
            List<GuiaEntidad> guiasSeleccionadas = new List<GuiaEntidad>();
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((GuiaEntidad)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                CargarGuiasPendientes();
                listViewFleteros.Items.Clear();
                return;
            }

            GuiaEntidad guiaReferencia = guiasSeleccionadas[0];
            string calleRef, alturaRef, pisoRef, cpRef, ciudadRef;

            if (guiaReferencia.ModalidadEntrega == ModalidadEntrega.PuertaAPuerta)
            {
                calleRef = guiaReferencia.Destinatario.Calle;
                alturaRef = guiaReferencia.Destinatario.Altura.ToString();
                pisoRef = guiaReferencia.Destinatario.Piso;
                cpRef = guiaReferencia.Destinatario.CodigoPostal;
                ciudadRef = guiaReferencia.Destinatario.Ciudad;
            }
            else
            {
                calleRef = guiaReferencia.Agencia.Calle;
                alturaRef = guiaReferencia.Agencia.Altura.ToString();
                pisoRef = guiaReferencia.Agencia.Piso;
                cpRef = guiaReferencia.Agencia.CodigoPostal;
                ciudadRef = guiaReferencia.Agencia.Ciudad;
            }

            modelo.Actualizando = true;
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                GuiaEntidad guia = (GuiaEntidad)item.Tag;
                string calle, altura, piso, cp, ciudad;

                if (guia.ModalidadEntrega == ModalidadEntrega.PuertaAPuerta)
                {
                    calle = guia.Destinatario.Calle;
                    altura = guia.Destinatario.Altura.ToString();
                    piso = guia.Destinatario.Piso;
                    cp = guia.Destinatario.CodigoPostal;
                    ciudad = guia.Destinatario.Ciudad;
                }
                else
                {
                    calle = guia.Agencia.Calle;
                    altura = guia.Agencia.Altura.ToString();
                    piso = guia.Agencia.Piso;
                    cp = guia.Agencia.CodigoPostal;
                    ciudad = guia.Agencia.Ciudad;
                }

                if (calle != calleRef || altura != alturaRef || piso != pisoRef || cp != cpRef || ciudad != ciudadRef)
                    item.ForeColor = System.Drawing.Color.Gray;
                else
                    item.ForeColor = System.Drawing.Color.Black;
            }
            modelo.Actualizando = false;
        }

        private void ActualizarCantGuias()
        {
            int cant = 0;
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                if (item.Checked)
                    cant++;
            }
            txtCantGuias.Text = cant.ToString();
        }

        private void CargarFleteros()
        {
            listViewFleteros.Items.Clear();

            bool hayGuiasSeleccionadas = false;
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                if (item.Checked)
                {
                    hayGuiasSeleccionadas = true;
                    break;
                }
            }

            if (!hayGuiasSeleccionadas)
                return;

            List<TransportistaLocalEntidad> transportistasFiltrados = new List<TransportistaLocalEntidad>();
            foreach (var transportista in modelo.Transportistas)
            {
                if (transportista.CD.IdCD == modelo.CdEmisor.IdCD)
                    transportistasFiltrados.Add(transportista);
            }

            transportistasFiltrados.Sort((a, b) => a.HdrAsignadas.CompareTo(b.HdrAsignadas));

            foreach (var transportista in transportistasFiltrados)
            {
                var item = new ListViewItem(transportista.DniTransportista.ToString());
                item.SubItems.Add(transportista.Nombre);
                item.SubItems.Add(transportista.Apellido);
                item.SubItems.Add(transportista.HdrAsignadas.ToString());
                item.Tag = transportista;
                listViewFleteros.Items.Add(item);
            }
        }

        private void btnGenerarHdr_Click(object sender, EventArgs e)
        {
            // Validar que haya al menos una guía seleccionada
            List<GuiaEntidad> guiasSeleccionadas = new List<GuiaEntidad>();
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((GuiaEntidad)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Distribución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya un fletero seleccionado
            TransportistaLocalEntidad transportistaSeleccionado = null;
            if (listViewFleteros.SelectedItems.Count > 0)
                transportistaSeleccionado = (TransportistaLocalEntidad)listViewFleteros.SelectedItems[0].Tag;

            if (transportistaSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Distribución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la HDR
            HojaDeRutaDistribucionEntidad nuevaHDR = new HojaDeRutaDistribucionEntidad();
            nuevaHDR.NroHDR = modelo.HojasDeRuta.Count + 1;
            nuevaHDR.FechaEmision = dtpFecha.Value;
            nuevaHDR.CdEmisor = modelo.CdEmisor;
            nuevaHDR.Transportista = transportistaSeleccionado;
            nuevaHDR.Guias = guiasSeleccionadas;
            nuevaHDR.Estado = EstadoHojaDeRutaDistribucion.Generada;

            // Cambiar el estado de las guías a EnDistribucion
            foreach (var guia in guiasSeleccionadas)
                guia.Estado = EstadoGuia.EnDistribucion;

            // Incrementar las HDR asignadas al transportista
            transportistaSeleccionado.HdrAsignadas++;

            // Registrar la HDR
            modelo.HojasDeRuta.Add(nuevaHDR);

            MessageBox.Show($"Hoja de Ruta de Distribución Nro {nuevaHDR.NroHDR} generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar la pantalla para una nueva operación
            listViewFleteros.Items.Clear();
            CargarGuiasPendientes();
            ActualizarCantGuias();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
