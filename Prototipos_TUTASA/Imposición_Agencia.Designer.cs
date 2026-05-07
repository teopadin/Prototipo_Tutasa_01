namespace Prototipos_TUTASA
{
    partial class Imposicion_Agencia
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
            pnlSep1 = new Panel();
            lblSecTipo = new Label();
            pnlSepTipo = new Panel();
            lblTipoCliente = new Label();
            cboTipoCliente = new ComboBox();
            lblSecRem = new Label();
            pnlSepRem = new Panel();
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
            lblSecDest = new Label();
            pnlSepDest = new Panel();
            lblNombreDest = new Label();
            txtNombreDest = new TextBox();
            lblApellidoDest = new Label();
            txtApellidoDest = new TextBox();
            lblDNIDest = new Label();
            txtDNIDest = new TextBox();
            lblTelDest = new Label();
            txtTelDest = new TextBox();
            lblSecEnvio = new Label();
            pnlSepEnvio = new Panel();
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
            lblFecha.Location = new Point(870, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(948, 28);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(134, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "06/05/2026";
            // 
            // pnlSep1
            // 
            pnlSep1.BackColor = Color.FromArgb(220, 220, 220);
            pnlSep1.Location = new Point(30, 63);
            pnlSep1.Name = "pnlSep1";
            pnlSep1.Size = new Size(1010, 1);
            pnlSep1.TabIndex = 3;
            // 
            // lblSecTipo
            // 
            lblSecTipo.Font = new Font("Segoe UI", 10F);
            lblSecTipo.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecTipo.Location = new Point(30, 67);
            lblSecTipo.Name = "lblSecTipo";
            lblSecTipo.Size = new Size(300, 35);
            lblSecTipo.TabIndex = 4;
            lblSecTipo.Text = "1. Tipo de remitente";
            // 
            // pnlSepTipo
            // 
            pnlSepTipo.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepTipo.Location = new Point(30, 105);
            pnlSepTipo.Name = "pnlSepTipo";
            pnlSepTipo.Size = new Size(1010, 1);
            pnlSepTipo.TabIndex = 5;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoCliente.Location = new Point(30, 105);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(150, 30);
            lblTipoCliente.TabIndex = 6;
            lblTipoCliente.Text = "Tipo cliente *";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.Items.AddRange(new object[] { "Empresa / Agencia", "Particular" });
            cboTipoCliente.Location = new Point(30, 137);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(200, 33);
            cboTipoCliente.TabIndex = 7;
            // 
            // lblSecRem
            // 
            lblSecRem.Font = new Font("Segoe UI", 10F);
            lblSecRem.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecRem.Location = new Point(30, 173);
            lblSecRem.Name = "lblSecRem";
            lblSecRem.Size = new Size(300, 29);
            lblSecRem.TabIndex = 8;
            lblSecRem.Text = "2. Datos del remitente";
            // 
            // pnlSepRem
            // 
            pnlSepRem.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepRem.Location = new Point(30, 205);
            pnlSepRem.Name = "pnlSepRem";
            pnlSepRem.Size = new Size(1010, 1);
            pnlSepRem.TabIndex = 9;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.ForeColor = Color.FromArgb(60, 60, 60);
            lblRazonSocial.Location = new Point(30, 205);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(150, 30);
            lblRazonSocial.TabIndex = 10;
            lblRazonSocial.Text = "Razón social *";
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.Items.AddRange(new object[] { "Acme SA", "Distribuidora Norte SRL", "Logística del Sur SA" });
            cboRazonSocial.Location = new Point(30, 237);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(180, 33);
            cboRazonSocial.TabIndex = 11;
            // 
            // lblCUIT
            // 
            lblCUIT.ForeColor = Color.FromArgb(60, 60, 60);
            lblCUIT.Location = new Point(230, 205);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(100, 30);
            lblCUIT.TabIndex = 12;
            lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(230, 237);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(140, 31);
            txtCUIT.TabIndex = 13;
            // 
            // lblNombreRem
            // 
            lblNombreRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreRem.Location = new Point(390, 205);
            lblNombreRem.Name = "lblNombreRem";
            lblNombreRem.Size = new Size(120, 30);
            lblNombreRem.TabIndex = 14;
            lblNombreRem.Text = "Nombre *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(390, 237);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(140, 31);
            txtNombreRem.TabIndex = 15;
            // 
            // lblApellidoRem
            // 
            lblApellidoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoRem.Location = new Point(550, 205);
            lblApellidoRem.Name = "lblApellidoRem";
            lblApellidoRem.Size = new Size(120, 30);
            lblApellidoRem.TabIndex = 16;
            lblApellidoRem.Text = "Apellido *";
            // 
            // txtApellidoRem
            // 
            txtApellidoRem.Location = new Point(550, 237);
            txtApellidoRem.Name = "txtApellidoRem";
            txtApellidoRem.Size = new Size(140, 31);
            txtApellidoRem.TabIndex = 17;
            // 
            // lblDNIRem
            // 
            lblDNIRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIRem.Location = new Point(710, 205);
            lblDNIRem.Name = "lblDNIRem";
            lblDNIRem.Size = new Size(80, 30);
            lblDNIRem.TabIndex = 18;
            lblDNIRem.Text = "DNI *";
            // 
            // txtDNIRem
            // 
            txtDNIRem.Location = new Point(710, 237);
            txtDNIRem.Name = "txtDNIRem";
            txtDNIRem.Size = new Size(120, 31);
            txtDNIRem.TabIndex = 19;
            // 
            // lblTelRem
            // 
            lblTelRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelRem.Location = new Point(850, 205);
            lblTelRem.Name = "lblTelRem";
            lblTelRem.Size = new Size(100, 30);
            lblTelRem.TabIndex = 20;
            lblTelRem.Text = "Teléfono *";
            // 
            // txtTelRem
            // 
            txtTelRem.Location = new Point(850, 237);
            txtTelRem.Name = "txtTelRem";
            txtTelRem.Size = new Size(170, 31);
            txtTelRem.TabIndex = 21;
            // 
            // lblSecDest
            // 
            lblSecDest.Font = new Font("Segoe UI", 10F);
            lblSecDest.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecDest.Location = new Point(30, 273);
            lblSecDest.Name = "lblSecDest";
            lblSecDest.Size = new Size(300, 34);
            lblSecDest.TabIndex = 22;
            lblSecDest.Text = "3. Datos del destinatario";
            // 
            // pnlSepDest
            // 
            pnlSepDest.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepDest.Location = new Point(30, 306);
            pnlSepDest.Name = "pnlSepDest";
            pnlSepDest.Size = new Size(1010, 10);
            pnlSepDest.TabIndex = 23;
            // 
            // lblNombreDest
            // 
            lblNombreDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreDest.Location = new Point(30, 319);
            lblNombreDest.Name = "lblNombreDest";
            lblNombreDest.Size = new Size(120, 21);
            lblNombreDest.TabIndex = 24;
            lblNombreDest.Text = "Nombre *";
            // 
            // txtNombreDest
            // 
            txtNombreDest.Location = new Point(30, 342);
            txtNombreDest.Name = "txtNombreDest";
            txtNombreDest.Size = new Size(220, 31);
            txtNombreDest.TabIndex = 25;
            // 
            // lblApellidoDest
            // 
            lblApellidoDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoDest.Location = new Point(270, 319);
            lblApellidoDest.Name = "lblApellidoDest";
            lblApellidoDest.Size = new Size(120, 21);
            lblApellidoDest.TabIndex = 26;
            lblApellidoDest.Text = "Apellido *";
            // 
            // txtApellidoDest
            // 
            txtApellidoDest.Location = new Point(270, 342);
            txtApellidoDest.Name = "txtApellidoDest";
            txtApellidoDest.Size = new Size(220, 31);
            txtApellidoDest.TabIndex = 27;
            // 
            // lblDNIDest
            // 
            lblDNIDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIDest.Location = new Point(510, 319);
            lblDNIDest.Name = "lblDNIDest";
            lblDNIDest.Size = new Size(80, 21);
            lblDNIDest.TabIndex = 28;
            lblDNIDest.Text = "DNI *";
            // 
            // txtDNIDest
            // 
            txtDNIDest.Location = new Point(510, 342);
            txtDNIDest.Name = "txtDNIDest";
            txtDNIDest.Size = new Size(160, 31);
            txtDNIDest.TabIndex = 29;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(690, 319);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(100, 21);
            lblTelDest.TabIndex = 30;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(690, 342);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(180, 31);
            txtTelDest.TabIndex = 31;
            // 
            // lblSecEnvio
            // 
            lblSecEnvio.Font = new Font("Segoe UI", 10F);
            lblSecEnvio.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecEnvio.Location = new Point(30, 390);
            lblSecEnvio.Name = "lblSecEnvio";
            lblSecEnvio.Size = new Size(300, 22);
            lblSecEnvio.TabIndex = 32;
            lblSecEnvio.Text = "4. Datos del envío";
            // 
            // pnlSepEnvio
            // 
            pnlSepEnvio.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepEnvio.Location = new Point(30, 415);
            pnlSepEnvio.Name = "pnlSepEnvio";
            pnlSepEnvio.Size = new Size(1010, 1);
            pnlSepEnvio.TabIndex = 33;
            // 
            // lblAgenciaOrigen
            // 
            lblAgenciaOrigen.ForeColor = Color.FromArgb(60, 60, 60);
            lblAgenciaOrigen.Location = new Point(30, 419);
            lblAgenciaOrigen.Name = "lblAgenciaOrigen";
            lblAgenciaOrigen.Size = new Size(160, 26);
            lblAgenciaOrigen.TabIndex = 34;
            lblAgenciaOrigen.Text = "Agencia origen";
            // 
            // txtAgenciaOrigen
            // 
            txtAgenciaOrigen.BackColor = Color.FromArgb(245, 245, 245);
            txtAgenciaOrigen.Location = new Point(30, 447);
            txtAgenciaOrigen.Name = "txtAgenciaOrigen";
            txtAgenciaOrigen.ReadOnly = true;
            txtAgenciaOrigen.Size = new Size(180, 31);
            txtAgenciaOrigen.TabIndex = 35;
            txtAgenciaOrigen.Text = "Agencia Flores (FIJO)";
            // 
            // lblCDOrigen
            // 
            lblCDOrigen.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDOrigen.Location = new Point(230, 419);
            lblCDOrigen.Name = "lblCDOrigen";
            lblCDOrigen.Size = new Size(120, 26);
            lblCDOrigen.TabIndex = 36;
            lblCDOrigen.Text = "CD origen";
            // 
            // txtCDOrigen
            // 
            txtCDOrigen.BackColor = Color.FromArgb(245, 245, 245);
            txtCDOrigen.Location = new Point(230, 447);
            txtCDOrigen.Name = "txtCDOrigen";
            txtCDOrigen.ReadOnly = true;
            txtCDOrigen.Size = new Size(140, 31);
            txtCDOrigen.TabIndex = 37;
            txtCDOrigen.Text = "CABA (FIJO)";
            // 
            // lblCDDestino
            // 
            lblCDDestino.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDDestino.Location = new Point(390, 419);
            lblCDDestino.Name = "lblCDDestino";
            lblCDDestino.Size = new Size(120, 26);
            lblCDDestino.TabIndex = 38;
            lblCDDestino.Text = "CD destino *";
            // 
            // cboCDDestino
            // 
            cboCDDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCDDestino.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });
            cboCDDestino.Location = new Point(390, 447);
            cboCDDestino.Name = "cboCDDestino";
            cboCDDestino.Size = new Size(140, 33);
            cboCDDestino.TabIndex = 39;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoEntrega.Location = new Point(550, 419);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(150, 26);
            lblTipoEntrega.TabIndex = 40;
            lblTipoEntrega.Text = "Tipo de entrega *";
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEntrega.Items.AddRange(new object[] { "Retiro en CD", "Retiro en Agencia", "Puerta a Puerta" });
            cboTipoEntrega.Location = new Point(550, 447);
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(180, 33);
            cboTipoEntrega.TabIndex = 41;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoBulto.Location = new Point(750, 419);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(120, 26);
            lblTipoBulto.TabIndex = 42;
            lblTipoBulto.Text = "Tipo de bulto *";
            // 
            // cboTipoBulto
            // 
            cboTipoBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoBulto.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            cboTipoBulto.Location = new Point(750, 447);
            cboTipoBulto.Name = "cboTipoBulto";
            cboTipoBulto.Size = new Size(100, 33);
            cboTipoBulto.TabIndex = 43;
            // 
            // lblCantBultos
            // 
            lblCantBultos.ForeColor = Color.FromArgb(60, 60, 60);
            lblCantBultos.Location = new Point(870, 419);
            lblCantBultos.Name = "lblCantBultos";
            lblCantBultos.Size = new Size(120, 26);
            lblCantBultos.TabIndex = 44;
            lblCantBultos.Text = "Cant. bultos *";
            // 
            // txtCantBultos
            // 
            txtCantBultos.Location = new Point(870, 447);
            txtCantBultos.Name = "txtCantBultos";
            txtCantBultos.Size = new Size(80, 31);
            txtCantBultos.TabIndex = 45;
            // 
            // lblContenido
            // 
            lblContenido.ForeColor = Color.FromArgb(60, 60, 60);
            lblContenido.Location = new Point(30, 481);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(180, 27);
            lblContenido.TabIndex = 46;
            lblContenido.Text = "Contenido declarado *";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(30, 510);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(340, 31);
            txtContenido.TabIndex = 47;
            // 
            // lblValor
            // 
            lblValor.ForeColor = Color.FromArgb(60, 60, 60);
            lblValor.Location = new Point(390, 481);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(150, 27);
            lblValor.TabIndex = 48;
            lblValor.Text = "Valor declarado *";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(390, 510);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(160, 31);
            txtValor.TabIndex = 49;
            // 
            // lblAgenciaDestino
            // 
            lblAgenciaDestino.ForeColor = Color.FromArgb(60, 60, 60);
            lblAgenciaDestino.Location = new Point(570, 481);
            lblAgenciaDestino.Name = "lblAgenciaDestino";
            lblAgenciaDestino.Size = new Size(450, 27);
            lblAgenciaDestino.TabIndex = 50;
            lblAgenciaDestino.Text = "Agencia destino  (si tipo entrega = Retiro en Agencia)";
            // 
            // cboAgenciaDestino
            // 
            cboAgenciaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgenciaDestino.Items.AddRange(new object[] { "Agencia Centro Rosario", "Agencia Norte Córdoba", "Agencia Sur Mendoza" });
            cboAgenciaDestino.Location = new Point(570, 510);
            cboAgenciaDestino.Name = "cboAgenciaDestino";
            cboAgenciaDestino.Size = new Size(280, 33);
            cboAgenciaDestino.TabIndex = 51;
            // 
            // lblCalleEnt
            // 
            lblCalleEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCalleEnt.Location = new Point(30, 546);
            lblCalleEnt.Name = "lblCalleEnt";
            lblCalleEnt.Size = new Size(220, 27);
            lblCalleEnt.TabIndex = 52;
            lblCalleEnt.Text = "Calle  (si Puerta a Puerta) *";
            // 
            // txtCalleEnt
            // 
            txtCalleEnt.Location = new Point(30, 575);
            txtCalleEnt.Name = "txtCalleEnt";
            txtCalleEnt.Size = new Size(280, 31);
            txtCalleEnt.TabIndex = 53;
            // 
            // lblAlturaEnt
            // 
            lblAlturaEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblAlturaEnt.Location = new Point(330, 546);
            lblAlturaEnt.Name = "lblAlturaEnt";
            lblAlturaEnt.Size = new Size(80, 27);
            lblAlturaEnt.TabIndex = 54;
            lblAlturaEnt.Text = "Altura *";
            // 
            // txtAlturaEnt
            // 
            txtAlturaEnt.Location = new Point(330, 575);
            txtAlturaEnt.Name = "txtAlturaEnt";
            txtAlturaEnt.Size = new Size(90, 31);
            txtAlturaEnt.TabIndex = 55;
            // 
            // lblPisoEnt
            // 
            lblPisoEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblPisoEnt.Location = new Point(440, 546);
            lblPisoEnt.Name = "lblPisoEnt";
            lblPisoEnt.Size = new Size(100, 27);
            lblPisoEnt.TabIndex = 56;
            lblPisoEnt.Text = "Piso / Depto";
            // 
            // txtPisoEnt
            // 
            txtPisoEnt.Location = new Point(440, 575);
            txtPisoEnt.Name = "txtPisoEnt";
            txtPisoEnt.Size = new Size(120, 31);
            txtPisoEnt.TabIndex = 57;
            // 
            // lblCPEnt
            // 
            lblCPEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCPEnt.Location = new Point(580, 546);
            lblCPEnt.Name = "lblCPEnt";
            lblCPEnt.Size = new Size(120, 27);
            lblCPEnt.TabIndex = 58;
            lblCPEnt.Text = "Código postal *";
            // 
            // txtCPEnt
            // 
            txtCPEnt.Location = new Point(580, 575);
            txtCPEnt.Name = "txtCPEnt";
            txtCPEnt.Size = new Size(110, 31);
            txtCPEnt.TabIndex = 59;
            // 
            // lblCiudadEnt
            // 
            lblCiudadEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCiudadEnt.Location = new Point(710, 546);
            lblCiudadEnt.Name = "lblCiudadEnt";
            lblCiudadEnt.Size = new Size(120, 27);
            lblCiudadEnt.TabIndex = 60;
            lblCiudadEnt.Text = "Ciudad *";
            // 
            // txtCiudadEnt
            // 
            txtCiudadEnt.Location = new Point(710, 575);
            txtCiudadEnt.Name = "txtCiudadEnt";
            txtCiudadEnt.Size = new Size(180, 31);
            txtCiudadEnt.TabIndex = 61;
            // 
            // btnGenerar
            // 
            btnGenerar.FlatStyle = FlatStyle.System;
            btnGenerar.Location = new Point(900, 575);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(140, 35);
            btnGenerar.TabIndex = 62;
            btnGenerar.Text = "Generar guía";
            // 
            // lblGuiaGen
            // 
            lblGuiaGen.ForeColor = Color.FromArgb(60, 60, 60);
            lblGuiaGen.Location = new Point(30, 630);
            lblGuiaGen.Name = "lblGuiaGen";
            lblGuiaGen.Size = new Size(150, 34);
            lblGuiaGen.TabIndex = 63;
            lblGuiaGen.Text = "Guía generada";
            // 
            // txtGuiaGen
            // 
            txtGuiaGen.BackColor = Color.FromArgb(248, 248, 248);
            txtGuiaGen.Location = new Point(30, 679);
            txtGuiaGen.Multiline = true;
            txtGuiaGen.Name = "txtGuiaGen";
            txtGuiaGen.ReadOnly = true;
            txtGuiaGen.Size = new Size(840, 60);
            txtGuiaGen.TabIndex = 64;
            // 
            // Imposicion_Agencia
            // 
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1241, 946);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(pnlSep1);
            Controls.Add(lblSecTipo);
            Controls.Add(pnlSepTipo);
            Controls.Add(lblTipoCliente);
            Controls.Add(cboTipoCliente);
            Controls.Add(lblSecRem);
            Controls.Add(pnlSepRem);
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
            Controls.Add(lblSecDest);
            Controls.Add(pnlSepDest);
            Controls.Add(lblNombreDest);
            Controls.Add(txtNombreDest);
            Controls.Add(lblApellidoDest);
            Controls.Add(txtApellidoDest);
            Controls.Add(lblDNIDest);
            Controls.Add(txtDNIDest);
            Controls.Add(lblTelDest);
            Controls.Add(txtTelDest);
            Controls.Add(lblSecEnvio);
            Controls.Add(pnlSepEnvio);
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
            Name = "Imposicion_Agencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición en Agencia";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo, lblPaso, lblFecha, lblFechaValor;
        private System.Windows.Forms.Panel pnlSep1, pnlSepTipo, pnlSepRem, pnlSepDest, pnlSepEnvio;
        private System.Windows.Forms.Label lblSecTipo, lblSecRem, lblSecDest, lblSecEnvio;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label lblRazonSocial, lblCUIT, lblNombreRem, lblApellidoRem, lblDNIRem, lblTelRem;
        private System.Windows.Forms.ComboBox cboRazonSocial;
        private System.Windows.Forms.TextBox txtCUIT, txtNombreRem, txtApellidoRem, txtDNIRem, txtTelRem;
        private System.Windows.Forms.Label lblNombreDest, lblApellidoDest, lblDNIDest, lblTelDest;
        private System.Windows.Forms.TextBox txtNombreDest, txtApellidoDest, txtDNIDest, txtTelDest;
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