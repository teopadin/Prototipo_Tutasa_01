using System;
using System.Collections.Generic;
using System.Text;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class HDRRetiro
    {
        public int NroHDR { get; set; }
        public int DniTransportistaAsignado { get; set; }
        public EstadoHDR Estado { get; set; }
        public MotivoNoCumplidaRetiro? MotivoNoCumplida { get; set; }
        public List<DetalleGuiasARetirar> Detalles { get; set; } = new List<DetalleGuiasARetirar>();
    }
}
 