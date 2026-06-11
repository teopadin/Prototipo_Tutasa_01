using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro
{
    internal class ModeloGenerarHDRRetiro
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Agencia> Agencias { get; set; }
        public List<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public bool Actualizando { get; set; } = false;
        public List<HojaDeRutaRetiro> HojasDeRuta { get; set; } = new List<HojaDeRutaRetiro>();

        public ModeloGenerarHDRRetiro()
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

            // Clientes (con idCliente)
            var cliente1 = new Cliente { idCliente = 1, razonSocial = "Empresa ABC SA", calle = "Av. Rivadavia", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var cliente2 = new Cliente { idCliente = 2, razonSocial = "Distribuidora XYZ SRL", calle = "Av. Rivadavia", altura = 3200, piso = "3B", codigoPostal = "1406", ciudad = "Buenos Aires" };
            var cliente3 = new Cliente { idCliente = 3, razonSocial = "Comercio El Sol", calle = "Belgrano", altura = 750, piso = "PB", codigoPostal = "5000", ciudad = "Córdoba" };

            Clientes = new List<Cliente> { cliente1, cliente2, cliente3 };

            // Guías (todas las referencias ahora por id)
            Guias = new List<Guia>
            {
                // Domicilio cliente, origen Capital - misma dirección para probar filtro
                new Guia { NroGuia = "CD01-0001", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.M, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD, IdCliente = cliente1.idCliente, idAgenciaOrigen = null },
                new Guia { NroGuia = "CD01-0002", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.L, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital.idCD, idCDDestino = cdCentro.idCD, IdCliente = cliente2.idCliente, idAgenciaOrigen = null },

                // Retiro en agencia, origen Capital
                new Guia { NroGuia = "A001-0001", TipoImposicion = TipoImposicionEnum.Agencia, TipoBulto = TipoBultoEnum.S, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD, IdCliente = null, idAgenciaOrigen = agencia1.idAgencia },
                new Guia { NroGuia = "A001-0002", TipoImposicion = TipoImposicionEnum.Agencia, TipoBulto = TipoBultoEnum.XL, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital.idCD, idCDDestino = cdEste.idCD, IdCliente = null, idAgenciaOrigen = agencia1.idAgencia },
                new Guia { NroGuia = "A002-0001", TipoImposicion = TipoImposicionEnum.Agencia, TipoBulto = TipoBultoEnum.M, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCapital.idCD, idCDDestino = cdSur.idCD, IdCliente = null, idAgenciaOrigen = agencia2.idAgencia },

                // Domicilio cliente, origen Córdoba - NO debe aparecer (CD origen != CD emisor)
                new Guia { NroGuia = "CD02-0001", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.S, Estado = EstadoGuiaEnum.Impuesta, idCDOrigen = cdCentro.idCD, idCDDestino = cdNorte.idCD, IdCliente = cliente3.idCliente, idAgenciaOrigen = null },

                // En otro estado - NO debe aparecer
                new Guia { NroGuia = "CD01-0003", TipoImposicion = TipoImposicionEnum.CallCenter, TipoBulto = TipoBultoEnum.L, Estado = EstadoGuiaEnum.IncluidaEnHDRRetiro, idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD, IdCliente = cliente1.idCliente, idAgenciaOrigen = null },
            };
        }

        // Busca un cliente por su id. Devuelve null si no existe.
        public Cliente BuscarCliente(int idCliente)
        {
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.idCliente == idCliente)
                    return cliente;
            }
            return null;
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
    }
}