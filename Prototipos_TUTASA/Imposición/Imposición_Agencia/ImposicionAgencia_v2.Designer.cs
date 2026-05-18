namespace Prototipos_TUTASA.ImposiciónAgencia_v2
{
    partial class ImposicionAgencia_v2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            txtCiudadRemitente = new TextBox();
            lblCiudadRemitente = new Label();
            txtCodigoPostalRemitente = new TextBox();
            lblCodigoPostalRemitente = new Label();
            txtPisoRemitente = new TextBox();
            lblPisoRemitente = new Label();
            txtAlturaRemitente = new TextBox();
            lblAlturaRemitente = new Label();
            txtCalleRemitente = new TextBox();
            lblCalleRemitente = new Label();
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
            groupBox2 = new GroupBox();
            lblNombreDest = new Label();
            txtNombreDest = new TextBox();
            lblApellidoDest = new Label();
            txtApellidoDest = new TextBox();
            lblDNIDest = new Label();
            txtDNIDest = new TextBox();
            lblTelDest = new Label();
            txtTelDest = new TextBox();
            groupBox3 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            gbTamañoBulto = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox4 = new GroupBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            groupBox6 = new GroupBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            groupBox7 = new GroupBox();
            label8 = new Label();
            comboBox3 = new ComboBox();
            btnGenerarGuia = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            gbTamañoBulto.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(850, 75);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Imposición en Agencia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCiudadRemitente);
            groupBox1.Controls.Add(lblCiudadRemitente);
            groupBox1.Controls.Add(txtCodigoPostalRemitente);
            groupBox1.Controls.Add(lblCodigoPostalRemitente);
            groupBox1.Controls.Add(txtPisoRemitente);
            groupBox1.Controls.Add(lblPisoRemitente);
            groupBox1.Controls.Add(txtAlturaRemitente);
            groupBox1.Controls.Add(lblAlturaRemitente);
            groupBox1.Controls.Add(txtCalleRemitente);
            groupBox1.Controls.Add(lblCalleRemitente);
            groupBox1.Controls.Add(lblRazonSocial);
            groupBox1.Controls.Add(cboRazonSocial);
            groupBox1.Controls.Add(lblCUIT);
            groupBox1.Controls.Add(txtCUIT);
            groupBox1.Controls.Add(lblNombreRem);
            groupBox1.Controls.Add(txtNombreRem);
            groupBox1.Controls.Add(lblApellidoRem);
            groupBox1.Controls.Add(txtApellidoRem);
            groupBox1.Controls.Add(lblDNIRem);
            groupBox1.Controls.Add(txtDNIRem);
            groupBox1.Controls.Add(lblTelRem);
            groupBox1.Controls.Add(txtTelRem);
            groupBox1.Location = new Point(20, 95);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2060, 290);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Remitente";
            // 
            // txtCiudadRemitente
            // 
            txtCiudadRemitente.Location = new Point(1387, 205);
            txtCiudadRemitente.Margin = new Padding(7);
            txtCiudadRemitente.MaxLength = 40;
            txtCiudadRemitente.Name = "txtCiudadRemitente";
            txtCiudadRemitente.Size = new Size(658, 47);
            txtCiudadRemitente.TabIndex = 38;
            // 
            // lblCiudadRemitente
            // 
            lblCiudadRemitente.AutoSize = true;
            lblCiudadRemitente.Location = new Point(1382, 157);
            lblCiudadRemitente.Margin = new Padding(7, 0, 7, 0);
            lblCiudadRemitente.Name = "lblCiudadRemitente";
            lblCiudadRemitente.Size = new Size(133, 41);
            lblCiudadRemitente.TabIndex = 43;
            lblCiudadRemitente.Text = "Ciudad *";
            // 
            // txtCodigoPostalRemitente
            // 
            txtCodigoPostalRemitente.Location = new Point(1110, 205);
            txtCodigoPostalRemitente.Margin = new Padding(7);
            txtCodigoPostalRemitente.MaxLength = 10;
            txtCodigoPostalRemitente.Name = "txtCodigoPostalRemitente";
            txtCodigoPostalRemitente.Size = new Size(237, 47);
            txtCodigoPostalRemitente.TabIndex = 37;
            // 
            // lblCodigoPostalRemitente
            // 
            lblCodigoPostalRemitente.AutoSize = true;
            lblCodigoPostalRemitente.Location = new Point(1110, 157);
            lblCodigoPostalRemitente.Margin = new Padding(7, 0, 7, 0);
            lblCodigoPostalRemitente.Name = "lblCodigoPostalRemitente";
            lblCodigoPostalRemitente.Size = new Size(226, 41);
            lblCodigoPostalRemitente.TabIndex = 42;
            lblCodigoPostalRemitente.Text = "Codigo postal *";
            // 
            // txtPisoRemitente
            // 
            txtPisoRemitente.Location = new Point(972, 205);
            txtPisoRemitente.Margin = new Padding(7);
            txtPisoRemitente.MaxLength = 10;
            txtPisoRemitente.Name = "txtPisoRemitente";
            txtPisoRemitente.Size = new Size(114, 47);
            txtPisoRemitente.TabIndex = 36;
            // 
            // lblPisoRemitente
            // 
            lblPisoRemitente.AutoSize = true;
            lblPisoRemitente.Location = new Point(972, 157);
            lblPisoRemitente.Margin = new Padding(7, 0, 7, 0);
            lblPisoRemitente.Name = "lblPisoRemitente";
            lblPisoRemitente.Size = new Size(73, 41);
            lblPisoRemitente.TabIndex = 41;
            lblPisoRemitente.Text = "Piso";
            // 
            // txtAlturaRemitente
            // 
            txtAlturaRemitente.Location = new Point(780, 205);
            txtAlturaRemitente.Margin = new Padding(7);
            txtAlturaRemitente.Name = "txtAlturaRemitente";
            txtAlturaRemitente.Size = new Size(172, 47);
            txtAlturaRemitente.TabIndex = 35;
            // 
            // lblAlturaRemitente
            // 
            lblAlturaRemitente.AutoSize = true;
            lblAlturaRemitente.Location = new Point(780, 157);
            lblAlturaRemitente.Margin = new Padding(7, 0, 7, 0);
            lblAlturaRemitente.Name = "lblAlturaRemitente";
            lblAlturaRemitente.Size = new Size(117, 41);
            lblAlturaRemitente.TabIndex = 40;
            lblAlturaRemitente.Text = "Altura *";
            // 
            // txtCalleRemitente
            // 
            txtCalleRemitente.Location = new Point(19, 205);
            txtCalleRemitente.Margin = new Padding(7);
            txtCalleRemitente.MaxLength = 50;
            txtCalleRemitente.Name = "txtCalleRemitente";
            txtCalleRemitente.Size = new Size(745, 47);
            txtCalleRemitente.TabIndex = 34;
            // 
            // lblCalleRemitente
            // 
            lblCalleRemitente.AutoSize = true;
            lblCalleRemitente.Location = new Point(19, 157);
            lblCalleRemitente.Margin = new Padding(7, 0, 7, 0);
            lblCalleRemitente.Name = "lblCalleRemitente";
            lblCalleRemitente.Size = new Size(103, 41);
            lblCalleRemitente.TabIndex = 39;
            lblCalleRemitente.Text = "Calle *";
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.ForeColor = Color.FromArgb(60, 60, 60);
            lblRazonSocial.Location = new Point(14, 36);
            lblRazonSocial.Margin = new Padding(5, 0, 5, 0);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(255, 46);
            lblRazonSocial.TabIndex = 22;
            lblRazonSocial.Text = "Razón social *";
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.Items.AddRange(new object[] { "Acme SA", "Distribuidora Norte SRL", "Logística del Sur SA" });
            cboRazonSocial.Location = new Point(14, 87);
            cboRazonSocial.Margin = new Padding(5);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(303, 49);
            cboRazonSocial.TabIndex = 23;
            // 
            // lblCUIT
            // 
            lblCUIT.ForeColor = Color.FromArgb(60, 60, 60);
            lblCUIT.Location = new Point(354, 36);
            lblCUIT.Margin = new Padding(5, 0, 5, 0);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(170, 46);
            lblCUIT.TabIndex = 24;
            lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(354, 87);
            txtCUIT.Margin = new Padding(5);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(235, 47);
            txtCUIT.TabIndex = 25;
            // 
            // lblNombreRem
            // 
            lblNombreRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreRem.Location = new Point(626, 36);
            lblNombreRem.Margin = new Padding(5, 0, 5, 0);
            lblNombreRem.Name = "lblNombreRem";
            lblNombreRem.Size = new Size(342, 46);
            lblNombreRem.TabIndex = 26;
            lblNombreRem.Text = "Nombre *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(626, 87);
            txtNombreRem.Margin = new Padding(5);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(373, 47);
            txtNombreRem.TabIndex = 27;
            // 
            // lblApellidoRem
            // 
            lblApellidoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoRem.Location = new Point(1022, 36);
            lblApellidoRem.Margin = new Padding(5, 0, 5, 0);
            lblApellidoRem.Name = "lblApellidoRem";
            lblApellidoRem.Size = new Size(357, 46);
            lblApellidoRem.TabIndex = 28;
            lblApellidoRem.Text = "Apellido *";
            // 
            // txtApellidoRem
            // 
            txtApellidoRem.Location = new Point(1022, 87);
            txtApellidoRem.Margin = new Padding(5);
            txtApellidoRem.Name = "txtApellidoRem";
            txtApellidoRem.Size = new Size(388, 47);
            txtApellidoRem.TabIndex = 29;
            // 
            // lblDNIRem
            // 
            lblDNIRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIRem.Location = new Point(1423, 36);
            lblDNIRem.Margin = new Padding(5, 0, 5, 0);
            lblDNIRem.Name = "lblDNIRem";
            lblDNIRem.Size = new Size(235, 46);
            lblDNIRem.TabIndex = 30;
            lblDNIRem.Text = "DNI *";
            // 
            // txtDNIRem
            // 
            txtDNIRem.Location = new Point(1423, 87);
            txtDNIRem.Margin = new Padding(5);
            txtDNIRem.Name = "txtDNIRem";
            txtDNIRem.Size = new Size(300, 47);
            txtDNIRem.TabIndex = 31;
            // 
            // lblTelRem
            // 
            lblTelRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelRem.Location = new Point(1736, 36);
            lblTelRem.Margin = new Padding(5, 0, 5, 0);
            lblTelRem.Name = "lblTelRem";
            lblTelRem.Size = new Size(170, 46);
            lblTelRem.TabIndex = 32;
            lblTelRem.Text = "Teléfono *";
            // 
            // txtTelRem
            // 
            txtTelRem.Location = new Point(1736, 87);
            txtTelRem.Margin = new Padding(5);
            txtTelRem.Name = "txtTelRem";
            txtTelRem.Size = new Size(312, 47);
            txtTelRem.TabIndex = 33;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNombreDest);
            groupBox2.Controls.Add(txtNombreDest);
            groupBox2.Controls.Add(lblApellidoDest);
            groupBox2.Controls.Add(txtApellidoDest);
            groupBox2.Controls.Add(lblDNIDest);
            groupBox2.Controls.Add(txtDNIDest);
            groupBox2.Controls.Add(lblTelDest);
            groupBox2.Controls.Add(txtTelDest);
            groupBox2.Location = new Point(20, 395);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2060, 197);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Destinatario";
            // 
            // lblNombreDest
            // 
            lblNombreDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreDest.Location = new Point(19, 57);
            lblNombreDest.Margin = new Padding(5, 0, 5, 0);
            lblNombreDest.Name = "lblNombreDest";
            lblNombreDest.Size = new Size(304, 59);
            lblNombreDest.TabIndex = 32;
            lblNombreDest.Text = "Nombre *";
            // 
            // txtNombreDest
            // 
            txtNombreDest.Location = new Point(19, 121);
            txtNombreDest.Margin = new Padding(5);
            txtNombreDest.Name = "txtNombreDest";
            txtNombreDest.Size = new Size(562, 47);
            txtNombreDest.TabIndex = 33;
            // 
            // lblApellidoDest
            // 
            lblApellidoDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoDest.Location = new Point(658, 57);
            lblApellidoDest.Margin = new Padding(5, 0, 5, 0);
            lblApellidoDest.Name = "lblApellidoDest";
            lblApellidoDest.Size = new Size(362, 59);
            lblApellidoDest.TabIndex = 34;
            lblApellidoDest.Text = "Apellido *";
            // 
            // txtApellidoDest
            // 
            txtApellidoDest.Location = new Point(658, 121);
            txtApellidoDest.Margin = new Padding(5);
            txtApellidoDest.Name = "txtApellidoDest";
            txtApellidoDest.Size = new Size(529, 47);
            txtApellidoDest.TabIndex = 35;
            // 
            // lblDNIDest
            // 
            lblDNIDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIDest.Location = new Point(1229, 57);
            lblDNIDest.Margin = new Padding(5, 0, 5, 0);
            lblDNIDest.Name = "lblDNIDest";
            lblDNIDest.Size = new Size(260, 59);
            lblDNIDest.TabIndex = 36;
            lblDNIDest.Text = "DNI *";
            // 
            // txtDNIDest
            // 
            txtDNIDest.Location = new Point(1229, 121);
            txtDNIDest.Margin = new Padding(5);
            txtDNIDest.Name = "txtDNIDest";
            txtDNIDest.Size = new Size(393, 47);
            txtDNIDest.TabIndex = 37;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(1671, 57);
            lblTelDest.Margin = new Padding(5, 0, 5, 0);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(243, 59);
            lblTelDest.TabIndex = 38;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(1671, 121);
            txtTelDest.Margin = new Padding(5);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(376, 47);
            txtTelDest.TabIndex = 39;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Location = new Point(22, 769);
            groupBox3.Margin = new Padding(7, 8, 7, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(7, 8, 7, 8);
            groupBox3.Size = new Size(2059, 153);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modalidad de entrega*";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(1598, 64);
            radioButton7.Margin = new Padding(7, 8, 7, 8);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(216, 45);
            radioButton7.TabIndex = 2;
            radioButton7.TabStop = true;
            radioButton7.Text = "Retiro en CD";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(865, 56);
            radioButton6.Margin = new Padding(7, 8, 7, 8);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(282, 45);
            radioButton6.TabIndex = 1;
            radioButton6.TabStop = true;
            radioButton6.Text = "Retiro en Agencia";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(177, 64);
            radioButton5.Margin = new Padding(7, 8, 7, 8);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(251, 45);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Puerta a puerta";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // gbTamañoBulto
            // 
            gbTamañoBulto.Controls.Add(radioButton4);
            gbTamañoBulto.Controls.Add(radioButton3);
            gbTamañoBulto.Controls.Add(radioButton2);
            gbTamañoBulto.Controls.Add(radioButton1);
            gbTamañoBulto.Location = new Point(22, 605);
            gbTamañoBulto.Margin = new Padding(7, 8, 7, 8);
            gbTamañoBulto.Name = "gbTamañoBulto";
            gbTamañoBulto.Padding = new Padding(7, 8, 7, 8);
            gbTamañoBulto.Size = new Size(2057, 144);
            gbTamañoBulto.TabIndex = 26;
            gbTamañoBulto.TabStop = false;
            gbTamañoBulto.Text = "Tamaño de Bulto*";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(1612, 56);
            radioButton4.Margin = new Padding(7, 8, 7, 8);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(262, 45);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "TIPO XL: <20 kg";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(1081, 64);
            radioButton3.Margin = new Padding(7, 8, 7, 8);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(244, 45);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "TIPO L: <10 kg";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(585, 64);
            radioButton2.Margin = new Padding(7, 8, 7, 8);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(241, 45);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "TIPO M: <5 kg";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(126, 64);
            radioButton1.Margin = new Padding(7, 8, 7, 8);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(253, 45);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "TIPO S: <2.5 kg";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(20, 938);
            groupBox4.Margin = new Padding(7, 8, 7, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(7, 8, 7, 8);
            groupBox4.Size = new Size(578, 471);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Puerta a Puerta";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 364);
            textBox5.Margin = new Padding(7, 5, 7, 5);
            textBox5.MaxLength = 40;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(543, 47);
            textBox5.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 320);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 41);
            label5.TabIndex = 32;
            label5.Text = "Ciudad *";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(350, 238);
            textBox4.Margin = new Padding(7, 5, 7, 5);
            textBox4.MaxLength = 10;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 47);
            textBox4.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 195);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 41);
            label4.TabIndex = 32;
            label4.Text = "Codigo postal *";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 238);
            textBox3.Margin = new Padding(7, 5, 7, 5);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 47);
            textBox3.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 195);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 41);
            label3.TabIndex = 33;
            label3.Text = "Piso";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 238);
            textBox2.Margin = new Padding(7, 5, 7, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 47);
            textBox2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 195);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 41);
            label2.TabIndex = 32;
            label2.Text = "Altura *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 98);
            textBox1.Margin = new Padding(7, 5, 7, 5);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(543, 47);
            textBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 56);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 41);
            label1.TabIndex = 27;
            label1.Text = "Calle*";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(comboBox2);
            groupBox5.Location = new Point(1620, 938);
            groupBox5.Margin = new Padding(7, 8, 7, 8);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(7, 8, 7, 8);
            groupBox5.Size = new Size(459, 471);
            groupBox5.TabIndex = 29;
            groupBox5.TabStop = false;
            groupBox5.Text = "Retiro en CD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 151);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(333, 41);
            label7.TabIndex = 3;
            label7.Text = "Seleccionar CD Destino:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(14, 238);
            comboBox2.Margin = new Padding(7, 8, 7, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(434, 49);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(comboBox1);
            groupBox6.Location = new Point(1148, 938);
            groupBox6.Margin = new Padding(7, 8, 7, 8);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(7, 8, 7, 8);
            groupBox6.Size = new Size(459, 471);
            groupBox6.TabIndex = 30;
            groupBox6.TabStop = false;
            groupBox6.Text = "CD de Origen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 154);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(322, 41);
            label6.TabIndex = 3;
            label6.Text = "Seleccionar CD Origen:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 238);
            comboBox1.Margin = new Padding(7, 8, 7, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 49);
            comboBox1.TabIndex = 2;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(comboBox3);
            groupBox7.Location = new Point(607, 938);
            groupBox7.Margin = new Padding(7, 8, 7, 8);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(7, 8, 7, 8);
            groupBox7.Size = new Size(527, 471);
            groupBox7.TabIndex = 31;
            groupBox7.TabStop = false;
            groupBox7.Text = "Retiro en Agencia";
            groupBox7.Enter += groupBox7_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 154);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(289, 41);
            label8.TabIndex = 1;
            label8.Text = "Seleccionar Agencia:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(31, 233);
            comboBox3.Margin = new Padding(7, 8, 7, 8);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(470, 49);
            comboBox3.TabIndex = 0;
            // 
            // btnGenerarGuia
            // 
            btnGenerarGuia.Location = new Point(826, 1422);
            btnGenerarGuia.Margin = new Padding(7, 5, 7, 5);
            btnGenerarGuia.Name = "btnGenerarGuia";
            btnGenerarGuia.Size = new Size(573, 151);
            btnGenerarGuia.TabIndex = 32;
            btnGenerarGuia.Text = "Registrar Imposición";
            btnGenerarGuia.UseVisualStyleBackColor = true;
            btnGenerarGuia.Click += btnGenerarGuia_Click;
            // 
            // ImposicionAgencia_v2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2101, 1588);
            Controls.Add(btnGenerarGuia);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(gbTamañoBulto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Margin = new Padding(5);
            Name = "ImposicionAgencia_v2";
            Text = "Imposición en Agencia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbTamañoBulto.ResumeLayout(false);
            gbTamañoBulto.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox1;
        private Label lblRazonSocial;
        private ComboBox cboRazonSocial;
        private Label lblCUIT;
        private TextBox txtCUIT;
        private Label lblNombreRem;
        private TextBox txtNombreRem;
        private Label lblApellidoRem;
        private TextBox txtApellidoRem;
        private Label lblDNIRem;
        private TextBox txtDNIRem;
        private Label lblTelRem;
        private TextBox txtTelRem;
        private TextBox txtCiudadRemitente;
        private Label lblCiudadRemitente;
        private TextBox txtCodigoPostalRemitente;
        private Label lblCodigoPostalRemitente;
        private TextBox txtPisoRemitente;
        private Label lblPisoRemitente;
        private TextBox txtAlturaRemitente;
        private Label lblAlturaRemitente;
        private TextBox txtCalleRemitente;
        private Label lblCalleRemitente;
        private GroupBox groupBox2;
        private Label lblNombreDest;
        private TextBox txtNombreDest;
        private Label lblApellidoDest;
        private TextBox txtApellidoDest;
        private Label lblDNIDest;
        private TextBox txtDNIDest;
        private Label lblTelDest;
        private TextBox txtTelDest;
        private GroupBox groupBox3;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private GroupBox gbTamañoBulto;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox5;
        private Label label7;
        private ComboBox comboBox2;
        private GroupBox groupBox6;
        private Label label6;
        private ComboBox comboBox1;
        private GroupBox groupBox7;
        private Label label8;
        private ComboBox comboBox3;
        private Button btnGenerarGuia;
    }
}