using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CargarEntorno();
            ConectarEventos();
            ActualizarContexto();
        }

        private void CargarEntorno()
        {
            List<CentroDistribucionEntidad> centros = new List<CentroDistribucionEntidad>();
            if (CentroDistribucionAlmacen.CentrosDeDistribucion != null)
            {
                foreach (CentroDistribucionEntidad centro in CentroDistribucionAlmacen.CentrosDeDistribucion)
                {
                    centros.Add(centro);
                }
            }

            cboCentroDistribucion.DisplayMember = "nombre";
            cboCentroDistribucion.ValueMember = "idCD";
            cboCentroDistribucion.DataSource = centros;
            SeleccionarCentro(Program.CodigoCDActual);

            List<AgenciaEntidad> agencias = new List<AgenciaEntidad>();
            if (AgenciaAlmacen.Agencias != null)
            {
                foreach (AgenciaEntidad agencia in AgenciaAlmacen.Agencias)
                {
                    agencias.Add(agencia);
                }
            }

            cboAgencia.DisplayMember = "razonSocial";
            cboAgencia.ValueMember = "idAgencia";
            cboAgencia.DataSource = agencias;
            SeleccionarAgencia(Program.CodigoAgenciaActual);

            rbDesdeAgencia.Checked = Program.IniciaDesdeAgencia;
            rbDesdeCD.Checked = !Program.IniciaDesdeAgencia;
        }

        private void ConectarEventos()
        {
            cboCentroDistribucion.SelectedIndexChanged += Entorno_Changed;
            cboAgencia.SelectedIndexChanged += Entorno_Changed;
            rbDesdeCD.CheckedChanged += Entorno_Changed;
            rbDesdeAgencia.CheckedChanged += Entorno_Changed;

            btnImposicionCD.Click += (sender, e) => Abrir(new ImposiciónCD_V2.ImposiciónCD_V2());
            btnImposicionAgencia.Click += (sender, e) => Abrir(new ImposiciónAgencia_v2.ImposicionAgencia_v2());
            btnImposicionCallCenter.Click += (sender, e) => Abrir(new ImposiciónCallCenter_v2.ImposicionCallCenter_v2());

            btnAdmision.Click += (sender, e) => Abrir(new Admisión.Admisión());
            btnGenerarHDRRetiro.Click += (sender, e) => Abrir(new HojaDeRutaRetiro.GeneracionHojaDeRutaRetiro());
            btnResumenHDRRetiro.Click += (sender, e) => Abrir(new Resumen_HDR_Retiro());
            btnRecepcionHDRRetiro.Click += (sender, e) => Abrir(new RecepcionHojaDeRutaDeRetiroEnAgencia.Recepcion_HDR_Retiro_Agencia());
            btnRendirHDRRetiro.Click += (sender, e) => Abrir(new Rendiciones_HDR.Rendir_HDR_De_Retiro());

            btnGenerarHDRTransporte.Click += (sender, e) => Abrir(new Generación_Hoja_De_Ruta_De_Transporte.GenerarHojaDeRutaDeTransporte());
            btnDespachoMediaDistancia.Click += (sender, e) => Abrir(new Despacho_Servicios_Media_Distancia.Despacho_Servicios_Media_Distancia());
            btnRecepcionMediaDistancia.Click += (sender, e) => Abrir(new RecepcionMediaDistancia.RecepcionMediaDistancia());
            btnGenerarHDRDistribucion.Click += (sender, e) => Abrir(new HojaDeRutaDeDistribucion.HojaDeRutaDeDistribucionDestinatario());
            btnResumenHDRDistribucion.Click += (sender, e) => Abrir(new Generacion_Resumen_HDR_Distribucion());
            btnRecepcionHDRDistribucion.Click += (sender, e) => Abrir(new RecepcionHojaDeRutaDeDistribucionEnAgencia.Recepcion_HDR_Distribucion_Agencia());
            btnRendirHDRDistribucion.Click += (sender, e) => Abrir(new Rendiciones_HDR.Rendir_HDR_De_Distribucion());

            btnEntregaCD.Click += (sender, e) => Abrir(new Última_Milla.Entrega_Encomienda_CD.EntregaEncomiendaCD());
            btnEntregaAgencia.Click += (sender, e) => Abrir(new Última_Milla.Entrega_Encomienda_Agencia.EntregaAgencia());
            btnConsultarEstado.Click += (sender, e) => Abrir(new ConsultarEstadoDelPedido_v2.ConsultarEstadoDelPedido());
        }

        private void Entorno_Changed(object sender, EventArgs e)
        {
            ActualizarContexto();
        }

        private void ActualizarContexto()
        {
            if (cboCentroDistribucion.SelectedItem is CentroDistribucionEntidad centro)
            {
                Program.CodigoCDActual = centro.idCD;
            }

            if (cboAgencia.SelectedItem is AgenciaEntidad agencia)
            {
                Program.CodigoAgenciaActual = agencia.idAgencia;
            }

            Program.IniciaDesdeAgencia = rbDesdeAgencia.Checked;
        }

        private void Abrir(Form pantalla)
        {
            ActualizarContexto();
            using (pantalla)
            {
                pantalla.ShowDialog(this);
            }
        }

        private void SeleccionarCentro(int idCD)
        {
            for (int i = 0; i < cboCentroDistribucion.Items.Count; i++)
            {
                if (cboCentroDistribucion.Items[i] is CentroDistribucionEntidad centro && centro.idCD == idCD)
                {
                    cboCentroDistribucion.SelectedIndex = i;
                    return;
                }
            }

            if (cboCentroDistribucion.Items.Count > 0)
            {
                cboCentroDistribucion.SelectedIndex = 0;
            }
        }

        private void SeleccionarAgencia(int idAgencia)
        {
            for (int i = 0; i < cboAgencia.Items.Count; i++)
            {
                if (cboAgencia.Items[i] is AgenciaEntidad agencia && agencia.idAgencia == idAgencia)
                {
                    cboAgencia.SelectedIndex = i;
                    return;
                }
            }

            if (cboAgencia.Items.Count > 0)
            {
                cboAgencia.SelectedIndex = 0;
            }
        }
    }
}
