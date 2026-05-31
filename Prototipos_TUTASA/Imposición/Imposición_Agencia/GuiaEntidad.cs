using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.Imposición_Agencia
{
    internal class GuiaEntidad
    {
        public string NroGuia { get; set; }
        public DateTime FechaImposicion { get; set; }
        public TipoBulto TipoBulto { get; set; }
        public ModalidadEntrega ModalidadEntrega { get; set; }
        public EstadoGuia Estado { get; set; }
        public CentroDistribucionEntidad CdOrigen { get; set; }
        public CentroDistribucionEntidad CdDestino { get; set; }
        public DestinatarioEntidad Destinatario { get; set; }  // null si es Retiro en Agencia
        public AgenciaEntidad Agencia { get; set; }            // null si es Puerta a Puerta
    }
}
