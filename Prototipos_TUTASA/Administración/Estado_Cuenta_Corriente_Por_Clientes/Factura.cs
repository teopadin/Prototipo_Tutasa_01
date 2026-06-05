using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class Factura
    {
        public int NroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> Detalles { get; set; }

        public decimal ImporteTotal
        {
            get { return Detalles.Sum(d => d.Importe); }
        }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }
    }
}
