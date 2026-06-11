using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class HojaDeRutaTransporte
    {
        public int NroHDR { get; set; }
        public EstadoHojaDeRutaEnum estado { get; set; }
        public List<Guia> DetalleGuias { get; set; }
    }
}
