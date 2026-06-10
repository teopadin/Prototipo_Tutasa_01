using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ServicioMediaDistancia
    {
        public string idServicio { get; set; }
        public int idEmpresa { get; set; }
        public List<int> detalleHDRs { get; set; }

        public ServicioMediaDistancia()
        {
            detalleHDRs = new List<int>();
        }
    }
}
