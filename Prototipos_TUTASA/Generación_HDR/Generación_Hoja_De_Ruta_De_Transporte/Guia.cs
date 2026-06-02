using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public DateTime FechaImposicion { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public CentroDistribucion CdDestino { get; set; }

        public int EquivalenteS
        {
            get
            {
                switch (TipoBulto)
                {
                    case TiposBultoEnum.S: return 1;
                    case TiposBultoEnum.M: return 2;
                    case TiposBultoEnum.L: return 4;
                    case TiposBultoEnum.XL: return 8;
                    default: return 0;
                }
            }
        }
    }
}
