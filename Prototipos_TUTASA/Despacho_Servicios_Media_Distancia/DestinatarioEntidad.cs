using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class DestinatarioEntidad
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Propiedad auxiliar para mostrar en la grilla fácilmente
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
