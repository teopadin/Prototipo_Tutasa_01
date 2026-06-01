using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public DateTime FechaImposicion { get; set; }
        public TipoBulto TipoBulto { get; set; }
        public EstadoGuia Estado { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public CentroDistribucion CdDestino { get; set; }

        public int EquivalenteS
        {
            get
            {
                switch (TipoBulto)
                {
                    case TipoBulto.S: return 1;
                    case TipoBulto.M: return 2;
                    case TipoBulto.L: return 4;
                    case TipoBulto.XL: return 8;
                    default: return 0;
                }
            }
        }
    }
}
