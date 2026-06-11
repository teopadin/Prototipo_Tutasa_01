using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    // Entidad de soporte para la pantalla (Hoja de Ruta de Transporte)
    internal class HojaDeRutaTransporte
    {
        public int NroHDR { get; set; }
        public EstadoHojaDeRutaEnum estado { get; set; }
        public DateTime fechaGeneracion { get; set; }
        public string idServicio { get; set; }
        public int idCDDestino { get; set; }
        public List<string> DetalleGuias { get; set; }
        public HojaDeRutaTransporte()
        {
            DetalleGuias = new List<string>();
        }
        public override string ToString()
        {
            return " " + NroHDR;
        }
    }
}