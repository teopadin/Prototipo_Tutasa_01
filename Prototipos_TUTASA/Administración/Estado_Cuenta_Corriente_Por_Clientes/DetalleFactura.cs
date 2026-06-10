using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public int nroFactura { get; set; }
        public string nroGuia { get; set; }
        public decimal tarifaCalculada { get; set; }
    }
}
