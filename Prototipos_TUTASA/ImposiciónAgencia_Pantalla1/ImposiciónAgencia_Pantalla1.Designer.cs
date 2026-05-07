namespace Prototipos_TUTASA
{
    partial class ImposiciónAgencia_Pantalla1
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
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            SeleccionTipoCliente_RadioButton = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            lblTitulo = new Label();
            lblFecha = new Label();
            lblFechaValor = new Label();
            lblSubtitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(SeleccionTipoCliente_RadioButton);
            groupBox1.Location = new Point(12, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 116);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el tipo de cliente:";
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
            // button2
            // 
            button2.Location = new Point(476, 267);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(612, 267);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 17;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(12, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 41);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Imposición en Agencia";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(510, 40);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 33);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(579, 40);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(145, 23);
            lblFechaValor.TabIndex = 15;
            lblFechaValor.Text = "dd/mm/aaaa";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(12, 85);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(200, 20);
            lblSubtitulo.TabIndex = 16;
            lblSubtitulo.Text = "Paso 1 de 2";
            // 
            // ImposiciónAgencia_Pantalla1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 368);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(lblSubtitulo);
            Name = "ImposiciónAgencia_Pantalla1";
            Text = "ImposiciónAgencia_Pantalla1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton SeleccionTipoCliente_RadioButton;
        private Button button2;
        private Button button1;
        private Label lblTitulo;
        private Label lblFecha;
        private Label lblFechaValor;
        private Label lblSubtitulo;
    }
}