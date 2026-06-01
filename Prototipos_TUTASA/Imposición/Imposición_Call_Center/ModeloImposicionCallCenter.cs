using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Imposición.ImposicionCallCenter_v2
{
    internal class ModeloImposicionCallCenter

        {
            public List<Cliente> Clientes { get; set; }
            public List<Agencia> Agencias { get; set; }
            public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
            public List<Guia> Guias { get; set; }

        public ModeloImposicionCallCenter()
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

            // Clientes (remitentes)
            var cliente1 = new Cliente
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
            var cliente2 = new Cliente
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

            Clientes = new List<Cliente> { cliente1, cliente2 };

            // Agencias (para modalidad Retiro en Agencia)
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

            // Guías generadas al registrar imposiciones (arranca vacía)
            Guias = new List<Guia>();
        }


        public Guia RegistrarImposicion(TipoBulto tipoBulto, ModalidadEntrega modalidadEntrega, Destinatario destinatario, CentroDistribucion cdOrigen, CentroDistribucion cdDestino, Agencia agenciaDestino)
        {
            Guia guia = new Guia
            {
                NroGuia = GenerarNumeroGuia(cdOrigen),
            };

            Guias.Add(guia);

            return guia;
        }

        private string GenerarNumeroGuia(CentroDistribucion cdOrigen)
        {
            return "CD" + cdOrigen.IdCD.ToString("00") + "-" + (Guias.Count + 1).ToString("0000");
        }
    }
}
