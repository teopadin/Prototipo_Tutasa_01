using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal partial class ModeloAdmision
    {
        // CD desde el que se realiza la admisión (fijo para el prototipo)
        private int idCDAdmisionActual = 1;

        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { IdCliente = 100, RazonSocial = "Tecno Distribuciones S.A." },
            new Cliente { IdCliente = 200, RazonSocial = "Importadora del Sur SRL" },
            new Cliente { IdCliente = 300, RazonSocial = "Comercial Norte" }
        };

        private List<CentroDistribucion> cds = new List<CentroDistribucion>
        {
            new CentroDistribucion { IdCD = 1, Nombre = "CD Buenos Aires" },
            new CentroDistribucion { IdCD = 2, Nombre = "CD Córdoba" },
            new CentroDistribucion { IdCD = 3, Nombre = "CD Mendoza" }
        };

        private List<Destinatario> destinatarios = new List<Destinatario>
        {
            new Destinatario { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
            new Destinatario { Dni = 28444555, Nombre = "María", Apellido = "González" },
            new Destinatario { Dni = 35777888, Nombre = "Carlos", Apellido = "López" }
        };

        private List<Guia> guias = new List<Guia>
        {
            // Guía 1: caso general → quedará "Admitida"
            new Guia
            {
                NroGuia = "CD01-0001",
                IdCliente = 100,
                IdCDDestino = 2,
                IdCDAdmision = 1,
                DniDestinatario = 30111222,
                TipoBulto = TiposBulto.M,
                ModalidadEntrega = ModalidadesEntrega.PuertaAPuerta,
                Estado = EstadoGuia.Retirada,
                Historial = new List<HistorialEstadoGuia>()
            },
            // Guía 2: caso especial → quedará "Pendiente de retiro en CD"
            new Guia
            {
                NroGuia = "CD01-0002",
                IdCliente = 200,
                IdCDDestino = 1,
                IdCDAdmision = 1,
                DniDestinatario = 28444555,
                TipoBulto = TiposBulto.S,
                ModalidadEntrega = ModalidadesEntrega.RetiroEnCD,
                Estado = EstadoGuia.Retirada,
                Historial = new List<HistorialEstadoGuia>()
            },
            // Guía 3: caso general (mismo CD pero no es Retiro en CD)
            new Guia
            {
                NroGuia = "CD01-0003",
                IdCliente = 300,
                IdCDDestino = 1,
                IdCDAdmision = 1,
                DniDestinatario = 35777888,
                TipoBulto = TiposBulto.L,
                ModalidadEntrega = ModalidadesEntrega.PuertaAPuerta,
                Estado = EstadoGuia.Retirada,
                Historial = new List<HistorialEstadoGuia>()
            },
            // Guía 4: estado distinto a "Retirada" → no se puede admitir
            new Guia
            {
                NroGuia = "CD01-0004",
                IdCliente = 100,
                IdCDDestino = 3,
                IdCDAdmision = 1,
                DniDestinatario = 30111222,
                TipoBulto = TiposBulto.XL,
                ModalidadEntrega = ModalidadesEntrega.RetiroEnAgencia,
                Estado = EstadoGuia.Entregada,
                Historial = new List<HistorialEstadoGuia>()
            }
        };

        // Busca una guía por su número. Devuelve null si no existe.
        public Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia guia in guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    return guia;
                }
            }
            return null;
        }

        // Busca un cliente por su ID.
        public Cliente BuscarCliente(int idCliente)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.IdCliente == idCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        // Busca un CD por su ID.
        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (CentroDistribucion cd in cds)
            {
                if (cd.IdCD == idCD)
                {
                    return cd;
                }
            }
            return null;
        }

        // Busca un destinatario por su DNI.
        public Destinatario BuscarDestinatario(int dni)
        {
            foreach (Destinatario dest in destinatarios)
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
            Guia guia = BuscarGuia(nroGuia);
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
            HistorialEstadoGuia cambio = new HistorialEstadoGuia
            {
                FechaCambio = fechaAdmision,
                Estado = guia.Estado
            };
            guia.Historial.Add(cambio);
        }

        // Rechaza la admisión: pasa la guía a "Cancelada"
        public void RechazarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            guia.Estado = EstadoGuia.Cancelada;

            HistorialEstadoGuia cambio = new HistorialEstadoGuia
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