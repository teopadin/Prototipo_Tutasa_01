using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class GuiaResultado
    {
        public string NroGuia { get; set; }
        public DateTime FechaImposicion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal ImporteVenta { get; set; }
        public EstadoGuiaResultado Estado { get; set; }
    }
}
