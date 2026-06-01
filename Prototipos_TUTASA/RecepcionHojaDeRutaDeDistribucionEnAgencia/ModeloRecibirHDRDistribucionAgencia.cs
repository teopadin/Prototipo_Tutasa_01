using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class ModeloRecibirHDRDistribucionAgencia
    {
        public AgenciaEntidad AgenciaLogueada { get; set; }

        public List<CentroDeDistribucionEntidad> CentrosDeDistribucion { get; set; }

        public List<AgenciaEntidad> Agencias { get; set; }

        public List<TransportistaLocalEntidad> Transportistas { get; set; }

        public List<GuiaEntidad> Guias { get; set; }

        public List<HojaDeRutaDistribucionEntidad> HojasDeRutaDistribucion { get; set; }

        public ModeloRecibirHDRDistribucionAgencia()
        {
            // CDs
            var cdCapital = new CentroDeDistribucionEntidad { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDeDistribucionEntidad { IdCD = 2, Nombre = "Centro - Córdoba" };

            CentrosDeDistribucion = new List<CentroDeDistribucionEntidad>
        {
            cdCapital,
            cdCentro
        };

            // Agencias
            var agencia1 = new AgenciaEntidad
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

            var agencia2 = new AgenciaEntidad
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

            Agencias = new List<AgenciaEntidad>
        {
            agencia1,
            agencia2
        };

            // Simulación operador logueado
            AgenciaLogueada = agencia1;

            // Transportistas
            var t1 = new TransportistaLocalEntidad
            {
                DniTransportista = 12345678,
                Nombre = "Carlos",
                Apellido = "Gomez",
                IdCD = cdCapital
            };

            var t2 = new TransportistaLocalEntidad
            {
                DniTransportista = 23456789,
                Nombre = "Laura",
                Apellido = "Martinez",
                IdCD = cdCapital
            };

            Transportistas = new List<TransportistaLocalEntidad>
        {
            t1,
            t2
        };

            // Guías
            var g1 = new GuiaEntidad
            {
                NroGuia = "GD-0001",
                TipoBulto = TiposBulto.S,
                Agencia = agencia1
            };

            var g2 = new GuiaEntidad
            {
                NroGuia = "GD-0002",
                TipoBulto = TiposBulto.M,
                Agencia = agencia1
            };

            var g3 = new GuiaEntidad
            {
                NroGuia = "GD-0003",
                TipoBulto = TiposBulto.L,
                Agencia = agencia1
            };

            var g4 = new GuiaEntidad
            {
                NroGuia = "GD-0004",
                TipoBulto = TiposBulto.XL,
                Agencia = agencia2
            };

            Guias = new List<GuiaEntidad>
        {
            g1, g2, g3, g4
        };

            // HDR de Distribución
            HojasDeRutaDistribucion = new List<HojaDeRutaDistribucionEntidad>
        {
            new HojaDeRutaDistribucionEntidad
            {
                NroHDR = 1001,
                FechaEmision = new DateTime(2026, 5, 25),
                Agencia = agencia1,
                Transportista = t1,
                Guias = new List<GuiaEntidad>{ g1, g2 },
                Estado = EstadoHojaDeRuta.EnCurso
            },

            new HojaDeRutaDistribucionEntidad
            {
                NroHDR = 1002,
                FechaEmision = new DateTime(2026, 5, 26),
                Agencia = agencia1,
                Transportista = t2,
                Guias = new List<GuiaEntidad>{ g3 },
                Estado = EstadoHojaDeRuta.EnCurso
            },

            new HojaDeRutaDistribucionEntidad
            {
                NroHDR = 1003,
                FechaEmision = new DateTime(2026, 5, 24),
                Agencia = agencia2,
                Transportista = t1,
                Guias = new List<GuiaEntidad>{ g4 },
                Estado = EstadoHojaDeRuta.Recibida
            }
        };
        }
    }
}
