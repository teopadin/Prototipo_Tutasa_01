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
            txtCdEmisor.Text = modelo.CdEmisor.nombre;
            dtpFecha.Value = DateTime.Today;
            CargarGuiasImpuestas();
        }

        private void CargarGuiasImpuestas()
        {
            modelo.Actualizando = true;
            lvGuiasPendientes.Items.Clear();

            foreach (var guia in modelo.Guias)
            {
                if (guia.Estado != EstadoGuiaEnum.Impuesta || guia.idCDOrigen.nombre != modelo.CdEmisor.nombre)
                    continue;

                string razonSocial, calle, altura, piso, cp, ciudad;

                if (guia.TipoImposicion == TipoImposicionEnum.CallCenter)
                {
                    razonSocial = guia.IdCliente.razonSocial;
                    calle = guia.IdCliente.calle;
                    altura = guia.IdCliente.altura.ToString();
                    piso = guia.IdCliente.piso;
                    cp = guia.IdCliente.codigoPostal;
                    ciudad = guia.IdCliente.ciudad;
                }
                else
                {
                    razonSocial = guia.idAgenciaOrigen.razonSocial;
                    calle = guia.idAgenciaOrigen.calle;
                    altura = guia.idAgenciaOrigen.altura.ToString();
                    piso = guia.idAgenciaOrigen.piso;
                    cp = guia.idAgenciaOrigen.codigoPostal;
                    ciudad = guia.idAgenciaOrigen.ciudad;
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

            if (guiaReferencia.TipoImposicion == TipoImposicionEnum.CallCenter)
            {
                calleRef = guiaReferencia.IdCliente.calle;
                alturaRef = guiaReferencia.IdCliente.altura.ToString();
                pisoRef = guiaReferencia.IdCliente.piso;
                cpRef = guiaReferencia.IdCliente.codigoPostal;
                ciudadRef = guiaReferencia.IdCliente.ciudad;
            }
            else
            {
                calleRef = guiaReferencia.idAgenciaOrigen.calle;
                alturaRef = guiaReferencia.idAgenciaOrigen.altura.ToString();
                pisoRef = guiaReferencia.idAgenciaOrigen.piso;
                cpRef = guiaReferencia.idAgenciaOrigen.codigoPostal;
                ciudadRef = guiaReferencia.idAgenciaOrigen.ciudad;
            }

            modelo.Actualizando = true;
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                Guia guia = (Guia)item.Tag;
                string calle, altura, piso, cp, ciudad;

                if (guia.TipoImposicion == TipoImposicionEnum.CallCenter)
                {
                    calle = guia.IdCliente.calle;
                    altura = guia.IdCliente.altura.ToString();
                    piso = guia.IdCliente.piso;
                    cp = guia.IdCliente.codigoPostal;
                    ciudad = guia.IdCliente.ciudad;
                }
                else
                {
                    calle = guia.idAgenciaOrigen.calle;
                    altura = guia.idAgenciaOrigen.altura.ToString();
                    piso = guia.idAgenciaOrigen.piso;
                    cp = guia.idAgenciaOrigen.codigoPostal;
                    ciudad = guia.idAgenciaOrigen.ciudad;
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
                if (transportista.idCD.nombre == modelo.CdEmisor.nombre)
                    transportistasFiltrados.Add(transportista);
            }

            transportistasFiltrados.Sort((a, b) => a.HdrAsignadas.CompareTo(b.HdrAsignadas));

            foreach (var transportista in transportistasFiltrados)
            {
                var item = new ListViewItem(transportista.dniTransportista.ToString());
                item.SubItems.Add(transportista.nombre);
                item.SubItems.Add(transportista.apellido);
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
                guia.Estado = EstadoGuiaEnum.IncluidaEnHDRRetiro;

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
