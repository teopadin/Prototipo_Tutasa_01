using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class ServicioMediaDistancia
    {
        public int idServicio { get; set; }
        public int idEmpresa { get; set; }
        public DateTime? fechaLlegada { get; set; }
        public DateTime? fechaRecepcion { get; set; }
        public List<int> DetalleHDRs { get; set; }
    }
}
