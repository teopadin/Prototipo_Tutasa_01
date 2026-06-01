using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA
{
    internal class HojaDeRutaDistribucionResumen
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public FleteroResumen Fletero { get; set; }
        public List<GuiaDistribucionResumen> Guias { get; set; }
        public EstadoHojaDeRutaResumen Estado { get; set; }

        public HojaDeRutaDistribucionResumen()
        {
            Fletero = new FleteroResumen();
            Guias = new List<GuiaDistribucionResumen>();
        }
    }
}
