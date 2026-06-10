using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ArrendamientoBodega
    {
        public int idArrendamiento { get; set; }
        public string idServicio { get; set; }
        public DateTime periodo { get; set; }
        public TipoArrendamientoEnum tipoArrendamiento { get; set; }
        public decimal importeMensual { get; set; }
    }
}
