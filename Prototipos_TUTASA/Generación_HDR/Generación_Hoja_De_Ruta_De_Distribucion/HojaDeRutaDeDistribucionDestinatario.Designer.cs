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
            label2.Location = new Point(280, 32);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 44;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(28, 362);
            listView1.Name = "listView1";
            listView1.Size = new Size(867, 115);
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
            btnGenerarHdr.Location = new Point(664, 483);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(112, 24);
            btnGenerarHdr.TabIndex = 41;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // lblGuiasPendientes
            // 
            lblGuiasPendientes.AutoSize = true;
            lblGuiasPendientes.Location = new Point(23, 77);
            lblGuiasPendientes.Name = "lblGuiasPendientes";
            lblGuiasPendientes.Size = new Size(757, 15);
            lblGuiasPendientes.TabIndex = 39;
            lblGuiasPendientes.Text = "Guías pendientes de distribución (cuando se seleccione una guía, solo podrá seleccionar otras que compartan: Calle, Altura, Piso, CP y Ciudad)";
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(28, 344);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(570, 15);
            lblFletero.TabIndex = 38;
            lblFletero.Text = "Fletero asignado(se muestran solos los fleteros que coinciden con el CD destino de las guias seleccionadas)";
            lblFletero.Click += lblFletero_Click;
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(112, 26);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(102, 23);
            txtCdEmisor.TabIndex = 37;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(23, 29);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(62, 15);
            lblCdEmisor.TabIndex = 36;
            lblCdEmisor.Text = "CD emisor";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(-81, -32);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 35;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(791, 29);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(102, 23);
            dtpFecha.TabIndex = 34;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(723, 32);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 33;
            lblFecha.Text = "Fecha";
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.Location = new Point(21, 8);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(82, 12);
            lblGuiaBase.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(792, 483);
            button1.Name = "button1";
            button1.Size = new Size(112, 24);
            button1.TabIndex = 45;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 320);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 46;
            label1.Text = "Cantidad de guias seleccionadas:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 318);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 47;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, colRemitenteLista, columnHeader6, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(28, 104);
            listView2.Name = "listView2";
            listView2.Size = new Size(867, 208);
            listView2.TabIndex = 48;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro Guia";
            columnHeader4.Width = 70;
            // 
            // colRemitenteLista
            // 
            colRemitenteLista.Text = "Fecha de Imposición";
            colRemitenteLista.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tipo de entrega";
            columnHeader6.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Razón Social";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "DNI destinatario";
            columnHeader11.Width = 100;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 519);
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
            Margin = new Padding(1, 1, 1, 1);
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