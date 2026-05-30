using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class HDRDistribucion
    {
        public int NroHDR { get; set; }
        public int IdFletero { get; set; }
        public string Destinatario { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CP { get; set; }
        public EstadoHDR Estado { get; set; }
        public MotivoNoCumplida? MotivoNoCumplida { get; set; }
    }
}
