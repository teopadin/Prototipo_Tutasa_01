using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    partial class RecepcionMediaDistancia
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
            lblNumeroHojaRuta = new Label();
            txtNumeroHojaRuta = new TextBox();
            btnBuscar = new Button();
            lblFechaRecepcion = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblEmpresaTransporte = new Label();
            txtEmpresaTransporte = new TextBox();
            lblIdServicio = new Label();
            txtIdServicio = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblOrigen = new Label();
            txtOrigen = new TextBox();
            lblCantidadGuias = new Label();
            txtCantidadGuias = new TextBox();
            lblGuiasIncluidas = new Label();
            lvGuias = new ListView();
            colNumeroGuia = new ColumnHeader();
            colTipoBulto = new ColumnHeader();
            btnConfirmarRecepcion = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(17, 9);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(451, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepción de hoja de ruta de media distancia";
            // 
            // lblNumeroHojaRuta
            // 
            lblNumeroHojaRuta.AutoSize = true;
            lblNumeroHojaRuta.Location = new Point(17, 56);
            lblNumeroHojaRuta.Margin = new Padding(2, 0, 2, 0);
            lblNumeroHojaRuta.Name = "lblNumeroHojaRuta";
            lblNumeroHojaRuta.Size = new Size(93, 15);
            lblNumeroHojaRuta.TabIndex = 1;
            lblNumeroHojaRuta.Text = "Nro hoja de ruta";
            // 
            // txtNumeroHojaRuta
            // 
            txtNumeroHojaRuta.Location = new Point(140, 54);
            txtNumeroHojaRuta.Margin = new Padding(2, 2, 2, 2);
            txtNumeroHojaRuta.Name = "txtNumeroHojaRuta";
            txtNumeroHojaRuta.Size = new Size(158, 23);
            txtNumeroHojaRuta.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(315, 53);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 24);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(446, 56);
            lblFechaRecepcion.Margin = new Padding(2, 0, 2, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(93, 15);
            lblFechaRecepcion.TabIndex = 4;
            lblFechaRecepcion.Text = "Fecha recepción";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(560, 54);
            dtpFechaRecepcion.Margin = new Padding(2, 2, 2, 2);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(123, 23);
            dtpFechaRecepcion.TabIndex = 5;
            // 
            // lblEmpresaTransporte
            // 
            lblEmpresaTransporte.AutoSize = true;
            lblEmpresaTransporte.Location = new Point(17, 93);
            lblEmpresaTransporte.Margin = new Padding(2, 0, 2, 0);
            lblEmpresaTransporte.Name = "lblEmpresaTransporte";
            lblEmpresaTransporte.Size = new Size(109, 15);
            lblEmpresaTransporte.TabIndex = 8;
            lblEmpresaTransporte.Text = "Empresa transporte";
            // 
            // txtEmpresaTransporte
            // 
            txtEmpresaTransporte.Location = new Point(157, 91);
            txtEmpresaTransporte.Margin = new Padding(2, 2, 2, 2);
            txtEmpresaTransporte.Name = "txtEmpresaTransporte";
            txtEmpresaTransporte.ReadOnly = true;
            txtEmpresaTransporte.Size = new Size(219, 23);
            txtEmpresaTransporte.TabIndex = 9;
            // 
            // lblIdServicio
            // 
            lblIdServicio.AutoSize = true;
            lblIdServicio.Location = new Point(411, 93);
            lblIdServicio.Margin = new Padding(2, 0, 2, 0);
            lblIdServicio.Name = "lblIdServicio";
            lblIdServicio.Size = new Size(62, 15);
            lblIdServicio.TabIndex = 10;
            lblIdServicio.Text = "ID Servicio";
            // 
            // txtIdServicio
            // 
            txtIdServicio.Location = new Point(499, 91);
            txtIdServicio.Margin = new Padding(2, 2, 2, 2);
            txtIdServicio.Name = "txtIdServicio";
            txtIdServicio.ReadOnly = true;
            txtIdServicio.Size = new Size(158, 23);
            txtIdServicio.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(17, 127);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(140, 125);
            txtEstado.Margin = new Padding(2, 2, 2, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(158, 23);
            txtEstado.TabIndex = 13;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(17, 161);
            lblOrigen.Margin = new Padding(2, 0, 2, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 14;
            lblOrigen.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(140, 159);
            txtOrigen.Margin = new Padding(2, 2, 2, 2);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.ReadOnly = true;
            txtOrigen.Size = new Size(158, 23);
            txtOrigen.TabIndex = 15;
            // 
            // lblCantidadGuias
            // 
            lblCantidadGuias.AutoSize = true;
            lblCantidadGuias.Location = new Point(409, 161);
            lblCantidadGuias.Margin = new Padding(2, 0, 2, 0);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(102, 15);
            lblCantidadGuias.TabIndex = 18;
            lblCantidadGuias.Text = "Cantidad de guías";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(540, 159);
            txtCantidadGuias.Margin = new Padding(2, 2, 2, 2);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(88, 23);
            txtCantidadGuias.TabIndex = 19;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(17, 198);
            lblGuiasIncluidas.Margin = new Padding(2, 0, 2, 0);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(36, 15);
            lblGuiasIncluidas.TabIndex = 20;
            lblGuiasIncluidas.Text = "Guías";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colTipoBulto });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(17, 217);
            lvGuias.Margin = new Padding(2, 2, 2, 2);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(841, 188);
            lvGuias.TabIndex = 21;
            lvGuias.UseCompatibleStateImageBehavior = false;
            lvGuias.View = View.Details;
            lvGuias.SelectedIndexChanged += lvGuias_SelectedIndexChanged;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guía";
            colNumeroGuia.Width = 140;
            // 
            // colTipoBulto
            // 
            colTipoBulto.Text = "Tipo Bulto";
            colTipoBulto.Width = 180;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(665, 427);
            btnConfirmarRecepcion.Margin = new Padding(2, 2, 2, 2);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(131, 31);
            btnConfirmarRecepcion.TabIndex = 22;
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(814, 427);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 31);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // RecepcionMediaDistancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 465);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarRecepcion);
            Controls.Add(lvGuias);
            Controls.Add(lblGuiasIncluidas);
            Controls.Add(txtCantidadGuias);
            Controls.Add(lblCantidadGuias);
            Controls.Add(txtOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtIdServicio);
            Controls.Add(lblIdServicio);
            Controls.Add(txtEmpresaTransporte);
            Controls.Add(lblEmpresaTransporte);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroHojaRuta);
            Controls.Add(lblNumeroHojaRuta);
            Controls.Add(lblTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RecepcionMediaDistancia";
            Text = "Recepción de hoja de ruta de media distancia";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblNumeroHojaRuta;
        private TextBox txtNumeroHojaRuta;
        private Button btnBuscar;
        private Label lblFechaRecepcion;
        private DateTimePicker dtpFechaRecepcion;
        private Label lblEmpresaTransporte;
        private TextBox txtEmpresaTransporte;
        private Label lblIdServicio;
        private TextBox txtIdServicio;
        private Label lblEstado;
        private TextBox txtEstado;
        private Label lblOrigen;
        private TextBox txtOrigen;
        private Label lblCantidadGuias;
        private TextBox txtCantidadGuias;
        private Label lblGuiasIncluidas;
        private ListView lvGuias;
        private ColumnHeader colNumeroGuia;
        private ColumnHeader colTipoBulto;
        private Button btnConfirmarRecepcion;
        private Button btnCancelar;
    }
}
