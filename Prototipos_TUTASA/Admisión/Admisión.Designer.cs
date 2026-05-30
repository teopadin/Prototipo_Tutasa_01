namespace Prototipos_TUTASA.Admisión
{
    partial class Admisión
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmar = new Button();
            btnRechazar = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            txtNroGuia = new TextBox();
            label3 = new Label();
            dtpFechaAdmision = new DateTimePicker();
            label5 = new Label();
            txtCliente = new TextBox();
            txtDestinatario = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtTipoBulto = new TextBox();
            label8 = new Label();
            txtCDDestino = new TextBox();
            label9 = new Label();
            txtTipoEntrega = new TextBox();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.System;
            btnConfirmar.Location = new Point(116, 500);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(196, 34);
            btnConfirmar.TabIndex = 31;
            btnConfirmar.Text = "Confirmar Admisión";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(318, 500);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(188, 34);
            btnRechazar.TabIndex = 37;
            btnRechazar.Text = "Rechazar Admisión";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 63);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 38;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 41);
            lblTitulo.TabIndex = 39;
            lblTitulo.Text = "Admisión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 40;
            label2.Text = "Nro de Guía:";
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Location = new Point(538, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 40);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNroGuia
            // 
            txtNroGuia.Location = new Point(177, 73);
            txtNroGuia.Name = "txtNroGuia";
            txtNroGuia.Size = new Size(334, 31);
            txtNroGuia.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 43;
            label3.Text = "Fecha Admisión:";
            // 
            // dtpFechaAdmision
            // 
            dtpFechaAdmision.Enabled = false;
            dtpFechaAdmision.Location = new Point(177, 126);
            dtpFechaAdmision.Name = "dtpFechaAdmision";
            dtpFechaAdmision.Size = new Size(334, 31);
            dtpFechaAdmision.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 39);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 47;
            label5.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(183, 39);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(334, 31);
            txtCliente.TabIndex = 48;
            // 
            // txtDestinatario
            // 
            txtDestinatario.Enabled = false;
            txtDestinatario.Location = new Point(183, 129);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.ReadOnly = true;
            txtDestinatario.Size = new Size(334, 31);
            txtDestinatario.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 132);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 50;
            label6.Text = "Destinatario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 185);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 51;
            label7.Text = "Tipo de Bulto:";
            // 
            // txtTipoBulto
            // 
            txtTipoBulto.Enabled = false;
            txtTipoBulto.Location = new Point(183, 179);
            txtTipoBulto.Name = "txtTipoBulto";
            txtTipoBulto.ReadOnly = true;
            txtTipoBulto.Size = new Size(334, 31);
            txtTipoBulto.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 89);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 53;
            label8.Text = "CD Destino:";
            // 
            // txtCDDestino
            // 
            txtCDDestino.Enabled = false;
            txtCDDestino.Location = new Point(183, 86);
            txtCDDestino.Name = "txtCDDestino";
            txtCDDestino.ReadOnly = true;
            txtCDDestino.Size = new Size(334, 31);
            txtCDDestino.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 234);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 55;
            label9.Text = "Tipo de Entrega:";
            // 
            // txtTipoEntrega
            // 
            txtTipoEntrega.Enabled = false;
            txtTipoEntrega.Location = new Point(183, 231);
            txtTipoEntrega.Name = "txtTipoEntrega";
            txtTipoEntrega.ReadOnly = true;
            txtTipoEntrega.Size = new Size(334, 31);
            txtTipoEntrega.TabIndex = 56;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTipoEntrega);
            groupBox1.Controls.Add(txtCDDestino);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(txtTipoBulto);
            groupBox1.Controls.Add(txtDestinatario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 287);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Guía";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(512, 500);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 34);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Admisión
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 572);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(dtpFechaAdmision);
            Controls.Add(label3);
            Controls.Add(txtNroGuia);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(btnRechazar);
            Controls.Add(btnConfirmar);
            Name = "Admisión";
            Text = "Admisión";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button button1;
        private Label label1;
        private Label lblTitulo;
        private Label label2;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox7;
        private GroupBox groupBox1;
        private Button button3;
        private Button btnConfirmar;
        private Button btnRechazar;
        private Button btnBuscar;
        private TextBox txtNroGuia;
        private DateTimePicker dtpFechaAdmision;
        private TextBox txtCliente;
        private TextBox txtDestinatario;
        private TextBox txtTipoBulto;
        private TextBox txtCDDestino;
        private TextBox txtTipoEntrega;
        private Button btnCancelar;
    }
}