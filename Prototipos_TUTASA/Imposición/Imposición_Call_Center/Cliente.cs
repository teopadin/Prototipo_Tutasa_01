using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.ImposicionCallCenter_v2
{
    internal class Cliente
    {
        public string RazonSocial { get; set; }
        public long CUIT { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Piso { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
    }
}
