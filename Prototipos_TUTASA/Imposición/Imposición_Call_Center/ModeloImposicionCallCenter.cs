using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.ImposicionCallCenter_v2
{
    internal class ModeloImposicionCallCenter

        {
            public List<ClienteEntidad> Clientes { get; set; }
            public List<AgenciaEntidad> Agencias { get; set; }
            public List<CentroDistribucionEntidad> CentrosDeDistribucion { get; set; }
            public List<GuiaEntidad> Guias { get; set; }

            public ModeloImposicionCallCenter()
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

                // Clientes (remitentes)
                var cliente1 = new ClienteEntidad
                {
                    RazonSocial = "Distribuidora El Sol SRL",
                    CUIT = "30712345678",
                    Telefono = 1145678901,
                    Calle = "Av. Corrientes",
                    Altura = 1500,
                    Piso = "PB",
                    CodigoPostal = "1043",
                    Ciudad = "Buenos Aires"
                };
                var cliente2 = new ClienteEntidad
                {
                    RazonSocial = "Importadora del Norte SA",
                    CUIT = "30798765432",
                    Telefono = 1167890123,
                    Calle = "San Martín",
                    Altura = 320,
                    Piso = "2",
                    CodigoPostal = "1004",
                    Ciudad = "Buenos Aires"
                };

                Clientes = new List<ClienteEntidad> { cliente1, cliente2 };

                // Agencias (para modalidad Retiro en Agencia)
                var agencia1 = new AgenciaEntidad
                {
                    IdAgencia = 1,
                    RazonSocial = "Agencia Norte SA",
                    Calle = "Av. Corrientes",
                    Altura = 1234,
                    Piso = "PB",
                    CodigoPostal = "1043",
                    Ciudad = "Buenos Aires",
                    CD = cdCapital
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
                    CD = cdCapital
                };

                Agencias = new List<AgenciaEntidad> { agencia1, agencia2 };

                // Guías generadas al registrar imposiciones (arranca vacía)
                Guias = new List<GuiaEntidad>();
            }
        
    }
}
