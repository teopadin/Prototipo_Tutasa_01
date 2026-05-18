namespace Prototipos_TUTASA.ConsultarEstadoDelPedido_v2
{
    partial class ConsultarEstadoDelPedidoV2
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
            lblNumeroPedido = new Label();
            btnBuscar = new Button();
            txtNumeroPedido = new TextBox();
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
            lblTitulo.Location = new Point(20, 34);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(848, 75);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Consultar Estado del Pedido";
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Location = new Point(39, 138);
            lblNumeroPedido.Margin = new Padding(7, 0, 7, 0);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(244, 41);
            lblNumeroPedido.TabIndex = 2;
            lblNumeroPedido.Text = "Número de Guía:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(918, 126);
            btnBuscar.Margin = new Padding(7, 8, 7, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(182, 62);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(301, 138);
            txtNumeroPedido.Margin = new Padding(7, 8, 7, 8);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(601, 47);
            txtNumeroPedido.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(39, 231);
            listView1.Margin = new Padding(5, 5, 5, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(1058, 394);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 400;
            // 
            // ConsultarEstadoDelPedidoV2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 695);
            Controls.Add(listView1);
            Controls.Add(txtNumeroPedido);
            Controls.Add(btnBuscar);
            Controls.Add(lblNumeroPedido);
            Controls.Add(lblTitulo);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ConsultarEstadoDelPedidoV2";
            Text = "ConsultarEstadoDelPedidoV2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumeroPedido;
        private Button btnBuscar;
        private TextBox txtNumeroPedido;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}