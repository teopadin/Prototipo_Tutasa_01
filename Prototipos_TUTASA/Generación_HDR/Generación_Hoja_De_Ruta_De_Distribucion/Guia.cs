using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public DateTime FechaImposicion { get; set; }
        public ModalidadEntrega ModalidadEntrega { get; set; }
        public EstadoGuia Estado { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public CentroDistribucion CdDestino { get; set; }
        public Destinatario Destinatario { get; set; }  // null si es Retiro en Agencia
        public Agencia Agencia { get; set; }            // null si es Puerta a Puerta
    }
}