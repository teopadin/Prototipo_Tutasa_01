using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
