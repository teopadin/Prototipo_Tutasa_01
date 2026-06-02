using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_CD
{
    internal class Guia
    {
        public string NroGuia { get; set; } = string.Empty;
        public EstadoGuiaEnum Estado { get; set; }
        public CentroDistribucion CdDestino { get; set; } = null!;
        public DestinatarioGuia Destinatario { get; set; } = null!;
        public DateTime FechaEntrega { get; set; }
        public List<HistorialEstadoGuia> Historial { get; set; } = new List<HistorialEstadoGuia>();
    }
}
