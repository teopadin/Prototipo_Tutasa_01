using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class CostoExtra
    {
        public int IdCostoExtra { get; set; }
        public TipoCostoExtraEnum Tipo { get; set; }
        public decimal Monto { get; set; }
    }
}
