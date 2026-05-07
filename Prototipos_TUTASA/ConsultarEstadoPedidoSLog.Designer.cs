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
            dgvResultados = new DataGridView();
            colNumeroPedido = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colDetalles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 0;
            label1.Text = "Consultar Estado del Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 110);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Número de Guía:";
            label2.Click += label2_Click;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(150, 110);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(250, 23);
            txtNumeroPedido.TabIndex = 2;
            txtNumeroPedido.TextChanged += txtNumeroPedido_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(420, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colNumeroPedido, colFecha, colEstado, colDetalles });
            dgvResultados.Location = new Point(32, 155);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.Size = new Size(760, 84);
            dgvResultados.TabIndex = 4;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // colNumeroPedido
            // 
            colNumeroPedido.HeaderText = "Número de Guía";
            colNumeroPedido.Name = "colNumeroPedido";
            colNumeroPedido.ReadOnly = true;
            colNumeroPedido.Width = 150;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha de imposición";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 120;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 150;
            // 
            // colDetalles
            // 
            colDetalles.HeaderText = "Detalles";
            colDetalles.Name = "colDetalles";
            colDetalles.ReadOnly = true;
            colDetalles.Width = 300;
            // 
            // ConsultarEstadoPedidoSLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultados);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarEstadoPedidoSLog";
            Text = "Consultar Estado del Pedido";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumeroPedido;
        private Button btnBuscar;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colNumeroPedido;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colDetalles;
    }
}