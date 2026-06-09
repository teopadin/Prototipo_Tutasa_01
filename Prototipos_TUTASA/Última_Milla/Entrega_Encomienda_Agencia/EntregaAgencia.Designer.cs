namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    partial class EntregaAgencia
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblGuia = new Label();
            txtGuia = new TextBox();
            btnBuscar = new Button();
            lblAgenciaFija = new Label();
            lblAgencia = new Label();
            lvGuia = new ListView();
            colNombre = new ColumnHeader();
            colApellido = new ColumnHeader();
            colDni = new ColumnHeader();
            grpValidacion = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            chkDNI = new CheckBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            grpValidacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Entrega de Encomienda en Agencia";
            // 
            // lblGuia
            // 
            lblGuia.AutoSize = true;
            lblGuia.Location = new Point(24, 60);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(34, 15);
            lblGuia.TabIndex = 1;
            lblGuia.Text = "Guía:";
            // 
            // txtGuia
            // 
            txtGuia.Location = new Point(80, 57);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new Size(180, 23);
            txtGuia.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(270, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblAgenciaFija
            // 
            lblAgenciaFija.AutoSize = true;
            lblAgenciaFija.Location = new Point(24, 92);
            lblAgenciaFija.Name = "lblAgenciaFija";
            lblAgenciaFija.Size = new Size(53, 15);
            lblAgenciaFija.TabIndex = 4;
            lblAgenciaFija.Text = "Agencia:";
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAgencia.Location = new Point(80, 92);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(57, 15);
            lblAgencia.TabIndex = 5;
            lblAgencia.Text = "(agencia)";
            // 
            // lvGuia
            // 
            lvGuia.Columns.AddRange(new ColumnHeader[] { colNombre, colApellido, colDni });
            lvGuia.FullRowSelect = true;
            lvGuia.GridLines = true;
            lvGuia.Location = new Point(24, 120);
            lvGuia.Name = "lvGuia";
            lvGuia.Size = new Size(336, 80);
            lvGuia.TabIndex = 6;
            lvGuia.UseCompatibleStateImageBehavior = false;
            lvGuia.View = View.Details;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 110;
            // 
            // colApellido
            // 
            colApellido.Text = "Apellido";
            colApellido.Width = 110;
            // 
            // colDni
            // 
            colDni.Text = "DNI";
            colDni.Width = 110;
            // 
            // grpValidacion
            // 
            grpValidacion.Controls.Add(lblNombre);
            grpValidacion.Controls.Add(txtNombre);
            grpValidacion.Controls.Add(lblApellido);
            grpValidacion.Controls.Add(txtApellido);
            grpValidacion.Controls.Add(lblDNI);
            grpValidacion.Controls.Add(txtDNI);
            grpValidacion.Controls.Add(chkDNI);
            grpValidacion.Location = new Point(24, 212);
            grpValidacion.Name = "grpValidacion";
            grpValidacion.Size = new Size(336, 160);
            grpValidacion.TabIndex = 7;
            grpValidacion.TabStop = false;
            grpValidacion.Text = "Validación de quien retira";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(16, 62);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 59);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(220, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(16, 94);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 4;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(96, 91);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(220, 23);
            txtDNI.TabIndex = 5;
            // 
            // chkDNI
            // 
            chkDNI.AutoSize = true;
            chkDNI.Location = new Point(16, 126);
            chkDNI.Name = "chkDNI";
            chkDNI.Size = new Size(284, 19);
            chkDNI.TabIndex = 6;
            chkDNI.Text = "Documento de identidad presentado y verificado";
            chkDNI.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(158, 384);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(120, 30);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar Entrega";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(284, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EntregaAgencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 431);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(grpValidacion);
            Controls.Add(lvGuia);
            Controls.Add(lblAgencia);
            Controls.Add(lblAgenciaFija);
            Controls.Add(btnBuscar);
            Controls.Add(txtGuia);
            Controls.Add(lblGuia);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntregaAgencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrega en Agencia";
            grpValidacion.ResumeLayout(false);
            grpValidacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblAgenciaFija;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.ListView lvGuia;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colDni;
        private System.Windows.Forms.GroupBox grpValidacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.CheckBox chkDNI;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
