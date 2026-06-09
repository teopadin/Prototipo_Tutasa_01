using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class ModeloGenerarHDRDistribucion
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public bool Actualizando { get; set; } = false;
        public List<HojaDeRutaDistribucion> HojasDeRuta { get; set; } = new List<HojaDeRutaDistribucion>();

        public ModeloGenerarHDRDistribucion()
        {
            // CDs
            var cdCapital = new CentroDistribucion { Nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { Nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucion { Nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucion { Nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucion { Nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucion { Nombre = "Sur - Viedma" };

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
            var agencia1 = new Agencia { RazonSocial = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, Piso = "PB", CodigoPostal = "1043", Ciudad = "Buenos Aires", CD = cdCapital };
            var agencia2 = new Agencia { RazonSocial = "Agencia Sur SRL", Calle = "San Martín", Altura = 500, Piso = "1", CodigoPostal = "1043", Ciudad = "Buenos Aires", CD = cdCapital };

            // Destinatarios
            var dest1 = new DestinatarioGuia { Dni = 40123456, Nombre = "Ana", Apellido = "Pérez", Calle = "Av. Rivadavia", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" };
            var dest2 = new DestinatarioGuia { Dni = 41234567, Nombre = "Juan", Apellido = "Rodríguez", Calle = "Av. Santa Fe", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" };
            var dest3 = new DestinatarioGuia { Dni = 42345678, Nombre = "María", Apellido = "González", Calle = "Belgrano", Altura = 750, Piso = "PB", CodigoPostal = "5000", Ciudad = "Córdoba" };

            // Guías
            Guias = new List<Guia>
            {
                // Puerta a puerta, origen CD Norte, destino Capital
                new Guia { NroGuia = "CD03-0001", FechaImposicion = new DateTime(2026, 5, 20), ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = dest1, AgenciaGuia = null },

                // Puerta a puerta, origen CD Centro, destino Capital - misma dirección que CD03-0001 para probar filtro
                new Guia { NroGuia = "CD02-0001", FechaImposicion = new DateTime(2026, 5, 21), ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, CdOrigen = cdCentro, CdDestino = cdCapital, Destinatario = dest2, AgenciaGuia = null },

                // Retiro en agencia, origen Agencia 1, destino Capital
                new Guia { NroGuia = "A001-0001", FechaImposicion = new DateTime(2026, 5, 22), ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = null, AgenciaGuia = agencia1 },

                // Retiro en agencia, origen Agencia 2, destino Capital
                new Guia { NroGuia = "A002-0001", FechaImposicion = new DateTime(2026, 5, 23), ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = null, AgenciaGuia = agencia2 },

                // Retiro en agencia, origen Agencia 1, destino Capital
                new Guia { NroGuia = "A001-0002", FechaImposicion = new DateTime(2026, 5, 24), ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = null, AgenciaGuia = agencia1 },

                // Puerta a puerta, destino Córdoba - NO debe aparecer (CD destino != CD emisor)
                new Guia { NroGuia = "CD01-0001", FechaImposicion = new DateTime(2026, 5, 22), ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, CdOrigen = cdCapital, CdDestino = cdCentro, Destinatario = dest3, AgenciaGuia = null },

                // En distribución - NO debe aparecer (estado incorrecto)
                new Guia { NroGuia = "CD03-0002", FechaImposicion = new DateTime(2026, 5, 19), ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnDistribucion, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = dest1, AgenciaGuia = null },

                new Guia { NroGuia = "CD01-0002", FechaImposicion = new DateTime(2026, 5, 25), ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.Admitida, CdOrigen = cdCapital, CdDestino = cdCapital, Destinatario = dest1, AgenciaGuia = null },
            };

        }
    }
} 