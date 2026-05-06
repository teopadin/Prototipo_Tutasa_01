namespace Prototipos_TUTASA.GeneraciónHojaDeRutaDeTransporte
{
    partial class GeneracionHojaRutaTransporte
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            txtCdEmisor = new TextBox();
            txtEstadoHdr = new TextBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblDniDestinatario = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            txtDomicilioEntrega = new TextBox();
            lblDomicilioEntrega = new Label();
            lblGuiasIncluidas = new Label();
            lvGuias = new ListView();
            colNumeroGuia = new ColumnHeader();
            colRemitente = new ColumnHeader();
            colTipoBulto = new ColumnHeader();
            colCdOrigen = new ColumnHeader();
            colTipoEntrega = new ColumnHeader();
            lblCantidadGuias = new Label();
            txtCantidadGuias = new TextBox();
            btnGenerarHdr = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar por guia:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDomicilioEntrega);
            groupBox1.Controls.Add(txtDomicilioEntrega);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtCdEmisor);
            groupBox1.Controls.Add(txtEstadoHdr);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblDniDestinatario);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 142);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Hoja de Ruta de Transporte";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(389, 39);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(130, 23);
            txtCdEmisor.TabIndex = 28;
            // 
            // txtEstadoHdr
            // 
            txtEstadoHdr.Location = new Point(213, 36);
            txtEstadoHdr.Name = "txtEstadoHdr";
            txtEstadoHdr.ReadOnly = true;
            txtEstadoHdr.Size = new Size(130, 23);
            txtEstadoHdr.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(19, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 74);
            label8.Name = "label8";
            label8.Size = new Size(160, 15);
            label8.TabIndex = 24;
            label8.Text = "Fecha y Horario de despacho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 92);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 77);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 21;
            label6.Text = "Chofer asignado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(564, 18);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 20;
            label5.Text = "CD Destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 108);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 18);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "Fecha";
            // 
            // lblDniDestinatario
            // 
            lblDniDestinatario.AutoSize = true;
            lblDniDestinatario.Location = new Point(389, 19);
            lblDniDestinatario.Name = "lblDniDestinatario";
            lblDniDestinatario.Size = new Size(62, 15);
            lblDniDestinatario.TabIndex = 17;
            lblDniDestinatario.Text = "CD Emisor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 18);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Estado";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(19, 36);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(105, 23);
            dtpFecha.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(213, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // txtDomicilioEntrega
            // 
            txtDomicilioEntrega.Location = new Point(425, 92);
            txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            txtDomicilioEntrega.ReadOnly = true;
            txtDomicilioEntrega.Size = new Size(341, 23);
            txtDomicilioEntrega.TabIndex = 31;
            // 
            // lblDomicilioEntrega
            // 
            lblDomicilioEntrega.AutoSize = true;
            lblDomicilioEntrega.Location = new Point(425, 74);
            lblDomicilioEntrega.Name = "lblDomicilioEntrega";
            lblDomicilioEntrega.Size = new Size(136, 15);
            lblDomicilioEntrega.TabIndex = 32;
            lblDomicilioEntrega.Text = "Domicilio de CD Destino";
            lblDomicilioEntrega.Click += lblDomicilioEntrega_Click;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(16, 191);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(129, 15);
            lblGuiasIncluidas.TabIndex = 23;
            lblGuiasIncluidas.Text = "Guias incluidas en HDR";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colRemitente, colTipoBulto, colCdOrigen, colTipoEntrega });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(16, 217);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(803, 212);
            lvGuias.TabIndex = 24;
            lvGuias.UseCompatibleStateImageBehavior = false;
            lvGuias.View = View.Details;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guia";
            colNumeroGuia.Width = 120;
            // 
            // colRemitente
            // 
            colRemitente.Text = "Remitente";
            colRemitente.Width = 260;
            // 
            // colTipoBulto
            // 
            colTipoBulto.Text = "Tipo Bulto";
            colTipoBulto.Width = 100;
            // 
            // colCdOrigen
            // 
            colCdOrigen.Text = "CD Origen";
            colCdOrigen.Width = 100;
            // 
            // colTipoEntrega
            // 
            colTipoEntrega.Text = "Tipo Entrega";
            colTipoEntrega.Width = 180;
            // 
            // lblCantidadGuias
            // 
            lblCantidadGuias.AutoSize = true;
            lblCantidadGuias.Location = new Point(16, 446);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(80, 15);
            lblCantidadGuias.TabIndex = 25;
            lblCantidadGuias.Text = "Total de guias";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(102, 443);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(80, 23);
            txtCantidadGuias.TabIndex = 26;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(687, 443);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(130, 30);
            btnGenerarHdr.TabIndex = 27;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // GeneracionHojaRutaTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 478);
            Controls.Add(btnGenerarHdr);
            Controls.Add(txtCantidadGuias);
            Controls.Add(lblCantidadGuias);
            Controls.Add(lvGuias);
            Controls.Add(lblGuiasIncluidas);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "GeneracionHojaRutaTransporte";
            Text = "GeneracionHojaRutaTransporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblDniDestinatario;
        private Label label2;
        private Label label8;
        private Label label7;
        private ComboBox comboBox2;
        private TextBox txtEstadoHdr;
        private TextBox txtCdEmisor;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpFecha;
        private TextBox txtDomicilioEntrega;
        private Label lblDomicilioEntrega;
        private Label lblGuiasIncluidas;
        private ListView lvGuias;
        private ColumnHeader colNumeroGuia;
        private ColumnHeader colRemitente;
        private ColumnHeader colTipoBulto;
        private ColumnHeader colCdOrigen;
        private ColumnHeader colTipoEntrega;
        private Label lblCantidadGuias;
        private TextBox txtCantidadGuias;
        private Button btnGenerarHdr;
    }
}