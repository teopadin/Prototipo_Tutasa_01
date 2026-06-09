using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class TarifaPorCliente
    {
        public int IdTarifa { get; set; }
        public int IdCliente { get; set; }
        public int IdCDOrigen { get; set; }
        public int IdCDDestino { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public decimal PrecioFlete { get; set; }
    }
}
