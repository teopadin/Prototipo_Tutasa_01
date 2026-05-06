namespace Prototipos_TUTASA
{
    partial class ImposiciónCallCenter_Pantalla1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblFecha = new Label();
            lblFechaValor = new Label();
            lblInstruccion = new Label();
            pnlSeparador = new Panel();
            SeleccionTipoCliente_RadioButton = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(30, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Imposición en Call Center";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(30, 80);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(200, 20);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "Paso 1 de 3";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(508, 32);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 33);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(567, 32);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(145, 23);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "dd/mm/aaaa";
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 11F);
            lblInstruccion.ForeColor = Color.FromArgb(60, 60, 60);
            lblInstruccion.Location = new Point(30, 115);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(595, 35);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Seleccione el tipo de cliente:";
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.FromArgb(220, 220, 220);
            pnlSeparador.Location = new Point(30, 68);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(630, 1);
            pnlSeparador.TabIndex = 3;
            // 
            // SeleccionTipoCliente_RadioButton
            // 
            SeleccionTipoCliente_RadioButton.Location = new Point(30, 148);
            SeleccionTipoCliente_RadioButton.Name = "SeleccionTipoCliente_RadioButton";
            SeleccionTipoCliente_RadioButton.Size = new Size(116, 77);
            SeleccionTipoCliente_RadioButton.TabIndex = 8;
            SeleccionTipoCliente_RadioButton.TabStop = true;
            SeleccionTipoCliente_RadioButton.Text = "Empresa";
            SeleccionTipoCliente_RadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(168, 148);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(125, 77);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Particular";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(687, 221);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(548, 221);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            // 
            // ImposiciónCallCenter_Pantalla1
            // 
            BackColor = Color.White;
            ClientSize = new Size(811, 267);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Controls.Add(SeleccionTipoCliente_RadioButton);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(pnlSeparador);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblInstruccion);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCallCenter_Pantalla1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Selección de cliente";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Panel pnlSeparador;
        private RadioButton SeleccionTipoCliente_RadioButton;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
    }
}