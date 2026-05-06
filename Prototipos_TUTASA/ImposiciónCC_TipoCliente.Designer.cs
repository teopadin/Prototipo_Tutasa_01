namespace Prototipos_TUTASA
{
    partial class ImposiciónCC_TipoCliente
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
            pnlEmpresa = new Panel();
            lblEmpresaTitulo = new Label();
            lblEmpresaDesc = new Label();
            pnlParticular = new Panel();
            lblParticularTitulo = new Label();
            lblParticularDesc = new Label();
            lblInstruccion = new Label();
            pnlSeparador = new Panel();
            pnlEmpresa.SuspendLayout();
            pnlParticular.SuspendLayout();
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
            lblFecha.Location = new Point(520, 32);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.FromArgb(30, 30, 30);
            lblFechaValor.Location = new Point(568, 32);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(145, 20);
            lblFechaValor.TabIndex = 2;
            lblFechaValor.Text = "06/05/2026";
            // 
            // pnlEmpresa
            // 
            pnlEmpresa.BackColor = Color.White;
            pnlEmpresa.BorderStyle = BorderStyle.FixedSingle;
            pnlEmpresa.Controls.Add(lblEmpresaTitulo);
            pnlEmpresa.Controls.Add(lblEmpresaDesc);
            pnlEmpresa.Cursor = Cursors.Hand;
            pnlEmpresa.Location = new Point(60, 170);
            pnlEmpresa.Name = "pnlEmpresa";
            pnlEmpresa.Size = new Size(245, 160);
            pnlEmpresa.TabIndex = 6;
            // 
            // lblEmpresaTitulo
            // 
            lblEmpresaTitulo.Font = new Font("Segoe UI", 12F);
            lblEmpresaTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblEmpresaTitulo.Location = new Point(15, 45);
            lblEmpresaTitulo.Name = "lblEmpresaTitulo";
            lblEmpresaTitulo.Size = new Size(210, 28);
            lblEmpresaTitulo.TabIndex = 0;
            lblEmpresaTitulo.Text = "Empresa / Agencia";
            lblEmpresaTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpresaDesc
            // 
            lblEmpresaDesc.Font = new Font("Segoe UI", 9F);
            lblEmpresaDesc.ForeColor = Color.Gray;
            lblEmpresaDesc.Location = new Point(15, 85);
            lblEmpresaDesc.Name = "lblEmpresaDesc";
            lblEmpresaDesc.Size = new Size(210, 45);
            lblEmpresaDesc.TabIndex = 1;
            lblEmpresaDesc.Text = "Clientes corporativos\ncon convenio vigente";
            lblEmpresaDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlParticular
            // 
            pnlParticular.BackColor = Color.White;
            pnlParticular.BorderStyle = BorderStyle.FixedSingle;
            pnlParticular.Controls.Add(lblParticularTitulo);
            pnlParticular.Controls.Add(lblParticularDesc);
            pnlParticular.Cursor = Cursors.Hand;
            pnlParticular.Location = new Point(380, 170);
            pnlParticular.Name = "pnlParticular";
            pnlParticular.Size = new Size(245, 160);
            pnlParticular.TabIndex = 7;
            // 
            // lblParticularTitulo
            // 
            lblParticularTitulo.Font = new Font("Segoe UI", 12F);
            lblParticularTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblParticularTitulo.Location = new Point(15, 45);
            lblParticularTitulo.Name = "lblParticularTitulo";
            lblParticularTitulo.Size = new Size(210, 28);
            lblParticularTitulo.TabIndex = 0;
            lblParticularTitulo.Text = "Particular";
            lblParticularTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblParticularDesc
            // 
            lblParticularDesc.Font = new Font("Segoe UI", 9F);
            lblParticularDesc.ForeColor = Color.Gray;
            lblParticularDesc.Location = new Point(15, 85);
            lblParticularDesc.Name = "lblParticularDesc";
            lblParticularDesc.Size = new Size(210, 45);
            lblParticularDesc.TabIndex = 1;
            lblParticularDesc.Text = "Personas físicas\nsin convenio corporativo";
            lblParticularDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 11F);
            lblInstruccion.ForeColor = Color.FromArgb(60, 60, 60);
            lblInstruccion.Location = new Point(30, 115);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(400, 25);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Seleccione el tipo de cliente para continuar";
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.FromArgb(220, 220, 220);
            pnlSeparador.Location = new Point(30, 68);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(630, 1);
            pnlSeparador.TabIndex = 3;
            // 
            // ImposiciónCC_TipoCliente
            // 
            BackColor = Color.White;
            ClientSize = new Size(811, 424);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(pnlSeparador);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblInstruccion);
            Controls.Add(pnlEmpresa);
            Controls.Add(pnlParticular);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImposiciónCC_TipoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imposición - Selección de cliente";
            pnlEmpresa.ResumeLayout(false);
            pnlParticular.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Label lblEmpresaTitulo;
        private System.Windows.Forms.Label lblEmpresaDesc;
        private System.Windows.Forms.Panel pnlParticular;
        private System.Windows.Forms.Label lblParticularTitulo;
        private System.Windows.Forms.Label lblParticularDesc;
        private System.Windows.Forms.Panel pnlSeparador;
    }
}