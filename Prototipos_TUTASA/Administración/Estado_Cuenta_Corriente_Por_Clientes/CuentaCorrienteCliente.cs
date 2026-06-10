using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class CuentaCorrienteCliente
    {
        public int idCuentaCorriente { get; set; }
        public int idCliente { get; set; }
        public decimal saldoActual { get; set; }
        public EstadoCuentaCorrienteEnum estadoCuenta { get; set; }
    }
}
