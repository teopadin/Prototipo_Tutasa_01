using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ModeloGenerarHDRTransporte
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<GuiaEntidad> Guias { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public List<HojaDeRutaTransporte> HojasDeRuta { get; set; }

        public bool Actualizando { get; set; } = false;

        public ModeloGenerarHDRTransporte()
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

            CdEmisor = cdCapital;

            // Empresas de transporte
            var empresa1 = new EmpresaTransporte { IdEmpresa = 1, RazonSocial = "Transportes del Sur SA" };
            var empresa2 = new EmpresaTransporte { IdEmpresa = 2, RazonSocial = "Logística Norte SRL" };

            // Servicios
            Servicios = new List<ServicioMediaDistancia>
            {
                // Servicio A: Capital -> Norte, capacidad max 160S, ya usó 40S
                new ServicioMediaDistancia { IdServicio = 1, Empresa = empresa1, TipoArrendamiento = TipoArrendamiento.A, CapacidadUsada = 40, CdOrigen = cdCapital, CdDestino = cdNorte, HorarioSalida = new TimeSpan(8, 0, 0) },

                // Servicio B: Capital -> Centro, capacidad max 80S, ya usó 0S
                new ServicioMediaDistancia { IdServicio = 2, Empresa = empresa2, TipoArrendamiento = TipoArrendamiento.B, CapacidadUsada = 0, CdOrigen = cdCapital, CdDestino = cdCentro, HorarioSalida = new TimeSpan(10, 30, 0) },

                // Servicio C: Capital -> Norte, capacidad max 56S, ya usó 50S (casi lleno)
                new ServicioMediaDistancia { IdServicio = 3, Empresa = empresa1, TipoArrendamiento = TipoArrendamiento.C, CapacidadUsada = 50, CdOrigen = cdCapital, CdDestino = cdNorte, HorarioSalida = new TimeSpan(14, 0, 0) },

                // Servicio D: Capital -> Este, capacidad max 24S, ya usó 0S
                new ServicioMediaDistancia { IdServicio = 4, Empresa = empresa2, TipoArrendamiento = TipoArrendamiento.D, CapacidadUsada = 0, CdOrigen = cdCapital, CdDestino = cdEste, HorarioSalida = new TimeSpan(16, 0, 0) },

                // Servicio de otro CD - NO debe aparecer
                new ServicioMediaDistancia { IdServicio = 5, Empresa = empresa1, TipoArrendamiento = TipoArrendamiento.A, CapacidadUsada = 0, CdOrigen = cdCentro, CdDestino = cdNorte, HorarioSalida = new TimeSpan(9, 0, 0) },
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

            HojasDeRuta = new List<HojaDeRutaTransporte>();
        }
    }
}
