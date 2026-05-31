using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class HDRTransporte
    {
        public int NroHDR { get; set; }
        public string CdDestino { get; set; }
        public string Empresa { get; set; }
        public string IdServicio { get; set; }
        public EstadoHDRTransporte Estado { get; set; }
        public List<GuiaDespacho> Guias { get; set; } = new List<GuiaDespacho>();

        // Para que el ComboBox lo muestre bien
        public override string ToString()
        {
            return "HDR " + NroHDR;
        }
    }
}
