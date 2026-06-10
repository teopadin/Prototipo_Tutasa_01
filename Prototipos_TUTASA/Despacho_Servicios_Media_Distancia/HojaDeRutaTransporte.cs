using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    // Entidad de soporte para la pantalla (Hoja de Ruta de Transporte)
    internal class HojaDeRutaTransporte
    {
        public int NroHDR { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }

        public int IdServicio { get; set; }
        public int IdCDDestino { get; set; }
        public List<Guia> DetalleGuias { get; set; }

        public override string ToString()
        {
            return " " + NroHDR;
        }
    }
}