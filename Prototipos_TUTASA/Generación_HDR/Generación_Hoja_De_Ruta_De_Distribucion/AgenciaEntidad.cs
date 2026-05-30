using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class AgenciaEntidad
    {
        public int IdAgencia { get; set; }
        public string RazonSocial { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Piso { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public CentroDistribucionEntidad CD { get; set; }
    }
}
