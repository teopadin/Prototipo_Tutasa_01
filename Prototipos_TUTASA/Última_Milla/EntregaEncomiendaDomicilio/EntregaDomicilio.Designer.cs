namespace Prototipos_TUTASA
{
    partial class EntregaDomicilio
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
            colDomicilio = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblFletero = new Label();
            cboFletero = new ComboBox();
            lblFechaEntrega = new Label();
            dtpFechaEntrega = new DateTimePicker();
            rbEntregada = new RadioButton();
            rbNoEntregada = new RadioButton();
            lblMotivo = new Label();
            cboMotivo = new ComboBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitulo.Location = new Point(12, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Rendición de Entrega a Domicilio";
            // 
            // lblGuia
            // 
            lblGuia.Location = new Point(12, 62);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(74, 18);
            lblGuia.TabIndex = 1;
            lblGuia.Text = "Guía";
            // 
            // txtGuia
            // 
            txtGuia.Location = new Point(92, 62);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new Size(120, 26);
            txtGuia.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(229, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 41);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            // 
            // lvGuia
            // 
            lvGuia.Columns.AddRange(new ColumnHeader[] { colNombre, colApellido, colDNI, colDomicilio, colEstado });
            lvGuia.FullRowSelect = true;
            lvGuia.GridLines = true;
            lvGuia.Location = new Point(12, 106);
            lvGuia.Name = "lvGuia";
            lvGuia.Size = new Size(595, 110);
            lvGuia.TabIndex = 4;
            lvGuia.UseCompatibleStateImageBehavior = false;
            lvGuia.View = View.Details;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 100;
            // 
            // colApellido
            // 
            colApellido.Text = "Apellido";
            colApellido.Width = 100;
            // 
            // colDNI
            // 
            colDNI.Text = "DNI";
            colDNI.Width = 90;
            // 
            // colDomicilio
            // 
            colDomicilio.Text = "Domicilio de entrega";
            colDomicilio.Width = 220;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 80;
            // 
            // lblFletero
            // 
            lblFletero.Location = new Point(12, 233);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(272, 29);
            lblFletero.TabIndex = 5;
            lblFletero.Text = "Fletero que realizó la entrega";
            // 
            // cboFletero
            // 
            cboFletero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFletero.Items.AddRange(new object[] { "Luis Fernández", "Carlos Romero", "Pablo García" });
            cboFletero.Location = new Point(12, 265);
            cboFletero.Name = "cboFletero";
            cboFletero.Size = new Size(218, 28);
            cboFletero.TabIndex = 6;
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.Location = new Point(350, 233);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(257, 31);
            lblFechaEntrega.TabIndex = 7;
            lblFechaEntrega.Text = "Fecha y hora de entrega";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CustomFormat = "dd/MM/yyyy  HH:mm";
            dtpFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrega.Location = new Point(350, 267);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(257, 26);
            dtpFechaEntrega.TabIndex = 8;
            // 
            // rbEntregada
            // 
            rbEntregada.Checked = true;
            rbEntregada.Location = new Point(21, 45);
            rbEntregada.Name = "rbEntregada";
            rbEntregada.Size = new Size(179, 34);
            rbEntregada.TabIndex = 10;
            rbEntregada.TabStop = true;
            rbEntregada.Text = "Entregada";
            // 
            // rbNoEntregada
            // 
            rbNoEntregada.Location = new Point(299, 45);
            rbNoEntregada.Name = "rbNoEntregada";
            rbNoEntregada.Size = new Size(180, 34);
            rbNoEntregada.TabIndex = 11;
            rbNoEntregada.Text = "No entregada";
            // 
            // lblMotivo
            // 
            lblMotivo.Location = new Point(279, 110);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(250, 36);
            lblMotivo.TabIndex = 12;
            lblMotivo.Text = "Motivo de no entrega";
            // 
            // cboMotivo
            // 
            cboMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMotivo.Enabled = false;
            cboMotivo.Items.AddRange(new object[] { "Destinatario ausente - 1er intento", "Destinatario ausente - 2do intento", "Dirección incorrecta", "Destinatario rechazó la encomienda" });
            cboMotivo.Location = new Point(279, 149);
            cboMotivo.Name = "cboMotivo";
            cboMotivo.Size = new Size(300, 28);
            cboMotivo.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(92, 535);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(192, 71);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar Rendición";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(290, 535);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 71);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEntregada);
            groupBox1.Controls.Add(rbNoEntregada);
            groupBox1.Controls.Add(lblMotivo);
            groupBox1.Controls.Add(cboMotivo);
            groupBox1.Location = new Point(12, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 203);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado de la entrega";
            // 
            // EntregaDomicilio
            // 
            ClientSize = new Size(632, 656);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(lblGuia);
            Controls.Add(txtGuia);
            Controls.Add(btnBuscar);
            Controls.Add(lvGuia);
            Controls.Add(lblFletero);
            Controls.Add(cboFletero);
            Controls.Add(lblFechaEntrega);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EntregaDomicilio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Rendición de Entrega a Domicilio";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvGuia;
        private System.Windows.Forms.ColumnHeader colNombre, colApellido, colDNI, colDomicilio, colEstado;
        private System.Windows.Forms.Label lblFletero;
        private System.Windows.Forms.ComboBox cboFletero;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.RadioButton rbEntregada, rbNoEntregada;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox cboMotivo;
        private System.Windows.Forms.Button btnRegistrar, btnCancelar;
        private GroupBox groupBox1;
    }
}