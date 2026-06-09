namespace Prototipos_TUTASA.Rendiciones_HDR
{
    partial class Rendir_HDR_De_Retiro
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
            label3 = new Label();
            FechaDtp = new DateTimePicker();
            Fletero = new Label();
            FleteroCmb = new ComboBox();
            label4 = new Label();
            RegistratBtn = new Button();
            CancelarBtn = new Button();
            HDRRendidaLst = new ListView();
            HojRut = new ColumnHeader();
            Remitente = new ColumnHeader();
            Calle = new ColumnHeader();
            Altura = new ColumnHeader();
            Piso = new ColumnHeader();
            CP = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            label5 = new Label();
            label2 = new Label();
            TotalRendidasTxtb = new TextBox();
            TotalCumplidasTxtb = new TextBox();
            label6 = new Label();
            TotalNoCumplidasTxtb = new TextBox();
            groupBox1 = new GroupBox();
            AplicarBtn = new Button();
            label7 = new Label();
            MotivoCmb = new ComboBox();
            NoCumplidaRdb = new RadioButton();
            CumplidaRdb = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 45);
            label1.TabIndex = 1;
            label1.Text = "Rendición de HDR de Retiro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // FechaDtp
            // 
            FechaDtp.Location = new Point(29, 125);
            FechaDtp.Name = "FechaDtp";
            FechaDtp.Size = new Size(327, 31);
            FechaDtp.TabIndex = 17;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(397, 97);
            Fletero.Margin = new Padding(4, 0, 4, 0);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(236, 25);
            Fletero.TabIndex = 18;
            Fletero.Text = "Transportista Local asignado";
            // 
            // FleteroCmb
            // 
            FleteroCmb.FormattingEnabled = true;
            FleteroCmb.Location = new Point(397, 127);
            FleteroCmb.Name = "FleteroCmb";
            FleteroCmb.Size = new Size(236, 33);
            FleteroCmb.TabIndex = 19;
            FleteroCmb.SelectedIndexChanged += FleteroCmb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 192);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(398, 25);
            label4.TabIndex = 20;
            label4.Text = "Hojas de Ruta rendidas por el Transportista Local";
            // 
            // RegistratBtn
            // 
            RegistratBtn.Location = new Point(203, 772);
            RegistratBtn.Margin = new Padding(4, 5, 4, 5);
            RegistratBtn.Name = "RegistratBtn";
            RegistratBtn.Size = new Size(170, 73);
            RegistratBtn.TabIndex = 21;
            RegistratBtn.Text = "Registrar Rendición";
            RegistratBtn.UseVisualStyleBackColor = true;
            RegistratBtn.Click += RegistratBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(381, 772);
            CancelarBtn.Margin = new Padding(4, 5, 4, 5);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(170, 73);
            CancelarBtn.TabIndex = 22;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // HDRRendidaLst
            // 
            HDRRendidaLst.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente, Calle, Altura, Piso, CP, TipoBulto });
            HDRRendidaLst.Location = new Point(13, 234);
            HDRRendidaLst.Margin = new Padding(4, 5, 4, 5);
            HDRRendidaLst.Name = "HDRRendidaLst";
            HDRRendidaLst.Size = new Size(802, 159);
            HDRRendidaLst.TabIndex = 23;
            HDRRendidaLst.UseCompatibleStateImageBehavior = false;
            HDRRendidaLst.View = View.Details;
            HDRRendidaLst.SelectedIndexChanged += HDRRendidaLst_SelectedIndexChanged;
            // 
            // HojRut
            // 
            HojRut.Text = "Nro de Hoja de Ruta";
            HojRut.Width = 200;
            // 
            // Remitente
            // 
            Remitente.Text = "Remitente";
            Remitente.Width = 210;
            // 
            // Calle
            // 
            Calle.Text = "Calle";
            Calle.Width = 100;
            // 
            // Altura
            // 
            Altura.Text = "Altura";
            Altura.Width = 70;
            // 
            // Piso
            // 
            Piso.Text = "Piso";
            // 
            // CP
            // 
            CP.Text = "CP";
            CP.Width = 80;
            // 
            // TipoBulto
            // 
            TipoBulto.Text = "Estado";
            TipoBulto.Width = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 682);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 24;
            label5.Text = "Total HDR Rendidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 682);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 25;
            label2.Text = "Total HDR Cumplidas";
            // 
            // TotalRendidasTxtb
            // 
            TotalRendidasTxtb.Location = new Point(16, 712);
            TotalRendidasTxtb.Margin = new Padding(4, 5, 4, 5);
            TotalRendidasTxtb.Name = "TotalRendidasTxtb";
            TotalRendidasTxtb.ReadOnly = true;
            TotalRendidasTxtb.Size = new Size(261, 31);
            TotalRendidasTxtb.TabIndex = 26;
            // 
            // TotalCumplidasTxtb
            // 
            TotalCumplidasTxtb.Location = new Point(285, 712);
            TotalCumplidasTxtb.Margin = new Padding(4, 5, 4, 5);
            TotalCumplidasTxtb.Name = "TotalCumplidasTxtb";
            TotalCumplidasTxtb.ReadOnly = true;
            TotalCumplidasTxtb.Size = new Size(255, 31);
            TotalCumplidasTxtb.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(548, 682);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 28;
            label6.Text = "Total HDR no cumplidas";
            // 
            // TotalNoCumplidasTxtb
            // 
            TotalNoCumplidasTxtb.Location = new Point(548, 712);
            TotalNoCumplidasTxtb.Margin = new Padding(4, 5, 4, 5);
            TotalNoCumplidasTxtb.Name = "TotalNoCumplidasTxtb";
            TotalNoCumplidasTxtb.ReadOnly = true;
            TotalNoCumplidasTxtb.Size = new Size(270, 31);
            TotalNoCumplidasTxtb.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AplicarBtn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(MotivoCmb);
            groupBox1.Controls.Add(NoCumplidaRdb);
            groupBox1.Controls.Add(CumplidaRdb);
            groupBox1.Location = new Point(16, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 256);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado de la HDR seleccionada (\"\")";
            // 
            // AplicarBtn
            // 
            AplicarBtn.Location = new Point(646, 190);
            AplicarBtn.Name = "AplicarBtn";
            AplicarBtn.Size = new Size(147, 60);
            AplicarBtn.TabIndex = 32;
            AplicarBtn.Text = "Aplicar";
            AplicarBtn.UseVisualStyleBackColor = true;
            AplicarBtn.Click += AplicarBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 80);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(239, 25);
            label7.TabIndex = 31;
            label7.Text = "Motivo (solo si no cumplida)";
            // 
            // MotivoCmb
            // 
            MotivoCmb.FormattingEnabled = true;
            MotivoCmb.Location = new Point(227, 108);
            MotivoCmb.Name = "MotivoCmb";
            MotivoCmb.Size = new Size(261, 33);
            MotivoCmb.TabIndex = 2;
            // 
            // NoCumplidaRdb
            // 
            NoCumplidaRdb.AutoSize = true;
            NoCumplidaRdb.Location = new Point(227, 48);
            NoCumplidaRdb.Name = "NoCumplidaRdb";
            NoCumplidaRdb.Size = new Size(139, 29);
            NoCumplidaRdb.TabIndex = 1;
            NoCumplidaRdb.TabStop = true;
            NoCumplidaRdb.Text = "No cumplida";
            NoCumplidaRdb.UseVisualStyleBackColor = true;
            NoCumplidaRdb.CheckedChanged += NoCumplidaRdb_CheckedChanged;
            // 
            // CumplidaRdb
            // 
            CumplidaRdb.AutoSize = true;
            CumplidaRdb.Location = new Point(43, 47);
            CumplidaRdb.Name = "CumplidaRdb";
            CumplidaRdb.Size = new Size(113, 29);
            CumplidaRdb.TabIndex = 0;
            CumplidaRdb.TabStop = true;
            CumplidaRdb.Text = "Cumplida";
            CumplidaRdb.UseVisualStyleBackColor = true;
            CumplidaRdb.CheckedChanged += CumplidaRdb_CheckedChanged;
            // 
            // Rendir_HDR_De_Retiro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 859);
            Controls.Add(groupBox1);
            Controls.Add(TotalNoCumplidasTxtb);
            Controls.Add(label6);
            Controls.Add(TotalCumplidasTxtb);
            Controls.Add(TotalRendidasTxtb);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(HDRRendidaLst);
            Controls.Add(CancelarBtn);
            Controls.Add(RegistratBtn);
            Controls.Add(label4);
            Controls.Add(FleteroCmb);
            Controls.Add(Fletero);
            Controls.Add(FechaDtp);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Rendir_HDR_De_Retiro";
            Text = "Rendición HDR de Retiro";
            Load += Rendir_HDR_De_Retiro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker FechaDtp;
        private Label Fletero;
        private ComboBox FleteroCmb;
        private Label label4;
        private Button RegistratBtn;
        private Button CancelarBtn;
        private ListView HDRRendidaLst;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente;
        private ColumnHeader Calle;
        private ColumnHeader Altura;
        private ColumnHeader CP;
        private ColumnHeader TipoBulto;
        private Label label5;
        private Label label2;
        private TextBox TotalRendidasTxtb;
        private TextBox TotalCumplidasTxtb;
        private Label label6;
        private TextBox TotalNoCumplidasTxtb;
        private GroupBox groupBox1;
        private RadioButton NoCumplidaRdb;
        private RadioButton CumplidaRdb;
        private Button AplicarBtn;
        private Label label7;
        private ComboBox MotivoCmb;
        private ColumnHeader Piso;
    }
}