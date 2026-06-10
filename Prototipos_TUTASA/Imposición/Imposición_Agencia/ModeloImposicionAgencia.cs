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
            var cdCapital = new CentroDistribucion { idCD = 1, nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { idCD = 2, nombre = "Centro - Córdoba" };
            var cdNorte = new CentroDistribucion { idCD = 3, nombre = "Norte - Tucumán" };
            var cdEste = new CentroDistribucion { idCD = 4, nombre = "Este - Corrientes" };
            var cdCordillera = new CentroDistribucion { idCD = 5, nombre = "Cordillera - Neuquén" };
            var cdSur = new CentroDistribucion { idCD = 6, nombre = "Sur - Viedma" };

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
                razonSocial = "Distribuidora El Sol SRL",
                cuit = 30712345678,
                telefono = "1145678901",
                calle = "Av. Corrientes",
                altura = 1500,
                piso = "PB",
                codigoPostal = "1043",
                ciudad = "Buenos Aires"
            };

            var cliente2 = new Cliente
            {
                razonSocial = "Importadora del Norte SA",
                cuit = 30787654321,
                telefono = "1167890123",
                calle = "San Martín",
                altura = 320,
                piso = "2",
                codigoPostal = "1004",
                ciudad = "Buenos Aires"
            };

            Clientes = new List<Cliente> { cliente1, cliente2 };

            var agencia1 = new Agencia
            {
                idAgencia = 1,
                razonSocial = "Agencia Norte SA",
                CD = cdCapital
            };

            var agencia2 = new Agencia
            {
                idAgencia = 2,
                razonSocial = "Agencia Sur SRL",
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
                nroGuia = GenerarNumeroGuia()
            };

            Guias.Add(guia);

            return guia;
        }

        private string GenerarNumeroGuia()
        {
            int proximoNumero = Guias.Count + 1;

            return "AG" + AgenciaOperadora.idAgencia.ToString("000") + "-" + proximoNumero.ToString("0000");
        }
    }
}
