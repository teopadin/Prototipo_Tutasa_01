namespace Prototipos_TUTASA
{
    partial class ImposicionAgencia_Pantalla2
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblPaso = new Label();
            lblFecha = new Label();
            lblFechaValor = new Label();
            this.pnlSep1 = new Panel();
            this.lblSecRem = new Label();
            this.pnlSepRem = new Panel();
            lblRazonSocial = new Label();
            cboRazonSocial = new ComboBox();
            lblCUIT = new Label();
            txtCUIT = new TextBox();
            lblNombreRem = new Label();
            txtNombreRem = new TextBox();
            lblApellidoRem = new Label();
            txtApellidoRem = new TextBox();
            lblDNIRem = new Label();
            txtDNIRem = new TextBox();
            lblTelRem = new Label();
            txtTelRem = new TextBox();
            this.lblSecDest = new Label();
            this.pnlSepDest = new Panel();
            lblNombreDest = new Label();
            txtNombreDest = new TextBox();
            lblApellidoDest = new Label();
            txtApellidoDest = new TextBox();
            lblDNIDest = new Label();
            txtDNIDest = new TextBox();
            lblTelDest = new Label();
            txtTelDest = new TextBox();
            this.lblSecEnvio = new Label();
            this.pnlSepEnvio = new Panel();
            lblAgenciaOrigen = new Label();
            txtAgenciaOrigen = new TextBox();
            lblCDOrigen = new Label();
            txtCDOrigen = new TextBox();
            lblCDDestino = new Label();
            cboCDDestino = new ComboBox();
            lblTipoEntrega = new Label();
            cboTipoEntrega = new ComboBox();
            lblTipoBulto = new Label();
            cboTipoBulto = new ComboBox();
            lblCantBultos = new Label();
            txtCantBultos = new TextBox();
            lblContenido = new Label();
            txtContenido = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblAgenciaDestino = new Label();
            cboAgenciaDestino = new ComboBox();
            lblCalleEnt = new Label();
            txtCalleEnt = new TextBox();
            lblAlturaEnt = new Label();
            txtAlturaEnt = new TextBox();
            lblPisoEnt = new Label();
            txtPisoEnt = new TextBox();
            lblCPEnt = new Label();
            txtCPEnt = new TextBox();
            lblCiudadEnt = new Label();
            txtCiudadEnt = new TextBox();
            btnGenerar = new Button();
            lblGuiaGen = new Label();
            txtGuiaGen = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(30, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Imposición en Agencia";
            // 
            // lblPaso
            // 
            lblPaso.Location = new Point(0, 0);
            lblPaso.Name = "lblPaso";
            lblPaso.Size = new Size(100, 23);
            lblPaso.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(900, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(948, 28);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(90, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "06/05/2026";
            // 
            // pnlSep1
            // 
            this.pnlSep1.BackColor = Color.FromArgb(220, 220, 220);
            this.pnlSep1.Location = new Point(30, 63);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new Size(1010, 1);
            this.pnlSep1.TabIndex = 3;
            // 
            // lblSecRem
            // 
            this.lblSecRem.Font = new Font("Segoe UI", 10F);
            this.lblSecRem.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblSecRem.Location = new Point(34, 77);
            this.lblSecRem.Name = "lblSecRem";
            this.lblSecRem.Size = new Size(300, 31);
            this.lblSecRem.TabIndex = 8;
            this.lblSecRem.Text = "1. Datos del remitente";
            // 
            // pnlSepRem
            // 
            this.pnlSepRem.BackColor = Color.FromArgb(220, 220, 220);
            this.pnlSepRem.Location = new Point(30, 111);
            this.pnlSepRem.Name = "pnlSepRem";
            this.pnlSepRem.Size = new Size(1010, 1);
            this.pnlSepRem.TabIndex = 9;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.ForeColor = Color.FromArgb(60, 60, 60);
            lblRazonSocial.Location = new Point(30, 123);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(150, 28);
            lblRazonSocial.TabIndex = 10;
            lblRazonSocial.Text = "Razón social *";
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.Items.AddRange(new object[] { "Acme SA", "Distribuidora Norte SRL", "Logística del Sur SA" });
            cboRazonSocial.Location = new Point(30, 154);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(180, 33);
            cboRazonSocial.TabIndex = 11;
            // 
            // lblCUIT
            // 
            lblCUIT.ForeColor = Color.FromArgb(60, 60, 60);
            lblCUIT.Location = new Point(230, 123);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(100, 28);
            lblCUIT.TabIndex = 12;
            lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(230, 154);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(140, 31);
            txtCUIT.TabIndex = 13;
            // 
            // lblNombreRem
            // 
            lblNombreRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreRem.Location = new Point(390, 123);
            lblNombreRem.Name = "lblNombreRem";
            lblNombreRem.Size = new Size(120, 28);
            lblNombreRem.TabIndex = 14;
            lblNombreRem.Text = "Nombre *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(390, 154);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(140, 31);
            txtNombreRem.TabIndex = 15;
            // 
            // lblApellidoRem
            // 
            lblApellidoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoRem.Location = new Point(550, 123);
            lblApellidoRem.Name = "lblApellidoRem";
            lblApellidoRem.Size = new Size(120, 28);
            lblApellidoRem.TabIndex = 16;
            lblApellidoRem.Text = "Apellido *";
            // 
            // txtApellidoRem
            // 
            txtApellidoRem.Location = new Point(550, 154);
            txtApellidoRem.Name = "txtApellidoRem";
            txtApellidoRem.Size = new Size(140, 31);
            txtApellidoRem.TabIndex = 17;
            // 
            // lblDNIRem
            // 
            lblDNIRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIRem.Location = new Point(710, 123);
            lblDNIRem.Name = "lblDNIRem";
            lblDNIRem.Size = new Size(80, 28);
            lblDNIRem.TabIndex = 18;
            lblDNIRem.Text = "DNI *";
            // 
            // txtDNIRem
            // 
            txtDNIRem.Location = new Point(710, 154);
            txtDNIRem.Name = "txtDNIRem";
            txtDNIRem.Size = new Size(120, 31);
            txtDNIRem.TabIndex = 19;
            // 
            // lblTelRem
            // 
            lblTelRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelRem.Location = new Point(850, 123);
            lblTelRem.Name = "lblTelRem";
            lblTelRem.Size = new Size(100, 28);
            lblTelRem.TabIndex = 20;
            lblTelRem.Text = "Teléfono *";
            // 
            // txtTelRem
            // 
            txtTelRem.Location = new Point(850, 154);
            txtTelRem.Name = "txtTelRem";
            txtTelRem.Size = new Size(170, 31);
            txtTelRem.TabIndex = 21;
            // 
            // lblSecDest
            // 
            this.lblSecDest.Font = new Font("Segoe UI", 10F);
            this.lblSecDest.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblSecDest.Location = new Point(30, 191);
            this.lblSecDest.Name = "lblSecDest";
            this.lblSecDest.Size = new Size(300, 34);
            this.lblSecDest.TabIndex = 22;
            this.lblSecDest.Text = "2. Datos del destinatario";
            // 
            // pnlSepDest
            // 
            this.pnlSepDest.BackColor = Color.FromArgb(220, 220, 220);
            this.pnlSepDest.Location = new Point(30, 224);
            this.pnlSepDest.Name = "pnlSepDest";
            this.pnlSepDest.Size = new Size(1010, 1);
            this.pnlSepDest.TabIndex = 23;
            // 
            // lblNombreDest
            // 
            lblNombreDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreDest.Location = new Point(30, 228);
            lblNombreDest.Name = "lblNombreDest";
            lblNombreDest.Size = new Size(120, 36);
            lblNombreDest.TabIndex = 24;
            lblNombreDest.Text = "Nombre *";
            // 
            // txtNombreDest
            // 
            txtNombreDest.Location = new Point(30, 267);
            txtNombreDest.Name = "txtNombreDest";
            txtNombreDest.Size = new Size(220, 31);
            txtNombreDest.TabIndex = 25;
            // 
            // lblApellidoDest
            // 
            lblApellidoDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoDest.Location = new Point(270, 228);
            lblApellidoDest.Name = "lblApellidoDest";
            lblApellidoDest.Size = new Size(120, 36);
            lblApellidoDest.TabIndex = 26;
            lblApellidoDest.Text = "Apellido *";
            // 
            // txtApellidoDest
            // 
            txtApellidoDest.Location = new Point(270, 267);
            txtApellidoDest.Name = "txtApellidoDest";
            txtApellidoDest.Size = new Size(220, 31);
            txtApellidoDest.TabIndex = 27;
            // 
            // lblDNIDest
            // 
            lblDNIDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIDest.Location = new Point(510, 228);
            lblDNIDest.Name = "lblDNIDest";
            lblDNIDest.Size = new Size(80, 36);
            lblDNIDest.TabIndex = 28;
            lblDNIDest.Text = "DNI *";
            // 
            // txtDNIDest
            // 
            txtDNIDest.Location = new Point(510, 267);
            txtDNIDest.Name = "txtDNIDest";
            txtDNIDest.Size = new Size(160, 31);
            txtDNIDest.TabIndex = 29;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(690, 228);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(100, 36);
            lblTelDest.TabIndex = 30;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(690, 267);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(180, 31);
            txtTelDest.TabIndex = 31;
            // 
            // lblSecEnvio
            // 
            this.lblSecEnvio.Font = new Font("Segoe UI", 10F);
            this.lblSecEnvio.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblSecEnvio.Location = new Point(30, 301);
            this.lblSecEnvio.Name = "lblSecEnvio";
            this.lblSecEnvio.Size = new Size(300, 35);
            this.lblSecEnvio.TabIndex = 32;
            this.lblSecEnvio.Text = "3. Datos del envío";
            // 
            // pnlSepEnvio
            // 
            this.pnlSepEnvio.BackColor = Color.FromArgb(220, 220, 220);
            this.pnlSepEnvio.Location = new Point(30, 339);
            this.pnlSepEnvio.Name = "pnlSepEnvio";
            this.pnlSepEnvio.Size = new Size(1010, 1);
            this.pnlSepEnvio.TabIndex = 33;
            // 
            // lblAgenciaOrigen
            // 
            lblAgenciaOrigen.ForeColor = Color.FromArgb(60, 60, 60);
            lblAgenciaOrigen.Location = new Point(34, 343);
            lblAgenciaOrigen.Name = "lblAgenciaOrigen";
            lblAgenciaOrigen.Size = new Size(160, 36);
            lblAgenciaOrigen.TabIndex = 34;
            lblAgenciaOrigen.Text = "Agencia origen";
            // 
            // txtAgenciaOrigen
            // 
            txtAgenciaOrigen.BackColor = Color.FromArgb(245, 245, 245);
            txtAgenciaOrigen.Location = new Point(34, 382);
            txtAgenciaOrigen.Name = "txtAgenciaOrigen";
            txtAgenciaOrigen.ReadOnly = true;
            txtAgenciaOrigen.Size = new Size(180, 31);
            txtAgenciaOrigen.TabIndex = 35;
            txtAgenciaOrigen.Text = "Agencia Flores (FIJO)";
            // 
            // lblCDOrigen
            // 
            lblCDOrigen.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDOrigen.Location = new Point(234, 343);
            lblCDOrigen.Name = "lblCDOrigen";
            lblCDOrigen.Size = new Size(120, 36);
            lblCDOrigen.TabIndex = 36;
            lblCDOrigen.Text = "CD origen";
            // 
            // txtCDOrigen
            // 
            txtCDOrigen.BackColor = Color.FromArgb(245, 245, 245);
            txtCDOrigen.Location = new Point(234, 382);
            txtCDOrigen.Name = "txtCDOrigen";
            txtCDOrigen.ReadOnly = true;
            txtCDOrigen.Size = new Size(140, 31);
            txtCDOrigen.TabIndex = 37;
            txtCDOrigen.Text = "CABA (FIJO)";
            // 
            // lblCDDestino
            // 
            lblCDDestino.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDDestino.Location = new Point(394, 343);
            lblCDDestino.Name = "lblCDDestino";
            lblCDDestino.Size = new Size(120, 36);
            lblCDDestino.TabIndex = 38;
            lblCDDestino.Text = "CD destino *";
            // 
            // cboCDDestino
            // 
            cboCDDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCDDestino.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });
            cboCDDestino.Location = new Point(394, 382);
            cboCDDestino.Name = "cboCDDestino";
            cboCDDestino.Size = new Size(140, 33);
            cboCDDestino.TabIndex = 39;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoEntrega.Location = new Point(554, 343);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(150, 36);
            lblTipoEntrega.TabIndex = 40;
            lblTipoEntrega.Text = "Tipo de entrega *";
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEntrega.Items.AddRange(new object[] { "Retiro en CD", "Retiro en Agencia", "Puerta a Puerta" });
            cboTipoEntrega.Location = new Point(554, 382);
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(180, 33);
            cboTipoEntrega.TabIndex = 41;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoBulto.Location = new Point(754, 343);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(120, 36);
            lblTipoBulto.TabIndex = 42;
            lblTipoBulto.Text = "Tipo de bulto *";
            // 
            // cboTipoBulto
            // 
            cboTipoBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoBulto.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            cboTipoBulto.Location = new Point(754, 382);
            cboTipoBulto.Name = "cboTipoBulto";
            cboTipoBulto.Size = new Size(100, 33);
            cboTipoBulto.TabIndex = 43;
            // 
            // lblCantBultos
            // 
            lblCantBultos.ForeColor = Color.FromArgb(60, 60, 60);
            lblCantBultos.Location = new Point(874, 343);
            lblCantBultos.Name = "lblCantBultos";
            lblCantBultos.Size = new Size(120, 36);
            lblCantBultos.TabIndex = 44;
            lblCantBultos.Text = "Cant. bultos *";
            // 
            // txtCantBultos
            // 
            txtCantBultos.Location = new Point(874, 382);
            txtCantBultos.Name = "txtCantBultos";
            txtCantBultos.Size = new Size(80, 31);
            txtCantBultos.TabIndex = 45;
            // 
            // lblContenido
            // 
            lblContenido.ForeColor = Color.FromArgb(60, 60, 60);
            lblContenido.Location = new Point(30, 416);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(180, 26);
            lblContenido.TabIndex = 46;
            lblContenido.Text = "Contenido declarado *";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(30, 445);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(340, 31);
            txtContenido.TabIndex = 47;
            // 
            // lblValor
            // 
            lblValor.ForeColor = Color.FromArgb(60, 60, 60);
            lblValor.Location = new Point(390, 416);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(150, 26);
            lblValor.TabIndex = 48;
            lblValor.Text = "Valor declarado *";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(390, 445);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(160, 31);
            txtValor.TabIndex = 49;
            // 
            // lblAgenciaDestino
            // 
            lblAgenciaDestino.ForeColor = Color.FromArgb(60, 60, 60);
            lblAgenciaDestino.Location = new Point(570, 416);
            lblAgenciaDestino.Name = "lblAgenciaDestino";
            lblAgenciaDestino.Size = new Size(330, 26);
            lblAgenciaDestino.TabIndex = 50;
            lblAgenciaDestino.Text = "Agencia destino  (si tipo entrega = Retiro en Agencia)";
            // 
            // cboAgenciaDestino
            // 
            cboAgenciaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgenciaDestino.Items.AddRange(new object[] { "Agencia Centro Rosario", "Agencia Norte Córdoba", "Agencia Sur Mendoza" });
            cboAgenciaDestino.Location = new Point(570, 445);
            cboAgenciaDestino.Name = "cboAgenciaDestino";
            cboAgenciaDestino.Size = new Size(280, 33);
            cboAgenciaDestino.TabIndex = 51;
            // 
            // lblCalleEnt
            // 
            lblCalleEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCalleEnt.Location = new Point(30, 481);
            lblCalleEnt.Name = "lblCalleEnt";
            lblCalleEnt.Size = new Size(220, 30);
            lblCalleEnt.TabIndex = 52;
            lblCalleEnt.Text = "Calle  (si Puerta a Puerta) *";
            // 
            // txtCalleEnt
            // 
            txtCalleEnt.Location = new Point(34, 514);
            txtCalleEnt.Name = "txtCalleEnt";
            txtCalleEnt.Size = new Size(280, 31);
            txtCalleEnt.TabIndex = 53;
            // 
            // lblAlturaEnt
            // 
            lblAlturaEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblAlturaEnt.Location = new Point(330, 481);
            lblAlturaEnt.Name = "lblAlturaEnt";
            lblAlturaEnt.Size = new Size(80, 30);
            lblAlturaEnt.TabIndex = 54;
            lblAlturaEnt.Text = "Altura *";
            // 
            // txtAlturaEnt
            // 
            txtAlturaEnt.Location = new Point(334, 514);
            txtAlturaEnt.Name = "txtAlturaEnt";
            txtAlturaEnt.Size = new Size(90, 31);
            txtAlturaEnt.TabIndex = 55;
            // 
            // lblPisoEnt
            // 
            lblPisoEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblPisoEnt.Location = new Point(440, 481);
            lblPisoEnt.Name = "lblPisoEnt";
            lblPisoEnt.Size = new Size(100, 30);
            lblPisoEnt.TabIndex = 56;
            lblPisoEnt.Text = "Piso / Depto";
            // 
            // txtPisoEnt
            // 
            txtPisoEnt.Location = new Point(444, 514);
            txtPisoEnt.Name = "txtPisoEnt";
            txtPisoEnt.Size = new Size(120, 31);
            txtPisoEnt.TabIndex = 57;
            // 
            // lblCPEnt
            // 
            lblCPEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCPEnt.Location = new Point(580, 481);
            lblCPEnt.Name = "lblCPEnt";
            lblCPEnt.Size = new Size(120, 30);
            lblCPEnt.TabIndex = 58;
            lblCPEnt.Text = "Código postal *";
            // 
            // txtCPEnt
            // 
            txtCPEnt.Location = new Point(584, 514);
            txtCPEnt.Name = "txtCPEnt";
            txtCPEnt.Size = new Size(110, 31);
            txtCPEnt.TabIndex = 59;
            // 
            // lblCiudadEnt
            // 
            lblCiudadEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCiudadEnt.Location = new Point(710, 481);
            lblCiudadEnt.Name = "lblCiudadEnt";
            lblCiudadEnt.Size = new Size(120, 30);
            lblCiudadEnt.TabIndex = 60;
            lblCiudadEnt.Text = "Ciudad *";
            // 
            // txtCiudadEnt
            // 
            txtCiudadEnt.Location = new Point(714, 514);
            txtCiudadEnt.Name = "txtCiudadEnt";
            txtCiudadEnt.Size = new Size(180, 31);
            txtCiudadEnt.TabIndex = 61;
            // 
            // btnGenerar
            // 
            btnGenerar.FlatStyle = FlatStyle.System;
            btnGenerar.Location = new Point(900, 501);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(166, 57);
            btnGenerar.TabIndex = 62;
            btnGenerar.Text = "Generar guía";
            // 
            // lblGuiaGen
            // 
            lblGuiaGen.ForeColor = Color.FromArgb(60, 60, 60);
            lblGuiaGen.Location = new Point(34, 566);
            lblGuiaGen.Name = "lblGuiaGen";
            lblGuiaGen.Size = new Size(150, 29);
            lblGuiaGen.TabIndex = 63;
            lblGuiaGen.Text = "Guía generada";
            // 
            // txtGuiaGen
            // 
            txtGuiaGen.BackColor = Color.FromArgb(248, 248, 248);
            txtGuiaGen.Location = new Point(34, 607);
            txtGuiaGen.Multiline = true;
            txtGuiaGen.Name = "txtGuiaGen";
            txtGuiaGen.ReadOnly = true;
            txtGuiaGen.Size = new Size(915, 213);
            txtGuiaGen.TabIndex = 64;
            // 
            // ImposicionAgencia_Pantalla2
            // 
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1247, 896);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(this.pnlSep1);
            Controls.Add(this.lblSecRem);
            Controls.Add(this.pnlSepRem);
            Controls.Add(lblRazonSocial);
            Controls.Add(cboRazonSocial);
            Controls.Add(lblCUIT);
            Controls.Add(txtCUIT);
            Controls.Add(lblNombreRem);
            Controls.Add(txtNombreRem);
            Controls.Add(lblApellidoRem);
            Controls.Add(txtApellidoRem);
            Controls.Add(lblDNIRem);
            Controls.Add(txtDNIRem);
            Controls.Add(lblTelRem);
            Controls.Add(txtTelRem);
            Controls.Add(this.lblSecDest);
            Controls.Add(this.pnlSepDest);
            Controls.Add(lblNombreDest);
            Controls.Add(txtNombreDest);
            Controls.Add(lblApellidoDest);
            Controls.Add(txtApellidoDest);
            Controls.Add(lblDNIDest);
            Controls.Add(txtDNIDest);
            Controls.Add(lblTelDest);
            Controls.Add(txtTelDest);
            Controls.Add(this.lblSecEnvio);
            Controls.Add(this.pnlSepEnvio);
            Controls.Add(lblAgenciaOrigen);
            Controls.Add(txtAgenciaOrigen);
            Controls.Add(lblCDOrigen);
            Controls.Add(txtCDOrigen);
            Controls.Add(lblCDDestino);
            Controls.Add(cboCDDestino);
            Controls.Add(lblTipoEntrega);
            Controls.Add(cboTipoEntrega);
            Controls.Add(lblTipoBulto);
            Controls.Add(cboTipoBulto);
            Controls.Add(lblCantBultos);
            Controls.Add(txtCantBultos);
            Controls.Add(lblContenido);
            Controls.Add(txtContenido);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblAgenciaDestino);
            Controls.Add(cboAgenciaDestino);
            Controls.Add(lblCalleEnt);
            Controls.Add(txtCalleEnt);
            Controls.Add(lblAlturaEnt);
            Controls.Add(txtAlturaEnt);
            Controls.Add(lblPisoEnt);
            Controls.Add(txtPisoEnt);
            Controls.Add(lblCPEnt);
            Controls.Add(txtCPEnt);
            Controls.Add(lblCiudadEnt);
            Controls.Add(txtCiudadEnt);
            Controls.Add(btnGenerar);
            Controls.Add(lblGuiaGen);
            Controls.Add(txtGuiaGen);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposicionAgencia_Pantalla2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición en Agencia";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo, lblPaso, lblFecha, lblFechaValor;
        private System.Windows.Forms.Label lblRazonSocial, lblCUIT, lblNombreRem, lblApellidoRem, lblDNIRem, lblTelRem;
        private System.Windows.Forms.ComboBox cboRazonSocial;
        private System.Windows.Forms.TextBox txtCUIT, txtNombreRem, txtApellidoRem, txtDNIRem, txtTelRem;
        private System.Windows.Forms.Label lblNombreDest, lblApellidoDest, lblDNIDest, lblTelDest;
        private System.Windows.Forms.TextBox txtNombreDest, txtApellidoDest, txtDNIDest, txtTelDest;
        private System.Windows.Forms.Label lblSecRem, lblSecDest, lblSecEnvio;
        private System.Windows.Forms.Panel pnlSep1, pnlSepRem, pnlSepDest, pnlSepEnvio;
        private System.Windows.Forms.Label lblAgenciaOrigen, lblCDOrigen, lblCDDestino, lblTipoEntrega, lblTipoBulto, lblCantBultos;
        private System.Windows.Forms.TextBox txtAgenciaOrigen, txtCDOrigen, txtCantBultos;
        private System.Windows.Forms.ComboBox cboCDDestino, cboTipoEntrega, cboTipoBulto;
        private System.Windows.Forms.Label lblContenido, lblValor, lblAgenciaDestino;
        private System.Windows.Forms.TextBox txtContenido, txtValor;
        private System.Windows.Forms.ComboBox cboAgenciaDestino;
        private System.Windows.Forms.Label lblCalleEnt, lblAlturaEnt, lblPisoEnt, lblCPEnt, lblCiudadEnt;
        private System.Windows.Forms.TextBox txtCalleEnt, txtAlturaEnt, txtPisoEnt, txtCPEnt, txtCiudadEnt;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblGuiaGen;
        private System.Windows.Forms.TextBox txtGuiaGen;
    }
}