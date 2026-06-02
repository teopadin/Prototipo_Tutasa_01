using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class HojaDeRutaDistribucion
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public int DniTransportistaAsignado { get; set; }
        public List<DetalleGuiaDistribucion> DetalleGuias { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }

        public HojaDeRutaDistribucion()
        {
            DetalleGuias = new List<DetalleGuiaDistribucion>();
        }
    }
}
