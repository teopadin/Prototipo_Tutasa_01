namespace Prototipos_TUTASA
{
    partial class Retiro_Teo_
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
            lblFleteroAsignado = new Label();
            cboFleteroAsignado = new ComboBox();
            lblRemitente = new Label();
            txtRemitente = new TextBox();
            lblTelefonoRemitente = new Label();
            txtTelefonoRemitente = new TextBox();
            lblDomicilioRetiro = new Label();
            txtDomicilioRetiro = new TextBox();
            lblCiudadRetiro = new Label();
            txtCiudadRetiro = new TextBox();
            lblGuiasIncluidas = new Label();
            lvGuias = new ListView();
            colNumeroGuia = new ColumnHeader();
            colDestinatario = new ColumnHeader();
            colTipoBulto = new ColumnHeader();
            colCdDestino = new ColumnHeader();
            colTipoEntrega = new ColumnHeader();
            lblCantidadGuias = new Label();
            txtCantidadGuias = new TextBox();
            btnGenerarHdr = new Button();
            SuspendLayout();
            // 
            // lblGuiaBase
            // 
            lblGuiaBase.AutoSize = true;
            lblGuiaBase.Location = new Point(12, 15);
            lblGuiaBase.Name = "lblGuiaBase";
            lblGuiaBase.Size = new Size(58, 15);
            lblGuiaBase.TabIndex = 0;
            lblGuiaBase.Text = "Guia base";
            // 
            // cboGuiaBase
            // 
            cboGuiaBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGuiaBase.FormattingEnabled = true;
            cboGuiaBase.Location = new Point(90, 12);
            cboGuiaBase.Name = "cboGuiaBase";
            cboGuiaBase.Size = new Size(140, 23);
            cboGuiaBase.TabIndex = 1;
            cboGuiaBase.SelectedIndexChanged += cboGuiaBase_SelectedIndexChanged_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(250, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(300, 12);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 3;
            // 
            // lblEstadoHdr
            // 
            lblEstadoHdr.AutoSize = true;
            lblEstadoHdr.Location = new Point(440, 15);
            lblEstadoHdr.Name = "lblEstadoHdr";
            lblEstadoHdr.Size = new Size(42, 15);
            lblEstadoHdr.TabIndex = 4;
            lblEstadoHdr.Text = "Estado";
            // 
            // txtEstadoHdr
            // 
            txtEstadoHdr.Location = new Point(490, 12);
            txtEstadoHdr.Name = "txtEstadoHdr";
            txtEstadoHdr.ReadOnly = true;
            txtEstadoHdr.Size = new Size(130, 23);
            txtEstadoHdr.TabIndex = 5;
            // 
            // lblCdEmisor
            // 
            lblCdEmisor.AutoSize = true;
            lblCdEmisor.Location = new Point(12, 50);
            lblCdEmisor.Name = "lblCdEmisor";
            lblCdEmisor.Size = new Size(62, 15);
            lblCdEmisor.TabIndex = 6;
            lblCdEmisor.Text = "CD emisor";
            // 
            // txtCdEmisor
            // 
            txtCdEmisor.Location = new Point(90, 47);
            txtCdEmisor.Name = "txtCdEmisor";
            txtCdEmisor.ReadOnly = true;
            txtCdEmisor.Size = new Size(140, 23);
            txtCdEmisor.TabIndex = 7;
            // 
            // lblFleteroAsignado
            // 
            lblFleteroAsignado.AutoSize = true;
            lblFleteroAsignado.Location = new Point(250, 50);
            lblFleteroAsignado.Name = "lblFleteroAsignado";
            lblFleteroAsignado.Size = new Size(94, 15);
            lblFleteroAsignado.TabIndex = 8;
            lblFleteroAsignado.Text = "Fletero asignado";
            // 
            // cboFleteroAsignado
            // 
            cboFleteroAsignado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFleteroAsignado.FormattingEnabled = true;
            cboFleteroAsignado.Location = new Point(360, 47);
            cboFleteroAsignado.Name = "cboFleteroAsignado";
            cboFleteroAsignado.Size = new Size(180, 23);
            cboFleteroAsignado.TabIndex = 9;
            // 
            // lblRemitente
            // 
            lblRemitente.AutoSize = true;
            lblRemitente.Location = new Point(12, 90);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(61, 15);
            lblRemitente.TabIndex = 10;
            lblRemitente.Text = "Remitente";
            // 
            // txtRemitente
            // 
            txtRemitente.Location = new Point(90, 87);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.ReadOnly = true;
            txtRemitente.Size = new Size(250, 23);
            txtRemitente.TabIndex = 11;
            // 
            // lblTelefonoRemitente
            // 
            lblTelefonoRemitente.AutoSize = true;
            lblTelefonoRemitente.Location = new Point(360, 90);
            lblTelefonoRemitente.Name = "lblTelefonoRemitente";
            lblTelefonoRemitente.Size = new Size(107, 15);
            lblTelefonoRemitente.TabIndex = 12;
            lblTelefonoRemitente.Text = "Telefono remitente";
            // 
            // txtTelefonoRemitente
            // 
            txtTelefonoRemitente.Location = new Point(475, 87);
            txtTelefonoRemitente.Name = "txtTelefonoRemitente";
            txtTelefonoRemitente.ReadOnly = true;
            txtTelefonoRemitente.Size = new Size(160, 23);
            txtTelefonoRemitente.TabIndex = 13;
            // 
            // lblDomicilioRetiro
            // 
            lblDomicilioRetiro.AutoSize = true;
            lblDomicilioRetiro.Location = new Point(12, 125);
            lblDomicilioRetiro.Name = "lblDomicilioRetiro";
            lblDomicilioRetiro.Size = new Size(89, 15);
            lblDomicilioRetiro.TabIndex = 14;
            lblDomicilioRetiro.Text = "Domicilio retiro";
            // 
            // txtDomicilioRetiro
            // 
            txtDomicilioRetiro.Location = new Point(110, 122);
            txtDomicilioRetiro.Name = "txtDomicilioRetiro";
            txtDomicilioRetiro.ReadOnly = true;
            txtDomicilioRetiro.Size = new Size(350, 23);
            txtDomicilioRetiro.TabIndex = 15;
            // 
            // lblCiudadRetiro
            // 
            lblCiudadRetiro.AutoSize = true;
            lblCiudadRetiro.Location = new Point(480, 125);
            lblCiudadRetiro.Name = "lblCiudadRetiro";
            lblCiudadRetiro.Size = new Size(45, 15);
            lblCiudadRetiro.TabIndex = 16;
            lblCiudadRetiro.Text = "Ciudad";
            // 
            // txtCiudadRetiro
            // 
            txtCiudadRetiro.Location = new Point(530, 122);
            txtCiudadRetiro.Name = "txtCiudadRetiro";
            txtCiudadRetiro.ReadOnly = true;
            txtCiudadRetiro.Size = new Size(160, 23);
            txtCiudadRetiro.TabIndex = 17;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(12, 155);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(129, 15);
            lblGuiasIncluidas.TabIndex = 18;
            lblGuiasIncluidas.Text = "Guias incluidas en HDR";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colDestinatario, colTipoBulto, colCdDestino, colTipoEntrega });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(12, 173);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(803, 212);
            lvGuias.TabIndex = 19;
            lvGuias.UseCompatibleStateImageBehavior = false;
            lvGuias.View = View.Details;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guia";
            colNumeroGuia.Width = 110;
            // 
            // colDestinatario
            // 
            colDestinatario.Text = "Destinatario";
            colDestinatario.Width = 260;
            // 
            // colTipoBulto
            // 
            colTipoBulto.Text = "Tipo Bulto";
            colTipoBulto.Width = 100;
            // 
            // colCdDestino
            // 
            colCdDestino.Text = "CD Destino";
            colCdDestino.Width = 100;
            // 
            // colTipoEntrega
            // 
            colTipoEntrega.Text = "Tipo Entrega";
            colTipoEntrega.Width = 180;
            // 
            // lblCantidadGuias
            // 
            lblCantidadGuias.AutoSize = true;
            lblCantidadGuias.Location = new Point(12, 400);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(80, 15);
            lblCantidadGuias.TabIndex = 20;
            lblCantidadGuias.Text = "Total de guias";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(110, 397);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(80, 23);
            txtCantidadGuias.TabIndex = 21;
            // 
            // btnGenerarHdr
            // 
            btnGenerarHdr.Location = new Point(685, 394);
            btnGenerarHdr.Name = "btnGenerarHdr";
            btnGenerarHdr.Size = new Size(130, 30);
            btnGenerarHdr.TabIndex = 22;
            btnGenerarHdr.Text = "Generar HDR";
            btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // Retiro_Teo_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 438);
            Controls.Add(btnGenerarHdr);
            Controls.Add(txtCantidadGuias);
            Controls.Add(lblCantidadGuias);
            Controls.Add(lvGuias);
            Controls.Add(lblGuiasIncluidas);
            Controls.Add(txtCiudadRetiro);
            Controls.Add(lblCiudadRetiro);
            Controls.Add(txtDomicilioRetiro);
            Controls.Add(lblDomicilioRetiro);
            Controls.Add(txtTelefonoRemitente);
            Controls.Add(lblTelefonoRemitente);
            Controls.Add(txtRemitente);
            Controls.Add(lblRemitente);
            Controls.Add(cboFleteroAsignado);
            Controls.Add(lblFleteroAsignado);
            Controls.Add(txtCdEmisor);
            Controls.Add(lblCdEmisor);
            Controls.Add(txtEstadoHdr);
            Controls.Add(lblEstadoHdr);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(cboGuiaBase);
            Controls.Add(lblGuiaBase);
            Name = "Retiro_Teo_";
            Text = "Generacion de HDR de retiro";
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
        private System.Windows.Forms.Label lblFleteroAsignado;
        private System.Windows.Forms.ComboBox cboFleteroAsignado;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Label lblTelefonoRemitente;
        private System.Windows.Forms.TextBox txtTelefonoRemitente;
        private System.Windows.Forms.Label lblDomicilioRetiro;
        private System.Windows.Forms.TextBox txtDomicilioRetiro;
        private System.Windows.Forms.Label lblCiudadRetiro;
        private System.Windows.Forms.TextBox txtCiudadRetiro;
        private System.Windows.Forms.Label lblGuiasIncluidas;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader colNumeroGuia;
        private System.Windows.Forms.ColumnHeader colDestinatario;
        private System.Windows.Forms.ColumnHeader colTipoBulto;
        private System.Windows.Forms.ColumnHeader colCdDestino;
        private System.Windows.Forms.ColumnHeader colTipoEntrega;
        private System.Windows.Forms.Label lblCantidadGuias;
        private System.Windows.Forms.TextBox txtCantidadGuias;
        private System.Windows.Forms.Button btnGenerarHdr;
    }
}
