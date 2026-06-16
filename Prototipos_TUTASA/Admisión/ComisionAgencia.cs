using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class ComisionAgencia
    {
        public int idAgencia { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public decimal MontoPorImposicion { get; set; }
        public decimal MontoPorEntrega { get; set; }
    }
}
