namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    partial class EntregaAgencia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAgenciaFija = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lvGuia = new System.Windows.Forms.ListView();
            this.colNombre = new System.Windows.Forms.ColumnHeader();
            this.colApellido = new System.Windows.Forms.ColumnHeader();
            this.colDni = new System.Windows.Forms.ColumnHeader();
            this.grpValidacion = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.chkDNI = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpValidacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Entrega de Encomienda en Agencia";
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Location = new System.Drawing.Point(24, 60);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(38, 15);
            this.lblGuia.TabIndex = 1;
            this.lblGuia.Text = "Guía:";
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(80, 57);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(180, 23);
            this.txtGuia.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(270, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblAgenciaFija
            // 
            this.lblAgenciaFija.AutoSize = true;
            this.lblAgenciaFija.Location = new System.Drawing.Point(24, 92);
            this.lblAgenciaFija.Name = "lblAgenciaFija";
            this.lblAgenciaFija.Size = new System.Drawing.Size(54, 15);
            this.lblAgenciaFija.TabIndex = 4;
            this.lblAgenciaFija.Text = "Agencia:";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAgencia.Location = new System.Drawing.Point(80, 92);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(57, 15);
            this.lblAgencia.TabIndex = 5;
            this.lblAgencia.Text = "(agencia)";
            // 
            // lvGuia
            // 
            this.lvGuia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colApellido,
            this.colDni});
            this.lvGuia.FullRowSelect = true;
            this.lvGuia.GridLines = true;
            this.lvGuia.Location = new System.Drawing.Point(24, 120);
            this.lvGuia.Name = "lvGuia";
            this.lvGuia.Size = new System.Drawing.Size(336, 80);
            this.lvGuia.TabIndex = 6;
            this.lvGuia.UseCompatibleStateImageBehavior = false;
            this.lvGuia.View = System.Windows.Forms.View.Details;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 110;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 110;
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            this.colDni.Width = 110;
            // 
            // grpValidacion
            // 
            this.grpValidacion.Controls.Add(this.lblNombre);
            this.grpValidacion.Controls.Add(this.txtNombre);
            this.grpValidacion.Controls.Add(this.lblApellido);
            this.grpValidacion.Controls.Add(this.txtApellido);
            this.grpValidacion.Controls.Add(this.lblDNI);
            this.grpValidacion.Controls.Add(this.txtDNI);
            this.grpValidacion.Controls.Add(this.chkDNI);
            this.grpValidacion.Location = new System.Drawing.Point(24, 212);
            this.grpValidacion.Name = "grpValidacion";
            this.grpValidacion.Size = new System.Drawing.Size(336, 160);
            this.grpValidacion.TabIndex = 7;
            this.grpValidacion.TabStop = false;
            this.grpValidacion.Text = "Validación de quien retira";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(16, 62);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(16, 94);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 15);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(96, 91);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(220, 23);
            this.txtDNI.TabIndex = 5;
            // 
            // chkDNI
            // 
            this.chkDNI.AutoSize = true;
            this.chkDNI.Location = new System.Drawing.Point(16, 126);
            this.chkDNI.Name = "chkDNI";
            this.chkDNI.Size = new System.Drawing.Size(300, 19);
            this.chkDNI.TabIndex = 6;
            this.chkDNI.Text = "Documento de identidad presentado y verificado";
            this.chkDNI.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(180, 384);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 30);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar Entrega";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(306, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EntregaAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpValidacion);
            this.Controls.Add(this.lvGuia);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblAgenciaFija);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.lblGuia);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntregaAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega en Agencia";
            this.grpValidacion.ResumeLayout(false);
            this.grpValidacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
