using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class ModeloRecibirServicioMediaDistancia
    {
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public ServicioMediaDistancia ServicioActual { get; set; }
        public ModeloRecibirServicioMediaDistancia() 
        {
            // CDs
            var cdCordoba = new CentroDeDistribucion
            {
                Nombre = "Centro - Córdoba"
            };

            var cdMendoza = new CentroDeDistribucion
            {
                Nombre = "Cuyo - Mendoza"
            };

            // Empresa Transporte
            var empresa1 = new EmpresaTransporte
            {
                RazonSocial = "Transportes Argentinos"
            };

            var empresa2 = new EmpresaTransporte
            {
                RazonSocial = "Expreso Nacional"
            };
            
            // SERVICIO 1
            var guia1 = new Guia
            {
                NroGuia = "G0001",
                TipoBulto = TiposBulto.S,
                Modalidad = ModalidadEntrega.PuertaAPuerta,
                CDOrigen = cdCordoba,
                Estado = EstadoGuia.EnTransito
            };

            var guia2 = new Guia
            {
                NroGuia = "G0002",
                TipoBulto = TiposBulto.M,
                Modalidad = ModalidadEntrega.RetiroEnAgencia,
                CDOrigen = cdCordoba,
                Estado = EstadoGuia.EnTransito
            };

            var guia3 = new Guia
            {
                NroGuia = "G0003",
                TipoBulto = TiposBulto.XL,
                Modalidad = ModalidadEntrega.RetiroEnCD,
                CDOrigen = cdCordoba,
                Estado = EstadoGuia.EnTransito
            };

            var hdr1 = new HojaDeRutaTransporte
            {
                NroHDR = 1001,
                Estado = EstadoHojaDeRuta.EnCurso,
                Guias = new List<Guia>
                {
                    guia1,
                    guia2
                }
            };

            var hdr2 = new HojaDeRutaTransporte
            {
                NroHDR = 1002,
                Estado = EstadoHojaDeRuta.EnCurso,
                Guias = new List<Guia>
                {
                    guia3
                }
            };

            var servicio1 = new ServicioMediaDistancia
            {
                IdServicio = 1,
                EmpresaTransporte = empresa1,
                FechaDespacho= new DateTime(2026, 6, 2, 8, 30, 0),
                FechaRecepcion= null,
                HDRs = new List<HojaDeRutaTransporte>
                {
                    hdr1,
                    hdr2
                }
            };

            // SERVICIO 2

            var guia4 = new Guia
            {
                NroGuia = "G0004",
                TipoBulto = TiposBulto.L,
                Modalidad = ModalidadEntrega.PuertaAPuerta,
                CDOrigen = cdMendoza,
                Estado = EstadoGuia.EnTransito
            };

            var guia5 = new Guia
            {
                NroGuia = "G0005",
                TipoBulto = TiposBulto.M,
                Modalidad = ModalidadEntrega.RetiroEnCD,
                CDOrigen = cdMendoza,
                Estado = EstadoGuia.EnTransito
            };

            var hdr3 = new HojaDeRutaTransporte
            {
                NroHDR = 2001,
                Estado = EstadoHojaDeRuta.EnCurso,
                Guias = new List<Guia>
                {
                    guia4,
                    guia5
                }
            };

            var servicio2 = new ServicioMediaDistancia
            {
                IdServicio = 2,
                EmpresaTransporte = empresa2,
                FechaDespacho = new DateTime(2026, 5, 29, 16, 30, 0),
                FechaRecepcion = null,
                HDRs = new List<HojaDeRutaTransporte>
                {
                    hdr3
                }
            };

            //SERVICIO 3
            var guia6 = new Guia
            {
                NroGuia = "G0006",
                TipoBulto = TiposBulto.S,
                Modalidad = ModalidadEntrega.PuertaAPuerta,
                Estado = EstadoGuia.EnTransito,
                CDOrigen = cdCordoba
            };

            var hdr4 = new HojaDeRutaTransporte
            {
                NroHDR = 3001,
                Estado = EstadoHojaDeRuta.EnCurso,
                Guias = new List<Guia>
                {
                    guia6
                }
            };

            var servicio3 = new ServicioMediaDistancia
            {
                IdServicio = 3,
                EmpresaTransporte = empresa1,
                FechaDespacho = new DateTime(2026, 5, 25, 11, 30, 0),
                FechaRecepcion = new DateTime(2026, 5, 30, 15, 30, 0),
                HDRs = new List<HojaDeRutaTransporte>
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
