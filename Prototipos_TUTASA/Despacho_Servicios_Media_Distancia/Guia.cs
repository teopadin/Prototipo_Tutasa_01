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

        // La conexión real con la clase Cliente (la flecha "Es remitente de")
        public Cliente ClienteGuia { get; set; }

        // La conexión real con la clase DestinatarioGuia
        public DestinatarioGuia Destinatario { get; set; }
    }
}
