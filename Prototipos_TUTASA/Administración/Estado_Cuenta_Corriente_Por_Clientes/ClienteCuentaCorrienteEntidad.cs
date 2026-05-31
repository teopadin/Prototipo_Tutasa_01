using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class ClienteCuentaCorrienteEntidad
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string EstadoCuenta { get; set; }
        public decimal SaldoActual { get; set; }
        public bool HabilitadoParaFacturar { get; set; }

        public string CondicionFacturacion
        {
            get
            {
                if (HabilitadoParaFacturar)
                    return "Habilitado";

                return "Bloqueado";
            }
        }

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
