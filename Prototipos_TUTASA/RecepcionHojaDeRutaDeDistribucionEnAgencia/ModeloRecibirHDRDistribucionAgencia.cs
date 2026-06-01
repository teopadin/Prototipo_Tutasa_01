using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class ModeloRecibirHDRDistribucionAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public List<CentroDeDistribucion> CentrosDeDistribucion { get; set; }

        public List<Agencia> Agencias { get; set; }

        public List<TransportistaLocal> Transportistas { get; set; }

        public List<Guia> Guias { get; set; }

        public List<HojaDeRutaDistribucion> HojasDeRutaDistribucion { get; set; }

        public HojaDeRutaDistribucion HdrActual { get; set; }

        public ModeloRecibirHDRDistribucionAgencia()
        {
            // CDs
            var cdCapital = new CentroDeDistribucion { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDeDistribucion { IdCD = 2, Nombre = "Centro - Córdoba" };

            CentrosDeDistribucion = new List<CentroDeDistribucion>
        {
            cdCapital,
            cdCentro
        };

            // Agencias
            var agencia1 = new Agencia
            {
                IdAgencia = 1,
                RazonSocial = "Agencia Norte SA",
                Calle = "Av. Corrientes",
                Altura = 1234,
                Piso = "PB",
                CodigoPostal = "1043",
                Ciudad = "Buenos Aires",
                IdCD = cdCapital
            };

            var agencia2 = new Agencia
            {
                IdAgencia = 2,
                RazonSocial = "Agencia Sur SRL",
                Calle = "San Martín",
                Altura = 500,
                Piso = "1",
                CodigoPostal = "1043",
                Ciudad = "Buenos Aires",
                IdCD = cdCapital
            };

            Agencias = new List<Agencia>
        {
            agencia1,
            agencia2
        };

            // Simulación operador logueado
            AgenciaLogueada = agencia1;

            // Transportistas
            var t1 = new TransportistaLocal
            {
                DniTransportista = 12345678,
                Nombre = "Carlos",
                Apellido = "Gomez",
                IdCD = cdCapital
            };

            var t2 = new TransportistaLocal
            {
                DniTransportista = 23456789,
                Nombre = "Laura",
                Apellido = "Martinez",
                IdCD = cdCapital
            };

            Transportistas = new List<TransportistaLocal>
        {
            t1,
            t2
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

            Guias = new List<Guia>
        {
            g1, g2, g3, g4
        };

            // HDR de Distribución
            HojasDeRutaDistribucion = new List<HojaDeRutaDistribucion>
        {
            new HojaDeRutaDistribucion
            {
                NroHDR = 1001,
                FechaEmision = new DateTime(2026, 5, 25),
                Agencia = agencia1,
                Transportista = t1,
                Guias = new List<Guia>{ g1, g2 },
                Estado = EstadoHojaDeRuta.EnCurso
            },

            new HojaDeRutaDistribucion
            {
                NroHDR = 1002,
                FechaEmision = new DateTime(2026, 5, 26),
                Agencia = agencia1,
                Transportista = t2,
                Guias = new List<Guia>{ g3 },
                Estado = EstadoHojaDeRuta.EnCurso
            },

            new HojaDeRutaDistribucion
            {
                NroHDR = 1003,
                FechaEmision = new DateTime(2026, 5, 24),
                Agencia = agencia2,
                Transportista = t1,
                Guias = new List<Guia>{ g4 },
                Estado = EstadoHojaDeRuta.Recibida
            }
        };
        }
    }
}
