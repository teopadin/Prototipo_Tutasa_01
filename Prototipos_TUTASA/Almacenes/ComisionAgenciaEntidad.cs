using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Almacenes;

    internal class ComisionAgenciaEntidad
    {
        public int idComision { get; set; }
        public int idAgencia { get; set; }
        public Auxiliares.TiposBultoEnum TipoBulto { get; set; }
        public decimal MontoPorImposicion { get; set; }
        public decimal MontoPorEntrega { get; set; }
    }
