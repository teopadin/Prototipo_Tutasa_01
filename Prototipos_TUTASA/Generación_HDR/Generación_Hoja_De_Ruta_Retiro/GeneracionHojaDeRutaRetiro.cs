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
                if (guia.Estado != EstadoGuiaEnum.Impuesta || guia.idCDOrigen != modelo.CdEmisor.idCD)
                    continue;

                string razonSocial, calle, altura, piso, cp, ciudad;

                if (guia.TipoImposicion == TipoImposicionEnum.CallCenter)
                {
                    Cliente cliente = modelo.BuscarCliente(guia.IdCliente.Value);
                    razonSocial = cliente.razonSocial;
                    calle = cliente.calle;
                    altura = cliente.altura.ToString();
                    piso = cliente.piso;
                    cp = cliente.codigoPostal;
                    ciudad = cliente.ciudad;
                }
                else
                {
                    Agencia agencia = modelo.BuscarAgencia(guia.idAgenciaOrigen.Value);
                    razonSocial = agencia.razonSocial;
                    calle = agencia.calle;
                    altura = agencia.altura.ToString();
                    piso = agencia.piso;
                    cp = agencia.codigoPostal;
                    ciudad = agencia.ciudad;
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
                Cliente cliente = modelo.BuscarCliente(guiaReferencia.IdCliente.Value);
                calleRef = cliente.calle;
                alturaRef = cliente.altura.ToString();
                pisoRef = cliente.piso;
                cpRef = cliente.codigoPostal;
                ciudadRef = cliente.ciudad;
            }
            else
            {
                Agencia agencia = modelo.BuscarAgencia(guiaReferencia.idAgenciaOrigen.Value);
                calleRef = agencia.calle;
                alturaRef = agencia.altura.ToString();
                pisoRef = agencia.piso;
                cpRef = agencia.codigoPostal;
                ciudadRef = agencia.ciudad;
            }

            modelo.Actualizando = true;
            foreach (ListViewItem item in lvGuiasPendientes.Items)
            {
                Guia guia = (Guia)item.Tag;
                string calle, altura, piso, cp, ciudad;

                if (guia.TipoImposicion == TipoImposicionEnum.CallCenter)
                {
                    Cliente cliente = modelo.BuscarCliente(guia.IdCliente.Value);
                    calle = cliente.calle;
                    altura = cliente.altura.ToString();
                    piso = cliente.piso;
                    cp = cliente.codigoPostal;
                    ciudad = cliente.ciudad;
                }
                else
                {
                    Agencia agencia = modelo.BuscarAgencia(guia.idAgenciaOrigen.Value);
                    calle = agencia.calle;
                    altura = agencia.altura.ToString();
                    piso = agencia.piso;
                    cp = agencia.codigoPostal;
                    ciudad = agencia.ciudad;
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
                if (transportista.idCD == modelo.CdEmisor.idCD)
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
            List<Guia> guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in lvGuiasPendientes.Items)
                if (item.Checked)
                    guiasSeleccionadas.Add((Guia)item.Tag);

            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Retiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TransportistaLocal transportistaSeleccionado = null;
            if (lvFleteros.SelectedItems.Count > 0)
                transportistaSeleccionado = (TransportistaLocal)lvFleteros.SelectedItems[0].Tag;

            if (transportistaSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar al menos una guía y un fletero para generar la Hoja de Ruta de Retiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaHDR = modelo.GenerarHDR(guiasSeleccionadas, transportistaSeleccionado, dtpFecha.Value.Date);
            MessageBox.Show($"Hoja de Ruta de Retiro {nuevaHDR.NroHDR} generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lvFleteros.Items.Clear();
            CargarGuiasImpuestas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvFleteros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
