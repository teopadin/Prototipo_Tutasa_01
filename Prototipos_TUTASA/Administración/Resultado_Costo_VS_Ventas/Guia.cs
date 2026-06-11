using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TarifaCalculadaGuia TarifaCalculada { get; set; }
        public List<HistorialEstadoGuia> Historial { get; set; }
    }
}
