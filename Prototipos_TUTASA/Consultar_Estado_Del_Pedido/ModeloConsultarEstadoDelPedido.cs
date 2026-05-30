using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal partial class ModeloConsultarEstadoDelPedido
    {
        private List<GuiaEntidad> guias = new List<GuiaEntidad>
        {
            // Guía CD01-0001 - Recorrido completo entregada en agencia
            new GuiaEntidad
            {
                NroGuia = "AG01-0001",
                Estado = EstadoGuia.Entregada,
                Historial = new List<HistorialEstadoGuiaEntidad>
                {
                        new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 10), Estado = EstadoGuia.Impuesta, Donde = UbicacionGuia.EnAgencia },
                        new HistorialEstadoGuiaEntidad { FechaCambio = new DateTime(2026, 5, 11), Estado = EstadoGuia.PendienteDeRetiroPorTransportista, Donde = UbicacionGuia.EnAgencia },
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
            // Guía CD02-0002 - Retiro en CD destino
            new GuiaEntidad
            {
                NroGuia = "CD02-0002",
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
            // Guía AG05-0003 - Cancelada
            new GuiaEntidad
            {
                NroGuia = "AG05-0003",
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
        public string TextoEstado(EstadoGuia estado)
        {
            if (estado == EstadoGuia.Impuesta) return "Impuesta";
            if (estado == EstadoGuia.PendienteDeRetiroPorTransportista) return "Pendiente de retiro por transportista";
            if (estado == EstadoGuia.Retirada) return "Retirada";
            if (estado == EstadoGuia.Admitida) return "Admitida";
            if (estado == EstadoGuia.PendienteDeDespacho) return "Pendiente de despacho";
            if (estado == EstadoGuia.EnTransito) return "En tránsito";
            if (estado == EstadoGuia.EnCDDestino) return "En CD destino";
            if (estado == EstadoGuia.EnDistribucion) return "En distribución";
            if (estado == EstadoGuia.PendienteDeRetiroEnAgencia) return "Pendiente de retiro en agencia";
            if (estado == EstadoGuia.PendienteDeRetiroEnCD) return "Pendiente de retiro en CD";
            if (estado == EstadoGuia.Entregada) return "Entregada";
            if (estado == EstadoGuia.Cancelada) return "Cancelada";
            return "";
        }

        public string TextoUbicacion(UbicacionGuia ubicacion)
        {
            if (ubicacion == UbicacionGuia.EnCDOrigen) return "En CD origen";
            if (ubicacion == UbicacionGuia.ConTransportistaLocal) return "Con transportista local";
            if (ubicacion == UbicacionGuia.EnServicioMediaDistancia) return "En servicio media distancia";
            if (ubicacion == UbicacionGuia.EnCDDestino) return "En CD destino";
            if (ubicacion == UbicacionGuia.EnAgencia) return "En agencia";
            return "";
        }
    }
}
