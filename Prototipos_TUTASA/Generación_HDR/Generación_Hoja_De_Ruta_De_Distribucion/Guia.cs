using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public ModalidadEntregaEnum modalidadEntrega { get; set; }
        public EstadoGuiaEnum estado { get; set; }
        public int idCDOrigen { get; set; }
        public int idCDDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }  // null si es Retiro en Agencia
        public int? idAgenciaDestino { get; set; }            // null si es Puerta a Puerta
    }
}