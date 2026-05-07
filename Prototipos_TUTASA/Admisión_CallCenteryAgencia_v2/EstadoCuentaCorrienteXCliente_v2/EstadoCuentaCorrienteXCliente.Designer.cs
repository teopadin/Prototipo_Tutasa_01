namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    partial class EstadoCuentaCorrienteXCliente
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
            groupBox1 = new GroupBox();
            lblRazonSocial = new Label();
            txtNombreRem = new TextBox();
            button1 = new Button();
            lblCUIT = new Label();
            txtCUIT = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(587, 41);
            lblTitulo.TabIndex = 40;
            lblTitulo.Text = "Estado de Cuenta Corriente por Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblCUIT);
            groupBox1.Controls.Add(txtCUIT);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNombreRem);
            groupBox1.Controls.Add(lblRazonSocial);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 182);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.ForeColor = Color.FromArgb(60, 60, 60);
            lblRazonSocial.Location = new Point(6, 27);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(150, 28);
            lblRazonSocial.TabIndex = 23;
            lblRazonSocial.Text = "Razón social *";
            // 
            // txtNombreRem
            // 
            txtNombreRem.Location = new Point(6, 58);
            txtNombreRem.Name = "txtNombreRem";
            txtNombreRem.Size = new Size(170, 31);
            txtNombreRem.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(200, 58);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 42;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblCUIT
            // 
            lblCUIT.ForeColor = Color.FromArgb(60, 60, 60);
            lblCUIT.Location = new Point(6, 99);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(107, 28);
            lblCUIT.TabIndex = 43;
            lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(9, 130);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.ReadOnly = true;
            txtCUIT.Size = new Size(167, 31);
            txtCUIT.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 100);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 42;
            label2.Text = "Estado de Cuenta";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(12, 271);
            listView1.Name = "listView1";
            listView1.Size = new Size(609, 146);
            listView1.TabIndex = 45;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Concepto";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Debe";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Haber";
            columnHeader4.Width = 110;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 130);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 99);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 46;
            label1.Text = "Saldo Actual";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 130);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(174, 31);
            textBox2.TabIndex = 47;
            // 
            // button2
            // 
            button2.Location = new Point(64, 441);
            button2.Name = "button2";
            button2.Size = new Size(211, 62);
            button2.TabIndex = 46;
            button2.Text = "Registrar Pago";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(338, 441);
            button3.Name = "button3";
            button3.Size = new Size(232, 62);
            button3.TabIndex = 47;
            button3.Text = "Emitir Factura";
            button3.UseVisualStyleBackColor = true;
            // 
            // EstadoCuentaCorrienteXCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 536);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "EstadoCuentaCorrienteXCliente";
            Text = "Estado de CC por Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox1;
        private Label lblRazonSocial;
        private Button button1;
        private TextBox txtNombreRem;
        private Label lblCUIT;
        private TextBox txtCUIT;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label1;
        private TextBox textBox1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}