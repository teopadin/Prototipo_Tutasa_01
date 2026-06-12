using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public ModalidadEntregaEnum modalidadEntrega { get; set; }
        public EstadoGuiaEnum estado { get; set; }
        public int idCDOrigen { get; set; }
        public int idCDActual { get; set; }
        public int idCDDestino { get; set; }

    }
}
