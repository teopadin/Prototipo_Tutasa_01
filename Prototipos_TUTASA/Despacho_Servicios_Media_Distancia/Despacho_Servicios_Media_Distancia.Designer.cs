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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            HojRut = new ColumnHeader();
            Remitente = new ColumnHeader();
            CHcalle = new ColumnHeader();
            Altura = new ColumnHeader();
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(736, 46);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Despacho de Servicios de Media Distancia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(233, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 33);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 139);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 4;
            label1.Text = "Nro HDR de Transporte";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 31);
            dateTimePicker1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(157, 650);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(170, 73);
            button1.TabIndex = 31;
            button1.Text = "Confirmar despacho";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(405, 650);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(170, 73);
            button2.TabIndex = 32;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojRut, Remitente, CHcalle, Altura });
            listView1.Location = new Point(30, 343);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(713, 181);
            listView1.TabIndex = 33;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HojRut
            // 
            HojRut.Text = "Nro Guía";
            HojRut.Width = 150;
            // 
            // Remitente
            // 
            Remitente.Text = "Remitente";
            Remitente.Width = 120;
            // 
            // CHcalle
            // 
            CHcalle.Text = "Destinatario";
            CHcalle.Width = 200;
            // 
            // Altura
            // 
            Altura.Text = "Tipo de bulto";
            Altura.Width = 500;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 549);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 34;
            label4.Text = "Bultos (equiv. en S)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 546);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 31);
            textBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 549);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 36;
            label2.Text = "Total de Bultos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(523, 549);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 31);
            textBox2.TabIndex = 37;
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
            // textBox3
            // 
            textBox3.Location = new Point(221, 197);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 41;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(221, 239);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 42;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(221, 287);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(124, 610);
            label8.Name = "label8";
            label8.Size = new Size(473, 25);
            label8.TabIndex = 44;
            label8.Text = "Al confirmar, se emitirán 3 copias de la HDR de Transporte";
            // 
            // Despacho_Servicios_Media_Distancia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 754);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lblTitulo);
            Name = "Despacho_Servicios_Media_Distancia";
            Text = "Despacho_Servicios_Media_Distancia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader HojRut;
        private ColumnHeader Remitente;
        private ColumnHeader CHcalle;
        private ColumnHeader Altura;
        private Label label4;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
    }
}