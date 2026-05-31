using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class GuiaEntidad
    {
        public string NroGuia { get; set; } // En el diagrama es string
        public TiposBulto TipoBulto { get; set; }
        public EstadoGuia Estado { get; set; }

        // Relaciones simplificadas basadas en tu diagrama
        public ClienteEntidad ClienteRemitente { get; set; }
        public DestinatarioEntidad DestinatarioFinal { get; set; }
    }
}
