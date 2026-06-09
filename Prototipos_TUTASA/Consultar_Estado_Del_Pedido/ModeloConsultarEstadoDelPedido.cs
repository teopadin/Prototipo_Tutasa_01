using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal class ModeloConsultarEstadoDelPedido
    {
        private List<Guia> guias = new List<Guia>
        {
            // Guía AG01-0001 - Recorrido completo entregada en agencia
                new Guia
                {
                    NroGuia = "AG01-0001",
                    Historial = new List<HistorialEstadoGuia>
                {
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 10), Estado = EstadoGuiaEnum.Impuesta, Donde = "En Agencia Caballito" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 11), Estado = EstadoGuiaEnum.IncluidaEnHDRRetiro, Donde = "En Agencia Caballito" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 12), Estado = EstadoGuiaEnum.Retirada, Donde = "Con transportista Juan Pérez" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 13), Estado = EstadoGuiaEnum.Admitida, Donde = "En CD Buenos Aires" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 14), Estado = EstadoGuiaEnum.PendienteDeDespacho, Donde = "En CD Buenos Aires" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 15), Estado = EstadoGuiaEnum.EnTransito, Donde = "En servicio Buenos Aires - Córdoba" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 17), Estado = EstadoGuiaEnum.EnCDDestino, Donde = "En CD Córdoba" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 18), Estado = EstadoGuiaEnum.EnDistribucion, Donde = "Con transportista María González" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 19), Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia, Donde = "En Agencia Nueva Córdoba" },
                    new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 21), Estado = EstadoGuiaEnum.Entregada, Donde = "En Agencia Nueva Córdoba" }
                }
                },
                // Guía CD02-0002 - Retiro en CD destino
                new Guia
                {
                    NroGuia = "CD02-0002",
                    Historial = new List<HistorialEstadoGuia>
                    {
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 5), Estado = EstadoGuiaEnum.Impuesta, Donde = "En CD Córdoba" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 6), Estado = EstadoGuiaEnum.Admitida, Donde = "En CD Córdoba" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 7), Estado = EstadoGuiaEnum.PendienteDeDespacho, Donde = "En CD Córdoba" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 8), Estado = EstadoGuiaEnum.EnTransito, Donde = "En servicio Córdoba - Buenos Aires" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 10), Estado = EstadoGuiaEnum.EnCDDestino, Donde = "En CD Buenos Aires" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 11), Estado = EstadoGuiaEnum.PendienteDeRetiroEnCD, Donde = "En CD Buenos Aires" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 4, 13), Estado = EstadoGuiaEnum.Entregada, Donde = "En CD Buenos Aires" }
                    }
                },
                // Guía CD03-0003 - Cancelada
                new Guia
                {
                    NroGuia = "CD03-0003",
                    Historial = new List<HistorialEstadoGuia>
                    {
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 1), Estado = EstadoGuiaEnum.Impuesta, Donde = "En domicilio del cliente Av. San Martín 1234, Mendoza" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 2), Estado = EstadoGuiaEnum.IncluidaEnHDRRetiro, Donde = "En domicilio del cliente Av. San Martín 1234, Mendoza" },
                        new HistorialEstadoGuia { FechaCambio = new DateTime(2026, 5, 3), Estado = EstadoGuiaEnum.Cancelada, Donde = "Con transportista Pedro López" }
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
        public string TextoEstado(EstadoGuiaEnum estado)
        {
            if (estado == EstadoGuiaEnum.Impuesta) return "Impuesta";
            if (estado == EstadoGuiaEnum.IncluidaEnHDRRetiro) return "Incluida en HDR de retiro";
            if (estado == EstadoGuiaEnum.Retirada) return "Retirada";
            if (estado == EstadoGuiaEnum.Admitida) return "Admitida";
            if (estado == EstadoGuiaEnum.PendienteDeDespacho) return "Pendiente de despacho";
            if (estado == EstadoGuiaEnum.EnTransito) return "En tránsito";
            if (estado == EstadoGuiaEnum.EnCDDestino) return "En CD destino";
            if (estado == EstadoGuiaEnum.EnDistribucion) return "En distribución";
            if (estado == EstadoGuiaEnum.PendienteDeRetiroEnAgencia) return "Pendiente de retiro en agencia";
            if (estado == EstadoGuiaEnum.PendienteDeRetiroEnCD) return "Pendiente de retiro en CD";
            if (estado == EstadoGuiaEnum.Entregada) return "Entregada";
            if (estado == EstadoGuiaEnum.Cancelada) return "Cancelada";
            return "";
        }
    }
}
