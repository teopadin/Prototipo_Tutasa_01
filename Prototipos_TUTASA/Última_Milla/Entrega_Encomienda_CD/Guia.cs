using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_CD
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public int idCDDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }
    }
}
