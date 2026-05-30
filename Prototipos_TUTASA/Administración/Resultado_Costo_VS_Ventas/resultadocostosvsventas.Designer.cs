namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    partial class resultadocostosvsventas
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(428, 41);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Resultado Costos VS Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 76);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 42;
            label1.Text = "Empresa de Transporte";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 33);
            comboBox1.TabIndex = 43;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(24, 185);
            listView1.Name = "listView1";
            listView1.Size = new Size(364, 304);
            listView1.TabIndex = 44;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ventas";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Costos";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Resultado";
            columnHeader3.Width = 120;
            // 
            // resultadocostosvsventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 517);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "resultadocostosvsventas";
            Text = "Resultados Costos VS Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}