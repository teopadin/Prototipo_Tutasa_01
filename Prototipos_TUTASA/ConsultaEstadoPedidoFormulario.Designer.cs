namespace Prototipos_TUTASA
{
    partial class ConsultaEstadoPedidoFormulario
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
            components = new System.ComponentModel.Container();
            
            // Labels
            Label lblTitulo = new Label();
            Label lblNumeroPedido = new Label();
            Label lblTipo = new Label();
            Label lblFecha = new Label();
            Label lblEstado = new Label();
            Label lblResultados = new Label();
            
            // TextBox
            TextBox txtNumeroPedido = new TextBox();
            
            // ComboBox
            ComboBox cmbTipo = new ComboBox();
            
            // DateTimePicker
            DateTimePicker dtpFecha = new DateTimePicker();
            
            // CheckBox
            CheckBox chkActivos = new CheckBox();
            
            // RadioButton
            RadioButton rbPendiente = new RadioButton();
            RadioButton rbEntregado = new RadioButton();
            
            // ListView
            ListView lvResultados = new ListView();
            
            // Button (for search)
            Button btnBuscar = new Button();
            
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(32, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(325, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar Estado del Pedido";

            // lblNumeroPedido
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Location = new System.Drawing.Point(32, 70);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new System.Drawing.Size(110, 15);
            lblNumeroPedido.TabIndex = 1;
            lblNumeroPedido.Text = "Número de Pedido:";

            // txtNumeroPedido
            txtNumeroPedido.Location = new System.Drawing.Point(150, 70);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new System.Drawing.Size(200, 23);
            txtNumeroPedido.TabIndex = 2;

            // lblTipo
            lblTipo.AutoSize = true;
            lblTipo.Location = new System.Drawing.Point(360, 70);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(36, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";

            // cmbTipo
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Encomienda", "Paquete", "Documento" });
            cmbTipo.Location = new System.Drawing.Point(400, 70);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(150, 23);
            cmbTipo.TabIndex = 4;

            // lblFecha
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(32, 110);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(42, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha:";

            // dtpFecha
            dtpFecha.Location = new System.Drawing.Point(150, 110);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(200, 23);
            dtpFecha.TabIndex = 6;

            // chkActivos
            chkActivos.AutoSize = true;
            chkActivos.Location = new System.Drawing.Point(400, 110);
            chkActivos.Name = "chkActivos";
            chkActivos.Size = new System.Drawing.Size(144, 19);
            chkActivos.TabIndex = 7;
            chkActivos.Text = "Mostrar solo activos";
            chkActivos.UseVisualStyleBackColor = true;

            // lblEstado
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(32, 150);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(48, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";

            // rbPendiente
            rbPendiente.AutoSize = true;
            rbPendiente.Location = new System.Drawing.Point(150, 150);
            rbPendiente.Name = "rbPendiente";
            rbPendiente.Size = new System.Drawing.Size(77, 19);
            rbPendiente.TabIndex = 9;
            rbPendiente.TabStop = true;
            rbPendiente.Text = "Pendiente";
            rbPendiente.UseVisualStyleBackColor = true;

            // rbEntregado
            rbEntregado.AutoSize = true;
            rbEntregado.Location = new System.Drawing.Point(250, 150);
            rbEntregado.Name = "rbEntregado";
            rbEntregado.Size = new System.Drawing.Size(80, 19);
            rbEntregado.TabIndex = 10;
            rbEntregado.TabStop = true;
            rbEntregado.Text = "Entregado";
            rbEntregado.UseVisualStyleBackColor = true;

            // btnBuscar
            btnBuscar.Location = new System.Drawing.Point(400, 150);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;

            // lblResultados
            lblResultados.AutoSize = true;
            lblResultados.Location = new System.Drawing.Point(32, 195);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new System.Drawing.Size(73, 15);
            lblResultados.TabIndex = 12;
            lblResultados.Text = "Resultados:";

            // lvResultados
            lvResultados.Location = new System.Drawing.Point(32, 220);
            lvResultados.Name = "lvResultados";
            lvResultados.Size = new System.Drawing.Size(750, 210);
            lvResultados.TabIndex = 13;
            lvResultados.UseCompatibleStateImageBehavior = false;
            lvResultados.View = View.Details;
            lvResultados.Columns.Add("Número de Pedido", 150);
            lvResultados.Columns.Add("Fecha", 120);
            lvResultados.Columns.Add("Estado", 150);
            lvResultados.Columns.Add("Detalles", 300);

            // ConsultaEstadoPedidoFormulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lvResultados);
            this.Controls.Add(lblResultados);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(rbEntregado);
            this.Controls.Add(rbPendiente);
            this.Controls.Add(lblEstado);
            this.Controls.Add(chkActivos);
            this.Controls.Add(dtpFecha);
            this.Controls.Add(lblFecha);
            this.Controls.Add(cmbTipo);
            this.Controls.Add(lblTipo);
            this.Controls.Add(txtNumeroPedido);
            this.Controls.Add(lblNumeroPedido);
            this.Controls.Add(lblTitulo);
            this.Name = "ConsultaEstadoPedidoFormulario";
            this.Text = "Consultar Estado del Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
