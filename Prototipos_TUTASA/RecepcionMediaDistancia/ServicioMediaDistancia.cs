using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class ServicioMediaDistancia
    {
        public int IdServicio { get; set; }
        public EmpresaTransporte EmpresaTransporte { get; set; }
        public DateTime? FechaDespacho { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public List<HojaDeRutaTransporte> HDRs { get; set; }
    }
}
