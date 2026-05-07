namespace Prototipos_TUTASA.EntregaenCD_v3
{
    partial class EntregaEncomiendaCD_v3
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblGuia;
        private Label lblListView;
        private Label lblValidacion;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblImporte;
        private Label lblTipo;
        private Label lblFecha;
        private Label lblEstadoEntrega;
        
        private TextBox txtGuia;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        
        private Button btnBuscar;
        private Button btnConfirmarEntrega;
        private Button btnCancelar;
        
        private ListView lvGuias;
        private ColumnHeader colNombre;
        private ColumnHeader colApellido;
        private ColumnHeader colDNI_LV;
        private ColumnHeader colEstado;
        
        private CheckBox chkFirmoRecibo;
        private CheckBox chkPresentoDNI;
        
        private ComboBox cmbTipo;
        private DateTimePicker dtpFecha;
        
        private RadioButton rbEntregado;
        private RadioButton rbPendiente;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void IniciarComp()
        {
            components = new System.ComponentModel.Container();
            
            lblTitulo = new Label();
            lblGuia = new Label();
            lblListView = new Label();
            lblValidacion = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblImporte = new Label();
            lblTipo = new Label();
            lblFecha = new Label();
            lblEstadoEntrega = new Label();
            
            txtGuia = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            
            btnBuscar = new Button();
            btnConfirmarEntrega = new Button();
            btnCancelar = new Button();
            
            lvGuias = new ListView();
            colNombre = new ColumnHeader();
            colApellido = new ColumnHeader();
            colDNI_LV = new ColumnHeader();
            colEstado = new ColumnHeader();
            
            chkFirmoRecibo = new CheckBox();
            chkPresentoDNI = new CheckBox();
            
            cmbTipo = new ComboBox();
            dtpFecha = new DateTimePicker();
            
            rbEntregado = new RadioButton();
            rbPendiente = new RadioButton();
            
           
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(280, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Entrega de Encomienda en CD";

            lblGuia.AutoSize = true;
            lblGuia.Location = new System.Drawing.Point(20, 70);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new System.Drawing.Size(36, 15);
            lblGuia.TabIndex = 1;
            lblGuia.Text = "Guía:";

            txtGuia.Location = new System.Drawing.Point(70, 70);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new System.Drawing.Size(150, 23);
            txtGuia.TabIndex = 2;

            btnBuscar.Location = new System.Drawing.Point(230, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;

            lblListView.AutoSize = true;
            lblListView.Location = new System.Drawing.Point(20, 105);
            lblListView.Name = "lblListView";
            lblListView.Size = new System.Drawing.Size(180, 15);
            lblListView.TabIndex = 4;
            lblListView.Text = "ListView con la guía buscada";

          
            colNombre.Text = "Nombre";
            colNombre.Width = 120;

            colApellido.Text = "Apellido";
            colApellido.Width = 120;

            colDNI_LV.Text = "DNI";
            colDNI_LV.Width = 100;

            colEstado.Text = "Estado";
            colEstado.Width = 150;

            lblValidacion.AutoSize = true;
            lblValidacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblValidacion.Location = new System.Drawing.Point(20, 220);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new System.Drawing.Size(280, 19);
            lblValidacion.TabIndex = 6;
            lblValidacion.Text = "Validación de Identidad de quien retira";

            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(20, 250);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(57, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";

            txtNombre.Location = new System.Drawing.Point(20, 270);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(120, 23);
            txtNombre.TabIndex = 8;

            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(160, 250);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(57, 15);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";

            txtApellido.Location = new System.Drawing.Point(160, 270);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(120, 23);
            txtApellido.TabIndex = 10;

            lblDNI.AutoSize = true;
            lblDNI.Location = new System.Drawing.Point(300, 250);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new System.Drawing.Size(32, 15);
            lblDNI.TabIndex = 11;
            lblDNI.Text = "DNI";

            txtDNI.Location = new System.Drawing.Point(300, 270);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(120, 23);
            txtDNI.TabIndex = 12;

            lblImporte.AutoSize = true;
            lblImporte.Location = new System.Drawing.Point(20, 310);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new System.Drawing.Size(300, 15);
            lblImporte.TabIndex = 13;
            lblImporte.Text = "[ Label ] Importe a cobrar (según admisión): $ [ XXXX ]";

            chkFirmoRecibo.AutoSize = true;
            chkFirmoRecibo.Location = new System.Drawing.Point(20, 340);
            chkFirmoRecibo.Name = "chkFirmoRecibo";
            chkFirmoRecibo.Size = new System.Drawing.Size(200, 19);
            chkFirmoRecibo.TabIndex = 14;
            chkFirmoRecibo.Text = "Firmó Recibo de encomienda?";
            chkFirmoRecibo.UseVisualStyleBackColor = true;

            chkPresentoDNI.AutoSize = true;
            chkPresentoDNI.Location = new System.Drawing.Point(20, 365);
            chkPresentoDNI.Name = "chkPresentoDNI";
            chkPresentoDNI.Size = new System.Drawing.Size(150, 19);
            chkPresentoDNI.TabIndex = 15;
            chkPresentoDNI.Text = "Presentó DNI/Cédula?";
            chkPresentoDNI.UseVisualStyleBackColor = true;

            lblTipo.AutoSize = true;
            lblTipo.Location = new System.Drawing.Point(450, 250);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(36, 15);
            lblTipo.TabIndex = 16;
            lblTipo.Text = "Tipo:";
            lblTipo.Visible = false;

            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Encomienda", "Paquete", "Documento" });
            cmbTipo.Location = new System.Drawing.Point(450, 270);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(120, 23);
            cmbTipo.TabIndex = 17;
            cmbTipo.Visible = false;

            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(450, 300);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(42, 15);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Fecha:";
            lblFecha.Visible = false;

            dtpFecha.Location = new System.Drawing.Point(450, 320);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(120, 23);
            dtpFecha.TabIndex = 19;
            dtpFecha.Visible = false;

            lblEstadoEntrega.AutoSize = true;
            lblEstadoEntrega.Location = new System.Drawing.Point(450, 350);
            lblEstadoEntrega.Name = "lblEstadoEntrega";
            lblEstadoEntrega.Size = new System.Drawing.Size(48, 15);
            lblEstadoEntrega.TabIndex = 20;
            lblEstadoEntrega.Text = "Estado:";
            lblEstadoEntrega.Visible = false;

            rbEntregado.AutoSize = true;
            rbEntregado.Location = new System.Drawing.Point(450, 370);
            rbEntregado.Name = "rbEntregado";
            rbEntregado.Size = new System.Drawing.Size(80, 19);
            rbEntregado.TabIndex = 21;
            rbEntregado.TabStop = true;
            rbEntregado.Text = "Entregado";
            rbEntregado.UseVisualStyleBackColor = true;
            rbEntregado.Visible = false;

            rbPendiente.AutoSize = true;
            rbPendiente.Location = new System.Drawing.Point(450, 395);
            rbPendiente.Name = "rbPendiente";
            rbPendiente.Size = new System.Drawing.Size(77, 19);
            rbPendiente.TabIndex = 22;
            rbPendiente.TabStop = true;
            rbPendiente.Text = "Pendiente";
            rbPendiente.UseVisualStyleBackColor = true;
            rbPendiente.Visible = false;

            btnConfirmarEntrega.Location = new System.Drawing.Point(450, 410);
            btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            btnConfirmarEntrega.Size = new System.Drawing.Size(120, 30);
            btnConfirmarEntrega.TabIndex = 23;
            btnConfirmarEntrega.Text = "Confirmar Entrega";
            btnConfirmarEntrega.UseVisualStyleBackColor = true;

            btnCancelar.Location = new System.Drawing.Point(580, 410);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(btnConfirmarEntrega);
            this.Controls.Add(rbPendiente);
            this.Controls.Add(rbEntregado);
            this.Controls.Add(lblEstadoEntrega);
            this.Controls.Add(dtpFecha);
            this.Controls.Add(lblFecha);
            this.Controls.Add(cmbTipo);
            this.Controls.Add(lblTipo);
            this.Controls.Add(chkPresentoDNI);
            this.Controls.Add(chkFirmoRecibo);
            this.Controls.Add(lblImporte);
            this.Controls.Add(txtDNI);
            this.Controls.Add(lblDNI);
            this.Controls.Add(txtApellido);
            this.Controls.Add(lblApellido);
            this.Controls.Add(txtNombre);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblValidacion);
            this.Controls.Add(lvGuias);
            this.Controls.Add(lblListView);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(txtGuia);
            this.Controls.Add(lblGuia);
            this.Controls.Add(lblTitulo);
            this.Name = "EntregaEncomiendaCD_v3";
            this.Text = "Entrega de Encomienda en CD";
            this.PerformLayout();
        }

        #endregion
    }
}
