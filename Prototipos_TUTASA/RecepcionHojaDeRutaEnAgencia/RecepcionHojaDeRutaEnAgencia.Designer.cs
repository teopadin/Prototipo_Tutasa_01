using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
// removed conflicting static import for MediaTypeNames to avoid symbol ambiguity

namespace Prototipos_TUTASA.RecepcionHojaDeRutaEnAgencia
{
    partial class RecepcionHojaDeRutaEnAgencia
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
            lblNumeroHdr = new Label();
            txtNumeroHdr = new TextBox();
            btnBuscar = new Button();
            lblFechaRecepcion = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblAgencia = new Label();
            txtAgencia = new TextBox();
            groupBox1 = new GroupBox();
            txtTipoMovimiento = new TextBox();
            lblTipoMovimiento = new Label();
            txtEstadoHdr = new TextBox();
            lblEstadoHdr = new Label();
            txtFletero = new TextBox();
            lblFletero = new Label();
            lblGuiasIncluidas = new Label();
            lvGuias = new ListView();
            colNumeroGuia = new ColumnHeader();
            colRemitente = new ColumnHeader();
            colDestinatario = new ColumnHeader();
            colTipoBulto = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblTotalGuias = new Label();
            txtTotalGuias = new TextBox();
            btnConfirmarRecepcion = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(42, 31);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(756, 59);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepción de Hoja de Ruta en Agencia";
            // 
            // lblNumeroHdr
            // 
            lblNumeroHdr.AutoSize = true;
            lblNumeroHdr.Location = new Point(42, 154);
            lblNumeroHdr.Margin = new Padding(6, 0, 6, 0);
            lblNumeroHdr.Name = "lblNumeroHdr";
            lblNumeroHdr.Size = new Size(293, 41);
            lblNumeroHdr.TabIndex = 1;
            lblNumeroHdr.Text = "Nro HDR / Hoja Ruta";
            // 
            // txtNumeroHdr
            // 
            txtNumeroHdr.Location = new Point(382, 148);
            txtNumeroHdr.Margin = new Padding(6);
            txtNumeroHdr.Name = "txtNumeroHdr";
            txtNumeroHdr.Size = new Size(463, 47);
            txtNumeroHdr.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(892, 144);
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
            lblFechaRecepcion.Location = new Point(1190, 156);
            lblFechaRecepcion.Margin = new Padding(6, 0, 6, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(233, 41);
            lblFechaRecepcion.TabIndex = 4;
            lblFechaRecepcion.Text = "Fecha recepción";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(1466, 148);
            dtpFechaRecepcion.Margin = new Padding(6);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(293, 47);
            dtpFechaRecepcion.TabIndex = 5;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(42, 246);
            lblAgencia.Margin = new Padding(6, 0, 6, 0);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(124, 41);
            lblAgencia.TabIndex = 6;
            lblAgencia.Text = "Agencia";
            // 
            // txtAgencia
            // 
            txtAgencia.Location = new Point(382, 240);
            txtAgencia.Margin = new Padding(6);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.ReadOnly = true;
            txtAgencia.Size = new Size(527, 47);
            txtAgencia.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTipoMovimiento);
            groupBox1.Controls.Add(lblTipoMovimiento);
            groupBox1.Controls.Add(txtEstadoHdr);
            groupBox1.Controls.Add(lblEstadoHdr);
            groupBox1.Controls.Add(txtFletero);
            groupBox1.Controls.Add(lblFletero);
            groupBox1.Location = new Point(42, 338);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1721, 215);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Hoja de Ruta";
            // 
            // txtTipoMovimiento
            // 
            txtTipoMovimiento.Location = new Point(1190, 102);
            txtTipoMovimiento.Margin = new Padding(6);
            txtTipoMovimiento.Name = "txtTipoMovimiento";
            txtTipoMovimiento.ReadOnly = true;
            txtTipoMovimiento.Size = new Size(378, 47);
            txtTipoMovimiento.TabIndex = 5;
            // 
            // lblTipoMovimiento
            // 
            lblTipoMovimiento.AutoSize = true;
            lblTipoMovimiento.Location = new Point(1190, 55);
            lblTipoMovimiento.Margin = new Padding(6, 0, 6, 0);
            lblTipoMovimiento.Name = "lblTipoMovimiento";
            lblTipoMovimiento.Size = new Size(531, 41);
            lblTipoMovimiento.TabIndex = 4;
            lblTipoMovimiento.Text = "Tipo movimiento (retiro o distribucion)";
            // 
            // txtEstadoHdr
            // 
            txtEstadoHdr.Location = new Point(638, 102);
            txtEstadoHdr.Margin = new Padding(6);
            txtEstadoHdr.Name = "txtEstadoHdr";
            txtEstadoHdr.ReadOnly = true;
            txtEstadoHdr.Size = new Size(378, 47);
            txtEstadoHdr.TabIndex = 3;
            // 
            // lblEstadoHdr
            // 
            lblEstadoHdr.AutoSize = true;
            lblEstadoHdr.Location = new Point(638, 55);
            lblEstadoHdr.Margin = new Padding(6, 0, 6, 0);
            lblEstadoHdr.Name = "lblEstadoHdr";
            lblEstadoHdr.Size = new Size(175, 41);
            lblEstadoHdr.TabIndex = 2;
            lblEstadoHdr.Text = "Estado HDR";
            // 
            // txtFletero
            // 
            txtFletero.Location = new Point(42, 102);
            txtFletero.Margin = new Padding(6);
            txtFletero.Name = "txtFletero";
            txtFletero.ReadOnly = true;
            txtFletero.Size = new Size(463, 47);
            txtFletero.TabIndex = 1;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(42, 55);
            lblFletero.Margin = new Padding(6, 0, 6, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(110, 41);
            lblFletero.TabIndex = 0;
            lblFletero.Text = "Fletero";
            // 
            // lblGuiasIncluidas
            // 
            lblGuiasIncluidas.AutoSize = true;
            lblGuiasIncluidas.Location = new Point(42, 594);
            lblGuiasIncluidas.Margin = new Padding(6, 0, 6, 0);
            lblGuiasIncluidas.Name = "lblGuiasIncluidas";
            lblGuiasIncluidas.Size = new Size(353, 41);
            lblGuiasIncluidas.TabIndex = 11;
            lblGuiasIncluidas.Text = "Guías incluidas en la HDR";
            // 
            // lvGuias
            // 
            lvGuias.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colRemitente, colDestinatario, colTipoBulto, colEstado });
            lvGuias.FullRowSelect = true;
            lvGuias.Location = new Point(42, 646);
            lvGuias.Margin = new Padding(6);
            lvGuias.Name = "lvGuias";
            lvGuias.Size = new Size(2248, 508);
            lvGuias.TabIndex = 12;
            lvGuias.UseCompatibleStateImageBehavior = false;
            lvGuias.View = View.Details;
            lvGuias.SelectedIndexChanged += lvGuias_SelectedIndexChanged;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guía";
            colNumeroGuia.Width = 120;
            // 
            // colRemitente
            // 
            colRemitente.Text = "Remitente";
            colRemitente.Width = 180;
            // 
            // colDestinatario
            // 
            colDestinatario.Text = "Destinatario";
            colDestinatario.Width = 180;
            // 
            // colTipoBulto
            // 
            colTipoBulto.Text = "Tipo Bulto";
            colTipoBulto.Width = 120;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 120;
            // 
            // lblTotalGuias
            // 
            lblTotalGuias.AutoSize = true;
            lblTotalGuias.Location = new Point(42, 1199);
            lblTotalGuias.Margin = new Padding(6, 0, 6, 0);
            lblTotalGuias.Name = "lblTotalGuias";
            lblTotalGuias.Size = new Size(201, 41);
            lblTotalGuias.TabIndex = 13;
            lblTotalGuias.Text = "Total de guías";
            // 
            // txtTotalGuias
            // 
            txtTotalGuias.Location = new Point(276, 1193);
            txtTotalGuias.Margin = new Padding(6);
            txtTotalGuias.Name = "txtTotalGuias";
            txtTotalGuias.ReadOnly = true;
            txtTotalGuias.Size = new Size(208, 47);
            txtTotalGuias.TabIndex = 14;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(1742, 1312);
            btnConfirmarRecepcion.Margin = new Padding(6);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(319, 86);
            btnConfirmarRecepcion.TabIndex = 15;
            btnConfirmarRecepcion.Text = "Confirmar Recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(2104, 1312);
            btnCancelar.Margin = new Padding(6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(191, 86);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // RecepcionHojaDeRutaEnAgencia
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2348, 1456);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarRecepcion);
            Controls.Add(txtTotalGuias);
            Controls.Add(lblTotalGuias);
            Controls.Add(lvGuias);
            Controls.Add(lblGuiasIncluidas);
            Controls.Add(groupBox1);
            Controls.Add(txtAgencia);
            Controls.Add(lblAgencia);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroHdr);
            Controls.Add(lblNumeroHdr);
            Controls.Add(lblTitulo);
            Margin = new Padding(6);
            Name = "RecepcionHojaDeRutaEnAgencia";
            Text = "Recepción de Hoja de Ruta en Agencia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblNumeroHdr;
        private TextBox txtNumeroHdr;
        private Button btnBuscar;
        private Label lblFechaRecepcion;
        private DateTimePicker dtpFechaRecepcion;
        private Label lblAgencia;
        private TextBox txtAgencia;
        private GroupBox groupBox1;
        private TextBox txtTipoMovimiento;
        private Label lblTipoMovimiento;
        private TextBox txtEstadoHdr;
        private Label lblEstadoHdr;
        private TextBox txtFletero;
        private Label lblFletero;
        private Label lblGuiasIncluidas;
        private ListView lvGuias;
        private ColumnHeader colNumeroGuia;
        private ColumnHeader colRemitente;
        private ColumnHeader colDestinatario;
        private ColumnHeader colTipoBulto;
        private ColumnHeader colEstado;
        private Label lblTotalGuias;
        private TextBox txtTotalGuias;
        private Button btnConfirmarRecepcion;
        private Button btnCancelar;
    }
}
