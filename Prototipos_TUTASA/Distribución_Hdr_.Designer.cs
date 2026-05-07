namespace Prototipos_TUTASA
{
    partial class Distribucion_Hdr_
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
            lblGuiaBase = new Label();
            cboGuiaBase = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblEstadoHdr = new Label();
            txtEstadoHdr = new TextBox();
            lblCdEmisor = new Label();
            txtCdEmisor = new TextBox();
            lblCdDestino = new Label();
            txtCdDestino = new TextBox();
            lblFleteroAsignado = new Label();
            cboFleteroAsignado = new ComboBox();
            lblDestinatario = new Label();
            txtDestinatario = new TextBox();
            lblTelefonoDestinatario = new Label();
            txtTelefonoDestinatario = new TextBox();
            lblDniDestinatario = new Label();
            txtDniDestinatario = new TextBox();
            lblDomicilioEntrega = new Label();
            txtDomicilioEntrega = new TextBox();
            lblCiudadEntrega = new Label();
            txtCiudadEntrega = new TextBox();
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
            groupBox1 = new GroupBox();
            codigo_postal_entrega = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.AutoSize = true;
            lblGuiaBase.Location = new Point(39, 15);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(92, 15);
            lblGuiaBase.TabIndex = 0;
            lblGuiaBase.Text = "Buscar por guía:";
            lblGuiaBase.Click += lblGuiaBase_Click;
            // 
            // cboGuiaBase
            // 
            cboGuiaBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGuiaBase.FormattingEnabled = true;
            cboGuiaBase.Location = new Point(137, 12);
            cboGuiaBase.Name = "cboGuiaBase";
            cboGuiaBase.Size = new Size(140, 23);
            cboGuiaBase.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(29, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(29, 37);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 3;
            // 
            // lblEstadoHdr
            // 
            lblEstadoHdr.AutoSize = true;
            lblEstadoHdr.Location = new Point(227, 19);
            lblEstadoHdr.Name = "lblEstadoHdr";
            lblEstadoHdr.Size = new Size(42, 15);
            lblEstadoHdr.TabIndex = 4;
            lblEstadoHdr.Text = "Estado";
            // 
            // txtEstadoHdr
            // 
            txtEstadoHdr.Location = new Point(227, 37);
            txtEstadoHdr.Name = "txtEstadoHdr";
            txtEstadoHdr.ReadOnly = true;
            txtEstadoHdr.Size = new Size(130, 23);
            txtEstadoHdr.TabIndex = 5;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(426, 19);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(62, 15);
            lblCdEmisor.TabIndex = 6;
            lblCdEmisor.Text = "CD emisor";
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(426, 40);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(130, 23);
            txtCdEmisor.TabIndex = 7;
            // 
            // lblCdDestino
            // 
            lblCdDestino.AutoSize = true;
            lblCdDestino.Location = new Point(613, 19);
            lblCdDestino.Name = "lblCdDestino";
            lblCdDestino.Size = new Size(65, 15);
            lblCdDestino.TabIndex = 8;
            lblCdDestino.Text = "CD destino";
            // 
            // txtCdDestino
            // 
            txtCdDestino.Location = new Point(613, 40);
            txtCdDestino.Name = "txtCdDestino";
            txtCdDestino.ReadOnly = true;
            txtCdDestino.Size = new Size(130, 23);
            txtCdDestino.TabIndex = 9;
            // 
            // lblFleteroAsignado
            // 
            lblFleteroAsignado.AutoSize = true;
            lblFleteroAsignado.Location = new Point(29, 72);
            lblFleteroAsignado.Name = "lblFleteroAsignado";
            lblFleteroAsignado.Size = new Size(94, 15);
            lblFleteroAsignado.TabIndex = 10;
            lblFleteroAsignado.Text = "Fletero asignado";
            // 
            // cboFleteroAsignado
            // 
            cboFleteroAsignado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFleteroAsignado.FormattingEnabled = true;
            cboFleteroAsignado.Location = new Point(29, 90);
            cboFleteroAsignado.Name = "cboFleteroAsignado";
            cboFleteroAsignado.Size = new Size(180, 23);
            cboFleteroAsignado.TabIndex = 11;
            // 
            // lblDestinatario
            // 
            lblDestinatario.AutoSize = true;
            lblDestinatario.Location = new Point(227, 72);
            lblDestinatario.Name = "lblDestinatario";
            lblDestinatario.Size = new Size(70, 15);
            lblDestinatario.TabIndex = 12;
            lblDestinatario.Text = "Destinatario";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(227, 90);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.ReadOnly = true;
            txtDestinatario.Size = new Size(250, 23);
            txtDestinatario.TabIndex = 13;
            // 
            // lblTelefonoDestinatario
            // 
            lblTelefonoDestinatario.AutoSize = true;
            lblTelefonoDestinatario.Location = new Point(613, 72);
            lblTelefonoDestinatario.Name = "lblTelefonoDestinatario";
            lblTelefonoDestinatario.Size = new Size(118, 15);
            lblTelefonoDestinatario.TabIndex = 14;
            lblTelefonoDestinatario.Text = "Telefono destinatario";
            // 
            // txtTelefonoDestinatario
            // 
            txtTelefonoDestinatario.Location = new Point(613, 90);
            txtTelefonoDestinatario.Name = "txtTelefonoDestinatario";
            txtTelefonoDestinatario.ReadOnly = true;
            txtTelefonoDestinatario.Size = new Size(130, 23);
            txtTelefonoDestinatario.TabIndex = 15;
            // 
            // lblDniDestinatario
            // 
            lblDniDestinatario.AutoSize = true;
            lblDniDestinatario.Location = new Point(493, 72);
            lblDniDestinatario.Name = "lblDniDestinatario";
            lblDniDestinatario.Size = new Size(27, 15);
            lblDniDestinatario.TabIndex = 16;
            lblDniDestinatario.Text = "DNI";
            // 
            // txtDniDestinatario
            // 
            txtDniDestinatario.Location = new Point(493, 90);
            txtDniDestinatario.Name = "txtDniDestinatario";
            txtDniDestinatario.ReadOnly = true;
            txtDniDestinatario.Size = new Size(100, 23);
            txtDniDestinatario.TabIndex = 17;
            // 
            // lblDomicilioEntrega
            // 
            lblDomicilioEntrega.AutoSize = true;
            lblDomicilioEntrega.Location = new Point(31, 128);
            lblDomicilioEntrega.Name = "lblDomicilioEntrega";
            lblDomicilioEntrega.Size = new Size(101, 15);
            lblDomicilioEntrega.TabIndex = 18;
            lblDomicilioEntrega.Text = "Domicilio entrega";
            // 
            // txtDomicilioEntrega
            // 
            txtDomicilioEntrega.Location = new Point(31, 146);
            txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            txtDomicilioEntrega.ReadOnly = true;
            txtDomicilioEntrega.Size = new Size(350, 23);
            txtDomicilioEntrega.TabIndex = 19;
            // 
            // lblCiudadEntrega
            // 
            lblCiudadEntrega.AutoSize = true;
            lblCiudadEntrega.Location = new Point(399, 128);
            lblCiudadEntrega.Name = "lblCiudadEntrega";
            lblCiudadEntrega.Size = new Size(45, 15);
            lblCiudadEntrega.TabIndex = 20;
            lblCiudadEntrega.Text = "Ciudad";
            // 
            // txtCiudadEntrega
            // 
            txtCiudadEntrega.Location = new Point(399, 146);
            txtCiudadEntrega.Name = "txtCiudadEntrega";
            txtCiudadEntrega.ReadOnly = true;
            txtCiudadEntrega.Size = new Size(203, 23);
            txtCiudadEntrega.TabIndex = 21;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(7, 243);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(129, 15);
            lblGuiasIncluidas.TabIndex = 22;
            lblGuiasIncluidas.Text = "Guias incluidas en HDR";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colRemitente, colTipoBulto, colCdOrigen, colTipoEntrega });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(7, 264);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(803, 212);
            lvGuias.TabIndex = 23;
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
            lblCantidadGuias.Location = new Point(12, 490);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(80, 15);
            lblCantidadGuias.TabIndex = 24;
            lblCantidadGuias.Text = "Total de guias";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(112, 482);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(80, 23);
            txtCantidadGuias.TabIndex = 25;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(680, 498);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(130, 30);
            btnGenerarHdr.TabIndex = 26;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(codigo_postal_entrega);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtCiudadEntrega);
            groupBox1.Controls.Add(lblCiudadEntrega);
            groupBox1.Controls.Add(txtDomicilioEntrega);
            groupBox1.Controls.Add(lblDomicilioEntrega);
            groupBox1.Controls.Add(txtDniDestinatario);
            groupBox1.Controls.Add(lblDniDestinatario);
            groupBox1.Controls.Add(txtTelefonoDestinatario);
            groupBox1.Controls.Add(lblTelefonoDestinatario);
            groupBox1.Controls.Add(txtDestinatario);
            groupBox1.Controls.Add(lblDestinatario);
            groupBox1.Controls.Add(cboFleteroAsignado);
            groupBox1.Controls.Add(lblFleteroAsignado);
            groupBox1.Controls.Add(txtCdDestino);
            groupBox1.Controls.Add(lblCdDestino);
            groupBox1.Controls.Add(txtCdEmisor);
            groupBox1.Controls.Add(lblCdEmisor);
            groupBox1.Controls.Add(txtEstadoHdr);
            groupBox1.Controls.Add(lblEstadoHdr);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Location = new Point(8, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(815, 197);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Hoja de Ruta de Distribución";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // codigo_postal_entrega
            // 
            codigo_postal_entrega.AutoSize = true;
            codigo_postal_entrega.Location = new Point(613, 128);
            codigo_postal_entrega.Name = "codigo_postal_entrega";
            codigo_postal_entrega.Size = new Size(81, 15);
            codigo_postal_entrega.TabIndex = 23;
            codigo_postal_entrega.Text = "Codigo postal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(613, 146);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 22;
            // 
            // Distribucion_Hdr_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 531);
            Controls.Add(groupBox1);
            Controls.Add(btnGenerarHdr);
            Controls.Add(txtCantidadGuias);
            Controls.Add(lblCantidadGuias);
            Controls.Add(lvGuias);
            Controls.Add(lblGuiasIncluidas);
            Controls.Add(cboGuiaBase);
            Controls.Add(lblGuiaBase);
            Name = "Distribucion_Hdr_";
            Text = "Generacion de HDR de distribucion";
            Load += Distribucion_Hdr__Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblGuiaBase;
        private System.Windows.Forms.ComboBox cboGuiaBase;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEstadoHdr;
        private System.Windows.Forms.TextBox txtEstadoHdr;
        private System.Windows.Forms.Label lblCdEmisor;
        private System.Windows.Forms.TextBox txtCdEmisor;
        private System.Windows.Forms.Label lblCdDestino;
        private System.Windows.Forms.TextBox txtCdDestino;
        private System.Windows.Forms.Label lblFleteroAsignado;
        private System.Windows.Forms.ComboBox cboFleteroAsignado;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblTelefonoDestinatario;
        private System.Windows.Forms.TextBox txtTelefonoDestinatario;
        private System.Windows.Forms.Label lblDniDestinatario;
        private System.Windows.Forms.TextBox txtDniDestinatario;
        private System.Windows.Forms.Label lblDomicilioEntrega;
        private System.Windows.Forms.TextBox txtDomicilioEntrega;
        private System.Windows.Forms.Label lblCiudadEntrega;
        private System.Windows.Forms.TextBox txtCiudadEntrega;
        private System.Windows.Forms.Label lblGuiasIncluidas;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader colNumeroGuia;
        private System.Windows.Forms.ColumnHeader colRemitente;
        private System.Windows.Forms.ColumnHeader colTipoBulto;
        private System.Windows.Forms.ColumnHeader colCdOrigen;
        private System.Windows.Forms.ColumnHeader colTipoEntrega;
        private System.Windows.Forms.Label lblCantidadGuias;
        private System.Windows.Forms.TextBox txtCantidadGuias;
        private System.Windows.Forms.Button btnGenerarHdr;
        private GroupBox groupBox1;
        private Label codigo_postal_entrega;
        private TextBox textBox1;
    }
}
