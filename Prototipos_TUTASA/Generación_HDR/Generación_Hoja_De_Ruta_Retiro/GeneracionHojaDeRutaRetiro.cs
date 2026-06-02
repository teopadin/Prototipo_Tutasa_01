using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.HojaDeRutaRetiro
{
    public partial class GeneracionHojaDeRutaRetiro : Form
    {
        private ModeloGenerarHDRRetiro modelo = new ModeloGenerarHDRRetiro();
        public GeneracionHojaDeRutaRetiro()
        {
            InitializeComponent();
        }

        private void GeneracionHojaDeRutaRetiro_Load(object sender, EventArgs e)
        {
            txtCdEmisor.Text = modelo.CdEmisor.Nombre;
            dtpFecha.Value = DateTime.Today;
            CargarGuiasImpuestas();
        }

        private void CargarGuiasImpuestas()
        {
            modelo.Actualizando = true;
            lvGuiasPendientes.Items.Clear();

            foreach (var guia in modelo.Guias)
            {
                if (guia.Estado != EstadoGuia.Impuesta || guia.CdOrigen.Nombre != modelo.CdEmisor.Nombre)
                    continue;

                string razonSocial, calle, altura, piso, cp, ciudad;

                if (guia.TipoImposicion == TipoImposicion.CallCenter)
                {
                    razonSocial = guia.ClienteGuia.RazonSocial;
                    calle = guia.ClienteGuia.Calle;
                    altura = guia.ClienteGuia.Altura.ToString();
                    piso = guia.ClienteGuia.Piso;
                    cp = guia.ClienteGuia.CodigoPostal;
                    ciudad = guia.ClienteGuia.Ciudad;
                }
                else
                {
                    razonSocial = guia.Agencia.RazonSocial;
                    calle = guia.Agencia.Calle;
                    altura = guia.Agencia.Altura.ToString();
                    piso = guia.Agencia.Piso;
                    cp = guia.Agencia.CodigoPostal;
                    ciudad = guia.Agencia.Ciudad;
                }

                var item = new ListViewItem(guia.NroGuia);
                item.SubItems.Add(guia.TipoImposicion.ToString());
                item.SubItems.Add(razonSocial);
                item.SubItems.Add(calle);
                item.SubItems.Add(altura);
                item.SubItems.Add(piso);
                item.SubItems.Add(cp);
                item.SubItems.Add(ciudad);
                item.SubItems.Add(guia.TipoBulto.ToString());
                item.SubItems.Add(guia.FechaImposicion.ToShortDateString());
                item.Tag = guia;

                lvGuiasPendientes.Items.Add(item);
            }

            modelo.Actualizando = false;
        }

        private void lvGuiasPendientes_ItemChecked(object sender, ItemCheckedEventArgs e)
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
            ObtenerTransportistas();
        }

        private void ActualizarGuiasFiltradas()
        {
            List<Guia> guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((Guia)item.Tag);
            }

            if (guiasSeleccionadas.Count == 0)
            {
                CargarGuiasImpuestas();
                lvFleteros.Items.Clear();
                return;
            }

            Guia guiaReferencia = guiasSeleccionadas[0];
            string calleRef, alturaRef, pisoRef, cpRef, ciudadRef;

            if (guiaReferencia.TipoImposicion == TipoImposicion.CallCenter)
            {
                calleRef = guiaReferencia.ClienteGuia.Calle;
                alturaRef = guiaReferencia.ClienteGuia.Altura.ToString();
                pisoRef = guiaReferencia.ClienteGuia.Piso;
                cpRef = guiaReferencia.ClienteGuia.CodigoPostal;
                ciudadRef = guiaReferencia.ClienteGuia.Ciudad;
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
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                Guia guia = (Guia)item.Tag;
                string calle, altura, piso, cp, ciudad;

                if (guia.TipoImposicion == TipoImposicion.CallCenter)
                {
                    calle = guia.ClienteGuia.Calle;
                    altura = guia.ClienteGuia.Altura.ToString();
                    piso = guia.ClienteGuia.Piso;
                    cp = guia.ClienteGuia.CodigoPostal;
                    ciudad = guia.ClienteGuia.Ciudad;
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


        private void ObtenerTransportistas()
        {
            lvFleteros.Items.Clear();

            bool hayGuiasSeleccionadas = false;
            foreach (ListViewItem item in lvGuiasPendientes.Items)
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
                if (transportista.CD.Nombre == modelo.CdEmisor.Nombre)
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
                lvFleteros.Items.Add(item);
            }
        }

        private void btnGenerarHdr_Click(object sender, EventArgs e)
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
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Retiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya un fletero seleccionado
            TransportistaLocal transportistaSeleccionado = null;
            if (lvFleteros.SelectedItems.Count > 0)
                transportistaSeleccionado = (TransportistaLocal)lvFleteros.SelectedItems[0].Tag;

            if (transportistaSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Retiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro nuevaHDR = new Generación_HDR.Generación_Hoja_De_Ruta_Retiro.HojaDeRutaRetiro();
            nuevaHDR.NroHDR = modelo.HojasDeRuta.Count + 1;

            // Cambiar el estado de las guías a PendienteDeRetiroPorTransportista
            foreach (var guia in guiasSeleccionadas)
                guia.Estado = EstadoGuia.PendienteDeRetiroPorTransportista;

            // Incrementar las HDR asignadas al transportista
            transportistaSeleccionado.HdrAsignadas++;

            modelo.HojasDeRuta.Add(nuevaHDR);

            MessageBox.Show($"Hoja de Ruta de Retiro  {nuevaHDR.NroHDR} generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar la pantalla para una nueva operación
            lvFleteros.Items.Clear();
            CargarGuiasImpuestas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
