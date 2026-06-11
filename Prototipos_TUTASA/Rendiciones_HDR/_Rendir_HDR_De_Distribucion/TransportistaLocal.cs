using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class TransportistaLocal
    {
        public int dniTransportista { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
