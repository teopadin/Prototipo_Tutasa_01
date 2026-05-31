using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class FacturaEntidad
    {
        public int NroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public ClienteCuentaCorrienteEntidad Cliente { get; set; }
        public List<ServicioPendienteFacturaEntidad> ServiciosFacturados { get; set; }
        public decimal ImporteTotal { get; set; }

        public FacturaEntidad()
        {
            ServiciosFacturados = new List<ServicioPendienteFacturaEntidad>();
        }
    }
}
