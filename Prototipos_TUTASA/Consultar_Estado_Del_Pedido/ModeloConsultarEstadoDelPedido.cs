using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal class ModeloConsultarEstadoDelPedido
    {
        private List<Guia> guias = new List<Guia>
        {
 // Guía CD01-0001 - Recorrido completo entregada en agencia
            new Guia
            {
                NroGuia = "AG01-0001",
                Historial = new List<HistorialEstadoGuia>
                {
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 10), Estado = EstadoGuia.Impuesta, Donde = "En agencia" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 11), Estado = EstadoGuia.IncluidaEnHDRRetiro, Donde = "En agencia" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 12), Estado = EstadoGuia.Retirada, Donde = "Con transportista local" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 13), Estado = EstadoGuia.Admitida, Donde = "En CD origen" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 14), Estado = EstadoGuia.PendienteDeDespacho, Donde = "En CD origen" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 15), Estado = EstadoGuia.EnTransito, Donde = "En servicio media distancia" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 17), Estado = EstadoGuia.EnCDDestino, Donde = "En CD destino" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 18), Estado = EstadoGuia.EnDistribucion, Donde = "Con transportista local" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 19), Estado = EstadoGuia.PendienteDeRetiroEnAgencia, Donde = "En agencia" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 21), Estado = EstadoGuia.Entregada, Donde = "En agencia" }
                }
            },
            // Guía CD02-0002 - Retiro en CD destino
            new Guia
            {
                NroGuia = "CD02-0002",
                Historial = new List<HistorialEstadoGuia>
                {
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 5), Estado = EstadoGuia.Impuesta, Donde = "En CD origen" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 6), Estado = EstadoGuia.Admitida, Donde = "En CD origen" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 7), Estado = EstadoGuia.PendienteDeDespacho, Donde = "En CD origen" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 8), Estado = EstadoGuia.EnTransito, Donde = "En servicio media distancia" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 10), Estado = EstadoGuia.EnCDDestino, Donde = "En CD destino" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 11), Estado = EstadoGuia.PendienteDeRetiroEnCD, Donde = "En CD destino" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 13), Estado = EstadoGuia.Entregada, Donde = "En CD destino" }
                }
            },
            // Guía CD0-0003 - Cancelada
            new Guia
            {
                NroGuia = "CD03-0003",
                Historial = new List<HistorialEstadoGuia>
                {
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 1), Estado = EstadoGuia.Impuesta, Donde = "En domicilio" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 2), Estado = EstadoGuia.IncluidaEnHDRRetiro, Donde = "En domicilio" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 3), Estado = EstadoGuia.Cancelada, Donde = "Con transportista local" }
                }
            }

        };

        // Busca la guía por número y devuelve su historial. Si no la encuentra, devuelve null.
        public List<HistorialEstadoGuia> ConsultarEstado(string nroGuia)
        {
            foreach (Guia guia in guias)
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
            if (estado == EstadoGuia.IncluidaEnHDRRetiro) return "Incluida en HDR de retiro";
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
    }
}
