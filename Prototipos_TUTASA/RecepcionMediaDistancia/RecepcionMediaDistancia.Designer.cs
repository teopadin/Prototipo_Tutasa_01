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
            lblFechaRecepcion = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblEmpresaTransporte = new Label();
            txtEmpresaTransporte = new TextBox();
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
            comboBox1 = new ComboBox();
            colNroHDR = new ColumnHeader();
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
            lblNumeroHojaRuta.Click += lblNumeroHojaRuta_Click;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(569, 94);
            lblFechaRecepcion.Margin = new Padding(4, 0, 4, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(138, 25);
            lblFechaRecepcion.TabIndex = 4;
            lblFechaRecepcion.Text = "Fecha recepción";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(722, 94);
            dtpFechaRecepcion.Margin = new Padding(4);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(174, 31);
            dtpFechaRecepcion.TabIndex = 5;
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
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(25, 212);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(200, 208);
            txtEstado.Margin = new Padding(4);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(224, 31);
            txtEstado.TabIndex = 13;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(25, 268);
            lblOrigen.Margin = new Padding(4, 0, 4, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(66, 25);
            lblOrigen.TabIndex = 14;
            lblOrigen.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(200, 265);
            txtOrigen.Margin = new Padding(4);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.ReadOnly = true;
            txtOrigen.Size = new Size(224, 31);
            txtOrigen.TabIndex = 15;
            // 
            // lblCantidadGuias
            // 
            lblCantidadGuias.AutoSize = true;
            lblCantidadGuias.Location = new Point(585, 268);
            lblCantidadGuias.Margin = new Padding(4, 0, 4, 0);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(155, 25);
            lblCantidadGuias.TabIndex = 18;
            lblCantidadGuias.Text = "Cantidad de guías";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(772, 265);
            txtCantidadGuias.Margin = new Padding(4);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(124, 31);
            txtCantidadGuias.TabIndex = 19;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(25, 330);
            lblGuiasIncluidas.Margin = new Padding(4, 0, 4, 0);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(55, 25);
            lblGuiasIncluidas.TabIndex = 20;
            lblGuiasIncluidas.Text = "Guías";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colTipoBulto, colNroHDR });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(25, 362);
            lvGuias.Margin = new Padding(4);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(1199, 311);
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
            btnConfirmarRecepcion.Location = new Point(950, 712);
            btnConfirmarRecepcion.Margin = new Padding(4);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(188, 52);
            btnConfirmarRecepcion.TabIndex = 22;
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1162, 712);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 52);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(335, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 33);
            comboBox1.TabIndex = 24;
            // 
            // colNroHDR
            // 
            colNroHDR.Text = "Nro HDR a la que pertenece";
            colNroHDR.Width = 250;
            // 
            // RecepcionMediaDistancia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 797);
            Controls.Add(comboBox1);
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
            Controls.Add(txtEmpresaTransporte);
            Controls.Add(lblEmpresaTransporte);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(lblNumeroHojaRuta);
            Controls.Add(lblTitulo);
            Margin = new Padding(4);
            Name = "RecepcionMediaDistancia";
            Text = "Recepción de hoja de ruta de media distancia";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblNumeroHojaRuta;
        private Label lblFechaRecepcion;
        private DateTimePicker dtpFechaRecepcion;
        private Label lblEmpresaTransporte;
        private TextBox txtEmpresaTransporte;
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
        private ComboBox comboBox1;
        private ColumnHeader colNroHDR;
    }
}
