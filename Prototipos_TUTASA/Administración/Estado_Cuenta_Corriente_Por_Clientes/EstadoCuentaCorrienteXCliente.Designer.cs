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
            lblTitulo.Location = new Point(42, 31);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(576, 59);
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
            grpCliente.Location = new Point(42, 144);
            grpCliente.Margin = new Padding(6, 6, 6, 6);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(6, 6, 6, 6);
            grpCliente.Size = new Size(2252, 390);
            grpCliente.TabIndex = 1;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(765, 98);
            btnBuscarCliente.Margin = new Padding(6, 6, 6, 6);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(255, 82);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRazonSocial.FormattingEnabled = true;
            cboRazonSocial.Location = new Point(42, 111);
            cboRazonSocial.Margin = new Padding(6, 6, 6, 6);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(654, 49);
            cboRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(42, 62);
            lblRazonSocial.Margin = new Padding(6, 0, 6, 0);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(190, 41);
            lblRazonSocial.TabIndex = 0;
            lblRazonSocial.Text = "Razón social ";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(42, 271);
            txtCuit.Margin = new Padding(6, 6, 6, 6);
            txtCuit.Name = "txtCuit";
            txtCuit.ReadOnly = true;
            txtCuit.Size = new Size(420, 47);
            txtCuit.TabIndex = 4;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(42, 221);
            lblCuit.Margin = new Padding(6, 0, 6, 0);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(82, 41);
            lblCuit.TabIndex = 3;
            lblCuit.Text = "CUIT";
            // 
            // txtEstadoCuenta
            // 
            txtEstadoCuenta.Location = new Point(552, 271);
            txtEstadoCuenta.Margin = new Padding(6, 6, 6, 6);
            txtEstadoCuenta.Name = "txtEstadoCuenta";
            txtEstadoCuenta.ReadOnly = true;
            txtEstadoCuenta.Size = new Size(463, 47);
            txtEstadoCuenta.TabIndex = 6;
            // 
            // lblEstadoCuenta
            // 
            lblEstadoCuenta.AutoSize = true;
            lblEstadoCuenta.Location = new Point(552, 221);
            lblEstadoCuenta.Margin = new Padding(6, 0, 6, 0);
            lblEstadoCuenta.Name = "lblEstadoCuenta";
            lblEstadoCuenta.Size = new Size(251, 41);
            lblEstadoCuenta.TabIndex = 5;
            lblEstadoCuenta.Text = "Estado de Cuenta";
            lblEstadoCuenta.Click += lblEstadoCuenta_Click;
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Location = new Point(1105, 271);
            txtSaldoActual.Margin = new Padding(6, 6, 6, 6);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.ReadOnly = true;
            txtSaldoActual.Size = new Size(420, 47);
            txtSaldoActual.TabIndex = 8;
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Location = new Point(1105, 221);
            lblSaldoActual.Margin = new Padding(6, 0, 6, 0);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(182, 41);
            lblSaldoActual.TabIndex = 7;
            lblSaldoActual.Text = "Saldo Actual";
            // 
            // txtCondicionFacturacion
            // 
            txtCondicionFacturacion.Location = new Point(1615, 271);
            txtCondicionFacturacion.Margin = new Padding(6, 6, 6, 6);
            txtCondicionFacturacion.Name = "txtCondicionFacturacion";
            txtCondicionFacturacion.ReadOnly = true;
            txtCondicionFacturacion.Size = new Size(548, 47);
            txtCondicionFacturacion.TabIndex = 10;
            // 
            // lblCondicionFacturacion
            // 
            lblCondicionFacturacion.AutoSize = true;
            lblCondicionFacturacion.Location = new Point(1615, 221);
            lblCondicionFacturacion.Margin = new Padding(6, 0, 6, 0);
            lblCondicionFacturacion.Name = "lblCondicionFacturacion";
            lblCondicionFacturacion.Size = new Size(664, 41);
            lblCondicionFacturacion.TabIndex = 9;
            lblCondicionFacturacion.Text = "Condición para facturar (habilitado o bloqueado)";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(42, 574);
            lblServicios.Margin = new Padding(6, 0, 6, 0);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(429, 41);
            lblServicios.TabIndex = 2;
            lblServicios.Text = "Servicios pendientes de factura";
            // 
            // lvServiciosPendientes
            // 
            lvServiciosPendientes.Columns.AddRange(new ColumnHeader[] { colFecha, colNumeroServicio, colTipoServicio, colOrigen, colDestino, colImporte, colEstado });
            lvServiciosPendientes.FullRowSelect = true;
            lvServiciosPendientes.Location = new Point(42, 625);
            lvServiciosPendientes.Margin = new Padding(6, 6, 6, 6);
            lvServiciosPendientes.Name = "lvServiciosPendientes";
            lvServiciosPendientes.Size = new Size(2248, 529);
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
            colNumeroServicio.Text = "Nro Servicio / Guía";
            colNumeroServicio.Width = 160;
            // 
            // colTipoServicio
            // 
            colTipoServicio.Text = "Tipo Servicio";
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
            colEstado.Width = 140;
            // 
            // lblCantidadServicios
            // 
            lblCantidadServicios.AutoSize = true;
            lblCantidadServicios.Location = new Point(42, 1210);
            lblCantidadServicios.Margin = new Padding(6, 0, 6, 0);
            lblCantidadServicios.Name = "lblCantidadServicios";
            lblCantidadServicios.Size = new Size(299, 41);
            lblCantidadServicios.TabIndex = 4;
            lblCantidadServicios.Text = "Cantidad de servicios";
            // 
            // txtCantidadServicios
            // 
            txtCantidadServicios.Location = new Point(382, 1203);
            txtCantidadServicios.Margin = new Padding(6, 6, 6, 6);
            txtCantidadServicios.Name = "txtCantidadServicios";
            txtCantidadServicios.ReadOnly = true;
            txtCantidadServicios.Size = new Size(208, 47);
            txtCantidadServicios.TabIndex = 5;
            // 
            // lblTotalFacturar
            // 
            lblTotalFacturar.AutoSize = true;
            lblTotalFacturar.Location = new Point(701, 1210);
            lblTotalFacturar.Margin = new Padding(6, 0, 6, 0);
            lblTotalFacturar.Name = "lblTotalFacturar";
            lblTotalFacturar.Size = new Size(212, 41);
            lblTotalFacturar.TabIndex = 6;
            lblTotalFacturar.Text = "Total a facturar";
            // 
            // txtTotalFacturar
            // 
            txtTotalFacturar.Location = new Point(967, 1203);
            txtTotalFacturar.Margin = new Padding(6, 6, 6, 6);
            txtTotalFacturar.Name = "txtTotalFacturar";
            txtTotalFacturar.ReadOnly = true;
            txtTotalFacturar.Size = new Size(314, 47);
            txtTotalFacturar.TabIndex = 7;
            // 
            // btnEmitirFactura
            // 
            btnEmitirFactura.Location = new Point(1615, 1332);
            btnEmitirFactura.Margin = new Padding(6, 6, 6, 6);
            btnEmitirFactura.Name = "btnEmitirFactura";
            btnEmitirFactura.Size = new Size(319, 92);
            btnEmitirFactura.TabIndex = 8;
            btnEmitirFactura.Text = "Emitir Factura";
            btnEmitirFactura.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1976, 1332);
            btnCancelar.Margin = new Padding(6, 6, 6, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(319, 92);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // EstadoCuentaCorrienteXCliente
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2348, 1476);
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
            Margin = new Padding(6, 6, 6, 6);
            Name = "EstadoCuentaCorrienteXCliente";
            Text = "Estado de Cuenta Corriente por Cliente";
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

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

        #endregion
    }
}
