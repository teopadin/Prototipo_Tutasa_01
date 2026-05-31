using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.Imposición_Agencia
{
        internal class ModeloImposicionAgencia
    {
        public List<ClienteEntidad> Clientes { get; set; }
        public List<AgenciaEntidad> Agencias { get; set; }
        public List<CentroDistribucionEntidad> CentrosDeDistribucion { get; set; }
        public AgenciaEntidad AgenciaOperadora { get; set; }
        public CentroDistribucionEntidad CdOrigen { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public List<RendicionAgenciaEntidad> RendicionesAgencia { get; set; }

        public ModeloImposicionAgencia()
        {
            // CDs
            var cdCapital    = new CentroDistribucionEntidad { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro     = new CentroDistribucionEntidad { IdCD = 2, Nombre = "Centro - Córdoba" };
            var cdNorte      = new CentroDistribucionEntidad { IdCD = 3, Nombre = "Norte - Tucumán" };
            var cdEste       = new CentroDistribucionEntidad { IdCD = 4, Nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucionEntidad { IdCD = 5, Nombre = "Cordillera - Neuquén" };
            var cdSur        = new CentroDistribucionEntidad { IdCD = 6, Nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDistribucionEntidad>
            {
                cdCapital, cdCentro, cdNorte, cdEste, cdCordillera, cdSur
            };

            // Clientes (remitentes)
            var cliente1 = new ClienteEntidad { RazonSocial  = "Distribuidora El Sol SRL",
                CUIT         = "30712345678",
                Telefono     = 1145678901,
                Calle        = "Av. Corrientes",
                Altura       = 1500,
                Piso         = "PB",
                CodigoPostal = "1043",
                Ciudad       = "Buenos Aires"
            };
            var cliente2 = new ClienteEntidad
            {
                RazonSocial  = "Importadora del Norte SA",
                CUIT         = "30787654321",
                Telefono     = 1167890123,
                Calle        = "San Martín",
                Altura       = 320,
                Piso         = "2",
                CodigoPostal = "1004",
                Ciudad       = "Buenos Aires"
            };

            Clientes = new List<ClienteEntidad> { cliente1, cliente2 };

            // Agencias
            var agencia1 = new AgenciaEntidad
            {
                IdAgencia    = 1,
                RazonSocial  = "Agencia Norte SA",
                Calle        = "Av. Corrientes",
                Altura       = 1234,
                Piso         = "PB",
                CodigoPostal = "1043",
                Ciudad       = "Buenos Aires",
                CD           = cdCapital
            };
            var agencia2 = new AgenciaEntidad
            {
                IdAgencia    = 2,
                RazonSocial  = "Agencia Sur SRL",
                Calle        = "San Martín",
                Altura       = 500,
                Piso         = "1",
                CodigoPostal = "1043",
                Ciudad       = "Buenos Aires",
                CD           = cdCapital
            };

            Agencias = new List<AgenciaEntidad> { agencia1, agencia2 };
            AgenciaOperadora = agencia1;
            CdOrigen = AgenciaOperadora.CD;

            // Guías ya impuestas (lista que se va llenando al registrar)
            Guias = new List<GuiaEntidad>();
            RendicionesAgencia = new List<RendicionAgenciaEntidad>();
        }

        public CentroDistribucionEntidad ObtenerCentroDistribucionPorCiudad(string ciudad)
        {
            string ciudadNormalizada = (ciudad ?? string.Empty).ToLower();

            if (ciudadNormalizada.Contains("córdoba") || ciudadNormalizada.Contains("cordoba"))
                return CentrosDeDistribucion[1];

            if (ciudadNormalizada.Contains("tucumán") || ciudadNormalizada.Contains("tucuman"))
                return CentrosDeDistribucion[2];

            if (ciudadNormalizada.Contains("corrientes"))
                return CentrosDeDistribucion[3];

            if (ciudadNormalizada.Contains("neuquén") || ciudadNormalizada.Contains("neuquen"))
                return CentrosDeDistribucion[4];

            if (ciudadNormalizada.Contains("viedma"))
                return CentrosDeDistribucion[5];

            return CdOrigen;
        }

        public GuiaEntidad RegistrarImposicion(ClienteEntidad cliente, TipoBulto tipoBulto, ModalidadEntrega modalidadEntrega, DestinatarioEntidad destinatario, CentroDistribucionEntidad cdDestino, AgenciaEntidad agenciaDestino)
        {
            GuiaEntidad guia = new GuiaEntidad
            {
                NroGuia = GenerarNumeroGuia(),
                FechaImposicion = DateTime.Today,
                TipoBulto = tipoBulto,
                ModalidadEntrega = modalidadEntrega,
                Estado = EstadoGuia.Impuesta,
                CdOrigen = CdOrigen,
                CdDestino = cdDestino,
                Destinatario = destinatario,
                Agencia = agenciaDestino
            };

            Guias.Add(guia);

            RendicionesAgencia.Add(new RendicionAgenciaEntidad
            {
                Agencia = AgenciaOperadora,
                Cliente = cliente,
                Fecha = DateTime.Today,
                TipoBulto = tipoBulto,
                CantidadBultos = 1,
                NroGuia = guia.NroGuia
            });

            return guia;
        }

        private string GenerarNumeroGuia()
        {
            return "A" + AgenciaOperadora.IdAgencia.ToString("000") + "-" + (Guias.Count + 1).ToString("0000");
        }
    }
    
}
