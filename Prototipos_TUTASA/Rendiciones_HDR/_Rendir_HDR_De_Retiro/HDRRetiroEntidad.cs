using System;
using System.Collections.Generic;
using System.Text;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class HDRRetiroEntidad
    {
        public int NroHDR { get; set; }
        public int IdFletero { get; set; }
        public string Remitente { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CP { get; set; }
        public EstadoHDR Estado { get; set; }
        public MotivoNoCumplidaRetiro? MotivoNoCumplida { get; set; }
    }
}
