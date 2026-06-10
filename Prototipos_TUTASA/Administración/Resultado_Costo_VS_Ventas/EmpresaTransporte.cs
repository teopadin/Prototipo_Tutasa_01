using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class EmpresaTransporte
    {
        public int idEmpresa { get; set; }
        public string razonSocial { get; set; }
        public bool convenioVigente { get; set; }

        public override string ToString()
        {
            return razonSocial;
        }
    }
}
