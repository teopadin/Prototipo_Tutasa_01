using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class ModeloRecibirHDRRetiroAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public List<CentroDeDistribucion> CentrosDeDistribucion { get; set; }

        public HojaDeRutaRetiro HdrActual { get; set; }

        public List<Agencia> Agencias { get; set; }

        public List<HojaDeRutaRetiro> HojasDeRutaRetiro { get; set; }

        public List<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }

        public ModeloRecibirHDRRetiroAgencia()
        {
            // CDs
            var cdCapital = new CentroDeDistribucion { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDeDistribucion { IdCD = 2, Nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDeDistribucion { IdCD = 3, Nombre = "Norte - Tucumán" };
            var cdEste = new CentroDeDistribucion { IdCD = 4, Nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDeDistribucion { IdCD = 5, Nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDeDistribucion { IdCD = 6, Nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDeDistribucion>
            {
                cdCapital, cdCentro, cdNorte, cdEste, cdCordillera, cdSur
            };


            // Transportistas
            var t1 = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez", IdCD = cdCapital};
            var t2 = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez", IdCD = cdCapital};
            var t3 = new TransportistaLocal { DniTransportista = 34567890, Nombre = "Pedro", Apellido = "Lopez", IdCD = cdCentro};

            Transportistas = new List<TransportistaLocal> { t1, t2, t3 };

            // Agencias
            var agencia1 = new Agencia { IdAgencia = 1, RazonSocial = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, Piso = "PB", CodigoPostal = "1043", Ciudad = "Buenos Aires", IdCD = cdCapital };
            var agencia2 = new Agencia { IdAgencia = 2, RazonSocial = "Agencia Sur SRL", Calle = "San Martín", Altura = 500, Piso = "1", CodigoPostal = "1043", Ciudad = "Buenos Aires", IdCD = cdCapital };
            
            Agencias = new List<Agencia>
            {
                agencia1, agencia2
            };
            AgenciaLogueada = agencia1;

            // Guías
            Guias = new List<Guia>
            {
                // Domicilio cliente, origen Capital - misma dirección para probar filtro
                new Guia { NroGuia = "CD01-0001", TipoBulto = TiposBulto.M, Agencia = null },
                new Guia { NroGuia = "CD01-0002", TipoBulto = TiposBulto.L, Agencia = null },

                // Retiro en agencia, origen Capital
                new Guia { NroGuia = "A001-0001", TipoBulto = TiposBulto.S, Agencia = agencia1 },
                new Guia { NroGuia = "A001-0002", TipoBulto = TiposBulto.XL, Agencia = agencia1 },
                new Guia { NroGuia = "A002-0001", TipoBulto = TiposBulto.M, Agencia = agencia2 },

                // Domicilio cliente, origen Córdoba - NO debe aparecer (CD origen != CD emisor)
                new Guia { NroGuia = "CD02-0001", TipoBulto = TiposBulto.S, Agencia = null },

                // En otro estado - NO debe aparecer
                new Guia { NroGuia = "CD01-0003", TipoBulto = TiposBulto.L, Agencia = null },
            };
            HojasDeRutaRetiro = new List<HojaDeRutaRetiro>();

            // HDR válida para flujo normal
            var hdr1 = new HojaDeRutaRetiro
            {
                NroHDR = 1001, FechaEmision = new DateTime(2026, 5, 25), Agencia = agencia1, Transportista = t1, Estado = EstadoHojaDeRuta.EnCurso,
                Guias = new List<Guia>
                {
                    Guias[2], // A001-0001
                    Guias[3]  // A001-0002
                }
            };

            // HDR de otra agencia (para excepción 3)
            var hdr2 = new HojaDeRutaRetiro
            {
                NroHDR = 1002, FechaEmision = new DateTime(2026, 5, 26), Agencia = agencia2, Transportista = t2, Estado = EstadoHojaDeRuta.EnCurso,
                Guias = new List<Guia>
                {
                    Guias[4] // A002-0001
                }
            };

            // HDR ya recibida (para excepción 4)
            var hdr3 = new HojaDeRutaRetiro
            {
                NroHDR = 1003, FechaEmision = new DateTime(2026, 5, 24), FechaRecepcion = new DateTime(2026, 5, 25), Agencia = agencia1, Transportista = t1, Estado = EstadoHojaDeRuta.Recibida,
                Guias = new List<Guia>
                {
                    Guias[2]
                }
            };

            HojasDeRutaRetiro = new List<HojaDeRutaRetiro>
            { hdr1, hdr2, hdr3 };

        }
    }
}
