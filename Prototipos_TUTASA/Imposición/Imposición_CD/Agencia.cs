using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.Imposición_CD
{
    internal class Agencia
    {
        public int IdAgencia { get; set; }
        public string RazonSocial { get; set; }
        public CentroDistribucion CD { get; set; }
    }
}
