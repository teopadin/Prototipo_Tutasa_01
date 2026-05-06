namespace Prototipos_TUTASA
{
    partial class ImposiciónCC_DatosEnvio
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
            lblFechaValor = new Label();
            pnlSep1 = new Panel();
            lblSecEnvio = new Label();
            pnlSepEnvio = new Panel();
            lblCDOrigen = new Label();
            cboCDOrigen = new ComboBox();
            lblCDDestino = new Label();
            cboCDDestino = new ComboBox();
            lblTipoBulto = new Label();
            cboTipoBulto = new ComboBox();
            lblTipoEntrega = new Label();
            cboTipoEntrega = new ComboBox();
            lblContenido = new Label();
            txtContenido = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblSecDireccion = new Label();
            pnlSepDir = new Panel();
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
            lblSecGuias = new Label();
            pnlSepGuias = new Panel();
            lstGuias = new ListView();
            colTracking = new ColumnHeader();
            colRemitente = new ColumnHeader();
            colDestino = new ColumnHeader();
            colTipo = new ColumnHeader();
            colEntrega = new ColumnHeader();
            colEstado = new ColumnHeader();
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
            lblPaso.Size = new Size(300, 20);
            lblPaso.TabIndex = 4;
            lblPaso.Text = "Paso 3 de 4  —  Datos del envío";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(730, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(778, 28);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(131, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "06/05/2026";
            // 
            // pnlSep1
            // 
            pnlSep1.BackColor = Color.FromArgb(220, 220, 220);
            pnlSep1.Location = new Point(30, 63);
            pnlSep1.Name = "pnlSep1";
            pnlSep1.Size = new Size(840, 1);
            pnlSep1.TabIndex = 3;
            // 
            // lblSecEnvio
            // 
            lblSecEnvio.Font = new Font("Segoe UI", 10F);
            lblSecEnvio.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecEnvio.Location = new Point(30, 93);
            lblSecEnvio.Name = "lblSecEnvio";
            lblSecEnvio.Size = new Size(300, 32);
            lblSecEnvio.TabIndex = 5;
            lblSecEnvio.Text = "1. Datos del envío";
            // 
            // pnlSepEnvio
            // 
            pnlSepEnvio.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepEnvio.Location = new Point(30, 128);
            pnlSepEnvio.Name = "pnlSepEnvio";
            pnlSepEnvio.Size = new Size(840, 1);
            pnlSepEnvio.TabIndex = 6;
            // 
            // lblCDOrigen
            // 
            lblCDOrigen.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDOrigen.Location = new Point(30, 132);
            lblCDOrigen.Name = "lblCDOrigen";
            lblCDOrigen.Size = new Size(130, 26);
            lblCDOrigen.TabIndex = 7;
            lblCDOrigen.Text = "CD Origen *";
            // 
            // cboCDOrigen
            // 
            cboCDOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCDOrigen.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });
            cboCDOrigen.Location = new Point(30, 160);
            cboCDOrigen.Name = "cboCDOrigen";
            cboCDOrigen.Size = new Size(160, 33);
            cboCDOrigen.TabIndex = 8;
            // 
            // lblCDDestino
            // 
            lblCDDestino.ForeColor = Color.FromArgb(60, 60, 60);
            lblCDDestino.Location = new Point(210, 132);
            lblCDDestino.Name = "lblCDDestino";
            lblCDDestino.Size = new Size(130, 26);
            lblCDDestino.TabIndex = 9;
            lblCDDestino.Text = "CD Destino *";
            // 
            // cboCDDestino
            // 
            cboCDDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCDDestino.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });
            cboCDDestino.Location = new Point(210, 160);
            cboCDDestino.Name = "cboCDDestino";
            cboCDDestino.Size = new Size(160, 33);
            cboCDDestino.TabIndex = 10;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoBulto.Location = new Point(390, 132);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(130, 26);
            lblTipoBulto.TabIndex = 11;
            lblTipoBulto.Text = "Tipo de bulto *";
            // 
            // cboTipoBulto
            // 
            cboTipoBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoBulto.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            cboTipoBulto.Location = new Point(390, 160);
            cboTipoBulto.Name = "cboTipoBulto";
            cboTipoBulto.Size = new Size(120, 33);
            cboTipoBulto.TabIndex = 12;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.ForeColor = Color.FromArgb(60, 60, 60);
            lblTipoEntrega.Location = new Point(530, 132);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(150, 26);
            lblTipoEntrega.TabIndex = 13;
            lblTipoEntrega.Text = "Tipo de entrega *";
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEntrega.Items.AddRange(new object[] { "Retiro en CD", "Retiro en Agencia", "Puerta a Puerta" });
            cboTipoEntrega.Location = new Point(530, 160);
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(200, 33);
            cboTipoEntrega.TabIndex = 14;
            // 
            // lblContenido
            // 
            lblContenido.ForeColor = Color.FromArgb(60, 60, 60);
            lblContenido.Location = new Point(30, 196);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(180, 25);
            lblContenido.TabIndex = 15;
            lblContenido.Text = "Contenido declarado *";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(30, 223);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(300, 31);
            txtContenido.TabIndex = 16;
            // 
            // lblValor
            // 
            lblValor.ForeColor = Color.FromArgb(60, 60, 60);
            lblValor.Location = new Point(350, 196);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(150, 25);
            lblValor.TabIndex = 17;
            lblValor.Text = "Valor declarado *";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(350, 223);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 18;
            // 
            // lblSecDireccion
            // 
            lblSecDireccion.Font = new Font("Segoe UI", 10F);
            lblSecDireccion.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecDireccion.Location = new Point(30, 257);
            lblSecDireccion.Name = "lblSecDireccion";
            lblSecDireccion.Size = new Size(500, 35);
            lblSecDireccion.TabIndex = 19;
            lblSecDireccion.Text = "2. Datos de entrega  (según tipo seleccionado)";
            // 
            // pnlSepDir
            // 
            pnlSepDir.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepDir.Location = new Point(30, 295);
            pnlSepDir.Name = "pnlSepDir";
            pnlSepDir.Size = new Size(840, 1);
            pnlSepDir.TabIndex = 20;
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
            btnGenerar.Location = new Point(750, 372);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 32);
            btnGenerar.TabIndex = 30;
            btnGenerar.Text = "Generar guía";
            // 
            // lblSecGuias
            // 
            lblSecGuias.Font = new Font("Segoe UI", 10F);
            lblSecGuias.ForeColor = Color.FromArgb(30, 30, 30);
            lblSecGuias.Location = new Point(30, 425);
            lblSecGuias.Name = "lblSecGuias";
            lblSecGuias.Size = new Size(300, 22);
            lblSecGuias.TabIndex = 31;
            lblSecGuias.Text = "Guías generadas hoy";
            // 
            // pnlSepGuias
            // 
            pnlSepGuias.BackColor = Color.FromArgb(220, 220, 220);
            pnlSepGuias.Location = new Point(30, 450);
            pnlSepGuias.Name = "pnlSepGuias";
            pnlSepGuias.Size = new Size(840, 1);
            pnlSepGuias.TabIndex = 32;
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
            // ImposiciónCC_DatosEnvio
            // 
            BackColor = Color.White;
            ClientSize = new Size(1024, 624);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(pnlSep1);
            Controls.Add(lblPaso);
            Controls.Add(lblSecEnvio);
            Controls.Add(pnlSepEnvio);
            Controls.Add(lblCDOrigen);
            Controls.Add(cboCDOrigen);
            Controls.Add(lblCDDestino);
            Controls.Add(cboCDDestino);
            Controls.Add(lblTipoBulto);
            Controls.Add(cboTipoBulto);
            Controls.Add(lblTipoEntrega);
            Controls.Add(cboTipoEntrega);
            Controls.Add(lblContenido);
            Controls.Add(txtContenido);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblSecDireccion);
            Controls.Add(pnlSepDir);
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
            Controls.Add(lblSecGuias);
            Controls.Add(pnlSepGuias);
            Controls.Add(lstGuias);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCC_DatosEnvio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Datos del envío y generación de guía";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo, lblPaso, lblFecha, lblFechaValor;
        private System.Windows.Forms.Panel pnlSep1, pnlSepEnvio, pnlSepDir, pnlSepGuias;
        private System.Windows.Forms.Label lblSecEnvio, lblSecDireccion, lblSecGuias;
        private System.Windows.Forms.Label lblCDOrigen, lblCDDestino, lblTipoBulto, lblTipoEntrega;
        private System.Windows.Forms.ComboBox cboCDOrigen, cboCDDestino, cboTipoBulto, cboTipoEntrega;
        private System.Windows.Forms.Label lblContenido, lblValor;
        private System.Windows.Forms.TextBox txtContenido, txtValor;
        private System.Windows.Forms.Label lblCalleEnt, lblAlturaEnt, lblPisoEnt, lblAgencia;
        private System.Windows.Forms.TextBox txtCalleEnt, txtAlturaEnt, txtPisoEnt;
        private System.Windows.Forms.ComboBox cboAgencia;
        private System.Windows.Forms.Button btnVolver, btnGenerar;
        private System.Windows.Forms.ListView lstGuias;
        private System.Windows.Forms.ColumnHeader colTracking, colRemitente, colDestino, colTipo, colEntrega, colEstado;
    }
}