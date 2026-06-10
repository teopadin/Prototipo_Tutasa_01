using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class HojaDeRutaDistribucion
    {
        public int NroHDR { get; set; }
        public int DniTransportistaAsignado { get; set; }
        public string Destinatario { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }

        public string Piso { get; set; }
        public string CP { get; set; }
        public EstadoHojaDeRutaEnum Estado { get; set; }
        public MotivoNoCumplidaDistribucionEnum? MotivoNoCumplida { get; set; }

        public List<string> DetalleGuias { get; set; }
    }
}
