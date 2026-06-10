using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.Imposición_Agencia
{
    internal class Agencia
    {
        public int idAgencia { get; set; }
        public string razonSocial { get; set; }
        public CentroDistribucion CD { get; set; }
    }
}

