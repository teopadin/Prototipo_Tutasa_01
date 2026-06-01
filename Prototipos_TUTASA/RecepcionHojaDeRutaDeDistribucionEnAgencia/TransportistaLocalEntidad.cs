using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class TransportistaLocalEntidad
    {
        public int DniTransportista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public CentroDeDistribucionEntidad IdCD { get; set; }
    }
}
