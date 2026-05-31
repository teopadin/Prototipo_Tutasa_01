using Prototipos_TUTASA.Generación_HDR.Generacion_Hoja_De_Ruta_De_Transporte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class HojaDeRutaTransporteEntidad
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public CentroDistribucionEntidad CdOrigen { get; set; }
        public CentroDistribucionEntidad CdDestino { get; set; }
        public ServicioMediaDistanciaEntidad Servicio { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public EstadoHojaDeRutaTransporte Estado { get; set; }
    }
}
