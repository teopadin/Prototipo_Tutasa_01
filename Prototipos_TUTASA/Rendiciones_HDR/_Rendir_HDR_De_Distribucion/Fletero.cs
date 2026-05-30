using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class Fletero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
