using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class HojaDeRutaRetiro
    {
        public int NroHDR { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public CentroDeDistribucion CdEmisor { get; set; }
        public Agencia Agencia { get; set; }
        public TransportistaLocal Transportista { get; set; }
        public List<Guia> Guias { get; set; }
        public EstadoHojaDeRuta Estado { get; set; }
    }
}
