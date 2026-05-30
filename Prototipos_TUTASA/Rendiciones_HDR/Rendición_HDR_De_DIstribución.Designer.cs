namespace Prototipos_TUTASA.Rendiciones_HDR
{
    partial class Rendición_HDR_De_Distribución
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
            groupBox1 = new GroupBox();
            AplicarBtn = new Button();
            label7 = new Label();
            MotivoCmb = new ComboBox();
            NoCumplidaRdb = new RadioButton();
            CumplidaRdb = new RadioButton();
            TotalNoCumplidasTxtb = new TextBox();
            label6 = new Label();
            TotalCumplidasTxtb = new TextBox();
            TotalRendidasTxtb = new TextBox();
            label2 = new Label();
            label5 = new Label();
            HdrRendidasLst = new ListView();
            HojRut = new ColumnHeader();
            Remitente_Y_Destinatario = new ColumnHeader();
            Calle = new ColumnHeader();
            Altura = new ColumnHeader();
            CP = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            CancelarBtn = new Button();
            RegistrarBtn = new Button();
            label4 = new Label();
            FleteroCMB = new ComboBox();
            Fletero = new Label();
            FechaDtp = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AplicarBtn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(MotivoCmb);
            groupBox1.Controls.Add(NoCumplidaRdb);
            groupBox1.Controls.Add(CumplidaRdb);
            groupBox1.Location = new Point(2, 372);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 184);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado de la HDR seleccionada (\"\")";
            // 
            // AplicarBtn
            // 
            AplicarBtn.Location = new Point(315, 145);
            AplicarBtn.Name = "AplicarBtn";
            AplicarBtn.Size = new Size(138, 33);
            AplicarBtn.TabIndex = 32;
            AplicarBtn.Text = "Aplicar";
            AplicarBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 105);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(239, 25);
            label7.TabIndex = 31;
            label7.Text = "Motivo (solo si no cumplida)";
            // 
            // MotivoCmb
            // 
            MotivoCmb.FormattingEnabled = true;
            MotivoCmb.Location = new Point(43, 145);
            MotivoCmb.Name = "MotivoCmb";
            MotivoCmb.Size = new Size(261, 33);
            MotivoCmb.TabIndex = 2;
            // 
            // NoCumplidaRdb
            // 
            NoCumplidaRdb.AutoSize = true;
            NoCumplidaRdb.Location = new Point(256, 47);
            NoCumplidaRdb.Name = "NoCumplidaRdb";
            NoCumplidaRdb.Size = new Size(139, 29);
            NoCumplidaRdb.TabIndex = 1;
            NoCumplidaRdb.TabStop = true;
            NoCumplidaRdb.Text = "No cumplida";
            NoCumplidaRdb.UseVisualStyleBackColor = true;
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
            // 
            // TotalNoCumplidasTxtb
            // 
            TotalNoCumplidasTxtb.Location = new Point(531, 598);
            TotalNoCumplidasTxtb.Margin = new Padding(4, 5, 4, 5);
            TotalNoCumplidasTxtb.Name = "TotalNoCumplidasTxtb";
            TotalNoCumplidasTxtb.ReadOnly = true;
            TotalNoCumplidasTxtb.Size = new Size(270, 31);
            TotalNoCumplidasTxtb.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 568);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 44;
            label6.Text = "Total HDR no cumplidas";
            // 
            // TotalCumplidasTxtb
            // 
            TotalCumplidasTxtb.Location = new Point(268, 598);
            TotalCumplidasTxtb.Margin = new Padding(4, 5, 4, 5);
            TotalCumplidasTxtb.Name = "TotalCumplidasTxtb";
            TotalCumplidasTxtb.ReadOnly = true;
            TotalCumplidasTxtb.Size = new Size(255, 31);
            TotalCumplidasTxtb.TabIndex = 43;
            // 
            // TotalRendidasTxtb
            // 
            TotalRendidasTxtb.Location = new Point(-1, 598);
            TotalRendidasTxtb.Margin = new Padding(4, 5, 4, 5);
            TotalRendidasTxtb.Name = "TotalRendidasTxtb";
            TotalRendidasTxtb.ReadOnly = true;
            TotalRendidasTxtb.Size = new Size(261, 31);
            TotalRendidasTxtb.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 568);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 41;
            label2.Text = "Total HDR Cumplidas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 568);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 40;
            label5.Text = "Total HDR Rendidas";
            // 
            // HdrRendidasLst
            // 
            HdrRendidasLst.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente_Y_Destinatario, Calle, Altura, CP, TipoBulto });
            HdrRendidasLst.Location = new Point(15, 206);
            HdrRendidasLst.Margin = new Padding(4, 5, 4, 5);
            HdrRendidasLst.Name = "HdrRendidasLst";
            HdrRendidasLst.Size = new Size(737, 159);
            HdrRendidasLst.TabIndex = 39;
            HdrRendidasLst.UseCompatibleStateImageBehavior = false;
            HdrRendidasLst.View = View.Details;
            // 
            // HojRut
            // 
            HojRut.Text = "Nro de Hoja de Ruta";
            HojRut.Width = 200;
            // 
            // Remitente_Y_Destinatario
            // 
            Remitente_Y_Destinatario.Text = "Destinatario";
            Remitente_Y_Destinatario.Width = 210;
            // 
            // Calle
            // 
            Calle.Text = "Calle";
            Calle.Width = 50;
            // 
            // Altura
            // 
            Altura.Text = "Altura";
            Altura.Width = 70;
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
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(372, 653);
            CancelarBtn.Margin = new Padding(4, 5, 4, 5);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(170, 73);
            CancelarBtn.TabIndex = 38;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrarBtn
            // 
            RegistrarBtn.Location = new Point(172, 653);
            RegistrarBtn.Margin = new Padding(4, 5, 4, 5);
            RegistrarBtn.Name = "RegistrarBtn";
            RegistrarBtn.Size = new Size(170, 73);
            RegistrarBtn.TabIndex = 37;
            RegistrarBtn.Text = "Registrar Rendición";
            RegistrarBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(306, 25);
            label4.TabIndex = 36;
            label4.Text = "Hojas de Ruta rendidas por el Fletero";
            // 
            // FleteroCMB
            // 
            FleteroCMB.FormattingEnabled = true;
            FleteroCMB.Location = new Point(383, 99);
            FleteroCMB.Name = "FleteroCMB";
            FleteroCMB.Size = new Size(182, 33);
            FleteroCMB.TabIndex = 35;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(383, 69);
            Fletero.Margin = new Padding(4, 0, 4, 0);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(144, 25);
            Fletero.TabIndex = 34;
            Fletero.Text = "Fletero asignado";
            // 
            // FechaDtp
            // 
            FechaDtp.Location = new Point(15, 97);
            FechaDtp.Name = "FechaDtp";
            FechaDtp.Size = new Size(327, 31);
            FechaDtp.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 32;
            label3.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 45);
            label1.TabIndex = 31;
            label1.Text = "Rendición de HDR de Distribución";
            // 
            // Rendición_HDR_De_Distribución
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 741);
            Controls.Add(groupBox1);
            Controls.Add(TotalNoCumplidasTxtb);
            Controls.Add(label6);
            Controls.Add(TotalCumplidasTxtb);
            Controls.Add(TotalRendidasTxtb);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(HdrRendidasLst);
            Controls.Add(CancelarBtn);
            Controls.Add(RegistrarBtn);
            Controls.Add(label4);
            Controls.Add(FleteroCMB);
            Controls.Add(Fletero);
            Controls.Add(FechaDtp);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Rendición_HDR_De_Distribución";
            Text = "Rendición HDR de Distribución";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button AplicarBtn;
        private Label label7;
        private ComboBox MotivoCmb;
        private RadioButton NoCumplidaRdb;
        private RadioButton CumplidaRdb;
        private TextBox TotalNoCumplidasTxtb;
        private Label label6;
        private TextBox TotalCumplidasTxtb;
        private TextBox TotalRendidasTxtb;
        private Label label2;
        private Label label5;
        private ListView HdrRendidasLst;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente_Y_Destinatario;
        private ColumnHeader Calle;
        private ColumnHeader Altura;
        private ColumnHeader CP;
        private ColumnHeader TipoBulto;
        private Button CancelarBtn;
        private Button RegistrarBtn;
        private Label label4;
        private ComboBox FleteroCMB;
        private Label Fletero;
        private DateTimePicker FechaDtp;
        private Label label3;
        private Label label1;
    }
}