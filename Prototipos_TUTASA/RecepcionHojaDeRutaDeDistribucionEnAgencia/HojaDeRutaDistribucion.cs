using Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class HojaDeRutaDistribucion
    {
        public int NroHDR { get; set; }

        public DateTime Fecha { get; set; }
        public int idAgenciaDestino { get; set; }

        public int dniTransportistaAsignado { get; set; }

        public List<string> DetalleGuias { get; set; }

        public EstadoHojaDeRutaEnum estado { get; set; }
    }
}
