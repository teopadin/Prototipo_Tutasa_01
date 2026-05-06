namespace Prototipos_TUTASA
{
    partial class Form3_Particular
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
            lblNombreRem = new Label();
            txtNombreRem = new TextBox();
            lblApellidoRem = new Label();
            txtApellidoRem = new TextBox();
            lblDNIRem = new Label();
            txtDNIRem = new TextBox();
            lblTelRem = new Label();
            txtTelRem = new TextBox();
            lblCalleRem = new Label();
            txtCalleRem = new TextBox();
            lblAlturaRem = new Label();
            txtAlturaRem = new TextBox();
            lblPisoRem = new Label();
            txtPisoRem = new TextBox();
            lblSecDestinatario = new Label();
            pnlSepDest = new Panel();
            lblNombreDest = new Label();
            txtNombreDest = new TextBox();
            lblApellidoDest = new Label();
            txtApellidoDest = new TextBox();
            lblDNIDest = new Label();
            txtDNIDest = new TextBox();
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
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Imposición en Call Center";
            // 
            // lblPaso
            // 
            lblPaso.Font = new Font("Segoe UI", 9F);
            lblPaso.ForeColor = Color.Gray;
            lblPaso.Location = new Point(30, 73);
            lblPaso.Name = "lblPaso";
            lblPaso.Size = new Size(300, 20);
            lblPaso.TabIndex = 4;
            lblPaso.Text = "Paso 2 de 3  —  Particular";
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
            lblFechaValor.Size = new Size(90, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "05/05/2026";
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
            lblSecRemitente.Location = new Point(30, 105);
            lblSecRemitente.Name = "lblSecRemitente";
            lblSecRemitente.Size = new Size(300, 22);
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
            // lblNombreRem
            // 
            lblNombreRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreRem.Location = new Point(30, 142);
            lblNombreRem.Name = "lblNombreRem";
            lblNombreRem.Size = new Size(130, 18);
            lblNombreRem.TabIndex = 7;
            lblNombreRem.Text = "Nombre *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(30, 162);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(160, 31);
            txtNombreRem.TabIndex = 8;
            // 
            // lblApellidoRem
            // 
            lblApellidoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoRem.Location = new Point(210, 142);
            lblApellidoRem.Name = "lblApellidoRem";
            lblApellidoRem.Size = new Size(130, 18);
            lblApellidoRem.TabIndex = 9;
            lblApellidoRem.Text = "Apellido *";
            // 
            // txtApellidoRem
            // 
            txtApellidoRem.Location = new Point(210, 162);
            txtApellidoRem.Name = "txtApellidoRem";
            txtApellidoRem.Size = new Size(160, 31);
            txtApellidoRem.TabIndex = 10;
            // 
            // lblDNIRem
            // 
            lblDNIRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIRem.Location = new Point(390, 142);
            lblDNIRem.Name = "lblDNIRem";
            lblDNIRem.Size = new Size(100, 18);
            lblDNIRem.TabIndex = 11;
            lblDNIRem.Text = "DNI *";
            // 
            // txtDNIRem
            // 
            txtDNIRem.Location = new Point(390, 162);
            txtDNIRem.Name = "txtDNIRem";
            txtDNIRem.Size = new Size(130, 31);
            txtDNIRem.TabIndex = 12;
            // 
            // lblTelRem
            // 
            lblTelRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelRem.Location = new Point(540, 142);
            lblTelRem.Name = "lblTelRem";
            lblTelRem.Size = new Size(100, 18);
            lblTelRem.TabIndex = 13;
            lblTelRem.Text = "Teléfono *";
            // 
            // txtTelRem
            // 
            txtTelRem.Location = new Point(540, 162);
            txtTelRem.Name = "txtTelRem";
            txtTelRem.Size = new Size(160, 31);
            txtTelRem.TabIndex = 14;
            // 
            // lblCalleRem
            // 
            lblCalleRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblCalleRem.Location = new Point(30, 205);
            lblCalleRem.Name = "lblCalleRem";
            lblCalleRem.Size = new Size(220, 18);
            lblCalleRem.TabIndex = 15;
            lblCalleRem.Text = "Calle (domicilio de retiro) *";
            // 
            // txtCalleRem
            // 
            txtCalleRem.Location = new Point(30, 225);
            txtCalleRem.Name = "txtCalleRem";
            txtCalleRem.Size = new Size(280, 31);
            txtCalleRem.TabIndex = 16;
            // 
            // lblAlturaRem
            // 
            lblAlturaRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblAlturaRem.Location = new Point(330, 205);
            lblAlturaRem.Name = "lblAlturaRem";
            lblAlturaRem.Size = new Size(80, 18);
            lblAlturaRem.TabIndex = 17;
            lblAlturaRem.Text = "Altura *";
            // 
            // txtAlturaRem
            // 
            txtAlturaRem.Location = new Point(330, 225);
            txtAlturaRem.Name = "txtAlturaRem";
            txtAlturaRem.Size = new Size(90, 31);
            txtAlturaRem.TabIndex = 18;
            // 
            // lblPisoRem
            // 
            lblPisoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblPisoRem.Location = new Point(440, 205);
            lblPisoRem.Name = "lblPisoRem";
            lblPisoRem.Size = new Size(100, 18);
            lblPisoRem.TabIndex = 19;
            lblPisoRem.Text = "Piso / Depto";
            // 
            // txtPisoRem
            // 
            txtPisoRem.Location = new Point(440, 225);
            txtPisoRem.Name = "txtPisoRem";
            txtPisoRem.Size = new Size(120, 31);
            txtPisoRem.TabIndex = 20;
            // 
            // lblSecDestinatario
            // 
            lblSecDestinatario.Font = new Font("Segoe UI", 10F);
            lblSecDestinatario.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecDestinatario.Location = new Point(30, 275);
            lblSecDestinatario.Name = "lblSecDestinatario";
            lblSecDestinatario.Size = new Size(300, 22);
            lblSecDestinatario.TabIndex = 21;
            lblSecDestinatario.Text = "2. Datos del destinatario";
            // 
            // pnlSepDest
            // 
            pnlSepDest.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepDest.Location = new Point(30, 300);
            pnlSepDest.Name = "pnlSepDest";
            pnlSepDest.Size = new Size(690, 1);
            pnlSepDest.TabIndex = 22;
            // 
            // lblNombreDest
            // 
            lblNombreDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreDest.Location = new Point(30, 312);
            lblNombreDest.Name = "lblNombreDest";
            lblNombreDest.Size = new Size(130, 18);
            lblNombreDest.TabIndex = 23;
            lblNombreDest.Text = "Nombre *";
            // 
            // txtNombreDest
            // 
            txtNombreDest.Location = new Point(30, 332);
            txtNombreDest.Name = "txtNombreDest";
            txtNombreDest.Size = new Size(160, 31);
            txtNombreDest.TabIndex = 24;
            // 
            // lblApellidoDest
            // 
            lblApellidoDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoDest.Location = new Point(210, 312);
            lblApellidoDest.Name = "lblApellidoDest";
            lblApellidoDest.Size = new Size(130, 18);
            lblApellidoDest.TabIndex = 25;
            lblApellidoDest.Text = "Apellido *";
            // 
            // txtApellidoDest
            // 
            txtApellidoDest.Location = new Point(210, 332);
            txtApellidoDest.Name = "txtApellidoDest";
            txtApellidoDest.Size = new Size(160, 31);
            txtApellidoDest.TabIndex = 26;
            // 
            // lblDNIDest
            // 
            lblDNIDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIDest.Location = new Point(390, 312);
            lblDNIDest.Name = "lblDNIDest";
            lblDNIDest.Size = new Size(80, 18);
            lblDNIDest.TabIndex = 27;
            lblDNIDest.Text = "DNI *";
            // 
            // txtDNIDest
            // 
            txtDNIDest.Location = new Point(390, 332);
            txtDNIDest.Name = "txtDNIDest";
            txtDNIDest.Size = new Size(130, 31);
            txtDNIDest.TabIndex = 28;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(540, 312);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(100, 18);
            lblTelDest.TabIndex = 29;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(540, 332);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(160, 31);
            txtTelDest.TabIndex = 30;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.ForeColor = Color.FromArgb(80, 80, 80);
            btnVolver.Location = new Point(30, 455);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "< Volver";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.System;
            btnSiguiente.Location = new Point(610, 455);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(110, 32);
            btnSiguiente.TabIndex = 32;
            btnSiguiente.Text = "Siguiente >";
            // 
            // Form3_Particular
            // 
            BackColor = Color.White;
            ClientSize = new Size(738, 484);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(pnlSep1);
            Controls.Add(lblPaso);
            Controls.Add(lblSecRemitente);
            Controls.Add(pnlSepRem);
            Controls.Add(lblNombreRem);
            Controls.Add(txtNombreRem);
            Controls.Add(lblApellidoRem);
            Controls.Add(txtApellidoRem);
            Controls.Add(lblDNIRem);
            Controls.Add(txtDNIRem);
            Controls.Add(lblTelRem);
            Controls.Add(txtTelRem);
            Controls.Add(lblCalleRem);
            Controls.Add(txtCalleRem);
            Controls.Add(lblAlturaRem);
            Controls.Add(txtAlturaRem);
            Controls.Add(lblPisoRem);
            Controls.Add(txtPisoRem);
            Controls.Add(lblSecDestinatario);
            Controls.Add(pnlSepDest);
            Controls.Add(lblNombreDest);
            Controls.Add(txtNombreDest);
            Controls.Add(lblApellidoDest);
            Controls.Add(txtApellidoDest);
            Controls.Add(lblDNIDest);
            Controls.Add(txtDNIDest);
            Controls.Add(lblTelDest);
            Controls.Add(txtTelDest);
            Controls.Add(btnVolver);
            Controls.Add(btnSiguiente);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3_Particular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Datos del remitente (Particular)";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo, lblPaso, lblFecha, lblFechaValor;
        private System.Windows.Forms.Panel pnlSep1, pnlSepRem, pnlSepDest;
        private System.Windows.Forms.Label lblSecRemitente, lblSecDestinatario;
        private System.Windows.Forms.Label lblNombreRem, lblApellidoRem, lblDNIRem, lblTelRem, lblCalleRem, lblAlturaRem, lblPisoRem;
        private System.Windows.Forms.TextBox txtNombreRem, txtApellidoRem, txtDNIRem, txtTelRem, txtCalleRem, txtAlturaRem, txtPisoRem;
        private System.Windows.Forms.Label lblNombreDest, lblApellidoDest, lblDNIDest, lblTelDest;
        private System.Windows.Forms.TextBox txtNombreDest, txtApellidoDest, txtDNIDest, txtTelDest;
        private System.Windows.Forms.Button btnVolver, btnSiguiente;
    }
}