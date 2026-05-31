using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA
{
    internal class ResumenHDRRetiroEntidad
    {
        public int NroResumen { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public List<HojaDeRutaRetiroEntidad> HojasDeRuta { get; set; }
        public TransportistaLocalEntidad Fletero { get; set; }
        public int TotalDomicilios { get; set; }
        public int TotalBultos { get; set; }

        public ResumenHDRRetiroEntidad()
        {
            HojasDeRuta = new List<HojaDeRutaRetiroEntidad>();
            Fletero = new TransportistaLocalEntidad();
        }
    }
}
