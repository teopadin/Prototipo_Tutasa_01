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

        public ModeloGenerarHDRRetiro()
        {
            // CDs
            var cdCapital = new CentroDistribucion { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { IdCD = 2, Nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucion { IdCD = 3, Nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucion { IdCD = 4, Nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucion { IdCD = 5, Nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucion { IdCD = 6, Nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDistribucion>
            {
                cdCapital, cdCentro, cdNorte, cdEste, cdCordillera, cdSur
            };

            CdEmisor = cdCapital;

            // Transportistas
            var t1 = new TransportistaLocal { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez", CD = cdCapital, HdrAsignadas = 2 };
            var t2 = new TransportistaLocal { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez", CD = cdCapital, HdrAsignadas = 0 };
            var t3 = new TransportistaLocal { DniTransportista = 34567890, Nombre = "Pedro", Apellido = "Lopez", CD = cdCentro, HdrAsignadas = 1 };

            Transportistas = new List<TransportistaLocal> { t1, t2, t3 };

            // Agencias
            var agencia1 = new Agencia { IdAgencia = 1, RazonSocial = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, Piso = "PB", CodigoPostal = "1043", Ciudad = "Buenos Aires", CD = cdCapital };
            var agencia2 = new Agencia { IdAgencia = 2, RazonSocial = "Agencia Sur SRL", Calle = "San Martín", Altura = 500, Piso = "1", CodigoPostal = "1043", Ciudad = "Buenos Aires", CD = cdCapital };

            // Clientes
            var cliente1 = new Cliente { Cuit = "20-12345678-9", RazonSocial = "Empresa ABC SA", Calle = "Av. Rivadavia", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" };
            var cliente2 = new Cliente { Cuit = "30-23456789-1", RazonSocial = "Distribuidora XYZ SRL", Calle = "Av. Rivadavia", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" };
            var cliente3 = new Cliente { Cuit = "20-34567890-2", RazonSocial = "Comercio El Sol", Calle = "Belgrano", Altura = 750, Piso = "PB", CodigoPostal = "5000", Ciudad = "Córdoba" };

            // Guías
            Guias = new List<Guia>
            {
                // Domicilio cliente, origen Capital - misma dirección para probar filtro
                new Guia { NroGuia = "CD01-0001", FechaImposicion = new DateTime(2026, 5, 20), TipoImposicion = TipoImposicion.CallCenter, TipoBulto = TipoBulto.M, ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.Impuesta, CdOrigen = cdCapital, CdDestino = cdNorte, Cliente = cliente1, Agencia = null },
                new Guia { NroGuia = "CD01-0002", FechaImposicion = new DateTime(2026, 5, 21), TipoImposicion = TipoImposicion.CallCenter, TipoBulto = TipoBulto.L, ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.Impuesta, CdOrigen = cdCapital, CdDestino = cdCentro, Cliente = cliente2, Agencia = null },

                // Retiro en agencia, origen Capital
                new Guia { NroGuia = "A001-0001", FechaImposicion = new DateTime(2026, 5, 22), TipoImposicion = TipoImposicion.Agencia, TipoBulto = TipoBulto.S, ModalidadEntrega = ModalidadEntrega.RetiroEnAgencia, Estado = EstadoGuia.Impuesta, CdOrigen = cdCapital, CdDestino = cdNorte, Cliente = null, Agencia = agencia1 },
                new Guia { NroGuia = "A001-0002", FechaImposicion = new DateTime(2026, 5, 23), TipoImposicion = TipoImposicion.Agencia, TipoBulto = TipoBulto.XL, ModalidadEntrega = ModalidadEntrega.RetiroEnAgencia, Estado = EstadoGuia.Impuesta, CdOrigen = cdCapital, CdDestino = cdEste, Cliente = null, Agencia = agencia1 },
                new Guia { NroGuia = "A002-0001", FechaImposicion = new DateTime(2026, 5, 24), TipoImposicion = TipoImposicion.Agencia, TipoBulto = TipoBulto.M, ModalidadEntrega = ModalidadEntrega.RetiroEnAgencia, Estado = EstadoGuia.Impuesta, CdOrigen = cdCapital, CdDestino = cdSur, Cliente = null, Agencia = agencia2 },

                // Domicilio cliente, origen Córdoba - NO debe aparecer (CD origen != CD emisor)
                new Guia { NroGuia = "CD02-0001", FechaImposicion = new DateTime(2026, 5, 22), TipoImposicion = TipoImposicion.CallCenter, TipoBulto = TipoBulto.S, ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.Impuesta, CdOrigen = cdCentro, CdDestino = cdNorte, Cliente = cliente3, Agencia = null },

                // En otro estado - NO debe aparecer
                new Guia { NroGuia = "CD01-0003", FechaImposicion = new DateTime(2026, 5, 19), TipoImposicion = TipoImposicion.CallCenter, TipoBulto = TipoBulto.L, ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.PendienteDeRetiroPorTransportista, CdOrigen = cdCapital, CdDestino = cdNorte, Cliente = cliente1, Agencia = null },
            };

        }
    }
}
