using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        // 1. LISTA DE EJEMPLOS ADAPTADA (Sin atributos de más)
        private List<HDRTransporte> hdrs = new List<HDRTransporte>
        {
            // Ejemplo 1: Destino Córdoba
            new HDRTransporte
            {
                NroHDR = 3001,
                CDDestino = new CentroDistribucion { Nombre = "CD Córdoba - Terminal Central" },
                Empresa = "Nueva Chevallier S.A.",
                IdServicio = "CH-CBA-2200",
                Guias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-1001",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Techint Logística" },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Carlos Paz" }
                    },
                    new Guia {
                        NroGuia = "G-1002",
                        TipoBulto = TiposBulto.M,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Arcor S.A.I.C." },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Laura Martínez" }
                    }
                }
            },

            // Ejemplo 2: Destino Mendoza
            new HDRTransporte
            {
                NroHDR = 3002,
                CDDestino = new CentroDistribucion { Nombre = "CD Mendoza - Terminal Del Sol" },
                Empresa = "Andesmar",
                IdServicio = "AND-MDZ-2315",
                Guias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-2041",
                        TipoBulto = TiposBulto.L,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Bodegas López" },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Federico Quintana" }
                    }
                }
            },

            // Ejemplo 3: Destino Rosario
            new HDRTransporte
            {
                NroHDR = 3003,
                CDDestino = new CentroDistribucion { Nombre = "CD Rosario - Terminal Mariano Moreno" },
                Empresa = "Empresa Argentina",
                IdServicio = "EA-ROS-2130",
                Guias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-3110",
                        TipoBulto = TiposBulto.XL,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Unilever S.A." },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Alberto Rossi" }
                    },
                    new Guia {
                        NroGuia = "G-3111",
                        TipoBulto = TiposBulto.M,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Bazar Avenida" },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Marta Gómez" }
                    }
                }
            },

            // Ejemplo 4: Destino Mar del Plata
            new HDRTransporte
            {
                NroHDR = 3004,
                CDDestino = new CentroDistribucion { Nombre = "CD Mar del Plata - Terminal Ferroautomotora" },
                Empresa = "Plusmar",
                IdServicio = "PM-MDP-2345",
                Guias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-4001",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "MercadoLibre SRL" },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Esteban Quito" }
                    },
                    new Guia {
                        NroGuia = "G-4002",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "MercadoLibre SRL" },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Ramiro Díaz" }
                    },
                    new Guia {
                        NroGuia = "G-4003",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Frávega S.A." },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Clara Benítez" }
                    }
                }
            },

            // Ejemplo 5: Destino Bariloche
            new HDRTransporte
            {
                NroHDR = 3005,
                CDDestino = new CentroDistribucion { Nombre = "CD Bariloche - Terminal Río Negro" },
                Empresa = "Via Bariloche",
                IdServicio = "VB-BAR-1900",
                Guias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-5501",
                        TipoBulto = TiposBulto.L,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "INVAP S.E." },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Jorge Sabat" }
                    },
                    new Guia {
                        NroGuia = "G-5502",
                        TipoBulto = TiposBulto.XL,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Aluar S.A." },
                        DestinatarioFinal = new Destinatario { NombreCompleto = "Enrique Pinti" }
                    }
                }
            }
        };

        // 2. MÉTODOS DEL MODELO ACTUALIZADOS A "HDRTransporte"
        internal List<HDRTransporte> ObtenerHDRsPendientes()
        {
            List<HDRTransporte> temporales = new List<HDRTransporte>();
            foreach (var h in hdrs)
            {
                if (!h.Despachada)
                {
                    temporales.Add(h);
                }
            }
            return temporales;
        }

        internal int CalcularBultosEnS(HDRTransporte hdr)
        {
            int total = 0;
            foreach (var g in hdr.Guias)
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
            return hdr.Guias.Count;
        }

        internal int CalcularTotalGeneralPendiente()
        {
            int acumulador = 0;
            foreach (var h in ObtenerHDRsPendientes())
            {
                acumulador += h.Guias.Count;
            }
            return acumulador;
        }

        internal bool ConfirmarDespacho(HDRTransporte hdr)
        {
            if (hdr == null)
            {
                MessageBox.Show("Debe seleccionar un Servicio.");
                return false;
            }

            foreach (var guia in hdr.Guias)
            {
                guia.Estado = EstadoGuia.EnTransito;
            }
            hdr.Despachada = true;

            return true;
        }
    }
}
