using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class Factura
    {
        public int nroFactura { get; set; }
        public DateTime fechaEmision { get; set; }
        public int idCliente { get; set; }
        public List<DetalleFactura> detalles { get; set; }

        public decimal ImporteTotal
        {
            get { return detalles.Sum(d => d.importe); }
        }

        public Factura()
        {
            detalles = new List<DetalleFactura>();
        }
    }
}
