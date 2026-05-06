namespace Prototipos_TUTASA
{
    partial class Admision_Teo_
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
            lblNumeroGuia = new Label();
            txtNumeroGuia = new TextBox();
            btnBuscar = new Button();
            lblFechaAdmision = new Label();
            dtpFechaAdmision = new DateTimePicker();
            lblCdReceptor = new Label();
            txtCdReceptor = new TextBox();
            lblRemitente = new Label();
            txtRemitente = new TextBox();
            lblDestinatario = new Label();
            txtDestinatario = new TextBox();
            lblTipoBulto = new Label();
            txtTipoBulto = new TextBox();
            lblCdDestino = new Label();
            txtCdDestino = new TextBox();
            lblTipoEntrega = new Label();
            txtTipoEntrega = new TextBox();
            btnConfirmarAdmision = new Button();
            btnRechazarAdmision = new Button();
            SuspendLayout();
            // 
            // lblNumeroGuia
            // 
            lblNumeroGuia.AutoSize = true;
            lblNumeroGuia.Location = new Point(29, 41);
            lblNumeroGuia.Margin = new Padding(7, 0, 7, 0);
            lblNumeroGuia.Name = "lblNumeroGuia";
            lblNumeroGuia.Size = new Size(175, 41);
            lblNumeroGuia.TabIndex = 0;
            lblNumeroGuia.Text = "Nro de guia";
            // 
            // txtNumeroGuia
            // 
            txtNumeroGuia.Location = new Point(231, 33);
            txtNumeroGuia.Margin = new Padding(7, 8, 7, 8);
            txtNumeroGuia.Name = "txtNumeroGuia";
            txtNumeroGuia.Size = new Size(334, 47);
            txtNumeroGuia.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(607, 27);
            btnBuscar.Margin = new Padding(7, 8, 7, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(219, 74);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFechaAdmision
            // 
            lblFechaAdmision.AutoSize = true;
            lblFechaAdmision.Location = new Point(29, 150);
            lblFechaAdmision.Margin = new Padding(7, 0, 7, 0);
            lblFechaAdmision.Name = "lblFechaAdmision";
            lblFechaAdmision.Size = new Size(224, 41);
            lblFechaAdmision.TabIndex = 3;
            lblFechaAdmision.Text = "Fecha admision";
            // 
            // dtpFechaAdmision
            // 
            dtpFechaAdmision.Enabled = false;
            dtpFechaAdmision.Format = DateTimePickerFormat.Short;
            dtpFechaAdmision.Location = new Point(267, 142);
            dtpFechaAdmision.Margin = new Padding(7, 8, 7, 8);
            dtpFechaAdmision.Name = "dtpFechaAdmision";
            dtpFechaAdmision.Size = new Size(286, 47);
            dtpFechaAdmision.TabIndex = 4;
            // 
            // lblCdReceptor
            // 
            lblCdReceptor.AutoSize = true;
            lblCdReceptor.Location = new Point(631, 150);
            lblCdReceptor.Margin = new Padding(7, 0, 7, 0);
            lblCdReceptor.Name = "lblCdReceptor";
            lblCdReceptor.Size = new Size(178, 41);
            lblCdReceptor.TabIndex = 5;
            lblCdReceptor.Text = "CD receptor";
            // 
            // txtCdReceptor
            // 
            txtCdReceptor.Location = new Point(826, 142);
            txtCdReceptor.Margin = new Padding(7, 8, 7, 8);
            txtCdReceptor.Name = "txtCdReceptor";
            txtCdReceptor.ReadOnly = true;
            txtCdReceptor.Size = new Size(286, 47);
            txtCdReceptor.TabIndex = 6;
            // 
            // lblRemitente
            // 
            lblRemitente.AutoSize = true;
            lblRemitente.Location = new Point(29, 260);
            lblRemitente.Margin = new Padding(7, 0, 7, 0);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(153, 41);
            lblRemitente.TabIndex = 7;
            lblRemitente.Text = "Remitente";
            // 
            // txtRemitente
            // 
            txtRemitente.Location = new Point(231, 251);
            txtRemitente.Margin = new Padding(7, 8, 7, 8);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.ReadOnly = true;
            txtRemitente.Size = new Size(881, 47);
            txtRemitente.TabIndex = 8;
            // 
            // lblDestinatario
            // 
            lblDestinatario.AutoSize = true;
            lblDestinatario.Location = new Point(29, 355);
            lblDestinatario.Margin = new Padding(7, 0, 7, 0);
            lblDestinatario.Name = "lblDestinatario";
            lblDestinatario.Size = new Size(177, 41);
            lblDestinatario.TabIndex = 9;
            lblDestinatario.Text = "Destinatario";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(231, 347);
            txtDestinatario.Margin = new Padding(7, 8, 7, 8);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.ReadOnly = true;
            txtDestinatario.Size = new Size(881, 47);
            txtDestinatario.TabIndex = 10;
            // 
            // lblTipoBulto
            // 
            lblTipoBulto.AutoSize = true;
            lblTipoBulto.Location = new Point(29, 451);
            lblTipoBulto.Margin = new Padding(7, 0, 7, 0);
            lblTipoBulto.Name = "lblTipoBulto";
            lblTipoBulto.Size = new Size(155, 41);
            lblTipoBulto.TabIndex = 11;
            lblTipoBulto.Text = "Tipo bulto";
            // 
            // txtTipoBulto
            // 
            txtTipoBulto.Location = new Point(231, 443);
            txtTipoBulto.Margin = new Padding(7, 8, 7, 8);
            txtTipoBulto.Name = "txtTipoBulto";
            txtTipoBulto.ReadOnly = true;
            txtTipoBulto.Size = new Size(286, 47);
            txtTipoBulto.TabIndex = 12;
            // 
            // lblCdDestino
            // 
            lblCdDestino.AutoSize = true;
            lblCdDestino.Location = new Point(583, 451);
            lblCdDestino.Margin = new Padding(7, 0, 7, 0);
            lblCdDestino.Name = "lblCdDestino";
            lblCdDestino.Size = new Size(165, 41);
            lblCdDestino.TabIndex = 13;
            lblCdDestino.Text = "CD destino";
            // 
            // txtCdDestino
            // 
            txtCdDestino.Location = new Point(765, 443);
            txtCdDestino.Margin = new Padding(7, 8, 7, 8);
            txtCdDestino.Name = "txtCdDestino";
            txtCdDestino.ReadOnly = true;
            txtCdDestino.Size = new Size(346, 47);
            txtCdDestino.TabIndex = 14;
            // 
            // lblTipoEntrega
            // 
            lblTipoEntrega.AutoSize = true;
            lblTipoEntrega.Location = new Point(29, 547);
            lblTipoEntrega.Margin = new Padding(7, 0, 7, 0);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(187, 41);
            lblTipoEntrega.TabIndex = 15;
            lblTipoEntrega.Text = "Tipo entrega";
            // 
            // txtTipoEntrega
            // 
            txtTipoEntrega.Location = new Point(231, 538);
            txtTipoEntrega.Margin = new Padding(7, 8, 7, 8);
            txtTipoEntrega.Name = "txtTipoEntrega";
            txtTipoEntrega.ReadOnly = true;
            txtTipoEntrega.Size = new Size(431, 47);
            txtTipoEntrega.TabIndex = 16;
            // 
            // btnConfirmarAdmision
            // 
            btnConfirmarAdmision.Location = new Point(231, 670);
            btnConfirmarAdmision.Margin = new Padding(7, 8, 7, 8);
            btnConfirmarAdmision.Name = "btnConfirmarAdmision";
            btnConfirmarAdmision.Size = new Size(364, 87);
            btnConfirmarAdmision.TabIndex = 17;
            btnConfirmarAdmision.Text = "Confirmar admision";
            btnConfirmarAdmision.UseVisualStyleBackColor = true;
            // 
            // btnRechazarAdmision
            // 
            btnRechazarAdmision.Location = new Point(656, 670);
            btnRechazarAdmision.Margin = new Padding(7, 8, 7, 8);
            btnRechazarAdmision.Name = "btnRechazarAdmision";
            btnRechazarAdmision.Size = new Size(364, 87);
            btnRechazarAdmision.TabIndex = 18;
            btnRechazarAdmision.Text = "Rechazar admision";
            btnRechazarAdmision.UseVisualStyleBackColor = true;
            // 
            // Admision_Teo_
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 825);
            Controls.Add(btnRechazarAdmision);
            Controls.Add(btnConfirmarAdmision);
            Controls.Add(txtTipoEntrega);
            Controls.Add(lblTipoEntrega);
            Controls.Add(txtCdDestino);
            Controls.Add(lblCdDestino);
            Controls.Add(txtTipoBulto);
            Controls.Add(lblTipoBulto);
            Controls.Add(txtDestinatario);
            Controls.Add(lblDestinatario);
            Controls.Add(txtRemitente);
            Controls.Add(lblRemitente);
            Controls.Add(txtCdReceptor);
            Controls.Add(lblCdReceptor);
            Controls.Add(dtpFechaAdmision);
            Controls.Add(lblFechaAdmision);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroGuia);
            Controls.Add(lblNumeroGuia);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Admision_Teo_";
            Text = "Admision";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNumeroGuia;
        private System.Windows.Forms.TextBox txtNumeroGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaAdmision;
        private System.Windows.Forms.DateTimePicker dtpFechaAdmision;
        private System.Windows.Forms.Label lblCdReceptor;
        private System.Windows.Forms.TextBox txtCdReceptor;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblTipoBulto;
        private System.Windows.Forms.TextBox txtTipoBulto;
        private System.Windows.Forms.Label lblCdDestino;
        private System.Windows.Forms.TextBox txtCdDestino;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.TextBox txtTipoEntrega;
        private System.Windows.Forms.Button btnConfirmarAdmision;
        private System.Windows.Forms.Button btnRechazarAdmision;
    }
}
