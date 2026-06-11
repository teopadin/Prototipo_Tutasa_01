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

            // Clientes (remitentes)
            var cliente1 = new Cliente
            {
                razonSocial = "Distribuidora El Sol SRL",
                cuit = 30712345678,
                telefono = "1145678901",
                calle = "Av. Corrientes",
                altura = 1500,
                Piso = "PB",
                codigoPostal = "1043",
                ciudad = "Buenos Aires"
            };
            var cliente2 = new Cliente
            {
                razonSocial = "Importadora del Norte SA",
                cuit = 30798765432,
                telefono = "1167890123",
                calle = "San Martín",
                altura = 320,
                Piso = "2",
                codigoPostal = "1004",
                ciudad = "Buenos Aires"
            };

            Clientes = new List<Cliente> { cliente1, cliente2 };

            // Agencias (para modalidad Retiro en Agencia)
            var agencia1 = new Agencia
            {
                idAgencia = 1,
                razonSocial = "Agencia Norte SA",
                idCD = cdCapital.idCD
            };
            var agencia2 = new Agencia
            {
                idAgencia = 2,
                razonSocial = "Agencia Sur SRL",
                idCD = cdCapital.idCD
            };

            Agencias = new List<Agencia> { agencia1, agencia2 };

            // Guías generadas al registrar imposiciones (arranca vacía)
            Guias = new List<Guia>();
        }

        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (CentroDistribucion cd in CentrosDeDistribucion)
            {
                if (cd.idCD == idCD)
                    return cd;
            }
            return null;
        }
        public Guia RegistrarImposicion(TipoBultoEnum tipoBulto, ModalidadEntregaEnum modalidadEntrega, DestinatarioGuia destinatario, CentroDistribucion cdOrigen, CentroDistribucion cdDestino, Agencia agenciaDestino)
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
            return "CD" + cdOrigen.idCD.ToString("00") + "-" + (Guias.Count + 1).ToString("0000");
        }
    }
}
