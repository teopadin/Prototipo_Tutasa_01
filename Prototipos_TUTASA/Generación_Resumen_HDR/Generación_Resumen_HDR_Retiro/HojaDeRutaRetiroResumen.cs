using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA
{
    internal class HojaDeRutaRetiroResumen
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public TransportistaLocal Transportista { get; set; }
        public List<GuiaRetiroResumen> Guias { get; set; }
        public EstadoHojaDeRutaResumen Estado { get; set; }

        public HojaDeRutaRetiroResumen()
        {
            Transportista = new TransportistaLocal();
            Guias = new List<GuiaRetiroResumen>();
        }
    }
}
