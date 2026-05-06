namespace Prototipos_TUTASA
{
    partial class Imposición_DatosEnvio
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPaso = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.pnlSep1 = new System.Windows.Forms.Panel();

            // Datos del envío
            this.lblSecEnvio = new System.Windows.Forms.Label();
            this.pnlSepEnvio = new System.Windows.Forms.Panel();
            this.lblCDOrigen = new System.Windows.Forms.Label();
            this.cboCDOrigen = new System.Windows.Forms.ComboBox();
            this.lblCDDestino = new System.Windows.Forms.Label();
            this.cboCDDestino = new System.Windows.Forms.ComboBox();
            this.lblTipoBulto = new System.Windows.Forms.Label();
            this.cboTipoBulto = new System.Windows.Forms.ComboBox();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.cboTipoEntrega = new System.Windows.Forms.ComboBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();

            // Dirección condicional
            this.lblSecDireccion = new System.Windows.Forms.Label();
            this.pnlSepDir = new System.Windows.Forms.Panel();
            this.lblCalleEnt = new System.Windows.Forms.Label();
            this.txtCalleEnt = new System.Windows.Forms.TextBox();
            this.lblAlturaEnt = new System.Windows.Forms.Label();
            this.txtAlturaEnt = new System.Windows.Forms.TextBox();
            this.lblPisoEnt = new System.Windows.Forms.Label();
            this.txtPisoEnt = new System.Windows.Forms.TextBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.cboAgencia = new System.Windows.Forms.ComboBox();

            // Botones acción
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();

            // Sección guías generadas
            this.lblSecGuias = new System.Windows.Forms.Label();
            this.pnlSepGuias = new System.Windows.Forms.Panel();
            this.lstGuias = new System.Windows.Forms.ListView();
            this.colTracking = new System.Windows.Forms.ColumnHeader();
            this.colRemitente = new System.Windows.Forms.ColumnHeader();
            this.colDestino = new System.Windows.Forms.ColumnHeader();
            this.colTipo = new System.Windows.Forms.ColumnHeader();
            this.colEntrega = new System.Windows.Forms.ColumnHeader();
            this.colEstado = new System.Windows.Forms.ColumnHeader();

            this.SuspendLayout();

            this.Text = "Imposición - Datos del envío y generación de guía";
            this.Size = new System.Drawing.Size(900, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Encabezado
            this.lblTitulo.Text = "Imposición en Call Center";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Size = new System.Drawing.Size(400, 35);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);

            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(730, 28);
            this.lblFecha.Size = new System.Drawing.Size(45, 20);

            this.lblFechaValor.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            this.lblFechaValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaValor.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblFechaValor.Location = new System.Drawing.Point(778, 28);
            this.lblFechaValor.Size = new System.Drawing.Size(90, 20);

            this.pnlSep1.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlSep1.Location = new System.Drawing.Point(30, 63);
            this.pnlSep1.Size = new System.Drawing.Size(840, 1);

            this.lblPaso.Text = "Paso 3 de 4  —  Datos del envío";
            this.lblPaso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaso.ForeColor = System.Drawing.Color.Gray;
            this.lblPaso.Location = new System.Drawing.Point(30, 73);
            this.lblPaso.Size = new System.Drawing.Size(300, 20);

            // Sección envío
            this.lblSecEnvio.Text = "1. Datos del envío";
            this.lblSecEnvio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSecEnvio.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblSecEnvio.Location = new System.Drawing.Point(30, 103);
            this.lblSecEnvio.Size = new System.Drawing.Size(300, 22);

            this.pnlSepEnvio.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlSepEnvio.Location = new System.Drawing.Point(30, 128);
            this.pnlSepEnvio.Size = new System.Drawing.Size(840, 1);

            // Fila 1
            this.lblCDOrigen.Text = "CD Origen *";
            this.lblCDOrigen.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCDOrigen.Location = new System.Drawing.Point(30, 140);
            this.lblCDOrigen.Size = new System.Drawing.Size(130, 18);

            this.cboCDOrigen.Location = new System.Drawing.Point(30, 160);
            this.cboCDOrigen.Size = new System.Drawing.Size(160, 24);
            this.cboCDOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCDOrigen.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });

            this.lblCDDestino.Text = "CD Destino *";
            this.lblCDDestino.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCDDestino.Location = new System.Drawing.Point(210, 140);
            this.lblCDDestino.Size = new System.Drawing.Size(130, 18);

            this.cboCDDestino.Location = new System.Drawing.Point(210, 160);
            this.cboCDDestino.Size = new System.Drawing.Size(160, 24);
            this.cboCDDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCDDestino.Items.AddRange(new object[] { "CABA", "GBA Norte", "GBA Sur", "Rosario", "Córdoba", "Mendoza" });

            this.lblTipoBulto.Text = "Tipo de bulto *";
            this.lblTipoBulto.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblTipoBulto.Location = new System.Drawing.Point(390, 140);
            this.lblTipoBulto.Size = new System.Drawing.Size(130, 18);

            this.cboTipoBulto.Location = new System.Drawing.Point(390, 160);
            this.cboTipoBulto.Size = new System.Drawing.Size(120, 24);
            this.cboTipoBulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBulto.Items.AddRange(new object[] { "S", "M", "L", "XL" });

            this.lblTipoEntrega.Text = "Tipo de entrega *";
            this.lblTipoEntrega.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblTipoEntrega.Location = new System.Drawing.Point(530, 140);
            this.lblTipoEntrega.Size = new System.Drawing.Size(150, 18);

            this.cboTipoEntrega.Location = new System.Drawing.Point(530, 160);
            this.cboTipoEntrega.Size = new System.Drawing.Size(200, 24);
            this.cboTipoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEntrega.Items.AddRange(new object[] { "Retiro en CD", "Retiro en Agencia", "Puerta a Puerta" });

            // Fila 2
            this.lblContenido.Text = "Contenido declarado *";
            this.lblContenido.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblContenido.Location = new System.Drawing.Point(30, 203);
            this.lblContenido.Size = new System.Drawing.Size(180, 18);

            this.txtContenido.Location = new System.Drawing.Point(30, 223);
            this.txtContenido.Size = new System.Drawing.Size(300, 24);

            this.lblValor.Text = "Valor declarado *";
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblValor.Location = new System.Drawing.Point(350, 203);
            this.lblValor.Size = new System.Drawing.Size(150, 18);

            this.txtValor.Location = new System.Drawing.Point(350, 223);
            this.txtValor.Size = new System.Drawing.Size(150, 24);

            // Sección condicional — dirección / agencia
            this.lblSecDireccion.Text = "2. Datos de entrega  (según tipo seleccionado)";
            this.lblSecDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSecDireccion.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblSecDireccion.Location = new System.Drawing.Point(30, 270);
            this.lblSecDireccion.Size = new System.Drawing.Size(500, 22);

            this.pnlSepDir.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlSepDir.Location = new System.Drawing.Point(30, 295);
            this.pnlSepDir.Size = new System.Drawing.Size(840, 1);

            this.lblCalleEnt.Text = "Calle *";
            this.lblCalleEnt.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCalleEnt.Location = new System.Drawing.Point(30, 307);
            this.lblCalleEnt.Size = new System.Drawing.Size(100, 18);

            this.txtCalleEnt.Location = new System.Drawing.Point(30, 327);
            this.txtCalleEnt.Size = new System.Drawing.Size(280, 24);

            this.lblAlturaEnt.Text = "Altura *";
            this.lblAlturaEnt.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAlturaEnt.Location = new System.Drawing.Point(330, 307);
            this.lblAlturaEnt.Size = new System.Drawing.Size(80, 18);

            this.txtAlturaEnt.Location = new System.Drawing.Point(330, 327);
            this.txtAlturaEnt.Size = new System.Drawing.Size(90, 24);

            this.lblPisoEnt.Text = "Piso / Depto";
            this.lblPisoEnt.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblPisoEnt.Location = new System.Drawing.Point(440, 307);
            this.lblPisoEnt.Size = new System.Drawing.Size(100, 18);

            this.txtPisoEnt.Location = new System.Drawing.Point(440, 327);
            this.txtPisoEnt.Size = new System.Drawing.Size(120, 24);

            this.lblAgencia.Text = "Agencia *";
            this.lblAgencia.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAgencia.Location = new System.Drawing.Point(580, 307);
            this.lblAgencia.Size = new System.Drawing.Size(100, 18);

            this.cboAgencia.Location = new System.Drawing.Point(580, 327);
            this.cboAgencia.Size = new System.Drawing.Size(220, 24);
            this.cboAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgencia.Items.AddRange(new object[] { "Agencia Flores", "Agencia Palermo", "Agencia Belgrano" });

            // Botones
            this.btnVolver.Text = "< Volver";
            this.btnVolver.Location = new System.Drawing.Point(30, 372);
            this.btnVolver.Size = new System.Drawing.Size(100, 32);
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            this.btnGenerar.Text = "Generar guía";
            this.btnGenerar.Location = new System.Drawing.Point(750, 372);
            this.btnGenerar.Size = new System.Drawing.Size(120, 32);
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.System;

            // Sección guías del día
            this.lblSecGuias.Text = "Guías generadas hoy";
            this.lblSecGuias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSecGuias.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblSecGuias.Location = new System.Drawing.Point(30, 425);
            this.lblSecGuias.Size = new System.Drawing.Size(300, 22);

            this.pnlSepGuias.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.pnlSepGuias.Location = new System.Drawing.Point(30, 450);
            this.pnlSepGuias.Size = new System.Drawing.Size(840, 1);

            // ListView guías
            this.lstGuias.Location = new System.Drawing.Point(30, 460);
            this.lstGuias.Size = new System.Drawing.Size(840, 175);
            this.lstGuias.View = System.Windows.Forms.View.Details;
            this.lstGuias.FullRowSelect = true;
            this.lstGuias.GridLines = true;
            this.lstGuias.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.colTracking.Text = "N° Tracking";
            this.colTracking.Width = 120;
            this.colRemitente.Text = "Remitente";
            this.colRemitente.Width = 180;
            this.colDestino.Text = "CD Destino";
            this.colDestino.Width = 110;
            this.colTipo.Text = "Tipo bulto";
            this.colTipo.Width = 90;
            this.colEntrega.Text = "Tipo entrega";
            this.colEntrega.Width = 140;
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 160;

            this.lstGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colTracking, this.colRemitente, this.colDestino,
                this.colTipo, this.colEntrega, this.colEstado });

            // Datos de ejemplo
            var item1 = new System.Windows.Forms.ListViewItem("TRK-00480");
            item1.SubItems.Add("Acme SA");
            item1.SubItems.Add("Córdoba");
            item1.SubItems.Add("M");
            item1.SubItems.Add("Puerta a Puerta");
            item1.SubItems.Add("Pendiente de admisión");
            this.lstGuias.Items.Add(item1);

            var item2 = new System.Windows.Forms.ListViewItem("TRK-00481");
            item2.SubItems.Add("García, Lucía");
            item2.SubItems.Add("Rosario");
            item2.SubItems.Add("S");
            item2.SubItems.Add("Retiro en CD");
            item2.SubItems.Add("Pendiente de admisión");
            this.lstGuias.Items.Add(item2);

            // Agregar controles
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.pnlSep1);
            this.Controls.Add(this.lblPaso);
            this.Controls.Add(this.lblSecEnvio);
            this.Controls.Add(this.pnlSepEnvio);
            this.Controls.Add(this.lblCDOrigen);
            this.Controls.Add(this.cboCDOrigen);
            this.Controls.Add(this.lblCDDestino);
            this.Controls.Add(this.cboCDDestino);
            this.Controls.Add(this.lblTipoBulto);
            this.Controls.Add(this.cboTipoBulto);
            this.Controls.Add(this.lblTipoEntrega);
            this.Controls.Add(this.cboTipoEntrega);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblSecDireccion);
            this.Controls.Add(this.pnlSepDir);
            this.Controls.Add(this.lblCalleEnt);
            this.Controls.Add(this.txtCalleEnt);
            this.Controls.Add(this.lblAlturaEnt);
            this.Controls.Add(this.txtAlturaEnt);
            this.Controls.Add(this.lblPisoEnt);
            this.Controls.Add(this.txtPisoEnt);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.cboAgencia);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblSecGuias);
            this.Controls.Add(this.pnlSepGuias);
            this.Controls.Add(this.lstGuias);

            this.ResumeLayout(false);
            this.PerformLayout();
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