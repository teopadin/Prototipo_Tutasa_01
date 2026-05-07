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
            lblTitulo = new Label();
            lblPaso = new Label();
            lblFecha = new Label();
            lblCDOrigen = new Label();
            cboCDOrigen = new ComboBox();
            lblCDDestino = new Label();
            cboCDDestino = new ComboBox();
            lblTipoBulto = new Label();
            cboTipoBulto = new ComboBox();
            lblTipoEntrega = new Label();
            cboTipoEntrega = new ComboBox();
            lblCalleEnt = new Label();
            txtCalleEnt = new TextBox();
            lblAlturaEnt = new Label();
            txtAlturaEnt = new TextBox();
            lblPisoEnt = new Label();
            txtPisoEnt = new TextBox();
            btnGenerar = new Button();
            lblSecGuias = new Label();
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
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(20, 9);
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
            lblPaso.Size = new Size(300, 20);
            lblPaso.TabIndex = 4;
            lblPaso.Text = "Paso 3 de 3 ";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(624, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(70, 27);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
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
            cboCDOrigen.Size = new Size(160, 23);
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
            cboCDDestino.Size = new Size(160, 23);
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
            cboTipoBulto.Size = new Size(153, 23);
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
            cboTipoEntrega.Size = new Size(200, 23);
            cboTipoEntrega.TabIndex = 14;
            // 
            // lblCalleEnt
            // 
            lblCalleEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblCalleEnt.Location = new Point(10, 32);
            lblCalleEnt.Name = "lblCalleEnt";
            lblCalleEnt.Size = new Size(100, 30);
            lblCalleEnt.TabIndex = 21;
            lblCalleEnt.Text = "Calle *";
            // 
            // txtCalleEnt
            // 
            txtCalleEnt.Location = new Point(10, 64);
            txtCalleEnt.Name = "txtCalleEnt";
            txtCalleEnt.Size = new Size(280, 23);
            txtCalleEnt.TabIndex = 22;
            // 
            // lblAlturaEnt
            // 
            lblAlturaEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblAlturaEnt.Location = new Point(310, 32);
            lblAlturaEnt.Name = "lblAlturaEnt";
            lblAlturaEnt.Size = new Size(80, 30);
            lblAlturaEnt.TabIndex = 23;
            lblAlturaEnt.Text = "Altura *";
            // 
            // txtAlturaEnt
            // 
            txtAlturaEnt.Location = new Point(310, 64);
            txtAlturaEnt.Name = "txtAlturaEnt";
            txtAlturaEnt.Size = new Size(90, 23);
            txtAlturaEnt.TabIndex = 24;
            // 
            // lblPisoEnt
            // 
            lblPisoEnt.ForeColor = Color.FromArgb(60, 60, 60);
            lblPisoEnt.Location = new Point(420, 32);
            lblPisoEnt.Name = "lblPisoEnt";
            lblPisoEnt.Size = new Size(100, 30);
            lblPisoEnt.TabIndex = 25;
            lblPisoEnt.Text = "Piso / Depto";
            // 
            // txtPisoEnt
            // 
            txtPisoEnt.Location = new Point(420, 64);
            txtPisoEnt.Name = "txtPisoEnt";
            txtPisoEnt.Size = new Size(120, 23);
            txtPisoEnt.TabIndex = 26;
            // 
            // btnGenerar
            // 
            btnGenerar.FlatStyle = FlatStyle.System;
            btnGenerar.Location = new Point(595, 828);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 34);
            btnGenerar.TabIndex = 30;
            btnGenerar.Text = "Generar Guía";
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblSecGuias
            // 
            lblSecGuias.Font = new Font("Segoe UI", 10F);
            lblSecGuias.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecGuias.Location = new Point(30, 652);
            lblSecGuias.Name = "lblSecGuias";
            lblSecGuias.Size = new Size(275, 41);
            lblSecGuias.TabIndex = 31;
            lblSecGuias.Text = "Guías generadas en la fecha";
            lblSecGuias.Click += lblSecGuias_Click;
            // 
            // lstGuias
            // 
            lstGuias.Columns.AddRange(new ColumnHeader[] { colTracking, colRemitente, colDestino, colTipo, colEntrega, colEstado });
            lstGuias.Font = new Font("Segoe UI", 9F);
            lstGuias.FullRowSelect = true;
            lstGuias.GridLines = true;
            lstGuias.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lstGuias.Location = new Point(30, 701);
            lstGuias.Name = "lstGuias";
            lstGuias.Size = new Size(822, 107);
            lstGuias.TabIndex = 33;
            lstGuias.UseCompatibleStateImageBehavior = false;
            lstGuias.View = View.Details;
            lstGuias.SelectedIndexChanged += lstGuias_SelectedIndexChanged;
            // 
            // colTracking
            // 
            colTracking.Text = "N° Tracking";
            colTracking.Width = 120;
            // 
            // colRemitente
            // 
            colRemitente.Text = "Cliente";
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
            lblFechaValor.Location = new Point(681, 25);
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
            groupBox1.Size = new Size(796, 135);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Datos del envío";
            // 
            // button1
            // 
            button1.Location = new Point(740, 828);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 36;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPisoEnt);
            groupBox2.Controls.Add(lblPisoEnt);
            groupBox2.Controls.Add(txtAlturaEnt);
            groupBox2.Controls.Add(lblAlturaEnt);
            groupBox2.Controls.Add(txtCalleEnt);
            groupBox2.Controls.Add(lblCalleEnt);
            groupBox2.Location = new Point(30, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(796, 118);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. Datos de entrega (Puerta a Puerta)";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(30, 384);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(796, 123);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "2. Datos de entrega (Retiro en Agencia)";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Agencia Flores", "Agencia Palermo", "Agencia Belgrano" });
            comboBox1.Location = new Point(6, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(534, 23);
            comboBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(60, 60, 60);
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 27;
            label1.Text = "Agencia *";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(30, 526);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(796, 123);
            groupBox4.TabIndex = 39;
            groupBox4.TabStop = false;
            groupBox4.Text = "2. Datos de entrega (Retiro en Centro de Distribución)";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { "Agencia Flores", "Agencia Palermo", "Agencia Belgrano" });
            comboBox2.Location = new Point(6, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(534, 23);
            comboBox2.TabIndex = 28;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(219, 30);
            label2.TabIndex = 27;
            label2.Text = "Centro de Distribución *";
            label2.Click += label2_Click;
            // 
            // ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular
            // 
            BackColor = Color.White;
            ClientSize = new Size(871, 749);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(lblFechaValor);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblPaso);
            Controls.Add(btnGenerar);
            Controls.Add(lblSecGuias);
            Controls.Add(lstGuias);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Datos del envío y Generación de Guía";
            Load += ImposiciónCallCenter_Pantalla3_ClienteEmpresayParticular_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblCDOrigen, lblCDDestino, lblTipoBulto, lblTipoEntrega;
        private System.Windows.Forms.ComboBox cboCDOrigen, cboCDDestino, cboTipoBulto, cboTipoEntrega;
        private System.Windows.Forms.TextBox txtCalleEnt, txtAlturaEnt, txtPisoEnt;
        private System.Windows.Forms.ListView lstGuias;
        private System.Windows.Forms.ColumnHeader colTracking, colRemitente, colDestino, colTipo, colEntrega, colEstado;
        private Label lblFechaValor;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox4;
        private ComboBox comboBox2;
        private Label label2;
        private Label lblTitulo, lblPaso, lblFecha, lblSecGuias, lblCalleEnt, lblAlturaEnt, lblPisoEnt;
        private Button btnGenerar;
    }
}