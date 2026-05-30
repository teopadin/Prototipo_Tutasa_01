using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    public class GuiaEntidad
    {
        public string NroGuia { get; set; }
        public int IdCliente { get; set; }
        public int IdCDDestino { get; set; }
        public int IdCDAdmision { get; set; }
        public int DniDestinatario { get; set; }
        public TiposBulto TipoBulto { get; set; }
        public ModalidadesEntrega ModalidadEntrega { get; set; }
        public EstadoGuia Estado { get; set; }
        public List<HistorialEstadoGuiaEntidad> Historial { get; set; }
    }
}