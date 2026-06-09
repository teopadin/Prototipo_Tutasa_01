using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class HojaDeRutaTransporte
    {
        public int NroHDR { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public int IdCDOrigen { get; set; }
        public int IdCDDestino { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }
        public string IdServicio { get; set; }
        public List<string> DetalleGuias { get; set; }

        public HojaDeRutaTransporte()
        {
            DetalleGuias = new List<string>();
        }
    }
}
