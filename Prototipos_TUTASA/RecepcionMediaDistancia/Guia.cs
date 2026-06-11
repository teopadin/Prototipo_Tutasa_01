using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public ModalidadEntrega ModalidadEntrega { get; set; }
        public EstadoGuia Estado { get; set; }
        public CentroDistribucion CDOrigen { get; set; }
        public CentroDistribucion CDDestino { get; set; }
        public CentroDistribucion CDActual { get; set; }

    }
}
