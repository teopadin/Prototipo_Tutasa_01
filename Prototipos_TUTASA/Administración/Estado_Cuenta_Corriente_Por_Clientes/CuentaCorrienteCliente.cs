using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class CuentaCorrienteCliente
    {
        public int IdCuentaCorriente { get; set; }
        public int IdCliente { get; set; }
        public decimal SaldoActual { get; set; }
        public EstadoCuentaCorrienteEnum EstadoCuenta { get; set; }
    }
}
