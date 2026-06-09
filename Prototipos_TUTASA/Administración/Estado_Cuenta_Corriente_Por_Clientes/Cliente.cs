using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public long Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Piso { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
