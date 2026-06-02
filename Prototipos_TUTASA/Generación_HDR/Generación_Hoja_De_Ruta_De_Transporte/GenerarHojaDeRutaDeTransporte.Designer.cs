namespace Prototipos_TUTASA.Generación_Hoja_De_Ruta_De_Transporte
{
    partial class GenerarHojaDeRutaDeTransporte
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
            cmbCDDestino = new ComboBox();
            lblCDDestino = new Label();
            lvGuiasPendientes = new ListView();
            colNumeroGuia = new ColumnHeader();
            colFechaGuia = new ColumnHeader();
            colTipoBultoLista = new ColumnHeader();
            lvServicios = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblBultos = new Label();
            txtBultos = new TextBox();
            btnGenerarHDR = new Button();
            gbxGuias = new GroupBox();
            gbxServicios = new GroupBox();
            btnCancelar = new Button();
            gbxGuias.SuspendLayout();
            gbxServicios.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCDDestino
            // 
            cmbCDDestino.FormattingEnabled = true;
            cmbCDDestino.Location = new Point(12, 20);
            cmbCDDestino.Margin = new Padding(1);
            cmbCDDestino.Name = "cmbCDDestino";
            cmbCDDestino.Size = new Size(102, 23);
            cmbCDDestino.TabIndex = 1;
            cmbCDDestino.SelectedIndexChanged += cmbCDDestino_SelectedIndexChanged;
            // 
            // lblCDDestino
            // 
            lblCDDestino.AutoSize = true;
            lblCDDestino.Location = new Point(12, 4);
            lblCDDestino.Margin = new Padding(1, 0, 1, 0);
            lblCDDestino.Name = "lblCDDestino";
            lblCDDestino.Size = new Size(66, 15);
            lblCDDestino.TabIndex = 0;
            lblCDDestino.Text = "CD Destino";
            // 
            // lvGuiasPendientes
            // 
            lvGuiasPendientes.CheckBoxes = true;
            lvGuiasPendientes.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colFechaGuia, colTipoBultoLista });
            lvGuiasPendientes.FullRowSelect = true;
            lvGuiasPendientes.Location = new Point(12, 77);
            lvGuiasPendientes.Name = "lvGuiasPendientes";
            lvGuiasPendientes.Size = new Size(926, 223);
            lvGuiasPendientes.TabIndex = 3;
            lvGuiasPendientes.UseCompatibleStateImageBehavior = false;
            lvGuiasPendientes.View = View.Details;
            lvGuiasPendientes.ItemChecked += lvGuiasPendientes_ItemChecked;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guia";
            colNumeroGuia.Width = 200;
            // 
            // colFechaGuia
            // 
            colFechaGuia.Text = "Fecha";
            colFechaGuia.Width = 200;
            // 
            // colTipoBultoLista
            // 
            colTipoBultoLista.Text = "Tipo de Bulto";
            colTipoBultoLista.Width = 200;
            // 
            // lvServicios
            // 
            lvServicios.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader3, columnHeader4 });
            lvServicios.FullRowSelect = true;
            lvServicios.Location = new Point(7, 20);
            lvServicios.MultiSelect = false;
            lvServicios.Name = "lvServicios";
            lvServicios.Size = new Size(926, 120);
            lvServicios.TabIndex = 0;
            lvServicios.UseCompatibleStateImageBehavior = false;
            lvServicios.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Servicio";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Empresa ";
            columnHeader2.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tipo de Servicio";
            columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Capacidad disp. (en tamaño S)";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Horario salida";
            columnHeader4.Width = 100;
            // 
            // lblBultos
            // 
            lblBultos.AutoSize = true;
            lblBultos.Location = new Point(17, 250);
            lblBultos.Margin = new Padding(1, 0, 1, 0);
            lblBultos.Name = "lblBultos";
            lblBultos.Size = new Size(185, 15);
            lblBultos.TabIndex = 0;
            lblBultos.Text = "Bultos seleccionados (equiv. en S)";
            // 
            // txtBultos
            // 
            txtBultos.Location = new Point(204, 247);
            txtBultos.Margin = new Padding(1);
            txtBultos.Name = "txtBultos";
            txtBultos.Size = new Size(81, 23);
            txtBultos.TabIndex = 1;
            // 
            // btnGenerarHDR
            // 
            btnGenerarHDR.Location = new Point(697, 492);
            btnGenerarHDR.Margin = new Padding(1);
            btnGenerarHDR.Name = "btnGenerarHDR";
            btnGenerarHDR.Size = new Size(111, 26);
            btnGenerarHDR.TabIndex = 5;
            btnGenerarHDR.Text = "Generar HDR";
            btnGenerarHDR.UseVisualStyleBackColor = true;
            btnGenerarHDR.Click += btnGenerarHDR_Click;
            // 
            // gbxGuias
            // 
            gbxGuias.Controls.Add(txtBultos);
            gbxGuias.Controls.Add(lblBultos);
            gbxGuias.Location = new Point(5, 57);
            gbxGuias.Margin = new Padding(1);
            gbxGuias.Name = "gbxGuias";
            gbxGuias.Padding = new Padding(1);
            gbxGuias.Size = new Size(937, 277);
            gbxGuias.TabIndex = 2;
            gbxGuias.TabStop = false;
            gbxGuias.Text = "Guias";
            // 
            // gbxServicios
            // 
            gbxServicios.Controls.Add(lvServicios);
            gbxServicios.Location = new Point(5, 343);
            gbxServicios.Margin = new Padding(1);
            gbxServicios.Name = "gbxServicios";
            gbxServicios.Padding = new Padding(1);
            gbxServicios.Size = new Size(937, 147);
            gbxServicios.TabIndex = 4;
            gbxServicios.TabStop = false;
            gbxServicios.Text = "Servicios disponibles";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(831, 492);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 26);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GenerarHojaDeRutaDeTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 528);
            Controls.Add(btnCancelar);
            Controls.Add(btnGenerarHDR);
            Controls.Add(lvGuiasPendientes);
            Controls.Add(lblCDDestino);
            Controls.Add(cmbCDDestino);
            Controls.Add(gbxGuias);
            Controls.Add(gbxServicios);
            Margin = new Padding(1);
            Name = "GenerarHojaDeRutaDeTransporte";
            Text = "Generar Hoja De Ruta De Transporte";
            Load += GenerarHojaDeRutaDeTransporte_Load;
            gbxGuias.ResumeLayout(false);
            gbxGuias.PerformLayout();
            gbxServicios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCDDestino;
        private Label lblCDDestino;
        private ListView lvGuiasPendientes;
        private ColumnHeader colNumeroGuia;
        private ColumnHeader colTipoBultoLista;
        private ColumnHeader colFechaGuia;
        private ListView lvServicios;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblBultos;
        private TextBox txtBultos;
        private ColumnHeader columnHeader4;
        private Button btnGenerarHDR;
        private ColumnHeader columnHeader5;
        private GroupBox gbxGuias;
        private GroupBox gbxServicios;
        private Button btnCancelar;
    }
}