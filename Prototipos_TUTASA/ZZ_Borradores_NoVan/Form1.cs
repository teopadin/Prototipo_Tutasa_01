using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Form1 : Form
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
                Calle = "Av. Corrientes",
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

        public Form1()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarPantallaInicial();
        }

        private void CargarCombos()
        {
            cboTipoCliente.Items.AddRange(new object[]
            {
                "Corporativo",
                "Particular"
            });

            cboRazonSocial.DataSource = clientesCorporativos;

            cboTipoEntrega.Items.AddRange(new object[]
            {
                "Puerta a puerta",
                "Retiro en CD",
                "Retiro en agencia"
            });

            cboTipoBulto.Items.AddRange(new object[]
            {
                "S",
                "M",
                "L",
                "XL"
            });

            cboCdOrigen.Items.AddRange(new object[]
            {
                "CABA",
                "COR",
                "ROS",
                "MDZ"
            });

            cboCdDestino.Items.AddRange(new object[]
            {
                "CABA",
                "COR",
                "ROS",
                "MDZ"
            });

            cboAgencia.Items.AddRange(new object[]
            {
                "AG001 - Centro",
                "AG002 - Norte",
                "AG003 - Sur"
            });

            cboTipoCliente.SelectedIndex = -1;
            cboRazonSocial.SelectedIndex = -1;
            cboTipoEntrega.SelectedIndex = -1;
            cboTipoBulto.SelectedIndex = -1;
            cboCdOrigen.SelectedIndex = -1;
            cboCdDestino.SelectedIndex = -1;
            cboAgencia.SelectedIndex = -1;
        }

        private void ConfigurarPantallaInicial()
        {
            lblFechaValor.Text = DateTime.Now.ToString("dd/MM/yyyy");

            HabilitarCorporativo(false);
            HabilitarParticular(false);
            HabilitarEntregaDomicilio(false);

            cboAgencia.Enabled = false;
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esCorporativo = cboTipoCliente.Text == "Corporativo";
            bool esParticular = cboTipoCliente.Text == "Particular";

            HabilitarCorporativo(esCorporativo);
            HabilitarParticular(esParticular);

            if (esCorporativo)
            {
                LimpiarParticular();
                cboRazonSocial.SelectedIndex = -1;
                LimpiarCamposCorporativos();
            }
            else if (esParticular)
            {
                cboRazonSocial.SelectedIndex = -1;
                LimpiarCamposCorporativos();
            }
            else
            {
                cboRazonSocial.SelectedIndex = -1;
                LimpiarCamposCorporativos();
                LimpiarParticular();
            }
        }

        private void cboRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoCliente.Text != "Corporativo")
                return;

            ClienteCorporativo cliente = cboRazonSocial.SelectedItem as ClienteCorporativo;
            if (cliente == null)
            {
                LimpiarCamposCorporativos();
                return;
            }

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

            string numeroOrden = GenerarNumeroOrden();
            string guia = GenerarTextoGuia(numeroOrden);

            MessageBox.Show(
                $"Orden nro {numeroOrden} se ha generado correctamente.",
                "Guia generada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtSalidaGuia.Text = guia;
        }

        private string GenerarNumeroOrden()
        {
            string codigoCd = cboCdOrigen.Text.Trim();
            string numero = $"{codigoCd}-{ultimoCorrelativo:D4}";
            ultimoCorrelativo++;
            return numero;
        }

        private string GenerarTextoGuia(string numeroOrden)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("GUIA DE ENCOMIENDA");
            sb.AppendLine("------------------------------");
            sb.AppendLine($"Nro. de guia: {numeroOrden}");
            sb.AppendLine($"Fecha de imposicion: {DateTime.Now:dd/MM/yyyy}");
            sb.AppendLine($"CD origen: {cboCdOrigen.Text}");
            sb.AppendLine($"CD destino: {cboCdDestino.Text}");
            sb.AppendLine($"Tipo de entrega: {cboTipoEntrega.Text}");
            sb.AppendLine($"Tipo de bulto: {cboTipoBulto.Text}");
            sb.AppendLine();

            sb.AppendLine("REMITENTE");
            sb.AppendLine($"Tipo de cliente: {cboTipoCliente.Text}");

            if (cboTipoCliente.Text == "Corporativo")
            {
                sb.AppendLine($"Razon social: {cboRazonSocial.Text}");
                sb.AppendLine($"CUIT: {txtCuit.Text}");
            }
            else
            {
                sb.AppendLine($"Nombre: {txtNombreRemitente.Text}");
                sb.AppendLine($"Apellido: {txtApellidoRemitente.Text}");
                sb.AppendLine($"DNI: {txtDniRemitente.Text}");
            }

            sb.AppendLine($"Telefono: {txtTelefonoRemitente.Text}");
            sb.AppendLine($"Calle: {txtCalleRemitente.Text}");
            sb.AppendLine($"Altura: {txtAlturaRemitente.Text}");
            sb.AppendLine($"Piso: {txtPisoRemitente.Text}");
            sb.AppendLine($"Codigo postal: {txtCodigoPostalRemitente.Text}");
            sb.AppendLine($"Ciudad: {txtCiudadRemitente.Text}");
            sb.AppendLine();

            sb.AppendLine("DESTINATARIO");
            sb.AppendLine($"Nombre: {txtNombreDestinatario.Text}");
            sb.AppendLine($"Apellido: {txtApellidoDestinatario.Text}");
            sb.AppendLine($"DNI: {txtDniDestinatario.Text}");
            sb.AppendLine($"Telefono: {txtTelefonoDestinatario.Text}");

            if (cboTipoEntrega.Text == "Puerta a puerta")
            {
                sb.AppendLine($"Calle entrega: {txtCalleEntrega.Text}");
                sb.AppendLine($"Altura entrega: {txtAlturaEntrega.Text}");
                sb.AppendLine($"Piso entrega: {txtPisoEntrega.Text}");
                sb.AppendLine($"Codigo postal entrega: {txtCodigoPostalEntrega.Text}");
                sb.AppendLine($"Ciudad entrega: {txtCiudadEntrega.Text}");
            }
            else if (cboTipoEntrega.Text == "Retiro en agencia")
            {
                sb.AppendLine($"Agencia: {cboAgencia.Text}");
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

                if (!ValidarTelefono(txtTelefonoRemitente.Text))
                    return MostrarError("El telefono del remitente debe tener entre 8 y 15 caracteres.");

                if (!ValidarTexto(txtCalleRemitente.Text, 50))
                    return MostrarError("La calle del remitente es obligatoria y debe tener hasta 50 caracteres.");

                if (!ValidarEnteroPositivo(txtAlturaRemitente.Text))
                    return MostrarError("La altura del remitente debe ser un numero entero mayor a 0.");

                if (txtPisoRemitente.Text.Trim().Length > 10)
                    return MostrarError("El piso del remitente debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCodigoPostalRemitente.Text, 10))
                    return MostrarError("El codigo postal del remitente es obligatorio y debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCiudadRemitente.Text, 40))
                    return MostrarError("La ciudad del remitente es obligatoria y debe tener hasta 40 caracteres.");
            }

            if (cboTipoCliente.Text == "Particular")
            {
                if (!ValidarTexto(txtNombreRemitente.Text, 30))
                    return MostrarError("El nombre del remitente es obligatorio y debe tener hasta 30 caracteres.");

                if (!ValidarTexto(txtApellidoRemitente.Text, 30))
                    return MostrarError("El apellido del remitente es obligatorio y debe tener hasta 30 caracteres.");

                if (!ValidarDni(txtDniRemitente.Text))
                    return MostrarError("El DNI del remitente debe tener entre 7 y 9 digitos numericos.");

                if (!ValidarTelefono(txtTelefonoRemitente.Text))
                    return MostrarError("El telefono del remitente debe tener entre 8 y 15 caracteres.");

                if (!ValidarTexto(txtCalleRemitente.Text, 50))
                    return MostrarError("La calle del remitente es obligatoria y debe tener hasta 50 caracteres.");

                if (!ValidarEnteroPositivo(txtAlturaRemitente.Text))
                    return MostrarError("La altura del remitente debe ser un numero entero mayor a 0.");

                if (txtPisoRemitente.Text.Trim().Length > 10)
                    return MostrarError("El piso del remitente debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCodigoPostalRemitente.Text, 10))
                    return MostrarError("El codigo postal del remitente es obligatorio y debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCiudadRemitente.Text, 40))
                    return MostrarError("La ciudad del remitente es obligatoria y debe tener hasta 40 caracteres.");
            }

            if (!ValidarTexto(txtNombreDestinatario.Text, 30))
                return MostrarError("El nombre del destinatario es obligatorio y debe tener hasta 30 caracteres.");

            if (!ValidarTexto(txtApellidoDestinatario.Text, 30))
                return MostrarError("El apellido del destinatario es obligatorio y debe tener hasta 30 caracteres.");

            if (!ValidarDni(txtDniDestinatario.Text))
                return MostrarError("El DNI del destinatario debe tener entre 7 y 9 digitos numericos.");

            if (!ValidarTelefono(txtTelefonoDestinatario.Text))
                return MostrarError("El telefono del destinatario debe tener entre 8 y 15 caracteres.");

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
                    return MostrarError("La calle de entrega es obligatoria y debe tener hasta 50 caracteres.");

                if (!ValidarEnteroPositivo(txtAlturaEntrega.Text))
                    return MostrarError("La altura de entrega debe ser un numero entero mayor a 0.");

                if (txtPisoEntrega.Text.Trim().Length > 10)
                    return MostrarError("El piso de entrega debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCodigoPostalEntrega.Text, 10))
                    return MostrarError("El codigo postal de entrega es obligatorio y debe tener hasta 10 caracteres.");

                if (!ValidarTexto(txtCiudadEntrega.Text, 40))
                    return MostrarError("La ciudad de entrega es obligatoria y debe tener hasta 40 caracteres.");
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
            MessageBox.Show(
                mensaje,
                "Validacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }

        private void HabilitarCorporativo(bool habilitar)
        {
            cboRazonSocial.Enabled = habilitar;
            txtCuit.ReadOnly = true;
        }

        private void HabilitarParticular(bool habilitar)
        {
            txtNombreRemitente.Enabled = habilitar;
            txtApellidoRemitente.Enabled = habilitar;
            txtDniRemitente.Enabled = habilitar;

            txtTelefonoRemitente.ReadOnly = false;
            txtCalleRemitente.ReadOnly = false;
            txtAlturaRemitente.ReadOnly = false;
            txtPisoRemitente.ReadOnly = false;
            txtCodigoPostalRemitente.ReadOnly = false;
            txtCiudadRemitente.ReadOnly = false;

            bool corporativo = cboTipoCliente.Text == "Corporativo";
            if (corporativo)
            {
                txtTelefonoRemitente.ReadOnly = true;
                txtCalleRemitente.ReadOnly = true;
                txtAlturaRemitente.ReadOnly = true;
                txtPisoRemitente.ReadOnly = true;
                txtCodigoPostalRemitente.ReadOnly = true;
                txtCiudadRemitente.ReadOnly = true;
            }
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
