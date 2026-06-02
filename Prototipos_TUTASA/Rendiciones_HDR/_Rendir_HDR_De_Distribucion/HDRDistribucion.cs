using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class HDRDistribucion
    {
        public int NroHDR { get; set; }
        public int DniTransportistaAsignado { get; set; }
        public EstadoHDR Estado { get; set; }
        public MotivoNoCumplidaDistribucion? MotivoNoCumplida { get; set; }
        public List<DetalleGuiasADistribuir> DetalleGuias { get; set; } = new List<DetalleGuiasADistribuir>();
    }
}
