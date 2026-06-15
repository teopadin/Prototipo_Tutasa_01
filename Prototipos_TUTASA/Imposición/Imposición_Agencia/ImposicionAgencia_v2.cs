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


            if (string.IsNullOrWhiteSpace(txtNombreDest.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDest.Text) ||
                string.IsNullOrWhiteSpace(txtDNIDest.Text) ||
                string.IsNullOrWhiteSpace(txtTelDest.Text))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            if (!EsSoloTexto(txtNombreDest.Text))
            {
                MostrarAviso("El campo Nombre ingresado no es válido.");
                return;
            }

            if (!EsSoloTexto(txtApellidoDest.Text))
            {
                MostrarAviso("El campo Apellido ingresado no es válido.");
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

            if (!TryObtenerTipoBulto(out TipoBultoEnum tipoBulto))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            if (!TryObtenerModalidadEntrega(out ModalidadEntregaEnum modalidadEntrega))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            DestinatarioGuia destinatario = new DestinatarioGuia
            {
                Dni = dniDestinatario,
                nombre = txtNombreDest.Text.Trim(),
                apellido = txtApellidoDest.Text.Trim(),
                telefono = txtTelDest.Text.Trim()
            };

            Agencia agenciaDestino = null;
            CentroDistribucion cdDestino = null;

            if (modalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
            {
                if (!ValidarDomicilioPuertaPuerta())
                    return;

                cdDestino = cbCDDestino.SelectedItem as CentroDistribucion;
                if (cdDestino == null)
                {
                    MostrarAviso("Debe seleccionar un centro de distribución destino.");
                    return;
                }

                destinatario.calle = tbCalleDest.Text.Trim();
                destinatario.altura = int.Parse(tbAlturaDest.Text.Trim());
                destinatario.piso = tbPisoDest.Text.Trim();
                destinatario.codigoPostal = tbCDDest.Text.Trim();
                destinatario.ciudad = tbCiudadDest.Text.Trim();
            }
            else if (modalidadEntrega == ModalidadEntregaEnum.EntregaAgencia)
            {
                agenciaDestino = cbSeleccionarAgencia.SelectedItem as Agencia;
                if (agenciaDestino == null)
                {
                    MostrarAviso("Debe completar todos los campos obligatorios.");
                    return;
                }

                cdDestino = modelo.BuscarCD(agenciaDestino.idCD);
            }
            else if (modalidadEntrega == ModalidadEntregaEnum.EntregaCD)
            {
                cdDestino = cbCDDestino.SelectedItem as CentroDistribucion;
                if (cdDestino == null)
                {
                    MostrarAviso("Debe completar todos los campos obligatorios.");
                    return;
                }

                destinatario.calle = string.Empty;
                destinatario.altura = 0;
                destinatario.piso = string.Empty;
                destinatario.codigoPostal = string.Empty;
                destinatario.ciudad = cdDestino.nombre;
            }

            Guia guia = modelo.RegistrarImposicion(tipoBulto, modalidadEntrega, destinatario, cdDestino, agenciaDestino, cliente);

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

            txtCUIT.Text = cliente.cuit.ToString();
            txtTelRem.Text = cliente.telefono;
            txtCalleRemitente.Text = cliente.calle;
            txtAlturaRemitente.Text = cliente.altura.ToString();
            txtPisoRemitente.Text = cliente.piso;
            txtCodigoPostalRemitente.Text = cliente.codigoPostal;
            txtCiudadRemitente.Text = cliente.ciudad;
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

            if (!EsSoloTexto(tbCalleDest.Text))
            {
                MostrarAviso("El campo Calle ingresado no es válido.");
                return false;
            }

            if (!int.TryParse(tbAlturaDest.Text.Trim(), out int alturaDestino) || alturaDestino <= 0)
            {
                MostrarAviso("El campo Altura ingresado no es válido.");
                return false;
            }

            if (!EsSoloTexto(tbCiudadDest.Text))
            {
                MostrarAviso("El campo Ciudad ingresado no es válido.");
                return false;
            }

            return true;
        }

        private bool TryObtenerTipoBulto(out TipoBultoEnum tipoBulto)
        {
            if (rbS.Checked)
            {
                tipoBulto = TipoBultoEnum.S;
                return true;
            }

            if (rbM.Checked)
            {
                tipoBulto = TipoBultoEnum.M;
                return true;
            }

            if (rbL.Checked)
            {
                tipoBulto = TipoBultoEnum.L;
                return true;
            }

            if (rbXL.Checked)
            {
                tipoBulto = TipoBultoEnum.XL;
                return true;
            }

            tipoBulto = TipoBultoEnum.S;
            return false;
        }

        private bool TryObtenerModalidadEntrega(out ModalidadEntregaEnum modalidadEntrega)
        {
            if (rbPuertaPuerta.Checked)
            {
                modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio;
                return true;
            }

            if (rbRetiroAgencia.Checked)
            {
                modalidadEntrega = ModalidadEntregaEnum.EntregaAgencia;
                return true;
            }

            if (rbRetiroCD.Checked)
            {
                modalidadEntrega = ModalidadEntregaEnum.EntregaCD;
                return true;
            }

            modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio;
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

        private bool EsSoloTexto(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            foreach (char caracter in valor.Trim())
            {
                if (!char.IsLetter(caracter) && caracter != ' ')
                    return false;
            }

            return true;
        }

        private void MostrarAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblTelDest_Click(object sender, EventArgs e)
        {

        }
    }
}
