using Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia;
using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.Entrega_Agencia
{
    public class ModeloEntregaAgencia
    {
        public AgenciaEntidad AgenciaActual { get; }
        private readonly List<GuiaEntidad> guias;
        private readonly List<ReciboEntregaEntidad> recibos = new List<ReciboEntregaEntidad>();

        public ModeloEntregaAgencia()
        {
            var agenciaCapital = new AgenciaEntidad { IdAgencia = 1, Nombre = "Capital y GBA" };
            var agenciaCentro = new AgenciaEntidad { IdAgencia = 2, Nombre = "Centro - Córdoba" };

            AgenciaActual = agenciaCapital;

            guias = new List<GuiaEntidad>
            {
                new GuiaEntidad
                {
                    NroGuia = "CD02-0002",
                    Estado = EstadoGuia.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioEntidad { Nombre = "Ana", Apellido = "Pérez", Dni = 40123456 }
                },
                new GuiaEntidad
                {
                    NroGuia = "CD01-0007",
                    Estado = EstadoGuia.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioEntidad { Nombre = "Juan", Apellido = "Rodríguez", Dni = 41234567 }
                },
                new GuiaEntidad
                {
                    NroGuia = "CD03-0001",
                    Estado = EstadoGuia.EnDistribucion,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioEntidad { Nombre = "María", Apellido = "González", Dni = 42345678 }
                },
                new GuiaEntidad
                {
                    NroGuia = "CD02-0009",
                    Estado = EstadoGuia.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCentro,
                    Destinatario = new DestinatarioEntidad { Nombre = "Carlos", Apellido = "López", Dni = 43567890 }
                }
            };
        }

        public GuiaEntidad BuscarGuia(string nroGuia)
        {
            return guias.Find(g => string.Equals(g.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase));
        }

        public void RegistrarEntrega(GuiaEntidad guia, string nombre, string apellido, string dni)
        {
            var recibo = new ReciboEntregaEntidad
            {
                NroGuia = guia.NroGuia,
                FechaEntrega = DateTime.Now,
                NombreRetira = nombre,
                ApellidoRetira = apellido,
                DniRetira = dni,
                Agencia = AgenciaActual.Nombre
            };

            guia.Estado = EstadoGuia.Entregada;
            recibos.Add(recibo);
        }
    }
}
