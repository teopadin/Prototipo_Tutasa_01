namespace Prototipos_TUTASA
{
    partial class ImposiciónCD_Pantalla1
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
            groupBox1.Location = new Point(8, 67);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(280, 70);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el tipo de cliente:";
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(104, 18);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 46);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Particular";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // SeleccionTipoCliente_RadioButton
            // 
            SeleccionTipoCliente_RadioButton.Location = new Point(8, 18);
            SeleccionTipoCliente_RadioButton.Margin = new Padding(2, 2, 2, 2);
            SeleccionTipoCliente_RadioButton.Name = "SeleccionTipoCliente_RadioButton";
            SeleccionTipoCliente_RadioButton.Size = new Size(81, 46);
            SeleccionTipoCliente_RadioButton.TabIndex = 8;
            SeleccionTipoCliente_RadioButton.TabStop = true;
            SeleccionTipoCliente_RadioButton.Text = "Empresa";
            SeleccionTipoCliente_RadioButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(333, 151);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 25;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(428, 151);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 24;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(16, 5);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 37);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Imposición en CD";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(333, 13);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(116, 20);
            lblFecha.TabIndex = 21;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(428, 15);
            lblFechaValor.Margin = new Padding(2, 0, 2, 0);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(98, 14);
            lblFechaValor.TabIndex = 22;
            lblFechaValor.Text = "dd/mm/aaaa";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(8, 42);
            lblSubtitulo.Margin = new Padding(2, 0, 2, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(140, 12);
            lblSubtitulo.TabIndex = 23;
            lblSubtitulo.Text = "Paso 1 de 2";
            // 
            // ImposiciónCD_Pantalla1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 196);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(lblSubtitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ImposiciónCD_Pantalla1";
            Text = "ImposiciónCD_Pantalla1";
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