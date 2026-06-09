using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.ResultadoCostoVSVentas_v2
{
    internal class ServicioMediaDistancia
    {
        public string IdServicio { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int CapacidadDisponible { get; set; }
        public int IdCDOrigen { get; set; }
        public int IdCDDestino { get; set; }
        public List<int> DetalleHDRs { get; set; }

        public ServicioMediaDistancia()
        {
            DetalleHDRs = new List<int>();
        }
    }
}
