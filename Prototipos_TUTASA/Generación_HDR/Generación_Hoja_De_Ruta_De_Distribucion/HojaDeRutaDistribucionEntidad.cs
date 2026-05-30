using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class HojaDeRutaDistribucionEntidad
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public CentroDistribucionEntidad CdEmisor { get; set; }
        public TransportistaLocalEntidad Transportista { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public EstadoHojaDeRutaDistribucion Estado { get; set; }
    }
}