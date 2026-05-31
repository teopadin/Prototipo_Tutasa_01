using Prototipos_TUTASA.Imposición.Imposición_Agencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.ImposiciónAgencia_v2
{
    public partial class ImposicionAgencia_v2 : Form
    {
        private ModeloImposicionAgencia modelo = new ModeloImposicionAgencia();
        public ImposicionAgencia_v2()
        {
            InitializeComponent();
        }
        private void btnGenerarGuia_Click(object sender, EventArgs e)
        {
            RegistrarImposicion(ObtenerDatosFormulario());
        }

        private void ImposicionAgencia_v2_Load(object sender, EventArgs e)
        {
            ObtenerClientes();
        }

        // ─── CARGA INICIAL ───────────────────────────────────────────────

        private void ObtenerClientes()
        {
            List<ClienteEntidad> listaClientes = modelo.Clientes;
            cboRazonSocial.DataSource = listaClientes;
            cboRazonSocial.DisplayMember = "RazonSocial";
            cboRazonSocial.ValueMember = "CUIT";
            cboRazonSocial.SelectedIndex = -1;
        }

        // ─── REMITENTE ───────────────────────────────────────────────────

        private void ObtenerDatosCliente(string razonSocial)
        {
            ClienteEntidad datosCliente = BuscarClientePorRazonSocial(razonSocial);

            if (datosCliente == null) return;

            txtCUIT.Text = datosCliente.CUIT.ToString();
            txtTelRem.Text = datosCliente.Telefono.ToString();
            txtCalleRemitente.Text = datosCliente.Calle;
            txtAlturaRemitente.Text = datosCliente.Altura.ToString();
            txtPisoRemitente.Text = datosCliente.Piso;
            txtCodigoPostalRemitente.Text = datosCliente.CodigoPostal;
            txtCiudadRemitente.Text = datosCliente.Ciudad;
        }

        private ClienteEntidad BuscarClientePorRazonSocial(string razonSocial)
        {
            return modelo.Clientes.Find(c => c.RazonSocial == razonSocial);
        }

        private void cboRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRazonSocial.SelectedIndex == -1) return;
            ObtenerDatosCliente(cboRazonSocial.Text);
        }
        // ─── MODALIDAD DE ENTREGA ────────────────────────────────────────

        private void rbPuertaPuerta_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbPuertaPuerta.Checked) return;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
        }

        private void rbRetiroAgencia_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbRetiroAgencia.Checked) return;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = true;
            ObtenerAgencias();
        }

        private void rbRetiroCD_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbRetiroCD.Checked) return;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox7.Visible = false;
            ObtenerCDsDestino();
        }

        // ─── AGENCIAS ────────────────────────────────────────────────────

        private void ObtenerAgencias()
        {
            List<AgenciaEntidad> listaAgencias = modelo.Agencias;
            cbSeleccionarAgencia.DataSource = listaAgencias;
            cbSeleccionarAgencia.DisplayMember = "RazonSocial";
            cbSeleccionarAgencia.ValueMember = "IdAgencia";
            cbSeleccionarAgencia.SelectedIndex = -1;
        }

        // ─── CDs DESTINO ─────────────────────────────────────────────────

        private void ObtenerCDsDestino()
        {
            List<CentroDistribucionEntidad> listaCDs = modelo.CentrosDeDistribucion;
            cbCDDestino.DataSource = listaCDs;
            cbCDDestino.DisplayMember = "Nombre";
            cbCDDestino.ValueMember = "IdCD";
            cbCDDestino.SelectedIndex = -1;
        }
        // ─── REGISTRAR IMPOSICIÓN ─────────────────────────────────────────


        private GuiaEntidad ObtenerDatosFormulario()
        {
            var guia = new GuiaEntidad();

            guia.FechaImposicion = DateTime.Now;
            guia.Estado = EstadoGuia.Impuesta;

            // Destinatario
            guia.Destinatario = new DestinatarioEntidad
            {
                Nombre = txtNombreDest.Text.Trim(),
                Apellido = txtApellidoDest.Text.Trim(),
                Dni = int.TryParse(txtDNIDest.Text.Trim(), out int dni) ? dni : 0,
                Telefono = txtTelDest.Text.Trim()
            };

            // Tipo de bulto
            if (rbS.Checked) guia.TipoBulto = TipoBulto.S;
            else if (rbM.Checked) guia.TipoBulto = TipoBulto.M;
            else if (rbL.Checked) guia.TipoBulto = TipoBulto.L;
            else if (rbXL.Checked) guia.TipoBulto = TipoBulto.XL;

            // Modalidad y datos específicos
            if (rbPuertaPuerta.Checked)
            {
                guia.ModalidadEntrega = ModalidadEntrega.PuertaPuerta;
                guia.Destinatario.Calle = tbCalleDest.Text.Trim();
                guia.Destinatario.Altura = int.TryParse(tbAlturaDest.Text.Trim(), out int alt) ? alt : 0;
                guia.Destinatario.Piso = tbPisoDest.Text.Trim();
                guia.Destinatario.CodigoPostal = tbCDDest.Text.Trim();
                guia.Destinatario.Ciudad = tbCiudadDest.Text.Trim();
                guia.Agencia = null;
                guia.CdOrigen = ObtenerCDAsociadoAAgencia();
                guia.CdDestino = ObtenerCDAsociadoAAgencia();
            }
            else if (rbRetiroAgencia.Checked)
            {
                guia.ModalidadEntrega = ModalidadEntrega.RetiroAgencia;
                guia.Agencia = cbSeleccionarAgencia.SelectedItem as AgenciaEntidad;
                guia.CdOrigen = ObtenerCDAsociadoAAgencia();
                guia.CdDestino = ObtenerCDAsociadoAAgencia();
            }
            else if (rbRetiroCD.Checked)
            {
                guia.ModalidadEntrega = ModalidadEntrega.RetiroCD;
                guia.CdDestino = cbCDDestino.SelectedItem as CentroDistribucionEntidad;
                guia.CdOrigen = null;
                guia.Agencia = null;
            }

            return guia;
        }

        private void RegistrarImposicion(GuiaEntidad guia)
        {
            if (!ValidarCamposObligatorios(guia)) return;

            guia.NroGuia = GenerarNroGuia(guia.CdOrigen);
            modelo.Guias.Add(guia);

            MessageBox.Show($"Guía N° {guia.NroGuia} generada con éxito.", "Imposición registrada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private string GenerarNroGuia(CentroDistribucionEntidad cdOrigen)
        {
            int nro = modelo.Guias.Count + 1;
            return $"A{cdOrigen.IdCD:D2}-{nro:D4}";
        }

        private CentroDistribucionEntidad ObtenerCDAsociadoAAgencia()
        {
            if (cbSeleccionarAgencia.SelectedItem is AgenciaEntidad agencia)
                return agencia.CD;
            return null;
        }

        // ─── VALIDACIONES ────────────────────────────────────────────────

        private bool ValidarCamposObligatorios(GuiaEntidad guia)
        {
            if (cboRazonSocial.SelectedIndex == -1)
                return ErrorCamposObligatorios("Debe seleccionar un remitente.");

            if (string.IsNullOrWhiteSpace(txtNombreDest.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDest.Text) ||
                string.IsNullOrWhiteSpace(txtDNIDest.Text) ||
                string.IsNullOrWhiteSpace(txtTelDest.Text))
                return ErrorCamposObligatorios("Debe completar todos los datos del destinatario.");

            if (!int.TryParse(txtDNIDest.Text.Trim(), out _))
                return ErrorFormatoInvalido("DNI");

            if (!rbS.Checked && !rbM.Checked && !rbL.Checked && !rbXL.Checked)
                return ErrorCamposObligatorios("Debe seleccionar un tipo de bulto.");

            if (!rbPuertaPuerta.Checked && !rbRetiroAgencia.Checked && !rbRetiroCD.Checked)
                return ErrorCamposObligatorios("Debe seleccionar una modalidad de entrega.");

            if (rbPuertaPuerta.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbCalleDest.Text) ||
                    string.IsNullOrWhiteSpace(tbAlturaDest.Text) ||
                    string.IsNullOrWhiteSpace(tbCDDest.Text) ||
                    string.IsNullOrWhiteSpace(tbCiudadDest.Text))
                    return ErrorCamposObligatorios("Debe completar todos los datos de entrega puerta a puerta.");

                if (!int.TryParse(tbAlturaDest.Text.Trim(), out _))
                    return ErrorFormatoInvalido("Altura");
            }

            if (rbRetiroAgencia.Checked && cbSeleccionarAgencia.SelectedIndex == -1)
                return ErrorCamposObligatorios("Debe seleccionar una agencia.");

            if (rbRetiroCD.Checked && cbCDDestino.SelectedIndex == -1)
                return ErrorCamposObligatorios("Debe seleccionar un CD destino.");

            return true;
        }

        private bool ErrorCamposObligatorios(string mensaje)
        {
            MessageBox.Show(mensaje, "Campos obligatorios incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool ErrorFormatoInvalido(string campo)
        {
            MessageBox.Show($"El campo {campo} ingresado no es válido.", "Formato de dato inválido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // ─── CANCELAR ────────────────────────────────────────────────────

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
