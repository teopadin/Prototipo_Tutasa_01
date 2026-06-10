using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        private List<HojaDeRutaTransporte> hdrs;
        private List<ServicioMediaDistancia> servicios;

        // ALMACENES DE ENTIDADES (Las "tablas" maestras)
        private List<EmpresaTransporte> almacenEmpresas;
        private List<Cliente> almacenClientes;
        private List<CentroDistribucion> almacenCDs;

        public ModeloDespachoServiciosMediaDistancia()
        {
            // 1. Inicializamos los almacenes
            almacenEmpresas = new List<EmpresaTransporte> {
                new EmpresaTransporte { IdEmpresa = 10, RazonSocial = "Nueva Chevallier S.A." },
                new EmpresaTransporte { IdEmpresa = 20, RazonSocial = "Andesmar" },
                new EmpresaTransporte { IdEmpresa = 30, RazonSocial = "Empresa Argentina" },
                new EmpresaTransporte { IdEmpresa = 40, RazonSocial = "Plusmar" },
                new EmpresaTransporte { IdEmpresa = 50, RazonSocial = "Via Bariloche" }
            };

            almacenClientes = new List<Cliente> {
                new Cliente { IdCliente = 100, RazonSocial = "Techint Logística" },
                new Cliente { IdCliente = 200, RazonSocial = "Arcor S.A.I.C." },
                new Cliente { IdCliente = 300, RazonSocial = "Bodegas López" },
                new Cliente { IdCliente = 400, RazonSocial = "Unilever S.A." },
                new Cliente { IdCliente = 500, RazonSocial = "MercadoLibre SRL" }
            };

            almacenCDs = new List<CentroDistribucion> {
                new CentroDistribucion { IdCD = 1, Nombre = "CD Buenos Aires" },
                new CentroDistribucion { IdCD = 2, Nombre = "CD Córdoba" },
                new CentroDistribucion { IdCD = 3, Nombre = "CD Mendoza" },
                new CentroDistribucion { IdCD = 4, Nombre = "CD Rosario" },
                new CentroDistribucion { IdCD = 5, Nombre = "CD Bariloche" }
            };

            servicios = new List<ServicioMediaDistancia> {
                new ServicioMediaDistancia { IdServicio = 2200, IdEmpresa = 10 },
                new ServicioMediaDistancia { IdServicio = 2315, IdEmpresa = 20 },
                new ServicioMediaDistancia { IdServicio = 2130, IdEmpresa = 30 },
                new ServicioMediaDistancia { IdServicio = 2345, IdEmpresa = 40 },
                new ServicioMediaDistancia { IdServicio = 1900, IdEmpresa = 50 }
            };

            // 2. Inicializamos las HDRs usando SOLAMENTE IDs (la forma correcta de hacerlo)
            hdrs = new List<HojaDeRutaTransporte>
            {

                new HojaDeRutaTransporte
                {
                    NroHDR = 3001,
                    Estado = EstadoHojaDeRutaEnum.Generada,
                    IdServicio = 2200,
                    IdCDDestino = 1,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-1001", IdCliente = 100, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { Nombre = "Carlos", Apellido = "Paz" } },
                        new Guia { NroGuia = "G-1002", IdCliente = 200, TipoBulto = TiposBultoEnum.M, Destinatario = new DestinatarioGuia { Nombre = "Laura", Apellido = "Martínez" } },
                        new Guia { NroGuia = "G-1003", IdCliente = 200, TipoBulto = TiposBultoEnum.L, Destinatario = new DestinatarioGuia { Nombre = "Laura", Apellido = "Martínez" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    NroHDR = 3002,
                    Estado = EstadoHojaDeRutaEnum.Generada,
                    IdServicio = 2315,
                    IdCDDestino = 2,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-2041", IdCliente = 300, TipoBulto = TiposBultoEnum.L, Destinatario = new DestinatarioGuia { Nombre = "Federico", Apellido = "Quintana" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    NroHDR = 3003,
                    Estado = EstadoHojaDeRutaEnum.Generada,
                    IdServicio = 2130,
                    IdCDDestino = 3,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-3110", IdCliente = 400, TipoBulto = TiposBultoEnum.XL, Destinatario = new DestinatarioGuia { Nombre = "Alberto", Apellido = "Rossi" } },
                        new Guia { NroGuia = "G-3111", IdCliente = 500, TipoBulto = TiposBultoEnum.M, Destinatario = new DestinatarioGuia { Nombre = "Marta", Apellido = "Gómez" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    NroHDR = 3004,
                    Estado = EstadoHojaDeRutaEnum.Generada,
                    IdServicio = 2345,
                    IdCDDestino = 4,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-4001", IdCliente = 500, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { Nombre = "Esteban", Apellido = "Quito" } },
                        new Guia { NroGuia = "G-4002", IdCliente = 500, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { Nombre = "Ramiro", Apellido = "Díaz" } },
                        new Guia { NroGuia = "G-4003", IdCliente = 500, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { Nombre = "Clara", Apellido = "Benítez" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    NroHDR = 3005,
                    Estado = EstadoHojaDeRutaEnum.Generada,
                    IdServicio = 1900,
                    IdCDDestino = 5,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-5501", IdCliente = 100, TipoBulto = TiposBultoEnum.L, Destinatario = new DestinatarioGuia { Nombre = "Jorge", Apellido = "Sabat" } },
                        new Guia { NroGuia = "G-5502", IdCliente = 400, TipoBulto = TiposBultoEnum.XL, Destinatario = new DestinatarioGuia { Nombre = "Enrique", Apellido = "Pinti" } }
                    }
                }
            };
                    }

        // --- MÉTODOS BUSCADORES (Indispensables para tu lógica) ---
        public EmpresaTransporte BuscarEmpresa(int id) => almacenEmpresas.Find(e => e.IdEmpresa == id);
        public Cliente BuscarCliente(int id) => almacenClientes.Find(c => c.IdCliente == id);
        public CentroDistribucion BuscarCD(int id) => almacenCDs.Find(cd => cd.IdCD == id);
        public ServicioMediaDistancia BuscarServicioPorId(int id) => servicios.Find(s => s.IdServicio == id);

        // --- MÉTODOS DE LÓGICA (No cambian) ---
        internal List<HojaDeRutaTransporte> ObtenerHDRsPendientes() => hdrs.FindAll(h => h.Estado == EstadoHojaDeRutaEnum.Generada);

        internal int CalcularBultosEnS(HojaDeRutaTransporte hdr)
        {
            int total = 0;
            foreach (var g in hdr.DetalleGuias)
            {
                if (g.TipoBulto == TiposBultoEnum.S) total += 1;
                else if (g.TipoBulto == TiposBultoEnum.M) total += 2;
                else if (g.TipoBulto == TiposBultoEnum.L) total += 4;
                else if (g.TipoBulto == TiposBultoEnum.XL) total += 8;
            }
            return total;
        }

        internal int CalcularTotalBultos(HojaDeRutaTransporte hdr) => hdr?.DetalleGuias.Count ?? 0;

        internal int CalcularTotalGeneralPendiente()
        {
            int acumulador = 0;
            foreach (var h in ObtenerHDRsPendientes()) acumulador += h.DetalleGuias.Count;
            return acumulador;
        }

        internal bool ConfirmarDespacho(HojaDeRutaTransporte hdr)
        {
            if (hdr == null) return false;
            foreach (var guia in hdr.DetalleGuias) guia.Estado = EstadoGuiaEnum.EnTransito;
            hdr.Estado = EstadoHojaDeRutaEnum.EnCurso;
            return true;
        }
    }
}