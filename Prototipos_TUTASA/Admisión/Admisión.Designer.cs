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
            btnGenerar = new Button();
            button1 = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.FlatStyle = FlatStyle.System;
            btnGenerar.Location = new Point(379, 404);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(196, 34);
            btnGenerar.TabIndex = 31;
            btnGenerar.Text = "Confirmar Admisión";
            // 
            // button1
            // 
            button1.Location = new Point(600, 404);
            button1.Name = "button1";
            button1.Size = new Size(188, 34);
            button1.TabIndex = 37;
            button1.Text = "Rechazar Admisión";
            button1.UseVisualStyleBackColor = true;
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
            lblTitulo.Location = new Point(12, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 41);
            lblTitulo.TabIndex = 39;
            lblTitulo.Text = "Admisión";
            // 
            // Admisión
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnGenerar);
            Name = "Admisión";
            Text = "Admisión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button button1;
        private Label label1;
        private Label lblTitulo;
    }
}