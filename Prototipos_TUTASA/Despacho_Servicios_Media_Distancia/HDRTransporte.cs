using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    // Entidad de soporte para la pantalla (Hoja de Ruta de Transporte)
    internal class HojaRutaTransporte
    {
        public int NroHDR { get; set; }
        public CentroDistribucion CDDestino { get; set; }
        public string Empresa { get; set; }
        public string IdServicio { get; set; }
        public bool Despachada { get; set; } = false; // Flag simple para el estado de la HDR
        public List<Guia> Guias { get; set; } = new List<Guia>();

        public override string ToString()
        {
            return " " + NroHDR;
        }
    }
}