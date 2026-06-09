using Prototipos_TUTASA.Imposición.Imposición_Agencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.ImposiciónAgencia_v2
{
    public partial class ImposicionAgencia_v2 : Form
    {
        private ModeloImposicionAgencia modelo = new ModeloImposicionAgencia();

        public ImposicionAgencia_v2()
        {
            InitializeComponent();
            Load += ImposicionAgencia_v2_Load;
            cboRazonSocial.SelectedIndexChanged += cboRazonSocial_SelectedIndexChanged;
            rbPuertaPuerta.CheckedChanged += Modalidad_CheckedChanged;
            rbRetiroAgencia.CheckedChanged += Modalidad_CheckedChanged;
            rbRetiroCD.CheckedChanged += Modalidad_CheckedChanged;
            btCancelar.Click += btCancelar_Click;
        }

        private void ImposicionAgencia_v2_Load(object sender, EventArgs e)
        {
            ConfigurarCombos();
            CargarClientes();
            CargarAgencias();
            CargarCentrosDeDistribucion();
            ConfigurarCamposRemitente();
            LimpiarDatosRemitente();
            ActualizarModalidad();
        }

        private void btnGenerarGuia_Click(object sender, EventArgs e)
        {
            Cliente cliente = cboRazonSocial.SelectedItem as Cliente;
            if (cliente == null)
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            if (!ValidarDatosRemitente())
                return;

            if (string.IsNullOrWhiteSpace(txtNombreDest.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDest.Text) ||
                string.IsNullOrWhiteSpace(txtDNIDest.Text) ||
                string.IsNullOrWhiteSpace(txtTelDest.Text))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            if (!int.TryParse(txtDNIDest.Text.Trim(), out int dniDestinatario) || dniDestinatario <= 0)
            {
                MostrarAviso("El campo DNI ingresado no es válido.");
                return;
            }

            if (!EsSoloNumerico(txtTelDest.Text))
            {
                MostrarAviso("El campo Teléfono ingresado no es válido.");
                return;
            }

            if (!TryObtenerTipoBulto(out TipoBulto tipoBulto))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            if (!TryObtenerModalidadEntrega(out ModalidadEntrega modalidadEntrega))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            DestinatarioGuia destinatario = new DestinatarioGuia
            {
                Dni = dniDestinatario,
                Nombre = txtNombreDest.Text.Trim(),
                Apellido = txtApellidoDest.Text.Trim(),
                Telefono = txtTelDest.Text.Trim()
            };

            Agencia agenciaDestino = null;
            CentroDistribucion cdDestino = null;

            if (modalidadEntrega == ModalidadEntrega.EntregaDomicilio)
            {
                if (!ValidarDomicilioPuertaPuerta())
                    return;

                cdDestino = cbCDDestino.SelectedItem as CentroDistribucion;
                if (cdDestino == null)
                {
                    MostrarAviso("Debe seleccionar un centro de distribución destino.");
                    return;
                }

                destinatario.Calle = tbCalleDest.Text.Trim();
                destinatario.Altura = int.Parse(tbAlturaDest.Text.Trim());
                destinatario.Piso = tbPisoDest.Text.Trim();
                destinatario.CodigoPostal = tbCDDest.Text.Trim();
                destinatario.Ciudad = tbCiudadDest.Text.Trim();
            }
            else if (modalidadEntrega == ModalidadEntrega.EntregaAgencia)
            {
                agenciaDestino = cbSeleccionarAgencia.SelectedItem as Agencia;
                if (agenciaDestino == null)
                {
                    MostrarAviso("Debe completar todos los campos obligatorios.");
                    return;
                }

                cdDestino = agenciaDestino.CD;
            }
            else if (modalidadEntrega == ModalidadEntrega.EntregaCD)
            {
                cdDestino = cbCDDestino.SelectedItem as CentroDistribucion;
                if (cdDestino == null)
                {
                    MostrarAviso("Debe completar todos los campos obligatorios.");
                    return;
                }

                destinatario.Calle = string.Empty;
                destinatario.Altura = 0;
                destinatario.Piso = string.Empty;
                destinatario.CodigoPostal = string.Empty;
                destinatario.Ciudad = cdDestino.Nombre;
            }

            Guia guia = modelo.RegistrarImposicion();

            MessageBox.Show(
                "Guía N° " + guia.NroGuia + " generada con éxito.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void cboRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = cboRazonSocial.SelectedItem as Cliente;
            if (cliente == null)
            {
                LimpiarDatosRemitente();
                return;
            }

            txtCUIT.Text = cliente.CUIT.ToString();
            txtTelRem.Text = cliente.Telefono;
            txtCalleRemitente.Text = cliente.Calle;
            txtAlturaRemitente.Text = cliente.Altura.ToString();
            txtPisoRemitente.Text = cliente.Piso;
            txtCodigoPostalRemitente.Text = cliente.CodigoPostal;
            txtCiudadRemitente.Text = cliente.Ciudad;
        }

        private void Modalidad_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarModalidad();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarCombos()
        {
            cboRazonSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSeleccionarAgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCDDestino.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarClientes()
        {
            cboRazonSocial.DataSource = null;
            cboRazonSocial.Items.Clear();
            cboRazonSocial.DisplayMember = "RazonSocial";
            cboRazonSocial.DataSource = new List<Cliente>(modelo.Clientes);
            cboRazonSocial.SelectedIndex = -1;
        }

        private void CargarAgencias()
        {
            cbSeleccionarAgencia.DataSource = null;
            cbSeleccionarAgencia.Items.Clear();
            cbSeleccionarAgencia.DisplayMember = "RazonSocial";
            cbSeleccionarAgencia.DataSource = new List<Agencia>(modelo.Agencias);
            cbSeleccionarAgencia.SelectedIndex = -1;
        }

        private void CargarCentrosDeDistribucion()
        {
            cbCDDestino.DataSource = null;
            cbCDDestino.Items.Clear();
            cbCDDestino.DisplayMember = "Nombre";
            cbCDDestino.DataSource = new List<CentroDistribucion>(modelo.CentrosDeDistribucion);
            cbCDDestino.SelectedIndex = -1;
        }

        private void ConfigurarCamposRemitente()
        {
            txtCUIT.ReadOnly = true;
            txtTelRem.ReadOnly = true;
            txtCalleRemitente.ReadOnly = true;
            txtAlturaRemitente.ReadOnly = true;
            txtPisoRemitente.ReadOnly = true;
            txtCodigoPostalRemitente.ReadOnly = true;
            txtCiudadRemitente.ReadOnly = true;
        }

        private void LimpiarDatosRemitente()
        {
            txtCUIT.Clear();
            txtTelRem.Clear();
            txtCalleRemitente.Clear();
            txtAlturaRemitente.Clear();
            txtPisoRemitente.Clear();
            txtCodigoPostalRemitente.Clear();
            txtCiudadRemitente.Clear();
        }

        private void ActualizarModalidad()
        {
            groupBox4.Enabled = rbPuertaPuerta.Checked;
            groupBox7.Enabled = rbRetiroAgencia.Checked;
            groupBox5.Enabled = rbPuertaPuerta.Checked || rbRetiroCD.Checked;

            if (!rbPuertaPuerta.Checked)
                LimpiarDomicilioPuertaPuerta();

            if (!rbRetiroAgencia.Checked)
                cbSeleccionarAgencia.SelectedIndex = -1;

            if (!rbPuertaPuerta.Checked && !rbRetiroCD.Checked)
                cbCDDestino.SelectedIndex = -1;
        }

        private void LimpiarDomicilioPuertaPuerta()
        {
            tbCalleDest.Clear();
            tbAlturaDest.Clear();
            tbPisoDest.Clear();
            tbCDDest.Clear();
            tbCiudadDest.Clear();
        }

        private bool ValidarDatosRemitente()
        {
            if (string.IsNullOrWhiteSpace(txtCUIT.Text) ||
                string.IsNullOrWhiteSpace(txtTelRem.Text) ||
                string.IsNullOrWhiteSpace(txtCalleRemitente.Text) ||
                string.IsNullOrWhiteSpace(txtAlturaRemitente.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostalRemitente.Text) ||
                string.IsNullOrWhiteSpace(txtCiudadRemitente.Text))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return false;
            }

            if (!long.TryParse(txtCUIT.Text.Trim(), out long cuit) || cuit <= 0)
            {
                MostrarAviso("El campo CUIT ingresado no es válido.");
                return false;
            }

            if (!EsSoloNumerico(txtTelRem.Text))
            {
                MostrarAviso("El campo Teléfono ingresado no es válido.");
                return false;
            }

            if (!int.TryParse(txtAlturaRemitente.Text.Trim(), out int alturaRemitente) || alturaRemitente <= 0)
            {
                MostrarAviso("El campo Altura ingresado no es válido.");
                return false;
            }

            if (!EsSoloNumerico(txtCodigoPostalRemitente.Text))
            {
                MostrarAviso("El campo Codigo postal ingresado no es válido.");
                return false;
            }

            return true;
        }

        private bool ValidarDomicilioPuertaPuerta()
        {
            if (string.IsNullOrWhiteSpace(tbCalleDest.Text) ||
                string.IsNullOrWhiteSpace(tbAlturaDest.Text) ||
                string.IsNullOrWhiteSpace(tbCDDest.Text) ||
                string.IsNullOrWhiteSpace(tbCiudadDest.Text))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return false;
            }

            if (!int.TryParse(tbAlturaDest.Text.Trim(), out int alturaDestino) || alturaDestino <= 0)
            {
                MostrarAviso("El campo Altura ingresado no es válido.");
                return false;
            }

            if (!EsSoloNumerico(tbCDDest.Text))
            {
                MostrarAviso("El campo Codigo postal ingresado no es válido.");
                return false;
            }

            return true;
        }

        private bool TryObtenerTipoBulto(out TipoBulto tipoBulto)
        {
            if (rbS.Checked)
            {
                tipoBulto = TipoBulto.S;
                return true;
            }

            if (rbM.Checked)
            {
                tipoBulto = TipoBulto.M;
                return true;
            }

            if (rbL.Checked)
            {
                tipoBulto = TipoBulto.L;
                return true;
            }

            if (rbXL.Checked)
            {
                tipoBulto = TipoBulto.XL;
                return true;
            }

            tipoBulto = TipoBulto.S;
            return false;
        }

        private bool TryObtenerModalidadEntrega(out ModalidadEntrega modalidadEntrega)
        {
            if (rbPuertaPuerta.Checked)
            {
                modalidadEntrega = ModalidadEntrega.EntregaDomicilio;
                return true;
            }

            if (rbRetiroAgencia.Checked)
            {
                modalidadEntrega = ModalidadEntrega.EntregaAgencia;
                return true;
            }

            if (rbRetiroCD.Checked)
            {
                modalidadEntrega = ModalidadEntrega.EntregaCD;
                return true;
            }

            modalidadEntrega = ModalidadEntrega.EntregaDomicilio;
            return false;
        }

        private bool EsSoloNumerico(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            foreach (char caracter in valor.Trim())
            {
                if (!char.IsDigit(caracter))
                    return false;
            }

            return true;
        }

        private void MostrarAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
