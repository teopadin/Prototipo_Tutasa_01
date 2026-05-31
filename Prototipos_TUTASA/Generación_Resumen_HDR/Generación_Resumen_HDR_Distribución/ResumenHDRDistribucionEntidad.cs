using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA
{
    internal class ResumenHDRDistribucionEntidad
    {
        public int NroResumen { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public List<HojaDeRutaDistribucionEntidad> HojasDeRuta { get; set; }
        public TransportistaLocalEntidad Fletero { get; set; }
        public int TotalDomicilios { get; set; }
        public int TotalBultos { get; set; }

        public ResumenHDRDistribucionEntidad()
        {
            HojasDeRuta = new List<HojaDeRutaDistribucionEntidad>();
            Fletero = new TransportistaLocalEntidad();
        }
    }
}
