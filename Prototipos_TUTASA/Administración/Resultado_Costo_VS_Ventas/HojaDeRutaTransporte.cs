using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class HojaDeRutaTransporte
    {
        public int NroHDR { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaDespacho { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public ServicioMediaDistancia Servicio { get; set; }
        public List<GuiaResultado> Guias { get; set; }

        public HojaDeRutaTransporte()
        {
            Guias = new List<GuiaResultado>();
        }
    }
}
