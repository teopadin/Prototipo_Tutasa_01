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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            Fletero = new Label();
            listView1 = new ListView();
            label4 = new Label();
            HojRut = new ColumnHeader();
            Remitente = new ColumnHeader();
            Calle = new ColumnHeader();
            Altura = new ColumnHeader();
            CP = new ColumnHeader();
            TipoBulto = new ColumnHeader();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(314, 30);
            label1.TabIndex = 0;
            label1.Text = "Resumen Hoja de Ruta de Retiro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "CD Emisor (FIJO)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 78);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(316, 78);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(94, 15);
            Fletero.TabIndex = 5;
            Fletero.Text = "Fletero asignado";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente, Calle, Altura, CP, TipoBulto });
            listView1.Location = new Point(21, 172);
            listView1.Name = "listView1";
            listView1.Size = new Size(419, 97);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 144);
            label4.Name = "label4";
            label4.Size = new Size(226, 15);
            label4.TabIndex = 8;
            label4.Text = "Hoja de Ruta de Retiro asignada al Fletero";
            // 
            // HojRut
            // 
            HojRut.Text = "Nro de Hoja de Retiro";
            HojRut.Width = 130;
            // 
            // Remitente
            // 
            Remitente.Text = "Remitente";
            Remitente.Width = 70;
            // 
            // Calle
            // 
            Calle.Text = "Calle";
            Calle.Width = 40;
            // 
            // Altura
            // 
            Altura.Text = "Altura";
            Altura.Width = 50;
            // 
            // CP
            // 
            CP.Text = "CP";
            CP.Width = 30;
            // 
            // TipoBulto
            // 
            TipoBulto.Text = "Cant de Bultos";
            TipoBulto.Width = 90;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 330);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 330);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(115, 23);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 312);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 11;
            label6.Text = "Total Bultos a Retirar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 312);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 9;
            label5.Text = "Total Domicilios a Visitar";
            // 
            // button1
            // 
            button1.Location = new Point(84, 400);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 13;
            button1.Text = "Generar Resumen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(246, 400);
            button2.Name = "button2";
            button2.Size = new Size(119, 44);
            button2.TabIndex = 14;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Resumen_HDR_Retiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 465);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(textBox3);
            Controls.Add(Fletero);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Resumen_HDR_Retiro";
            Text = "ResumenHDR";
            Load += ResumenHDR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label Fletero;
        private ListView listView1;
        private ColumnHeader columnHeader1;
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
    }
}