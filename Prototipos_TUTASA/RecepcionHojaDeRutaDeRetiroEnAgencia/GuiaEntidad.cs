using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class GuiaEntidad
    {
        public string NroGuia { get; set; }
        public TiposBulto TipoBulto { get; set; }
        public AgenciaEntidad Agencia { get; set; }
    }
}
