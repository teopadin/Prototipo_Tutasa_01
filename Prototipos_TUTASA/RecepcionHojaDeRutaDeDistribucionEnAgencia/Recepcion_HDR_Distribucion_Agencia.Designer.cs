namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    partial class Recepcion_HDR_Distribucion_Agencia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNroHDR = new Label();
            txtNroHDR = new TextBox();
            btnBuscar = new Button();
            lblFechaRecepcion = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblAgencia = new Label();
            txtAgencia = new TextBox();
            lblFletero = new Label();
            txtFletero = new TextBox();
            lblGuias = new Label();
            lblTotalGuias = new Label();
            txtTotalGuias = new TextBox();
            btnConfirmarRecepcion = new Button();
            btnCancelar = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblNroHDR
            // 
            lblNroHDR.AutoSize = true;
            lblNroHDR.Location = new Point(29, 34);
            lblNroHDR.Margin = new Padding(4, 0, 4, 0);
            lblNroHDR.Name = "lblNroHDR";
            lblNroHDR.Size = new Size(154, 25);
            lblNroHDR.TabIndex = 0;
            lblNroHDR.Text = "Nro Hoja de Ruta:";
            // 
            // txtNroHDR
            // 
            txtNroHDR.Location = new Point(214, 28);
            txtNroHDR.Margin = new Padding(4, 5, 4, 5);
            txtNroHDR.Name = "txtNroHDR";
            txtNroHDR.Size = new Size(213, 31);
            txtNroHDR.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(443, 25);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 45);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(29, 91);
            lblFechaRecepcion.Margin = new Padding(4, 0, 4, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(142, 25);
            lblFechaRecepcion.TabIndex = 3;
            lblFechaRecepcion.Text = "Fecha recepción:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Enabled = false;
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(214, 87);
            dtpFechaRecepcion.Margin = new Padding(4, 5, 4, 5);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(284, 31);
            dtpFechaRecepcion.TabIndex = 4;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(29, 150);
            lblAgencia.Margin = new Padding(4, 0, 4, 0);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(79, 25);
            lblAgencia.TabIndex = 5;
            lblAgencia.Text = "Agencia:";
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = SystemColors.Control;
            txtAgencia.Location = new Point(214, 145);
            txtAgencia.Margin = new Padding(4, 5, 4, 5);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.ReadOnly = true;
            txtAgencia.Size = new Size(284, 31);
            txtAgencia.TabIndex = 6;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(29, 209);
            lblFletero.Margin = new Padding(4, 0, 4, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(70, 25);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Fletero:";
            // 
            // txtFletero
            // 
            txtFletero.BackColor = SystemColors.Control;
            txtFletero.Location = new Point(214, 203);
            txtFletero.Margin = new Padding(4, 5, 4, 5);
            txtFletero.Name = "txtFletero";
            txtFletero.ReadOnly = true;
            txtFletero.Size = new Size(284, 31);
            txtFletero.TabIndex = 8;
            // 
            // lblGuias
            // 
            lblGuias.AutoSize = true;
            lblGuias.Location = new Point(24, 257);
            lblGuias.Margin = new Padding(4, 0, 4, 0);
            lblGuias.Name = "lblGuias";
            lblGuias.Size = new Size(216, 25);
            lblGuias.TabIndex = 11;
            lblGuias.Text = "Guías incluidas en la HDR:";
            // 
            // lblTotalGuias
            // 
            lblTotalGuias.AutoSize = true;
            lblTotalGuias.Location = new Point(24, 615);
            lblTotalGuias.Margin = new Padding(4, 0, 4, 0);
            lblTotalGuias.Name = "lblTotalGuias";
            lblTotalGuias.Size = new Size(125, 25);
            lblTotalGuias.TabIndex = 12;
            lblTotalGuias.Text = "Total de guías:";
            // 
            // txtTotalGuias
            // 
            txtTotalGuias.BackColor = SystemColors.Control;
            txtTotalGuias.Location = new Point(209, 610);
            txtTotalGuias.Margin = new Padding(4, 5, 4, 5);
            txtTotalGuias.Name = "txtTotalGuias";
            txtTotalGuias.ReadOnly = true;
            txtTotalGuias.Size = new Size(113, 31);
            txtTotalGuias.TabIndex = 13;
            txtTotalGuias.TextAlign = HorizontalAlignment.Right;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(139, 677);
            btnConfirmarRecepcion.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(214, 59);
            btnConfirmarRecepcion.TabIndex = 14;
            btnConfirmarRecepcion.Text = "Confirmar Recepción";
            btnConfirmarRecepcion.Click += btnConfirmarRecepcion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(375, 677);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 59);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(29, 295);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(604, 291);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro de guia";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de bulto";
            columnHeader2.Width = 200;
            // 
            // Recepcion_HDR_Distribucion_Agencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 825);
            Controls.Add(listView1);
            Controls.Add(lblNroHDR);
            Controls.Add(txtNroHDR);
            Controls.Add(btnBuscar);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblAgencia);
            Controls.Add(txtAgencia);
            Controls.Add(lblFletero);
            Controls.Add(txtFletero);
            Controls.Add(lblGuias);
            Controls.Add(lblTotalGuias);
            Controls.Add(txtTotalGuias);
            Controls.Add(btnConfirmarRecepcion);
            Controls.Add(btnCancelar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Recepcion_HDR_Distribucion_Agencia";
            Text = "Recepción HDR Distribución en Agencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNroHDR;
        private System.Windows.Forms.TextBox txtNroHDR;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblFletero;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Label lblGuias;
        private System.Windows.Forms.Label lblTotalGuias;
        private System.Windows.Forms.TextBox txtTotalGuias;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnCancelar;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}