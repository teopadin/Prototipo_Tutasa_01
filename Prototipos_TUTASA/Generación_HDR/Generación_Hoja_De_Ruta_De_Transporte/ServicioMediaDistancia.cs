using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Transporte
{
    internal class ServicioMediaDistancia
    {
        public int idServicio { get; set; }
        public int idEmpresa { get; set; }
        public TipoArrendamientoEnum tipoArrendamiento { get; set; }
        public int capacidadUsada { get; set; }
        public int idCDOrigen { get; set; }
        public int idCDDestino { get; set; }
        public DateTime fechaSalida { get; set; }


        public int CapacidadMaxima
        {
            get
            {
                switch (tipoArrendamiento)
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
            get { return CapacidadMaxima - capacidadUsada; }
        }
    }
}