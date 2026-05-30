using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class TransportistaLocalEntidad
    {
        public int DniTransportista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public CentroDistribucionEntidad CD { get; set; }
        public int HdrAsignadas { get; set; } 
    }
}
