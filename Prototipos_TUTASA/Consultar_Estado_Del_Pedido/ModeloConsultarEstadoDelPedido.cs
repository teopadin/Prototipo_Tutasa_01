using Prototipos_TUTASA.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
{
    internal class ModeloConsultarEstadoDelPedido
    {
        public List<Guia> Guias { get; set; }

        public ModeloConsultarEstadoDelPedido()
        {
            Guias = new List<Guia>();
            foreach (var guiaEntidad in GuiaAlmacen.Guias)
            {
                var guia = new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    Historial = new List<HistorialEstadoGuia>()
                };

                foreach (var histEntidad in guiaEntidad.Historial)
                {
                    guia.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = histEntidad.FechaCambio,
                        Estado = (EstadoGuiaEnum)histEntidad.Estado,
                        Donde = histEntidad.Donde
                    });
                }

                Guias.Add(guia);
            }
        }

        // Busca la guía por número y devuelve su historial. Si no la encuentra, devuelve null.
        public List<HistorialEstadoGuia> ConsultarEstado(string nroGuia)
        {
            foreach (Guia guia in Guias)
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
