using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class HojaDeRutaDistribucion
    {
        public int NroHDR { get; set; }
        public DateTime Fecha { get; set; }
        public int DniTransportistaAsignado { get; set; }
        public List<DestinatarioGuia> DetalleGuias { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }

        public HojaDeRutaDistribucion()
        {
            DetalleGuias = new List<DestinatarioGuia>();
        }
    }
}
