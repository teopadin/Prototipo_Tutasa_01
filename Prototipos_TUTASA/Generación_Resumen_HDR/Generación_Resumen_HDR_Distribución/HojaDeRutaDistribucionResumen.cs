using System;
using System.Collections.Generic;
using TransportistaLocal = Prototipos_TUTASA.ClasesResumenHDRDistribucion.TransportistaLocal;

namespace Prototipos_TUTASA
{
    internal class HojaDeRutaDistribucionResumen
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public TransportistaLocal Transportista { get; set; }
        public List<GuiaDistribucionResumen> Guias { get; set; }
        public EstadoHojaDeRutaResumen Estado { get; set; }

        public HojaDeRutaDistribucionResumen()
        {
            Transportista = new TransportistaLocal();
            Guias = new List<GuiaDistribucionResumen>();
        }
    }
}
