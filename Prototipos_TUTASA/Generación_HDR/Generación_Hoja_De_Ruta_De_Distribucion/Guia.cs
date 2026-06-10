using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class Guia
    {
        public string nroGuia { get; set; }
        public DateTime fechaImposicion { get; set; }
        public ModalidadEntregaEnum ModalidadEntrega { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public CentroDistribucion idCDOrigen { get; set; }
        public CentroDistribucion idCDDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }  // null si es Retiro en Agencia
        public Agencia AgenciaGuia { get; set; }            // null si es Puerta a Puerta
    }
}