using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class ModeloRecibirHDRDistribucionAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public List<HojaDeRutaDistribucion> HojasDeRutaDistribucion { get; set; }

        public HojaDeRutaDistribucion HdrActual { get; set; }

        public ModeloRecibirHDRDistribucionAgencia()
        {
            
            // Agencias
            var agencia1 = new Agencia
            {
                idAgencia = 1,
                razonSocial = "Agencia Norte SA",
            };

            var agencia2 = new Agencia
            {
                idAgencia = 2,
                razonSocial = "Agencia Sur SRL",

            };

            // Simulación operador logueado
            AgenciaLogueada = agencia1;

            // Transportistas
            var t1 = new TransportistaLocal
            {
                nombre = "Carlos",
                apellido = "Gomez",
            };

            var t2 = new TransportistaLocal
            {
                nombre = "Laura",
                apellido = "Martinez",
            };

            // Guías
            var g1 = new Guia
            {
                NroGuia = "GD-0001",
                TipoBulto = TiposBultoEnum.S,
                AgenciaGuia = agencia1,
                estado = EstadoGuia.EnDistribucion
            };

            var g2 = new Guia
            {
                NroGuia = "GD-0002",
                TipoBulto = TiposBultoEnum.M,
                AgenciaGuia = agencia1,
                estado = EstadoGuia.EnDistribucion
            };

            var g3 = new Guia
            {
                NroGuia = "GD-0003",
                TipoBulto = TiposBultoEnum.L,
                AgenciaGuia = agencia1,
                estado = EstadoGuia.EnDistribucion
            };

            var g4 = new Guia
            {
                NroGuia = "GD-0004",
                TipoBulto = TiposBultoEnum.XL,
                AgenciaGuia = agencia2,
                estado = EstadoGuia.EnDistribucion
            };

            // HDR válida
            var hdr1 = new HojaDeRutaDistribucion
            {
                NroHDR = 1001,
                AgenciaHDR = agencia1,
                Transportista = t1,
                DetalleGuias = new List<Guia>
                {
                    g1,
                    g2
                },
                estado = EstadoHojaDeRuta.EnCurso
            };

            // HDR válida adicional
            var hdr2 = new HojaDeRutaDistribucion
            {
                NroHDR = 1002,
                AgenciaHDR = agencia1,
                Transportista = t2,
                DetalleGuias = new List<Guia>
                {
                    g3
                },
                estado = EstadoHojaDeRuta.EnCurso
            };

            // HDR de otra agencia (Excepción 3)
            var hdr3 = new HojaDeRutaDistribucion
            {
                NroHDR = 1003,
                AgenciaHDR = agencia2,
                Transportista = t1,
                DetalleGuias = new List<Guia>
                {
                    g4
                },
                estado = EstadoHojaDeRuta.EnCurso
            };

            // HDR ya recibida (Excepción 4)
            var hdr4 = new HojaDeRutaDistribucion
            {
                NroHDR = 1004,
                AgenciaHDR = agencia1,
                Transportista = t2,
                DetalleGuias = new List<Guia>
                {
                    g1
                },
                estado = EstadoHojaDeRuta.Recibida,
                Fecha = new DateTime(2026, 5, 25)
            };

            HojasDeRutaDistribucion = new List<HojaDeRutaDistribucion>
            {
                hdr1,
                hdr2,
                hdr3,
                hdr4
            };

        
        }
    }
}
