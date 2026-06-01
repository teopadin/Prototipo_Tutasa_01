using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class ModeloAdmision
    {
        // CD desde el que se realiza la admisión (lo reconoce el sistema)
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

        private List<Guia> guias = new List<Guia>
        {
            // Guía 1: caso general → quedará "Admitida"
            new Guia
            {
                NroGuia = "CD01-0001",
                IdCliente = 100,
                IdCDDestino = 2,
                Destinatario = new Destinatario { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
                TipoBulto = TiposBulto.M,
                ModalidadEntrega = ModalidadesEntrega.PuertaAPuerta,
                Estado = EstadoGuia.Retirada
            },
            // Guía 2: caso especial → quedará "Pendiente de retiro en CD"
            new Guia
            {
                NroGuia = "CD01-0002",
                IdCliente = 200,
                IdCDDestino = 1,
                Destinatario = new Destinatario { Dni = 28444555, Nombre = "María", Apellido = "González" },
                TipoBulto = TiposBulto.S,
                ModalidadEntrega = ModalidadesEntrega.RetiroEnCD,
                Estado = EstadoGuia.Retirada
            },
            // Guía 3: caso general (mismo CD pero no es Retiro en CD)
            new Guia
            {
                NroGuia = "CD01-0003",
                IdCliente = 300,
                IdCDDestino = 1,
                Destinatario = new Destinatario { Dni = 35777888, Nombre = "Carlos", Apellido = "López" },
                TipoBulto = TiposBulto.L,
                ModalidadEntrega = ModalidadesEntrega.PuertaAPuerta,
                Estado = EstadoGuia.Retirada
            },
            // Guía 4: estado distinto a "Retirada" → no se puede admitir
            new Guia
            {
                NroGuia = "CD01-0004",
                IdCliente = 100,
                IdCDDestino = 3,
                Destinatario = new Destinatario { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
                TipoBulto = TiposBulto.XL,
                ModalidadEntrega = ModalidadesEntrega.RetiroEnAgencia,
                Estado = EstadoGuia.Admitida
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

        // Confirma la admisión de una guía
        public void ConfirmarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            // Caso especial: el CD destino es el mismo que el CD de admisión Y modalidad es Retiro en CD
            if (guia.IdCDDestino == idCDAdmisionActual && guia.ModalidadEntrega == ModalidadesEntrega.RetiroEnCD)
            {
                guia.Estado = EstadoGuia.PendienteDeRetiroEnCD;
            }
            else
            {
                guia.Estado = EstadoGuia.Admitida;
            }
        }

        // Rechaza la admisión: pasa la guía a "Cancelada"
        public void RechazarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            guia.Estado = EstadoGuia.Cancelada;
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