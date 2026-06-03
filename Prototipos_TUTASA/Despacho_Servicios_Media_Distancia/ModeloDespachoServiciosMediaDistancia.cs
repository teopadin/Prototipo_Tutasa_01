using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        private List<HDRTransporte> hdrs;

        // La "tabla" de servicios independientes, donde vive EmpresaTransporte
        private List<ServicioMediaDistancia> servicios;

        public ModeloDespachoServiciosMediaDistancia()
        {
            // 1. Inicializamos los servicios auxiliares con sus empresas (Uso real de objetos)
            servicios = new List<ServicioMediaDistancia>
            {
                new ServicioMediaDistancia { IdServicio = 2200, Empresa = new EmpresaTransporte { RazonSocial = "Nueva Chevallier S.A." } },
                new ServicioMediaDistancia { IdServicio = 2315, Empresa = new EmpresaTransporte { RazonSocial = "Andesmar" } },
                new ServicioMediaDistancia { IdServicio = 2130, Empresa = new EmpresaTransporte { RazonSocial = "Empresa Argentina" } },
                new ServicioMediaDistancia { IdServicio = 2345, Empresa = new EmpresaTransporte { RazonSocial = "Plusmar" } },
                new ServicioMediaDistancia { IdServicio = 1900, Empresa = new EmpresaTransporte { RazonSocial = "Via Bariloche" } }
            };

            // 2. Inicializamos tus 5 Hojas de Ruta usando solo los IDs del diagrama
            hdrs = new List<HDRTransporte>
            {
                new HDRTransporte
                {
                    NroHDR = 3001,
                    Estado = EstadoHDR.Generada,
                    IdServicio = 2200,   // Conectado por ID
                    IdCDDestino = 1,     // Conectado por ID
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-1001", TipoBulto = TiposBulto.S, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Techint Logística" }, Destinatario = new DestinatarioGuia { Nombre = "Carlos", Apellido = "Paz" } },
                        new Guia { NroGuia = "G-1002", TipoBulto = TiposBulto.M, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Arcor S.A.I.C." }, Destinatario = new DestinatarioGuia { Nombre = "Laura", Apellido = "Martínez" } },
                        new Guia { NroGuia = "G-1003", TipoBulto = TiposBulto.L, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Arcor S.A.I.C." }, Destinatario = new DestinatarioGuia { Nombre = "Laura", Apellido = "Martínez" } }
                    }
                },
                new HDRTransporte
                {
                    NroHDR = 3002,
                    Estado = EstadoHDR.Generada,
                    IdServicio = 2315,
                    IdCDDestino = 2,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-2041", TipoBulto = TiposBulto.L, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Bodegas López" }, Destinatario = new DestinatarioGuia { Nombre = "Federico", Apellido = "Quintana" } }
                    }
                },
                new HDRTransporte
                {
                    NroHDR = 3003,
                    Estado = EstadoHDR.Generada,
                    IdServicio = 2130,
                    IdCDDestino = 3,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-3110", TipoBulto = TiposBulto.XL, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Unilever S.A." }, Destinatario = new DestinatarioGuia { Nombre = "Alberto", Apellido = "Rossi" } },
                        new Guia { NroGuia = "G-3111", TipoBulto = TiposBulto.M, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Bazar Avenida" }, Destinatario = new DestinatarioGuia { Nombre = "Marta", Apellido = "Gómez" } }
                    }
                },
                new HDRTransporte
                {
                    NroHDR = 3004,
                    Estado = EstadoHDR.Generada,
                    IdServicio = 2345,
                    IdCDDestino = 4,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-4001", TipoBulto = TiposBulto.S, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "MercadoLibre SRL" }, Destinatario = new DestinatarioGuia { Nombre = "Esteban", Apellido = "Quito" } },
                        new Guia { NroGuia = "G-4002", TipoBulto = TiposBulto.S, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "MercadoLibre SRL" }, Destinatario = new DestinatarioGuia { Nombre = "Ramiro", Apellido ="Díaz" } },
                        new Guia { NroGuia = "G-4003", TipoBulto = TiposBulto.S, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Frávega S.A." }, Destinatario = new DestinatarioGuia { Nombre = "Clara", Apellido = "Benítez" } }
                    }
                },
                new HDRTransporte
                {
                    NroHDR = 3005,
                    Estado = EstadoHDR.Generada,
                    IdServicio = 1900,
                    IdCDDestino = 5,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-5501", TipoBulto = TiposBulto.L, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "INVAP S.E." }, Destinatario = new DestinatarioGuia { Nombre = "Jorge", Apellido = "Sabat" } },
                        new Guia { NroGuia = "G-5502", TipoBulto = TiposBulto.XL, Estado = EstadoGuia.PendienteDeDespacho, Cliente = new Cliente { RazonSocial = "Aluar S.A." }, Destinatario = new DestinatarioGuia { Nombre = "Enrique", Apellido = "Pinti" } }
                    }
                }
            };
        }

        // Método intermedio para que el Formulario pueda buscar el objeto Servicio usando el ID
        internal ServicioMediaDistancia BuscarServicioPorId(int id)
        {
            foreach (var s in servicios)
            {
                if (s.IdServicio == id) return s;
            }
            return null;
        }

        internal List<HDRTransporte> ObtenerHDRsPendientes()
        {
            List<HDRTransporte> temporales = new List<HDRTransporte>();
            foreach (var h in hdrs)
            {
                if (h.Estado == EstadoHDR.Generada) temporales.Add(h);
            }
            return temporales;
        }

        internal int CalcularBultosEnS(HDRTransporte hdr)
        {
            int total = 0;
            foreach (var g in hdr.DetalleGuias)
            {
                if (g.TipoBulto == TiposBulto.S) total += 1;
                else if (g.TipoBulto == TiposBulto.M) total += 2;
                else if (g.TipoBulto == TiposBulto.L) total += 4;
                else if (g.TipoBulto == TiposBulto.XL) total += 8;
            }
            return total;
        }

        internal int CalcularTotalBultos(HDRTransporte hdr)
        {
            if (hdr == null) return 0;
            return hdr.DetalleGuias.Count;
        }

        internal int CalcularTotalGeneralPendiente()
        {
            int acumulador = 0;
            foreach (var h in ObtenerHDRsPendientes())
            {
                acumulador += h.DetalleGuias.Count;
            }
            return acumulador;
        }

        internal bool ConfirmarDespacho(HDRTransporte hdr)
        {
            if (hdr == null) return false;
            foreach (var guia in hdr.DetalleGuias)
            {
                guia.Estado = EstadoGuia.EnTransito;
            }
            hdr.Estado = EstadoHDR.EnCurso;
            return true;
        }
    }
}