namespace Prototipos_TUTASA
{
    partial class EntregaEncomiendaAgencia
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
            colNombre = new ColumnHeader();
            colApellido = new ColumnHeader();
            colDNI = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblAgencia = new Label();
            txtAgencia = new TextBox();
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
            lblTitulo.Size = new Size(368, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Entrega de Encomienda en Agencia";
            // 
            // lblGuia
            // 
            lblGuia.Location = new Point(12, 54);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(80, 23);
            lblGuia.TabIndex = 1;
            lblGuia.Text = "Guía";
            // 
            // txtGuia
            // 
            txtGuia.Location = new Point(98, 51);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new Size(169, 26);
            txtGuia.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(290, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 37);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lvGuia
            // 
            lvGuia.Columns.AddRange(new ColumnHeader[] { colNombre, colApellido, colDNI, colEstado });
            lvGuia.FullRowSelect = true;
            lvGuia.GridLines = true;
            lvGuia.Location = new Point(12, 99);
            lvGuia.Name = "lvGuia";
            lvGuia.Size = new Size(581, 103);
            lvGuia.TabIndex = 4;
            lvGuia.UseCompatibleStateImageBehavior = false;
            lvGuia.View = View.Details;
            lvGuia.SelectedIndexChanged += lvGuia_SelectedIndexChanged;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 120;
            // 
            // colApellido
            // 
            colApellido.Text = "Apellido";
            colApellido.Width = 120;
            // 
            // colDNI
            // 
            colDNI.Text = "DNI";
            colDNI.Width = 110;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 110;
            // 
            // lblAgencia
            // 
            lblAgencia.Location = new Point(12, 214);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(238, 24);
            lblAgencia.TabIndex = 5;
            lblAgencia.Text = "Agencia que entrega";
            // 
            // txtAgencia
            // 
            txtAgencia.Location = new Point(12, 241);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.ReadOnly = true;
            txtAgencia.Size = new Size(200, 26);
            txtAgencia.TabIndex = 6;
            txtAgencia.Text = "Agencia Flores (FIJO)";
            // 
            // lblValidacion
            // 
            lblValidacion.Location = new Point(12, 287);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(238, 32);
            lblValidacion.TabIndex = 9;
            lblValidacion.Text = "Validación de quien retira";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(12, 319);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(104, 30);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 352);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 26);
            txtNombre.TabIndex = 11;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(170, 319);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(97, 31);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(170, 353);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(147, 26);
            txtApellido.TabIndex = 13;
            // 
            // lblDNI
            // 
            lblDNI.Location = new Point(330, 319);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(62, 31);
            lblDNI.TabIndex = 14;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(330, 353);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(137, 26);
            txtDNI.TabIndex = 15;
            // 
            // chkDNI
            // 
            chkDNI.Location = new Point(12, 425);
            chkDNI.Name = "chkDNI";
            chkDNI.Size = new Size(200, 59);
            chkDNI.TabIndex = 16;
            chkDNI.Text = "Presentó DNI / Cédula";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(130, 490);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(174, 70);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "Confirmar Entrega";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(363, 490);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 70);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            // 
            // EntregaEncomiendaAgencia
            // 
            ClientSize = new Size(712, 619);
            Controls.Add(lblTitulo);
            Controls.Add(lblGuia);
            Controls.Add(txtGuia);
            Controls.Add(btnBuscar);
            Controls.Add(lvGuia);
            Controls.Add(lblAgencia);
            Controls.Add(txtAgencia);
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
            Name = "EntregaEncomiendaAgencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrega de Encomienda en Agencia";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvGuia;
        private System.Windows.Forms.ColumnHeader colNombre, colApellido, colDNI, colEstado;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Label lblNombre, lblApellido, lblDNI;
        private System.Windows.Forms.TextBox txtNombre, txtApellido, txtDNI;
        private System.Windows.Forms.CheckBox chkDNI;
        private System.Windows.Forms.Button btnConfirmar, btnCancelar;
    }
}