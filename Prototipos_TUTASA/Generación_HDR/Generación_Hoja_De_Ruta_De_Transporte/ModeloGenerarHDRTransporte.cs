using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ModeloGenerarHDRTransporte
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<EmpresaTransporte> Empresas { get; set; }
        public List<Guia> Guias { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }

        public bool Actualizando { get; set; } = false;
        public List<HojaDeRutaTransporte> HojasDeRuta { get; set; } = new List<HojaDeRutaTransporte>();

        public ModeloGenerarHDRTransporte()
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

            // Empresas de transporte (con idEmpresa)
            var empresa1 = new EmpresaTransporte { idEmpresa = 1, razonSocial = "Transportes del Sur SA" };
            var empresa2 = new EmpresaTransporte { idEmpresa = 2, razonSocial = "Logística Norte SRL" };

            Empresas = new List<EmpresaTransporte> { empresa1, empresa2 };

            // Servicios (idEmpresa, idCDOrigen, idCDDestino ahora por id)
            Servicios = new List<ServicioMediaDistancia>
            {
                new ServicioMediaDistancia { idServicio = 1, idEmpresa = empresa1.idEmpresa, tipoArrendamiento = TipoArrendamientoEnum.A, capacidadUsada = 40, idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD, fechaSalida = new DateTime(2026, 5, 26, 8, 0, 0) },
                new ServicioMediaDistancia { idServicio = 2, idEmpresa = empresa2.idEmpresa, tipoArrendamiento = TipoArrendamientoEnum.B, capacidadUsada = 0, idCDOrigen = cdCapital.idCD, idCDDestino = cdCentro.idCD, fechaSalida = new DateTime(2026, 5, 26, 10, 30, 0) },
                new ServicioMediaDistancia { idServicio = 3, idEmpresa = empresa1.idEmpresa, tipoArrendamiento = TipoArrendamientoEnum.C, capacidadUsada = 50, idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD, fechaSalida = new DateTime(2026, 5, 26, 14, 0, 0) },
                new ServicioMediaDistancia { idServicio = 4, idEmpresa = empresa2.idEmpresa, tipoArrendamiento = TipoArrendamientoEnum.D, capacidadUsada = 0, idCDOrigen = cdCapital.idCD, idCDDestino = cdEste.idCD, fechaSalida = new DateTime(2026, 5, 26, 16, 0, 0) },

                // Servicio de otro CD - NO debe aparecer
                new ServicioMediaDistancia { idServicio = 5, idEmpresa = empresa1.idEmpresa, tipoArrendamiento = TipoArrendamientoEnum.A, capacidadUsada = 0, idCDOrigen = cdCentro.idCD, idCDDestino = cdNorte.idCD, fechaSalida = new DateTime(2026, 5, 26, 9, 0, 0) },
            };

            // Guías (idCDOrigen, idCDDestino, idCDActual ahora por id)
            Guias = new List<Guia>
            {
                new Guia { NroGuia = "CD01-0001", TipoBulto = TiposBultoEnum.M,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD,  idCDActual = cdCapital.idCD },
                new Guia { NroGuia = "CD01-0002", TipoBulto = TiposBultoEnum.L,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD,  idCDActual = cdCapital.idCD },
                new Guia { NroGuia = "CD01-0003", TipoBulto = TiposBultoEnum.XL, Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD,  idCDActual = cdCapital.idCD },

                new Guia { NroGuia = "CD01-0004", TipoBulto = TiposBultoEnum.S,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdCentro.idCD, idCDActual = cdCapital.idCD },
                new Guia { NroGuia = "CD01-0005", TipoBulto = TiposBultoEnum.M,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdCentro.idCD, idCDActual = cdCapital.idCD },

                new Guia { NroGuia = "CD01-0006", TipoBulto = TiposBultoEnum.S,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdEste.idCD,   idCDActual = cdCapital.idCD },

                // Pendiente de despacho - NO debe aparecer
                new Guia { NroGuia = "CD01-0007", TipoBulto = TiposBultoEnum.M,  Estado = EstadoGuiaEnum.PendienteDeDespacho, idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD,  idCDActual = cdCapital.idCD },

                // Otro CD actual - NO debe aparecer
                new Guia { NroGuia = "CD02-0001", TipoBulto = TiposBultoEnum.S,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCentro.idCD,  idCDDestino = cdNorte.idCD,  idCDActual = cdCentro.idCD },

                // Redespacho: destino final Norte, ahora en Centro - NO debe aparecer (idCDActual != emisor)
                new Guia { NroGuia = "CD01-0008", TipoBulto = TiposBultoEnum.M,  Estado = EstadoGuiaEnum.Admitida,            idCDOrigen = cdCapital.idCD, idCDDestino = cdNorte.idCD,  idCDActual = cdCentro.idCD },
            };
        }

        // Indica si el servicio tiene capacidad suficiente para la cantidad de bultos
        public bool TieneCapacidadSuficiente(ServicioMediaDistancia servicio, int totalBultos)
        {
            return servicio.CapacidadDisponible >= totalBultos;
        }

        // Busca un CD por su id. Devuelve null si no existe.
        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (CentroDistribucion cd in CentrosDeDistribucion)
            {
                if (cd.idCD == idCD)
                    return cd;
            }
            return null;
        }

        // Busca una empresa de transporte por su id. Devuelve null si no existe.
        public EmpresaTransporte BuscarEmpresa(int idEmpresa)
        {
            foreach (EmpresaTransporte empresa in Empresas)
            {
                if (empresa.idEmpresa == idEmpresa)
                    return empresa;
            }
            return null;
        }
    }
}