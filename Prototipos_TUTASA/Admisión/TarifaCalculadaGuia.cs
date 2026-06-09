using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class TarifaCalculadaGuia
    {
        public decimal PrecioFlete { get; set; }
        public decimal ExtraRetiroDomicilio { get; set; }
        public decimal ExtraEntregaDomicilio { get; set; }
        public decimal ExtraEntregaAgencia { get; set; }
        public decimal TarifaTotal { get; set; }
    }
}
