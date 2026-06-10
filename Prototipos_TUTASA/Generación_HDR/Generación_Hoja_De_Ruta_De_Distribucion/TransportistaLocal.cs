using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class TransportistaLocal
    {
        public int dniTransportista { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public CentroDistribucion idCD { get; set; }
        public int HdrAsignadas { get; set; } 
    }
}
