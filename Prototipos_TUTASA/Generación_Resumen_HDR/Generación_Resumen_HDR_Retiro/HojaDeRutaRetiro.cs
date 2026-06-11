using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.ClasesResumenHDRRetiro
{
    internal class HojaDeRutaRetiro
    {
        public int NroHDR { get; set; }
        public DateTime Fecha { get; set; }
        public int dniTransportistaAsignado { get; set; }
        public List<Cliente> DetalleGuias { get; set; }
        public EstadoHojaDeRutaEnum estado { get; set; }

        public HojaDeRutaRetiro()
        {
            DetalleGuias = new List<Cliente>();
        }
    }
}
