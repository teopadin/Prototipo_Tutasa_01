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
            listViewFleteros = new ListView();
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
            lblCantGuias = new Label();
            txtCantGuias = new TextBox();
            listViewGuiasADistribuir = new ListView();
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
            label2.Location = new Point(400, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 44;
            // 
            // listViewFleteros
            // 
            listViewFleteros.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5 });
            listViewFleteros.FullRowSelect = true;
            listViewFleteros.Location = new Point(40, 603);
            listViewFleteros.Margin = new Padding(4, 5, 4, 5);
            listViewFleteros.MultiSelect = false;
            listViewFleteros.Name = "listViewFleteros";
            listViewFleteros.Size = new Size(1237, 189);
            listViewFleteros.TabIndex = 43;
            listViewFleteros.UseCompatibleStateImageBehavior = false;
            listViewFleteros.View = View.Details;
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
            btnGenerarHdr.Location = new Point(936, 805);
            btnGenerarHdr.Margin = new Padding(4, 5, 4, 5);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(160, 40);
            btnGenerarHdr.TabIndex = 41;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            btnGenerarHdr.Click += btnGenerarHdr_Click;
            // 
            // lblGuiasPendientes
            // 
            lblGuiasPendientes.AutoSize = true;
            lblGuiasPendientes.Location = new Point(33, 128);
            lblGuiasPendientes.Margin = new Padding(4, 0, 4, 0);
            lblGuiasPendientes.Name = "lblGuiasPendientes";
            lblGuiasPendientes.Size = new Size(1131, 25);
            lblGuiasPendientes.TabIndex = 39;
            lblGuiasPendientes.Text = "Guías pendientes de distribución (cuando se seleccione una guía, solo podrá seleccionar otras que compartan: Calle, Altura, Piso, CP y Ciudad)";
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(40, 573);
            lblFletero.Margin = new Padding(4, 0, 4, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(952, 25);
            lblFletero.TabIndex = 38;
            lblFletero.Text = "Transportista Local asignado(se muestran solos los fleteros que coinciden con el CD destino de las guias seleccionadas)";
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(160, 43);
            txtCdEmisor.Margin = new Padding(4, 5, 4, 5);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(144, 31);
            txtCdEmisor.TabIndex = 37;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(33, 48);
            lblCdEmisor.Margin = new Padding(4, 0, 4, 0);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(95, 25);
            lblCdEmisor.TabIndex = 36;
            lblCdEmisor.Text = "CD emisor";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(-116, -53);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 25);
            lblEstado.TabIndex = 35;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(1130, 48);
            dtpFecha.Margin = new Padding(4, 5, 4, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(144, 31);
            dtpFecha.TabIndex = 34;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1033, 53);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 33;
            lblFecha.Text = "Fecha";
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.Location = new Point(30, 13);
            lblGuiaBase.Margin = new Padding(4, 0, 4, 0);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(117, 20);
            lblGuiaBase.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(1119, 805);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 45;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblCantGuias
            // 
            lblCantGuias.AutoSize = true;
            lblCantGuias.Location = new Point(40, 535);
            lblCantGuias.Margin = new Padding(1, 0, 1, 0);
            lblCantGuias.Name = "lblCantGuias";
            lblCantGuias.Size = new Size(272, 25);
            lblCantGuias.TabIndex = 46;
            lblCantGuias.Text = "Cantidad de guias seleccionadas:";
            // 
            // txtCantGuias
            // 
            txtCantGuias.Location = new Point(314, 528);
            txtCantGuias.Margin = new Padding(4, 5, 4, 5);
            txtCantGuias.Name = "txtCantGuias";
            txtCantGuias.ReadOnly = true;
            txtCantGuias.Size = new Size(144, 31);
            txtCantGuias.TabIndex = 47;
            // 
            // listViewGuiasADistribuir
            // 
            listViewGuiasADistribuir.CheckBoxes = true;
            listViewGuiasADistribuir.Columns.AddRange(new ColumnHeader[] { columnHeader4, colRemitenteLista, columnHeader6, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listViewGuiasADistribuir.FullRowSelect = true;
            listViewGuiasADistribuir.Location = new Point(40, 172);
            listViewGuiasADistribuir.Margin = new Padding(4, 5, 4, 5);
            listViewGuiasADistribuir.Name = "listViewGuiasADistribuir";
            listViewGuiasADistribuir.Size = new Size(1237, 344);
            listViewGuiasADistribuir.TabIndex = 48;
            listViewGuiasADistribuir.UseCompatibleStateImageBehavior = false;
            listViewGuiasADistribuir.View = View.Details;
            listViewGuiasADistribuir.ItemChecked += listViewGuiasADistribuir_ItemChecked;
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
            columnHeader13.Width = 50;
            // 
            // columnHeader14
            // 
            columnHeader14.DisplayIndex = 6;
            columnHeader14.Text = "Piso";
            columnHeader14.Width = 50;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "CP";
            columnHeader15.Width = 50;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Ciudad";
            columnHeader16.Width = 100;
            // 
            // HojaDeRutaDeDistribucionDestinatario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 857);
            Controls.Add(listViewGuiasADistribuir);
            Controls.Add(txtCantGuias);
            Controls.Add(lblCantGuias);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listViewFleteros);
            Controls.Add(btnGenerarHdr);
            Controls.Add(lblGuiasPendientes);
            Controls.Add(lblFletero);
            Controls.Add(txtCdEmisor);
            Controls.Add(lblCdEmisor);
            Controls.Add(lblEstado);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblGuiaBase);
            Margin = new Padding(1, 2, 1, 2);
            Name = "HojaDeRutaDeDistribucionDestinatario";
            Text = "HojaDeRutaDeDistribucion";
            Load += HojaDeRutaDeDistribucionDestinatario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListView listViewFleteros;
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
        private Label lblCantGuias;
        private TextBox txtCantGuias;
        private ListView listViewGuiasADistribuir;
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