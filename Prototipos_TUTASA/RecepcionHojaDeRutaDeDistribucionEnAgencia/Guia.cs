using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TiposBulto TipoBulto { get; set; }
        public Agencia Agencia { get; set; }

        public EstadoGuia Estado { get; set; }
    }
}
