namespace Prototipos_TUTASA
{
    partial class ConsultarEstadoPedidoSLog
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
            txtNumeroPedido = new TextBox();
            btnBuscar = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(78, 137);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(591, 59);
            label1.TabIndex = 0;
            label1.Text = "Consultar Estado del Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 301);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 41);
            label2.TabIndex = 1;
            label2.Text = "Número de Guía:";
            label2.Click += label2_Click;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(364, 301);
            txtNumeroPedido.Margin = new Padding(7, 8, 7, 8);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(601, 47);
            txtNumeroPedido.TabIndex = 2;
            txtNumeroPedido.TextChanged += txtNumeroPedido_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1020, 301);
            btnBuscar.Margin = new Padding(7, 8, 7, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(182, 63);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(62, 487);
            listView1.Margin = new Padding(7, 8, 7, 8);
            listView1.Name = "listView1";
            listView1.Size = new Size(1818, 256);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID TL";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Patente";
            columnHeader4.Width = 180;
            // 
            // colEstado
            // 
            columnHeader5.Text = "HDR Asignadas";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "CD";
            columnHeader6.Width = 90;
            // 
            // ConsultarEstadoPedidoSLog
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1943, 1230);
            Controls.Add(listView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "ConsultarEstadoPedidoSLog";
            Text = "Consultar Estado del Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumeroPedido;
        private Button btnBuscar;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}