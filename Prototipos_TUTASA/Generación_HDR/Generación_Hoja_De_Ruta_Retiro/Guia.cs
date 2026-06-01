using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TipoImposicion TipoImposicion { get; set; }
        public TipoBulto TipoBulto { get; set; }
        public DateTime FechaImposicion { get; set; }
        public ModalidadEntrega ModalidadEntrega { get; set; }
        public EstadoGuia Estado { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public CentroDistribucion CdDestino { get; set; }
        public Cliente Cliente { get; set; }   // null si es Retiro en Agencia
        public Agencia Agencia { get; set; }   // null si es domicilio del cliente
    }
}