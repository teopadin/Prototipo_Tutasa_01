using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class CuentaCorrienteCliente
    {
        public int IdCuentaCorriente { get; set; }
        public Cliente Cliente { get; set; }
        public decimal SaldoActual { get; set; }
        public EstadoCuentaCorriente EstadoCuenta { get; set; }

        public bool HabilitadoParaFacturar
        {
            get { return EstadoCuenta == EstadoCuentaCorriente.Activa; }
        }

        public string CondicionFacturacion
        {
            get
            {
                if (HabilitadoParaFacturar)
                    return "Habilitado";

                return "Bloqueado";
            }
        }
    }
}
