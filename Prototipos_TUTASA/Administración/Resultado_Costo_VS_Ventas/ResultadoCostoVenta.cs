using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ResultadoCostoVenta
    {
        public int IdEmpresa { get; set; }
        public DateTime Periodo { get; set; }
        public decimal Ventas { get; set; }
        public decimal Costos { get; set; }

        public decimal Resultado
        {
            get { return Ventas - Costos; }
        }
    }
}
