using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        // DATOS DE PRUEBA ADAPTADOS AL NUEVO DIAGRAMA
        private List<HojaRutaTransporte> hdrs = new List<HojaRutaTransporte>
        {
            new HojaRutaTransporte
            {NroHDR = 3001,
            CDDestino = new CentroDistribucion { IdCD = 1, Nombre = "CD Córdoba - Terminal Central" },
            Empresa = "Nueva Chevallier S.A.",
            IdServicio = "CH-CBA-2200",
            Guias = new List<Guia>
            {
                new Guia {
                    NroGuia = "G-1001",
                    TipoBulto = TiposBulto.S, // 1 bulto en S
                    Estado = EstadoGuia.PendienteDeDespacho,
                    ClienteRemitente = new Cliente { RazonSocial = "Techint Logística" },
                    DestinatarioFinal = new Destinatario { Nombre = "Carlos", Apellido = "Paz" }
                },
                new Guia {
                    NroGuia = "G-1002",
                    TipoBulto = TiposBulto.M, // 2 bultos en S
                    Estado = EstadoGuia.PendienteDeDespacho,
                    ClienteRemitente = new Cliente { RazonSocial = "Arcor S.A.I.C." },
                    DestinatarioFinal = new Destinatario { Nombre = "Laura", Apellido = "Martínez" }
                }
            }, // Total bultos en S = 3 | Total Guías = 2
        },
            // Ejemplo 2: Destino Mendoza - Caja grande tipo L
            new HojaRutaTransporte
            {
                NroHDR = 3002,
                CDDestino = new CentroDistribucion { IdCD = 2, Nombre = "CD Mendoza - Terminal Del Sol" },
                Empresa = "Andesmar",
                IdServicio = "AND-MDZ-2315",
                Guias = new List<Guia>
                {
                    new Guia 
                    {
                        NroGuia = "G-2041",
                        TipoBulto = TiposBulto.L, // 4 bultos en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Bodegas López" },
                        DestinatarioFinal = new Destinatario { Nombre = "Federico", Apellido = "Quintana" }
                    }
                } // Total bultos en S = 4 | Total Guías = 1
            },

            // Ejemplo 3: Destino Rosario - Carga pesada corporativa (XL y M)
            new HojaRutaTransporte
            {
                NroHDR = 3003,
                CDDestino = new CentroDistribucion { IdCD = 3, Nombre = "CD Rosario - Terminal Mariano Moreno" },
                Empresa = "Empresa Argentina",
                IdServicio = "EA-ROS-2130",
                Guias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-3110",
                        TipoBulto = TiposBulto.XL, // 8 bultos en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Unilever S.A." },
                        DestinatarioFinal = new Destinatario { Nombre = "Alberto", Apellido = "Rossi" }
                    },
                    new Guia 
                    {
                        NroGuia = "G-3111",
                        TipoBulto = TiposBulto.M, // 2 bultos en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Bazar Avenida" },
                        DestinatarioFinal = new Destinatario { Nombre = "Marta", Apellido = "Gómez" }
                    }
                } // Total bultos en S = 10 | Total Guías = 2
            },

            // Ejemplo 4: Destino Mar del Plata - Ecommerce puro (Muchos bultos S)
            new HojaRutaTransporte
            {
                NroHDR = 3004,
                CDDestino = new CentroDistribucion { IdCD = 4, Nombre = "CD Mar del Plata - Terminal Ferroautomotora" },
                Empresa = "Plusmar",
                IdServicio = "PM-MDP-2345",
                Guias = new List<Guia>
                {
                    new Guia 
                    {
                        NroGuia = "G-4001",
                        TipoBulto = TiposBulto.S, // 1 bulto en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "MercadoLibre SRL" },
                        DestinatarioFinal = new Destinatario { Nombre = "Esteban", Apellido = "Quito" }
                    },
                    new Guia 
                    {
                        NroGuia = "G-4002",
                        TipoBulto = TiposBulto.S, // 1 bulto en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "MercadoLibre SRL" },
                        DestinatarioFinal = new Destinatario { Nombre = "Ramiro", Apellido = "Díaz" }
                    },
                    new Guia 
                    {
                        NroGuia = "G-4003",
                        TipoBulto = TiposBulto.S, // 1 bulto en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Frávega S.A." },
                        DestinatarioFinal = new Destinatario { Nombre = "Clara", Apellido = "Benítez" }
                    }
                } // Total bultos en S = 3 | Total Guías = 3
            },

            // Ejemplo 5: Destino Bariloche - Remisión intercorporativa de largo alcance
            new HojaRutaTransporte
            {
                NroHDR = 3005,
                CDDestino = new CentroDistribucion { IdCD = 5, Nombre = "CD Bariloche - Terminal Río Negro" },
                Empresa = "Via Bariloche",
                IdServicio = "VB-BAR-1900",
                Guias = new List<Guia>
                {
                    new Guia 
                    {
                        NroGuia = "G-5501",
                        TipoBulto = TiposBulto.L, // 4 bultos en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "INVAP S.E." },
                        DestinatarioFinal = new Destinatario { Nombre = "Jorge", Apellido = "Sabat" }
                    },
                    new Guia 
                    {
                        NroGuia = "G-5502",
                        TipoBulto = TiposBulto.XL, // 8 bultos en S
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteRemitente = new Cliente { RazonSocial = "Aluar S.A." },
                        DestinatarioFinal = new Destinatario { Nombre = "Enrique", Apellido = "Pinti" }
                    }
                } // Total bultos en S = 12 | Total Guías = 2
            }
        };

        internal List<HojaRutaTransporte> ObtenerHDRsPendientes()
        {
            var resultado = new List<HojaRutaTransporte>();
            foreach (var hdr in hdrs)
            {
                if (!hdr.Despachada)
                {
                    resultado.Add(hdr);
                }
            }
            return resultado;
        }

        internal int CalcularBultosEnS(HojaRutaTransporte hdr)
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

        internal int CalcularTotalBultos(HojaRutaTransporte hdr)
        {
            return hdr.Guias.Count;
        }

        internal bool ConfirmarDespacho(HojaRutaTransporte hdr)
        {
            if (hdr == null)
            {
                MessageBox.Show("Debe seleccionar un Servicio.");
                return false;
            }

            if (hdr.Guias.Count == 0)
            {
                MessageBox.Show("El servicio seleccionado no tiene guías para despachar.");
                return false;
            }

            // Cambiamos el estado de las guías a En Transito según el diagrama y marcamos la HDR como despachada
            foreach (var guia in hdr.Guias)
            {
                guia.Estado = EstadoGuia.EnTransito;
            }
            hdr.Despachada = true;

            return true;
        }

        internal int CalcularTotalGeneralPendiente()
        {
            int acumulador = 0;
            foreach (var hdr in ObtenerHDRsPendientes())
            {
                acumulador += hdr.Guias.Count;
            }
            return acumulador;
        }
    }
}
