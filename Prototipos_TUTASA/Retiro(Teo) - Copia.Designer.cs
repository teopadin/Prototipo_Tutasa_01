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
            this.lblGuiaBase = new System.Windows.Forms.Label();
            this.cboGuiaBase = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoHdr = new System.Windows.Forms.Label();
            this.txtEstadoHdr = new System.Windows.Forms.TextBox();
            this.lblCdEmisor = new System.Windows.Forms.Label();
            this.txtCdEmisor = new System.Windows.Forms.TextBox();
            this.lblFleteroAsignado = new System.Windows.Forms.Label();
            this.cboFleteroAsignado = new System.Windows.Forms.ComboBox();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.lblTelefonoRemitente = new System.Windows.Forms.Label();
            this.txtTelefonoRemitente = new System.Windows.Forms.TextBox();
            this.lblDomicilioRetiro = new System.Windows.Forms.Label();
            this.txtDomicilioRetiro = new System.Windows.Forms.TextBox();
            this.lblCiudadRetiro = new System.Windows.Forms.Label();
            this.txtCiudadRetiro = new System.Windows.Forms.TextBox();
            this.lblGuiasIncluidas = new System.Windows.Forms.Label();
            this.lvGuias = new System.Windows.Forms.ListView();
            this.colNumeroGuia = new System.Windows.Forms.ColumnHeader();
            this.colDestinatario = new System.Windows.Forms.ColumnHeader();
            this.colTipoBulto = new System.Windows.Forms.ColumnHeader();
            this.colCdDestino = new System.Windows.Forms.ColumnHeader();
            this.colTipoEntrega = new System.Windows.Forms.ColumnHeader();
            this.lblCantidadGuias = new System.Windows.Forms.Label();
            this.txtCantidadGuias = new System.Windows.Forms.TextBox();
            this.btnGenerarHdr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGuiaBase
            // 
            this.lblGuiaBase.AutoSize = true;
            this.lblGuiaBase.Location = new System.Drawing.Point(12, 15);
            this.lblGuiaBase.Name = "lblGuiaBase";
            this.lblGuiaBase.Size = new System.Drawing.Size(56, 15);
            this.lblGuiaBase.TabIndex = 0;
            this.lblGuiaBase.Text = "Guia base";
            // 
            // cboGuiaBase
            // 
            this.cboGuiaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuiaBase.FormattingEnabled = true;
            this.cboGuiaBase.Location = new System.Drawing.Point(90, 12);
            this.cboGuiaBase.Name = "cboGuiaBase";
            this.cboGuiaBase.Size = new System.Drawing.Size(140, 23);
            this.cboGuiaBase.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(250, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(300, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 23);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblEstadoHdr
            // 
            this.lblEstadoHdr.AutoSize = true;
            this.lblEstadoHdr.Location = new System.Drawing.Point(440, 15);
            this.lblEstadoHdr.Name = "lblEstadoHdr";
            this.lblEstadoHdr.Size = new System.Drawing.Size(42, 15);
            this.lblEstadoHdr.TabIndex = 4;
            this.lblEstadoHdr.Text = "Estado";
            // 
            // txtEstadoHdr
            // 
            this.txtEstadoHdr.Location = new System.Drawing.Point(490, 12);
            this.txtEstadoHdr.Name = "txtEstadoHdr";
            this.txtEstadoHdr.ReadOnly = true;
            this.txtEstadoHdr.Size = new System.Drawing.Size(130, 23);
            this.txtEstadoHdr.TabIndex = 5;
            // 
            // lblCdEmisor
            // 
            this.lblCdEmisor.AutoSize = true;
            this.lblCdEmisor.Location = new System.Drawing.Point(12, 50);
            this.lblCdEmisor.Name = "lblCdEmisor";
            this.lblCdEmisor.Size = new System.Drawing.Size(58, 15);
            this.lblCdEmisor.TabIndex = 6;
            this.lblCdEmisor.Text = "CD emisor";
            // 
            // txtCdEmisor
            // 
            this.txtCdEmisor.Location = new System.Drawing.Point(90, 47);
            this.txtCdEmisor.Name = "txtCdEmisor";
            this.txtCdEmisor.ReadOnly = true;
            this.txtCdEmisor.Size = new System.Drawing.Size(140, 23);
            this.txtCdEmisor.TabIndex = 7;
            // 
            // lblFleteroAsignado
            // 
            this.lblFleteroAsignado.AutoSize = true;
            this.lblFleteroAsignado.Location = new System.Drawing.Point(250, 50);
            this.lblFleteroAsignado.Name = "lblFleteroAsignado";
            this.lblFleteroAsignado.Size = new System.Drawing.Size(94, 15);
            this.lblFleteroAsignado.TabIndex = 8;
            this.lblFleteroAsignado.Text = "Fletero asignado";
            // 
            // cboFleteroAsignado
            // 
            this.cboFleteroAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFleteroAsignado.FormattingEnabled = true;
            this.cboFleteroAsignado.Location = new System.Drawing.Point(360, 47);
            this.cboFleteroAsignado.Name = "cboFleteroAsignado";
            this.cboFleteroAsignado.Size = new System.Drawing.Size(180, 23);
            this.cboFleteroAsignado.TabIndex = 9;
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Location = new System.Drawing.Point(12, 90);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(58, 15);
            this.lblRemitente.TabIndex = 10;
            this.lblRemitente.Text = "Remitente";
            // 
            // txtRemitente
            // 
            this.txtRemitente.Location = new System.Drawing.Point(90, 87);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.ReadOnly = true;
            this.txtRemitente.Size = new System.Drawing.Size(250, 23);
            this.txtRemitente.TabIndex = 11;
            // 
            // lblTelefonoRemitente
            // 
            this.lblTelefonoRemitente.AutoSize = true;
            this.lblTelefonoRemitente.Location = new System.Drawing.Point(360, 90);
            this.lblTelefonoRemitente.Name = "lblTelefonoRemitente";
            this.lblTelefonoRemitente.Size = new System.Drawing.Size(103, 15);
            this.lblTelefonoRemitente.TabIndex = 12;
            this.lblTelefonoRemitente.Text = "Telefono remitente";
            // 
            // txtTelefonoRemitente
            // 
            this.txtTelefonoRemitente.Location = new System.Drawing.Point(475, 87);
            this.txtTelefonoRemitente.Name = "txtTelefonoRemitente";
            this.txtTelefonoRemitente.ReadOnly = true;
            this.txtTelefonoRemitente.Size = new System.Drawing.Size(160, 23);
            this.txtTelefonoRemitente.TabIndex = 13;
            // 
            // lblDomicilioRetiro
            // 
            this.lblDomicilioRetiro.AutoSize = true;
            this.lblDomicilioRetiro.Location = new System.Drawing.Point(12, 125);
            this.lblDomicilioRetiro.Name = "lblDomicilioRetiro";
            this.lblDomicilioRetiro.Size = new System.Drawing.Size(91, 15);
            this.lblDomicilioRetiro.TabIndex = 14;
            this.lblDomicilioRetiro.Text = "Domicilio retiro";
            // 
            // txtDomicilioRetiro
            // 
            this.txtDomicilioRetiro.Location = new System.Drawing.Point(110, 122);
            this.txtDomicilioRetiro.Name = "txtDomicilioRetiro";
            this.txtDomicilioRetiro.ReadOnly = true;
            this.txtDomicilioRetiro.Size = new System.Drawing.Size(350, 23);
            this.txtDomicilioRetiro.TabIndex = 15;
            // 
            // lblCiudadRetiro
            // 
            this.lblCiudadRetiro.AutoSize = true;
            this.lblCiudadRetiro.Location = new System.Drawing.Point(480, 125);
            this.lblCiudadRetiro.Name = "lblCiudadRetiro";
            this.lblCiudadRetiro.Size = new System.Drawing.Size(43, 15);
            this.lblCiudadRetiro.TabIndex = 16;
            this.lblCiudadRetiro.Text = "Ciudad";
            // 
            // txtCiudadRetiro
            // 
            this.txtCiudadRetiro.Location = new System.Drawing.Point(530, 122);
            this.txtCiudadRetiro.Name = "txtCiudadRetiro";
            this.txtCiudadRetiro.ReadOnly = true;
            this.txtCiudadRetiro.Size = new System.Drawing.Size(160, 23);
            this.txtCiudadRetiro.TabIndex = 17;
            // 
            // lblGuiasIncluidas
            // 
            this.lblGuiasIncluidas.AutoSize = true;
            this.lblGuiasIncluidas.Location = new System.Drawing.Point(12, 155);
            this.lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            this.lblGuiasIncluidas.Size = new System.Drawing.Size(122, 15);
            this.lblGuiasIncluidas.TabIndex = 18;
            this.lblGuiasIncluidas.Text = "Guias incluidas en HDR";
            // 
            // lvGuias
            // 
            this.lvGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
this.colNumeroGuia,
this.colDestinatario,
this.colTipoBulto,
this.colCdDestino,
this.colTipoEntrega});
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = false;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(12, 173);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(803, 212);
            this.lvGuias.TabIndex = 19;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;

            // 
            // colNumeroGuia
            // 
            this.colNumeroGuia.Text = "Nro Guia";
            this.colNumeroGuia.Width = 110;
            // 
            // colDestinatario
            // 
            this.colDestinatario.Text = "Destinatario";
            this.colDestinatario.Width = 260;
            // 
            // colTipoBulto
            // 
            this.colTipoBulto.Text = "Tipo Bulto";
            this.colTipoBulto.Width = 100;
            // 
            // colCdDestino
            // 
            this.colCdDestino.Text = "CD Destino";
            this.colCdDestino.Width = 100;
            // 
            // colTipoEntrega
            // 
            this.colTipoEntrega.Text = "Tipo Entrega";
            this.colTipoEntrega.Width = 180;

            // 
            // lblCantidadGuias
            // 
            this.lblCantidadGuias.AutoSize = true;
            this.lblCantidadGuias.Location = new System.Drawing.Point(12, 400);
            this.lblCantidadGuias.Name = "lblCantidadGuias";
            this.lblCantidadGuias.Size = new System.Drawing.Size(87, 15);
            this.lblCantidadGuias.TabIndex = 20;
            this.lblCantidadGuias.Text = "Total de guias";
            // 
            // txtCantidadGuias
            // 
            this.txtCantidadGuias.Location = new System.Drawing.Point(110, 397);
            this.txtCantidadGuias.Name = "txtCantidadGuias";
            this.txtCantidadGuias.ReadOnly = true;
            this.txtCantidadGuias.Size = new System.Drawing.Size(80, 23);
            this.txtCantidadGuias.TabIndex = 21;
            // 
            // btnGenerarHdr
            // 
            this.btnGenerarHdr.Location = new System.Drawing.Point(685, 394);
            this.btnGenerarHdr.Name = "btnGenerarHdr";
            this.btnGenerarHdr.Size = new System.Drawing.Size(130, 30);
            this.btnGenerarHdr.TabIndex = 22;
            this.btnGenerarHdr.Text = "Generar HDR";
            this.btnGenerarHdr.UseVisualStyleBackColor = true;
            // 
            // Retiro_Teo_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 438);
            this.Controls.Add(this.btnGenerarHdr);
            this.Controls.Add(this.txtCantidadGuias);
            this.Controls.Add(this.lblCantidadGuias);
            this.Controls.Add(this.lvGuias);
            this.Controls.Add(this.lblGuiasIncluidas);
            this.Controls.Add(this.txtCiudadRetiro);
            this.Controls.Add(this.lblCiudadRetiro);
            this.Controls.Add(this.txtDomicilioRetiro);
            this.Controls.Add(this.lblDomicilioRetiro);
            this.Controls.Add(this.txtTelefonoRemitente);
            this.Controls.Add(this.lblTelefonoRemitente);
            this.Controls.Add(this.txtRemitente);
            this.Controls.Add(this.lblRemitente);
            this.Controls.Add(this.cboFleteroAsignado);
            this.Controls.Add(this.lblFleteroAsignado);
            this.Controls.Add(this.txtCdEmisor);
            this.Controls.Add(this.lblCdEmisor);
            this.Controls.Add(this.txtEstadoHdr);
            this.Controls.Add(this.lblEstadoHdr);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboGuiaBase);
            this.Controls.Add(this.lblGuiaBase);
            this.Name = "Retiro_Teo_";
            this.Text = "Generacion de HDR de retiro";
            this.ResumeLayout(false);
            this.PerformLayout();
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
