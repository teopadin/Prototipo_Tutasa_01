namespace Prototipos_TUTASA
{
    partial class RetiroBelu
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
            gbDetalleGuías = new GroupBox();
            lblGuíaBuscar = new Label();
            cbxSelecGuia = new ComboBox();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            gbDetalleGuías.SuspendLayout();
            SuspendLayout();
            // 
            // gbDetalleGuías
            // 
            gbDetalleGuías.Controls.Add(listView1);
            gbDetalleGuías.Location = new Point(10, 200);
            gbDetalleGuías.Name = "gbDetalleGuías";
            gbDetalleGuías.Size = new Size(860, 350);
            gbDetalleGuías.TabIndex = 0;
            gbDetalleGuías.TabStop = false;
            gbDetalleGuías.Text = "Detalle de Guías";
            // 
            // lblGuíaBuscar
            // 
            lblGuíaBuscar.AutoSize = true;
            lblGuíaBuscar.Location = new Point(12, 9);
            lblGuíaBuscar.Name = "lblGuíaBuscar";
            lblGuíaBuscar.Size = new Size(90, 15);
            lblGuíaBuscar.TabIndex = 1;
            lblGuíaBuscar.Text = "Buscar por Guía";
            lblGuíaBuscar.Click += this.label1_Click;
            // 
            // cbxSelecGuia
            // 
            cbxSelecGuia.FormattingEnabled = true;
            cbxSelecGuia.Location = new Point(108, 6);
            cbxSelecGuia.Name = "cbxSelecGuia";
            cbxSelecGuia.Size = new Size(121, 23);
            cbxSelecGuia.TabIndex = 2;
            cbxSelecGuia.SelectedIndexChanged += this.cbxSelecGuia_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(318, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(362, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(603, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 5;
            label1.Text = "Estado de Hoja de Ruta";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(749, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "CD Emisor";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 53);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 8;
            label3.Text = "Fletero Asignado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(110, 53);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 10;
            label5.Text = "CABA                           ";
            label5.Click += this.label5_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(420, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 11;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(848, 322);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // RetiroBelu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(cbxSelecGuia);
            Controls.Add(lblGuíaBuscar);
            Controls.Add(gbDetalleGuías);
            Name = "RetiroBelu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RetiroBelu";
            gbDetalleGuías.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDetalleGuías;
        private Label lblGuíaBuscar;
        private ComboBox cbxSelecGuia;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private ListView listView1;
    }
}