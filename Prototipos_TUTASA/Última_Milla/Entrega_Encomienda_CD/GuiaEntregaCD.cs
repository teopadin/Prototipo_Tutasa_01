using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA
{
    internal class GuiaEntregaCD
    {
        public string NroGuia { get; set; } = string.Empty;
        public EstadoGuiaEntregaCD Estado { get; set; }
        public CentroDistribucionEntregaCD CdDestino { get; set; } = null!;
        public DestinatarioEntregaCD Destinatario { get; set; } = null!;
        public DateTime FechaEntrega { get; set; }
        public List<HistorialEstadoGuiaEntregaCD> Historial { get; set; } = new List<HistorialEstadoGuiaEntregaCD>();
    }
}
