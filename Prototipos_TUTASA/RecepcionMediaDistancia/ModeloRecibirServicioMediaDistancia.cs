using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class ModeloRecibirServicioMediaDistancia
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public ServicioMediaDistancia ServicioActual { get; set; }
        public List<EmpresaTransporte> Empresas { get; set; }
        public List<HojaDeRutaTransporte> HDRs { get; set; }
        public List<Guia> Guias { get; set; }
        public List<CentroDistribucion> CDs { get; set; }

        public ModeloRecibirServicioMediaDistancia() 
        {
            // CDs
            var cdCordoba = new CentroDistribucion
            {
                idCD = 0,
                nombre = "Centro - Córdoba"
            };

            var cdMendoza = new CentroDistribucion
            {
                idCD = 1,
                nombre = "Cuyo - Mendoza"
            };
            
            var cdBuenosAires = new CentroDistribucion
            {
                idCD = 2,
                nombre = "Capital Federal - Buenos Aires"
            };
            CDs = new List<CentroDistribucion>
            {
                cdCordoba,
                cdMendoza,
                cdBuenosAires
            };

            // Empresa Transporte
            var empresa1 = new EmpresaTransporte
            {
                idEmpresa = 11,
                razonSocial = "Transportes Argentinos"
            };

            var empresa2 = new EmpresaTransporte
            {
                idEmpresa = 12,
                razonSocial = "Expreso Nacional"
            };

            Empresas = new List<EmpresaTransporte>
            {
                empresa1,
                empresa2
            };

            // SERVICIO 1
            var guia1 = new Guia
            {
                NroGuia = "G0001",
                TipoBulto = TiposBultoEnum.S,
                modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio,
                idCDOrigen = cdCordoba.idCD,
                idCDActual = cdCordoba.idCD,
                idCDDestino = cdMendoza.idCD,
                estado = EstadoGuiaEnum.EnTransito
            };

            var guia2 = new Guia
            {
                NroGuia = "G0002",
                TipoBulto = TiposBultoEnum.M,
                modalidadEntrega = ModalidadEntregaEnum.EntregaAgencia,
                idCDOrigen = cdCordoba.idCD,
                idCDActual = cdCordoba.idCD,
                idCDDestino = cdMendoza.idCD,
                estado = EstadoGuiaEnum.EnTransito
            };

            var guia3 = new Guia
            {
                NroGuia = "G0003",
                TipoBulto = TiposBultoEnum.XL,
                modalidadEntrega = ModalidadEntregaEnum.EntregaCD,
                idCDOrigen = cdCordoba.idCD,
                idCDActual = cdCordoba.idCD,
                idCDDestino = cdMendoza.idCD,
                estado = EstadoGuiaEnum.EnTransito
            };

            var hdr1 = new HojaDeRutaTransporte
            {
                NroHDR = 1001,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<string>
                {
                    guia1.NroGuia,
                    guia2.NroGuia
                }
            };

            var hdr2 = new HojaDeRutaTransporte
            {
                NroHDR = 1002,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<string>
                {
                    guia3.NroGuia
                }
            };

            var servicio1 = new ServicioMediaDistancia
            {
                idServicio = 1,
                idEmpresa = empresa1.idEmpresa,
                fechaLlegada= new DateTime(2026, 6, 2, 8, 30, 0),
                fechaRecepcion= null,
                DetalleHDRs = new List<int>
                {
                    hdr1.NroHDR,
                    hdr2.NroHDR
                }
            };

            // SERVICIO 2

            var guia4 = new Guia
            {
                NroGuia = "G0004",
                TipoBulto = TiposBultoEnum.L,
                modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio,
                idCDOrigen = cdMendoza.idCD,
                idCDActual = cdMendoza.idCD,
                idCDDestino = cdCordoba.idCD,
                estado = EstadoGuiaEnum.EnTransito
            };

            var guia5 = new Guia
            {
                NroGuia = "G0005",
                TipoBulto = TiposBultoEnum.M,
                modalidadEntrega = ModalidadEntregaEnum.EntregaCD,
                idCDOrigen = cdMendoza.idCD,
                idCDActual = cdMendoza.idCD,
                idCDDestino = cdCordoba.idCD,
                estado = EstadoGuiaEnum.EnTransito
            };

            var hdr3 = new HojaDeRutaTransporte
            {
                NroHDR = 2001,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<string>
                {
                    guia4.NroGuia,
                    guia5.NroGuia
                }
            };

            var servicio2 = new ServicioMediaDistancia
            {
                idServicio = 2,
                idEmpresa = empresa2.idEmpresa,
                fechaLlegada = new DateTime(2026, 5, 29, 16, 30, 0),
                fechaRecepcion = null,
                DetalleHDRs = new List<int>
                {
                    hdr3.NroHDR
                }
            };

            //SERVICIO 3
            var guia6 = new Guia
            {
                NroGuia = "G0006",
                TipoBulto = TiposBultoEnum.S,
                modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio,
                idCDOrigen = cdCordoba.idCD,
                idCDActual = cdCordoba.idCD,
                idCDDestino = cdBuenosAires.idCD,
                estado = EstadoGuiaEnum.EnTransito
            };

            var hdr4 = new HojaDeRutaTransporte
            {
                NroHDR = 3001,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<string>
                {
                    guia6.NroGuia
                }
            };

            var servicio3 = new ServicioMediaDistancia
            {
                idServicio = 3,
                idEmpresa = empresa1.idEmpresa,
                fechaLlegada = new DateTime(2026, 5, 25, 11, 30, 0),
                fechaRecepcion = new DateTime(2026, 5, 30, 15, 30, 0),
                DetalleHDRs = new List<int>
                {
                    hdr4.NroHDR
                }
            };

            Servicios = new List<ServicioMediaDistancia>
            {
                servicio1,
                servicio2,
                servicio3
            };
            Guias = new List<Guia>
            {
                guia1,
                guia2,
                guia3,
                guia4,
                guia5,
                guia6
            };
            HDRs = new List<HojaDeRutaTransporte>
            {
                hdr1,
                hdr2,
                hdr3,
                hdr4
            };

        }
        public EmpresaTransporte BuscarEmpresa(int idEmpresa)
        {
            return Empresas.FirstOrDefault(e => e.idEmpresa == idEmpresa);
        }
        public HojaDeRutaTransporte BuscarHDR(int nroHDR)
        {
            return HDRs.FirstOrDefault(h => h.NroHDR == nroHDR);
        }
        public Guia BuscarGuia(string nroGuia)
        {
            return Guias.FirstOrDefault(g => g.NroGuia == nroGuia);
        }
        public CentroDistribucion BuscarCD(int idCD)
        {
            return CDs.FirstOrDefault(c => c.idCD == idCD);
        }

    }
}
