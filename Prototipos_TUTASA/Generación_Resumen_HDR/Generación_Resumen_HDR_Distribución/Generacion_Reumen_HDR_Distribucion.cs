using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class Generacion_Reumen_HDR_Distribucion : Form
    {
        private readonly ModeloResumenHDRDistribucion modelo = new ModeloResumenHDRDistribucion();
        private HojaDeRutaDistribucionEntidad hojaSeleccionada = new HojaDeRutaDistribucionEntidad();
        private bool hayHojaSeleccionada = false;

        public Generacion_Reumen_HDR_Distribucion()
        {
            InitializeComponent();
        }

        private void Generacion_Reumen_HDR_Distribucion_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            CargarFleteros();
            LimpiarResumen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHojaAsignada();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarHojaAsignada();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un fletero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!hayHojaSeleccionada)
            {
                MessageBox.Show("No hay una Hoja de Ruta de Distribución asignada al fletero para la fecha seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResumenHDRDistribucionEntidad resumen = modelo.GenerarResumen(hojaSeleccionada);
            textBox4.Text = resumen.TotalDomicilios.ToString();
            textBox5.Text = resumen.TotalBultos.ToString();

            MessageBox.Show($"Resumen de HDR de Distribución Nro {resumen.NroResumen} generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarFleteros()
        {
            comboBox1.Items.Clear();

            foreach (var fletero in modelo.Fleteros)
                comboBox1.Items.Add(new FleteroResumenItem(fletero));
        }

        private void CargarHojaAsignada()
        {
            LimpiarResumen();

            FleteroResumenItem itemSeleccionado = comboBox1.SelectedItem as FleteroResumenItem;
            if (itemSeleccionado == null)
                return;

            if (!modelo.BuscarHojaAsignada(itemSeleccionado.Fletero, dateTimePicker1.Value.Date, out HojaDeRutaDistribucionEntidad hoja))
                return;

            hojaSeleccionada = hoja;
            hayHojaSeleccionada = true;

            foreach (var guia in hojaSeleccionada.Guias)
            {
                DatosDestinoResumen datos = modelo.ObtenerDatosDestino(guia);
                var item = new ListViewItem(hojaSeleccionada.NroHDR.ToString());
                item.SubItems.Add(datos.Nombre);
                item.SubItems.Add(datos.Calle);
                item.SubItems.Add(datos.Altura.ToString());
                item.SubItems.Add(datos.CodigoPostal);
                item.SubItems.Add("1");
                item.Tag = guia;
                listView1.Items.Add(item);
            }

            textBox4.Text = modelo.CalcularTotalDomicilios(hojaSeleccionada).ToString();
            textBox5.Text = modelo.CalcularTotalBultos(hojaSeleccionada).ToString();
        }

        private void LimpiarResumen()
        {
            hojaSeleccionada = new HojaDeRutaDistribucionEntidad();
            hayHojaSeleccionada = false;
            listView1.Items.Clear();
            textBox4.Text = "0";
            textBox5.Text = "0";
        }
    }

    internal class ModeloResumenHDRDistribucion
    {
        private readonly ModeloGenerarHDRDistribucion modeloBase = new ModeloGenerarHDRDistribucion();
        private readonly List<ResumenHDRDistribucionEntidad> resumenes = new List<ResumenHDRDistribucionEntidad>();

        public List<TransportistaLocalEntidad> Fleteros
        {
            get { return modeloBase.Transportistas.Where(t => t.CD.IdCD == modeloBase.CdEmisor.IdCD).ToList(); }
        }

        public ModeloResumenHDRDistribucion()
        {
            CargarHojasDeRutaDePrueba();
        }

        public bool BuscarHojaAsignada(TransportistaLocalEntidad fletero, DateTime fecha, out HojaDeRutaDistribucionEntidad hoja)
        {
            hoja = new HojaDeRutaDistribucionEntidad();

            foreach (var hdr in modeloBase.HojasDeRuta)
            {
                if (hdr.Transportista.DniTransportista == fletero.DniTransportista
                    && hdr.FechaEmision.Date == fecha.Date
                    && hdr.Estado == EstadoHojaDeRutaDistribucion.Generada)
                {
                    hoja = hdr;
                    return true;
                }
            }

            return false;
        }

        public DatosDestinoResumen ObtenerDatosDestino(GuiaEntidad guia)
        {
            if (guia.ModalidadEntrega == ModalidadEntrega.PuertaAPuerta)
            {
                return new DatosDestinoResumen
                {
                    Nombre = $"{guia.Destinatario.Nombre} {guia.Destinatario.Apellido}",
                    Calle = guia.Destinatario.Calle,
                    Altura = guia.Destinatario.Altura,
                    CodigoPostal = guia.Destinatario.CodigoPostal
                };
            }

            return new DatosDestinoResumen
            {
                Nombre = guia.Agencia.RazonSocial,
                Calle = guia.Agencia.Calle,
                Altura = guia.Agencia.Altura,
                CodigoPostal = guia.Agencia.CodigoPostal
            };
        }

        public int CalcularTotalBultos(HojaDeRutaDistribucionEntidad hoja)
        {
            return hoja.Guias.Count;
        }

        public int CalcularTotalDomicilios(HojaDeRutaDistribucionEntidad hoja)
        {
            return hoja.Guias
                .Select(g => ObtenerDatosDestino(g).ClaveDomicilio)
                .Distinct()
                .Count();
        }

        public ResumenHDRDistribucionEntidad GenerarResumen(HojaDeRutaDistribucionEntidad hoja)
        {
            ResumenHDRDistribucionEntidad resumen = new ResumenHDRDistribucionEntidad
            {
                NroResumen = resumenes.Count + 1,
                FechaGeneracion = DateTime.Now,
                HojaDeRuta = hoja,
                Fletero = hoja.Transportista,
                TotalDomicilios = CalcularTotalDomicilios(hoja),
                TotalBultos = CalcularTotalBultos(hoja)
            };

            resumenes.Add(resumen);
            return resumen;
        }

        private void CargarHojasDeRutaDePrueba()
        {
            TransportistaLocalEntidad fleteroCapital = new TransportistaLocalEntidad();
            bool existeFleteroCapital = false;

            foreach (var transportista in modeloBase.Transportistas)
            {
                if (transportista.CD.IdCD == modeloBase.CdEmisor.IdCD)
                {
                    fleteroCapital = transportista;
                    existeFleteroCapital = true;
                    break;
                }
            }

            if (!existeFleteroCapital)
                return;

            List<GuiaEntidad> guias = modeloBase.Guias
                .Where(g => g.Estado == EstadoGuia.EnDistribucion && g.CdDestino.IdCD == modeloBase.CdEmisor.IdCD)
                .ToList();

            if (guias.Count == 0)
                guias = modeloBase.Guias
                    .Where(g => g.CdDestino.IdCD == modeloBase.CdEmisor.IdCD)
                    .Take(2)
                    .ToList();

            foreach (var guia in guias)
                guia.Estado = EstadoGuia.EnDistribucion;

            modeloBase.HojasDeRuta.Add(new HojaDeRutaDistribucionEntidad
            {
                NroHDR = 1,
                FechaEmision = DateTime.Today,
                CdEmisor = modeloBase.CdEmisor,
                Transportista = fleteroCapital,
                Guias = guias,
                Estado = EstadoHojaDeRutaDistribucion.Generada
            });
        }
    }

    internal class ResumenHDRDistribucionEntidad
    {
        public int NroResumen { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public HojaDeRutaDistribucionEntidad HojaDeRuta { get; set; }
        public TransportistaLocalEntidad Fletero { get; set; }
        public int TotalDomicilios { get; set; }
        public int TotalBultos { get; set; }
    }

    internal class FleteroResumenItem
    {
        public TransportistaLocalEntidad Fletero { get; }

        public FleteroResumenItem(TransportistaLocalEntidad fletero)
        {
            Fletero = fletero;
        }

        public override string ToString()
        {
            return $"{Fletero.Nombre} {Fletero.Apellido}";
        }
    }

    internal class DatosDestinoResumen
    {
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public string ClaveDomicilio
        {
            get { return $"{Calle}|{Altura}|{CodigoPostal}".ToUpperInvariant(); }
        }
    }
}
