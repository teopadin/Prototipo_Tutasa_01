using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaEnAgencia
{
    public partial class Recepcion_HDR_Retiro_Agencia : Form
    {
        //Instancia del modelo de recepcion de hdr de retiro en Agencia
        private ModeloRecibirHDRRetiroAgencia modelo = new ModeloRecibirHDRRetiroAgencia();
        public Recepcion_HDR_Retiro_Agencia()
        {
            InitializeComponent();
        }

        private void Recepcion_HDR_Retiro_Agencia_Load(object sender, EventArgs e)
        {

        }
    }
}
