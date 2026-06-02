using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ServicioMediaDistancia
    {
        public int IdServicio { get; set; }
        public EmpresaTransporte Empresa { get; set; }
        public TipoArrendamientoEnum TipoArrendamiento { get; set; }
        public int CapacidadUsada { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public CentroDistribucion CdDestino { get; set; }
        public TimeSpan HorarioSalida { get; set; }


        public int CapacidadMaxima
        {
            get
            {
                switch (TipoArrendamiento)
                {
                    case TipoArrendamientoEnum.A: return 160;
                    case TipoArrendamientoEnum.B: return 80;
                    case TipoArrendamientoEnum.C: return 56;
                    case TipoArrendamientoEnum.D: return 24;
                    default: return 0;
                }
            }
        }

        public int CapacidadDisponible
        {
            get { return CapacidadMaxima - CapacidadUsada; }
        }
    }
}