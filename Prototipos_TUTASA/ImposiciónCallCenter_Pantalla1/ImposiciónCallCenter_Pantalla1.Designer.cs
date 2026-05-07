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
            SeleccionTipoCliente_RadioButton = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
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
            lblFecha.Location = new Point(585, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 33);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(654, 35);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(145, 23);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "dd/mm/aaaa";
            // 
            // SeleccionTipoCliente_RadioButton
            // 
            SeleccionTipoCliente_RadioButton.Location = new Point(11, 30);
            SeleccionTipoCliente_RadioButton.Name = "SeleccionTipoCliente_RadioButton";
            SeleccionTipoCliente_RadioButton.Size = new Size(116, 77);
            SeleccionTipoCliente_RadioButton.TabIndex = 8;
            SeleccionTipoCliente_RadioButton.TabStop = true;
            SeleccionTipoCliente_RadioButton.Text = "Empresa";
            SeleccionTipoCliente_RadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(149, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(125, 77);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Particular";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(672, 261);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(536, 261);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(SeleccionTipoCliente_RadioButton);
            groupBox1.Location = new Point(30, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 116);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el tipo de cliente:";
            // 
            // ImposiciónCallCenter_Pantalla1
            // 
            BackColor = Color.White;
            ClientSize = new Size(811, 323);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(lblSubtitulo);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCallCenter_Pantalla1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Selección de cliente";
            Load += this.ImposiciónCallCenter_Pantalla1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaValor;
        private RadioButton SeleccionTipoCliente_RadioButton;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
    }
}