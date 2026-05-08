namespace Prototipos_TUTASA.Generación_Resumen_HDR.Generación_Resumen_HDR_Cumplidas
{
    partial class Generación_HDR_Rendidas
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
            dateTimePicker1 = new DateTimePicker();
            Fletero = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            HojRut = new ColumnHeader();
            Remitente = new ColumnHeader();
            Calle = new ColumnHeader();
            Altura = new ColumnHeader();
            CP = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label5 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(462, 45);
            label1.TabIndex = 1;
            label1.Text = "Resumen de Rendición de HDR";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(397, 97);
            Fletero.Margin = new Padding(4, 0, 4, 0);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(144, 25);
            Fletero.TabIndex = 18;
            Fletero.Text = "Fletero asignado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(397, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 192);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(306, 25);
            label4.TabIndex = 20;
            label4.Text = "Hojas de Ruta rendidas por el Fletero";
            // 
            // button1
            // 
            button1.Location = new Point(186, 511);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(170, 73);
            button1.TabIndex = 21;
            button1.Text = "Registrar Rendición";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(386, 511);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(170, 73);
            button2.TabIndex = 22;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente, Calle, Altura, CP, TipoBulto, columnHeader1 });
            listView1.Location = new Point(13, 234);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(763, 159);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HojRut
            // 
            HojRut.Text = "Nro de Hoja de Ruta";
            HojRut.Width = 200;
            // 
            // Remitente
            // 
            Remitente.Text = "Remitente";
            Remitente.Width = 100;
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
            // columnHeader1
            // 
            columnHeader1.Text = "Motivo";
            columnHeader1.Width = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 426);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 24;
            label5.Text = "Total HDR Rendidas";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 426);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 25;
            label2.Text = "Total HDR Cumplidas";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 456);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(193, 31);
            textBox4.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 456);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 426);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 28;
            label6.Text = "Total HDR no cumplidas";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 456);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(193, 31);
            textBox2.TabIndex = 29;
            // 
            // Generación_HDR_Rendidas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 605);
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
            Controls.Add(comboBox1);
            Controls.Add(Fletero);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Generación_HDR_Rendidas";
            Text = "Generación_HDR_Cumplidas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label Fletero;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente;
        private ColumnHeader Calle;
        private ColumnHeader Altura;
        private ColumnHeader CP;
        private ColumnHeader TipoBulto;
        private ColumnHeader columnHeader1;
        private Label label5;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
    }
}