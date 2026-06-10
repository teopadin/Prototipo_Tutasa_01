using Prototipos_TUTASA.ResultadoCostoVSVentas_v2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ModeloGenerarHDRTransporte
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<Guia> Guias { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }

        public bool Actualizando { get; set; } = false;
        public List<HojaDeRutaTransporte> HojasDeRuta { get; set; } = new List<HojaDeRutaTransporte>();

        public ModeloGenerarHDRTransporte()
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

            // Empresas de transporte
            var empresa1 = new EmpresaTransporte { razonSocial = "Transportes del Sur SA" };
            var empresa2 = new EmpresaTransporte { razonSocial = "Logística Norte SRL" };

            // Servicios
            Servicios = new List<ServicioMediaDistancia>
            {
                // Servicio A: Capital -> Norte, capacidad max 160S, ya usó 40S
                new ServicioMediaDistancia { idServicio = 1, idEmpresa = empresa1, tipoArrendamiento = TipoArrendamientoEnum.A, capacidadUsada = 40, idCDOrigen = cdCapital, idCDDestino = cdNorte, fechaSalida = new DateTime(2026, 5, 26, 8, 0, 0) },

                // Servicio B: Capital -> Centro, capacidad max 80S, ya usó 0S
                new ServicioMediaDistancia { idServicio = 2, idEmpresa = empresa2, tipoArrendamiento = TipoArrendamientoEnum.B, capacidadUsada = 0, idCDOrigen = cdCapital, idCDDestino = cdCentro, fechaSalida = new DateTime(2026, 5, 26, 10, 30, 0) },
                // Servicio C: Capital -> Norte, capacidad max 56S, ya usó 50S (casi lleno)
                new ServicioMediaDistancia { idServicio = 3, idEmpresa = empresa1, tipoArrendamiento = TipoArrendamientoEnum.C, capacidadUsada = 50, idCDOrigen = cdCapital, idCDDestino = cdNorte, fechaSalida = new DateTime(2026, 5, 26, 14, 0, 0) },

                // Servicio D: Capital -> Este, capacidad max 24S, ya usó 0S
                new ServicioMediaDistancia { idServicio = 4, idEmpresa = empresa2, tipoArrendamiento = TipoArrendamientoEnum.D, capacidadUsada = 0, idCDOrigen = cdCapital, idCDDestino = cdEste, fechaSalida = new DateTime(2026, 5, 26, 16, 0, 0) },

                // Servicio de otro CD - NO debe aparecer
                new ServicioMediaDistancia { idServicio = 5, idEmpresa = empresa1, tipoArrendamiento = TipoArrendamientoEnum.A, capacidadUsada = 0, idCDOrigen = cdCentro, idCDDestino = cdNorte, fechaSalida = new DateTime(2026, 5, 26, 9, 0, 0) },
            };

            // Guías en estado Admitida, origen Capital
            Guias = new List<Guia>
{
    // Destino Norte
    new Guia {
        NroGuia = "CD01-0001",
        TipoBulto = TiposBultoEnum.M,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdNorte,
        CdActual = cdCapital
    },

    new Guia {
        NroGuia = "CD01-0002",
        TipoBulto = TiposBultoEnum.L,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdNorte,
        CdActual = cdCapital
    },

    new Guia {
        NroGuia = "CD01-0003",
        TipoBulto = TiposBultoEnum.XL,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdNorte,
        CdActual = cdCapital
    },

    // Destino Centro
    new Guia {
        NroGuia = "CD01-0004",
        TipoBulto = TiposBultoEnum.S,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdCentro,
        CdActual = cdCapital
    },

    new Guia {
        NroGuia = "CD01-0005",
        TipoBulto = TiposBultoEnum.M,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdCentro,
        CdActual = cdCapital
    },

    // Destino Este
    new Guia {
        NroGuia = "CD01-0006",
        TipoBulto = TiposBultoEnum.S,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdEste,
        CdActual = cdCapital
    },

    // Pendiente de despacho
    new Guia {
        NroGuia = "CD01-0007",
        TipoBulto = TiposBultoEnum.M,
        Estado = EstadoGuiaEnum.PendienteDeDespacho,
        CdOrigen = cdCapital,
        CdDestino = cdNorte,
        CdActual = cdCapital
    },

    // Otro CD origen
    new Guia {
        NroGuia = "CD02-0001",
        TipoBulto = TiposBultoEnum.S,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCentro,
        CdDestino = cdNorte,
        CdActual = cdCentro
    },

    // Ejemplo de redespacho:
    // origen Capital -> destino final Norte
    // actualmente está admitida en Centro esperando otro viaje
    new Guia {
        NroGuia = "CD01-0008",
        TipoBulto = TiposBultoEnum.M,
        Estado = EstadoGuiaEnum.Admitida,
        CdOrigen = cdCapital,
        CdDestino = cdNorte,
        CdActual = cdCentro
    }
};

        }

        // Indica si el servicio tiene capacidad suficiente para la cantidad de bultos
        public bool TieneCapacidadSuficiente(ServicioMediaDistancia servicio, int totalBultos)
        {
            return servicio.CapacidadDisponible >= totalBultos;
        }
    }

}
