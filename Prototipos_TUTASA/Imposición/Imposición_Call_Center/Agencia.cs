using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.ImposicionCallCenter_v2
{
    internal class Agencia
    {
        public int idAgencia { get; set; }
        public string razonSocial { get; set; }
        public CentroDistribucion CD { get; set; }
    }
}
