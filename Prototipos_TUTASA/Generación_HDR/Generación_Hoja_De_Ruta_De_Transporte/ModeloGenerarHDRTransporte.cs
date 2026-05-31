using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ModeloGenerarHDRTransporte
    {
        public CentroDistribucionEntidad CdEmisor { get; set; }
        public List<CentroDistribucionEntidad> CentrosDeDistribucion { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public List<ServicioMediaDistanciaEntidad> Servicios { get; set; }
        public List<HojaDeRutaTransporteEntidad> HojasDeRuta { get; set; }

        public ModeloGenerarHDRTransporte()
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

            CdEmisor = cdCapital;

            // Empresas de transporte
            var empresa1 = new EmpresaTransporteEntidad { IdEmpresa = 1, RazonSocial = "Transportes del Sur SA" };
            var empresa2 = new EmpresaTransporteEntidad { IdEmpresa = 2, RazonSocial = "Logística Norte SRL" };

            // Servicios
            Servicios = new List<ServicioMediaDistanciaEntidad>
            {
                // Servicio A: Capital -> Norte, capacidad max 160S, ya usó 40S
                new ServicioMediaDistanciaEntidad { IdServicio = 1, Empresa = empresa1, TipoArrendamiento = TipoArrendamiento.A, CapacidadUsada = 40, CdOrigen = cdCapital, CdDestino = cdNorte, HorarioSalida = new TimeSpan(8, 0, 0) },

                // Servicio B: Capital -> Centro, capacidad max 80S, ya usó 0S
                new ServicioMediaDistanciaEntidad { IdServicio = 2, Empresa = empresa2, TipoArrendamiento = TipoArrendamiento.B, CapacidadUsada = 0, CdOrigen = cdCapital, CdDestino = cdCentro, HorarioSalida = new TimeSpan(10, 30, 0) },

                // Servicio C: Capital -> Norte, capacidad max 56S, ya usó 50S (casi lleno)
                new ServicioMediaDistanciaEntidad { IdServicio = 3, Empresa = empresa1, TipoArrendamiento = TipoArrendamiento.C, CapacidadUsada = 50, CdOrigen = cdCapital, CdDestino = cdNorte, HorarioSalida = new TimeSpan(14, 0, 0) },

                // Servicio D: Capital -> Este, capacidad max 24S, ya usó 0S
                new ServicioMediaDistanciaEntidad { IdServicio = 4, Empresa = empresa2, TipoArrendamiento = TipoArrendamiento.D, CapacidadUsada = 0, CdOrigen = cdCapital, CdDestino = cdEste, HorarioSalida = new TimeSpan(16, 0, 0) },

                // Servicio de otro CD - NO debe aparecer
                new ServicioMediaDistanciaEntidad { IdServicio = 5, Empresa = empresa1, TipoArrendamiento = TipoArrendamiento.A, CapacidadUsada = 0, CdOrigen = cdCentro, CdDestino = cdNorte, HorarioSalida = new TimeSpan(9, 0, 0) },
            };

            // Guías en estado Admitida, origen Capital
            Guias = new List<GuiaEntidad>
            {
                // Destino Norte
                new GuiaEntidad { NroGuia = "CD01-0001", FechaImposicion = new DateTime(2026, 5, 20), TipoBulto = TipoBulto.M, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdNorte },
                new GuiaEntidad { NroGuia = "CD01-0002", FechaImposicion = new DateTime(2026, 5, 21), TipoBulto = TipoBulto.L, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdNorte },
                new GuiaEntidad { NroGuia = "CD01-0003", FechaImposicion = new DateTime(2026, 5, 22), TipoBulto = TipoBulto.XL, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdNorte },

                // Destino Centro
                new GuiaEntidad { NroGuia = "CD01-0004", FechaImposicion = new DateTime(2026, 5, 20), TipoBulto = TipoBulto.S, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdCentro },
                new GuiaEntidad { NroGuia = "CD01-0005", FechaImposicion = new DateTime(2026, 5, 21), TipoBulto = TipoBulto.M, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdCentro },

                // Destino Este
                new GuiaEntidad { NroGuia = "CD01-0006", FechaImposicion = new DateTime(2026, 5, 22), TipoBulto = TipoBulto.S, Estado = EstadoGuia.Admitida, CdOrigen = cdCapital, CdDestino = cdEste },

                // Otro estado - NO debe aparecer
                new GuiaEntidad { NroGuia = "CD01-0007", FechaImposicion = new DateTime(2026, 5, 19), TipoBulto = TipoBulto.M, Estado = EstadoGuia.PendienteDeDespacho, CdOrigen = cdCapital, CdDestino = cdNorte },

                // Otro CD origen - NO debe aparecer
                new GuiaEntidad { NroGuia = "CD02-0001", FechaImposicion = new DateTime(2026, 5, 20), TipoBulto = TipoBulto.S, Estado = EstadoGuia.Admitida, CdOrigen = cdCentro, CdDestino = cdNorte },
            };

            HojasDeRuta = new List<HojaDeRutaTransporteEntidad>();
        }
    }
}
