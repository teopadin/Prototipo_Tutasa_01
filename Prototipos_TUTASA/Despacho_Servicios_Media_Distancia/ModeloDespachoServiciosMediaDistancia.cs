using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        // Tu lista privada con el nombre de clase corregido (HojaRutaTransporte)
        private List<HDRTransporte> hdrs = new List<HDRTransporte>
        {
            // Ejemplo 1: Destino Córdoba
            new HDRTransporte
            {
                NroHDR = 3001,
                IdServicio = 2200, // idServicio (int) según diagrama
                Estado = EstadoHDR.Generada, // Usamos el EstadoEnum del dibujo en vez de un bool
                DetalleGuias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-1001",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Techint Logística" },
                        Destinatario = new DestinatarioGuia { Nombre = "Carlos", Apellido = "Paz" }
                    },
                    new Guia {
                        NroGuia = "G-1002",
                        TipoBulto = TiposBulto.M,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Arcor S.A.I.C." },
                        Destinatario = new DestinatarioGuia { Nombre = "Laura", Apellido = "Martínez" }
                    }
                }
            },

            // Ejemplo 2: Destino Mendoza
            new HDRTransporte
            {
                NroHDR = 3002,
                IdServicio = 2315,
                Estado = EstadoHDR.Generada,
                DetalleGuias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-2041",
                        TipoBulto = TiposBulto.L,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Bodegas López" },
                        Destinatario = new DestinatarioGuia { Nombre = "Federico", Apellido = "Quintana" }
                    }
                }
            },

            // Ejemplo 3: Destino Rosario
            new HDRTransporte
            {
                NroHDR = 3003,
                IdServicio = 2130,
                Estado = EstadoHDR.Generada,
                DetalleGuias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-3110",
                        TipoBulto = TiposBulto.XL,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Unilever S.A." },
                        Destinatario = new DestinatarioGuia { Nombre = "Alberto", Apellido = "Rossi" }
                    },
                    new Guia {
                        NroGuia = "G-3111",
                        TipoBulto = TiposBulto.M,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Bazar Avenida" },
                        Destinatario = new DestinatarioGuia { Nombre = "Marta", Apellido = "Gómez" }
                    }
                }
            },

            // Ejemplo 4: Destino Mar del Plata
            new HDRTransporte
            {
                NroHDR = 3004,
                IdServicio = 2345,
                Estado = EstadoHDR.Generada,
                DetalleGuias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-4001",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "MercadoLibre SRL" },
                        Destinatario = new DestinatarioGuia { Nombre = "Esteban", Apellido = "Quito" }
                    },
                    new Guia {
                        NroGuia = "G-4002",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "MercadoLibre SRL" },
                        Destinatario = new DestinatarioGuia { Nombre = "Ramiro", Apellido ="Díaz" }
                    },
                    new Guia {
                        NroGuia = "G-4003",
                        TipoBulto = TiposBulto.S,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Frávega S.A." },
                        Destinatario = new DestinatarioGuia { Nombre = "Clara", Apellido = "Benítez" }
                    }
                }
            },

            // Ejemplo 5: Destino Bariloche
            new HDRTransporte
            {
                NroHDR = 3005,
                IdServicio = 1900,
                Estado = EstadoHDR.Generada,
                DetalleGuias = new List<Guia>
                {
                    new Guia {
                        NroGuia = "G-5501",
                        TipoBulto = TiposBulto.L,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "INVAP S.E." },
                        Destinatario = new DestinatarioGuia { Nombre = "Jorge", Apellido = "Sabat" }
                    },
                    new Guia {
                        NroGuia = "G-5502",
                        TipoBulto = TiposBulto.XL,
                        Estado = EstadoGuia.PendienteDeDespacho,
                        ClienteGuia = new Cliente { RazonSocial = "Aluar S.A." },
                        Destinatario = new DestinatarioGuia { Nombre = "Enrique", Apellido = "Pinti" }
                    }
                }
            }
        };

        // 2. MÉTODOS ADAPTADOS A LOS NUEVOS ATRIBUTOS

        internal List<HDRTransporte> ObtenerHDRsPendientes()
        {
            List<HDRTransporte> temporales = new List<HDRTransporte>();
            foreach (var h in hdrs)
            {
                // En vez de h.Despachada, miramos que el estado NO sea "EnCurso" o "Recibida"
                if (h.Estado == EstadoHDR.Generada)
                {
                    temporales.Add(h);
                }
            }
            return temporales;
        }

        internal int CalcularBultosEnS(HDRTransporte hdr)
        {
            int total = 0;
            // Usamos h.DetalleGuias
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
            if (hdr == null)
            {
                MessageBox.Show("Debe seleccionar un Servicio.");
                return false;
            }

            foreach (var guia in hdr.DetalleGuias)
            {
                guia.Estado = EstadoGuia.EnTransito;
            }

            // Cambiamos el estado a EnCurso (Despachada) según tu EstadoHojaDeRutaEnum
            hdr.Estado = EstadoHDR.EnCurso;

            return true;
        }
    }
}