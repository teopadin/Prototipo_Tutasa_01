namespace Prototipos_TUTASA
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.grpTipoCliente = new System.Windows.Forms.GroupBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.grpRemitente = new System.Windows.Forms.GroupBox();
            this.cboRazonSocial = new System.Windows.Forms.ComboBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtCiudadRemitente = new System.Windows.Forms.TextBox();
            this.lblCiudadRemitente = new System.Windows.Forms.Label();
            this.txtCodigoPostalRemitente = new System.Windows.Forms.TextBox();
            this.lblCodigoPostalRemitente = new System.Windows.Forms.Label();
            this.txtPisoRemitente = new System.Windows.Forms.TextBox();
            this.lblPisoRemitente = new System.Windows.Forms.Label();
            this.txtAlturaRemitente = new System.Windows.Forms.TextBox();
            this.lblAlturaRemitente = new System.Windows.Forms.Label();
            this.txtCalleRemitente = new System.Windows.Forms.TextBox();
            this.lblCalleRemitente = new System.Windows.Forms.Label();
            this.txtTelefonoRemitente = new System.Windows.Forms.TextBox();
            this.lblTelefonoRemitente = new System.Windows.Forms.Label();
            this.txtDniRemitente = new System.Windows.Forms.TextBox();
            this.lblDniRemitente = new System.Windows.Forms.Label();
            this.txtApellidoRemitente = new System.Windows.Forms.TextBox();
            this.lblApellidoRemitente = new System.Windows.Forms.Label();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.lblNombreRemitente = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.grpDestinatario = new System.Windows.Forms.GroupBox();
            this.txtTelefonoDestinatario = new System.Windows.Forms.TextBox();
            this.lblTelefonoDestinatario = new System.Windows.Forms.Label();
            this.txtDniDestinatario = new System.Windows.Forms.TextBox();
            this.lblDniDestinatario = new System.Windows.Forms.Label();
            this.txtApellidoDestinatario = new System.Windows.Forms.TextBox();
            this.lblApellidoDestinatario = new System.Windows.Forms.Label();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.lblNombreDestinatario = new System.Windows.Forms.Label();
            this.grpEnvio = new System.Windows.Forms.GroupBox();
            this.cboAgencia = new System.Windows.Forms.ComboBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.txtCiudadEntrega = new System.Windows.Forms.TextBox();
            this.lblCiudadEntrega = new System.Windows.Forms.Label();
            this.txtCodigoPostalEntrega = new System.Windows.Forms.TextBox();
            this.lblCodigoPostalEntrega = new System.Windows.Forms.Label();
            this.txtPisoEntrega = new System.Windows.Forms.TextBox();
            this.lblPisoEntrega = new System.Windows.Forms.Label();
            this.txtAlturaEntrega = new System.Windows.Forms.TextBox();
            this.lblAlturaEntrega = new System.Windows.Forms.Label();
            this.txtCalleEntrega = new System.Windows.Forms.TextBox();
            this.lblCalleEntrega = new System.Windows.Forms.Label();
            this.cboTipoBulto = new System.Windows.Forms.ComboBox();
            this.lblTipoBulto = new System.Windows.Forms.Label();
            this.cboTipoEntrega = new System.Windows.Forms.ComboBox();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.cboCdDestino = new System.Windows.Forms.ComboBox();
            this.lblCdDestino = new System.Windows.Forms.Label();
            this.cboCdOrigen = new System.Windows.Forms.ComboBox();
            this.lblCdOrigen = new System.Windows.Forms.Label();
            this.btnGenerarGuia = new System.Windows.Forms.Button();
            this.txtSalidaGuia = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.grpTipoCliente.SuspendLayout();
            this.grpRemitente.SuspendLayout();
            this.grpDestinatario.SuspendLayout();
            this.grpEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Imposicion en Callcenter";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(1040, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Location = new System.Drawing.Point(1095, 27);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(88, 20);
            this.lblFechaValor.TabIndex = 2;
            this.lblFechaValor.Text = "00/00/0000";
            // 
            // grpTipoCliente
            // 
            this.grpTipoCliente.Controls.Add(this.cboTipoCliente);
            this.grpTipoCliente.Controls.Add(this.lblTipoCliente);
            this.grpTipoCliente.Location = new System.Drawing.Point(20, 65);
            this.grpTipoCliente.Name = "grpTipoCliente";
            this.grpTipoCliente.Size = new System.Drawing.Size(1163, 76);
            this.grpTipoCliente.TabIndex = 3;
            this.grpTipoCliente.TabStop = false;
            this.grpTipoCliente.Text = "1. Tipo de remitente";
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(145, 29);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(220, 28);
            this.cboTipoCliente.TabIndex = 1;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(20, 32);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(102, 20);
            this.lblTipoCliente.TabIndex = 0;
            this.lblTipoCliente.Text = "Tipo cliente *";
            // 
            // grpRemitente
            // 
            this.grpRemitente.Controls.Add(this.cboRazonSocial);
            this.grpRemitente.Controls.Add(this.lblRazonSocial);
            this.grpRemitente.Controls.Add(this.txtCiudadRemitente);
            this.grpRemitente.Controls.Add(this.lblCiudadRemitente);
            this.grpRemitente.Controls.Add(this.txtCodigoPostalRemitente);
            this.grpRemitente.Controls.Add(this.lblCodigoPostalRemitente);
            this.grpRemitente.Controls.Add(this.txtPisoRemitente);
            this.grpRemitente.Controls.Add(this.lblPisoRemitente);
            this.grpRemitente.Controls.Add(this.txtAlturaRemitente);
            this.grpRemitente.Controls.Add(this.lblAlturaRemitente);
            this.grpRemitente.Controls.Add(this.txtCalleRemitente);
            this.grpRemitente.Controls.Add(this.lblCalleRemitente);
            this.grpRemitente.Controls.Add(this.txtTelefonoRemitente);
            this.grpRemitente.Controls.Add(this.lblTelefonoRemitente);
            this.grpRemitente.Controls.Add(this.txtDniRemitente);
            this.grpRemitente.Controls.Add(this.lblDniRemitente);
            this.grpRemitente.Controls.Add(this.txtApellidoRemitente);
            this.grpRemitente.Controls.Add(this.lblApellidoRemitente);
            this.grpRemitente.Controls.Add(this.txtNombreRemitente);
            this.grpRemitente.Controls.Add(this.lblNombreRemitente);
            this.grpRemitente.Controls.Add(this.txtCuit);
            this.grpRemitente.Controls.Add(this.lblCuit);
            this.grpRemitente.Location = new System.Drawing.Point(20, 155);
            this.grpRemitente.Name = "grpRemitente";
            this.grpRemitente.Size = new System.Drawing.Size(1163, 198);
            this.grpRemitente.TabIndex = 4;
            this.grpRemitente.TabStop = false;
            this.grpRemitente.Text = "2. Datos del remitente";
            // 
            // cboRazonSocial
            // 
            this.cboRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRazonSocial.FormattingEnabled = true;
            this.cboRazonSocial.Location = new System.Drawing.Point(20, 56);
            this.cboRazonSocial.Name = "cboRazonSocial";
            this.cboRazonSocial.Size = new System.Drawing.Size(260, 28);
            this.cboRazonSocial.TabIndex = 1;
            this.cboRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cboRazonSocial_SelectedIndexChanged);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 33);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(99, 20);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon social *";
            // 
            // txtCiudadRemitente
            // 
            this.txtCiudadRemitente.Location = new System.Drawing.Point(907, 145);
            this.txtCiudadRemitente.MaxLength = 40;
            this.txtCiudadRemitente.Name = "txtCiudadRemitente";
            this.txtCiudadRemitente.Size = new System.Drawing.Size(220, 27);
            this.txtCiudadRemitente.TabIndex = 11;
            // 
            // lblCiudadRemitente
            // 
            this.lblCiudadRemitente.AutoSize = true;
            this.lblCiudadRemitente.Location = new System.Drawing.Point(907, 122);
            this.lblCiudadRemitente.Name = "lblCiudadRemitente";
            this.lblCiudadRemitente.Size = new System.Drawing.Size(69, 20);
            this.lblCiudadRemitente.TabIndex = 20;
            this.lblCiudadRemitente.Text = "Ciudad *";
            // 
            // txtCodigoPostalRemitente
            // 
            this.txtCodigoPostalRemitente.Location = new System.Drawing.Point(735, 145);
            this.txtCodigoPostalRemitente.MaxLength = 10;
            this.txtCodigoPostalRemitente.Name = "txtCodigoPostalRemitente";
            this.txtCodigoPostalRemitente.Size = new System.Drawing.Size(140, 27);
            this.txtCodigoPostalRemitente.TabIndex = 10;
            // 
            // lblCodigoPostalRemitente
            // 
            this.lblCodigoPostalRemitente.AutoSize = true;
            this.lblCodigoPostalRemitente.Location = new System.Drawing.Point(735, 122);
            this.lblCodigoPostalRemitente.Name = "lblCodigoPostalRemitente";
            this.lblCodigoPostalRemitente.Size = new System.Drawing.Size(109, 20);
            this.lblCodigoPostalRemitente.TabIndex = 18;
            this.lblCodigoPostalRemitente.Text = "Codigo postal *";
            // 
            // txtPisoRemitente
            // 
            this.txtPisoRemitente.Location = new System.Drawing.Point(566, 145);
            this.txtPisoRemitente.MaxLength = 10;
            this.txtPisoRemitente.Name = "txtPisoRemitente";
            this.txtPisoRemitente.Size = new System.Drawing.Size(130, 27);
            this.txtPisoRemitente.TabIndex = 9;
            // 
            // lblPisoRemitente
            // 
            this.lblPisoRemitente.AutoSize = true;
            this.lblPisoRemitente.Location = new System.Drawing.Point(566, 122);
            this.lblPisoRemitente.Name = "lblPisoRemitente";
            this.lblPisoRemitente.Size = new System.Drawing.Size(37, 20);
            this.lblPisoRemitente.TabIndex = 16;
            this.lblPisoRemitente.Text = "Piso";
            // 
            // txtAlturaRemitente
            // 
            this.txtAlturaRemitente.Location = new System.Drawing.Point(421, 145);
            this.txtAlturaRemitente.Name = "txtAlturaRemitente";
            this.txtAlturaRemitente.Size = new System.Drawing.Size(110, 27);
            this.txtAlturaRemitente.TabIndex = 8;
            // 
            // lblAlturaRemitente
            // 
            this.lblAlturaRemitente.AutoSize = true;
            this.lblAlturaRemitente.Location = new System.Drawing.Point(421, 122);
            this.lblAlturaRemitente.Name = "lblAlturaRemitente";
            this.lblAlturaRemitente.Size = new System.Drawing.Size(67, 20);
            this.lblAlturaRemitente.TabIndex = 14;
            this.lblAlturaRemitente.Text = "Altura *";
            // 
            // txtCalleRemitente
            // 
            this.txtCalleRemitente.Location = new System.Drawing.Point(20, 145);
            this.txtCalleRemitente.MaxLength = 50;
            this.txtCalleRemitente.Name = "txtCalleRemitente";
            this.txtCalleRemitente.Size = new System.Drawing.Size(370, 27);
            this.txtCalleRemitente.TabIndex = 7;
            // 
            // lblCalleRemitente
            // 
            this.lblCalleRemitente.AutoSize = true;
            this.lblCalleRemitente.Location = new System.Drawing.Point(20, 122);
            this.lblCalleRemitente.Name = "lblCalleRemitente";
            this.lblCalleRemitente.Size = new System.Drawing.Size(58, 20);
            this.lblCalleRemitente.TabIndex = 12;
            this.lblCalleRemitente.Text = "Calle *";
            // 
            // txtTelefonoRemitente
            // 
            this.txtTelefonoRemitente.Location = new System.Drawing.Point(907, 56);
            this.txtTelefonoRemitente.MaxLength = 15;
            this.txtTelefonoRemitente.Name = "txtTelefonoRemitente";
            this.txtTelefonoRemitente.Size = new System.Drawing.Size(220, 27);
            this.txtTelefonoRemitente.TabIndex = 6;
            // 
            // lblTelefonoRemitente
            // 
            this.lblTelefonoRemitente.AutoSize = true;
            this.lblTelefonoRemitente.Location = new System.Drawing.Point(907, 33);
            this.lblTelefonoRemitente.Name = "lblTelefonoRemitente";
            this.lblTelefonoRemitente.Size = new System.Drawing.Size(85, 20);
            this.lblTelefonoRemitente.TabIndex = 10;
            this.lblTelefonoRemitente.Text = "Telefono *";
            // 
            // txtDniRemitente
            // 
            this.txtDniRemitente.Location = new System.Drawing.Point(735, 56);
            this.txtDniRemitente.MaxLength = 9;
            this.txtDniRemitente.Name = "txtDniRemitente";
            this.txtDniRemitente.Size = new System.Drawing.Size(140, 27);
            this.txtDniRemitente.TabIndex = 5;
            // 
            // lblDniRemitente
            // 
            this.lblDniRemitente.AutoSize = true;
            this.lblDniRemitente.Location = new System.Drawing.Point(735, 33);
            this.lblDniRemitente.Name = "lblDniRemitente";
            this.lblDniRemitente.Size = new System.Drawing.Size(47, 20);
            this.lblDniRemitente.TabIndex = 8;
            this.lblDniRemitente.Text = "DNI *";
            // 
            // txtApellidoRemitente
            // 
            this.txtApellidoRemitente.Location = new System.Drawing.Point(566, 56);
            this.txtApellidoRemitente.MaxLength = 30;
            this.txtApellidoRemitente.Name = "txtApellidoRemitente";
            this.txtApellidoRemitente.Size = new System.Drawing.Size(130, 27);
            this.txtApellidoRemitente.TabIndex = 4;
            // 
            // lblApellidoRemitente
            // 
            this.lblApellidoRemitente.AutoSize = true;
            this.lblApellidoRemitente.Location = new System.Drawing.Point(566, 33);
            this.lblApellidoRemitente.Name = "lblApellidoRemitente";
            this.lblApellidoRemitente.Size = new System.Drawing.Size(79, 20);
            this.lblApellidoRemitente.TabIndex = 6;
            this.lblApellidoRemitente.Text = "Apellido *";
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.Location = new System.Drawing.Point(421, 56);
            this.txtNombreRemitente.MaxLength = 30;
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.Size = new System.Drawing.Size(110, 27);
            this.txtNombreRemitente.TabIndex = 3;
            // 
            // lblNombreRemitente
            // 
            this.lblNombreRemitente.AutoSize = true;
            this.lblNombreRemitente.Location = new System.Drawing.Point(421, 33);
            this.lblNombreRemitente.Name = "lblNombreRemitente";
            this.lblNombreRemitente.Size = new System.Drawing.Size(77, 20);
            this.lblNombreRemitente.TabIndex = 4;
            this.lblNombreRemitente.Text = "Nombre *";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(306, 56);
            this.txtCuit.MaxLength = 20;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(90, 27);
            this.txtCuit.TabIndex = 2;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(306, 33);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(52, 20);
            this.lblCuit.TabIndex = 2;
            this.lblCuit.Text = "CUIT *";
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Controls.Add(this.txtTelefonoDestinatario);
            this.grpDestinatario.Controls.Add(this.lblTelefonoDestinatario);
            this.grpDestinatario.Controls.Add(this.txtDniDestinatario);
            this.grpDestinatario.Controls.Add(this.lblDniDestinatario);
            this.grpDestinatario.Controls.Add(this.txtApellidoDestinatario);
            this.grpDestinatario.Controls.Add(this.lblApellidoDestinatario);
            this.grpDestinatario.Controls.Add(this.txtNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.lblNombreDestinatario);
            this.grpDestinatario.Location = new System.Drawing.Point(20, 367);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(1163, 96);
            this.grpDestinatario.TabIndex = 5;
            this.grpDestinatario.TabStop = false;
            this.grpDestinatario.Text = "3. Datos del destinatario";
            // 
            // txtTelefonoDestinatario
            // 
            this.txtTelefonoDestinatario.Location = new System.Drawing.Point(867, 47);
            this.txtTelefonoDestinatario.MaxLength = 15;
            this.txtTelefonoDestinatario.Name = "txtTelefonoDestinatario";
            this.txtTelefonoDestinatario.Size = new System.Drawing.Size(260, 27);
            this.txtTelefonoDestinatario.TabIndex = 4;
            // 
            // lblTelefonoDestinatario
            // 
            this.lblTelefonoDestinatario.AutoSize = true;
            this.lblTelefonoDestinatario.Location = new System.Drawing.Point(867, 24);
            this.lblTelefonoDestinatario.Name = "lblTelefonoDestinatario";
            this.lblTelefonoDestinatario.Size = new System.Drawing.Size(96, 20);
            this.lblTelefonoDestinatario.TabIndex = 6;
            this.lblTelefonoDestinatario.Text = "Telefono  *";
            // 
            // txtDniDestinatario
            // 
            this.txtDniDestinatario.Location = new System.Drawing.Point(588, 47);
            this.txtDniDestinatario.MaxLength = 9;
            this.txtDniDestinatario.Name = "txtDniDestinatario";
            this.txtDniDestinatario.Size = new System.Drawing.Size(220, 27);
            this.txtDniDestinatario.TabIndex = 3;
            // 
            // lblDniDestinatario
            // 
            this.lblDniDestinatario.AutoSize = true;
            this.lblDniDestinatario.Location = new System.Drawing.Point(588, 24);
            this.lblDniDestinatario.Name = "lblDniDestinatario";
            this.lblDniDestinatario.Size = new System.Drawing.Size(58, 20);
            this.lblDniDestinatario.TabIndex = 4;
            this.lblDniDestinatario.Text = "DNI  *";
            // 
            // txtApellidoDestinatario
            // 
            this.txtApellidoDestinatario.Location = new System.Drawing.Point(306, 47);
            this.txtApellidoDestinatario.MaxLength = 30;
            this.txtApellidoDestinatario.Name = "txtApellidoDestinatario";
            this.txtApellidoDestinatario.Size = new System.Drawing.Size(220, 27);
            this.txtApellidoDestinatario.TabIndex = 2;
            // 
            // lblApellidoDestinatario
            // 
            this.lblApellidoDestinatario.AutoSize = true;
            this.lblApellidoDestinatario.Location = new System.Drawing.Point(306, 24);
            this.lblApellidoDestinatario.Name = "lblApellidoDestinatario";
            this.lblApellidoDestinatario.Size = new System.Drawing.Size(79, 20);
            this.lblApellidoDestinatario.TabIndex = 2;
            this.lblApellidoDestinatario.Text = "Apellido *";
            // 
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(20, 47);
            this.txtNombreDestinatario.MaxLength = 30;
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(220, 27);
            this.txtNombreDestinatario.TabIndex = 1;
            // 
            // lblNombreDestinatario
            // 
            this.lblNombreDestinatario.AutoSize = true;
            this.lblNombreDestinatario.Location = new System.Drawing.Point(20, 24);
            this.lblNombreDestinatario.Name = "lblNombreDestinatario";
            this.lblNombreDestinatario.Size = new System.Drawing.Size(77, 20);
            this.lblNombreDestinatario.TabIndex = 0;
            this.lblNombreDestinatario.Text = "Nombre *";
            // 
            // grpEnvio
            // 
            this.grpEnvio.Controls.Add(this.cboAgencia);
            this.grpEnvio.Controls.Add(this.lblAgencia);
            this.grpEnvio.Controls.Add(this.txtCiudadEntrega);
            this.grpEnvio.Controls.Add(this.lblCiudadEntrega);
            this.grpEnvio.Controls.Add(this.txtCodigoPostalEntrega);
            this.grpEnvio.Controls.Add(this.lblCodigoPostalEntrega);
            this.grpEnvio.Controls.Add(this.txtPisoEntrega);
            this.grpEnvio.Controls.Add(this.lblPisoEntrega);
            this.grpEnvio.Controls.Add(this.txtAlturaEntrega);
            this.grpEnvio.Controls.Add(this.lblAlturaEntrega);
            this.grpEnvio.Controls.Add(this.txtCalleEntrega);
            this.grpEnvio.Controls.Add(this.lblCalleEntrega);
            this.grpEnvio.Controls.Add(this.cboTipoBulto);
            this.grpEnvio.Controls.Add(this.lblTipoBulto);
            this.grpEnvio.Controls.Add(this.cboTipoEntrega);
            this.grpEnvio.Controls.Add(this.lblTipoEntrega);
            this.grpEnvio.Controls.Add(this.cboCdDestino);
            this.grpEnvio.Controls.Add(this.lblCdDestino);
            this.grpEnvio.Controls.Add(this.cboCdOrigen);
            this.grpEnvio.Controls.Add(this.lblCdOrigen);
            this.grpEnvio.Location = new System.Drawing.Point(20, 478);
            this.grpEnvio.Name = "grpEnvio";
            this.grpEnvio.Size = new System.Drawing.Size(1163, 172);
            this.grpEnvio.TabIndex = 6;
            this.grpEnvio.TabStop = false;
            this.grpEnvio.Text = "4. Datos del envio";
            // 
            // cboAgencia
            // 
            this.cboAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgencia.FormattingEnabled = true;
            this.cboAgencia.Location = new System.Drawing.Point(867, 58);
            this.cboAgencia.Name = "cboAgencia";
            this.cboAgencia.Size = new System.Drawing.Size(260, 28);
            this.cboAgencia.TabIndex = 5;
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(867, 35);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(74, 20);
            this.lblAgencia.TabIndex = 18;
            this.lblAgencia.Text = "Agencia *";
            // 
            // txtCiudadEntrega
            // 
            this.txtCiudadEntrega.Location = new System.Drawing.Point(907, 129);
            this.txtCiudadEntrega.MaxLength = 40;
            this.txtCiudadEntrega.Name = "txtCiudadEntrega";
            this.txtCiudadEntrega.Size = new System.Drawing.Size(220, 27);
            this.txtCiudadEntrega.TabIndex = 10;
            // 
            // lblCiudadEntrega
            // 
            this.lblCiudadEntrega.AutoSize = true;
            this.lblCiudadEntrega.Location = new System.Drawing.Point(907, 106);
            this.lblCiudadEntrega.Name = "lblCiudadEntrega";
            this.lblCiudadEntrega.Size = new System.Drawing.Size(69, 20);
            this.lblCiudadEntrega.TabIndex = 16;
            this.lblCiudadEntrega.Text = "Ciudad *";
            // 
            // txtCodigoPostalEntrega
            // 
            this.txtCodigoPostalEntrega.Location = new System.Drawing.Point(735, 129);
            this.txtCodigoPostalEntrega.MaxLength = 10;
            this.txtCodigoPostalEntrega.Name = "txtCodigoPostalEntrega";
            this.txtCodigoPostalEntrega.Size = new System.Drawing.Size(140, 27);
            this.txtCodigoPostalEntrega.TabIndex = 9;
            // 
            // lblCodigoPostalEntrega
            // 
            this.lblCodigoPostalEntrega.AutoSize = true;
            this.lblCodigoPostalEntrega.Location = new System.Drawing.Point(735, 106);
            this.lblCodigoPostalEntrega.Name = "lblCodigoPostalEntrega";
            this.lblCodigoPostalEntrega.Size = new System.Drawing.Size(109, 20);
            this.lblCodigoPostalEntrega.TabIndex = 14;
            this.lblCodigoPostalEntrega.Text = "Codigo postal *";
            // 
            // txtPisoEntrega
            // 
            this.txtPisoEntrega.Location = new System.Drawing.Point(566, 129);
            this.txtPisoEntrega.MaxLength = 10;
            this.txtPisoEntrega.Name = "txtPisoEntrega";
            this.txtPisoEntrega.Size = new System.Drawing.Size(130, 27);
            this.txtPisoEntrega.TabIndex = 8;
            // 
            // lblPisoEntrega
            // 
            this.lblPisoEntrega.AutoSize = true;
            this.lblPisoEntrega.Location = new System.Drawing.Point(566, 106);
            this.lblPisoEntrega.Name = "lblPisoEntrega";
            this.lblPisoEntrega.Size = new System.Drawing.Size(37, 20);
            this.lblPisoEntrega.TabIndex = 12;
            this.lblPisoEntrega.Text = "Piso";
            // 
            // txtAlturaEntrega
            // 
            this.txtAlturaEntrega.Location = new System.Drawing.Point(421, 129);
            this.txtAlturaEntrega.Name = "txtAlturaEntrega";
            this.txtAlturaEntrega.Size = new System.Drawing.Size(110, 27);
            this.txtAlturaEntrega.TabIndex = 7;
            // 
            // lblAlturaEntrega
            // 
            this.lblAlturaEntrega.AutoSize = true;
            this.lblAlturaEntrega.Location = new System.Drawing.Point(421, 106);
            this.lblAlturaEntrega.Name = "lblAlturaEntrega";
            this.lblAlturaEntrega.Size = new System.Drawing.Size(67, 20);
            this.lblAlturaEntrega.TabIndex = 10;
            this.lblAlturaEntrega.Text = "Altura *";
            // 
            // txtCalleEntrega
            // 
            this.txtCalleEntrega.Location = new System.Drawing.Point(20, 129);
            this.txtCalleEntrega.MaxLength = 50;
            this.txtCalleEntrega.Name = "txtCalleEntrega";
            this.txtCalleEntrega.Size = new System.Drawing.Size(370, 27);
            this.txtCalleEntrega.TabIndex = 6;
            // 
            // lblCalleEntrega
            // 
            this.lblCalleEntrega.AutoSize = true;
            this.lblCalleEntrega.Location = new System.Drawing.Point(20, 106);
            this.lblCalleEntrega.Name = "lblCalleEntrega";
            this.lblCalleEntrega.Size = new System.Drawing.Size(58, 20);
            this.lblCalleEntrega.TabIndex = 8;
            this.lblCalleEntrega.Text = "Calle *";
            // 
            // cboTipoBulto
            // 
            this.cboTipoBulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBulto.FormattingEnabled = true;
            this.cboTipoBulto.Location = new System.Drawing.Point(588, 58);
            this.cboTipoBulto.Name = "cboTipoBulto";
            this.cboTipoBulto.Size = new System.Drawing.Size(220, 28);
            this.cboTipoBulto.TabIndex = 4;
            // 
            // lblTipoBulto
            // 
            this.lblTipoBulto.AutoSize = true;
            this.lblTipoBulto.Location = new System.Drawing.Point(588, 35);
            this.lblTipoBulto.Name = "lblTipoBulto";
            this.lblTipoBulto.Size = new System.Drawing.Size(85, 20);
            this.lblTipoBulto.TabIndex = 6;
            this.lblTipoBulto.Text = "Tipo bulto *";
            // 
            // cboTipoEntrega
            // 
            this.cboTipoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEntrega.FormattingEnabled = true;
            this.cboTipoEntrega.Location = new System.Drawing.Point(306, 58);
            this.cboTipoEntrega.Name = "cboTipoEntrega";
            this.cboTipoEntrega.Size = new System.Drawing.Size(220, 28);
            this.cboTipoEntrega.TabIndex = 3;
            this.cboTipoEntrega.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntrega_SelectedIndexChanged);
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.AutoSize = true;
            this.lblTipoEntrega.Location = new System.Drawing.Point(306, 35);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(95, 20);
            this.lblTipoEntrega.TabIndex = 4;
            this.lblTipoEntrega.Text = "Tipo entrega *";
            // 
            // cboCdDestino
            // 
            this.cboCdDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCdDestino.FormattingEnabled = true;
            this.cboCdDestino.Location = new System.Drawing.Point(155, 58);
            this.cboCdDestino.Name = "cboCdDestino";
            this.cboCdDestino.Size = new System.Drawing.Size(110, 28);
            this.cboCdDestino.TabIndex = 2;
            // 
            // lblCdDestino
            // 
            this.lblCdDestino.AutoSize = true;
            this.lblCdDestino.Location = new System.Drawing.Point(155, 35);
            this.lblCdDestino.Name = "lblCdDestino";
            this.lblCdDestino.Size = new System.Drawing.Size(84, 20);
            this.lblCdDestino.TabIndex = 2;
            this.lblCdDestino.Text = "CD destino *";
            // 
            // cboCdOrigen
            // 
            this.cboCdOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCdOrigen.FormattingEnabled = true;
            this.cboCdOrigen.Location = new System.Drawing.Point(20, 58);
            this.cboCdOrigen.Name = "cboCdOrigen";
            this.cboCdOrigen.Size = new System.Drawing.Size(110, 28);
            this.cboCdOrigen.TabIndex = 1;
            // 
            // lblCdOrigen
            // 
            this.lblCdOrigen.AutoSize = true;
            this.lblCdOrigen.Location = new System.Drawing.Point(20, 35);
            this.lblCdOrigen.Name = "lblCdOrigen";
            this.lblCdOrigen.Size = new System.Drawing.Size(80, 20);
            this.lblCdOrigen.TabIndex = 0;
            this.lblCdOrigen.Text = "CD origen *";
            // 
            // btnGenerarGuia
            // 
            this.btnGenerarGuia.Location = new System.Drawing.Point(987, 662);
            this.btnGenerarGuia.Name = "btnGenerarGuia";
            this.btnGenerarGuia.Size = new System.Drawing.Size(196, 41);
            this.btnGenerarGuia.TabIndex = 7;
            this.btnGenerarGuia.Text = "Generar guia";
            this.btnGenerarGuia.UseVisualStyleBackColor = true;
            this.btnGenerarGuia.Click += new System.EventHandler(this.btnGenerarGuia_Click);
            // 
            // txtSalidaGuia
            // 
            this.txtSalidaGuia.Location = new System.Drawing.Point(20, 742);
            this.txtSalidaGuia.Multiline = true;
            this.txtSalidaGuia.Name = "txtSalidaGuia";
            this.txtSalidaGuia.ReadOnly = true;
            this.txtSalidaGuia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalidaGuia.Size = new System.Drawing.Size(1163, 169);
            this.txtSalidaGuia.TabIndex = 8;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(20, 719);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(96, 20);
            this.lblSalida.TabIndex = 9;
            this.lblSalida.Text = "Guia generada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 930);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtSalidaGuia);
            this.Controls.Add(this.btnGenerarGuia);
            this.Controls.Add(this.grpEnvio);
            this.Controls.Add(this.grpDestinatario);
            this.Controls.Add(this.grpRemitente);
            this.Controls.Add(this.grpTipoCliente);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imposicion en Callcenter";
            this.grpTipoCliente.ResumeLayout(false);
            this.grpTipoCliente.PerformLayout();
            this.grpRemitente.ResumeLayout(false);
            this.grpRemitente.PerformLayout();
            this.grpDestinatario.ResumeLayout(false);
            this.grpDestinatario.PerformLayout();
            this.grpEnvio.ResumeLayout(false);
            this.grpEnvio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.GroupBox grpTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.GroupBox grpRemitente;
        private System.Windows.Forms.ComboBox cboRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCiudadRemitente;
        private System.Windows.Forms.Label lblCiudadRemitente;
        private System.Windows.Forms.TextBox txtCodigoPostalRemitente;
        private System.Windows.Forms.Label lblCodigoPostalRemitente;
        private System.Windows.Forms.TextBox txtPisoRemitente;
        private System.Windows.Forms.Label lblPisoRemitente;
        private System.Windows.Forms.TextBox txtAlturaRemitente;
        private System.Windows.Forms.Label lblAlturaRemitente;
        private System.Windows.Forms.TextBox txtCalleRemitente;
        private System.Windows.Forms.Label lblCalleRemitente;
        private System.Windows.Forms.TextBox txtTelefonoRemitente;
        private System.Windows.Forms.Label lblTelefonoRemitente;
        private System.Windows.Forms.TextBox txtDniRemitente;
        private System.Windows.Forms.Label lblDniRemitente;
        private System.Windows.Forms.TextBox txtApellidoRemitente;
        private System.Windows.Forms.Label lblApellidoRemitente;
        private System.Windows.Forms.TextBox txtNombreRemitente;
        private System.Windows.Forms.Label lblNombreRemitente;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.GroupBox grpDestinatario;
        private System.Windows.Forms.TextBox txtTelefonoDestinatario;
        private System.Windows.Forms.Label lblTelefonoDestinatario;
        private System.Windows.Forms.TextBox txtDniDestinatario;
        private System.Windows.Forms.Label lblDniDestinatario;
        private System.Windows.Forms.TextBox txtApellidoDestinatario;
        private System.Windows.Forms.Label lblApellidoDestinatario;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.Label lblNombreDestinatario;
        private System.Windows.Forms.GroupBox grpEnvio;
        private System.Windows.Forms.ComboBox cboAgencia;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.TextBox txtCiudadEntrega;
        private System.Windows.Forms.Label lblCiudadEntrega;
        private System.Windows.Forms.TextBox txtCodigoPostalEntrega;
        private System.Windows.Forms.Label lblCodigoPostalEntrega;
        private System.Windows.Forms.TextBox txtPisoEntrega;
        private System.Windows.Forms.Label lblPisoEntrega;
        private System.Windows.Forms.TextBox txtAlturaEntrega;
        private System.Windows.Forms.Label lblAlturaEntrega;
        private System.Windows.Forms.TextBox txtCalleEntrega;
        private System.Windows.Forms.Label lblCalleEntrega;
        private System.Windows.Forms.ComboBox cboTipoBulto;
        private System.Windows.Forms.Label lblTipoBulto;
        private System.Windows.Forms.ComboBox cboTipoEntrega;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.ComboBox cboCdDestino;
        private System.Windows.Forms.Label lblCdDestino;
        private System.Windows.Forms.ComboBox cboCdOrigen;
        private System.Windows.Forms.Label lblCdOrigen;
        private System.Windows.Forms.Button btnGenerarGuia;
        private System.Windows.Forms.TextBox txtSalidaGuia;
        private System.Windows.Forms.Label lblSalida;
    }
}
