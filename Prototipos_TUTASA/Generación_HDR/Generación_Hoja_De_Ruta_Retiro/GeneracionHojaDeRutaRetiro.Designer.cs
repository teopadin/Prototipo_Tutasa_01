namespace Prototipos_TUTASA.HojaDeRutaRetiro
{
    partial class GeneracionHojaDeRutaRetiro
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
            colRemitenteLista = new ColumnHeader();
            colCalle = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            colTipoBultoLista = new ColumnHeader();
            colCiudadLista = new ColumnHeader();
            colFechaGuia = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnGenerarHdr = new Button();
            lblGuiaBase = new Label();
            lvFleteros = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            btnCancelar = new Button();
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
            lblFecha.Location = new Point(547, 37);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(597, 34);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 2;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(30, 30);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 3;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(21, 32);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(62, 15);
            lblCdEmisor.TabIndex = 5;
            lblCdEmisor.Text = "CD emisor";
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(91, 29);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(120, 23);
            txtCdEmisor.TabIndex = 6;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(20, 293);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(504, 15);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Transportista Local asignado(se muestran solos los fleteros que coinciden con el CD de origen)";
            // 
            // lblGuiasPendientes
            // 
            lblGuiasPendientes.AutoSize = true;
            lblGuiasPendientes.Location = new Point(7, 77);
            lblGuiasPendientes.Name = "lblGuiasPendientes";
            lblGuiasPendientes.Size = new Size(751, 15);
            lblGuiasPendientes.TabIndex = 9;
            lblGuiasPendientes.Text = "Guías pendientes de retiro (Cuando se seleccione una guía, solo podrá seleccionar las que compartan los campos Calle, Altura, Piso y Ciudad)";
            // 
            // lvGuiasPendientes
            // 
            lvGuiasPendientes.CheckBoxes = true;
            lvGuiasPendientes.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colRemitenteLista, colCalle, columnHeader8, columnHeader7, columnHeader9, colTipoBultoLista, colCiudadLista, colFechaGuia, columnHeader4 });
            lvGuiasPendientes.FullRowSelect = true;
            lvGuiasPendientes.Location = new Point(20, 100);
            lvGuiasPendientes.Name = "lvGuiasPendientes";
            lvGuiasPendientes.Size = new Size(966, 162);
            lvGuiasPendientes.TabIndex = 10;
            lvGuiasPendientes.UseCompatibleStateImageBehavior = false;
            lvGuiasPendientes.View = View.Details;
            lvGuiasPendientes.ItemChecked += lvGuiasPendientes_ItemChecked;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guia";
            colNumeroGuia.Width = 80;
            // 
            // colRemitenteLista
            // 
            colRemitenteLista.Text = "Tipo de Imposición";
            colRemitenteLista.Width = 130;
            // 
            // colCalle
            // 
            colCalle.Text = "Razón social";
            colCalle.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Calle";
            columnHeader8.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Altura";
            columnHeader7.Width = 50;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Piso";
            columnHeader9.Width = 50;
            // 
            // colTipoBultoLista
            // 
            colTipoBultoLista.Text = "CP";
            colTipoBultoLista.Width = 50;
            // 
            // colCiudadLista
            // 
            colCiudadLista.Text = "Ciudad";
            colCiudadLista.Width = 120;
            // 
            // colFechaGuia
            // 
            colFechaGuia.Text = "Tipo de bulto";
            colFechaGuia.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha Imposición";
            columnHeader4.Width = 150;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(722, 479);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(130, 35);
            btnGenerarHdr.TabIndex = 28;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            btnGenerarHdr.Click += btnGenerarHdr_Click;
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.Location = new Point(0, 0);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(100, 23);
            lblGuiaBase.TabIndex = 30;
            // 
            // lvFleteros
            // 
            lvFleteros.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            lvFleteros.FullRowSelect = true;
            lvFleteros.Location = new Point(20, 312);
            lvFleteros.MultiSelect = false;
            lvFleteros.Name = "lvFleteros";
            lvFleteros.Size = new Size(966, 161);
            lvFleteros.TabIndex = 31;
            lvFleteros.UseCompatibleStateImageBehavior = false;
            lvFleteros.View = View.Details;
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
            label2.Location = new Point(278, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 32;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(858, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 35);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GeneracionHojaDeRutaRetiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 484);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(lvFleteros);
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
            Name = "GeneracionHojaDeRutaRetiro";
            Text = "Generacion de HDR de retiro";
            Load += GeneracionHojaDeRutaRetiro_Load;
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
        private ListView lvFleteros;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label2;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader4;
        private Button btnCancelar;
    }
}
