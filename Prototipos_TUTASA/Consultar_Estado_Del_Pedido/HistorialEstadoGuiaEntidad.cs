using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    public class HistorialEstadoGuiaEntidad
    {
        public DateTime FechaCambio { get; set; }
        public EstadoGuia Estado { get; set; }
        public UbicacionGuia Donde { get; set; }
    }
}
