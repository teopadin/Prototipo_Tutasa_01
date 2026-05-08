namespace Prototipos_TUTASA
{
    partial class Resumen_HDR_Retiro
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
            Fletero = new Label();
            listView1 = new ListView();
            HojRut = new ColumnHeader();
            Remitente = new ColumnHeader();
            Calle = new ColumnHeader();
            Altura = new ColumnHeader();
            CP = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            columnHeader1 = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 45);
            label1.TabIndex = 0;
            label1.Text = "Resumen Hoja de Ruta de Retiro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 3;
            label3.Text = "Fecha";
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(384, 119);
            Fletero.Margin = new Padding(4, 0, 4, 0);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(144, 25);
            Fletero.TabIndex = 5;
            Fletero.Text = "Fletero asignado";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente, columnHeader1, Calle, Altura, CP, TipoBulto });
            listView1.Location = new Point(30, 287);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(762, 159);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HojRut
            // 
            HojRut.Text = "Nro de Hoja de Retiro";
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
            TipoBulto.Text = "Cant de Bultos";
            TipoBulto.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(344, 25);
            label4.TabIndex = 8;
            label4.Text = "Hoja de Ruta de Retiro asignada al Fletero";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 502);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(193, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(264, 502);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(163, 31);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 472);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 11;
            label6.Text = "Total Bultos a Retirar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 472);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 25);
            label5.TabIndex = 9;
            label5.Text = "Total Domicilios a Visitar";
            // 
            // button1
            // 
            button1.Location = new Point(123, 563);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(170, 73);
            button1.TabIndex = 13;
            button1.Text = "Generar Resumen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(358, 563);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(170, 73);
            button2.TabIndex = 14;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(384, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 15;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Localidad";
            columnHeader1.Width = 100;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(40, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 16;
            // 
            // Resumen_HDR_Retiro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 658);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(Fletero);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Resumen_HDR_Retiro";
            Text = "ResumenHDR";
            Load += ResumenHDR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label Fletero;
        private ListView listView1;
        private Label label4;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente;
        private ColumnHeader Calle;
        private ColumnHeader Altura;
        private ColumnHeader CP;
        private ColumnHeader TipoBulto;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}