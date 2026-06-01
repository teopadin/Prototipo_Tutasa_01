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
        public CentroDistribucionEntidad CdEmisor { get; set; }
        public List<CentroDistribucionEntidad> CentrosDeDistribucion { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public List<TransportistaLocalEntidad> Transportistas { get; set; }
        public List<HojaDeRutaDistribucionEntidad> HojasDeRuta { get; set; }
        public bool Actualizando { get; set; } = false;

        public ModeloGenerarHDRDistribucion()
        {
            // CDs
            var cdCapital = new CentroDistribucionEntidad { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucionEntidad { IdCD = 2, Nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucionEntidad { IdCD = 3, Nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucionEntidad { IdCD = 4, Nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucionEntidad { IdCD = 5, Nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucionEntidad { IdCD = 6, Nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDistribucionEntidad>
            {
                cdCapital, cdCentro, cdNorte, cdEste, cdCordillera, cdSur
            };

            CdEmisor = cdCapital;

            // Transportistas
            var t1 = new TransportistaLocalEntidad { DniTransportista = 12345678, Nombre = "Carlos", Apellido = "Gomez", CD = cdCapital, HdrAsignadas = 2 };
            var t2 = new TransportistaLocalEntidad { DniTransportista = 23456789, Nombre = "Laura", Apellido = "Martinez", CD = cdCapital, HdrAsignadas = 0 };
            var t3 = new TransportistaLocalEntidad { DniTransportista = 34567890, Nombre = "Pedro", Apellido = "Lopez", CD = cdCentro, HdrAsignadas = 1 };

            Transportistas = new List<TransportistaLocalEntidad> { t1, t2, t3 };

            // Agencias
            var agencia1 = new AgenciaEntidad { IdAgencia = 1, RazonSocial = "Agencia Norte SA", Calle = "Av. Corrientes", Altura = 1234, Piso = "PB", CodigoPostal = "1043", Ciudad = "Buenos Aires", CD = cdCapital };
            var agencia2 = new AgenciaEntidad { IdAgencia = 2, RazonSocial = "Agencia Sur SRL", Calle = "San Martín", Altura = 500, Piso = "1", CodigoPostal = "1043", Ciudad = "Buenos Aires", CD = cdCapital };

            // Destinatarios
            var dest1 = new DestinatarioEntidad { Dni = 40123456, Nombre = "Ana", Apellido = "Pérez", Calle = "Av. Rivadavia", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" };
            var dest2 = new DestinatarioEntidad { Dni = 41234567, Nombre = "Juan", Apellido = "Rodríguez", Calle = "Av. Santa Fe", Altura = 3200, Piso = "3B", CodigoPostal = "1406", Ciudad = "Buenos Aires" };
            var dest3 = new DestinatarioEntidad { Dni = 42345678, Nombre = "María", Apellido = "González", Calle = "Belgrano", Altura = 750, Piso = "PB", CodigoPostal = "5000", Ciudad = "Córdoba" };

            // Guías
            Guias = new List<GuiaEntidad>
            {
                // Puerta a puerta, origen CD Norte, destino Capital
                new GuiaEntidad { NroGuia = "CD03-0001", FechaImposicion = new DateTime(2026, 5, 20), ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = dest1, Agencia = null },

                // Puerta a puerta, origen CD Centro, destino Capital - misma dirección que CD03-0001 para probar filtro
                new GuiaEntidad { NroGuia = "CD02-0001", FechaImposicion = new DateTime(2026, 5, 21), ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.EnCDDestino, CdOrigen = cdCentro, CdDestino = cdCapital, Destinatario = dest2, Agencia = null },

                // Retiro en agencia, origen Agencia 1, destino Capital
                new GuiaEntidad { NroGuia = "A001-0001", FechaImposicion = new DateTime(2026, 5, 22), ModalidadEntrega = ModalidadEntrega.RetiroEnAgencia, Estado = EstadoGuia.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = null, Agencia = agencia1 },

                // Retiro en agencia, origen Agencia 2, destino Capital
                new GuiaEntidad { NroGuia = "A002-0001", FechaImposicion = new DateTime(2026, 5, 23), ModalidadEntrega = ModalidadEntrega.RetiroEnAgencia, Estado = EstadoGuia.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = null, Agencia = agencia2 },

                // Retiro en agencia, origen Agencia 1, destino Capital
                new GuiaEntidad { NroGuia = "A001-0002", FechaImposicion = new DateTime(2026, 5, 24), ModalidadEntrega = ModalidadEntrega.RetiroEnAgencia, Estado = EstadoGuia.EnCDDestino, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = null, Agencia = agencia1 },

                // Puerta a puerta, destino Córdoba - NO debe aparecer (CD destino != CD emisor)
                new GuiaEntidad { NroGuia = "CD01-0001", FechaImposicion = new DateTime(2026, 5, 22), ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.EnCDDestino, CdOrigen = cdCapital, CdDestino = cdCentro, Destinatario = dest3, Agencia = null },

                // En distribución - NO debe aparecer (estado incorrecto)
                new GuiaEntidad { NroGuia = "CD03-0002", FechaImposicion = new DateTime(2026, 5, 19), ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.EnDistribucion, CdOrigen = cdNorte, CdDestino = cdCapital, Destinatario = dest1, Agencia = null },

                new GuiaEntidad { NroGuia = "CD01-0002", FechaImposicion = new DateTime(2026, 5, 25), ModalidadEntrega = ModalidadEntrega.PuertaAPuerta, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdCapital, Destinatario = dest1, Agencia = null },
            };

            HojasDeRuta = new List<HojaDeRutaDistribucionEntidad>();
        }
    }
} 