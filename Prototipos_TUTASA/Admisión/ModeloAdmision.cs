using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal partial class ModeloAdmision
    {
        // CD desde el que se realiza la admisión (fijo para el prototipo)
        private int idCDAdmisionActual = 1;

        private List<ClienteEntidad> clientes = new List<ClienteEntidad>
        {
            new ClienteEntidad { IdCliente = 100, RazonSocial = "Tecno Distribuciones S.A." },
            new ClienteEntidad { IdCliente = 200, RazonSocial = "Importadora del Sur SRL" },
            new ClienteEntidad { IdCliente = 300, RazonSocial = "Comercial Norte" }
        };

        private List<CentroDistribucionEntidad> cds = new List<CentroDistribucionEntidad>
        {
            new CentroDistribucionEntidad { IdCD = 1, Nombre = "CD Buenos Aires" },
            new CentroDistribucionEntidad { IdCD = 2, Nombre = "CD Córdoba" },
            new CentroDistribucionEntidad { IdCD = 3, Nombre = "CD Mendoza" }
        };

        private List<DestinatarioEntidad> destinatarios = new List<DestinatarioEntidad>
        {
            new DestinatarioEntidad { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
            new DestinatarioEntidad { Dni = 28444555, Nombre = "María", Apellido = "González" },
            new DestinatarioEntidad { Dni = 35777888, Nombre = "Carlos", Apellido = "López" }
        };

        private List<GuiaEntidad> guias = new List<GuiaEntidad>
        {
            // Guía 1: caso general → quedará "Admitida"
            new GuiaEntidad
            {
                NroGuia = "CD01-0001",
                IdCliente = 100,
                IdCDDestino = 2,
                IdCDAdmision = 1,
                DniDestinatario = 30111222,
                TipoBulto = TiposBulto.M,
                ModalidadEntrega = ModalidadesEntrega.PuertaAPuerta,
                Estado = EstadoGuia.Retirada,
                Historial = new List<HistorialEstadoGuiaEntidad>()
            },
            // Guía 2: caso especial → quedará "Pendiente de retiro en CD"
            new GuiaEntidad
            {
                NroGuia = "CD01-0002",
                IdCliente = 200,
                IdCDDestino = 1,
                IdCDAdmision = 1,
                DniDestinatario = 28444555,
                TipoBulto = TiposBulto.S,
                ModalidadEntrega = ModalidadesEntrega.RetiroEnCD,
                Estado = EstadoGuia.Retirada,
                Historial = new List<HistorialEstadoGuiaEntidad>()
            },
            // Guía 3: caso general (mismo CD pero no es Retiro en CD)
            new GuiaEntidad
            {
                NroGuia = "CD01-0003",
                IdCliente = 300,
                IdCDDestino = 1,
                IdCDAdmision = 1,
                DniDestinatario = 35777888,
                TipoBulto = TiposBulto.L,
                ModalidadEntrega = ModalidadesEntrega.PuertaAPuerta,
                Estado = EstadoGuia.Retirada,
                Historial = new List<HistorialEstadoGuiaEntidad>()
            },
            // Guía 4: estado distinto a "Retirada" → no se puede admitir
            new GuiaEntidad
            {
                NroGuia = "CD01-0004",
                IdCliente = 100,
                IdCDDestino = 3,
                IdCDAdmision = 1,
                DniDestinatario = 30111222,
                TipoBulto = TiposBulto.XL,
                ModalidadEntrega = ModalidadesEntrega.RetiroEnAgencia,
                Estado = EstadoGuia.Entregada,
                Historial = new List<HistorialEstadoGuiaEntidad>()
            }
        };

        // Busca una guía por su número. Devuelve null si no existe.
        public GuiaEntidad BuscarGuia(string nroGuia)
        {
            foreach (GuiaEntidad guia in guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    return guia;
                }
            }
            return null;
        }

        // Busca un cliente por su ID.
        public ClienteEntidad BuscarCliente(int idCliente)
        {
            foreach (ClienteEntidad cliente in clientes)
            {
                if (cliente.IdCliente == idCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        // Busca un CD por su ID.
        public CentroDistribucionEntidad BuscarCD(int idCD)
        {
            foreach (CentroDistribucionEntidad cd in cds)
            {
                if (cd.IdCD == idCD)
                {
                    return cd;
                }
            }
            return null;
        }

        // Busca un destinatario por su DNI.
        public DestinatarioEntidad BuscarDestinatario(int dni)
        {
            foreach (DestinatarioEntidad dest in destinatarios)
            {
                if (dest.Dni == dni)
                {
                    return dest;
                }
            }
            return null;
        }

        // Confirma la admisión de una guía
        public void ConfirmarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            // Caso especial: el CD destino es el mismo que el CD de admisión Y modalidad es Retiro en CD
            if (guia.IdCDDestino == guia.IdCDAdmision && guia.ModalidadEntrega == ModalidadesEntrega.RetiroEnCD)
            {
                guia.Estado = EstadoGuia.PendienteDeRetiroEnCD;
            }
            else
            {
                guia.Estado = EstadoGuia.Admitida;
            }

            // Registrar el cambio en el historial
            HistorialEstadoGuiaEntidad cambio = new HistorialEstadoGuiaEntidad
            {
                FechaCambio = fechaAdmision,
                Estado = guia.Estado
            };
            guia.Historial.Add(cambio);
        }

        // Rechaza la admisión: pasa la guía a "Cancelada"
        public void RechazarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            GuiaEntidad guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            guia.Estado = EstadoGuia.Cancelada;

            HistorialEstadoGuiaEntidad cambio = new HistorialEstadoGuiaEntidad
            {
                FechaCambio = fechaAdmision,
                Estado = guia.Estado
            };
            guia.Historial.Add(cambio);
        }

        // Métodos de formato para mostrar en pantalla
        public string TextoBulto(TiposBulto bulto)
        {
            if (bulto == TiposBulto.S) return "S (hasta 2.5 kg)";
            if (bulto == TiposBulto.M) return "M (hasta 5 kg)";
            if (bulto == TiposBulto.L) return "L (hasta 10 kg)";
            if (bulto == TiposBulto.XL) return "XL (hasta 20 kg)";
            return "";
        }

        public string TextoModalidad(ModalidadesEntrega modalidad)
        {
            if (modalidad == ModalidadesEntrega.PuertaAPuerta) return "Puerta a Puerta";
            if (modalidad == ModalidadesEntrega.RetiroEnAgencia) return "Retiro en Agencia";
            if (modalidad == ModalidadesEntrega.RetiroEnCD) return "Retiro en CD";
            return "";
        }
    }
}