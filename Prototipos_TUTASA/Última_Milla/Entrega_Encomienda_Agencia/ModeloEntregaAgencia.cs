using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ModeloEntregaAgencia
    {
        public ClaseAgencia AgenciaActual { get; }
        private readonly List<ClaseGuia> guias;
        private readonly List<ReciboEntrega> recibos = new List<ReciboEntrega>();

        public ModeloEntregaAgencia()
        {
            var agenciaCapital = new ClaseAgencia { IdAgencia = 1, Nombre = "Capital y GBA" };
            var agenciaCentro = new ClaseAgencia { IdAgencia = 2, Nombre = "Centro - Córdoba" };

            AgenciaActual = agenciaCapital;

            guias = new List<ClaseGuia>
            {
                new ClaseGuia
                {
                    NroGuia = "CD02-0002",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new ClaseDestinatario { Nombre = "Ana", Apellido = "Pérez", Dni = 40123456 }
                },
                new ClaseGuia
                {
                    NroGuia = "CD01-0007",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new ClaseDestinatario { Nombre = "Juan", Apellido = "Rodríguez", Dni = 41234567 }
                },
                new ClaseGuia
                {
                    NroGuia = "CD03-0001",
                    Estado = EstadoGuiaEnum.Entregada,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new ClaseDestinatario { Nombre = "María", Apellido = "González", Dni = 42345678 }
                },
                new ClaseGuia
                {
                    NroGuia = "CD02-0009",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCentro,
                    Destinatario = new ClaseDestinatario { Nombre = "Carlos", Apellido = "López", Dni = 43567890 }
                }
            };
        }

        public ClaseGuia BuscarGuia(string nroGuia)
        {
            return guias.Find(g => string.Equals(g.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase));
        }

        public void RegistrarEntrega(ClaseGuia guia, string nombre, string apellido, string dni)
        {
            var recibo = new ReciboEntrega
            {
                NroGuia = guia.NroGuia,
                FechaEntrega = DateTime.Now,
                NombreRetira = nombre,
                ApellidoRetira = apellido,
                DniRetira = dni,
                Agencia = AgenciaActual.Nombre
            };

            guia.Estado = EstadoGuiaEnum.Entregada;
            recibos.Add(recibo);
        }
    }

    internal class ClaseDestinatario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
    }
}
