namespace Prototipos_TUTASA.Rendiciones_HDR
{
    partial class Rendición_HDR_De_DIstribución
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
            button3 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            listView1 = new ListView();
            HojRut = new ColumnHeader();
            Remitente_Y_Destinatario = new ColumnHeader();
            Calle = new ColumnHeader();
            Altura = new ColumnHeader();
            CP = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            button2 = new Button();
            button1 = new Button();
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
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(2, 372);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 184);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado de la HDR seleccionada (\"\")";
            // 
            // button3
            // 
            button3.Location = new Point(315, 145);
            button3.Name = "button3";
            button3.Size = new Size(138, 33);
            button3.TabIndex = 32;
            button3.Text = "Aplicar";
            button3.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(43, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(261, 33);
            comboBox2.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(256, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(139, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "No cumplida";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(43, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cumplida";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(531, 598);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(270, 31);
            textBox2.TabIndex = 45;
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
            // textBox1
            // 
            textBox1.Location = new Point(268, 598);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(255, 31);
            textBox1.TabIndex = 43;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(-1, 598);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(261, 31);
            textBox4.TabIndex = 42;
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente_Y_Destinatario, Calle, Altura, CP, TipoBulto });
            listView1.Location = new Point(15, 206);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 159);
            listView1.TabIndex = 39;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // button2
            // 
            button2.Location = new Point(372, 653);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(170, 73);
            button2.TabIndex = 38;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(172, 653);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(170, 73);
            button1.TabIndex = 37;
            button1.Text = "Registrar Rendición";
            button1.UseVisualStyleBackColor = true;
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
            // Rendición_HDR_De_DIstribución
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 741);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(FleteroCMB);
            Controls.Add(Fletero);
            Controls.Add(FechaDtp);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Rendición_HDR_De_DIstribución";
            Text = "Rendición HDR de Distribución";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Label label7;
        private ComboBox comboBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label2;
        private Label label5;
        private ListView listView1;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente_Y_Destinatario;
        private ColumnHeader Calle;
        private ColumnHeader Altura;
        private ColumnHeader CP;
        private ColumnHeader TipoBulto;
        private Button button2;
        private Button button1;
        private Label label4;
        private ComboBox FleteroCMB;
        private Label Fletero;
        private DateTimePicker FechaDtp;
        private Label label3;
        private Label label1;
    }
}