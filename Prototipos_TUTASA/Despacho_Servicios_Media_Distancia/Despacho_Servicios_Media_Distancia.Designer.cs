namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    partial class Despacho_Servicios_Media_Distancia
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
            lblTitulo = new Label();
            ServicioCmb = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            FechaDtp = new DateTimePicker();
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            DespachoLst = new ListView();
            NroGuia = new ColumnHeader();
            Remitente = new ColumnHeader();
            Destinatario = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            label4 = new Label();
            BultoTxtb = new TextBox();
            label2 = new Label();
            TotalBultoTxtb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CdDestinoTxtb = new TextBox();
            EmpresaTxtb = new TextBox();
            IdServicioTxtb = new TextBox();
            label8 = new Label();
            label9 = new Label();
            TotalGeneralTxtb = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(11, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(736, 47);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Despacho de Servicios de Media Distancia";
            // 
            // ServicioCmb
            // 
            ServicioCmb.FormattingEnabled = true;
            ServicioCmb.Location = new Point(233, 137);
            ServicioCmb.Name = "ServicioCmb";
            ServicioCmb.Size = new Size(393, 33);
            ServicioCmb.TabIndex = 3;
            ServicioCmb.SelectedIndexChanged += ServicioCmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 138);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 4;
            label1.Text = "Nro Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 19;
            label3.Text = "Fecha de Despacho";
            // 
            // FechaDtp
            // 
            FechaDtp.Location = new Point(233, 82);
            FechaDtp.Name = "FechaDtp";
            FechaDtp.Size = new Size(393, 31);
            FechaDtp.TabIndex = 30;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(279, 703);
            ConfirmarBtn.Margin = new Padding(4, 5, 4, 5);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(170, 73);
            ConfirmarBtn.TabIndex = 31;
            ConfirmarBtn.Text = "Confirmar despacho";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(456, 703);
            CancelarBtn.Margin = new Padding(4, 5, 4, 5);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(170, 73);
            CancelarBtn.TabIndex = 32;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // DespachoLst
            // 
            DespachoLst.Columns.AddRange(new ColumnHeader[] { NroGuia, Remitente, Destinatario, TipoBulto });
            DespachoLst.Location = new Point(30, 343);
            DespachoLst.Margin = new Padding(4, 5, 4, 5);
            DespachoLst.Name = "DespachoLst";
            DespachoLst.Size = new Size(945, 181);
            DespachoLst.TabIndex = 33;
            DespachoLst.UseCompatibleStateImageBehavior = false;
            DespachoLst.View = View.Details;
            // 
            // NroGuia
            // 
            NroGuia.Text = "Nro Guía";
            NroGuia.Width = 150;
            // 
            // Remitente
            // 
            Remitente.Text = "Remitente";
            Remitente.Width = 150;
            // 
            // Destinatario
            // 
            Destinatario.Text = "Destinatario";
            Destinatario.Width = 200;
            // 
            // TipoBulto
            // 
            TipoBulto.Text = "Tipo de bulto";
            TipoBulto.Width = 500;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 548);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 34;
            label4.Text = "Bultos (equiv. en S)";
            // 
            // BultoTxtb
            // 
            BultoTxtb.Location = new Point(189, 547);
            BultoTxtb.Margin = new Padding(1, 2, 1, 2);
            BultoTxtb.Name = "BultoTxtb";
            BultoTxtb.ReadOnly = true;
            BultoTxtb.Size = new Size(110, 31);
            BultoTxtb.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 552);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 36;
            label2.Text = "Total de Bultos";
            // 
            // TotalBultoTxtb
            // 
            TotalBultoTxtb.Location = new Point(451, 547);
            TotalBultoTxtb.Margin = new Padding(1, 2, 1, 2);
            TotalBultoTxtb.Name = "TotalBultoTxtb";
            TotalBultoTxtb.ReadOnly = true;
            TotalBultoTxtb.Size = new Size(110, 31);
            TotalBultoTxtb.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 197);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 38;
            label5.Text = "CD Destino";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 242);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 39;
            label6.Text = "Empresa de ómnibus";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 287);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 40;
            label7.Text = "ID Servicio";
            // 
            // CdDestinoTxtb
            // 
            CdDestinoTxtb.Location = new Point(233, 192);
            CdDestinoTxtb.Name = "CdDestinoTxtb";
            CdDestinoTxtb.ReadOnly = true;
            CdDestinoTxtb.Size = new Size(393, 31);
            CdDestinoTxtb.TabIndex = 41;
            // 
            // EmpresaTxtb
            // 
            EmpresaTxtb.Location = new Point(233, 238);
            EmpresaTxtb.Name = "EmpresaTxtb";
            EmpresaTxtb.ReadOnly = true;
            EmpresaTxtb.Size = new Size(393, 31);
            EmpresaTxtb.TabIndex = 42;
            // 
            // IdServicioTxtb
            // 
            IdServicioTxtb.Location = new Point(233, 287);
            IdServicioTxtb.Name = "IdServicioTxtb";
            IdServicioTxtb.ReadOnly = true;
            IdServicioTxtb.Size = new Size(393, 31);
            IdServicioTxtb.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(244, 662);
            label8.Name = "label8";
            label8.Size = new Size(473, 25);
            label8.TabIndex = 44;
            label8.Text = "Al confirmar, se emitirán 3 copias de la HDR de Transporte";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(591, 552);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(260, 25);
            label9.TabIndex = 45;
            label9.Text = "Bultos Pendientes de Despacho";
            // 
            // TotalGeneralTxtb
            // 
            TotalGeneralTxtb.Location = new Point(856, 548);
            TotalGeneralTxtb.Margin = new Padding(1, 2, 1, 2);
            TotalGeneralTxtb.Name = "TotalGeneralTxtb";
            TotalGeneralTxtb.ReadOnly = true;
            TotalGeneralTxtb.Size = new Size(118, 31);
            TotalGeneralTxtb.TabIndex = 46;
            // 
            // Despacho_Servicios_Media_Distancia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 817);
            Controls.Add(TotalGeneralTxtb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(IdServicioTxtb);
            Controls.Add(EmpresaTxtb);
            Controls.Add(CdDestinoTxtb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TotalBultoTxtb);
            Controls.Add(label2);
            Controls.Add(BultoTxtb);
            Controls.Add(label4);
            Controls.Add(DespachoLst);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(FechaDtp);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ServicioCmb);
            Controls.Add(lblTitulo);
            Name = "Despacho_Servicios_Media_Distancia";
            Text = "Despacho_Servicios_Media_Distancia";
            Load += Despacho_Servicios_Media_Distancia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox ServicioCmb;
        private Label label1;
        private Label label3;
        private DateTimePicker FechaDtp;
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ListView DespachoLst;
        private ColumnHeader NroGuia;
        private ColumnHeader Remitente;
        private ColumnHeader Destinatario;
        private ColumnHeader TipoBulto;
        private Label label4;
        private TextBox BultoTxtb;
        private Label label2;
        private TextBox TotalBultoTxtb;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox CdDestinoTxtb;
        private TextBox EmpresaTxtb;
        private TextBox IdServicioTxtb;
        private Label label8;
        private Label label9;
        private TextBox TotalGeneralTxtb;
    }
}