using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Almacenes
{
    internal class TarifaTransportistaLocalEntidad
    {
        public int idTarifaTransportista { get; set; }
        public Auxiliares.TiposBultoEnum TipoBulto { get; set; }
        public decimal MontoRetiro { get; set; }
        public decimal MontoDistribucion { get; set; }
    }
}
