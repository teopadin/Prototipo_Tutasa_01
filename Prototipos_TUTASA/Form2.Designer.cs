namespace Prototipos_TUTASA
{
    partial class Form2
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

        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.cboRazonSocial = new System.Windows.Forms.ComboBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblNombreRemitente = new System.Windows.Forms.Label();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.lblApellidoRemitente = new System.Windows.Forms.Label();
            this.txtApellidoRemitente = new System.Windows.Forms.TextBox();
            this.lblDniRemitente = new System.Windows.Forms.Label();
            this.txtDniRemitente = new System.Windows.Forms.TextBox();
            this.lblTelefonoRemitente = new System.Windows.Forms.Label();
            this.txtTelefonoRemitente = new System.Windows.Forms.TextBox();
            this.lblCalleRemitente = new System.Windows.Forms.Label();
            this.txtCalleRemitente = new System.Windows.Forms.TextBox();
            this.lblAlturaRemitente = new System.Windows.Forms.Label();
            this.txtAlturaRemitente = new System.Windows.Forms.TextBox();
            this.lblPisoRemitente = new System.Windows.Forms.Label();
            this.txtPisoRemitente = new System.Windows.Forms.TextBox();
            this.lblCodigoPostalRemitente = new System.Windows.Forms.Label();
            this.txtCodigoPostalRemitente = new System.Windows.Forms.TextBox();
            this.lblCiudadRemitente = new System.Windows.Forms.Label();
            this.txtCiudadRemitente = new System.Windows.Forms.TextBox();
            this.lblNombreDestinatario = new System.Windows.Forms.Label();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.lblApellidoDestinatario = new System.Windows.Forms.Label();
            this.txtApellidoDestinatario = new System.Windows.Forms.TextBox();
            this.lblDniDestinatario = new System.Windows.Forms.Label();
            this.txtDniDestinatario = new System.Windows.Forms.TextBox();
            this.lblTelefonoDestinatario = new System.Windows.Forms.Label();
            this.txtTelefonoDestinatario = new System.Windows.Forms.TextBox();
            this.lblCdOrigen = new System.Windows.Forms.Label();
            this.cboCdOrigen = new System.Windows.Forms.ComboBox();
            this.lblCdDestino = new System.Windows.Forms.Label();
            this.cboCdDestino = new System.Windows.Forms.ComboBox();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.cboTipoEntrega = new System.Windows.Forms.ComboBox();
            this.lblTipoBulto = new System.Windows.Forms.Label();
            this.cboTipoBulto = new System.Windows.Forms.ComboBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.cboAgencia = new System.Windows.Forms.ComboBox();
            this.lblCalleEntrega = new System.Windows.Forms.Label();
            this.txtCalleEntrega = new System.Windows.Forms.TextBox();
            this.lblAlturaEntrega = new System.Windows.Forms.Label();
            this.txtAlturaEntrega = new System.Windows.Forms.TextBox();
            this.lblPisoEntrega = new System.Windows.Forms.Label();
            this.txtPisoEntrega = new System.Windows.Forms.TextBox();
            this.lblCodigoPostalEntrega = new System.Windows.Forms.Label();
            this.txtCodigoPostalEntrega = new System.Windows.Forms.TextBox();
            this.lblCiudadEntrega = new System.Windows.Forms.Label();
            this.txtCiudadEntrega = new System.Windows.Forms.TextBox();
            this.btnGenerarGuia = new System.Windows.Forms.Button();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(100, 12);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(120, 27);
            this.txtFecha.TabIndex = 1;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(12, 55);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(82, 20);
            this.lblTipoCliente.TabIndex = 2;
            this.lblTipoCliente.Text = "Tipo cliente";
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(100, 52);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(180, 28);
            this.cboTipoCliente.TabIndex = 3;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 95);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(88, 20);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // cboRazonSocial
            // 
            this.cboRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRazonSocial.FormattingEnabled = true;
            this.cboRazonSocial.Location = new System.Drawing.Point(100, 92);
            this.cboRazonSocial.Name = "cboRazonSocial";
            this.cboRazonSocial.Size = new System.Drawing.Size(180, 28);
            this.cboRazonSocial.TabIndex = 5;
            this.cboRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cboRazonSocial_SelectedIndexChanged);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(300, 95);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(39, 20);
            this.lblCuit.TabIndex = 6;
            this.lblCuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(345, 92);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(150, 27);
            this.txtCuit.TabIndex = 7;
            // 
            // lblNombreRemitente
            // 
            this.lblNombreRemitente.AutoSize = true;
            this.lblNombreRemitente.Location = new System.Drawing.Point(12, 135);
            this.lblNombreRemitente.Name = "lblNombreRemitente";
            this.lblNombreRemitente.Size = new System.Drawing.Size(64, 20);
            this.lblNombreRemitente.TabIndex = 8;
            this.lblNombreRemitente.Text = "Nombre";
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.Location = new System.Drawing.Point(100, 132);
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.Size = new System.Drawing.Size(180, 27);
            this.txtNombreRemitente.TabIndex = 9;
            // 
            // lblApellidoRemitente
            // 
            this.lblApellidoRemitente.AutoSize = true;
            this.lblApellidoRemitente.Location = new System.Drawing.Point(300, 135);
            this.lblApellidoRemitente.Name = "lblApellidoRemitente";
            this.lblApellidoRemitente.Size = new System.Drawing.Size(66, 20);
            this.lblApellidoRemitente.TabIndex = 10;
            this.lblApellidoRemitente.Text = "Apellido";
            // 
            // txtApellidoRemitente
            // 
            this.txtApellidoRemitente.Location = new System.Drawing.Point(372, 132);
            this.txtApellidoRemitente.Name = "txtApellidoRemitente";
            this.txtApellidoRemitente.Size = new System.Drawing.Size(180, 27);
            this.txtApellidoRemitente.TabIndex = 11;
            // 
            // lblDniRemitente
            // 
            this.lblDniRemitente.AutoSize = true;
            this.lblDniRemitente.Location = new System.Drawing.Point(570, 135);
            this.lblDniRemitente.Name = "lblDniRemitente";
            this.lblDniRemitente.Size = new System.Drawing.Size(35, 20);
            this.lblDniRemitente.TabIndex = 12;
            this.lblDniRemitente.Text = "DNI";
            // 
            // txtDniRemitente
            // 
            this.txtDniRemitente.Location = new System.Drawing.Point(611, 132);
            this.txtDniRemitente.Name = "txtDniRemitente";
            this.txtDniRemitente.Size = new System.Drawing.Size(120, 27);
            this.txtDniRemitente.TabIndex = 13;
            // 
            // lblTelefonoRemitente
            // 
            this.lblTelefonoRemitente.AutoSize = true;
            this.lblTelefonoRemitente.Location = new System.Drawing.Point(12, 175);
            this.lblTelefonoRemitente.Name = "lblTelefonoRemitente";
            this.lblTelefonoRemitente.Size = new System.Drawing.Size(67, 20);
            this.lblTelefonoRemitente.TabIndex = 14;
            this.lblTelefonoRemitente.Text = "Telefono";
            // 
            // txtTelefonoRemitente
            // 
            this.txtTelefonoRemitente.Location = new System.Drawing.Point(100, 172);
            this.txtTelefonoRemitente.Name = "txtTelefonoRemitente";
            this.txtTelefonoRemitente.Size = new System.Drawing.Size(180, 27);
            this.txtTelefonoRemitente.TabIndex = 15;
            // 
            // lblCalleRemitente
            // 
            this.lblCalleRemitente.AutoSize = true;
            this.lblCalleRemitente.Location = new System.Drawing.Point(300, 175);
            this.lblCalleRemitente.Name = "lblCalleRemitente";
            this.lblCalleRemitente.Size = new System.Drawing.Size(41, 20);
            this.lblCalleRemitente.TabIndex = 16;
            this.lblCalleRemitente.Text = "Calle";
            // 
            // txtCalleRemitente
            // 
            this.txtCalleRemitente.Location = new System.Drawing.Point(372, 172);
            this.txtCalleRemitente.Name = "txtCalleRemitente";
            this.txtCalleRemitente.Size = new System.Drawing.Size(180, 27);
            this.txtCalleRemitente.TabIndex = 17;
            // 
            // lblAlturaRemitente
            // 
            this.lblAlturaRemitente.AutoSize = true;
            this.lblAlturaRemitente.Location = new System.Drawing.Point(570, 175);
            this.lblAlturaRemitente.Name = "lblAlturaRemitente";
            this.lblAlturaRemitente.Size = new System.Drawing.Size(49, 20);
            this.lblAlturaRemitente.TabIndex = 18;
            this.lblAlturaRemitente.Text = "Altura";
            // 
            // txtAlturaRemitente
            // 
            this.txtAlturaRemitente.Location = new System.Drawing.Point(625, 172);
            this.txtAlturaRemitente.Name = "txtAlturaRemitente";
            this.txtAlturaRemitente.Size = new System.Drawing.Size(106, 27);
            this.txtAlturaRemitente.TabIndex = 19;
            // 
            // lblPisoRemitente
            // 
            this.lblPisoRemitente.AutoSize = true;
            this.lblPisoRemitente.Location = new System.Drawing.Point(12, 215);
            this.lblPisoRemitente.Name = "lblPisoRemitente";
            this.lblPisoRemitente.Size = new System.Drawing.Size(37, 20);
            this.lblPisoRemitente.TabIndex = 20;
            this.lblPisoRemitente.Text = "Piso";
            // 
            // txtPisoRemitente
            // 
            this.txtPisoRemitente.Location = new System.Drawing.Point(100, 212);
            this.txtPisoRemitente.Name = "txtPisoRemitente";
            this.txtPisoRemitente.Size = new System.Drawing.Size(180, 27);
            this.txtPisoRemitente.TabIndex = 21;
            // 
            // lblCodigoPostalRemitente
            // 
            this.lblCodigoPostalRemitente.AutoSize = true;
            this.lblCodigoPostalRemitente.Location = new System.Drawing.Point(300, 215);
            this.lblCodigoPostalRemitente.Name = "lblCodigoPostalRemitente";
            this.lblCodigoPostalRemitente.Size = new System.Drawing.Size(96, 20);
            this.lblCodigoPostalRemitente.TabIndex = 22;
            this.lblCodigoPostalRemitente.Text = "Codigo postal";
            // 
            // txtCodigoPostalRemitente
            // 
            this.txtCodigoPostalRemitente.Location = new System.Drawing.Point(402, 212);
            this.txtCodigoPostalRemitente.Name = "txtCodigoPostalRemitente";
            this.txtCodigoPostalRemitente.Size = new System.Drawing.Size(150, 27);
            this.txtCodigoPostalRemitente.TabIndex = 23;
            // 
            // lblCiudadRemitente
            // 
            this.lblCiudadRemitente.AutoSize = true;
            this.lblCiudadRemitente.Location = new System.Drawing.Point(570, 215);
            this.lblCiudadRemitente.Name = "lblCiudadRemitente";
            this.lblCiudadRemitente.Size = new System.Drawing.Size(55, 20);
            this.lblCiudadRemitente.TabIndex = 24;
            this.lblCiudadRemitente.Text = "Ciudad";
            // 
            // txtCiudadRemitente
            // 
            this.txtCiudadRemitente.Location = new System.Drawing.Point(631, 212);
            this.txtCiudadRemitente.Name = "txtCiudadRemitente";
            this.txtCiudadRemitente.Size = new System.Drawing.Size(180, 27);
            this.txtCiudadRemitente.TabIndex = 25;
            // 
            // lblNombreDestinatario
            // 
            this.lblNombreDestinatario.AutoSize = true;
            this.lblNombreDestinatario.Location = new System.Drawing.Point(12, 270);
            this.lblNombreDestinatario.Name = "lblNombreDestinatario";
            this.lblNombreDestinatario.Size = new System.Drawing.Size(82, 20);
            this.lblNombreDestinatario.TabIndex = 26;
            this.lblNombreDestinatario.Text = "Nom desti";
            // 
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(100, 267);
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(180, 27);
            this.txtNombreDestinatario.TabIndex = 27;
            // 
            // lblApellidoDestinatario
            // 
            this.lblApellidoDestinatario.AutoSize = true;
            this.lblApellidoDestinatario.Location = new System.Drawing.Point(300, 270);
            this.lblApellidoDestinatario.Name = "lblApellidoDestinatario";
            this.lblApellidoDestinatario.Size = new System.Drawing.Size(84, 20);
            this.lblApellidoDestinatario.TabIndex = 28;
            this.lblApellidoDestinatario.Text = "Ape desti";
            // 
            // txtApellidoDestinatario
            // 
            this.txtApellidoDestinatario.Location = new System.Drawing.Point(390, 267);
            this.txtApellidoDestinatario.Name = "txtApellidoDestinatario";
            this.txtApellidoDestinatario.Size = new System.Drawing.Size(162, 27);
            this.txtApellidoDestinatario.TabIndex = 29;
            // 
            // lblDniDestinatario
            // 
            this.lblDniDestinatario.AutoSize = true;
            this.lblDniDestinatario.Location = new System.Drawing.Point(570, 270);
            this.lblDniDestinatario.Name = "lblDniDestinatario";
            this.lblDniDestinatario.Size = new System.Drawing.Size(63, 20);
            this.lblDniDestinatario.TabIndex = 30;
            this.lblDniDestinatario.Text = "DNI desti";
            // 
            // txtDniDestinatario
            // 
            this.txtDniDestinatario.Location = new System.Drawing.Point(639, 267);
            this.txtDniDestinatario.Name = "txtDniDestinatario";
            this.txtDniDestinatario.Size = new System.Drawing.Size(92, 27);
            this.txtDniDestinatario.TabIndex = 31;
            // 
            // lblTelefonoDestinatario
            // 
            this.lblTelefonoDestinatario.AutoSize = true;
            this.lblTelefonoDestinatario.Location = new System.Drawing.Point(750, 270);
            this.lblTelefonoDestinatario.Name = "lblTelefonoDestinatario";
            this.lblTelefonoDestinatario.Size = new System.Drawing.Size(93, 20);
            this.lblTelefonoDestinatario.TabIndex = 32;
            this.lblTelefonoDestinatario.Text = "Tel desti";
            // 
            // txtTelefonoDestinatario
            // 
            this.txtTelefonoDestinatario.Location = new System.Drawing.Point(849, 267);
            this.txtTelefonoDestinatario.Name = "txtTelefonoDestinatario";
            this.txtTelefonoDestinatario.Size = new System.Drawing.Size(150, 27);
            this.txtTelefonoDestinatario.TabIndex = 33;
            // 
            // lblCdOrigen
            // 
            this.lblCdOrigen.AutoSize = true;
            this.lblCdOrigen.Location = new System.Drawing.Point(12, 320);
            this.lblCdOrigen.Name = "lblCdOrigen";
            this.lblCdOrigen.Size = new System.Drawing.Size(68, 20);
            this.lblCdOrigen.TabIndex = 34;
            this.lblCdOrigen.Text = "CD origen";
            // 
            // cboCdOrigen
            // 
            this.cboCdOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCdOrigen.FormattingEnabled = true;
            this.cboCdOrigen.Location = new System.Drawing.Point(100, 317);
            this.cboCdOrigen.Name = "cboCdOrigen";
            this.cboCdOrigen.Size = new System.Drawing.Size(121, 28);
            this.cboCdOrigen.TabIndex = 35;
            // 
            // lblCdDestino
            // 
            this.lblCdDestino.AutoSize = true;
            this.lblCdDestino.Location = new System.Drawing.Point(240, 320);
            this.lblCdDestino.Name = "lblCdDestino";
            this.lblCdDestino.Size = new System.Drawing.Size(72, 20);
            this.lblCdDestino.TabIndex = 36;
            this.lblCdDestino.Text = "CD destino";
            // 
            // cboCdDestino
            // 
            this.cboCdDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCdDestino.FormattingEnabled = true;
            this.cboCdDestino.Location = new System.Drawing.Point(318, 317);
            this.cboCdDestino.Name = "cboCdDestino";
            this.cboCdDestino.Size = new System.Drawing.Size(121, 28);
            this.cboCdDestino.TabIndex = 37;
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.AutoSize = true;
            this.lblTipoEntrega.Location = new System.Drawing.Point(458, 320);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(86, 20);
            this.lblTipoEntrega.TabIndex = 38;
            this.lblTipoEntrega.Text = "Tipo entrega";
            // 
            // cboTipoEntrega
            // 
            this.cboTipoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEntrega.FormattingEnabled = true;
            this.cboTipoEntrega.Location = new System.Drawing.Point(550, 317);
            this.cboTipoEntrega.Name = "cboTipoEntrega";
            this.cboTipoEntrega.Size = new System.Drawing.Size(181, 28);
            this.cboTipoEntrega.TabIndex = 39;
            this.cboTipoEntrega.SelectedIndexChanged += new System.EventHandler(this.cboTipoEntrega_SelectedIndexChanged);
            // 
            // lblTipoBulto
            // 
            this.lblTipoBulto.AutoSize = true;
            this.lblTipoBulto.Location = new System.Drawing.Point(750, 320);
            this.lblTipoBulto.Name = "lblTipoBulto";
            this.lblTipoBulto.Size = new System.Drawing.Size(76, 20);
            this.lblTipoBulto.TabIndex = 40;
            this.lblTipoBulto.Text = "Tipo bulto";
            // 
            // cboTipoBulto
            // 
            this.cboTipoBulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBulto.FormattingEnabled = true;
            this.cboTipoBulto.Location = new System.Drawing.Point(832, 317);
            this.cboTipoBulto.Name = "cboTipoBulto";
            this.cboTipoBulto.Size = new System.Drawing.Size(121, 28);
            this.cboTipoBulto.TabIndex = 41;
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(12, 365);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(60, 20);
            this.lblAgencia.TabIndex = 42;
            this.lblAgencia.Text = "Agencia";
            // 
            // cboAgencia
            // 
            this.cboAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgencia.FormattingEnabled = true;
            this.cboAgencia.Location = new System.Drawing.Point(100, 362);
            this.cboAgencia.Name = "cboAgencia";
            this.cboAgencia.Size = new System.Drawing.Size(180, 28);
            this.cboAgencia.TabIndex = 43;
            // 
            // lblCalleEntrega
            // 
            this.lblCalleEntrega.AutoSize = true;
            this.lblCalleEntrega.Location = new System.Drawing.Point(12, 410);
            this.lblCalleEntrega.Name = "lblCalleEntrega";
            this.lblCalleEntrega.Size = new System.Drawing.Size(81, 20);
            this.lblCalleEntrega.TabIndex = 44;
            this.lblCalleEntrega.Text = "Calle entrega";
            // 
            // txtCalleEntrega
            // 
            this.txtCalleEntrega.Location = new System.Drawing.Point(100, 407);
            this.txtCalleEntrega.Name = "txtCalleEntrega";
            this.txtCalleEntrega.Size = new System.Drawing.Size(180, 27);
            this.txtCalleEntrega.TabIndex = 45;
            // 
            // lblAlturaEntrega
            // 
            this.lblAlturaEntrega.AutoSize = true;
            this.lblAlturaEntrega.Location = new System.Drawing.Point(300, 410);
            this.lblAlturaEntrega.Name = "lblAlturaEntrega";
            this.lblAlturaEntrega.Size = new System.Drawing.Size(89, 20);
            this.lblAlturaEntrega.TabIndex = 46;
            this.lblAlturaEntrega.Text = "Altura entrega";
            // 
            // txtAlturaEntrega
            // 
            this.txtAlturaEntrega.Location = new System.Drawing.Point(395, 407);
            this.txtAlturaEntrega.Name = "txtAlturaEntrega";
            this.txtAlturaEntrega.Size = new System.Drawing.Size(157, 27);
            this.txtAlturaEntrega.TabIndex = 47;
            // 
            // lblPisoEntrega
            // 
            this.lblPisoEntrega.AutoSize = true;
            this.lblPisoEntrega.Location = new System.Drawing.Point(570, 410);
            this.lblPisoEntrega.Name = "lblPisoEntrega";
            this.lblPisoEntrega.Size = new System.Drawing.Size(78, 20);
            this.lblPisoEntrega.TabIndex = 48;
            this.lblPisoEntrega.Text = "Piso entrega";
            // 
            // txtPisoEntrega
            // 
            this.txtPisoEntrega.Location = new System.Drawing.Point(654, 407);
            this.txtPisoEntrega.Name = "txtPisoEntrega";
            this.txtPisoEntrega.Size = new System.Drawing.Size(157, 27);
            this.txtPisoEntrega.TabIndex = 49;
            // 
            // lblCodigoPostalEntrega
            // 
            this.lblCodigoPostalEntrega.AutoSize = true;
            this.lblCodigoPostalEntrega.Location = new System.Drawing.Point(12, 450);
            this.lblCodigoPostalEntrega.Name = "lblCodigoPostalEntrega";
            this.lblCodigoPostalEntrega.Size = new System.Drawing.Size(96, 20);
            this.lblCodigoPostalEntrega.TabIndex = 50;
            this.lblCodigoPostalEntrega.Text = "CP entrega";
            // 
            // txtCodigoPostalEntrega
            // 
            this.txtCodigoPostalEntrega.Location = new System.Drawing.Point(100, 447);
            this.txtCodigoPostalEntrega.Name = "txtCodigoPostalEntrega";
            this.txtCodigoPostalEntrega.Size = new System.Drawing.Size(180, 27);
            this.txtCodigoPostalEntrega.TabIndex = 51;
            // 
            // lblCiudadEntrega
            // 
            this.lblCiudadEntrega.AutoSize = true;
            this.lblCiudadEntrega.Location = new System.Drawing.Point(300, 450);
            this.lblCiudadEntrega.Name = "lblCiudadEntrega";
            this.lblCiudadEntrega.Size = new System.Drawing.Size(92, 20);
            this.lblCiudadEntrega.TabIndex = 52;
            this.lblCiudadEntrega.Text = "Ciudad entrega";
            // 
            // txtCiudadEntrega
            // 
            this.txtCiudadEntrega.Location = new System.Drawing.Point(398, 447);
            this.txtCiudadEntrega.Name = "txtCiudadEntrega";
            this.txtCiudadEntrega.Size = new System.Drawing.Size(154, 27);
            this.txtCiudadEntrega.TabIndex = 53;
            // 
            // btnGenerarGuia
            // 
            this.btnGenerarGuia.Location = new System.Drawing.Point(12, 495);
            this.btnGenerarGuia.Name = "btnGenerarGuia";
            this.btnGenerarGuia.Size = new System.Drawing.Size(150, 32);
            this.btnGenerarGuia.TabIndex = 54;
            this.btnGenerarGuia.Text = "Generar guia";
            this.btnGenerarGuia.UseVisualStyleBackColor = true;
            this.btnGenerarGuia.Click += new System.EventHandler(this.btnGenerarGuia_Click);
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(12, 543);
            this.txtGuia.Multiline = true;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.ReadOnly = true;
            this.txtGuia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuia.Size = new System.Drawing.Size(987, 170);
            this.txtGuia.TabIndex = 55;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1014, 728);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.btnGenerarGuia);
            this.Controls.Add(this.txtCiudadEntrega);
            this.Controls.Add(this.lblCiudadEntrega);
            this.Controls.Add(this.txtCodigoPostalEntrega);
            this.Controls.Add(this.lblCodigoPostalEntrega);
            this.Controls.Add(this.txtPisoEntrega);
            this.Controls.Add(this.lblPisoEntrega);
            this.Controls.Add(this.txtAlturaEntrega);
            this.Controls.Add(this.lblAlturaEntrega);
            this.Controls.Add(this.txtCalleEntrega);
            this.Controls.Add(this.lblCalleEntrega);
            this.Controls.Add(this.cboAgencia);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.cboTipoBulto);
            this.Controls.Add(this.lblTipoBulto);
            this.Controls.Add(this.cboTipoEntrega);
            this.Controls.Add(this.lblTipoEntrega);
            this.Controls.Add(this.cboCdDestino);
            this.Controls.Add(this.lblCdDestino);
            this.Controls.Add(this.cboCdOrigen);
            this.Controls.Add(this.lblCdOrigen);
            this.Controls.Add(this.txtTelefonoDestinatario);
            this.Controls.Add(this.lblTelefonoDestinatario);
            this.Controls.Add(this.txtDniDestinatario);
            this.Controls.Add(this.lblDniDestinatario);
            this.Controls.Add(this.txtApellidoDestinatario);
            this.Controls.Add(this.lblApellidoDestinatario);
            this.Controls.Add(this.txtNombreDestinatario);
            this.Controls.Add(this.lblNombreDestinatario);
            this.Controls.Add(this.txtCiudadRemitente);
            this.Controls.Add(this.lblCiudadRemitente);
            this.Controls.Add(this.txtCodigoPostalRemitente);
            this.Controls.Add(this.lblCodigoPostalRemitente);
            this.Controls.Add(this.txtPisoRemitente);
            this.Controls.Add(this.lblPisoRemitente);
            this.Controls.Add(this.txtAlturaRemitente);
            this.Controls.Add(this.lblAlturaRemitente);
            this.Controls.Add(this.txtCalleRemitente);
            this.Controls.Add(this.lblCalleRemitente);
            this.Controls.Add(this.txtTelefonoRemitente);
            this.Controls.Add(this.lblTelefonoRemitente);
            this.Controls.Add(this.txtDniRemitente);
            this.Controls.Add(this.lblDniRemitente);
            this.Controls.Add(this.txtApellidoRemitente);
            this.Controls.Add(this.lblApellidoRemitente);
            this.Controls.Add(this.txtNombreRemitente);
            this.Controls.Add(this.lblNombreRemitente);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.cboRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "Form2";
            this.Text = "Imposicion en Callcenter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.ComboBox cboRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblNombreRemitente;
        private System.Windows.Forms.TextBox txtNombreRemitente;
        private System.Windows.Forms.Label lblApellidoRemitente;
        private System.Windows.Forms.TextBox txtApellidoRemitente;
        private System.Windows.Forms.Label lblDniRemitente;
        private System.Windows.Forms.TextBox txtDniRemitente;
        private System.Windows.Forms.Label lblTelefonoRemitente;
        private System.Windows.Forms.TextBox txtTelefonoRemitente;
        private System.Windows.Forms.Label lblCalleRemitente;
        private System.Windows.Forms.TextBox txtCalleRemitente;
        private System.Windows.Forms.Label lblAlturaRemitente;
        private System.Windows.Forms.TextBox txtAlturaRemitente;
        private System.Windows.Forms.Label lblPisoRemitente;
        private System.Windows.Forms.TextBox txtPisoRemitente;
        private System.Windows.Forms.Label lblCodigoPostalRemitente;
        private System.Windows.Forms.TextBox txtCodigoPostalRemitente;
        private System.Windows.Forms.Label lblCiudadRemitente;
        private System.Windows.Forms.TextBox txtCiudadRemitente;
        private System.Windows.Forms.Label lblNombreDestinatario;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.Label lblApellidoDestinatario;
        private System.Windows.Forms.TextBox txtApellidoDestinatario;
        private System.Windows.Forms.Label lblDniDestinatario;
        private System.Windows.Forms.TextBox txtDniDestinatario;
        private System.Windows.Forms.Label lblTelefonoDestinatario;
        private System.Windows.Forms.TextBox txtTelefonoDestinatario;
        private System.Windows.Forms.Label lblCdOrigen;
        private System.Windows.Forms.ComboBox cboCdOrigen;
        private System.Windows.Forms.Label lblCdDestino;
        private System.Windows.Forms.ComboBox cboCdDestino;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.ComboBox cboTipoEntrega;
        private System.Windows.Forms.Label lblTipoBulto;
        private System.Windows.Forms.ComboBox cboTipoBulto;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.ComboBox cboAgencia;
        private System.Windows.Forms.Label lblCalleEntrega;
        private System.Windows.Forms.TextBox txtCalleEntrega;
        private System.Windows.Forms.Label lblAlturaEntrega;
        private System.Windows.Forms.TextBox txtAlturaEntrega;
        private System.Windows.Forms.Label lblPisoEntrega;
        private System.Windows.Forms.TextBox txtPisoEntrega;
        private System.Windows.Forms.Label lblCodigoPostalEntrega;
        private System.Windows.Forms.TextBox txtCodigoPostalEntrega;
        private System.Windows.Forms.Label lblCiudadEntrega;
        private System.Windows.Forms.TextBox txtCiudadEntrega;
        private System.Windows.Forms.Button btnGenerarGuia;
        private System.Windows.Forms.TextBox txtGuia;
    }
}
