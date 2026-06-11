using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public int IdCliente { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public EstadoGuiaEnum estado { get; set; }
        public int EquivalenteS { get; set; }

        // La conexión real con la clase DestinatarioGuia
        public DestinatarioGuia Destinatario { get; set; }
    }
}
