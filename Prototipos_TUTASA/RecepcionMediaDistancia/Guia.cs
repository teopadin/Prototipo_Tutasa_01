using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TiposBulto TipoBulto { get; set; }
        public ModalidadEntrega Modalidad { get; set; }
        public EstadoGuia Estado { get; set; }
        public CentroDeDistribucion CDOrigen { get; set; }
    }
}
