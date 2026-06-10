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
        public Queue<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public bool Actualizando { get; set; } = false;
        public List<HojaDeRutaDistribucion> HojasDeRuta { get; set; } = new List<HojaDeRutaDistribucion>();

        public ModeloGenerarHDRDistribucion()
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

            // Destinatarios
            var dest1 = new DestinatarioGuia { Dni = 40123456, nombre = "Ana", apellido = "Pérez", calle = "Av. Rivadavia", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var dest2 = new DestinatarioGuia { Dni = 41234567, nombre = "Juan", apellido = "Rodríguez", calle = "Av. Santa Fe", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var dest3 = new DestinatarioGuia { Dni = 42345678, nombre = "María", apellido = "González", calle = "Belgrano", altura = 750, piso = "PB", codigoPostal = "5000", ciudad = "Córdoba" };

            // Guías
            var guiasEnOrdenDeLlegada = new List<Guia>
            {
                // Puerta a puerta, origen CD Norte, destino Capital
                new Guia { NroGuia = "CD03-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte, idCDDestino = cdCapital, Destinatario = dest1, idAgenciaDestino = null },

                // Puerta a puerta, origen CD Centro, destino Capital - misma dirección que CD03-0001 para probar filtro
                new Guia { NroGuia = "CD02-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdCentro, idCDDestino = cdCapital, Destinatario = dest2, idAgenciaDestino = null },

                // Retiro en agencia, origen Agencia 1, destino Capital
                new Guia { NroGuia = "A001-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte, idCDDestino = cdCapital, Destinatario = null, idAgenciaDestino = agencia1 },

                // Retiro en agencia, origen Agencia 2, destino Capital
                new Guia { NroGuia = "A002-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte, idCDDestino = cdCapital, Destinatario = null, idAgenciaDestino = agencia2 },

                // Retiro en agencia, origen Agencia 1, destino Capital
                new Guia { NroGuia = "A001-0002", ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte, idCDDestino = cdCapital, Destinatario = null, idAgenciaDestino = agencia1 },

                // Puerta a puerta, destino Córdoba - NO debe aparecer (CD destino != CD emisor)
                new Guia { NroGuia = "CD01-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdCapital, idCDDestino = cdCentro, Destinatario = dest3, idAgenciaDestino = null },

                // En distribución - NO debe aparecer (estado incorrecto)
                new Guia { NroGuia = "CD03-0002", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnDistribucion, idCDOrigen = cdNorte, idCDDestino = cdCapital, Destinatario = dest1, idAgenciaDestino = null },

                new Guia { NroGuia = "CD01-0002", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.Admitida, idCDOrigen = cdCapital, idCDDestino = cdCapital, Destinatario = dest1, idAgenciaDestino = null },
            };
            Guias = new Queue<Guia>(guiasEnOrdenDeLlegada);

        }
    }
} 