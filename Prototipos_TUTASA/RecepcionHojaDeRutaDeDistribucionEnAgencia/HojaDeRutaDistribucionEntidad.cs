using Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class HojaDeRutaDistribucionEntidad
    {
        public int NroHDR { get; set; }

        public DateTime FechaEmision { get; set; }

        public DateTime FechaRecepcion { get; set; }

        public AgenciaEntidad Agencia { get; set; }

        public TransportistaLocalEntidad Transportista { get; set; }

        public List<GuiaEntidad> Guias { get; set; }

        public EstadoHojaDeRuta Estado { get; set; }
    }
}
