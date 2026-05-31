using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ArrendamientoBodegaEntidad
    {
        public int IdArrendamiento { get; set; }
        public EmpresaTransporteEntidad Empresa { get; set; }
        public DateTime Periodo { get; set; }
        public decimal ImporteMensual { get; set; }
    }
}
