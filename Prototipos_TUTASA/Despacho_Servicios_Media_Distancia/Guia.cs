using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TiposBulto TipoBulto { get; set; }
        public EstadoGuia Estado { get; set; }
        public Cliente ClienteRemitente { get; set; }
        public Destinatario DestinatarioFinal { get; set; }
    }
}
