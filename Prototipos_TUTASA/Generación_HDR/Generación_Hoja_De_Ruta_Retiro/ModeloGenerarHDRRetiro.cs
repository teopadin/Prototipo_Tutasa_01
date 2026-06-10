using Prototipos_TUTASA.ResultadoCostoVSVentas_v2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro
{
    internal class ModeloGenerarHDRRetiro
    {
            public CentroDistribucion CdEmisor { get; set; }
            public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
            public List<Guia> Guias { get; set; }
            public List<TransportistaLocal> Transportistas { get; set; }
            public bool Actualizando { get; set; } = false;
            public List<HojaDeRutaRetiro> HojasDeRuta { get; set; } = new List<HojaDeRutaRetiro>();

        public ModeloGenerarHDRRetiro()
        {
            // CDs
            var cdCapital = new CentroDistribucion { nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucion { nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucion { nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucion { nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucion { nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDistribucion>
            {
                cdCapital, cdCentro, cdNorte, cdEste, cdCordillera, cdSur
            };

            CdEmisor = cdCapital;

            // Transportistas
            var t1 = new TransportistaLocal { dniTransportista = 12345678, nombre = "Carlos", apellido = "Gomez", idCD = cdCapital, HdrAsignadas = 2 };
            var t2 = new TransportistaLocal { dniTransportista = 23456789, nombre = "Laura", apellido = "Martinez", idCD = cdCapital, HdrAsignadas = 0 };
            var t3 = new TransportistaLocal { dniTransportista = 34567890, nombre = "Pedro", apellido = "Lopez", idCD = cdCentro, HdrAsignadas = 1 };

            Transportistas = new List<TransportistaLocal> { t1, t2, t3 };

            // Agencias
            var agencia1 = new Agencia { razonSocial = "Agencia Norte SA", calle = "Av. Corrientes", altura = 1234, piso = "PB", codigoPostal = "1043", ciudad = "Buenos Aires", idCD = cdCapital };
            var agencia2 = new Agencia { razonSocial = "Agencia Sur SRL", calle = "San Martín", altura = 500, piso = "1", codigoPostal = "1043", ciudad = "Buenos Aires", idCD = cdCapital };

            // Clientes
            var cliente1 = new Cliente { razonSocial = "Empresa ABC SA", calle = "Av. Rivadavia", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var cliente2 = new Cliente { razonSocial = "Distribuidora XYZ SRL", calle = "Av. Rivadavia", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var cliente3 = new Cliente { razonSocial = "Comercio El Sol", calle = "Belgrano", altura = 750, piso = "PB", codigoPostal = "5000", ciudad = "Córdoba" };

            // Guías
            Guias = new List<Guia>
            {
                // Domicilio cliente, origen Capital - misma dirección para probar filtro
                new Guia { NroGuia = "CD01-0001", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.M, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital, idCDDestino = cdNorte, IdCliente = cliente1, idAgenciaOrigen = null },
                new Guia { NroGuia = "CD01-0002", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.L, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital, idCDDestino = cdCentro, IdCliente = cliente2, idAgenciaOrigen = null },

                // Retiro en agencia, origen Capital
                new Guia { NroGuia = "A001-0001", TipoImposicion = TipoImposicionEnum.Agencia, TipoBulto = TipoBultoEnum.S, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital, idCDDestino = cdNorte, IdCliente = null, idAgenciaOrigen = agencia1 },
                new Guia { NroGuia = "A001-0002", TipoImposicion = TipoImposicionEnum.Agencia, TipoBulto = TipoBultoEnum.XL, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital, idCDDestino = cdEste, IdCliente = null, idAgenciaOrigen = agencia1 },
                new Guia { NroGuia = "A002-0001", TipoImposicion = TipoImposicionEnum.Agencia, TipoBulto = TipoBultoEnum.M, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital, idCDDestino = cdSur, IdCliente = null, idAgenciaOrigen = agencia2 },

                // Domicilio cliente, origen Córdoba - NO debe aparecer (CD origen != CD emisor)
                new Guia { NroGuia = "CD02-0001", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.S, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCentro, idCDDestino = cdNorte, IdCliente = cliente3, idAgenciaOrigen = null },

                // En otro estado - NO debe aparecer
                new Guia { NroGuia = "CD01-0003", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.L, Estado = EstadoGuiaEnum.IncluidaEnHDRRetiro, idCDOrigen = cdCapital, idCDDestino = cdNorte, IdCliente = cliente1, idAgenciaOrigen = null },
            };

        }
    }
}
