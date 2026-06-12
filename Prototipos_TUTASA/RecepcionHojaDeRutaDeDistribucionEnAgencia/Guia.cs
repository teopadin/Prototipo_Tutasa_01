using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public int idAgenciaDestino { get; set; }

        public EstadoGuiaEnum estado { get; set; }
    }
}
