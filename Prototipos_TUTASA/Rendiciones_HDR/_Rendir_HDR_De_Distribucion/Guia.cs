using System;
using System.Collections.Generic;
using System.Text;
using Prototipos_TUTASA.RecepcionMediaDistancia;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public ModalidadEntregaEnum ModalidadEntrega { get; set; }
    }
}
