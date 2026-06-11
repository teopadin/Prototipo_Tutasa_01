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
                new EmpresaTransporte { idEmpresa = 10, razonSocial = "Nueva Chevallier S.A." },
                new EmpresaTransporte { idEmpresa = 20, razonSocial = "Andesmar" },
                new EmpresaTransporte { idEmpresa = 30, razonSocial = "Empresa Argentina" },
                new EmpresaTransporte { idEmpresa = 40, razonSocial = "Plusmar" },
                new EmpresaTransporte { idEmpresa = 50, razonSocial = "Via Bariloche" }
            };

            almacenClientes = new List<Cliente> {
                new Cliente { idCliente = 100, razonSocial = "Techint Logística" },
                new Cliente { idCliente = 200, razonSocial = "Arcor S.A.I.C." },
                new Cliente { idCliente = 300, razonSocial = "Bodegas López" },
                new Cliente { idCliente = 400, razonSocial = "Unilever S.A." },
                new Cliente { idCliente = 500, razonSocial = "MercadoLibre SRL" }
            };

            almacenCDs = new List<CentroDistribucion> {
                new CentroDistribucion { idCD = 1, nombre = "CD Buenos Aires" },
                new CentroDistribucion { idCD = 2, nombre = "CD Córdoba" },
                new CentroDistribucion { idCD = 3, nombre = "CD Mendoza" },
                new CentroDistribucion { idCD = 4, nombre = "CD Rosario" },
                new CentroDistribucion { idCD = 5, nombre = "CD Bariloche" }
            };

            servicios = new List<ServicioMediaDistancia> {
                new ServicioMediaDistancia { idServicio = 2200, idEmpresa = 10 },
                new ServicioMediaDistancia { idServicio = 2315, idEmpresa = 20 },
                new ServicioMediaDistancia { idServicio = 2130, idEmpresa = 30 },
                new ServicioMediaDistancia { idServicio = 2345, idEmpresa = 40 },
                new ServicioMediaDistancia { idServicio = 1900, idEmpresa = 50 }
            };

            // 2. Inicializamos las HDRs usando SOLAMENTE IDs (la forma correcta de hacerlo)
            hdrs = new List<HojaDeRutaTransporte>
            {

                new HojaDeRutaTransporte
                {
                    nroHDR = 3001,
                    estado = EstadoHojaDeRutaEnum.Generada,
                    idServicio = 2200,
                    idCDDestino = 1,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-1001", IdCliente = 100, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { nombre = "Carlos", apellido = "Paz" } },
                        new Guia { NroGuia = "G-1002", IdCliente = 200, TipoBulto = TiposBultoEnum.M, Destinatario = new DestinatarioGuia { nombre = "Laura", apellido = "Martínez" } },
                        new Guia { NroGuia = "G-1003", IdCliente = 200, TipoBulto = TiposBultoEnum.L, Destinatario = new DestinatarioGuia { nombre = "Laura", apellido = "Martínez" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    nroHDR = 3002,
                    estado = EstadoHojaDeRutaEnum.Generada,
                    idServicio = 2315,
                    idCDDestino = 2,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-2041", IdCliente = 300, TipoBulto = TiposBultoEnum.L, Destinatario = new DestinatarioGuia { nombre = "Federico", apellido = "Quintana" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    nroHDR = 3003,
                    estado = EstadoHojaDeRutaEnum.Generada,
                    idServicio = 2130,
                    idCDDestino = 3,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-3110", IdCliente = 400, TipoBulto = TiposBultoEnum.XL, Destinatario = new DestinatarioGuia { nombre = "Alberto", apellido = "Rossi" } },
                        new Guia { NroGuia = "G-3111", IdCliente = 500, TipoBulto = TiposBultoEnum.M, Destinatario = new DestinatarioGuia { nombre = "Marta", apellido = "Gómez" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    nroHDR = 3004,
                    estado = EstadoHojaDeRutaEnum.Generada,
                    idServicio = 2345,
                    idCDDestino = 4,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-4001", IdCliente = 500, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { nombre = "Esteban", apellido = "Quito" } },
                        new Guia { NroGuia = "G-4002", IdCliente = 500, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { nombre = "Ramiro", apellido = "Díaz" } },
                        new Guia { NroGuia = "G-4003", IdCliente = 500, TipoBulto = TiposBultoEnum.S, Destinatario = new DestinatarioGuia { nombre = "Clara", apellido = "Benítez" } }
                    }
                },
                new HojaDeRutaTransporte
                {
                    nroHDR = 3005,
                    estado = EstadoHojaDeRutaEnum.Generada,
                    idServicio = 1900,
                    idCDDestino = 5,
                    DetalleGuias = new List<Guia>
                    {
                        new Guia { NroGuia = "G-5501", IdCliente = 100, TipoBulto = TiposBultoEnum.L, Destinatario = new DestinatarioGuia { nombre = "Jorge", apellido = "Sabat" } },
                        new Guia { NroGuia = "G-5502", IdCliente = 400, TipoBulto = TiposBultoEnum.XL, Destinatario = new DestinatarioGuia { nombre = "Enrique", apellido = "Pinti" } }
                    }
                }
            };
                    }

        // --- MÉTODOS BUSCADORES (Indispensables para tu lógica) ---
        public EmpresaTransporte BuscarEmpresa(int id) => almacenEmpresas.Find(e => e.idEmpresa == id);
        public Cliente BuscarCliente(int id) => almacenClientes.Find(c => c.idCliente == id);
        public CentroDistribucion BuscarCD(int id) => almacenCDs.Find(cd => cd.idCD == id);
        public ServicioMediaDistancia BuscarServicioPorId(int id) => servicios.Find(s => s.idServicio == id);

        // --- MÉTODOS DE LÓGICA (No cambian) ---
        internal List<HojaDeRutaTransporte> ObtenerHDRsPendientes() => hdrs.FindAll(h => h.estado == EstadoHojaDeRutaEnum.Generada);

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
            foreach (var guia in hdr.DetalleGuias) guia.estado = EstadoGuiaEnum.EnTransito;
            hdr.estado = EstadoHojaDeRutaEnum.EnCurso;
            return true;
        }
    }
}