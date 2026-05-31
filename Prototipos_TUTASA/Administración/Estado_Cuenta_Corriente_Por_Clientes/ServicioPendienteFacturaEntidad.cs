using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2
{
    internal class ServicioPendienteFacturaEntidad
    {
        public int IdServicio { get; set; }
        public DateTime Fecha { get; set; }
        public string NroServicioGuia { get; set; }
        public string TipoServicio { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Importe { get; set; }
        public EstadoServicioFacturacion Estado { get; set; }
        public ClienteCuentaCorrienteEntidad Cliente { get; set; }
    }
}
