using Prototipos_TUTASA.Generación_HDR.Generacion_Hoja_De_Ruta_De_Transporte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class HojaDeRutaTransporte
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public CentroDistribucion CdDestino { get; set; }
        public ServicioMediaDistancia Servicio { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public EstadoHojaDeRutaTransporte Estado { get; set; }
    }
}
