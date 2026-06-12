using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class HojaDeRutaRetiro
    {
        public int NroHDR { get; set; }
        public DateTime Fecha { get; set; }
        public int? idAgenciaOrigen { get; set; }
        public int dniTransportistaAsignado { get; set; }
        public List<string> DetalleGuias { get; set; }
        public EstadoHojaDeRutaEnum estado { get; set; }
    }
}
