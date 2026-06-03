using Prototipos_TUTASA.Imposición.Imposición_CD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.ImposiciónCD_V2
{
    public partial class ImposiciónCD_V2 : Form
    {
        private ModeloImposicionCD modelo = new ModeloImposicionCD();

        public ImposiciónCD_V2()
        {
            InitializeComponent();
            Load += ImposiciónCD_V2_Load;
            cboRazonSocial.SelectedIndexChanged += cboRazonSocial_SelectedIndexChanged;
            radioButton5.CheckedChanged += Modalidad_CheckedChanged;
            radioButton6.CheckedChanged += Modalidad_CheckedChanged;
            radioButton7.CheckedChanged += Modalidad_CheckedChanged;
            btnGenerarGuia.Click += btnGenerarGuia_Click;
            button1.Click += button1_Click;
        }

        private void cboTipoBulto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ImposiciónCD_V2_Load(object sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtNombreDestinatario.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDestinatario.Text) ||
                string.IsNullOrWhiteSpace(txtDniDestinatario.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoDestinatario.Text))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return;
            }

            if (!int.TryParse(txtDniDestinatario.Text.Trim(), out int dniDestinatario) || dniDestinatario <= 0)
            {
                MostrarAviso("El campo DNI ingresado no es válido.");
                return;
            }

            if (!EsSoloNumerico(txtTelefonoDestinatario.Text))
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
                Nombre = txtNombreDestinatario.Text.Trim(),
                Apellido = txtApellidoDestinatario.Text.Trim(),
                Telefono = txtTelefonoDestinatario.Text.Trim()
            };

            Agencia agenciaDestino = null;
            CentroDistribucion cdDestino = null;

            if (modalidadEntrega == ModalidadEntrega.PuertaPuerta)
            {
                if (!ValidarDomicilioPuertaPuerta())
                    return;

                destinatario.Calle = textBox1.Text.Trim();
                destinatario.Altura = int.Parse(textBox2.Text.Trim());
                destinatario.Piso = textBox3.Text.Trim();
                destinatario.CodigoPostal = textBox4.Text.Trim();
                destinatario.Ciudad = textBox5.Text.Trim();
                cdDestino = modelo.ObtenerCentroDistribucionPorCiudad(destinatario.Ciudad);
            }
            else if (modalidadEntrega == ModalidadEntrega.RetiroAgencia)
            {
                agenciaDestino = comboBox1.SelectedItem as Agencia;
                if (agenciaDestino == null)
                {
                    MostrarAviso("Debe completar todos los campos obligatorios.");
                    return;
                }

                cdDestino = agenciaDestino.CD;
            }
            else if (modalidadEntrega == ModalidadEntrega.RetiroCD)
            {
                cdDestino = comboBox2.SelectedItem as CentroDistribucion;
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

            Guia guia = modelo.RegistrarImposicion(tipoBulto, modalidadEntrega, destinatario, cdDestino, agenciaDestino);
            MessageBox.Show("Guía N° " + guia.NroGuia + " generada y admitida con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarCombos()
        {
            cboRazonSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
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
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "RazonSocial";
            comboBox1.DataSource = new List<Agencia>(modelo.Agencias);
            comboBox1.SelectedIndex = -1;
        }

        private void CargarCentrosDeDistribucion()
        {
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.DataSource = new List<CentroDistribucion>(modelo.CentrosDeDistribucion);
            comboBox2.SelectedIndex = -1;
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
            groupBox2.Enabled = radioButton5.Checked;
            groupBox3.Enabled = radioButton6.Checked;
            groupBox4.Enabled = radioButton7.Checked;

            if (!radioButton5.Checked)
                LimpiarDomicilioPuertaPuerta();

            if (!radioButton6.Checked)
                comboBox1.SelectedIndex = -1;

            if (!radioButton7.Checked)
                comboBox2.SelectedIndex = -1;
        }

        private void LimpiarDomicilioPuertaPuerta()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
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
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MostrarAviso("Debe completar todos los campos obligatorios.");
                return false;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int alturaDestino) || alturaDestino <= 0)
            {
                MostrarAviso("El campo Altura ingresado no es válido.");
                return false;
            }

            if (!EsSoloNumerico(textBox4.Text))
            {
                MostrarAviso("El campo Codigo postal ingresado no es válido.");
                return false;
            }

            return true;
        }

        private bool TryObtenerTipoBulto(out TipoBulto tipoBulto)
        {
            if (radioButton1.Checked)
            {
                tipoBulto = TipoBulto.S;
                return true;
            }

            if (radioButton2.Checked)
            {
                tipoBulto = TipoBulto.M;
                return true;
            }

            if (radioButton3.Checked)
            {
                tipoBulto = TipoBulto.L;
                return true;
            }

            if (radioButton4.Checked)
            {
                tipoBulto = TipoBulto.XL;
                return true;
            }

            tipoBulto = TipoBulto.S;
            return false;
        }

        private bool TryObtenerModalidadEntrega(out ModalidadEntrega modalidadEntrega)
        {
            if (radioButton5.Checked)
            {
                modalidadEntrega = ModalidadEntrega.PuertaPuerta;
                return true;
            }

            if (radioButton6.Checked)
            {
                modalidadEntrega = ModalidadEntrega.RetiroAgencia;
                return true;
            }

            if (radioButton7.Checked)
            {
                modalidadEntrega = ModalidadEntrega.RetiroCD;
                return true;
            }

            modalidadEntrega = ModalidadEntrega.PuertaPuerta;
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
