using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaEnAgencia
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
            lblNroHDR.Location = new Point(20, 20);
            lblNroHDR.Name = "lblNroHDR";
            lblNroHDR.Size = new Size(101, 15);
            lblNroHDR.TabIndex = 0;
            lblNroHDR.Text = "Nro Hoja de Ruta:";
            // 
            // txtNroHDR
            // 
            txtNroHDR.Location = new Point(150, 17);
            txtNroHDR.Name = "txtNroHDR";
            txtNroHDR.Size = new Size(150, 23);
            txtNroHDR.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(310, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(20, 55);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(96, 15);
            lblFechaRecepcion.TabIndex = 3;
            lblFechaRecepcion.Text = "Fecha recepción:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Enabled = false;
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(150, 52);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(200, 23);
            dtpFechaRecepcion.TabIndex = 4;
            // 
            // lblAgencia
            // 
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(20, 90);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(53, 15);
            lblAgencia.TabIndex = 5;
            lblAgencia.Text = "Agencia:";
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = SystemColors.Control;
            txtAgencia.Location = new Point(150, 87);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.ReadOnly = true;
            txtAgencia.Size = new Size(200, 23);
            txtAgencia.TabIndex = 6;
            // 
            // lblFletero
            // 
            lblFletero.AutoSize = true;
            lblFletero.Location = new Point(20, 125);
            lblFletero.Name = "lblFletero";
            lblFletero.Size = new Size(46, 15);
            lblFletero.TabIndex = 7;
            lblFletero.Text = "Fletero:";
            // 
            // txtFletero
            // 
            txtFletero.BackColor = SystemColors.Control;
            txtFletero.Location = new Point(150, 122);
            txtFletero.Name = "txtFletero";
            txtFletero.ReadOnly = true;
            txtFletero.Size = new Size(200, 23);
            txtFletero.TabIndex = 8;
            // 
            // lblGuias
            // 
            lblGuias.AutoSize = true;
            lblGuias.Location = new Point(16, 160);
            lblGuias.Name = "lblGuias";
            lblGuias.Size = new Size(144, 15);
            lblGuias.TabIndex = 11;
            lblGuias.Text = "Guías incluidas en la HDR:";
            // 
            // lblTotalGuias
            // 
            lblTotalGuias.AutoSize = true;
            lblTotalGuias.Location = new Point(20, 374);
            lblTotalGuias.Name = "lblTotalGuias";
            lblTotalGuias.Size = new Size(83, 15);
            lblTotalGuias.TabIndex = 12;
            lblTotalGuias.Text = "Total de guías:";
            // 
            // txtTotalGuias
            // 
            txtTotalGuias.BackColor = SystemColors.Control;
            txtTotalGuias.Location = new Point(150, 371);
            txtTotalGuias.Name = "txtTotalGuias";
            txtTotalGuias.ReadOnly = true;
            txtTotalGuias.Size = new Size(80, 23);
            txtTotalGuias.TabIndex = 13;
            txtTotalGuias.TextAlign = HorizontalAlignment.Right;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(150, 414);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(150, 35);
            btnConfirmarRecepcion.TabIndex = 14;
            btnConfirmarRecepcion.Text = "Confirmar Recepción";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(315, 414);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            // 
            // listViewGuiasRetiradas
            // 
            listViewGuiasRetiradas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewGuiasRetiradas.Location = new Point(20, 183);
            listViewGuiasRetiradas.Margin = new Padding(1);
            listViewGuiasRetiradas.Name = "listViewGuiasRetiradas";
            listViewGuiasRetiradas.Size = new Size(424, 176);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 486);
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