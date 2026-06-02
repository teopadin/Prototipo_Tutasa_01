using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.ClasesResumenHDRRetiro
{
    internal class HojaDeRutaRetiro
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public int DniTransportistaAsignado { get; set; }
        public List<DetalleGuiaRetiro> DetalleGuias { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }

        public HojaDeRutaRetiro()
        {
            DetalleGuias = new List<DetalleGuiaRetiro>();
        }
    }
}
