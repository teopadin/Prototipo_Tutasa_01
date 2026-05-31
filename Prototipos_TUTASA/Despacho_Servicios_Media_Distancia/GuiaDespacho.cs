using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class GuiaDespacho
    {
        public int NroGuia { get; set; }
        public string Remitente { get; set; }
        public string Destinatario { get; set; }
        public string TipoBulto { get; set; }   // S, M, L, XL
    }
}
