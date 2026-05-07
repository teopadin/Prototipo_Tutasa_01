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
            lblFecha = new Label();
            txtFecha = new TextBox();
            lblTipoCliente = new Label();
            cboTipoCliente = new ComboBox();
            lblRazonSocial = new Label();
            cboRazonSocial = new ComboBox();
            lblCuit = new Label();
            txtCuit = new TextBox();
            lblNombreRemitente = new Label();
            txtNombreRemitente = new TextBox();
            lblApellidoRemitente = new Label();
            txtApellidoRemitente = new TextBox();
            lblDniRemitente = new Label();
            txtDniRemitente = new TextBox();
            lblTelefonoRemitente = new Label();
            txtTelefonoRemitente = new TextBox();
            lblCalleRemitente = new Label();
            txtCalleRemitente = new TextBox();
            lblAlturaRemitente = new Label();
            txtAlturaRemitente = new TextBox();
            lblPisoRemitente = new Label();
            txtPisoRemitente = new TextBox();
            lblCodigoPostalRemitente = new Label();
            txtCodigoPostalRemitente = new TextBox();
            lblCiudadRemitente = new Label();
            txtCiudadRemitente = new TextBox();
            lblNombreDestinatario = new Label();
            txtNombreDestinatario = new TextBox();
            lblApellidoDestinatario = new Label();
            txtApellidoDestinatario = new TextBox();
            lblDniDestinatario = new Label();
            txtDniDestinatario = new TextBox();
            lblTelefonoDestinatario = new Label();
            txtTelefonoDestinatario = new TextBox();
            lblCdOrigen = new Label();
            cboCdOrigen = new ComboBox();
            lblCdDestino = new Label();
            cboCdDestino = new ComboBox();
            lblTipoEntrega = new Label();
            cboTipoEntrega = new ComboBox();
            lblTipoBulto = new Label();
            cboTipoBulto = new ComboBox();
            lblAgencia = new Label();
            cboAgencia = new ComboBox();
            lblCalleEntrega = new Label();
            txtCalleEntrega = new TextBox();
            lblAlturaEntrega = new Label();
            txtAlturaEntrega = new TextBox();
            lblPisoEntrega = new Label();
            txtPisoEntrega = new TextBox();
            lblCodigoPostalEntrega = new Label();
            txtCodigoPostalEntrega = new TextBox();
            lblCiudadEntrega = new Label();
            txtCiudadEntrega = new TextBox();
            btnGenerarGuia = new Button();
            txtGuia = new TextBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 41);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(100, 12);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(120, 47);
            txtFecha.TabIndex = 1;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(12, 55);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(172, 41);
            lblTipoCliente.TabIndex = 2;
            lblTipoCliente.Text = "Tipo cliente";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(100, 52);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(180, 49);
            cboTipoCliente.TabIndex = 3;
            cboTipoCliente.SelectedIndexChanged += cboTipoCliente_SelectedIndexChanged;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(12, 95);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(182, 41);
            lblRazonSocial.TabIndex = 4;
            lblRazonSocial.Text = "Razon social";
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRazonSocial.FormattingEnabled = true;
            cboRazonSocial.Location = new Point(100, 92);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(180, 49);
            cboRazonSocial.TabIndex = 5;
            cboRazonSocial.SelectedIndexChanged += cboRazonSocial_SelectedIndexChanged;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(300, 95);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(82, 41);
            lblCuit.TabIndex = 6;
            lblCuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(345, 92);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(150, 47);
            txtCuit.TabIndex = 7;
            // 
            // lblNombreRemitente
            // 
            lblNombreRemitente.AutoSize = true;
            lblNombreRemitente.Location = new Point(12, 135);
            lblNombreRemitente.Name = "lblNombreRemitente";
            lblNombreRemitente.Size = new Size(128, 41);
            lblNombreRemitente.TabIndex = 8;
            lblNombreRemitente.Text = "Nombre";
            // 
            // txtNombreRemitente
            // 
            txtNombreRemitente.Location = new Point(100, 132);
            txtNombreRemitente.Name = "txtNombreRemitente";
            txtNombreRemitente.Size = new Size(180, 47);
            txtNombreRemitente.TabIndex = 9;
            // 
            // lblApellidoRemitente
            // 
            lblApellidoRemitente.AutoSize = true;
            lblApellidoRemitente.Location = new Point(300, 135);
            lblApellidoRemitente.Name = "lblApellidoRemitente";
            lblApellidoRemitente.Size = new Size(128, 41);
            lblApellidoRemitente.TabIndex = 10;
            lblApellidoRemitente.Text = "Apellido";
            // 
            // txtApellidoRemitente
            // 
            txtApellidoRemitente.Location = new Point(372, 132);
            txtApellidoRemitente.Name = "txtApellidoRemitente";
            txtApellidoRemitente.Size = new Size(180, 47);
            txtApellidoRemitente.TabIndex = 11;
            // 
            // lblDniRemitente
            // 
            lblDniRemitente.AutoSize = true;
            lblDniRemitente.Location = new Point(570, 135);
            lblDniRemitente.Name = "lblDniRemitente";
            lblDniRemitente.Size = new Size(69, 41);
            lblDniRemitente.TabIndex = 12;
            lblDniRemitente.Text = "DNI";
            // 
            // txtDniRemitente
            // 
            txtDniRemitente.Location = new Point(611, 132);
            txtDniRemitente.Name = "txtDniRemitente";
            txtDniRemitente.Size = new Size(120, 47);
            txtDniRemitente.TabIndex = 13;
            // 
            // lblTelefonoRemitente
            // 
            lblTelefonoRemitente.AutoSize = true;
            lblTelefonoRemitente.Location = new Point(12, 175);
            lblTelefonoRemitente.Name = "lblTelefonoRemitente";
            lblTelefonoRemitente.Size = new Size(132, 41);
            lblTelefonoRemitente.TabIndex = 14;
            lblTelefonoRemitente.Text = "Telefono";
            // 
            // txtTelefonoRemitente
            // 
            txtTelefonoRemitente.Location = new Point(100, 172);
            txtTelefonoRemitente.Name = "txtTelefonoRemitente";
            txtTelefonoRemitente.Size = new Size(180, 47);
            txtTelefonoRemitente.TabIndex = 15;
            // 
            // lblCalleRemitente
            // 
            lblCalleRemitente.AutoSize = true;
            lblCalleRemitente.Location = new Point(300, 175);
            lblCalleRemitente.Name = "lblCalleRemitente";
            lblCalleRemitente.Size = new Size(82, 41);
            lblCalleRemitente.TabIndex = 16;
            lblCalleRemitente.Text = "Calle";
            // 
            // txtCalleRemitente
            // 
            txtCalleRemitente.Location = new Point(372, 172);
            txtCalleRemitente.Name = "txtCalleRemitente";
            txtCalleRemitente.Size = new Size(180, 47);
            txtCalleRemitente.TabIndex = 17;
            // 
            // lblAlturaRemitente
            // 
            lblAlturaRemitente.AutoSize = true;
            lblAlturaRemitente.Location = new Point(570, 175);
            lblAlturaRemitente.Name = "lblAlturaRemitente";
            lblAlturaRemitente.Size = new Size(96, 41);
            lblAlturaRemitente.TabIndex = 18;
            lblAlturaRemitente.Text = "Altura";
            // 
            // txtAlturaRemitente
            // 
            txtAlturaRemitente.Location = new Point(625, 172);
            txtAlturaRemitente.Name = "txtAlturaRemitente";
            txtAlturaRemitente.Size = new Size(106, 47);
            txtAlturaRemitente.TabIndex = 19;
            // 
            // lblPisoRemitente
            // 
            lblPisoRemitente.AutoSize = true;
            lblPisoRemitente.Location = new Point(12, 215);
            lblPisoRemitente.Name = "lblPisoRemitente";
            lblPisoRemitente.Size = new Size(73, 41);
            lblPisoRemitente.TabIndex = 20;
            lblPisoRemitente.Text = "Piso";
            // 
            // txtPisoRemitente
            // 
            txtPisoRemitente.Location = new Point(100, 212);
            txtPisoRemitente.Name = "txtPisoRemitente";
            txtPisoRemitente.Size = new Size(180, 47);
            txtPisoRemitente.TabIndex = 21;
            // 
            // lblCodigoPostalRemitente
            // 
            lblCodigoPostalRemitente.AutoSize = true;
            lblCodigoPostalRemitente.Location = new Point(300, 215);
            lblCodigoPostalRemitente.Name = "lblCodigoPostalRemitente";
            lblCodigoPostalRemitente.Size = new Size(205, 41);
            lblCodigoPostalRemitente.TabIndex = 22;
            lblCodigoPostalRemitente.Text = "Codigo postal";
            // 
            // txtCodigoPostalRemitente
            // 
            txtCodigoPostalRemitente.Location = new Point(402, 212);
            txtCodigoPostalRemitente.Name = "txtCodigoPostalRemitente";
            txtCodigoPostalRemitente.Size = new Size(150, 47);
            txtCodigoPostalRemitente.TabIndex = 23;
            // 
            // lblCiudadRemitente
            // 
            lblCiudadRemitente.AutoSize = true;
            lblCiudadRemitente.Location = new Point(570, 215);
            lblCiudadRemitente.Name = "lblCiudadRemitente";
            lblCiudadRemitente.Size = new Size(112, 41);
            lblCiudadRemitente.TabIndex = 24;
            lblCiudadRemitente.Text = "Ciudad";
            // 
            // txtCiudadRemitente
            // 
            txtCiudadRemitente.Location = new Point(631, 212);
            txtCiudadRemitente.Name = "txtCiudadRemitente";
            txtCiudadRemitente.Size = new Size(180, 47);
            txtCiudadRemitente.TabIndex = 25;
            // 
            // lblNombreDestinatario
            // 
            lblNombreDestinatario.AutoSize = true;
            lblNombreDestinatario.Location = new Point(12, 270);
            lblNombreDestinatario.Name = "lblNombreDestinatario";
            lblNombreDestinatario.Size = new Size(156, 41);
            lblNombreDestinatario.TabIndex = 26;
            lblNombreDestinatario.Text = "Nom desti";
            // 
            // txtNombreDestinatario
            // 
            txtNombreDestinatario.Location = new Point(100, 267);
            txtNombreDestinatario.Name = "txtNombreDestinatario";
            txtNombreDestinatario.Size = new Size(180, 47);
            txtNombreDestinatario.TabIndex = 27;
            // 
            // lblApellidoDestinatario
            // 
            lblApellidoDestinatario.AutoSize = true;
            lblApellidoDestinatario.Location = new Point(300, 270);
            lblApellidoDestinatario.Name = "lblApellidoDestinatario";
            lblApellidoDestinatario.Size = new Size(143, 41);
            lblApellidoDestinatario.TabIndex = 28;
            lblApellidoDestinatario.Text = "Ape desti";
            // 
            // txtApellidoDestinatario
            // 
            txtApellidoDestinatario.Location = new Point(390, 267);
            txtApellidoDestinatario.Name = "txtApellidoDestinatario";
            txtApellidoDestinatario.Size = new Size(162, 47);
            txtApellidoDestinatario.TabIndex = 29;
            // 
            // lblDniDestinatario
            // 
            lblDniDestinatario.AutoSize = true;
            lblDniDestinatario.Location = new Point(570, 270);
            lblDniDestinatario.Name = "lblDniDestinatario";
            lblDniDestinatario.Size = new Size(141, 41);
            lblDniDestinatario.TabIndex = 30;
            lblDniDestinatario.Text = "DNI desti";
            // 
            // txtDniDestinatario
            // 
            txtDniDestinatario.Location = new Point(639, 267);
            txtDniDestinatario.Name = "txtDniDestinatario";
            txtDniDestinatario.Size = new Size(92, 47);
            txtDniDestinatario.TabIndex = 31;
            // 
            // lblTelefonoDestinatario
            // 
            lblTelefonoDestinatario.AutoSize = true;
            lblTelefonoDestinatario.Location = new Point(750, 270);
            lblTelefonoDestinatario.Name = "lblTelefonoDestinatario";
            lblTelefonoDestinatario.Size = new Size(126, 41);
            lblTelefonoDestinatario.TabIndex = 32;
            lblTelefonoDestinatario.Text = "Tel desti";
            // 
            // txtTelefonoDestinatario
            // 
            txtTelefonoDestinatario.Location = new Point(849, 267);
            txtTelefonoDestinatario.Name = "txtTelefonoDestinatario";
            txtTelefonoDestinatario.Size = new Size(150, 47);
            txtTelefonoDestinatario.TabIndex = 33;
            // 
            // lblCdOrigen
            // 
            lblCdOrigen.AutoSize = true;
            lblCdOrigen.Location = new Point(12, 320);
            lblCdOrigen.Name = "lblCdOrigen";
            lblCdOrigen.Size = new Size(152, 41);
            lblCdOrigen.TabIndex = 34;
            lblCdOrigen.Text = "CD origen";
            // 
            // cboCdOrigen
            // 
            cboCdOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCdOrigen.FormattingEnabled = true;
            cboCdOrigen.Location = new Point(100, 317);
            cboCdOrigen.Name = "cboCdOrigen";
            cboCdOrigen.Size = new Size(121, 49);
            cboCdOrigen.TabIndex = 35;
            // 
            // lblCdDestino
            // 
            lblCdDestino.AutoSize = true;
            lblCdDestino.Location = new Point(240, 320);
            lblCdDestino.Name = "lblCdDestino";
            lblCdDestino.Size = new Size(165, 41);
            lblCdDestino.TabIndex = 36;
            lblCdDestino.Text = "CD destino";
            // 
            // cboCdDestino
            // 
            cboCdDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCdDestino.FormattingEnabled = true;
            cboCdDestino.Location = new Point(318, 317);
            cboCdDestino.Name = "cboCdDestino";
            cboCdDestino.Size = new Size(121, 49);
            cboCdDestino.TabIndex = 37;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.AutoSize = true;
            lblTipoEntrega.Location = new Point(458, 320);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(187, 41);
            lblTipoEntrega.TabIndex = 38;
            lblTipoEntrega.Text = "Tipo entrega";
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEntrega.FormattingEnabled = true;
            cboTipoEntrega.Location = new Point(550, 317);
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(181, 49);
            cboTipoEntrega.TabIndex = 39;
            cboTipoEntrega.SelectedIndexChanged += cboTipoEntrega_SelectedIndexChanged;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.AutoSize = true;
            lblTipoBulto.Location = new Point(750, 320);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(155, 41);
            lblTipoBulto.TabIndex = 40;
            lblTipoBulto.Text = "Tipo bulto";
            // 
            // cboTipoBulto
            // 
            cboTipoBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoBulto.FormattingEnabled = true;
            cboTipoBulto.Location = new Point(832, 317);
            cboTipoBulto.Name = "cboTipoBulto";
            cboTipoBulto.Size = new Size(121, 49);
            cboTipoBulto.TabIndex = 41;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(12, 365);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(124, 41);
            lblAgencia.TabIndex = 42;
            lblAgencia.Text = "Agencia";
            // 
            // cboAgencia
            // 
            cboAgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgencia.FormattingEnabled = true;
            cboAgencia.Location = new Point(100, 362);
            cboAgencia.Name = "cboAgencia";
            cboAgencia.Size = new Size(180, 49);
            cboAgencia.TabIndex = 43;
            // 
            // lblCalleEntrega
            // 
            lblCalleEntrega.AutoSize = true;
            lblCalleEntrega.Location = new Point(12, 410);
            lblCalleEntrega.Name = "lblCalleEntrega";
            lblCalleEntrega.Size = new Size(192, 41);
            lblCalleEntrega.TabIndex = 44;
            lblCalleEntrega.Text = "Calle entrega";
            // 
            // txtCalleEntrega
            // 
            txtCalleEntrega.Location = new Point(100, 407);
            txtCalleEntrega.Name = "txtCalleEntrega";
            txtCalleEntrega.Size = new Size(180, 47);
            txtCalleEntrega.TabIndex = 45;
            // 
            // lblAlturaEntrega
            // 
            lblAlturaEntrega.AutoSize = true;
            lblAlturaEntrega.Location = new Point(300, 410);
            lblAlturaEntrega.Name = "lblAlturaEntrega";
            lblAlturaEntrega.Size = new Size(206, 41);
            lblAlturaEntrega.TabIndex = 46;
            lblAlturaEntrega.Text = "Altura entrega";
            // 
            // txtAlturaEntrega
            // 
            txtAlturaEntrega.Location = new Point(395, 407);
            txtAlturaEntrega.Name = "txtAlturaEntrega";
            txtAlturaEntrega.Size = new Size(157, 47);
            txtAlturaEntrega.TabIndex = 47;
            // 
            // lblPisoEntrega
            // 
            lblPisoEntrega.AutoSize = true;
            lblPisoEntrega.Location = new Point(570, 410);
            lblPisoEntrega.Name = "lblPisoEntrega";
            lblPisoEntrega.Size = new Size(183, 41);
            lblPisoEntrega.TabIndex = 48;
            lblPisoEntrega.Text = "Piso entrega";
            // 
            // txtPisoEntrega
            // 
            txtPisoEntrega.Location = new Point(654, 407);
            txtPisoEntrega.Name = "txtPisoEntrega";
            txtPisoEntrega.Size = new Size(157, 47);
            txtPisoEntrega.TabIndex = 49;
            // 
            // lblCodigoPostalEntrega
            // 
            lblCodigoPostalEntrega.AutoSize = true;
            lblCodigoPostalEntrega.Location = new Point(12, 450);
            lblCodigoPostalEntrega.Name = "lblCodigoPostalEntrega";
            lblCodigoPostalEntrega.Size = new Size(164, 41);
            lblCodigoPostalEntrega.TabIndex = 50;
            lblCodigoPostalEntrega.Text = "CP entrega";
            // 
            // txtCodigoPostalEntrega
            // 
            txtCodigoPostalEntrega.Location = new Point(100, 447);
            txtCodigoPostalEntrega.Name = "txtCodigoPostalEntrega";
            txtCodigoPostalEntrega.Size = new Size(180, 47);
            txtCodigoPostalEntrega.TabIndex = 51;
            // 
            // lblCiudadEntrega
            // 
            lblCiudadEntrega.AutoSize = true;
            lblCiudadEntrega.Location = new Point(300, 450);
            lblCiudadEntrega.Name = "lblCiudadEntrega";
            lblCiudadEntrega.Size = new Size(222, 41);
            lblCiudadEntrega.TabIndex = 52;
            lblCiudadEntrega.Text = "Ciudad entrega";
            // 
            // txtCiudadEntrega
            // 
            txtCiudadEntrega.Location = new Point(398, 447);
            txtCiudadEntrega.Name = "txtCiudadEntrega";
            txtCiudadEntrega.Size = new Size(154, 47);
            txtCiudadEntrega.TabIndex = 53;
            // 
            // btnGenerarGuia
            // 
            btnGenerarGuia.Location = new Point(12, 495);
            btnGenerarGuia.Name = "btnGenerarGuia";
            btnGenerarGuia.Size = new Size(150, 32);
            btnGenerarGuia.TabIndex = 54;
            btnGenerarGuia.Text = "Generar guia";
            btnGenerarGuia.UseVisualStyleBackColor = true;
            btnGenerarGuia.Click += btnGenerarGuia_Click;
            // 
            // txtGuia
            // 
            txtGuia.Location = new Point(12, 573);
            txtGuia.Multiline = true;
            txtGuia.Name = "txtGuia";
            txtGuia.ReadOnly = true;
            txtGuia.ScrollBars = ScrollBars.Vertical;
            txtGuia.Size = new Size(987, 170);
            txtGuia.TabIndex = 55;
            // 
            // Form2
            // 
            ClientSize = new Size(1014, 728);
            Controls.Add(txtGuia);
            Controls.Add(btnGenerarGuia);
            Controls.Add(txtCiudadEntrega);
            Controls.Add(lblCiudadEntrega);
            Controls.Add(txtCodigoPostalEntrega);
            Controls.Add(lblCodigoPostalEntrega);
            Controls.Add(txtPisoEntrega);
            Controls.Add(lblPisoEntrega);
            Controls.Add(txtAlturaEntrega);
            Controls.Add(lblAlturaEntrega);
            Controls.Add(txtCalleEntrega);
            Controls.Add(lblCalleEntrega);
            Controls.Add(cboAgencia);
            Controls.Add(lblAgencia);
            Controls.Add(cboTipoBulto);
            Controls.Add(lblTipoBulto);
            Controls.Add(cboTipoEntrega);
            Controls.Add(lblTipoEntrega);
            Controls.Add(cboCdDestino);
            Controls.Add(lblCdDestino);
            Controls.Add(cboCdOrigen);
            Controls.Add(lblCdOrigen);
            Controls.Add(txtTelefonoDestinatario);
            Controls.Add(lblTelefonoDestinatario);
            Controls.Add(txtDniDestinatario);
            Controls.Add(lblDniDestinatario);
            Controls.Add(txtApellidoDestinatario);
            Controls.Add(lblApellidoDestinatario);
            Controls.Add(txtNombreDestinatario);
            Controls.Add(lblNombreDestinatario);
            Controls.Add(txtCiudadRemitente);
            Controls.Add(lblCiudadRemitente);
            Controls.Add(txtCodigoPostalRemitente);
            Controls.Add(lblCodigoPostalRemitente);
            Controls.Add(txtPisoRemitente);
            Controls.Add(lblPisoRemitente);
            Controls.Add(txtAlturaRemitente);
            Controls.Add(lblAlturaRemitente);
            Controls.Add(txtCalleRemitente);
            Controls.Add(lblCalleRemitente);
            Controls.Add(txtTelefonoRemitente);
            Controls.Add(lblTelefonoRemitente);
            Controls.Add(txtDniRemitente);
            Controls.Add(lblDniRemitente);
            Controls.Add(txtApellidoRemitente);
            Controls.Add(lblApellidoRemitente);
            Controls.Add(txtNombreRemitente);
            Controls.Add(lblNombreRemitente);
            Controls.Add(txtCuit);
            Controls.Add(lblCuit);
            Controls.Add(cboRazonSocial);
            Controls.Add(lblRazonSocial);
            Controls.Add(cboTipoCliente);
            Controls.Add(lblTipoCliente);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Name = "Form2";
            Text = "Imposicion en Callcenter";
            ResumeLayout(false);
            PerformLayout();
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
