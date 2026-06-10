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
            txtCdEmisor.Text = modelo.CdEmisor.nombre;
            dtpFecha.Value = DateTime.Today;
            CargarGuiasPendientes();
        }

        private void CargarGuiasPendientes()
        {
            modelo.Actualizando = true;
            listViewGuiasADistribuir.Items.Clear();

            foreach (var guia in modelo.Guias)
            {
                bool esEnCDDestino = guia.Estado == EstadoGuiaEnum.EnCDDestino && guia.idCDDestino.nombre == modelo.CdEmisor.nombre;
                bool esAdmitidaLocal = guia.Estado == EstadoGuiaEnum.Admitida && guia.idCDOrigen.nombre == modelo.CdEmisor.nombre && guia.idCDDestino.nombre == modelo.CdEmisor.nombre;

                if (!esEnCDDestino && !esAdmitidaLocal)
                    continue;

                string razonSocial, dni, calle, altura, piso, cp, ciudad;

                if (guia.ModalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
                {
                    razonSocial = $"{guia.Destinatario.nombre} {guia.Destinatario.apellido}";
                    dni = guia.Destinatario.Dni.ToString();
                    calle = guia.Destinatario.calle;
                    altura = guia.Destinatario.altura.ToString();
                    piso = guia.Destinatario.piso;
                    cp = guia.Destinatario.codigoPostal;
                    ciudad = guia.Destinatario.ciudad;
                }
                else
                {
                    razonSocial = guia.AgenciaGuia.razonSocial;
                    dni = "-";
                    calle = guia.AgenciaGuia.calle;
                    altura = guia.AgenciaGuia.altura.ToString();
                    piso = guia.AgenciaGuia.piso;
                    cp = guia.AgenciaGuia.codigoPostal;
                    ciudad = guia.AgenciaGuia.ciudad;
                }

                var item = new ListViewItem(guia.NroGuia);
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
            List<Guia> guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((Guia)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                CargarGuiasPendientes();
                listViewFleteros.Items.Clear();
                return;
            }

            Guia guiaReferencia = guiasSeleccionadas[0];
            string calleRef, alturaRef, pisoRef, cpRef, ciudadRef;

            if (guiaReferencia.ModalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
            {
                calleRef = guiaReferencia.Destinatario.calle;
                alturaRef = guiaReferencia.Destinatario.altura.ToString();
                pisoRef = guiaReferencia.Destinatario.piso;
                cpRef = guiaReferencia.Destinatario.codigoPostal;
                ciudadRef = guiaReferencia.Destinatario.ciudad;
            }
            else
            {
                calleRef = guiaReferencia.AgenciaGuia.calle;
                alturaRef = guiaReferencia.AgenciaGuia.altura.ToString();
                pisoRef = guiaReferencia.AgenciaGuia.piso;
                cpRef = guiaReferencia.AgenciaGuia.codigoPostal;
                ciudadRef = guiaReferencia.AgenciaGuia.ciudad;
            }

            modelo.Actualizando = true;
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                Guia guia = (Guia)item.Tag;
                string calle, altura, piso, cp, ciudad;

                if (guia.ModalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
                {
                    calle = guia.Destinatario.calle;
                    altura = guia.Destinatario.altura.ToString();
                    piso = guia.Destinatario.piso;
                    cp = guia.Destinatario.codigoPostal;
                    ciudad = guia.Destinatario.ciudad;
                }
                else
                {
                    calle = guia.AgenciaGuia.calle;
                    altura = guia.AgenciaGuia.altura.ToString();
                    piso = guia.AgenciaGuia.piso;
                    cp = guia.AgenciaGuia.codigoPostal;
                    ciudad = guia.AgenciaGuia.ciudad;
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

            List<TransportistaLocal> transportistasFiltrados = new List<TransportistaLocal>();
            foreach (var transportista in modelo.Transportistas)
            {
                if (transportista.CD.nombre == modelo.CdEmisor.nombre)
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
            List<Guia> guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in listViewGuiasADistribuir.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((Guia)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Distribución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya un fletero seleccionado
            TransportistaLocal transportistaSeleccionado = null;
            if (listViewFleteros.SelectedItems.Count > 0)
                transportistaSeleccionado = (TransportistaLocal)listViewFleteros.SelectedItems[0].Tag;

            if (transportistaSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Distribución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HojaDeRutaDistribucion nuevaHDR = new HojaDeRutaDistribucion();
            nuevaHDR.NroHDR = modelo.HojasDeRuta.Count + 1;

            // Cambiar el estado de las guías a EnDistribucion
            foreach (var guia in guiasSeleccionadas)
                guia.Estado = EstadoGuiaEnum.EnDistribucion;

            // Incrementar las HDR asignadas al transportista
            transportistaSeleccionado.HdrAsignadas++;

            modelo.HojasDeRuta.Add(nuevaHDR);

            MessageBox.Show($"Hoja de Ruta de Distribución {nuevaHDR.NroHDR} generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
