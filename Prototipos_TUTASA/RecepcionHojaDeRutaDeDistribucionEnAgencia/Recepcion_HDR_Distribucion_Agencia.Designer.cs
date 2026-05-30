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
            lblNroHDR.Location = new Point(49, 55);
            lblNroHDR.Margin = new Padding(7, 0, 7, 0);
            lblNroHDR.Name = "lblNroHDR";
            lblNroHDR.Size = new Size(254, 41);
            lblNroHDR.TabIndex = 0;
            lblNroHDR.Text = "Nro Hoja de Ruta:";
            // 
            // txtNroHDR
            // 
            txtNroHDR.Location = new Point(364, 46);
            txtNroHDR.Margin = new Padding(7, 8, 7, 8);
            txtNroHDR.Name = "txtNroHDR";
            txtNroHDR.Size = new Size(359, 47);
            txtNroHDR.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(753, 41);
            btnBuscar.Margin = new Padding(7, 8, 7, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(194, 74);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(49, 150);
            lblFechaRecepcion.Margin = new Padding(7, 0, 7, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(240, 41);
            lblFechaRecepcion.TabIndex = 3;
            lblFechaRecepcion.Text = "Fecha recepción:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Enabled = false;
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(364, 142);
            dtpFechaRecepcion.Margin = new Padding(7, 8, 7, 8);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(480, 47);
            dtpFechaRecepcion.TabIndex = 4;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(49, 246);
            lblAgencia.Margin = new Padding(7, 0, 7, 0);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(131, 41);
            lblAgencia.TabIndex = 5;
            lblAgencia.Text = "Agencia:";
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = SystemColors.Control;
            txtAgencia.Location = new Point(364, 238);
            txtAgencia.Margin = new Padding(7, 8, 7, 8);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.ReadOnly = true;
            txtAgencia.Size = new Size(480, 47);
            txtAgencia.TabIndex = 6;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(49, 342);
            lblFletero.Margin = new Padding(7, 0, 7, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(117, 41);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Fletero:";
            // 
            // txtFletero
            // 
            txtFletero.BackColor = SystemColors.Control;
            txtFletero.Location = new Point(364, 333);
            txtFletero.Margin = new Padding(7, 8, 7, 8);
            txtFletero.Name = "txtFletero";
            txtFletero.ReadOnly = true;
            txtFletero.Size = new Size(480, 47);
            txtFletero.TabIndex = 8;
            // 
            // lblGuias
            // 
            lblGuias.AutoSize = true;
            lblGuias.Location = new Point(40, 421);
            lblGuias.Margin = new Padding(7, 0, 7, 0);
            lblGuias.Name = "lblGuias";
            lblGuias.Size = new Size(360, 41);
            lblGuias.TabIndex = 11;
            lblGuias.Text = "Guías incluidas en la HDR:";
            // 
            // lblTotalGuias
            // 
            lblTotalGuias.AutoSize = true;
            lblTotalGuias.Location = new Point(40, 1009);
            lblTotalGuias.Margin = new Padding(7, 0, 7, 0);
            lblTotalGuias.Name = "lblTotalGuias";
            lblTotalGuias.Size = new Size(208, 41);
            lblTotalGuias.TabIndex = 12;
            lblTotalGuias.Text = "Total de guías:";
            // 
            // txtTotalGuias
            // 
            txtTotalGuias.BackColor = SystemColors.Control;
            txtTotalGuias.Location = new Point(355, 1000);
            txtTotalGuias.Margin = new Padding(7, 8, 7, 8);
            txtTotalGuias.Name = "txtTotalGuias";
            txtTotalGuias.ReadOnly = true;
            txtTotalGuias.Size = new Size(189, 47);
            txtTotalGuias.TabIndex = 13;
            txtTotalGuias.TextAlign = HorizontalAlignment.Right;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(236, 1110);
            btnConfirmarRecepcion.Margin = new Padding(7, 8, 7, 8);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(364, 96);
            btnConfirmarRecepcion.TabIndex = 14;
            btnConfirmarRecepcion.Text = "Confirmar Recepción";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(637, 1110);
            btnCancelar.Margin = new Padding(7, 8, 7, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(243, 96);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(49, 483);
            listView1.Name = "listView1";
            listView1.Size = new Size(1024, 474);
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
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 1234);
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
            Margin = new Padding(7, 8, 7, 8);
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