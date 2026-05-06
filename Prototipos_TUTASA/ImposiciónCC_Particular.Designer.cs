namespace Prototipos_TUTASA
{
    partial class ImposiciónCC_Particular
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            lblPaso.Location = new Point(30, 56);
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
            lblFechaValor.Size = new Size(142, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "06/05/2026";
            // 
            // lblNombreRem
            // 
            lblNombreRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreRem.Location = new Point(18, 19);
            lblNombreRem.Name = "lblNombreRem";
            lblNombreRem.Size = new Size(130, 26);
            lblNombreRem.TabIndex = 7;
            lblNombreRem.Text = "Nombre *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(18, 48);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(262, 23);
            txtNombreRem.TabIndex = 8;
            // 
            // lblApellidoRem
            // 
            lblApellidoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoRem.Location = new Point(298, 19);
            lblApellidoRem.Name = "lblApellidoRem";
            lblApellidoRem.Size = new Size(130, 26);
            lblApellidoRem.TabIndex = 9;
            lblApellidoRem.Text = "Apellido *";
            // 
            // txtApellidoRem
            // 
            txtApellidoRem.Location = new Point(298, 48);
            txtApellidoRem.Name = "txtApellidoRem";
            txtApellidoRem.Size = new Size(261, 23);
            txtApellidoRem.TabIndex = 10;
            // 
            // lblDNIRem
            // 
            lblDNIRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIRem.Location = new Point(574, 19);
            lblDNIRem.Name = "lblDNIRem";
            lblDNIRem.Size = new Size(100, 26);
            lblDNIRem.TabIndex = 11;
            lblDNIRem.Text = "DNI *";
            // 
            // txtDNIRem
            // 
            txtDNIRem.Location = new Point(574, 48);
            txtDNIRem.Name = "txtDNIRem";
            txtDNIRem.Size = new Size(130, 23);
            txtDNIRem.TabIndex = 12;
            // 
            // lblTelRem
            // 
            lblTelRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelRem.Location = new Point(18, 81);
            lblTelRem.Name = "lblTelRem";
            lblTelRem.Size = new Size(100, 26);
            lblTelRem.TabIndex = 13;
            lblTelRem.Text = "Teléfono *";
            // 
            // txtTelRem
            // 
            txtTelRem.Location = new Point(18, 108);
            txtTelRem.Name = "txtTelRem";
            txtTelRem.Size = new Size(160, 23);
            txtTelRem.TabIndex = 14;
            // 
            // lblCalleRem
            // 
            lblCalleRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblCalleRem.Location = new Point(183, 81);
            lblCalleRem.Name = "lblCalleRem";
            lblCalleRem.Size = new Size(220, 27);
            lblCalleRem.TabIndex = 15;
            lblCalleRem.Text = "Calle (domicilio de retiro) *";
            // 
            // txtCalleRem
            // 
            txtCalleRem.Location = new Point(184, 108);
            txtCalleRem.Name = "txtCalleRem";
            txtCalleRem.Size = new Size(280, 23);
            txtCalleRem.TabIndex = 16;
            // 
            // lblAlturaRem
            // 
            lblAlturaRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblAlturaRem.Location = new Point(469, 81);
            lblAlturaRem.Name = "lblAlturaRem";
            lblAlturaRem.Size = new Size(80, 27);
            lblAlturaRem.TabIndex = 17;
            lblAlturaRem.Text = "Altura *";
            // 
            // txtAlturaRem
            // 
            txtAlturaRem.Location = new Point(476, 108);
            txtAlturaRem.Name = "txtAlturaRem";
            txtAlturaRem.Size = new Size(90, 23);
            txtAlturaRem.TabIndex = 18;
            // 
            // lblPisoRem
            // 
            lblPisoRem.ForeColor = Color.FromArgb(60, 60, 60);
            lblPisoRem.Location = new Point(574, 81);
            lblPisoRem.Name = "lblPisoRem";
            lblPisoRem.Size = new Size(100, 27);
            lblPisoRem.TabIndex = 19;
            lblPisoRem.Text = "Piso / Depto";
            // 
            // txtPisoRem
            // 
            txtPisoRem.Location = new Point(574, 108);
            txtPisoRem.Name = "txtPisoRem";
            txtPisoRem.Size = new Size(130, 23);
            txtPisoRem.TabIndex = 20;
            // 
            // lblNombreDest
            // 
            lblNombreDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblNombreDest.Location = new Point(18, 29);
            lblNombreDest.Name = "lblNombreDest";
            lblNombreDest.Size = new Size(130, 26);
            lblNombreDest.TabIndex = 23;
            lblNombreDest.Text = "Nombre *";
            // 
            // txtNombreDest
            // 
            txtNombreDest.Location = new Point(18, 54);
            txtNombreDest.Name = "txtNombreDest";
            txtNombreDest.Size = new Size(160, 23);
            txtNombreDest.TabIndex = 24;
            // 
            // lblApellidoDest
            // 
            lblApellidoDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblApellidoDest.Location = new Point(198, 29);
            lblApellidoDest.Name = "lblApellidoDest";
            lblApellidoDest.Size = new Size(130, 26);
            lblApellidoDest.TabIndex = 25;
            lblApellidoDest.Text = "Apellido *";
            // 
            // txtApellidoDest
            // 
            txtApellidoDest.Location = new Point(198, 54);
            txtApellidoDest.Name = "txtApellidoDest";
            txtApellidoDest.Size = new Size(160, 23);
            txtApellidoDest.TabIndex = 26;
            // 
            // lblDNIDest
            // 
            lblDNIDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblDNIDest.Location = new Point(378, 29);
            lblDNIDest.Name = "lblDNIDest";
            lblDNIDest.Size = new Size(80, 26);
            lblDNIDest.TabIndex = 27;
            lblDNIDest.Text = "DNI *";
            // 
            // txtDNIDest
            // 
            txtDNIDest.Location = new Point(378, 58);
            txtDNIDest.Name = "txtDNIDest";
            txtDNIDest.Size = new Size(130, 23);
            txtDNIDest.TabIndex = 28;
            // 
            // lblTelDest
            // 
            lblTelDest.ForeColor = Color.FromArgb(60, 60, 60);
            lblTelDest.Location = new Point(528, 29);
            lblTelDest.Name = "lblTelDest";
            lblTelDest.Size = new Size(100, 26);
            lblTelDest.TabIndex = 29;
            lblTelDest.Text = "Teléfono *";
            // 
            // txtTelDest
            // 
            txtTelDest.Location = new Point(528, 58);
            txtTelDest.Name = "txtTelDest";
            txtTelDest.Size = new Size(160, 23);
            txtTelDest.TabIndex = 30;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.ForeColor = Color.FromArgb(80, 80, 80);
            btnVolver.Location = new Point(30, 363);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "< Volver";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.System;
            btnSiguiente.Location = new Point(606, 363);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(110, 32);
            btnSiguiente.TabIndex = 32;
            btnSiguiente.Text = "Siguiente >";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNombreDest);
            groupBox1.Controls.Add(txtNombreDest);
            groupBox1.Controls.Add(lblApellidoDest);
            groupBox1.Controls.Add(txtApellidoDest);
            groupBox1.Controls.Add(lblDNIDest);
            groupBox1.Controls.Add(txtDNIDest);
            groupBox1.Controls.Add(lblTelDest);
            groupBox1.Controls.Add(txtTelDest);
            groupBox1.Location = new Point(12, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 102);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "2. Datos del destinatario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNombreRem);
            groupBox2.Controls.Add(txtNombreRem);
            groupBox2.Controls.Add(lblApellidoRem);
            groupBox2.Controls.Add(txtApellidoRem);
            groupBox2.Controls.Add(lblDNIRem);
            groupBox2.Controls.Add(txtDNIRem);
            groupBox2.Controls.Add(lblTelRem);
            groupBox2.Controls.Add(txtTelRem);
            groupBox2.Controls.Add(lblCalleRem);
            groupBox2.Controls.Add(txtCalleRem);
            groupBox2.Controls.Add(lblAlturaRem);
            groupBox2.Controls.Add(txtAlturaRem);
            groupBox2.Controls.Add(lblPisoRem);
            groupBox2.Controls.Add(txtPisoRem);
            groupBox2.Location = new Point(12, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(718, 152);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "1. Datos del remitente";
            // 
            // ImposiciónCC_Particular
            // 
            BackColor = Color.White;
            ClientSize = new Size(738, 408);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(lblPaso);
            Controls.Add(btnVolver);
            Controls.Add(btnSiguiente);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCC_Particular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Datos del remitente (Particular)";
            Load += ImposiciónCC_Particular_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo, lblPaso, lblFecha, lblFechaValor;
        private System.Windows.Forms.Label lblNombreRem, lblApellidoRem, lblDNIRem, lblTelRem, lblCalleRem, lblAlturaRem, lblPisoRem;
        private System.Windows.Forms.TextBox txtNombreRem, txtApellidoRem, txtDNIRem, txtTelRem, txtCalleRem, txtAlturaRem, txtPisoRem;
        private System.Windows.Forms.Label lblNombreDest, lblApellidoDest, lblDNIDest, lblTelDest;
        private System.Windows.Forms.TextBox txtNombreDest, txtApellidoDest, txtDNIDest, txtTelDest;
        private System.Windows.Forms.Button btnVolver, btnSiguiente;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}