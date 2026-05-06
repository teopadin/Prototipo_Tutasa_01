namespace Prototipos_TUTASA
{
    partial class ImposiciónCC_Corporativo
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
            lblSecRemitente = new Label();
            pnlSepRem = new Panel();
            lblRazonSocial = new Label();
            txtRazonSocial = new ComboBox();
            lblCUIT = new Label();
            txtCUIT = new TextBox();
            lblContacto = new Label();
            txtContacto = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblSecDestinatario = new Label();
            pnlSepDest = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblTelDest = new Label();
            txtTelDest = new TextBox();
            btnVolver = new Button();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(30, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Imposición en Call Center";
            // 
            // lblPaso
            // 
            lblPaso.Font = new Font("Segoe UI", 9F);
            lblPaso.ForeColor = Color.Gray;
            lblPaso.Location = new Point(30, 73);
            lblPaso.Name = "lblPaso";
            lblPaso.Size = new Size(350, 20);
            lblPaso.TabIndex = 4;
            lblPaso.Text = "Paso 2 de 3  —  Empresa / Agencia";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(570, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(618, 28);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(126, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "06/05/2026";
            // 
            // pnlSep1
            // 
            pnlSep1.BackColor = Color.FromArgb(220, 220, 220);
            pnlSep1.Location = new Point(30, 63);
            pnlSep1.Name = "pnlSep1";
            pnlSep1.Size = new Size(690, 1);
            pnlSep1.TabIndex = 3;
            // 
            // lblSecRemitente
            // 
            lblSecRemitente.Font = new Font("Segoe UI", 10F);
            lblSecRemitente.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecRemitente.Location = new Point(30, 93);
            lblSecRemitente.Name = "lblSecRemitente";
            lblSecRemitente.Size = new Size(300, 34);
            lblSecRemitente.TabIndex = 5;
            lblSecRemitente.Text = "1. Datos del remitente";
            // 
            // pnlSepRem
            // 
            pnlSepRem.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepRem.Location = new Point(30, 130);
            pnlSepRem.Name = "pnlSepRem";
            pnlSepRem.Size = new Size(690, 1);
            pnlSepRem.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.ForeColor = Color.FromArgb(60, 60, 60);
            lblRazonSocial.Location = new Point(30, 134);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(200, 26);
            lblRazonSocial.TabIndex = 7;
            lblRazonSocial.Text = "Razón social *";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Items.AddRange(new object[] { "Acme SA", "Distribuidora Norte SRL", "Logística del Sur SA" });
            txtRazonSocial.Location = new Point(30, 162);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(260, 33);
            txtRazonSocial.TabIndex = 8;
            // 
            // lblCUIT
            // 
            lblCUIT.ForeColor = Color.FromArgb(60, 60, 60);
            lblCUIT.Location = new Point(310, 134);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(120, 26);
            lblCUIT.TabIndex = 9;
            lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(310, 162);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(150, 31);
            txtCUIT.TabIndex = 10;
            // 
            // lblContacto
            // 
            lblContacto.ForeColor = Color.FromArgb(60, 60, 60);
            lblContacto.Location = new Point(480, 134);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(180, 26);
            lblContacto.TabIndex = 11;
            lblContacto.Text = "Nombre de contacto *";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(480, 162);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(230, 31);
            txtContacto.TabIndex = 12;
            // 
            // lblTelefono
            // 
            lblTelefono.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelefono.Location = new Point(30, 198);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(150, 25);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Teléfono *";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(30, 225);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 31);
            txtTelefono.TabIndex = 14;
            // 
            // lblSecDestinatario
            // 
            lblSecDestinatario.Font = new Font("Segoe UI", 10F);
            lblSecDestinatario.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecDestinatario.Location = new Point(30, 259);
            lblSecDestinatario.Name = "lblSecDestinatario";
            lblSecDestinatario.Size = new Size(300, 38);
            lblSecDestinatario.TabIndex = 15;
            lblSecDestinatario.Text = "2. Datos del destinatario";
            // 
            // pnlSepDest
            // 
            pnlSepDest.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepDest.Location = new Point(30, 300);
            pnlSepDest.Name = "pnlSepDest";
            pnlSepDest.Size = new Size(690, 1);
            pnlSepDest.TabIndex = 16;
            // 
            // lblNombre
            // 
            lblNombre.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombre.Location = new Point(30, 300);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 30);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre *";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 332);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 31);
            txtNombre.TabIndex = 18;
            // 
            // lblApellido
            // 
            lblApellido.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellido.Location = new Point(230, 300);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(120, 30);
            lblApellido.TabIndex = 19;
            lblApellido.Text = "Apellido *";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(230, 332);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(180, 31);
            txtApellido.TabIndex = 20;
            // 
            // lblDNI
            // 
            lblDNI.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNI.Location = new Point(430, 300);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(80, 30);
            lblDNI.TabIndex = 21;
            lblDNI.Text = "DNI *";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(430, 332);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(130, 31);
            txtDNI.TabIndex = 22;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(580, 300);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(100, 30);
            lblTelDest.TabIndex = 23;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(580, 332);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(130, 31);
            txtTelDest.TabIndex = 24;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.ForeColor = Color.FromArgb(80, 80, 80);
            btnVolver.Location = new Point(30, 405);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "< Volver";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.System;
            btnSiguiente.Location = new Point(610, 405);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(110, 32);
            btnSiguiente.TabIndex = 26;
            btnSiguiente.Text = "Siguiente >";
            // 
            // ImposiciónCC_Corporativo
            // 
            BackColor = Color.White;
            ClientSize = new Size(855, 564);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(pnlSep1);
            Controls.Add(lblPaso);
            Controls.Add(lblSecRemitente);
            Controls.Add(pnlSepRem);
            Controls.Add(lblRazonSocial);
            Controls.Add(txtRazonSocial);
            Controls.Add(lblCUIT);
            Controls.Add(txtCUIT);
            Controls.Add(lblContacto);
            Controls.Add(txtContacto);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblSecDestinatario);
            Controls.Add(pnlSepDest);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(lblTelDest);
            Controls.Add(txtTelDest);
            Controls.Add(btnVolver);
            Controls.Add(btnSiguiente);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCC_Corporativo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Datos del remitente (Empresa/Agencia)";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo, lblPaso, lblFecha, lblFechaValor;
        private System.Windows.Forms.Panel pnlSep1, pnlSepRem, pnlSepDest;
        private System.Windows.Forms.Label lblSecRemitente, lblSecDestinatario;
        private System.Windows.Forms.Label lblRazonSocial, lblCUIT, lblContacto, lblTelefono;
        private System.Windows.Forms.ComboBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCUIT, txtContacto, txtTelefono;
        private System.Windows.Forms.Label lblNombre, lblApellido, lblDNI, lblTelDest;
        private System.Windows.Forms.TextBox txtNombre, txtApellido, txtDNI, txtTelDest;
        private System.Windows.Forms.Button btnVolver, btnSiguiente;
    }
}