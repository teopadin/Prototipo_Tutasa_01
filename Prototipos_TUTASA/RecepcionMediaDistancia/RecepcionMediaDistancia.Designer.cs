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
            lblEmpresaTransporte = new Label();
            txtEmpresaTransporte = new TextBox();
            lblCantidadGuias = new Label();
            txtCantidadGuias = new TextBox();
            lblGuiasIncluidas = new Label();
            lvGuias = new ListView();
            colNumeroGuia = new ColumnHeader();
            colTipoBulto = new ColumnHeader();
            colNroHDR = new ColumnHeader();
            colCDOrigen = new ColumnHeader();
            btnConfirmarRecepcion = new Button();
            btnCancelar = new Button();
            cmboIDServicio = new ComboBox();
            dateTimeFechaDespacho = new DateTimePicker();
            lblFechaDespacho = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(25, 19);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(667, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepción de hoja de ruta de media distancia";
            // 
            // lblNumeroHojaRuta
            // 
            lblNumeroHojaRuta.AutoSize = true;
            lblNumeroHojaRuta.Location = new Point(25, 94);
            lblNumeroHojaRuta.Margin = new Padding(4, 0, 4, 0);
            lblNumeroHojaRuta.Name = "lblNumeroHojaRuta";
            lblNumeroHojaRuta.Size = new Size(303, 25);
            lblNumeroHojaRuta.TabIndex = 1;
            lblNumeroHojaRuta.Text = "ID Servicios Pendientes de Despacho";
            // 
            // lblEmpresaTransporte
            // 
            lblEmpresaTransporte.AutoSize = true;
            lblEmpresaTransporte.Location = new Point(25, 155);
            lblEmpresaTransporte.Margin = new Padding(4, 0, 4, 0);
            lblEmpresaTransporte.Name = "lblEmpresaTransporte";
            lblEmpresaTransporte.Size = new Size(167, 25);
            lblEmpresaTransporte.TabIndex = 8;
            lblEmpresaTransporte.Text = "Empresa transporte";
            // 
            // txtEmpresaTransporte
            // 
            txtEmpresaTransporte.Location = new Point(225, 152);
            txtEmpresaTransporte.Margin = new Padding(4);
            txtEmpresaTransporte.Name = "txtEmpresaTransporte";
            txtEmpresaTransporte.ReadOnly = true;
            txtEmpresaTransporte.Size = new Size(312, 31);
            txtEmpresaTransporte.TabIndex = 9;
            // 
            // lblCantidadGuias
            // 
            lblCantidadGuias.AutoSize = true;
            lblCantidadGuias.Location = new Point(25, 227);
            lblCantidadGuias.Margin = new Padding(4, 0, 4, 0);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(155, 25);
            lblCantidadGuias.TabIndex = 18;
            lblCantidadGuias.Text = "Cantidad de guías";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(212, 224);
            txtCantidadGuias.Margin = new Padding(4);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(124, 31);
            txtCantidadGuias.TabIndex = 19;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(25, 278);
            lblGuiasIncluidas.Margin = new Padding(4, 0, 4, 0);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(55, 25);
            lblGuiasIncluidas.TabIndex = 20;
            lblGuiasIncluidas.Text = "Guías";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colTipoBulto, colNroHDR, colCDOrigen });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(25, 310);
            lvGuias.Margin = new Padding(4);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(1199, 311);
            lvGuias.TabIndex = 21;
            lvGuias.UseCompatibleStateImageBehavior = false;
            lvGuias.View = View.Details;
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
            // colNroHDR
            // 
            colNroHDR.Text = "Nro HDR a la que pertenece";
            colNroHDR.Width = 250;
            // 
            // colCDOrigen
            // 
            colCDOrigen.Text = "CD Origen";
            colCDOrigen.Width = 120;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(465, 645);
            btnConfirmarRecepcion.Margin = new Padding(4);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(188, 52);
            btnConfirmarRecepcion.TabIndex = 22;
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            btnConfirmarRecepcion.Click += btnConfirmarRecepcion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(677, 645);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 52);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmboIDServicio
            // 
            cmboIDServicio.FormattingEnabled = true;
            cmboIDServicio.Location = new Point(335, 86);
            cmboIDServicio.Name = "cmboIDServicio";
            cmboIDServicio.Size = new Size(227, 33);
            cmboIDServicio.TabIndex = 24;
            cmboIDServicio.SelectedIndexChanged += cmboIDServicio_SelectedIndexChanged;
            // 
            // dateTimeFechaDespacho
            // 
            dateTimeFechaDespacho.Location = new Point(763, 155);
            dateTimeFechaDespacho.Name = "dateTimeFechaDespacho";
            dateTimeFechaDespacho.Size = new Size(300, 31);
            dateTimeFechaDespacho.TabIndex = 25;
            // 
            // lblFechaDespacho
            // 
            lblFechaDespacho.AutoSize = true;
            lblFechaDespacho.Location = new Point(605, 161);
            lblFechaDespacho.Name = "lblFechaDespacho";
            lblFechaDespacho.Size = new Size(148, 25);
            lblFechaDespacho.TabIndex = 26;
            lblFechaDespacho.Text = "Fecha de Llegada";
            // 
            // RecepcionMediaDistancia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 721);
            Controls.Add(lblFechaDespacho);
            Controls.Add(dateTimeFechaDespacho);
            Controls.Add(cmboIDServicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarRecepcion);
            Controls.Add(lvGuias);
            Controls.Add(lblGuiasIncluidas);
            Controls.Add(txtCantidadGuias);
            Controls.Add(lblCantidadGuias);
            Controls.Add(txtEmpresaTransporte);
            Controls.Add(lblEmpresaTransporte);
            Controls.Add(lblNumeroHojaRuta);
            Controls.Add(lblTitulo);
            Margin = new Padding(4);
            Name = "RecepcionMediaDistancia";
            Text = "Recepción de hoja de ruta de media distancia";
            Load += RecepcionMediaDistancia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblNumeroHojaRuta;
        private Label lblEmpresaTransporte;
        private TextBox txtEmpresaTransporte;
        private Label lblCantidadGuias;
        private TextBox txtCantidadGuias;
        private Label lblGuiasIncluidas;
        private ListView lvGuias;
        private ColumnHeader colNumeroGuia;
        private ColumnHeader colTipoBulto;
        private Button btnConfirmarRecepcion;
        private Button btnCancelar;
        private ComboBox cmboIDServicio;
        private ColumnHeader colNroHDR;
        private ColumnHeader colCDOrigen;
        private DateTimePicker dateTimeFechaDespacho;
        private Label lblFechaDespacho;
    }
}
