namespace Prototipos_TUTASA.GeneracionHoja_DeRutaRetiro_v2
{
    partial class GeneracionHojaDeRutaRetiro_v2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblEstado = new Label();
            lblCdEmisor = new Label();
            txtCdEmisor = new TextBox();
            lblFletero = new Label();
            lblGuiasPendientes = new Label();
            lvGuiasPendientes = new ListView();
            colNumeroGuia = new ColumnHeader();
            colFechaGuia = new ColumnHeader();
            colRemitenteLista = new ColumnHeader();
            colCalle = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            colCiudadLista = new ColumnHeader();
            colTipoBultoLista = new ColumnHeader();
            btnGenerarHdr = new Button();
            lblGuiaBase = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Generacion de HDR retiro";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1329, 100);
            lblFecha.Margin = new Padding(7, 0, 7, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 41);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(1450, 92);
            dtpFecha.Margin = new Padding(7, 8, 7, 8);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(286, 47);
            dtpFecha.TabIndex = 2;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(74, 82);
            lblEstado.Margin = new Padding(7, 0, 7, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 41);
            lblEstado.TabIndex = 3;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(50, 87);
            lblCdEmisor.Margin = new Padding(7, 0, 7, 0);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(156, 41);
            lblCdEmisor.TabIndex = 5;
            lblCdEmisor.Text = "CD emisor";
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(220, 79);
            txtCdEmisor.Margin = new Padding(7, 8, 7, 8);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(286, 47);
            txtCdEmisor.TabIndex = 6;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(49, 604);
            lblFletero.Margin = new Padding(7, 0, 7, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(1449, 41);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Fletero asignado(criterios: se muestran solos los fleteros que coinciden con el CP de las guias seleccionadas)";
            // 
            // lblGuiasPendientes
            // 
            lblGuiasPendientes.AutoSize = true;
            lblGuiasPendientes.Location = new Point(49, 213);
            lblGuiasPendientes.Margin = new Padding(7, 0, 7, 0);
            lblGuiasPendientes.Name = "lblGuiasPendientes";
            lblGuiasPendientes.Size = new Size(1856, 41);
            lblGuiasPendientes.TabIndex = 9;
            lblGuiasPendientes.Text = "Guías pendientes de retiro(FIFO, una vez que selecciona una guia, solo puede seleccionar m'as si comparte los campos direccion, calle, etc)";
            lblGuiasPendientes.Click += lblGuiasPendientes_Click;
            // 
            // lvGuiasPendientes
            // 
            lvGuiasPendientes.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colRemitenteLista, colCalle, columnHeader8, columnHeader7, columnHeader9, colCiudadLista, colTipoBultoLista, colFechaGuia });
            lvGuiasPendientes.FullRowSelect = true;
            lvGuiasPendientes.Location = new Point(49, 274);
            lvGuiasPendientes.Margin = new Padding(7, 8, 7, 8);
            lvGuiasPendientes.Name = "lvGuiasPendientes";
            lvGuiasPendientes.Size = new Size(1818, 256);
            lvGuiasPendientes.TabIndex = 10;
            lvGuiasPendientes.UseCompatibleStateImageBehavior = false;
            lvGuiasPendientes.View = View.Details;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guia";
            colNumeroGuia.Width = 100;
            // 
            // colFechaGuia
            // 
            colFechaGuia.Text = "Fecha";
            colFechaGuia.Width = 90;
            // 
            // colRemitenteLista
            // 
            colRemitenteLista.Text = "Remitente";
            colRemitenteLista.Width = 170;
            // 
            // colCalle
            // 
            colCalle.Text = "Calle";
            colCalle.Width = 180;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Altura";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Piso";
            // 
            // colCiudadLista
            // 
            colCiudadLista.Text = "Ciudad";
            colCiudadLista.Width = 120;
            // 
            // colTipoBultoLista
            // 
            colTipoBultoLista.Text = "Tipo Bulto";
            colTipoBultoLista.Width = 90;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(1551, 978);
            btnGenerarHdr.Margin = new Padding(7, 8, 7, 8);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(316, 96);
            btnGenerarHdr.TabIndex = 28;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.Location = new Point(0, 0);
            lblGuiaBase.Margin = new Padding(7, 0, 7, 0);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(243, 63);
            lblGuiaBase.TabIndex = 30;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(49, 653);
            listView1.Margin = new Padding(7, 8, 7, 8);
            listView1.Name = "listView1";
            listView1.Size = new Size(1818, 256);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID TL";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "HDR Asignadas";
            columnHeader5.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 95);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 32;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 8;
            columnHeader9.Text = "Codigo postal";
            // 
            // GeneracionHojaDeRutaRetiro_v2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1953, 1117);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(btnGenerarHdr);
            Controls.Add(lvGuiasPendientes);
            Controls.Add(lblGuiasPendientes);
            Controls.Add(lblFletero);
            Controls.Add(txtCdEmisor);
            Controls.Add(lblCdEmisor);
            Controls.Add(lblEstado);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblGuiaBase);
            Margin = new Padding(7, 8, 7, 8);
            Name = "GeneracionHojaDeRutaRetiro_v2";
            Text = "Generacion de HDR de retiro";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCdEmisor;
        private System.Windows.Forms.TextBox txtCdEmisor;
        private System.Windows.Forms.Label lblFletero;
        private System.Windows.Forms.Label lblGuiasPendientes;
        private System.Windows.Forms.ListView lvGuiasPendientes;
        private System.Windows.Forms.ColumnHeader colNumeroGuia;
        private System.Windows.Forms.ColumnHeader colFechaGuia;
        private System.Windows.Forms.ColumnHeader colRemitenteLista;
        private System.Windows.Forms.ColumnHeader colCalle;
        private System.Windows.Forms.ColumnHeader colCiudadLista;
        private System.Windows.Forms.ColumnHeader colTipoBultoLista;
        private System.Windows.Forms.Button btnGenerarHdr;
        private System.Windows.Forms.Label lblGuiaBase;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label2;
        private ColumnHeader columnHeader9;
    }
}
