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
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(428, 41);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Resultado Costos VS Ventas";
            // 
            // lblEmpresaTransporte
            // 
            lblEmpresaTransporte.AutoSize = true;
            lblEmpresaTransporte.Location = new Point(24, 76);
            lblEmpresaTransporte.Name = "lblEmpresaTransporte";
            lblEmpresaTransporte.Size = new Size(193, 25);
            lblEmpresaTransporte.TabIndex = 42;
            lblEmpresaTransporte.Text = "Empresa de Transporte";
            // 
            // cmbEmpresaTransporte
            // 
            cmbEmpresaTransporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresaTransporte.FormattingEnabled = true;
            cmbEmpresaTransporte.Location = new Point(24, 115);
            cmbEmpresaTransporte.Name = "cmbEmpresaTransporte";
            cmbEmpresaTransporte.Size = new Size(267, 33);
            cmbEmpresaTransporte.TabIndex = 43;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(321, 76);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(70, 25);
            lblPeriodo.TabIndex = 44;
            lblPeriodo.Text = "Periodo";
            // 
            // dtpPeriodo
            // 
            dtpPeriodo.CustomFormat = "MM/yyyy";
            dtpPeriodo.Format = DateTimePickerFormat.Custom;
            dtpPeriodo.Location = new Point(321, 115);
            dtpPeriodo.Name = "dtpPeriodo";
            dtpPeriodo.ShowUpDown = true;
            dtpPeriodo.Size = new Size(123, 31);
            dtpPeriodo.TabIndex = 45;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(470, 115);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(112, 34);
            btnMostrar.TabIndex = 46;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lvResultados
            // 
            lvResultados.Columns.AddRange(new ColumnHeader[] { colPeriodo, colVentas, colCostos, colResultado });
            lvResultados.Location = new Point(24, 185);
            lvResultados.Name = "lvResultados";
            lvResultados.Size = new Size(558, 304);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 517);
            Controls.Add(lvResultados);
            Controls.Add(btnMostrar);
            Controls.Add(dtpPeriodo);
            Controls.Add(lblPeriodo);
            Controls.Add(cmbEmpresaTransporte);
            Controls.Add(lblEmpresaTransporte);
            Controls.Add(lblTitulo);
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
