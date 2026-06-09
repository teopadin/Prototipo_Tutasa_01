using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class EmpresaTransporte
    {
        public int IdEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public bool ConvenioVigente { get; set; }

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
