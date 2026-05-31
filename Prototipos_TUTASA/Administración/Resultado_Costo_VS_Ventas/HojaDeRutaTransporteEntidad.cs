using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class HojaDeRutaTransporteEntidad
    {
        public int NroHDR { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaDespacho { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public ServicioMediaDistanciaEntidad Servicio { get; set; }
        public List<GuiaResultadoEntidad> Guias { get; set; }

        public HojaDeRutaTransporteEntidad()
        {
            Guias = new List<GuiaResultadoEntidad>();
        }
    }
}
