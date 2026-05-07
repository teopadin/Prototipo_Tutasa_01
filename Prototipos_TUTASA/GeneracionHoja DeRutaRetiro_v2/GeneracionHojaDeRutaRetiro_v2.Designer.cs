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
            colDomicilioLista = new ColumnHeader();
            colCiudadLista = new ColumnHeader();
            colTipoBultoLista = new ColumnHeader();
            lblDatosGuia = new Label();
            lblRemitente = new Label();
            txtRemitente = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDomicilio = new Label();
            txtDomicilio = new TextBox();
            lblCiudad = new Label();
            txtCiudad = new TextBox();
            lblNumeroGuiaSel = new Label();
            txtNumeroGuiaSel = new TextBox();
            lblTipoBulto = new Label();
            txtTipoBulto = new TextBox();
            lblCdDestino = new Label();
            txtCdDestino = new TextBox();
            lblTipoEntrega = new Label();
            txtTipoEntrega = new TextBox();
            btnGenerarHdr = new Button();
            lblGuiaBase = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
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
            lblFecha.Location = new Point(539, 131);
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
            dtpFecha.Location = new Point(660, 123);
            dtpFecha.Margin = new Padding(7, 8, 7, 8);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(286, 47);
            dtpFecha.TabIndex = 2;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(70, 126);
            lblEstado.Margin = new Padding(7, 0, 7, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 41);
            lblEstado.TabIndex = 3;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(46, 131);
            lblCdEmisor.Margin = new Padding(7, 0, 7, 0);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(156, 41);
            lblCdEmisor.TabIndex = 5;
            lblCdEmisor.Text = "CD emisor";
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(216, 123);
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
            lblFletero.Size = new Size(239, 41);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Fletero asignado";
            // 
            // lblGuiasPendientes
            // 
            lblGuiasPendientes.AutoSize = true;
            lblGuiasPendientes.Location = new Point(49, 239);
            lblGuiasPendientes.Margin = new Padding(7, 0, 7, 0);
            lblGuiasPendientes.Name = "lblGuiasPendientes";
            lblGuiasPendientes.Size = new Size(368, 41);
            lblGuiasPendientes.TabIndex = 9;
            lblGuiasPendientes.Text = "Guías pendientes de retiro";
            // 
            // lvGuiasPendientes
            // 
            lvGuiasPendientes.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colFechaGuia, colRemitenteLista, colDomicilioLista, columnHeader8, columnHeader7, colCiudadLista, colTipoBultoLista });
            lvGuiasPendientes.FullRowSelect = true;
            lvGuiasPendientes.Location = new Point(49, 300);
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
            // colDomicilioLista
            // 
            colDomicilioLista.Text = "Calle";
            colDomicilioLista.Width = 180;
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
            // lblDatosGuia
            // 
            lblDatosGuia.AutoSize = true;
            lblDatosGuia.Location = new Point(49, 929);
            lblDatosGuia.Margin = new Padding(7, 0, 7, 0);
            lblDatosGuia.Name = "lblDatosGuia";
            lblDatosGuia.Size = new Size(337, 41);
            lblDatosGuia.TabIndex = 11;
            lblDatosGuia.Text = "Datos de la guía elegida";
            // 
            // lblRemitente
            // 
            lblRemitente.AutoSize = true;
            lblRemitente.Location = new Point(49, 1011);
            lblRemitente.Margin = new Padding(7, 0, 7, 0);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(153, 41);
            lblRemitente.TabIndex = 12;
            lblRemitente.Text = "Remitente";
            // 
            // txtRemitente
            // 
            txtRemitente.Location = new Point(243, 1003);
            txtRemitente.Margin = new Padding(7, 8, 7, 8);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.ReadOnly = true;
            txtRemitente.Size = new Size(601, 47);
            txtRemitente.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(923, 1011);
            lblTelefono.Margin = new Padding(7, 0, 7, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(132, 41);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1093, 1003);
            txtTelefono.Margin = new Padding(7, 8, 7, 8);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(383, 47);
            txtTelefono.TabIndex = 15;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(49, 1107);
            lblDomicilio.Margin = new Padding(7, 0, 7, 0);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(143, 41);
            lblDomicilio.TabIndex = 16;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(243, 1099);
            txtDomicilio.Margin = new Padding(7, 8, 7, 8);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.ReadOnly = true;
            txtDomicilio.Size = new Size(601, 47);
            txtDomicilio.TabIndex = 17;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(923, 1107);
            lblCiudad.Margin = new Padding(7, 0, 7, 0);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(112, 41);
            lblCiudad.TabIndex = 18;
            lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(1093, 1099);
            txtCiudad.Margin = new Padding(7, 8, 7, 8);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.ReadOnly = true;
            txtCiudad.Size = new Size(383, 47);
            txtCiudad.TabIndex = 19;
            // 
            // lblNumeroGuiaSel
            // 
            lblNumeroGuiaSel.AutoSize = true;
            lblNumeroGuiaSel.Location = new Point(49, 1203);
            lblNumeroGuiaSel.Margin = new Padding(7, 0, 7, 0);
            lblNumeroGuiaSel.Name = "lblNumeroGuiaSel";
            lblNumeroGuiaSel.Size = new Size(136, 41);
            lblNumeroGuiaSel.TabIndex = 20;
            lblNumeroGuiaSel.Text = "Nro Guia";
            // 
            // txtNumeroGuiaSel
            // 
            txtNumeroGuiaSel.Location = new Point(243, 1194);
            txtNumeroGuiaSel.Margin = new Padding(7, 8, 7, 8);
            txtNumeroGuiaSel.Name = "txtNumeroGuiaSel";
            txtNumeroGuiaSel.ReadOnly = true;
            txtNumeroGuiaSel.Size = new Size(286, 47);
            txtNumeroGuiaSel.TabIndex = 21;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.AutoSize = true;
            lblTipoBulto.Location = new Point(607, 1203);
            lblTipoBulto.Margin = new Padding(7, 0, 7, 0);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(155, 41);
            lblTipoBulto.TabIndex = 22;
            lblTipoBulto.Text = "Tipo bulto";
            // 
            // txtTipoBulto
            // 
            txtTipoBulto.Location = new Point(777, 1194);
            txtTipoBulto.Margin = new Padding(7, 8, 7, 8);
            txtTipoBulto.Name = "txtTipoBulto";
            txtTipoBulto.ReadOnly = true;
            txtTipoBulto.Size = new Size(237, 47);
            txtTipoBulto.TabIndex = 23;
            // 
            // lblCdDestino
            // 
            lblCdDestino.AutoSize = true;
            lblCdDestino.Location = new Point(1093, 1203);
            lblCdDestino.Margin = new Padding(7, 0, 7, 0);
            lblCdDestino.Name = "lblCdDestino";
            lblCdDestino.Size = new Size(165, 41);
            lblCdDestino.TabIndex = 24;
            lblCdDestino.Text = "CD destino";
            // 
            // txtCdDestino
            // 
            txtCdDestino.Location = new Point(1275, 1194);
            txtCdDestino.Margin = new Padding(7, 8, 7, 8);
            txtCdDestino.Name = "txtCdDestino";
            txtCdDestino.ReadOnly = true;
            txtCdDestino.Size = new Size(237, 47);
            txtCdDestino.TabIndex = 25;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.AutoSize = true;
            lblTipoEntrega.Location = new Point(49, 1298);
            lblTipoEntrega.Margin = new Padding(7, 0, 7, 0);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(187, 41);
            lblTipoEntrega.TabIndex = 26;
            lblTipoEntrega.Text = "Tipo entrega";
            // 
            // txtTipoEntrega
            // 
            txtTipoEntrega.Location = new Point(243, 1290);
            txtTipoEntrega.Margin = new Padding(7, 8, 7, 8);
            txtTipoEntrega.Name = "txtTipoEntrega";
            txtTipoEntrega.ReadOnly = true;
            txtTipoEntrega.Size = new Size(431, 47);
            txtTipoEntrega.TabIndex = 27;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(1579, 1394);
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
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
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
            // columnHeader4
            // 
            columnHeader4.Text = "Patente";
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "HDR Asignadas";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "CD";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Piso";
            // 
            // columnHeader8
            // 
            columnHeader8.DisplayIndex = 7;
            columnHeader8.Text = "Altura";
            // 
            // GeneracionHojaDeRutaRetiro_v2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1953, 1533);
            Controls.Add(listView1);
            Controls.Add(btnGenerarHdr);
            Controls.Add(txtTipoEntrega);
            Controls.Add(lblTipoEntrega);
            Controls.Add(txtCdDestino);
            Controls.Add(lblCdDestino);
            Controls.Add(txtTipoBulto);
            Controls.Add(lblTipoBulto);
            Controls.Add(txtNumeroGuiaSel);
            Controls.Add(lblNumeroGuiaSel);
            Controls.Add(txtCiudad);
            Controls.Add(lblCiudad);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtRemitente);
            Controls.Add(lblRemitente);
            Controls.Add(lblDatosGuia);
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
        private System.Windows.Forms.ColumnHeader colDomicilioLista;
        private System.Windows.Forms.ColumnHeader colCiudadLista;
        private System.Windows.Forms.ColumnHeader colTipoBultoLista;
        private System.Windows.Forms.Label lblDatosGuia;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblNumeroGuiaSel;
        private System.Windows.Forms.TextBox txtNumeroGuiaSel;
        private System.Windows.Forms.Label lblTipoBulto;
        private System.Windows.Forms.TextBox txtTipoBulto;
        private System.Windows.Forms.Label lblCdDestino;
        private System.Windows.Forms.TextBox txtCdDestino;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.TextBox txtTipoEntrega;
        private System.Windows.Forms.Button btnGenerarHdr;
        private System.Windows.Forms.Label lblGuiaBase;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}
