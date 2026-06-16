 using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ServicioMediaDistancia
    {
        public string idServicio { get; set; }
        public int idEmpresa { get; set; }
        public DateTime? fechaLlegada { get; set; }
        public DateTime? fechaRecepcion { get; set; }
        public int idCDOrigen { get; set; }
        public int idCDDestino { get; set; }
        public List<int> DetalleHDRs { get; set; } = new List<int>();
    }
}
