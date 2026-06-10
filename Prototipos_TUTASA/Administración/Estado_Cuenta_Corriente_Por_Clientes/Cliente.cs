using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class Cliente
    {
        public int idCliente { get; set; }
        public long cuit { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public string calle { get; set; }
        public int altura { get; set; }
        public string piso { get; set; }
        public string codigoPostal { get; set; }
        public string ciudad { get; set; }
    }
}
