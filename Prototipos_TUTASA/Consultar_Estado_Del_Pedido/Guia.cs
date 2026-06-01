using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public List<HistorialEstadoGuia> Historial { get; set; }
    }
}
