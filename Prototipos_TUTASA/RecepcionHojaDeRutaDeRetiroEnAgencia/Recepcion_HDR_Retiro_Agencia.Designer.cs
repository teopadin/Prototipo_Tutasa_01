using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    partial class Recepcion_HDR_Retiro_Agencia
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNroHDR = new Label();
            txtNroHDR = new TextBox();
            btnBuscar = new Button();
            lblFechaRecepcion = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblAgencia = new Label();
            txtAgencia = new TextBox();
            lblFletero = new Label();
            txtFletero = new TextBox();
            lblGuias = new Label();
            lblTotalGuias = new Label();
            txtTotalGuias = new TextBox();
            btnConfirmarRecepcion = new Button();
            btnCancelar = new Button();
            listViewGuiasRetiradas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // lblNroHDR
            // 
            lblNroHDR.AutoSize = true;
            lblNroHDR.Location = new Point(29, 33);
            lblNroHDR.Margin = new Padding(4, 0, 4, 0);
            lblNroHDR.Name = "lblNroHDR";
            lblNroHDR.Size = new Size(154, 25);
            lblNroHDR.TabIndex = 0;
            lblNroHDR.Text = "Nro Hoja de Ruta:";
            // 
            // txtNroHDR
            // 
            txtNroHDR.Location = new Point(214, 28);
            txtNroHDR.Margin = new Padding(4, 5, 4, 5);
            txtNroHDR.Name = "txtNroHDR";
            txtNroHDR.Size = new Size(213, 31);
            txtNroHDR.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(443, 25);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 45);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(29, 92);
            lblFechaRecepcion.Margin = new Padding(4, 0, 4, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(142, 25);
            lblFechaRecepcion.TabIndex = 3;
            lblFechaRecepcion.Text = "Fecha recepción:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Enabled = false;
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(214, 87);
            dtpFechaRecepcion.Margin = new Padding(4, 5, 4, 5);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(284, 31);
            dtpFechaRecepcion.TabIndex = 4;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(29, 150);
            lblAgencia.Margin = new Padding(4, 0, 4, 0);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(79, 25);
            lblAgencia.TabIndex = 5;
            lblAgencia.Text = "Agencia:";
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = SystemColors.Control;
            txtAgencia.Location = new Point(214, 145);
            txtAgencia.Margin = new Padding(4, 5, 4, 5);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.ReadOnly = true;
            txtAgencia.Size = new Size(284, 31);
            txtAgencia.TabIndex = 6;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(29, 208);
            lblFletero.Margin = new Padding(4, 0, 4, 0);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(162, 25);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Transportista Local:";
            // 
            // txtFletero
            // 
            txtFletero.BackColor = SystemColors.Control;
            txtFletero.Location = new Point(214, 203);
            txtFletero.Margin = new Padding(4, 5, 4, 5);
            txtFletero.Name = "txtFletero";
            txtFletero.ReadOnly = true;
            txtFletero.Size = new Size(284, 31);
            txtFletero.TabIndex = 8;
            // 
            // lblGuias
            // 
            lblGuias.AutoSize = true;
            lblGuias.Location = new Point(23, 267);
            lblGuias.Margin = new Padding(4, 0, 4, 0);
            lblGuias.Name = "lblGuias";
            lblGuias.Size = new Size(216, 25);
            lblGuias.TabIndex = 11;
            lblGuias.Text = "Guías incluidas en la HDR:";
            // 
            // lblTotalGuias
            // 
            lblTotalGuias.AutoSize = true;
            lblTotalGuias.Location = new Point(29, 623);
            lblTotalGuias.Margin = new Padding(4, 0, 4, 0);
            lblTotalGuias.Name = "lblTotalGuias";
            lblTotalGuias.Size = new Size(125, 25);
            lblTotalGuias.TabIndex = 12;
            lblTotalGuias.Text = "Total de guías:";
            // 
            // txtTotalGuias
            // 
            txtTotalGuias.BackColor = SystemColors.Control;
            txtTotalGuias.Location = new Point(214, 618);
            txtTotalGuias.Margin = new Padding(4, 5, 4, 5);
            txtTotalGuias.Name = "txtTotalGuias";
            txtTotalGuias.ReadOnly = true;
            txtTotalGuias.Size = new Size(113, 31);
            txtTotalGuias.TabIndex = 13;
            txtTotalGuias.TextAlign = HorizontalAlignment.Right;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(214, 690);
            btnConfirmarRecepcion.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(214, 58);
            btnConfirmarRecepcion.TabIndex = 14;
            btnConfirmarRecepcion.Text = "Confirmar Recepción";
            btnConfirmarRecepcion.Click += btnConfirmarRecepcion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(450, 690);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 58);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // listViewGuiasRetiradas
            // 
            listViewGuiasRetiradas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewGuiasRetiradas.Location = new Point(29, 305);
            listViewGuiasRetiradas.Margin = new Padding(1, 2, 1, 2);
            listViewGuiasRetiradas.Name = "listViewGuiasRetiradas";
            listViewGuiasRetiradas.Size = new Size(604, 291);
            listViewGuiasRetiradas.TabIndex = 16;
            listViewGuiasRetiradas.UseCompatibleStateImageBehavior = false;
            listViewGuiasRetiradas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro de guia";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de bulto";
            columnHeader2.Width = 200;
            // 
            // Recepcion_HDR_Retiro_Agencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 810);
            Controls.Add(listViewGuiasRetiradas);
            Controls.Add(lblNroHDR);
            Controls.Add(txtNroHDR);
            Controls.Add(btnBuscar);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblAgencia);
            Controls.Add(txtAgencia);
            Controls.Add(lblFletero);
            Controls.Add(txtFletero);
            Controls.Add(lblGuias);
            Controls.Add(lblTotalGuias);
            Controls.Add(txtTotalGuias);
            Controls.Add(btnConfirmarRecepcion);
            Controls.Add(btnCancelar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Recepcion_HDR_Retiro_Agencia";
            Text = "Recepción HDR Retiro en Agencia";
            Load += Recepcion_HDR_Retiro_Agencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNroHDR;
        private System.Windows.Forms.TextBox txtNroHDR;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblFletero;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Label lblGuias;
        private System.Windows.Forms.Label lblTotalGuias;
        private System.Windows.Forms.TextBox txtTotalGuias;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnCancelar;
        private ListView listViewGuiasRetiradas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}