namespace Prototipos_TUTASA.ImposiciónAgencia_v2
{
    partial class Form1
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 46);
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
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1006, 177);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Remitente";
            // 
            // txtCiudadRemitente
            // 
            txtCiudadRemitente.Location = new Point(693, 125);
            txtCiudadRemitente.Margin = new Padding(4);
            txtCiudadRemitente.MaxLength = 40;
            txtCiudadRemitente.Name = "txtCiudadRemitente";
            txtCiudadRemitente.Size = new Size(305, 31);
            txtCiudadRemitente.TabIndex = 38;
            // 
            // lblCiudadRemitente
            // 
            lblCiudadRemitente.AutoSize = true;
            lblCiudadRemitente.Location = new Point(690, 96);
            lblCiudadRemitente.Margin = new Padding(4, 0, 4, 0);
            lblCiudadRemitente.Name = "lblCiudadRemitente";
            lblCiudadRemitente.Size = new Size(81, 25);
            lblCiudadRemitente.TabIndex = 43;
            lblCiudadRemitente.Text = "Ciudad *";
            // 
            // txtCodigoPostalRemitente
            // 
            txtCodigoPostalRemitente.Location = new Point(544, 125);
            txtCodigoPostalRemitente.Margin = new Padding(4);
            txtCodigoPostalRemitente.MaxLength = 10;
            txtCodigoPostalRemitente.Name = "txtCodigoPostalRemitente";
            txtCodigoPostalRemitente.Size = new Size(141, 31);
            txtCodigoPostalRemitente.TabIndex = 37;
            // 
            // lblCodigoPostalRemitente
            // 
            lblCodigoPostalRemitente.AutoSize = true;
            lblCodigoPostalRemitente.Location = new Point(544, 96);
            lblCodigoPostalRemitente.Margin = new Padding(4, 0, 4, 0);
            lblCodigoPostalRemitente.Name = "lblCodigoPostalRemitente";
            lblCodigoPostalRemitente.Size = new Size(138, 25);
            lblCodigoPostalRemitente.TabIndex = 42;
            lblCodigoPostalRemitente.Text = "Codigo postal *";
            // 
            // txtPisoRemitente
            // 
            txtPisoRemitente.Location = new Point(463, 125);
            txtPisoRemitente.Margin = new Padding(4);
            txtPisoRemitente.MaxLength = 10;
            txtPisoRemitente.Name = "txtPisoRemitente";
            txtPisoRemitente.Size = new Size(69, 31);
            txtPisoRemitente.TabIndex = 36;
            // 
            // lblPisoRemitente
            // 
            lblPisoRemitente.AutoSize = true;
            lblPisoRemitente.Location = new Point(463, 96);
            lblPisoRemitente.Margin = new Padding(4, 0, 4, 0);
            lblPisoRemitente.Name = "lblPisoRemitente";
            lblPisoRemitente.Size = new Size(45, 25);
            lblPisoRemitente.TabIndex = 41;
            lblPisoRemitente.Text = "Piso";
            // 
            // txtAlturaRemitente
            // 
            txtAlturaRemitente.Location = new Point(350, 125);
            txtAlturaRemitente.Margin = new Padding(4);
            txtAlturaRemitente.Name = "txtAlturaRemitente";
            txtAlturaRemitente.Size = new Size(103, 31);
            txtAlturaRemitente.TabIndex = 35;
            // 
            // lblAlturaRemitente
            // 
            lblAlturaRemitente.AutoSize = true;
            lblAlturaRemitente.Location = new Point(350, 96);
            lblAlturaRemitente.Margin = new Padding(4, 0, 4, 0);
            lblAlturaRemitente.Name = "lblAlturaRemitente";
            lblAlturaRemitente.Size = new Size(72, 25);
            lblAlturaRemitente.TabIndex = 40;
            lblAlturaRemitente.Text = "Altura *";
            // 
            // txtCalleRemitente
            // 
            txtCalleRemitente.Location = new Point(11, 125);
            txtCalleRemitente.Margin = new Padding(4);
            txtCalleRemitente.MaxLength = 50;
            txtCalleRemitente.Name = "txtCalleRemitente";
            txtCalleRemitente.Size = new Size(331, 31);
            txtCalleRemitente.TabIndex = 34;
            // 
            // lblCalleRemitente
            // 
            lblCalleRemitente.AutoSize = true;
            lblCalleRemitente.Location = new Point(11, 96);
            lblCalleRemitente.Margin = new Padding(4, 0, 4, 0);
            lblCalleRemitente.Name = "lblCalleRemitente";
            lblCalleRemitente.Size = new Size(62, 25);
            lblCalleRemitente.TabIndex = 39;
            lblCalleRemitente.Text = "Calle *";
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.ForeColor = Color.FromArgb(60, 60, 60);
            lblRazonSocial.Location = new Point(8, 22);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(150, 28);
            lblRazonSocial.TabIndex = 22;
            lblRazonSocial.Text = "Razón social *";
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.Items.AddRange(new object[] { "Acme SA", "Distribuidora Norte SRL", "Logística del Sur SA" });
            cboRazonSocial.Location = new Point(8, 53);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(180, 33);
            cboRazonSocial.TabIndex = 23;
            // 
            // lblCUIT
            // 
            lblCUIT.ForeColor = Color.FromArgb(60, 60, 60);
            lblCUIT.Location = new Point(208, 22);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(100, 28);
            lblCUIT.TabIndex = 24;
            lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(208, 53);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(140, 31);
            txtCUIT.TabIndex = 25;
            // 
            // lblNombreRem
            // 
            lblNombreRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreRem.Location = new Point(368, 22);
            lblNombreRem.Name = "lblNombreRem";
            lblNombreRem.Size = new Size(120, 28);
            lblNombreRem.TabIndex = 26;
            lblNombreRem.Text = "Nombre *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(368, 53);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(140, 31);
            txtNombreRem.TabIndex = 27;
            // 
            // lblApellidoRem
            // 
            lblApellidoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoRem.Location = new Point(528, 22);
            lblApellidoRem.Name = "lblApellidoRem";
            lblApellidoRem.Size = new Size(120, 28);
            lblApellidoRem.TabIndex = 28;
            lblApellidoRem.Text = "Apellido *";
            // 
            // txtApellidoRem
            // 
            txtApellidoRem.Location = new Point(528, 53);
            txtApellidoRem.Name = "txtApellidoRem";
            txtApellidoRem.Size = new Size(140, 31);
            txtApellidoRem.TabIndex = 29;
            // 
            // lblDNIRem
            // 
            lblDNIRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIRem.Location = new Point(688, 22);
            lblDNIRem.Name = "lblDNIRem";
            lblDNIRem.Size = new Size(80, 28);
            lblDNIRem.TabIndex = 30;
            lblDNIRem.Text = "DNI *";
            // 
            // txtDNIRem
            // 
            txtDNIRem.Location = new Point(688, 53);
            txtDNIRem.Name = "txtDNIRem";
            txtDNIRem.Size = new Size(120, 31);
            txtDNIRem.TabIndex = 31;
            // 
            // lblTelRem
            // 
            lblTelRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelRem.Location = new Point(828, 22);
            lblTelRem.Name = "lblTelRem";
            lblTelRem.Size = new Size(100, 28);
            lblTelRem.TabIndex = 32;
            lblTelRem.Text = "Teléfono *";
            // 
            // txtTelRem
            // 
            txtTelRem.Location = new Point(828, 53);
            txtTelRem.Name = "txtTelRem";
            txtTelRem.Size = new Size(170, 31);
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
            groupBox2.Location = new Point(12, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1006, 120);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Destinatario";
            // 
            // lblNombreDest
            // 
            lblNombreDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreDest.Location = new Point(11, 35);
            lblNombreDest.Name = "lblNombreDest";
            lblNombreDest.Size = new Size(179, 36);
            lblNombreDest.TabIndex = 32;
            lblNombreDest.Text = "Nombre *";
            // 
            // txtNombreDest
            // 
            txtNombreDest.Location = new Point(11, 74);
            txtNombreDest.Name = "txtNombreDest";
            txtNombreDest.Size = new Size(279, 31);
            txtNombreDest.TabIndex = 33;
            // 
            // lblApellidoDest
            // 
            lblApellidoDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoDest.Location = new Point(312, 35);
            lblApellidoDest.Name = "lblApellidoDest";
            lblApellidoDest.Size = new Size(157, 36);
            lblApellidoDest.TabIndex = 34;
            lblApellidoDest.Text = "Apellido *";
            // 
            // txtApellidoDest
            // 
            txtApellidoDest.Location = new Point(312, 74);
            txtApellidoDest.Name = "txtApellidoDest";
            txtApellidoDest.Size = new Size(257, 31);
            txtApellidoDest.TabIndex = 35;
            // 
            // lblDNIDest
            // 
            lblDNIDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIDest.Location = new Point(587, 35);
            lblDNIDest.Name = "lblDNIDest";
            lblDNIDest.Size = new Size(80, 36);
            lblDNIDest.TabIndex = 36;
            lblDNIDest.Text = "DNI *";
            // 
            // txtDNIDest
            // 
            txtDNIDest.Location = new Point(587, 74);
            txtDNIDest.Name = "txtDNIDest";
            txtDNIDest.Size = new Size(160, 31);
            txtDNIDest.TabIndex = 37;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(775, 35);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(143, 36);
            lblTelDest.TabIndex = 38;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(775, 74);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(223, 31);
            txtTelDest.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 643);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Imposición en Agencia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}