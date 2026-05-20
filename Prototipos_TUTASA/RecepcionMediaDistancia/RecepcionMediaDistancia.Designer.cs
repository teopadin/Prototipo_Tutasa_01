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
            lblTitulo.Location = new Point(42, 31);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(882, 59);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepción de hoja de ruta de media distancia";
            // 
            // lblNumeroHojaRuta
            // 
            lblNumeroHojaRuta.AutoSize = true;
            lblNumeroHojaRuta.Location = new Point(42, 154);
            lblNumeroHojaRuta.Margin = new Padding(6, 0, 6, 0);
            lblNumeroHojaRuta.Name = "lblNumeroHojaRuta";
            lblNumeroHojaRuta.Size = new Size(235, 41);
            lblNumeroHojaRuta.TabIndex = 1;
            lblNumeroHojaRuta.Text = "Nro hoja de ruta";
            // 
            // txtNumeroHojaRuta
            // 
            txtNumeroHojaRuta.Location = new Point(340, 148);
            txtNumeroHojaRuta.Margin = new Padding(6);
            txtNumeroHojaRuta.Name = "txtNumeroHojaRuta";
            txtNumeroHojaRuta.Size = new Size(378, 47);
            txtNumeroHojaRuta.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(765, 144);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(234, 66);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(1084, 154);
            lblFechaRecepcion.Margin = new Padding(6, 0, 6, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(233, 41);
            lblFechaRecepcion.TabIndex = 4;
            lblFechaRecepcion.Text = "Fecha recepción";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(1360, 148);
            dtpFechaRecepcion.Margin = new Padding(6);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(293, 47);
            dtpFechaRecepcion.TabIndex = 5;
            // 
            // lblEmpresaTransporte
            // 
            lblEmpresaTransporte.AutoSize = true;
            lblEmpresaTransporte.Location = new Point(42, 255);
            lblEmpresaTransporte.Margin = new Padding(6, 0, 6, 0);
            lblEmpresaTransporte.Name = "lblEmpresaTransporte";
            lblEmpresaTransporte.Size = new Size(276, 41);
            lblEmpresaTransporte.TabIndex = 8;
            lblEmpresaTransporte.Text = "Empresa transporte";
            // 
            // txtEmpresaTransporte
            // 
            txtEmpresaTransporte.Location = new Point(382, 249);
            txtEmpresaTransporte.Margin = new Padding(6);
            txtEmpresaTransporte.Name = "txtEmpresaTransporte";
            txtEmpresaTransporte.ReadOnly = true;
            txtEmpresaTransporte.Size = new Size(527, 47);
            txtEmpresaTransporte.TabIndex = 9;
            // 
            // lblIdServicio
            // 
            lblIdServicio.AutoSize = true;
            lblIdServicio.Location = new Point(999, 255);
            lblIdServicio.Margin = new Padding(6, 0, 6, 0);
            lblIdServicio.Name = "lblIdServicio";
            lblIdServicio.Size = new Size(157, 41);
            lblIdServicio.TabIndex = 10;
            lblIdServicio.Text = "ID Servicio";
            // 
            // txtIdServicio
            // 
            txtIdServicio.Location = new Point(1211, 249);
            txtIdServicio.Margin = new Padding(6);
            txtIdServicio.Name = "txtIdServicio";
            txtIdServicio.ReadOnly = true;
            txtIdServicio.Size = new Size(378, 47);
            txtIdServicio.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(42, 347);
            lblEstado.Margin = new Padding(6, 0, 6, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(107, 41);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(340, 341);
            txtEstado.Margin = new Padding(6);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(378, 47);
            txtEstado.TabIndex = 13;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(42, 440);
            lblOrigen.Margin = new Padding(6, 0, 6, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(109, 41);
            lblOrigen.TabIndex = 14;
            lblOrigen.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(340, 434);
            txtOrigen.Margin = new Padding(6);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.ReadOnly = true;
            txtOrigen.Size = new Size(378, 47);
            txtOrigen.TabIndex = 15;
            // 
            // lblCantidadGuias
            // 
            lblCantidadGuias.AutoSize = true;
            lblCantidadGuias.Location = new Point(994, 440);
            lblCantidadGuias.Margin = new Padding(6, 0, 6, 0);
            lblCantidadGuias.Name = "lblCantidadGuias";
            lblCantidadGuias.Size = new Size(257, 41);
            lblCantidadGuias.TabIndex = 18;
            lblCantidadGuias.Text = "Cantidad de guías";
            // 
            // txtCantidadGuias
            // 
            txtCantidadGuias.Location = new Point(1312, 434);
            txtCantidadGuias.Margin = new Padding(6);
            txtCantidadGuias.Name = "txtCantidadGuias";
            txtCantidadGuias.ReadOnly = true;
            txtCantidadGuias.Size = new Size(208, 47);
            txtCantidadGuias.TabIndex = 19;
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(42, 542);
            lblGuiasIncluidas.Margin = new Padding(6, 0, 6, 0);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(91, 41);
            lblGuiasIncluidas.TabIndex = 20;
            lblGuiasIncluidas.Text = "Guías";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colTipoBulto });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(42, 593);
            lvGuias.Margin = new Padding(6);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(2036, 508);
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
            btnConfirmarRecepcion.Location = new Point(1615, 1167);
            btnConfirmarRecepcion.Margin = new Padding(6);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(319, 86);
            btnConfirmarRecepcion.TabIndex = 22;
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1976, 1167);
            btnCancelar.Margin = new Padding(6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(212, 86);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // RecepcionMediaDistancia
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2252, 1348);
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
            Margin = new Padding(6);
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
