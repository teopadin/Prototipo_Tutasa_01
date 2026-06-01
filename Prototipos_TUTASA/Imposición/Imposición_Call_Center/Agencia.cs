using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.ImposicionCallCenter_v2
{
    internal class Agencia
    {
        public int IdAgencia { get; set; }
        public string RazonSocial { get; set; }
        public CentroDistribucion CD { get; set; }
    }
}
