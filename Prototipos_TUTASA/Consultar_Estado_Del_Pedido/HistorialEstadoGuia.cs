using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal class HistorialEstadoGuia
    {
        public DateTime FechaCambio { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public string Donde { get; set; }
    }
}
