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
            lblEmpresaTransporte = new Label();
            cmbEmpresaTransporte = new ComboBox();
            lblPeriodo = new Label();
            dtpPeriodo = new DateTimePicker();
            btnMostrar = new Button();
            lvResultados = new ListView();
            colPeriodo = new ColumnHeader();
            colVentas = new ColumnHeader();
            colCostos = new ColumnHeader();
            colResultado = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(17, 11);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 25);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Resultado Costos VS Ventas";
            // 
            // lblEmpresaTransporte
            // 
            lblEmpresaTransporte.AutoSize = true;
            lblEmpresaTransporte.Location = new Point(17, 46);
            lblEmpresaTransporte.Margin = new Padding(2, 0, 2, 0);
            lblEmpresaTransporte.Name = "lblEmpresaTransporte";
            lblEmpresaTransporte.Size = new Size(127, 15);
            lblEmpresaTransporte.TabIndex = 42;
            lblEmpresaTransporte.Text = "Empresa de Transporte";
            // 
            // cmbEmpresaTransporte
            // 
            cmbEmpresaTransporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresaTransporte.FormattingEnabled = true;
            cmbEmpresaTransporte.Location = new Point(17, 69);
            cmbEmpresaTransporte.Margin = new Padding(2, 2, 2, 2);
            cmbEmpresaTransporte.Name = "cmbEmpresaTransporte";
            cmbEmpresaTransporte.Size = new Size(188, 23);
            cmbEmpresaTransporte.TabIndex = 43;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(225, 46);
            lblPeriodo.Margin = new Padding(2, 0, 2, 0);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(48, 15);
            lblPeriodo.TabIndex = 44;
            lblPeriodo.Text = "Periodo";
            // 
            // dtpPeriodo
            // 
            dtpPeriodo.CustomFormat = "MM/yyyy";
            dtpPeriodo.Format = DateTimePickerFormat.Custom;
            dtpPeriodo.Location = new Point(225, 69);
            dtpPeriodo.Margin = new Padding(2, 2, 2, 2);
            dtpPeriodo.Name = "dtpPeriodo";
            dtpPeriodo.ShowUpDown = true;
            dtpPeriodo.Size = new Size(87, 23);
            dtpPeriodo.TabIndex = 45;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(329, 69);
            btnMostrar.Margin = new Padding(2, 2, 2, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(78, 20);
            btnMostrar.TabIndex = 46;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lvResultados
            // 
            lvResultados.Columns.AddRange(new ColumnHeader[] { colPeriodo, colVentas, colCostos, colResultado });
            lvResultados.Location = new Point(17, 111);
            lvResultados.Margin = new Padding(2, 2, 2, 2);
            lvResultados.Name = "lvResultados";
            lvResultados.Size = new Size(392, 184);
            lvResultados.TabIndex = 47;
            lvResultados.UseCompatibleStateImageBehavior = false;
            lvResultados.View = View.Details;
            // 
            // colPeriodo
            // 
            colPeriodo.Text = "Periodo";
            colPeriodo.Width = 110;
            // 
            // colVentas
            // 
            colVentas.Text = "Ventas";
            colVentas.Width = 140;
            // 
            // colCostos
            // 
            colCostos.Text = "Costos";
            colCostos.Width = 140;
            // 
            // colResultado
            // 
            colResultado.Text = "Resultado";
            colResultado.Width = 140;
            // 
            // resultadocostosvsventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 310);
            Controls.Add(lvResultados);
            Controls.Add(btnMostrar);
            Controls.Add(dtpPeriodo);
            Controls.Add(lblPeriodo);
            Controls.Add(cmbEmpresaTransporte);
            Controls.Add(lblEmpresaTransporte);
            Controls.Add(lblTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "resultadocostosvsventas";
            Text = "Resultados Costos VS Ventas";
            Load += resultadocostosvsventas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEmpresaTransporte;
        private ComboBox cmbEmpresaTransporte;
        private Label lblPeriodo;
        private DateTimePicker dtpPeriodo;
        private Button btnMostrar;
        private ListView lvResultados;
        private ColumnHeader colPeriodo;
        private ColumnHeader colVentas;
        private ColumnHeader colCostos;
        private ColumnHeader colResultado;
    }
}
