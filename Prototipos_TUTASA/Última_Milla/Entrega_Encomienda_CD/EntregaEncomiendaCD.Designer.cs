namespace Prototipos_TUTASA
{
    partial class EntregaEncomiendaCD
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblGuia = new Label();
            txtGuia = new TextBox();
            btnBuscar = new Button();
            lvGuia = new ListView();
            this.colNombre = new ColumnHeader();
            this.colApellido = new ColumnHeader();
            this.colDNI = new ColumnHeader();
            lblValidacion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            chkDNI = new CheckBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(308, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Entrega de Encomienda en CD";
            // 
            // lblGuia
            // 
            lblGuia.Location = new Point(12, 65);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(62, 34);
            lblGuia.TabIndex = 1;
            lblGuia.Text = "Guía";
            // 
            // txtGuia
            // 
            txtGuia.Location = new Point(80, 62);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new Size(120, 32);
            txtGuia.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(212, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 39);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            // 
            // lvGuia
            // 
            lvGuia.Columns.AddRange(new ColumnHeader[] { this.colNombre, this.colApellido, this.colDNI });
            lvGuia.FullRowSelect = true;
            lvGuia.GridLines = true;
            lvGuia.Location = new Point(12, 120);
            lvGuia.Name = "lvGuia";
            lvGuia.Size = new Size(538, 127);
            lvGuia.TabIndex = 4;
            lvGuia.UseCompatibleStateImageBehavior = false;
            lvGuia.View = View.Details;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 120;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 120;
            // 
            // colDNI
            // 
            this.colDNI.Text = "DNI";
            this.colDNI.Width = 110;
            // 
            // lblValidacion
            // 
            lblValidacion.Location = new Point(12, 269);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(257, 31);
            lblValidacion.TabIndex = 7;
            lblValidacion.Text = "Validación de quien retira";
            lblValidacion.Click += lblValidacion_Click;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(12, 320);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 18);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 340);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 32);
            txtNombre.TabIndex = 9;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(189, 320);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(121, 18);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(189, 340);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 32);
            txtApellido.TabIndex = 11;
            // 
            // lblDNI
            // 
            lblDNI.Location = new Point(369, 320);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(181, 18);
            lblDNI.TabIndex = 12;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(369, 340);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(181, 32);
            txtDNI.TabIndex = 13;
            // 
            // chkDNI
            // 
            chkDNI.Location = new Point(12, 406);
            chkDNI.Name = "chkDNI";
            chkDNI.Size = new Size(538, 78);
            chkDNI.TabIndex = 14;
            chkDNI.Text = "Documento de identidad presentado y verificado";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(232, 513);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(187, 70);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Registrar Entrega";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(425, 513);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 70);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EntregaEncomiendaCD
            // 
            ClientSize = new Size(616, 621);
            Controls.Add(lblTitulo);
            Controls.Add(lblGuia);
            Controls.Add(txtGuia);
            Controls.Add(btnBuscar);
            Controls.Add(lvGuia);
            Controls.Add(lblValidacion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(chkDNI);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EntregaEncomiendaCD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrega de Encomienda en CD";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvGuia;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colDNI;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Label lblNombre, lblApellido, lblDNI;
        private System.Windows.Forms.TextBox txtNombre, txtApellido, txtDNI;
        private System.Windows.Forms.CheckBox chkDNI;
        private System.Windows.Forms.Button btnConfirmar, btnCancelar;
    }
}