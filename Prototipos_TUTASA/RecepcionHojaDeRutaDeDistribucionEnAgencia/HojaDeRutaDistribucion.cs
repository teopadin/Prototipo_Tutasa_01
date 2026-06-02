using Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class HojaDeRutaDistribucion
    {
        public int NroHDR { get; set; }


        public DateTime FechaRecepcion { get; set; }

        public Agencia Agencia { get; set; }

        public TransportistaLocal Transportista { get; set; }

        public List<Guia> Guias { get; set; }

        public EstadoHojaDeRuta Estado { get; set; }
    }
}
