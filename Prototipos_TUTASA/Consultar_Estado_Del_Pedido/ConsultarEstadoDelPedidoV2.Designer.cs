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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "07-05-2026", "CD-0001", "Pendiente de Retiro", "CD-0002" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "07-05-2026", "CD-0002", "Pendiente de Admisión" }, -1);
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
            lblTitulo.Location = new Point(12, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(499, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Consultar Estado del Pedido";
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Location = new Point(23, 84);
            lblNumeroPedido.Margin = new Padding(4, 0, 4, 0);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(146, 25);
            lblNumeroPedido.TabIndex = 2;
            lblNumeroPedido.Text = "Número de Guía:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(540, 77);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 38);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(177, 84);
            txtNumeroPedido.Margin = new Padding(4, 5, 4, 5);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(355, 31);
            txtNumeroPedido.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(23, 141);
            listView1.Name = "listView1";
            listView1.Size = new Size(624, 242);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 200;
            // 
            // ConsultarEstadoDelPedidoV2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 424);
            Controls.Add(listView1);
            Controls.Add(txtNumeroPedido);
            Controls.Add(btnBuscar);
            Controls.Add(lblNumeroPedido);
            Controls.Add(lblTitulo);
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