namespace Prototipos_TUTASA.HojaDeRutaDeDistribucion
{
    partial class HojaDeRutaDeDistribucionDestinatario
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
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnGenerarHdr = new Button();
            lblGuiasPendientes = new Label();
            lblFletero = new Label();
            txtCdEmisor = new TextBox();
            lblCdEmisor = new Label();
            lblEstado = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblGuiaBase = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            colRemitenteLista = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(681, 87);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 44;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(100, 677);
            listView1.Margin = new Padding(7, 8, 7, 8);
            listView1.Name = "listView1";
            listView1.Size = new Size(1774, 226);
            listView1.TabIndex = 43;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID TL";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "HDR Asignadas";
            columnHeader5.Width = 200;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(1292, 980);
            btnGenerarHdr.Margin = new Padding(7, 8, 7, 8);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(272, 66);
            btnGenerarHdr.TabIndex = 41;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // lblGuiasPendientes
            // 
            lblGuiasPendientes.AutoSize = true;
            lblGuiasPendientes.Location = new Point(4, 235);
            lblGuiasPendientes.Margin = new Padding(7, 0, 7, 0);
            lblGuiasPendientes.Name = "lblGuiasPendientes";
            lblGuiasPendientes.Size = new Size(1898, 41);
            lblGuiasPendientes.TabIndex = 39;
            lblGuiasPendientes.Text = "Guías pendientes de distribución (cuando se seleccione una guía, solo podrá seleccionar otras que compartan: Calle, Altura, Piso, CP y Ciudad)";
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(100, 614);
            lblFletero.Margin = new Padding(7, 0, 7, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(1562, 41);
            lblFletero.TabIndex = 38;
            lblFletero.Text = "Fletero asignado(criterios: se muestran solos los fleteros que coinciden con el Cod. Postal de las guias seleccionadas)";
            lblFletero.Click += lblFletero_Click;
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(271, 71);
            txtCdEmisor.Margin = new Padding(7, 8, 7, 8);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(242, 47);
            txtCdEmisor.TabIndex = 37;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(57, 79);
            lblCdEmisor.Margin = new Padding(7, 0, 7, 0);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(156, 41);
            lblCdEmisor.TabIndex = 36;
            lblCdEmisor.Text = "CD emisor";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(-197, -88);
            lblEstado.Margin = new Padding(7, 0, 7, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 41);
            lblEstado.TabIndex = 35;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(1501, 84);
            dtpFecha.Margin = new Padding(7, 8, 7, 8);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(242, 47);
            dtpFecha.TabIndex = 34;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1336, 92);
            lblFecha.Margin = new Padding(7, 0, 7, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 41);
            lblFecha.TabIndex = 33;
            lblFecha.Text = "Fecha";
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.Location = new Point(51, 22);
            lblGuiaBase.Margin = new Padding(7, 0, 7, 0);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(199, 33);
            lblGuiaBase.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(1602, 980);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(272, 66);
            button1.TabIndex = 45;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 539);
            label1.Name = "label1";
            label1.Size = new Size(455, 41);
            label1.TabIndex = 46;
            label1.Text = "Cantidad de guias seleccionadas:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(556, 533);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(242, 47);
            textBox1.TabIndex = 47;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, colRemitenteLista, columnHeader6, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(68, 284);
            listView2.Margin = new Padding(7, 8, 7, 8);
            listView2.Name = "listView2";
            listView2.Size = new Size(1818, 256);
            listView2.TabIndex = 48;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro Guia";
            columnHeader4.Width = 150;
            // 
            // colRemitenteLista
            // 
            colRemitenteLista.Text = "Fecha de Imposición";
            colRemitenteLista.Width = 300;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tipo de entrega";
            columnHeader6.Width = 250;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Razón Social";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "DNI destinatario";
            columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Calle";
            columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            columnHeader13.DisplayIndex = 7;
            columnHeader13.Text = "Altura";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.DisplayIndex = 6;
            columnHeader14.Text = "Piso";
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "CP";
            columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Ciudad";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 100;
            // 
            // HojaDeRutaDeDistribucionDestinatario
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1942, 1096);
            Controls.Add(listView2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(btnGenerarHdr);
            Controls.Add(lblGuiasPendientes);
            Controls.Add(lblFletero);
            Controls.Add(txtCdEmisor);
            Controls.Add(lblCdEmisor);
            Controls.Add(lblEstado);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblGuiaBase);
            Name = "HojaDeRutaDeDistribucionDestinatario";
            Text = "HojaDeRutaDeDistribucion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button btnGenerarHdr;
        private Label lblGuiasPendientes;
        private Label lblFletero;
        private TextBox txtCdEmisor;
        private Label lblCdEmisor;
        private Label lblEstado;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblGuiaBase;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader colRemitenteLista;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
    }
}