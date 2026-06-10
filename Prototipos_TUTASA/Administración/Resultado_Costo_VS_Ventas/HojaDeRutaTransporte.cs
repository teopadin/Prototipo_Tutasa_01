using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class HojaDeRutaTransporte
    {
        public int nroHDR { get; set; }
        public DateTime fechaGeneracion { get; set; }
        public int idCDOrigen { get; set; }
        public int idCDDestino { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }
        public string idServicio { get; set; }
        public List<string> detalleGuias { get; set; }

        public HojaDeRutaTransporte()
        {
            detalleGuias = new List<string>();
        }
    }
}
