namespace Prototipos_TUTASA
{
    partial class Menu
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
            lblTitulo = new Label();
            gbEntorno = new GroupBox();
            rbDesdeAgencia = new RadioButton();
            rbDesdeCD = new RadioButton();
            lblViaInicial = new Label();
            cboAgencia = new ComboBox();
            lblAgencia = new Label();
            cboCentroDistribucion = new ComboBox();
            lblCentroDistribucion = new Label();
            gbInicio = new GroupBox();
            btnImposicionCallCenter = new Button();
            btnImposicionAgencia = new Button();
            btnImposicionCD = new Button();
            gbRetiro = new GroupBox();
            btnRendirHDRRetiro = new Button();
            btnRecepcionHDRRetiro = new Button();
            btnResumenHDRRetiro = new Button();
            btnGenerarHDRRetiro = new Button();
            btnAdmision = new Button();
            gbDistribucion = new GroupBox();
            btnRendirHDRDistribucion = new Button();
            btnRecepcionHDRDistribucion = new Button();
            btnResumenHDRDistribucion = new Button();
            btnGenerarHDRDistribucion = new Button();
            btnRecepcionMediaDistancia = new Button();
            btnDespachoMediaDistancia = new Button();
            btnGenerarHDRTransporte = new Button();
            gbEntrega = new GroupBox();
            btnConsultarEstado = new Button();
            btnEntregaAgencia = new Button();
            btnEntregaCD = new Button();
            gbAdministracion = new GroupBox();
            btnResultadoCostoVentas = new Button();
            btnEstadoCuentaCorriente = new Button();
            gbEntorno.SuspendLayout();
            gbInicio.SuspendLayout();
            gbRetiro.SuspendLayout();
            gbDistribucion.SuspendLayout();
            gbEntrega.SuspendLayout();
            gbAdministracion.SuspendLayout();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(18, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menu de pruebas";
            //
            // gbEntorno
            //
            gbEntorno.Controls.Add(rbDesdeAgencia);
            gbEntorno.Controls.Add(rbDesdeCD);
            gbEntorno.Controls.Add(lblViaInicial);
            gbEntorno.Controls.Add(cboAgencia);
            gbEntorno.Controls.Add(lblAgencia);
            gbEntorno.Controls.Add(cboCentroDistribucion);
            gbEntorno.Controls.Add(lblCentroDistribucion);
            gbEntorno.Location = new Point(18, 55);
            gbEntorno.Name = "gbEntorno";
            gbEntorno.Size = new Size(934, 95);
            gbEntorno.TabIndex = 1;
            gbEntorno.TabStop = false;
            gbEntorno.Text = "Entorno";
            //
            // rbDesdeAgencia
            //
            rbDesdeAgencia.AutoSize = true;
            rbDesdeAgencia.Location = new Point(748, 47);
            rbDesdeAgencia.Name = "rbDesdeAgencia";
            rbDesdeAgencia.Size = new Size(103, 19);
            rbDesdeAgencia.TabIndex = 6;
            rbDesdeAgencia.TabStop = true;
            rbDesdeAgencia.Text = "Desde Agencia";
            rbDesdeAgencia.UseVisualStyleBackColor = true;
            //
            // rbDesdeCD
            //
            rbDesdeCD.AutoSize = true;
            rbDesdeCD.Location = new Point(650, 47);
            rbDesdeCD.Name = "rbDesdeCD";
            rbDesdeCD.Size = new Size(75, 19);
            rbDesdeCD.TabIndex = 5;
            rbDesdeCD.TabStop = true;
            rbDesdeCD.Text = "Desde CD";
            rbDesdeCD.UseVisualStyleBackColor = true;
            //
            // lblViaInicial
            //
            lblViaInicial.AutoSize = true;
            lblViaInicial.Location = new Point(650, 24);
            lblViaInicial.Name = "lblViaInicial";
            lblViaInicial.Size = new Size(54, 15);
            lblViaInicial.TabIndex = 4;
            lblViaInicial.Text = "Via inicial";
            //
            // cboAgencia
            //
            cboAgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgencia.FormattingEnabled = true;
            cboAgencia.Location = new Point(330, 44);
            cboAgencia.Name = "cboAgencia";
            cboAgencia.Size = new Size(270, 23);
            cboAgencia.TabIndex = 3;
            //
            // lblAgencia
            //
            lblAgencia.AutoSize = true;
            lblAgencia.Location = new Point(330, 24);
            lblAgencia.Name = "lblAgencia";
            lblAgencia.Size = new Size(84, 15);
            lblAgencia.TabIndex = 2;
            lblAgencia.Text = "Agencia actual";
            //
            // cboCentroDistribucion
            //
            cboCentroDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCentroDistribucion.FormattingEnabled = true;
            cboCentroDistribucion.Location = new Point(18, 44);
            cboCentroDistribucion.Name = "cboCentroDistribucion";
            cboCentroDistribucion.Size = new Size(270, 23);
            cboCentroDistribucion.TabIndex = 1;
            //
            // lblCentroDistribucion
            //
            lblCentroDistribucion.AutoSize = true;
            lblCentroDistribucion.Location = new Point(18, 24);
            lblCentroDistribucion.Name = "lblCentroDistribucion";
            lblCentroDistribucion.Size = new Size(168, 15);
            lblCentroDistribucion.TabIndex = 0;
            lblCentroDistribucion.Text = "Centro de distribución actual";
            //
            // gbInicio
            //
            gbInicio.Controls.Add(btnImposicionCallCenter);
            gbInicio.Controls.Add(btnImposicionAgencia);
            gbInicio.Controls.Add(btnImposicionCD);
            gbInicio.Location = new Point(18, 170);
            gbInicio.Name = "gbInicio";
            gbInicio.Size = new Size(218, 145);
            gbInicio.TabIndex = 2;
            gbInicio.TabStop = false;
            gbInicio.Text = "Inicio";
            //
            // btnImposicionCallCenter
            //
            btnImposicionCallCenter.Location = new Point(18, 96);
            btnImposicionCallCenter.Name = "btnImposicionCallCenter";
            btnImposicionCallCenter.Size = new Size(180, 28);
            btnImposicionCallCenter.TabIndex = 2;
            btnImposicionCallCenter.Text = "Imposición Call Center";
            btnImposicionCallCenter.UseVisualStyleBackColor = true;
            //
            // btnImposicionAgencia
            //
            btnImposicionAgencia.Location = new Point(18, 61);
            btnImposicionAgencia.Name = "btnImposicionAgencia";
            btnImposicionAgencia.Size = new Size(180, 28);
            btnImposicionAgencia.TabIndex = 1;
            btnImposicionAgencia.Text = "Imposición Agencia";
            btnImposicionAgencia.UseVisualStyleBackColor = true;
            //
            // btnImposicionCD
            //
            btnImposicionCD.Location = new Point(18, 26);
            btnImposicionCD.Name = "btnImposicionCD";
            btnImposicionCD.Size = new Size(180, 28);
            btnImposicionCD.TabIndex = 0;
            btnImposicionCD.Text = "Imposición CD";
            btnImposicionCD.UseVisualStyleBackColor = true;
            //
            // gbRetiro
            //
            gbRetiro.Controls.Add(btnRendirHDRRetiro);
            gbRetiro.Controls.Add(btnRecepcionHDRRetiro);
            gbRetiro.Controls.Add(btnResumenHDRRetiro);
            gbRetiro.Controls.Add(btnGenerarHDRRetiro);
            gbRetiro.Controls.Add(btnAdmision);
            gbRetiro.Location = new Point(252, 170);
            gbRetiro.Name = "gbRetiro";
            gbRetiro.Size = new Size(218, 220);
            gbRetiro.TabIndex = 3;
            gbRetiro.TabStop = false;
            gbRetiro.Text = "Retiro";
            //
            // btnRendirHDRRetiro
            //
            btnRendirHDRRetiro.Location = new Point(18, 166);
            btnRendirHDRRetiro.Name = "btnRendirHDRRetiro";
            btnRendirHDRRetiro.Size = new Size(180, 28);
            btnRendirHDRRetiro.TabIndex = 4;
            btnRendirHDRRetiro.Text = "Rendir HDR Retiro";
            btnRendirHDRRetiro.UseVisualStyleBackColor = true;
            //
            // btnRecepcionHDRRetiro
            //
            btnRecepcionHDRRetiro.Location = new Point(18, 131);
            btnRecepcionHDRRetiro.Name = "btnRecepcionHDRRetiro";
            btnRecepcionHDRRetiro.Size = new Size(180, 28);
            btnRecepcionHDRRetiro.TabIndex = 3;
            btnRecepcionHDRRetiro.Text = "Recepción HDR Retiro";
            btnRecepcionHDRRetiro.UseVisualStyleBackColor = true;
            //
            // btnResumenHDRRetiro
            //
            btnResumenHDRRetiro.Location = new Point(18, 96);
            btnResumenHDRRetiro.Name = "btnResumenHDRRetiro";
            btnResumenHDRRetiro.Size = new Size(180, 28);
            btnResumenHDRRetiro.TabIndex = 2;
            btnResumenHDRRetiro.Text = "Resumen HDR Retiro";
            btnResumenHDRRetiro.UseVisualStyleBackColor = true;
            //
            // btnGenerarHDRRetiro
            //
            btnGenerarHDRRetiro.Location = new Point(18, 61);
            btnGenerarHDRRetiro.Name = "btnGenerarHDRRetiro";
            btnGenerarHDRRetiro.Size = new Size(180, 28);
            btnGenerarHDRRetiro.TabIndex = 1;
            btnGenerarHDRRetiro.Text = "Generar HDR Retiro";
            btnGenerarHDRRetiro.UseVisualStyleBackColor = true;
            //
            // btnAdmision
            //
            btnAdmision.Location = new Point(18, 26);
            btnAdmision.Name = "btnAdmision";
            btnAdmision.Size = new Size(180, 28);
            btnAdmision.TabIndex = 0;
            btnAdmision.Text = "Admisión";
            btnAdmision.UseVisualStyleBackColor = true;
            //
            // gbDistribucion
            //
            gbDistribucion.Controls.Add(btnRendirHDRDistribucion);
            gbDistribucion.Controls.Add(btnRecepcionHDRDistribucion);
            gbDistribucion.Controls.Add(btnResumenHDRDistribucion);
            gbDistribucion.Controls.Add(btnGenerarHDRDistribucion);
            gbDistribucion.Controls.Add(btnRecepcionMediaDistancia);
            gbDistribucion.Controls.Add(btnDespachoMediaDistancia);
            gbDistribucion.Controls.Add(btnGenerarHDRTransporte);
            gbDistribucion.Location = new Point(486, 170);
            gbDistribucion.Name = "gbDistribucion";
            gbDistribucion.Size = new Size(240, 295);
            gbDistribucion.TabIndex = 4;
            gbDistribucion.TabStop = false;
            gbDistribucion.Text = "Transporte / Distribución";
            //
            // btnRendirHDRDistribucion
            //
            btnRendirHDRDistribucion.Location = new Point(18, 236);
            btnRendirHDRDistribucion.Name = "btnRendirHDRDistribucion";
            btnRendirHDRDistribucion.Size = new Size(200, 28);
            btnRendirHDRDistribucion.TabIndex = 6;
            btnRendirHDRDistribucion.Text = "Rendir HDR Distribución";
            btnRendirHDRDistribucion.UseVisualStyleBackColor = true;
            //
            // btnRecepcionHDRDistribucion
            //
            btnRecepcionHDRDistribucion.Location = new Point(18, 201);
            btnRecepcionHDRDistribucion.Name = "btnRecepcionHDRDistribucion";
            btnRecepcionHDRDistribucion.Size = new Size(200, 28);
            btnRecepcionHDRDistribucion.TabIndex = 5;
            btnRecepcionHDRDistribucion.Text = "Recepción HDR Distribución";
            btnRecepcionHDRDistribucion.UseVisualStyleBackColor = true;
            //
            // btnResumenHDRDistribucion
            //
            btnResumenHDRDistribucion.Location = new Point(18, 166);
            btnResumenHDRDistribucion.Name = "btnResumenHDRDistribucion";
            btnResumenHDRDistribucion.Size = new Size(200, 28);
            btnResumenHDRDistribucion.TabIndex = 4;
            btnResumenHDRDistribucion.Text = "Resumen HDR Distribución";
            btnResumenHDRDistribucion.UseVisualStyleBackColor = true;
            //
            // btnGenerarHDRDistribucion
            //
            btnGenerarHDRDistribucion.Location = new Point(18, 131);
            btnGenerarHDRDistribucion.Name = "btnGenerarHDRDistribucion";
            btnGenerarHDRDistribucion.Size = new Size(200, 28);
            btnGenerarHDRDistribucion.TabIndex = 3;
            btnGenerarHDRDistribucion.Text = "Generar HDR Distribución";
            btnGenerarHDRDistribucion.UseVisualStyleBackColor = true;
            //
            // btnRecepcionMediaDistancia
            //
            btnRecepcionMediaDistancia.Location = new Point(18, 96);
            btnRecepcionMediaDistancia.Name = "btnRecepcionMediaDistancia";
            btnRecepcionMediaDistancia.Size = new Size(200, 28);
            btnRecepcionMediaDistancia.TabIndex = 2;
            btnRecepcionMediaDistancia.Text = "Recepción Media Distancia";
            btnRecepcionMediaDistancia.UseVisualStyleBackColor = true;
            //
            // btnDespachoMediaDistancia
            //
            btnDespachoMediaDistancia.Location = new Point(18, 61);
            btnDespachoMediaDistancia.Name = "btnDespachoMediaDistancia";
            btnDespachoMediaDistancia.Size = new Size(200, 28);
            btnDespachoMediaDistancia.TabIndex = 1;
            btnDespachoMediaDistancia.Text = "Despacho Media Distancia";
            btnDespachoMediaDistancia.UseVisualStyleBackColor = true;
            //
            // btnGenerarHDRTransporte
            //
            btnGenerarHDRTransporte.Location = new Point(18, 26);
            btnGenerarHDRTransporte.Name = "btnGenerarHDRTransporte";
            btnGenerarHDRTransporte.Size = new Size(200, 28);
            btnGenerarHDRTransporte.TabIndex = 0;
            btnGenerarHDRTransporte.Text = "Generar HDR Transporte";
            btnGenerarHDRTransporte.UseVisualStyleBackColor = true;
            //
            // gbEntrega
            //
            gbEntrega.Controls.Add(btnConsultarEstado);
            gbEntrega.Controls.Add(btnEntregaAgencia);
            gbEntrega.Controls.Add(btnEntregaCD);
            gbEntrega.Location = new Point(742, 170);
            gbEntrega.Name = "gbEntrega";
            gbEntrega.Size = new Size(210, 145);
            gbEntrega.TabIndex = 5;
            gbEntrega.TabStop = false;
            gbEntrega.Text = "Entrega / Consulta";
            //
            // btnConsultarEstado
            //
            btnConsultarEstado.Location = new Point(16, 96);
            btnConsultarEstado.Name = "btnConsultarEstado";
            btnConsultarEstado.Size = new Size(176, 28);
            btnConsultarEstado.TabIndex = 2;
            btnConsultarEstado.Text = "Consultar Estado";
            btnConsultarEstado.UseVisualStyleBackColor = true;
            //
            // btnEntregaAgencia
            //
            btnEntregaAgencia.Location = new Point(16, 61);
            btnEntregaAgencia.Name = "btnEntregaAgencia";
            btnEntregaAgencia.Size = new Size(176, 28);
            btnEntregaAgencia.TabIndex = 1;
            btnEntregaAgencia.Text = "Entrega en Agencia";
            btnEntregaAgencia.UseVisualStyleBackColor = true;
            //
            // btnEntregaCD
            //
            btnEntregaCD.Location = new Point(16, 26);
            btnEntregaCD.Name = "btnEntregaCD";
            btnEntregaCD.Size = new Size(176, 28);
            btnEntregaCD.TabIndex = 0;
            btnEntregaCD.Text = "Entrega en CD";
            btnEntregaCD.UseVisualStyleBackColor = true;
            //
            // gbAdministracion
            //
            gbAdministracion.Controls.Add(btnResultadoCostoVentas);
            gbAdministracion.Controls.Add(btnEstadoCuentaCorriente);
            gbAdministracion.Location = new Point(742, 330);
            gbAdministracion.Name = "gbAdministracion";
            gbAdministracion.Size = new Size(210, 100);
            gbAdministracion.TabIndex = 6;
            gbAdministracion.TabStop = false;
            gbAdministracion.Text = "Administración";
            //
            // btnResultadoCostoVentas
            //
            btnResultadoCostoVentas.Location = new Point(16, 61);
            btnResultadoCostoVentas.Name = "btnResultadoCostoVentas";
            btnResultadoCostoVentas.Size = new Size(176, 28);
            btnResultadoCostoVentas.TabIndex = 1;
            btnResultadoCostoVentas.Text = "Resultado Costo/Ventas";
            btnResultadoCostoVentas.UseVisualStyleBackColor = true;
            //
            // btnEstadoCuentaCorriente
            //
            btnEstadoCuentaCorriente.Location = new Point(16, 26);
            btnEstadoCuentaCorriente.Name = "btnEstadoCuentaCorriente";
            btnEstadoCuentaCorriente.Size = new Size(176, 28);
            btnEstadoCuentaCorriente.TabIndex = 0;
            btnEstadoCuentaCorriente.Text = "Estado Cuenta Corriente";
            btnEstadoCuentaCorriente.UseVisualStyleBackColor = true;
            //
            // Menu
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 490);
            Controls.Add(gbAdministracion);
            Controls.Add(gbEntrega);
            Controls.Add(gbDistribucion);
            Controls.Add(gbRetiro);
            Controls.Add(gbInicio);
            Controls.Add(gbEntorno);
            Controls.Add(lblTitulo);
            Name = "Menu";
            Text = "Menu";
            gbEntorno.ResumeLayout(false);
            gbEntorno.PerformLayout();
            gbInicio.ResumeLayout(false);
            gbRetiro.ResumeLayout(false);
            gbDistribucion.ResumeLayout(false);
            gbEntrega.ResumeLayout(false);
            gbAdministracion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbEntorno;
        private RadioButton rbDesdeAgencia;
        private RadioButton rbDesdeCD;
        private Label lblViaInicial;
        private ComboBox cboAgencia;
        private Label lblAgencia;
        private ComboBox cboCentroDistribucion;
        private Label lblCentroDistribucion;
        private GroupBox gbInicio;
        private Button btnImposicionCallCenter;
        private Button btnImposicionAgencia;
        private Button btnImposicionCD;
        private GroupBox gbRetiro;
        private Button btnRendirHDRRetiro;
        private Button btnRecepcionHDRRetiro;
        private Button btnResumenHDRRetiro;
        private Button btnGenerarHDRRetiro;
        private Button btnAdmision;
        private GroupBox gbDistribucion;
        private Button btnRendirHDRDistribucion;
        private Button btnRecepcionHDRDistribucion;
        private Button btnResumenHDRDistribucion;
        private Button btnGenerarHDRDistribucion;
        private Button btnRecepcionMediaDistancia;
        private Button btnDespachoMediaDistancia;
        private Button btnGenerarHDRTransporte;
        private GroupBox gbEntrega;
        private Button btnConsultarEstado;
        private Button btnEntregaAgencia;
        private Button btnEntregaCD;
        private GroupBox gbAdministracion;
        private Button btnResultadoCostoVentas;
        private Button btnEstadoCuentaCorriente;
    }
}
