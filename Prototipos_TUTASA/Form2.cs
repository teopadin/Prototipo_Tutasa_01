using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Form2 : Form
    {
        private int ultimoCorrelativo = 1;

        private class ClienteCorporativo
        {
            public string RazonSocial { get; set; }
            public string Cuit { get; set; }
            public string Telefono { get; set; }
            public string Calle { get; set; }
            public string Altura { get; set; }
            public string Piso { get; set; }
            public string CodigoPostal { get; set; }
            public string Ciudad { get; set; }

            public override string ToString()
            {
                return RazonSocial;
            }
        }

        private readonly List<ClienteCorporativo> clientesCorporativos = new List<ClienteCorporativo>
        {
            new ClienteCorporativo
            {
                RazonSocial = "Acme SA",
                Cuit = "30-71234567-8",
                Telefono = "1155551111",
                Calle = "Corrientes",
                Altura = "1234",
                Piso = "4A",
                CodigoPostal = "C1043",
                Ciudad = "CABA"
            },
            new ClienteCorporativo
            {
                RazonSocial = "Farmabox SRL",
                Cuit = "30-70999888-1",
                Telefono = "1144442222",
                Calle = "San Martin",
                Altura = "850",
                Piso = "",
                CodigoPostal = "B8000",
                Ciudad = "Bahia Blanca"
            },
            new ClienteCorporativo
            {
                RazonSocial = "Distribuidora Norte",
                Cuit = "30-70111222-3",
                Telefono = "1133337777",
                Calle = "Belgrano",
                Altura = "456",
                Piso = "2B",
                CodigoPostal = "X5000",
                Ciudad = "Cordoba"
            }
        };

        public Form2()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarPantalla();
        }

        private void CargarCombos()
        {
            cboTipoCliente.Items.Add("Corporativo");
            cboTipoCliente.Items.Add("Particular");

            cboRazonSocial.DataSource = clientesCorporativos;

            cboTipoEntrega.Items.Add("Puerta a puerta");
            cboTipoEntrega.Items.Add("Retiro en CD");
            cboTipoEntrega.Items.Add("Retiro en agencia");

            cboTipoBulto.Items.Add("S");
            cboTipoBulto.Items.Add("M");
            cboTipoBulto.Items.Add("L");
            cboTipoBulto.Items.Add("XL");

            cboCdOrigen.Items.Add("CABA");
            cboCdOrigen.Items.Add("COR");
            cboCdOrigen.Items.Add("ROS");
            cboCdOrigen.Items.Add("MDZ");

            cboCdDestino.Items.Add("CABA");
            cboCdDestino.Items.Add("COR");
            cboCdDestino.Items.Add("ROS");
            cboCdDestino.Items.Add("MDZ");

            cboAgencia.Items.Add("AG001 - Centro");
            cboAgencia.Items.Add("AG002 - Norte");
            cboAgencia.Items.Add("AG003 - Sur");

            cboTipoCliente.SelectedIndex = -1;
            cboRazonSocial.SelectedIndex = -1;
            cboTipoEntrega.SelectedIndex = -1;
            cboTipoBulto.SelectedIndex = -1;
            cboCdOrigen.SelectedIndex = -1;
            cboCdDestino.SelectedIndex = -1;
            cboAgencia.SelectedIndex = -1;
        }

        private void ConfigurarPantalla()
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cboRazonSocial.Enabled = false;
            txtCuit.ReadOnly = true;

            HabilitarParticular(false);
            HabilitarEntregaDomicilio(false);

            cboAgencia.Enabled = false;
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esCorporativo = cboTipoCliente.Text == "Corporativo";
            bool esParticular = cboTipoCliente.Text == "Particular";

            cboRazonSocial.Enabled = esCorporativo;
            HabilitarParticular(esParticular);

            if (esCorporativo)
            {
                LimpiarParticular();
                txtTelefonoRemitente.ReadOnly = true;
                txtCalleRemitente.ReadOnly = true;
                txtAlturaRemitente.ReadOnly = true;
                txtPisoRemitente.ReadOnly = true;
                txtCodigoPostalRemitente.ReadOnly = true;
                txtCiudadRemitente.ReadOnly = true;
                cboRazonSocial.SelectedIndex = -1;
                LimpiarCamposCorporativos();
            }
            else if (esParticular)
            {
                cboRazonSocial.SelectedIndex = -1;
                LimpiarCamposCorporativos();

                txtTelefonoRemitente.ReadOnly = false;
                txtCalleRemitente.ReadOnly = false;
                txtAlturaRemitente.ReadOnly = false;
                txtPisoRemitente.ReadOnly = false;
                txtCodigoPostalRemitente.ReadOnly = false;
                txtCiudadRemitente.ReadOnly = false;
            }
        }

        private void cboRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoCliente.Text != "Corporativo")
                return;

            ClienteCorporativo cliente = cboRazonSocial.SelectedItem as ClienteCorporativo;
            if (cliente == null)
                return;

            txtCuit.Text = cliente.Cuit;
            txtTelefonoRemitente.Text = cliente.Telefono;
            txtCalleRemitente.Text = cliente.Calle;
            txtAlturaRemitente.Text = cliente.Altura;
            txtPisoRemitente.Text = cliente.Piso;
            txtCodigoPostalRemitente.Text = cliente.CodigoPostal;
            txtCiudadRemitente.Text = cliente.Ciudad;
        }

        private void cboTipoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool puertaAPuerta = cboTipoEntrega.Text == "Puerta a puerta";
            bool retiroAgencia = cboTipoEntrega.Text == "Retiro en agencia";

            HabilitarEntregaDomicilio(puertaAPuerta);
            cboAgencia.Enabled = retiroAgencia;

            if (!puertaAPuerta)
                LimpiarEntrega();

            if (!retiroAgencia)
                cboAgencia.SelectedIndex = -1;
        }

        private void btnGenerarGuia_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            string numeroOrden = $"{cboCdOrigen.Text}-{ultimoCorrelativo:D4}";
            ultimoCorrelativo++;

            txtGuia.Text = GenerarTextoGuia(numeroOrden);

            MessageBox.Show(
                $"Orden nro {numeroOrden} se ha generado correctamente.",
                "Guia generada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string GenerarTextoGuia(string numeroOrden)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("GUIA DE ENCOMIENDA");
            sb.AppendLine("Nro guia: " + numeroOrden);
            sb.AppendLine("Fecha: " + txtFecha.Text);
            sb.AppendLine("CD origen: " + cboCdOrigen.Text);
            sb.AppendLine("CD destino: " + cboCdDestino.Text);
            sb.AppendLine("Tipo entrega: " + cboTipoEntrega.Text);
            sb.AppendLine("Tipo bulto: " + cboTipoBulto.Text);
            sb.AppendLine("");

            sb.AppendLine("REMITENTE");
            sb.AppendLine("Tipo cliente: " + cboTipoCliente.Text);

            if (cboTipoCliente.Text == "Corporativo")
            {
                sb.AppendLine("Razon social: " + cboRazonSocial.Text);
                sb.AppendLine("CUIT: " + txtCuit.Text);
            }
            else
            {
                sb.AppendLine("Nombre: " + txtNombreRemitente.Text);
                sb.AppendLine("Apellido: " + txtApellidoRemitente.Text);
                sb.AppendLine("DNI: " + txtDniRemitente.Text);
            }

            sb.AppendLine("Telefono: " + txtTelefonoRemitente.Text);
            sb.AppendLine("Calle: " + txtCalleRemitente.Text);
            sb.AppendLine("Altura: " + txtAlturaRemitente.Text);
            sb.AppendLine("Piso: " + txtPisoRemitente.Text);
            sb.AppendLine("Codigo postal: " + txtCodigoPostalRemitente.Text);
            sb.AppendLine("Ciudad: " + txtCiudadRemitente.Text);
            sb.AppendLine("");

            sb.AppendLine("DESTINATARIO");
            sb.AppendLine("Nombre: " + txtNombreDestinatario.Text);
            sb.AppendLine("Apellido: " + txtApellidoDestinatario.Text);
            sb.AppendLine("DNI: " + txtDniDestinatario.Text);
            sb.AppendLine("Telefono: " + txtTelefonoDestinatario.Text);

            if (cboTipoEntrega.Text == "Puerta a puerta")
            {
                sb.AppendLine("Calle entrega: " + txtCalleEntrega.Text);
                sb.AppendLine("Altura entrega: " + txtAlturaEntrega.Text);
                sb.AppendLine("Piso entrega: " + txtPisoEntrega.Text);
                sb.AppendLine("Codigo postal entrega: " + txtCodigoPostalEntrega.Text);
                sb.AppendLine("Ciudad entrega: " + txtCiudadEntrega.Text);
            }
            else if (cboTipoEntrega.Text == "Retiro en agencia")
            {
                sb.AppendLine("Agencia: " + cboAgencia.Text);
            }

            return sb.ToString();
        }

        private bool ValidarFormulario()
        {
            if (cboTipoCliente.SelectedIndex == -1)
                return MostrarError("Debe seleccionar un tipo de cliente.");

            if (cboTipoCliente.Text == "Corporativo")
            {
                if (cboRazonSocial.SelectedIndex == -1)
                    return MostrarError("Debe seleccionar una razon social.");

                if (string.IsNullOrWhiteSpace(txtCuit.Text))
                    return MostrarError("El CUIT es obligatorio.");
            }

            if (cboTipoCliente.Text == "Particular")
            {
                if (!ValidarTexto(txtNombreRemitente.Text, 30))
                    return MostrarError("El nombre del remitente es obligatorio.");

                if (!ValidarTexto(txtApellidoRemitente.Text, 30))
                    return MostrarError("El apellido del remitente es obligatorio.");

                if (!ValidarDni(txtDniRemitente.Text))
                    return MostrarError("El DNI del remitente es invalido.");
            }

            if (!ValidarTelefono(txtTelefonoRemitente.Text))
                return MostrarError("El telefono del remitente es invalido.");

            if (!ValidarTexto(txtCalleRemitente.Text, 50))
                return MostrarError("La calle del remitente es obligatoria.");

            if (!ValidarEnteroPositivo(txtAlturaRemitente.Text))
                return MostrarError("La altura del remitente es invalida.");

            if (txtPisoRemitente.Text.Trim().Length > 10)
                return MostrarError("El piso del remitente debe tener hasta 10 caracteres.");

            if (!ValidarTexto(txtCodigoPostalRemitente.Text, 10))
                return MostrarError("El codigo postal del remitente es obligatorio.");

            if (!ValidarTexto(txtCiudadRemitente.Text, 40))
                return MostrarError("La ciudad del remitente es obligatoria.");

            if (!ValidarTexto(txtNombreDestinatario.Text, 30))
                return MostrarError("El nombre del destinatario es obligatorio.");

            if (!ValidarTexto(txtApellidoDestinatario.Text, 30))
                return MostrarError("El apellido del destinatario es obligatorio.");

            if (!ValidarDni(txtDniDestinatario.Text))
                return MostrarError("El DNI del destinatario es invalido.");

            if (!ValidarTelefono(txtTelefonoDestinatario.Text))
                return MostrarError("El telefono del destinatario es invalido.");

            if (cboCdOrigen.SelectedIndex == -1)
                return MostrarError("Debe seleccionar un CD de origen.");

            if (cboCdDestino.SelectedIndex == -1)
                return MostrarError("Debe seleccionar un CD de destino.");

            if (cboTipoEntrega.SelectedIndex == -1)
                return MostrarError("Debe seleccionar un tipo de entrega.");

            if (cboTipoBulto.SelectedIndex == -1)
                return MostrarError("Debe seleccionar un tipo de bulto.");

            if (cboTipoEntrega.Text == "Puerta a puerta")
            {
                if (!ValidarTexto(txtCalleEntrega.Text, 50))
                    return MostrarError("La calle de entrega es obligatoria.");

                if (!ValidarEnteroPositivo(txtAlturaEntrega.Text))
                    return MostrarError("La altura de entrega es invalida.");

                if (txtPisoEntrega.Text.Trim().Length > 10)
                    return MostrarError("El piso de entrega debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCodigoPostalEntrega.Text, 10))
                    return MostrarError("El codigo postal de entrega es obligatorio.");

                if (!ValidarTexto(txtCiudadEntrega.Text, 40))
                    return MostrarError("La ciudad de entrega es obligatoria.");
            }

            if (cboTipoEntrega.Text == "Retiro en agencia" && cboAgencia.SelectedIndex == -1)
                return MostrarError("Debe seleccionar una agencia.");

            return true;
        }

        private bool ValidarTexto(string valor, int maximo)
        {
            string texto = valor.Trim();
            return !string.IsNullOrWhiteSpace(texto) && texto.Length <= maximo;
        }

        private bool ValidarDni(string valor)
        {
            string texto = valor.Trim();
            return texto.Length >= 7 && texto.Length <= 9 && texto.All(char.IsDigit);
        }

        private bool ValidarTelefono(string valor)
        {
            string texto = valor.Trim();
            return texto.Length >= 8 && texto.Length <= 15;
        }

        private bool ValidarEnteroPositivo(string valor)
        {
            return int.TryParse(valor.Trim(), out int numero) && numero > 0;
        }

        private bool MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void HabilitarParticular(bool habilitar)
        {
            txtNombreRemitente.Enabled = habilitar;
            txtApellidoRemitente.Enabled = habilitar;
            txtDniRemitente.Enabled = habilitar;
        }

        private void HabilitarEntregaDomicilio(bool habilitar)
        {
            txtCalleEntrega.Enabled = habilitar;
            txtAlturaEntrega.Enabled = habilitar;
            txtPisoEntrega.Enabled = habilitar;
            txtCodigoPostalEntrega.Enabled = habilitar;
            txtCiudadEntrega.Enabled = habilitar;
        }

        private void LimpiarCamposCorporativos()
        {
            txtCuit.Clear();
            txtTelefonoRemitente.Clear();
            txtCalleRemitente.Clear();
            txtAlturaRemitente.Clear();
            txtPisoRemitente.Clear();
            txtCodigoPostalRemitente.Clear();
            txtCiudadRemitente.Clear();
        }

        private void LimpiarParticular()
        {
            txtNombreRemitente.Clear();
            txtApellidoRemitente.Clear();
            txtDniRemitente.Clear();
            txtTelefonoRemitente.Clear();
            txtCalleRemitente.Clear();
            txtAlturaRemitente.Clear();
            txtPisoRemitente.Clear();
            txtCodigoPostalRemitente.Clear();
            txtCiudadRemitente.Clear();
        }

        private void LimpiarEntrega()
        {
            txtCalleEntrega.Clear();
            txtAlturaEntrega.Clear();
            txtPisoEntrega.Clear();
            txtCodigoPostalEntrega.Clear();
            txtCiudadEntrega.Clear();
        }
    }
}
