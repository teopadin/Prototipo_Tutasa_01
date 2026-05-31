using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.Imposición_Agencia
{
    internal class RendicionAgenciaEntidad
    {
        public AgenciaEntidad Agencia { get; set; }
        public ClienteEntidad Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public TipoBulto TipoBulto { get; set; }
        public int CantidadBultos { get; set; }
        public string NroGuia { get; set; }
    }
}
