using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class HojaDeRutaDistribucion
    {
        public int NroHDR { get; set; }
        public DateTime Fecha { get; set; }
        public int dniTransportistaAsignado { get; set; }
        public List<string> DetalleGuias { get; set; }
        public EstadoHojaDeRutaEnum estado { get; set; }

        public HojaDeRutaDistribucion()
        {
            DetalleGuias = new List<string>();
        }
    }
}
