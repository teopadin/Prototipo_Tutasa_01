using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class HojaDeRutaRetiroEntidad
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public CentroDeDistribucionEntidad CdEmisor { get; set; }
        public AgenciaEntidad Agencia { get; set; }
        public TransportistaLocalEntidad Transportista { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public EstadoHojaDeRuta Estado { get; set; }
    }
}
