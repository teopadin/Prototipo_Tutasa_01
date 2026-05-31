namespace Prototipos_TUTASA
{
    partial class Generacion_Reumen_HDR_Distribucion
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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            HojRut = new ColumnHeader();
            Remitente = new ColumnHeader();
            CHcalle = new ColumnHeader();
            Altura = new ColumnHeader();
            CP = new ColumnHeader();
            CantBultos = new ColumnHeader();
            Fletero = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 31);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(383, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 33);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(401, 548);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(170, 73);
            button2.TabIndex = 27;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(166, 548);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(170, 73);
            button1.TabIndex = 26;
            button1.Text = "Generar Resumen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(383, 469);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(326, 31);
            textBox5.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 439);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 24;
            label6.Text = "Total Bultos a Entregar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(41, 469);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(321, 31);
            textBox4.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 439);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 25);
            label5.TabIndex = 22;
            label5.Text = "Total Domicilios a Visitar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 192);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(391, 25);
            label4.TabIndex = 21;
            label4.Text = "Hoja de Ruta de distribucion asignada al Fletero";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente, CHcalle, Altura, CP, CantBultos });
            listView1.Location = new Point(18, 241);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(691, 159);
            listView1.TabIndex = 20;
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
            Remitente.Text = "Destinatario";
            Remitente.Width = 120;
            // 
            // CHcalle
            // 
            CHcalle.Text = "Calle";
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
            // CantBultos
            // 
            CantBultos.Text = "Cant de Bultos";
            CantBultos.Width = 150;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(383, 102);
            Fletero.Margin = new Padding(4, 0, 4, 0);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(144, 25);
            Fletero.TabIndex = 19;
            Fletero.Text = "Fletero asignado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 18;
            label3.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(568, 45);
            label1.TabIndex = 17;
            label1.Text = "Resumen Hoja de Ruta de Distribución";
            // 
            // Generacion_Reumen_HDR_Distribucion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 684);
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
            Name = "Generacion_Reumen_HDR_Distribucion";
            Text = "Generacion_HDR_Distribucion";
            Load += Generacion_Reumen_HDR_Distribucion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private ListView listView1;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente;
        private ColumnHeader Calle;
        private ColumnHeader Altura;
        private ColumnHeader CP;
        private ColumnHeader CantBultos;
        private Label Fletero;
        private Label label3;
        private Label label1;
        private ColumnHeader CHcalle;
    }
}
