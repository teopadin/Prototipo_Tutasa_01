using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro
{
    internal class HojaDeRutaRetiro
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public CentroDistribucion CdEmisor { get; set; }
        public TransportistaLocal Transportista { get; set; }
        public List<Guia> Guias { get; set; }
        public EstadoHojaDeRutaRetiro Estado { get; set; }
    }
}
