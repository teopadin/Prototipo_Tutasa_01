using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    // Entidad de soporte para la pantalla (Hoja de Ruta de Transporte)
    internal class HojaDeRutaTransporte
    {
        public int nroHDR { get; set; }
        public EstadoHojaDeRutaEnum estado { get; set; }

        public int idServicio { get; set; }
        public int idCDDestino { get; set; }
        public List<Guia> DetalleGuias { get; set; }

        public override string ToString()
        {
            return " " + nroHDR;
        }
    }
}