using System;
using System.Collections.Generic;
using System.Globalization;

namespace Prototipos_TUTASA
{
    internal class ModeloEntregaEnCD
    {
        public CentroDistribucionEntregaCD CdActual { get; }
        private readonly List<GuiaEntregaCD> guias;
        private readonly List<ReciboEntregaCD> recibos = new List<ReciboEntregaCD>();

        public ModeloEntregaEnCD()
        {
            var cdCapital = new CentroDistribucionEntregaCD { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucionEntregaCD { IdCD = 2, Nombre = "Centro - Córdoba" };

            CdActual = cdCapital;

            guias = new List<GuiaEntregaCD>
            {
                new GuiaEntregaCD
                {
                    NroGuia = "CD02-0002",
                    Estado = EstadoGuiaEntregaCD.PendienteDeRetiroEnCD,
                    CdDestino = cdCapital,
                    Destinatario = new DestinatarioEntregaCD { Nombre = "Ana", Apellido = "Pérez", Dni = 40123456 }
                },
                new GuiaEntregaCD
                {
                    NroGuia = "CD01-0007",
                    Estado = EstadoGuiaEntregaCD.PendienteDeRetiroEnCD,
                    CdDestino = cdCapital,
                    Destinatario = new DestinatarioEntregaCD { Nombre = "Juan", Apellido = "Rodríguez", Dni = 41234567 }
                },
                new GuiaEntregaCD
                {
                    NroGuia = "CD03-0001",
                    Estado = EstadoGuiaEntregaCD.EnDistribucion,
                    CdDestino = cdCapital,
                    Destinatario = new DestinatarioEntregaCD { Nombre = "María", Apellido = "González", Dni = 42345678 }
                },
                new GuiaEntregaCD
                {
                    NroGuia = "CD02-0009",
                    Estado = EstadoGuiaEntregaCD.PendienteDeRetiroEnCD,
                    CdDestino = cdCentro,
                    Destinatario = new DestinatarioEntregaCD { Nombre = "Carlos", Apellido = "López", Dni = 43567890 }
                }
            };
        }

        public bool BuscarGuia(string nroGuia, out GuiaEntregaCD guiaEncontrada)
        {
            foreach (GuiaEntregaCD guia in guias)
            {
                if (string.Equals(guia.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase))
                {
                    guiaEncontrada = guia;
                    return true;
                }
            }

            guiaEncontrada = new GuiaEntregaCD();
            return false;
        }

        public bool CoincideDestinatario(GuiaEntregaCD guia, string nombre, string apellido, int dni)
        {
            return guia.Destinatario.Dni == dni
                && CoincideTexto(guia.Destinatario.Nombre, nombre)
                && CoincideTexto(guia.Destinatario.Apellido, apellido);
        }

        public ReciboEntregaCD RegistrarEntrega(GuiaEntregaCD guia, string nombre, string apellido, int dni)
        {
            DateTime fechaEntrega = DateTime.Now;

            var recibo = new ReciboEntregaCD
            {
                NroRecibo = recibos.Count + 1,
                NroGuia = guia.NroGuia,
                FechaEntrega = fechaEntrega,
                NombreRetira = nombre,
                ApellidoRetira = apellido,
                DniRetira = dni
            };

            guia.Estado = EstadoGuiaEntregaCD.Entregada;
            guia.FechaEntrega = fechaEntrega;
            guia.Historial.Add(new HistorialEstadoGuiaEntregaCD
            {
                FechaCambio = fechaEntrega,
                Estado = guia.Estado
            });
            recibos.Add(recibo);
            return recibo;
        }

        private static bool CoincideTexto(string textoRegistrado, string textoIngresado)
        {
            return CultureInfo.CurrentCulture.CompareInfo.Compare(
                textoRegistrado.Trim(),
                textoIngresado.Trim(),
                CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0;
        }
    }
}
