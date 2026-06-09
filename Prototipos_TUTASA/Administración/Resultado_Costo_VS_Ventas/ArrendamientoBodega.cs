using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ArrendamientoBodega
    {
        public int IdArrendamiento { get; set; }
        public string IdServicio { get; set; }
        public DateTime Periodo { get; set; }
        public TipoArrendamientoEnum TipoArrendamiento { get; set; }
        public decimal ImporteMensual { get; set; }
    }
}
