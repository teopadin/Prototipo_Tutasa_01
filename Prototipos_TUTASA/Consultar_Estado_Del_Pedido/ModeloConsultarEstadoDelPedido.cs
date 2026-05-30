using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal partial class ModeloConsultarEstadoDelPedido
    {
        private List<GuiaEntidad> guias = new List<GuiaEntidad>
        {
            // Guía 1001 - Recorrido completo entregada en agencia
            new GuiaEntidad
            {
                NroGuia = "CD01-00001",
                Estado = EstadoGuia.Entregada,
                Historial = new List<HistorialEstadoGuiaEntidad>
                {
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 10), Estado = EstadoGuia.Impuesta, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 11), Estado = EstadoGuia.PendienteDeRetiroPorTransportista, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 12), Estado = EstadoGuia.Retirada, Donde = UbicacionGuia.ConTransportistaLocal },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 13), Estado = EstadoGuia.Admitida, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 14), Estado = EstadoGuia.PendienteDeDespacho, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 15), Estado = EstadoGuia.EnTransito, Donde = UbicacionGuia.EnServicioMediaDistancia },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 17), Estado = EstadoGuia.EnCDDestino, Donde = UbicacionGuia.EnCDDestino },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 18), Estado = EstadoGuia.EnDistribucion, Donde = UbicacionGuia.ConTransportistaLocal },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 19), Estado = EstadoGuia.PendienteDeRetiroEnAgencia, Donde = UbicacionGuia.EnAgencia },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 21), Estado = EstadoGuia.Entregada, Donde = UbicacionGuia.EnAgencia }
                }
            },
            // Guía 1002 - Retiro en CD destino
            new GuiaEntidad
            {
                NroGuia = "CD02-00002",
                Estado = EstadoGuia.Entregada,
                Historial = new List<HistorialEstadoGuiaEntidad>
                {
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 5), Estado = EstadoGuia.Impuesta, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 6), Estado = EstadoGuia.Admitida, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 7), Estado = EstadoGuia.PendienteDeDespacho, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 8), Estado = EstadoGuia.EnTransito, Donde = UbicacionGuia.EnServicioMediaDistancia },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 10), Estado = EstadoGuia.EnCDDestino, Donde = UbicacionGuia.EnCDDestino },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 11), Estado = EstadoGuia.PendienteDeRetiroEnCD, Donde = UbicacionGuia.EnCDDestino },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 4, 13), Estado = EstadoGuia.Entregada, Donde = UbicacionGuia.EnCDDestino }
                }
            },
            // Guía 1003 - Cancelada
            new GuiaEntidad
            {
                NroGuia = "AG05-00003",
                Estado = EstadoGuia.Cancelada,
                Historial = new List<HistorialEstadoGuiaEntidad>
                {
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 1), Estado = EstadoGuia.Impuesta, Donde = UbicacionGuia.EnCDOrigen },
                    new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 2), Estado = EstadoGuia.Cancelada, Donde = UbicacionGuia.EnCDOrigen }
                }
            }
        };

        // Busca la guía por número y devuelve su historial. Si no la encuentra, devuelve null.
        public List<HistorialEstadoGuiaEntidad> ConsultarEstado(string nroGuia)
        {
            foreach (GuiaEntidad guia in guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    return guia.Historial;
                }
            }
            return null;
        }
    }
}
