using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    // Entidad de soporte para la pantalla (Hoja de Ruta de Transporte)
    internal class HDRTransporte
    {
        public int NroHDR { get; set; }
        public EstadoHDR Estado { get; set; }

        public int IdServicio { get; set; }
        public List<Guia> DetalleGuias { get; set; }

        public override string ToString()
        {
            return " " + NroHDR;
        }
    }
}