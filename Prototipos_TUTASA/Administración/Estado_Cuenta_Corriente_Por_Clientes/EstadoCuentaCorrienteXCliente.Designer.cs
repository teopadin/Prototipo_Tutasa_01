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
            lblTitulo.Location = new Point(32, 24);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
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
            grpCliente.Location = new Point(32, 113);
            grpCliente.Margin = new Padding(4);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(4);
            grpCliente.Size = new Size(1722, 305);
            grpCliente.TabIndex = 1;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(585, 77);
            btnBuscarCliente.Margin = new Padding(4);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(195, 64);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // cboRazonSocial
            // 
            cboRazonSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRazonSocial.FormattingEnabled = true;
            cboRazonSocial.Location = new Point(32, 87);
            cboRazonSocial.Margin = new Padding(4);
            cboRazonSocial.Name = "cboRazonSocial";
            cboRazonSocial.Size = new Size(501, 40);
            cboRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(32, 49);
            lblRazonSocial.Margin = new Padding(4, 0, 4, 0);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(152, 32);
            lblRazonSocial.TabIndex = 0;
            lblRazonSocial.Text = "Razón social ";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(32, 211);
            txtCuit.Margin = new Padding(4);
            txtCuit.Name = "txtCuit";
            txtCuit.ReadOnly = true;
            txtCuit.Size = new Size(322, 39);
            txtCuit.TabIndex = 4;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(32, 173);
            lblCuit.Margin = new Padding(4, 0, 4, 0);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(64, 32);
            lblCuit.TabIndex = 3;
            lblCuit.Text = "CUIT";
            // 
            // txtEstadoCuenta
            // 
            txtEstadoCuenta.Location = new Point(422, 211);
            txtEstadoCuenta.Margin = new Padding(4);
            txtEstadoCuenta.Name = "txtEstadoCuenta";
            txtEstadoCuenta.ReadOnly = true;
            txtEstadoCuenta.Size = new Size(355, 39);
            txtEstadoCuenta.TabIndex = 6;
            // 
            // lblEstadoCuenta
            // 
            lblEstadoCuenta.AutoSize = true;
            lblEstadoCuenta.Location = new Point(422, 173);
            lblEstadoCuenta.Margin = new Padding(4, 0, 4, 0);
            lblEstadoCuenta.Name = "lblEstadoCuenta";
            lblEstadoCuenta.Size = new Size(201, 32);
            lblEstadoCuenta.TabIndex = 5;
            lblEstadoCuenta.Text = "Estado de Cuenta";
           
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Location = new Point(845, 211);
            txtSaldoActual.Margin = new Padding(4);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.ReadOnly = true;
            txtSaldoActual.Size = new Size(322, 39);
            txtSaldoActual.TabIndex = 8;
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Location = new Point(845, 173);
            lblSaldoActual.Margin = new Padding(4, 0, 4, 0);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(146, 32);
            lblSaldoActual.TabIndex = 7;
            lblSaldoActual.Text = "Saldo Actual";
            lblSaldoActual.Click += lblSaldoActual_Click;
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(32, 448);
            lblServicios.Margin = new Padding(4, 0, 4, 0);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(339, 32);
            lblServicios.TabIndex = 2;
            lblServicios.Text = "Detalles pendientes de factura";
            // 
            // lvServiciosPendientes
            // 
            lvServiciosPendientes.Columns.AddRange(new ColumnHeader[] { colFecha, colNumeroServicio, colTipoServicio, colOrigen, colDestino, colImporte, colEstado });
            lvServiciosPendientes.FullRowSelect = true;
            lvServiciosPendientes.Location = new Point(32, 488);
            lvServiciosPendientes.Margin = new Padding(4);
            lvServiciosPendientes.Name = "lvServiciosPendientes";
            lvServiciosPendientes.Size = new Size(1720, 414);
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
            lblCantidadServicios.Location = new Point(32, 945);
            lblCantidadServicios.Margin = new Padding(4, 0, 4, 0);
            lblCantidadServicios.Name = "lblCantidadServicios";
            lblCantidadServicios.Size = new Size(232, 32);
            lblCantidadServicios.TabIndex = 4;
            lblCantidadServicios.Text = "Cantidad de detalles";
            // 
            // txtCantidadServicios
            // 
            txtCantidadServicios.Location = new Point(292, 940);
            txtCantidadServicios.Margin = new Padding(4);
            txtCantidadServicios.Name = "txtCantidadServicios";
            txtCantidadServicios.ReadOnly = true;
            txtCantidadServicios.Size = new Size(160, 39);
            txtCantidadServicios.TabIndex = 5;
            // 
            // lblTotalFacturar
            // 
            lblTotalFacturar.AutoSize = true;
            lblTotalFacturar.Location = new Point(536, 945);
            lblTotalFacturar.Margin = new Padding(4, 0, 4, 0);
            lblTotalFacturar.Name = "lblTotalFacturar";
            lblTotalFacturar.Size = new Size(172, 32);
            lblTotalFacturar.TabIndex = 6;
            lblTotalFacturar.Text = "Total a facturar";
            // 
            // txtTotalFacturar
            // 
            txtTotalFacturar.Location = new Point(740, 940);
            txtTotalFacturar.Margin = new Padding(4);
            txtTotalFacturar.Name = "txtTotalFacturar";
            txtTotalFacturar.ReadOnly = true;
            txtTotalFacturar.Size = new Size(241, 39);
            txtTotalFacturar.TabIndex = 7;
            // 
            // btnEmitirFactura
            // 
            btnEmitirFactura.Location = new Point(1235, 1039);
            btnEmitirFactura.Margin = new Padding(4);
            btnEmitirFactura.Name = "btnEmitirFactura";
            btnEmitirFactura.Size = new Size(244, 72);
            btnEmitirFactura.TabIndex = 8;
            btnEmitirFactura.Text = "Emitir Factura";
            btnEmitirFactura.UseVisualStyleBackColor = true;
            btnEmitirFactura.Click += btnEmitirFactura_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1511, 1039);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(244, 72);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EstadoCuentaCorrienteXCliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1795, 1152);
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
            Margin = new Padding(4);
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
