using System.Collections.Generic;

namespace Prototipos_TUTASA.Imposición.Imposición_Agencia
{
    internal class ModeloImposicionAgencia
    {
        public List<Cliente> Clientes { get; set; }
        public List<Agencia> Agencias { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public Agencia AgenciaOperadora { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public List<Guia> Guias { get; set; }

        public ModeloImposicionAgencia()
        {
            var cdCapital = new CentroDistribucion { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { IdCD = 2, Nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucion { IdCD = 3, Nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucion { IdCD = 4, Nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucion { IdCD = 5, Nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucion { IdCD = 6, Nombre = "Sur - Viedma" };

            CentrosDeDistribucion = new List<CentroDistribucion>
            {
                cdCapital,
                cdCentro,
                cdNorte,
                cdEste,
                cdCordillera,
                cdSur
            };

            var cliente1 = new Cliente
            {
                RazonSocial = "Distribuidora El Sol SRL",
                CUIT = 30712345678,
                Telefono = "1145678901",
                Calle = "Av. Corrientes",
                Altura = 1500,
                Piso = "PB",
                CodigoPostal = "1043",
                Ciudad = "Buenos Aires"
            };

            var cliente2 = new Cliente
            {
                RazonSocial = "Importadora del Norte SA",
                CUIT = 30787654321,
                Telefono = "1167890123",
                Calle = "San Martín",
                Altura = 320,
                Piso = "2",
                CodigoPostal = "1004",
                Ciudad = "Buenos Aires"
            };

            Clientes = new List<Cliente> { cliente1, cliente2 };

            var agencia1 = new Agencia
            {
                IdAgencia = 1,
                RazonSocial = "Agencia Norte SA",
                CD = cdCapital
            };

            var agencia2 = new Agencia
            {
                IdAgencia = 2,
                RazonSocial = "Agencia Sur SRL",
                CD = cdCapital
            };

            Agencias = new List<Agencia> { agencia1, agencia2 };
            AgenciaOperadora = agencia1;
            CdOrigen = AgenciaOperadora.CD;
            Guias = new List<Guia>();
        }

        public Guia RegistrarImposicion()
        {
            Guia guia = new Guia
            {
                NroGuia = GenerarNumeroGuia()
            };

            Guias.Add(guia);

            return guia;
        }

        private string GenerarNumeroGuia()
        {
            int proximoNumero = Guias.Count + 1;

            return "AG" + AgenciaOperadora.IdAgencia.ToString("000") + "-" + proximoNumero.ToString("0000");
        }
    }
}
