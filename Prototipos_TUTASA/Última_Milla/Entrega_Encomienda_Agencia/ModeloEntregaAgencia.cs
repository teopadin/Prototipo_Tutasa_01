using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ModeloEntregaAgencia
    {
        public Agencia AgenciaActual { get; }
        private readonly List<Guia> guias;
        private readonly List<ReciboEntrega> recibos = new List<ReciboEntrega>();

        public ModeloEntregaAgencia()
        {
            var agenciaCapital = new Agencia { IdAgencia = 1, Nombre = "Capital y GBA" };
            var agenciaCentro = new Agencia { IdAgencia = 2, Nombre = "Centro - Córdoba" };

            AgenciaActual = agenciaCapital;

            guias = new List<Guia>
            {
                new Guia
                {
                    NroGuia = "CD02-0002",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioGuia { Nombre = "Ana", Apellido = "Pérez", Dni = 40123456 }
                },
                new Guia
                {
                    NroGuia = "CD01-0007",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioGuia { Nombre = "Juan", Apellido = "Rodríguez", Dni = 41234567 }
                },
                new Guia
                {
                    NroGuia = "CD03-0001",
                    Estado = EstadoGuiaEnum.Entregada,
                    AgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioGuia { Nombre = "María", Apellido = "González", Dni = 42345678 }
                },
                new Guia
                {
                    NroGuia = "CD02-0009",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    AgenciaDestino = agenciaCentro,
                    Destinatario = new DestinatarioGuia { Nombre = "Carlos", Apellido = "López", Dni = 43567890 }
                }
            };
        }

        public Guia BuscarGuia(string nroGuia)
        {
            return guias.Find(g => string.Equals(g.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase));
        }

        public void RegistrarEntrega(Guia guia, string nombre, string apellido, string dni)
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
