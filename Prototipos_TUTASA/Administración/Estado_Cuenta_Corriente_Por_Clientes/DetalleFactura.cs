using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int NroFactura { get; set; }
        public string NroGuia { get; set; }
        public decimal Importe { get; set; }
    }
}
