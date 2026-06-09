namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    partial class EstadoCuentaCorrienteXCliente
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpCliente = new GroupBox();
            btnBuscarCliente = new Button();
            cboRazonSocial = new ComboBox();
            lblRazonSocial = new Label();
            txtCuit = new TextBox();
            lblCuit = new Label();
            txtEstadoCuenta = new TextBox();
            lblEstadoCuenta = new Label();
            txtSaldoActual = new TextBox();
            lblSaldoActual = new Label();
            txtCondicionFacturacion = new TextBox();
            lblCondicionFacturacion = new Label();
            lblServicios = new Label();
            lvServiciosPendientes = new ListView();
            colFecha = new ColumnHeader();
            colNumeroServicio = new ColumnHeader();
            colTipoServicio = new ColumnHeader();
            colOrigen = new ColumnHeader();
            colDestino = new ColumnHeader();
            colImporte = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblCantidadServicios = new Label();
            txtCantidadServicios = new TextBox();
            lblTotalFacturar = new Label();
            txtTotalFacturar = new TextBox();
            btnEmitirFactura = new Button();
            btnCancelar = new Button();
            grpCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(25, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(435, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Estado de Cuenta por Cliente";
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(btnBuscarCliente);
            grpCliente.Controls.Add(cboRazonSocial);
            grpCliente.Controls.Add(lblRazonSocial);
            grpCliente.Controls.Add(txtCuit);
            grpCliente.Controls.Add(lblCuit);
            grpCliente.Controls.Add(txtEstadoCuenta);
            grpCliente.Controls.Add(lblEstadoCuenta);
            grpCliente.Controls.Add(txtSaldoActual);
            grpCliente.Controls.Add(lblSaldoActual);
            grpCliente.Controls.Add(txtCondicionFacturacion);
            grpCliente.Controls.Add(lblCondicionFacturacion);
            grpCliente.Location = new Point(25, 88);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(1325, 238);
            grpCliente.TabIndex = 1;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(450, 60);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(150, 50);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRazonSocial.FormattingEnabled = true;
            cboRazonSocial.Location = new Point(25, 68);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(386, 33);
            cboRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(25, 38);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(115, 25);
            lblRazonSocial.TabIndex = 0;
            lblRazonSocial.Text = "Razón social ";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(25, 165);
            txtCuit.Name = "txtCuit";
            txtCuit.ReadOnly = true;
            txtCuit.Size = new Size(249, 31);
            txtCuit.TabIndex = 4;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(25, 135);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(49, 25);
            lblCuit.TabIndex = 3;
            lblCuit.Text = "CUIT";
            // 
            // txtEstadoCuenta
            // 
            txtEstadoCuenta.Location = new Point(325, 165);
            txtEstadoCuenta.Name = "txtEstadoCuenta";
            txtEstadoCuenta.ReadOnly = true;
            txtEstadoCuenta.Size = new Size(274, 31);
            txtEstadoCuenta.TabIndex = 6;
            // 
            // lblEstadoCuenta
            // 
            lblEstadoCuenta.AutoSize = true;
            lblEstadoCuenta.Location = new Point(325, 135);
            lblEstadoCuenta.Name = "lblEstadoCuenta";
            lblEstadoCuenta.Size = new Size(151, 25);
            lblEstadoCuenta.TabIndex = 5;
            lblEstadoCuenta.Text = "Estado de Cuenta";
            lblEstadoCuenta.Click += lblEstadoCuenta_Click;
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Location = new Point(650, 165);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.ReadOnly = true;
            txtSaldoActual.Size = new Size(249, 31);
            txtSaldoActual.TabIndex = 8;
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Location = new Point(650, 135);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(111, 25);
            lblSaldoActual.TabIndex = 7;
            lblSaldoActual.Text = "Saldo Actual";
            // 
            // txtCondicionFacturacion
            // 
            txtCondicionFacturacion.Location = new Point(925, 164);
            txtCondicionFacturacion.Name = "txtCondicionFacturacion";
            txtCondicionFacturacion.ReadOnly = true;
            txtCondicionFacturacion.Size = new Size(324, 31);
            txtCondicionFacturacion.TabIndex = 10;
            // 
            // lblCondicionFacturacion
            // 
            lblCondicionFacturacion.AutoSize = true;
            lblCondicionFacturacion.Location = new Point(918, 135);
            lblCondicionFacturacion.Name = "lblCondicionFacturacion";
            lblCondicionFacturacion.Size = new Size(399, 25);
            lblCondicionFacturacion.TabIndex = 9;
            lblCondicionFacturacion.Text = "Condición para facturar (habilitado o bloqueado)";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(25, 350);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(257, 25);
            lblServicios.TabIndex = 2;
            lblServicios.Text = "Detalles pendientes de factura";
            // 
            // lvServiciosPendientes
            // 
            lvServiciosPendientes.Columns.AddRange(new ColumnHeader[] { colFecha, colNumeroServicio, colTipoServicio, colOrigen, colDestino, colImporte, colEstado });
            lvServiciosPendientes.FullRowSelect = true;
            lvServiciosPendientes.Location = new Point(25, 381);
            lvServiciosPendientes.Name = "lvServiciosPendientes";
            lvServiciosPendientes.Size = new Size(1324, 324);
            lvServiciosPendientes.TabIndex = 3;
            lvServiciosPendientes.UseCompatibleStateImageBehavior = false;
            lvServiciosPendientes.View = View.Details;
            // 
            // colFecha
            // 
            colFecha.Text = "Fecha";
            colFecha.Width = 100;
            // 
            // colNumeroServicio
            // 
            colNumeroServicio.Text = "Nro Guía";
            colNumeroServicio.Width = 160;
            // 
            // colTipoServicio
            // 
            colTipoServicio.Text = "Tipo";
            colTipoServicio.Width = 150;
            // 
            // colOrigen
            // 
            colOrigen.Text = "Origen";
            colOrigen.Width = 140;
            // 
            // colDestino
            // 
            colDestino.Text = "Destino";
            colDestino.Width = 140;
            // 
            // colImporte
            // 
            colImporte.Text = "Importe";
            colImporte.Width = 120;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 170;
            // 
            // lblCantidadServicios
            // 
            lblCantidadServicios.AutoSize = true;
            lblCantidadServicios.Location = new Point(25, 738);
            lblCantidadServicios.Name = "lblCantidadServicios";
            lblCantidadServicios.Size = new Size(180, 25);
            lblCantidadServicios.TabIndex = 4;
            lblCantidadServicios.Text = "Cantidad de detalles";
            // 
            // txtCantidadServicios
            // 
            txtCantidadServicios.Location = new Point(225, 734);
            txtCantidadServicios.Name = "txtCantidadServicios";
            txtCantidadServicios.ReadOnly = true;
            txtCantidadServicios.Size = new Size(124, 31);
            txtCantidadServicios.TabIndex = 5;
            // 
            // lblTotalFacturar
            // 
            lblTotalFacturar.AutoSize = true;
            lblTotalFacturar.Location = new Point(412, 738);
            lblTotalFacturar.Name = "lblTotalFacturar";
            lblTotalFacturar.Size = new Size(128, 25);
            lblTotalFacturar.TabIndex = 6;
            lblTotalFacturar.Text = "Total a facturar";
            // 
            // txtTotalFacturar
            // 
            txtTotalFacturar.Location = new Point(569, 734);
            txtTotalFacturar.Name = "txtTotalFacturar";
            txtTotalFacturar.ReadOnly = true;
            txtTotalFacturar.Size = new Size(186, 31);
            txtTotalFacturar.TabIndex = 7;
            // 
            // btnEmitirFactura
            // 
            btnEmitirFactura.Location = new Point(950, 812);
            btnEmitirFactura.Name = "btnEmitirFactura";
            btnEmitirFactura.Size = new Size(188, 56);
            btnEmitirFactura.TabIndex = 8;
            btnEmitirFactura.Text = "Emitir Factura";
            btnEmitirFactura.UseVisualStyleBackColor = true;
            btnEmitirFactura.Click += btnEmitirFactura_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1162, 812);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 56);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EstadoCuentaCorrienteXCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 900);
            Controls.Add(btnCancelar);
            Controls.Add(btnEmitirFactura);
            Controls.Add(txtTotalFacturar);
            Controls.Add(lblTotalFacturar);
            Controls.Add(txtCantidadServicios);
            Controls.Add(lblCantidadServicios);
            Controls.Add(lvServiciosPendientes);
            Controls.Add(lblServicios);
            Controls.Add(grpCliente);
            Controls.Add(lblTitulo);
            Name = "EstadoCuentaCorrienteXCliente";
            Text = "Estado de Cuenta Corriente por Cliente";
            Load += EstadoCuentaCorrienteXCliente_Load;
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private GroupBox grpCliente;
        private ComboBox cboRazonSocial;
        private Label lblRazonSocial;
        private Button btnBuscarCliente;
        private TextBox txtCuit;
        private Label lblCuit;
        private TextBox txtEstadoCuenta;
        private Label lblEstadoCuenta;
        private TextBox txtSaldoActual;
        private Label lblSaldoActual;
        private TextBox txtCondicionFacturacion;
        private Label lblCondicionFacturacion;
        private Label lblServicios;
        private ListView lvServiciosPendientes;
        private ColumnHeader colFecha;
        private ColumnHeader colNumeroServicio;
        private ColumnHeader colTipoServicio;
        private ColumnHeader colOrigen;
        private ColumnHeader colDestino;
        private ColumnHeader colImporte;
        private ColumnHeader colEstado;
        private Label lblCantidadServicios;
        private TextBox txtCantidadServicios;
        private Label lblTotalFacturar;
        private TextBox txtTotalFacturar;
        private Button btnEmitirFactura;
        private Button btnCancelar;
    }
}
