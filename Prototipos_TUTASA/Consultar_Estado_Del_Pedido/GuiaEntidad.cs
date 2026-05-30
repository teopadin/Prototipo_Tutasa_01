using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    public class GuiaEntidad
    {
        public string NroGuia { get; set; }
        public EstadoGuia Estado { get; set; }
        public List<EstadoGuia> Estados { get; set; }
    }
}
