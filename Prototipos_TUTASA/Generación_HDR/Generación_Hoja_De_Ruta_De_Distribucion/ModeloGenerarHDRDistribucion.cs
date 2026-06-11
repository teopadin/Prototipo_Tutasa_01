using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class ModeloGenerarHDRDistribucion
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<Agencia> Agencias { get; set; }
        public Queue<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public bool Actualizando { get; set; } = false;
        public List<HojaDeRutaDistribucion> HojasDeRuta { get; set; } = new List<HojaDeRutaDistribucion>();

        public ModeloGenerarHDRDistribucion()
        {
            // CDs (ahora con idCD)
            var cdCapital = new CentroDistribucion { idCD = 1, nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { idCD = 2, nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucion { idCD = 3, nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucion { idCD = 4, nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucion { idCD = 5, nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucion { idCD = 6, nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDistribucion>
            {
                cdCapital, cdCentro, cdNorte, cdEste, cdCordillera, cdSur
            };

            CdEmisor = cdCapital;

            // Transportistas (idCD ahora es int)
            var t1 = new TransportistaLocal { dniTransportista = 12345678, nombre = "Carlos", apellido = "Gomez", idCD = cdCapital.idCD, HdrAsignadas = 2 };
            var t2 = new TransportistaLocal { dniTransportista = 23456789, nombre = "Laura", apellido = "Martinez", idCD = cdCapital.idCD, HdrAsignadas = 0 };
            var t3 = new TransportistaLocal { dniTransportista = 34567890, nombre = "Pedro", apellido = "Lopez", idCD = cdCentro.idCD, HdrAsignadas = 1 };

            Transportistas = new List<TransportistaLocal> { t1, t2, t3 };

            // Agencias (con idAgencia, idCD int)
            var agencia1 = new Agencia { idAgencia = 1, razonSocial = "Agencia Norte SA", calle = "Av. Corrientes", altura = 1234, piso = "PB", codigoPostal = "1043", ciudad = "Buenos Aires", idCD = cdCapital.idCD };
            var agencia2 = new Agencia { idAgencia = 2, razonSocial = "Agencia Sur SRL", calle = "San Martín", altura = 500, piso = "1", codigoPostal = "1043", ciudad = "Buenos Aires", idCD = cdCapital.idCD };

            Agencias = new List<Agencia> { agencia1, agencia2 };

            // Destinatarios (composición: se quedan como objetos dentro de la guía)
            var dest1 = new DestinatarioGuia { Dni = 40123456, nombre = "Ana", apellido = "Pérez", calle = "Av. Rivadavia", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var dest2 = new DestinatarioGuia { Dni = 41234567, nombre = "Juan", apellido = "Rodríguez", calle = "Av. Santa Fe", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var dest3 = new DestinatarioGuia { Dni = 42345678, nombre = "María", apellido = "González", calle = "Belgrano", altura = 750, piso = "PB", codigoPostal = "5000", ciudad = "Córdoba" };

            // Guías (CD por id, agencia por id, destinatario objeto)
            var guiasEnOrdenDeLlegada = new List<Guia>
            {
                // Puerta a puerta, origen CD Norte, destino Capital
                new Guia { NroGuia = "CD03-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte.idCD, idCDDestino = cdCapital.idCD, Destinatario = dest1, idAgenciaDestino = null },

                // Puerta a puerta, origen CD Centro, destino Capital - misma dirección que CD03-0001 para probar filtro
                new Guia { NroGuia = "CD02-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdCentro.idCD, idCDDestino = cdCapital.idCD, Destinatario = dest2, idAgenciaDestino = null },

                // Retiro en agencia, agencia 1, destino Capital
                new Guia { NroGuia = "A001-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte.idCD, idCDDestino = cdCapital.idCD, Destinatario = null, idAgenciaDestino = agencia1.idAgencia },

                // Retiro en agencia, agencia 2, destino Capital
                new Guia { NroGuia = "A002-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte.idCD, idCDDestino = cdCapital.idCD, Destinatario = null, idAgenciaDestino = agencia2.idAgencia },

                // Retiro en agencia, agencia 1, destino Capital
                new Guia { NroGuia = "A001-0002", ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdNorte.idCD, idCDDestino = cdCapital.idCD, Destinatario = null, idAgenciaDestino = agencia1.idAgencia },

                // Puerta a puerta, destino Córdoba - NO debe aparecer (CD destino != CD emisor)
                new Guia { NroGuia = "CD01-0001", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnCDDestino, idCDOrigen = cdCapital.idCD, idCDDestino = cdCentro.idCD, Destinatario = dest3, idAgenciaDestino = null },

                // En distribución - NO debe aparecer (estado incorrecto)
                new Guia { NroGuia = "CD03-0002", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.EnDistribucion, idCDOrigen = cdNorte.idCD, idCDDestino = cdCapital.idCD, Destinatario = dest1, idAgenciaDestino = null },

                new Guia { NroGuia = "CD01-0002", ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio, Estado = EstadoGuiaEnum.Admitida, idCDOrigen = cdCapital.idCD, idCDDestino = cdCapital.idCD, Destinatario = dest1, idAgenciaDestino = null },
            };
            Guias = new Queue<Guia>(guiasEnOrdenDeLlegada);
        }

        // Busca una agencia por su id. Devuelve null si no existe.
        public Agencia BuscarAgencia(int idAgencia)
        {
            foreach (Agencia agencia in Agencias)
            {
                if (agencia.idAgencia == idAgencia)
                    return agencia;
            }
            return null;
        }

        // En el modelo
        public HojaDeRutaDistribucion GenerarHDR(List<Guia> guias, TransportistaLocal transportista, DateTime fecha)
        {
            HojaDeRutaDistribucion nuevaHDR = new HojaDeRutaDistribucion();
            nuevaHDR.NroHDR = HojasDeRuta.Count + 1;
            nuevaHDR.Fecha = fecha;

            foreach (var guia in guias)
                guia.Estado = EstadoGuiaEnum.EnDistribucion;

            transportista.HdrAsignadas++;
            HojasDeRuta.Add(nuevaHDR);

            return nuevaHDR;
        }
    }
}