namespace Prototipos_TUTASA
{
    partial class ConsultarEstadoPedido
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
            txtNumeroPedido = new TextBox();
            btnBuscar = new Button();
            dgvEstado = new DataGridView();
            colNumeroPedido = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colDetalles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstado).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(17, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(441, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar Estado del Pedido";
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Location = new Point(17, 100);
            lblNumeroPedido.Margin = new Padding(4, 0, 4, 0);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(166, 25);
            lblNumeroPedido.TabIndex = 1;
            lblNumeroPedido.Text = "Número de Pedido:";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(183, 95);
            txtNumeroPedido.Margin = new Padding(4, 5, 4, 5);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(355, 31);
            txtNumeroPedido.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(571, 100);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 38);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEstado
            // 
            dgvEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstado.Columns.AddRange(new DataGridViewColumn[] { colNumeroPedido, colFecha, colEstado, colDetalles });
            dgvEstado.Location = new Point(17, 167);
            dgvEstado.Margin = new Padding(4, 5, 4, 5);
            dgvEstado.Name = "dgvEstado";
            dgvEstado.ReadOnly = true;
            dgvEstado.RowHeadersWidth = 62;
            dgvEstado.Size = new Size(1086, 155);
            dgvEstado.TabIndex = 4;
            dgvEstado.CellContentClick += dgvEstado_CellContentClick;
            // 
            // colNumeroPedido
            // 
            colNumeroPedido.HeaderText = "Número de Pedido";
            colNumeroPedido.MinimumWidth = 8;
            colNumeroPedido.Name = "colNumeroPedido";
            colNumeroPedido.ReadOnly = true;
            colNumeroPedido.Width = 150;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 120;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 8;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 150;
            // 
            // colDetalles
            // 
            colDetalles.HeaderText = "Detalles";
            colDetalles.MinimumWidth = 8;
            colDetalles.Name = "colDetalles";
            colDetalles.ReadOnly = true;
            colDetalles.Width = 300;
            // 
            // ConsultarEstadoPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 750);
            Controls.Add(dgvEstado);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroPedido);
            Controls.Add(lblNumeroPedido);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConsultarEstadoPedido";
            Text = "Consultar Estado del Pedido";
            ((System.ComponentModel.ISupportInitialize)dgvEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalles;
    }
}
