using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.HojaDeRutaDeDistribucion
{
    public partial class HojaDeRutaDeDistribucionDestinatario : Form
    {
        private ModeloGenerarHDRDistribucion modelo = new ModeloGenerarHDRDistribucion();
        public HojaDeRutaDeDistribucionDestinatario()
        {
            InitializeComponent();
        }

        private void HojaDeRutaDeDistribucionDestinatario_Load(object sender, EventArgs e)
        {

        }
    }
}
