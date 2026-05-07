using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prototipos_TUTASA.EntregaenCD
{
    partial class EntregaCD
    {
        // ── Controles públicos para que la lógica los consuma ──────────────
        public TextBox txtNroGuia { get; private set; }
        public TextBox txtFechaAdmision { get; private set; }
        public TextBox txtImporte { get; private set; }
        public TextBox txtDNI { get; private set; }
        public TextBox txtNombreApellido { get; private set; }
        public CheckBox chkDocPresentado { get; private set; }
        public TextBox txtComisionFletero { get; private set; }
        public TextBox txtComisionAgencia { get; private set; }
        public Button btnConfirmar { get; private set; }
        public Button btnCancelar { get; private set; }

        private void InitializeComponent()
        {
            // ── Form ───────────────────────────────────────────────────────
            this.Text = "Entrega en Terminal / Agencia";
            this.Size = new Size(640, 560);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9.5f);
            this.BackColor = Color.FromArgb(245, 247, 250);

            // ── Título ─────────────────────────────────────────────────────
            var lblTitulo = new Label
            {
                Text = "Entrega en Terminal / Agencia",
                Font = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 80, 150),
                Location = new Point(20, 15),
                AutoSize = true
            };

            var separator = new Panel
            {
                Location = new Point(20, 46),
                Size = new Size(582, 2),
                BackColor = Color.FromArgb(30, 80, 150)
            };

            // ── GroupBox: Datos de la Guía ─────────────────────────────────
            var grpGuia = new GroupBox
            {
                Text = "Datos de la Guía",
                Location = new Point(20, 60),
                Size = new Size(582, 115),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50)
            };

            // Nro. Guía
            var lblNroGuia = MakeLabel("Nro. de Guía:", new Point(12, 28));
            txtNroGuia = MakeTextBox(new Point(145, 25), 140, readOnly: true);

            // Fecha Admisión
            var lblFecha = MakeLabel("Fecha de Admisión:", new Point(305, 28));
            txtFechaAdmision = MakeTextBox(new Point(440, 25), 125, readOnly: true);

            // Importe
            var lblImporte = MakeLabel("Importe a Facturar:", new Point(12, 68));
            txtImporte = MakeTextBox(new Point(145, 65), 140, readOnly: true);
            txtImporte.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            txtImporte.ForeColor = Color.FromArgb(20, 120, 40);
            txtImporte.BackColor = Color.FromArgb(230, 255, 235);

            var lblAviso = new Label
            {
                Text = "⚠ Importe calculado al momento de la admisión",
                Font = new Font("Segoe UI", 8f, FontStyle.Italic),
                ForeColor = Color.FromArgb(160, 100, 0),
                Location = new Point(305, 70),
                AutoSize = true
            };

            grpGuia.Controls.AddRange(new Control[]
                { lblNroGuia, txtNroGuia, lblFecha, txtFechaAdmision,
                  lblImporte, txtImporte, lblAviso });

            // ── GroupBox: Destinatario / Retirante ─────────────────────────
            var grpDest = new GroupBox
            {
                Text = "Destinatario / Retirante",
                Location = new Point(20, 190),
                Size = new Size(582, 135),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50)
            };

            var lblDNI = MakeLabel("DNI / Cédula:  *", new Point(12, 32));
            txtDNI = MakeTextBox(new Point(145, 29), 160);
            txtDNI.MaxLength = 15;

            var lblNombre = MakeLabel("Nombre y Apellido:  *", new Point(12, 72));
            txtNombreApellido = MakeTextBox(new Point(145, 69), 420);
            txtNombreApellido.MaxLength = 100;

            chkDocPresentado = new CheckBox
            {
                Text = "Documento / Cédula presentado  (obligatorio)",
                Location = new Point(145, 103),
                AutoSize = true,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(180, 30, 30)
            };

            grpDest.Controls.AddRange(new Control[]
                { lblDNI, txtDNI, lblNombre, txtNombreApellido, chkDocPresentado });

            // ── GroupBox: Comisiones ───────────────────────────────────────
            var grpCom = new GroupBox
            {
                Text = "Comisiones (si corresponde)",
                Location = new Point(20, 340),
                Size = new Size(582, 90),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50)
            };

            var lblFletero = MakeLabel("Comisión Fletero:", new Point(12, 35));
            txtComisionFletero = MakeTextBox(new Point(145, 32), 140, readOnly: true);
            txtComisionFletero.BackColor = Color.FromArgb(240, 240, 240);

            var lblAgencia = MakeLabel("Comisión Agencia:", new Point(305, 35));
            txtComisionAgencia = MakeTextBox(new Point(440, 32), 125, readOnly: true);
            txtComisionAgencia.BackColor = Color.FromArgb(240, 240, 240);

            grpCom.Controls.AddRange(new Control[]
                { lblFletero, txtComisionFletero, lblAgencia, txtComisionAgencia });

            // ── Botones ────────────────────────────────────────────────────
            btnConfirmar = new Button
            {
                Text = "✔  Confirmar Entrega",
                Location = new Point(345, 455),
                Size = new Size(175, 40),
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                BackColor = Color.FromArgb(30, 130, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnConfirmar.FlatAppearance.BorderSize = 0;

            btnCancelar = new Button
            {
                Text = "✖  Cancelar",
                Location = new Point(530, 455),
                Size = new Size(110, 40),
                Font = new Font("Segoe UI", 10f),
                BackColor = Color.FromArgb(190, 50, 50),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCancelar.FlatAppearance.BorderSize = 0;

            // ── Nota inferior ──────────────────────────────────────────────
            var lblNota = new Label
            {
                Text = "* El destinatario debe firmar el Recibo de Encomienda antes de confirmar la entrega.",
                Font = new Font("Segoe UI", 8f, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(20, 465),
                Size = new Size(310, 32)
            };

            // ── Agregar controles al Form ──────────────────────────────────
            this.Controls.AddRange(new Control[]
            {
                lblTitulo, separator,
                grpGuia,
                grpDest,
                grpCom,
                btnConfirmar, btnCancelar,
                lblNota
            });
        }

        // ── Helpers ────────────────────────────────────────────────────────
        private static Label MakeLabel(string text, Point location)
        {
            return new Label
            {
                Text = text,
                Location = location,
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.FromArgb(60, 60, 60)
            };
        }

        private static TextBox MakeTextBox(Point location, int width, bool readOnly = false)
        {
            return new TextBox
            {
                Location = location,
                Size = new Size(width, 24),
                ReadOnly = readOnly,
                BackColor = readOnly ? Color.FromArgb(235, 235, 235) : Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
        }
    }
}