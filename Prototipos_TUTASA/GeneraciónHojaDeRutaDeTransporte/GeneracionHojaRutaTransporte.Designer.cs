namespace Prototipos_TUTASA.GeneraciónHojaDeRutaDeTransporte
{
    partial class GeneracionHojaRutaTransporte
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            lblDniDestinatario = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar por guia:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblDniDestinatario);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 209);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 19);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Estado";
            // 
            // lblDniDestinatario
            // 
            lblDniDestinatario.AutoSize = true;
            lblDniDestinatario.Location = new Point(327, 19);
            lblDniDestinatario.Name = "lblDniDestinatario";
            lblDniDestinatario.Size = new Size(62, 15);
            lblDniDestinatario.TabIndex = 17;
            lblDniDestinatario.Text = "CD Emisor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 18);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 108);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 19);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 20;
            label5.Text = "CD Destino";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 62);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 21;
            label6.Text = "Chofer asignado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 92);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(228, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 62);
            label8.Name = "label8";
            label8.Size = new Size(160, 15);
            label8.TabIndex = 24;
            label8.Text = "Fecha y Horario de despacho";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(28, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(28, 36);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(75, 23);
            dateTimePicker2.TabIndex = 26;
            dateTimePicker2.Value = new DateTime(2026, 5, 6, 17, 10, 26, 0);
            // 
            // GeneracionHojaRutaTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "GeneracionHojaRutaTransporte";
            Text = "GeneracionHojaRutaTransporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblDniDestinatario;
        private Label label2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
    }
}