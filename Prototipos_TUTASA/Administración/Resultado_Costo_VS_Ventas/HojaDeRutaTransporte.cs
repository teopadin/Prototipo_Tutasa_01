using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class HojaDeRutaTransporte
    {
        public int nroHDR { get; set; }
        public string idServicio { get; set; }
        public List<string> DetalleGuias { get; set; }

        public HojaDeRutaTransporte()
        {
            DetalleGuias = new List<string>();
        }
    }
}
