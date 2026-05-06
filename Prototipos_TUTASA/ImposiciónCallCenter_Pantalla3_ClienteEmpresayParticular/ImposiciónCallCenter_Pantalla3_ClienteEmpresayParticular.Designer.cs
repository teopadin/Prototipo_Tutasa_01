namespace Prototipos_TUTASA
{
    partial class ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "TRK-00480", "Acme SA", "Córdoba", "M", "Puerta a Puerta", "Pendiente de admisión" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "TRK-00481", "García, Lucía", "Rosario", "S", "Retiro en CD", "Pendiente de admisión" }, -1);
            this.lblTitulo = new Label();
            this.lblPaso = new Label();
            this.lblFecha = new Label();
            this.pnlSep1 = new Panel();
            lblCDOrigen = new Label();
            cboCDOrigen = new ComboBox();
            lblCDDestino = new Label();
            cboCDDestino = new ComboBox();
            lblTipoBulto = new Label();
            cboTipoBulto = new ComboBox();
            lblTipoEntrega = new Label();
            cboTipoEntrega = new ComboBox();
            this.lblSecDireccion = new Label();
            lblCalleEnt = new Label();
            txtCalleEnt = new TextBox();
            lblAlturaEnt = new Label();
            txtAlturaEnt = new TextBox();
            lblPisoEnt = new Label();
            txtPisoEnt = new TextBox();
            lblAgencia = new Label();
            cboAgencia = new ComboBox();
            btnVolver = new Button();
            btnGenerar = new Button();
            this.lblSecGuias = new Label();
            this.pnlSepGuias = new Panel();
            lstGuias = new ListView();
            colTracking = new ColumnHeader();
            colRemitente = new ColumnHeader();
            colDestino = new ColumnHeader();
            colTipo = new ColumnHeader();
            colEntrega = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblFechaValor = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new Font("Segoe UI", 16F);
            this.lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblTitulo.Location = new Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(400, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Imposición en Call Center";
            // 
            // lblPaso
            // 
            this.lblPaso.Font = new Font("Segoe UI", 9F);
            this.lblPaso.ForeColor = Color.Gray;
            this.lblPaso.Location = new Point(30, 73);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new Size(300, 20);
            this.lblPaso.TabIndex = 4;
            this.lblPaso.Text = "Paso 3 de 3 ";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = Color.Gray;
            this.lblFecha.Location = new Point(730, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new Size(70, 27);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // pnlSep1
            // 
            this.pnlSep1.BackColor = Color.FromArgb(220, 220, 220);
            this.pnlSep1.Location = new Point(30, 63);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new Size(840, 1);
            this.pnlSep1.TabIndex = 3;
            // 
            // lblCDOrigen
            // 
            lblCDOrigen.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDOrigen.Location = new Point(17, 42);
            lblCDOrigen.Name = "lblCDOrigen";
            lblCDOrigen.Size = new Size(130, 26);
            lblCDOrigen.TabIndex = 7;
            lblCDOrigen.Text = "CD Origen *";
            // 
            // cboCDOrigen
            // 
            cboCDOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCDOrigen.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });
            cboCDOrigen.Location = new Point(17, 70);
            cboCDOrigen.Name = "cboCDOrigen";
            cboCDOrigen.Size = new Size(160, 33);
            cboCDOrigen.TabIndex = 8;
            // 
            // lblCDDestino
            // 
            lblCDDestino.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDDestino.Location = new Point(197, 42);
            lblCDDestino.Name = "lblCDDestino";
            lblCDDestino.Size = new Size(130, 26);
            lblCDDestino.TabIndex = 9;
            lblCDDestino.Text = "CD Destino *";
            // 
            // cboCDDestino
            // 
            cboCDDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCDDestino.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });
            cboCDDestino.Location = new Point(197, 70);
            cboCDDestino.Name = "cboCDDestino";
            cboCDDestino.Size = new Size(160, 33);
            cboCDDestino.TabIndex = 10;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoBulto.Location = new Point(377, 42);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(130, 26);
            lblTipoBulto.TabIndex = 11;
            lblTipoBulto.Text = "Tipo de bulto *";
            // 
            // cboTipoBulto
            // 
            cboTipoBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoBulto.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            cboTipoBulto.Location = new Point(377, 70);
            cboTipoBulto.Name = "cboTipoBulto";
            cboTipoBulto.Size = new Size(153, 33);
            cboTipoBulto.TabIndex = 12;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoEntrega.Location = new Point(550, 41);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(150, 26);
            lblTipoEntrega.TabIndex = 13;
            lblTipoEntrega.Text = "Tipo de entrega *";
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEntrega.Items.AddRange(new object[] { "Retiro en CD", "Retiro en Agencia", "Puerta a Puerta" });
            cboTipoEntrega.Location = new Point(550, 70);
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(200, 33);
            cboTipoEntrega.TabIndex = 14;
            // 
            // lblSecDireccion
            // 
            this.lblSecDireccion.Font = new Font("Segoe UI", 10F);
            this.lblSecDireccion.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblSecDireccion.Location = new Point(30, 257);
            this.lblSecDireccion.Name = "lblSecDireccion";
            this.lblSecDireccion.Size = new Size(500, 35);
            this.lblSecDireccion.TabIndex = 19;
            this.lblSecDireccion.Text = "2. Datos de entrega  (según tipo seleccionado)";
            // 
            // lblCalleEnt
            // 
            lblCalleEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCalleEnt.Location = new Point(30, 295);
            lblCalleEnt.Name = "lblCalleEnt";
            lblCalleEnt.Size = new Size(100, 30);
            lblCalleEnt.TabIndex = 21;
            lblCalleEnt.Text = "Calle *";
            // 
            // txtCalleEnt
            // 
            txtCalleEnt.Location = new Point(30, 327);
            txtCalleEnt.Name = "txtCalleEnt";
            txtCalleEnt.Size = new Size(280, 31);
            txtCalleEnt.TabIndex = 22;
            // 
            // lblAlturaEnt
            // 
            lblAlturaEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblAlturaEnt.Location = new Point(330, 295);
            lblAlturaEnt.Name = "lblAlturaEnt";
            lblAlturaEnt.Size = new Size(80, 30);
            lblAlturaEnt.TabIndex = 23;
            lblAlturaEnt.Text = "Altura *";
            // 
            // txtAlturaEnt
            // 
            txtAlturaEnt.Location = new Point(330, 327);
            txtAlturaEnt.Name = "txtAlturaEnt";
            txtAlturaEnt.Size = new Size(90, 31);
            txtAlturaEnt.TabIndex = 24;
            // 
            // lblPisoEnt
            // 
            lblPisoEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblPisoEnt.Location = new Point(440, 295);
            lblPisoEnt.Name = "lblPisoEnt";
            lblPisoEnt.Size = new Size(100, 30);
            lblPisoEnt.TabIndex = 25;
            lblPisoEnt.Text = "Piso / Depto";
            // 
            // txtPisoEnt
            // 
            txtPisoEnt.Location = new Point(440, 327);
            txtPisoEnt.Name = "txtPisoEnt";
            txtPisoEnt.Size = new Size(120, 31);
            txtPisoEnt.TabIndex = 26;
            // 
            // lblAgencia
            // 
            lblAgencia.ForeColor = Color.FromArgb(60, 60, 60);
            lblAgencia.Location = new Point(580, 295);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(100, 30);
            lblAgencia.TabIndex = 27;
            lblAgencia.Text = "Agencia *";
            // 
            // cboAgencia
            // 
            cboAgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgencia.Items.AddRange(new object[] { "Agencia Flores", "Agencia Palermo", "Agencia Belgrano" });
            cboAgencia.Location = new Point(580, 327);
            cboAgencia.Name = "cboAgencia";
            cboAgencia.Size = new Size(220, 33);
            cboAgencia.TabIndex = 28;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.ForeColor = Color.FromArgb(80, 80, 80);
            btnVolver.Location = new Point(30, 372);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 29;
            btnVolver.Text = "< Volver";
            // 
            // btnGenerar
            // 
            btnGenerar.FlatStyle = FlatStyle.System;
            btnGenerar.Location = new Point(760, 706);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 34);
            btnGenerar.TabIndex = 30;
            btnGenerar.Text = "Generar Guía";
            btnGenerar.Click += this.btnGenerar_Click;
            // 
            // lblSecGuias
            // 
            this.lblSecGuias.Font = new Font("Segoe UI", 10F);
            this.lblSecGuias.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblSecGuias.Location = new Point(30, 425);
            this.lblSecGuias.Name = "lblSecGuias";
            this.lblSecGuias.Size = new Size(300, 22);
            this.lblSecGuias.TabIndex = 31;
            this.lblSecGuias.Text = "Guías generadas hoy";
            // 
            // pnlSepGuias
            // 
            this.pnlSepGuias.BackColor = Color.FromArgb(220, 220, 220);
            this.pnlSepGuias.Location = new Point(30, 450);
            this.pnlSepGuias.Name = "pnlSepGuias";
            this.pnlSepGuias.Size = new Size(840, 1);
            this.pnlSepGuias.TabIndex = 32;
            // 
            // lstGuias
            // 
            lstGuias.Columns.AddRange(new ColumnHeader[] { colTracking, colRemitente, colDestino, colTipo, colEntrega, colEstado });
            lstGuias.Font = new Font("Segoe UI", 9F);
            lstGuias.FullRowSelect = true;
            lstGuias.GridLines = true;
            lstGuias.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lstGuias.Location = new Point(30, 460);
            lstGuias.Name = "lstGuias";
            lstGuias.Size = new Size(871, 175);
            lstGuias.TabIndex = 33;
            lstGuias.UseCompatibleStateImageBehavior = false;
            lstGuias.View = View.Details;
            // 
            // colTracking
            // 
            colTracking.Text = "N° Tracking";
            colTracking.Width = 120;
            // 
            // colRemitente
            // 
            colRemitente.Text = "Remitente";
            colRemitente.Width = 180;
            // 
            // colDestino
            // 
            colDestino.Text = "CD Destino";
            colDestino.Width = 110;
            // 
            // colTipo
            // 
            colTipo.Text = "Tipo bulto";
            colTipo.Width = 90;
            // 
            // colEntrega
            // 
            colEntrega.Text = "Tipo entrega";
            colEntrega.Width = 140;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 160;
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(795, 28);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(145, 23);
            lblFechaValor.TabIndex = 34;
            lblFechaValor.Text = "dd/mm/aaaa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTipoEntrega);
            groupBox1.Controls.Add(cboTipoEntrega);
            groupBox1.Controls.Add(cboTipoBulto);
            groupBox1.Controls.Add(lblTipoBulto);
            groupBox1.Controls.Add(cboCDDestino);
            groupBox1.Controls.Add(lblCDDestino);
            groupBox1.Controls.Add(lblCDOrigen);
            groupBox1.Controls.Add(cboCDOrigen);
            groupBox1.Location = new Point(30, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 135);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Datos del envío";
            // 
            // button1
            // 
            button1.Location = new Point(900, 706);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 36;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(829, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular
            // 
            BackColor = Color.White;
            ClientSize = new Size(1024, 856);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(lblFechaValor);
            Controls.Add(this.lblTitulo);
            Controls.Add(this.lblFecha);
            Controls.Add(this.pnlSep1);
            Controls.Add(this.lblPaso);
            Controls.Add(this.lblSecDireccion);
            Controls.Add(lblCalleEnt);
            Controls.Add(txtCalleEnt);
            Controls.Add(lblAlturaEnt);
            Controls.Add(txtAlturaEnt);
            Controls.Add(lblPisoEnt);
            Controls.Add(txtPisoEnt);
            Controls.Add(lblAgencia);
            Controls.Add(cboAgencia);
            Controls.Add(btnVolver);
            Controls.Add(btnGenerar);
            Controls.Add(this.lblSecGuias);
            Controls.Add(this.pnlSepGuias);
            Controls.Add(lstGuias);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Datos del envío y Generación de Guía";
            Load += this.ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Label lblCDOrigen, lblCDDestino, lblTipoBulto, lblTipoEntrega;
        private System.Windows.Forms.ComboBox cboCDOrigen, cboCDDestino, cboTipoBulto, cboTipoEntrega;
        private System.Windows.Forms.Label lblCalleEnt, lblAlturaEnt, lblPisoEnt, lblAgencia;
        private System.Windows.Forms.TextBox txtCalleEnt, txtAlturaEnt, txtPisoEnt;
        private System.Windows.Forms.ComboBox cboAgencia;
        private System.Windows.Forms.Button btnVolver, btnGenerar;
        private System.Windows.Forms.ListView lstGuias;
        private System.Windows.Forms.ColumnHeader colTracking, colRemitente, colDestino, colTipo, colEntrega, colEstado;
        private Label lblFechaValor;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
    }
}