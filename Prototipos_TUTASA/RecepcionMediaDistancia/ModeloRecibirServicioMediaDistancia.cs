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
        public ModeloRecibirServicioMediaDistancia() 
        {
            // CDs
            var cdCordoba = new CentroDistribucion
            {
                nombre = "Centro - Córdoba"
            };

            var cdMendoza = new CentroDistribucion
            {
                nombre = "Cuyo - Mendoza"
            };
            
            var cdBuenosAires = new CentroDistribucion
            {
                nombre = "Capital Federal - Buenos Aires"
            };

            // Empresa Transporte
            var empresa1 = new EmpresaTransporte
            {
                razonSocial = "Transportes Argentinos"
            };

            var empresa2 = new EmpresaTransporte
            {
                razonSocial = "Expreso Nacional"
            };

            // SERVICIO 1
            var guia1 = new Guia
            {
                NroGuia = "G0001",
                TipoBulto = TiposBultoEnum.S,
                modalidadEntrega = ModalidadEntrega.EntregaDomicilio,
                CDOrigen = cdCordoba,
                CDActual = cdCordoba,
                CDDestino = cdMendoza,
                estado = EstadoGuiaEnum.EnTransito
            };

            var guia2 = new Guia
            {
                NroGuia = "G0002",
                TipoBulto = TiposBultoEnum.M,
                modalidadEntrega = ModalidadEntrega.EntregaAgencia,
                CDOrigen = cdCordoba,
                CDActual = cdCordoba,
                CDDestino = cdMendoza,
                estado = EstadoGuiaEnum.EnTransito
            };

            var guia3 = new Guia
            {
                NroGuia = "G0003",
                TipoBulto = TiposBultoEnum.XL,
                modalidadEntrega = ModalidadEntrega.EntregaCD,
                CDOrigen = cdCordoba,
                CDActual = cdCordoba,
                CDDestino = cdMendoza,
                estado = EstadoGuiaEnum.EnTransito
            };

            var hdr1 = new HojaDeRutaTransporte
            {
                NroHDR = 1001,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<Guia>
                {
                    guia1,
                    guia2
                }
            };

            var hdr2 = new HojaDeRutaTransporte
            {
                NroHDR = 1002,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<Guia>
                {
                    guia3
                }
            };

            var servicio1 = new ServicioMediaDistancia
            {
                idServicio = 1,
                EmpresaTransporte = empresa1,
                fechaLlegada= new DateTime(2026, 6, 2, 8, 30, 0),
                fechaRecepcion= null,
                DetalleHDRs = new List<HojaDeRutaTransporte>
                {
                    hdr1,
                    hdr2
                }
            };

            // SERVICIO 2

            var guia4 = new Guia
            {
                NroGuia = "G0004",
                TipoBulto = TiposBultoEnum.L,
                modalidadEntrega = ModalidadEntrega.EntregaDomicilio,
                CDOrigen = cdMendoza,
                CDActual = cdMendoza,
                CDDestino = cdCordoba,
                estado = EstadoGuiaEnum.EnTransito
            };

            var guia5 = new Guia
            {
                NroGuia = "G0005",
                TipoBulto = TiposBultoEnum.M,
                modalidadEntrega = ModalidadEntrega.EntregaCD,
                CDOrigen = cdMendoza,
                CDActual = cdMendoza,
                CDDestino = cdCordoba,
                estado = EstadoGuiaEnum.EnTransito
            };

            var hdr3 = new HojaDeRutaTransporte
            {
                NroHDR = 2001,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<Guia>
                {
                    guia4,
                    guia5
                }
            };

            var servicio2 = new ServicioMediaDistancia
            {
                idServicio = 2,
                EmpresaTransporte = empresa2,
                fechaLlegada = new DateTime(2026, 5, 29, 16, 30, 0),
                fechaRecepcion = null,
                DetalleHDRs = new List<HojaDeRutaTransporte>
                {
                    hdr3
                }
            };

            //SERVICIO 3
            var guia6 = new Guia
            {
                NroGuia = "G0006",
                TipoBulto = TiposBultoEnum.S,
                modalidadEntrega = ModalidadEntrega.EntregaDomicilio,
                CDOrigen = cdCordoba,
                CDActual = cdCordoba,
                CDDestino = cdBuenosAires,
                estado = EstadoGuiaEnum.EnTransito
            };

            var hdr4 = new HojaDeRutaTransporte
            {
                NroHDR = 3001,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<Guia>
                {
                    guia6
                }
            };

            var servicio3 = new ServicioMediaDistancia
            {
                idServicio = 3,
                EmpresaTransporte = empresa1,
                fechaLlegada = new DateTime(2026, 5, 25, 11, 30, 0),
                fechaRecepcion = new DateTime(2026, 5, 30, 15, 30, 0),
                DetalleHDRs = new List<HojaDeRutaTransporte>
                {
                    hdr4
                }
            };

            Servicios = new List<ServicioMediaDistancia>
            {
                servicio1,
                servicio2,
                servicio3
            };

        }
    }
}
