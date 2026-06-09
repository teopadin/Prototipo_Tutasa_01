namespace Prototipos_TUTASA.ConsultarEstadoDelPedido_v2
{
    partial class ConsultarEstadoDelPedido
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
            txtNroGuia = new TextBox();
            lstHistorial = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(8, 13);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(349, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Consultar Estado del Pedido";
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Location = new Point(16, 50);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(97, 15);
            lblNumeroPedido.TabIndex = 2;
            lblNumeroPedido.Text = "Número de Guía:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(349, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNroGuia
            // 
            txtNroGuia.Location = new Point(124, 50);
            txtNroGuia.Name = "txtNroGuia";
            txtNroGuia.Size = new Size(221, 23);
            txtNroGuia.TabIndex = 5;
            // 
            // lstHistorial
            // 
            lstHistorial.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstHistorial.Location = new Point(16, 85);
            lstHistorial.Margin = new Padding(2, 2, 2, 2);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(611, 203);
            lstHistorial.TabIndex = 6;
            lstHistorial.UseCompatibleStateImageBehavior = false;
            lstHistorial.View = View.Details;
            lstHistorial.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Donde";
            columnHeader4.Width = 230;
            // 
            // ConsultarEstadoDelPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 335);
            Controls.Add(lstHistorial);
            Controls.Add(txtNroGuia);
            Controls.Add(btnBuscar);
            Controls.Add(lblNumeroPedido);
            Controls.Add(lblTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsultarEstadoDelPedido";
            Text = "Consultar Estado del Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumeroPedido;
        private Button btnBuscar;
        private TextBox txtNroGuia;
        private ListView lstHistorial;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}