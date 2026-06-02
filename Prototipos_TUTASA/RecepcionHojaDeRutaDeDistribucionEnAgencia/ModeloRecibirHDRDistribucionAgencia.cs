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
                IdAgencia = 1,
                RazonSocial = "Agencia Norte SA",
            };

            var agencia2 = new Agencia
            {
                IdAgencia = 2,
                RazonSocial = "Agencia Sur SRL",

            };

            // Simulación operador logueado
            AgenciaLogueada = agencia1;

            // Transportistas
            var t1 = new TransportistaLocal
            {
                Nombre = "Carlos",
                Apellido = "Gomez",
            };

            var t2 = new TransportistaLocal
            {
                Nombre = "Laura",
                Apellido = "Martinez",
            };

            // Guías
            var g1 = new Guia
            {
                NroGuia = "GD-0001",
                TipoBulto = TiposBulto.S,
                Agencia = agencia1,
                Estado = EstadoGuia.EnDistribucion
            };

            var g2 = new Guia
            {
                NroGuia = "GD-0002",
                TipoBulto = TiposBulto.M,
                Agencia = agencia1,
                Estado = EstadoGuia.EnDistribucion
            };

            var g3 = new Guia
            {
                NroGuia = "GD-0003",
                TipoBulto = TiposBulto.L,
                Agencia = agencia1,
                Estado = EstadoGuia.EnDistribucion
            };

            var g4 = new Guia
            {
                NroGuia = "GD-0004",
                TipoBulto = TiposBulto.XL,
                Agencia = agencia2,
                Estado = EstadoGuia.EnDistribucion
            };

            // HDR válida
            var hdr1 = new HojaDeRutaDistribucion
            {
                NroHDR = 1001,
                Agencia = agencia1,
                Transportista = t1,
                Guias = new List<Guia>
                {
                    g1,
                    g2
                },
                Estado = EstadoHojaDeRuta.EnCurso
            };

            // HDR válida adicional
            var hdr2 = new HojaDeRutaDistribucion
            {
                NroHDR = 1002,
                Agencia = agencia1,
                Transportista = t2,
                Guias = new List<Guia>
                {
                    g3
                },
                Estado = EstadoHojaDeRuta.EnCurso
            };

            // HDR de otra agencia (Excepción 3)
            var hdr3 = new HojaDeRutaDistribucion
            {
                NroHDR = 1003,
                Agencia = agencia2,
                Transportista = t1,
                Guias = new List<Guia>
                {
                    g4
                },
                Estado = EstadoHojaDeRuta.EnCurso
            };

            // HDR ya recibida (Excepción 4)
            var hdr4 = new HojaDeRutaDistribucion
            {
                NroHDR = 1004,
                Agencia = agencia1,
                Transportista = t2,
                Guias = new List<Guia>
                {
                    g1
                },
                Estado = EstadoHojaDeRuta.Recibida,
                FechaRecepcion = new DateTime(2026, 5, 25)
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
