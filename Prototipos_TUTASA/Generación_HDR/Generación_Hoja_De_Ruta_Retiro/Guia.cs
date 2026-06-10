using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public TipoImposicionEnum TipoImposicion { get; set; }
        public TipoBultoEnum TipoBulto { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public CentroDistribucion idCDOrigen { get; set; }
        public CentroDistribucion idCDDestino { get; set; }
        public Cliente IdCliente { get; set; }   // null si es Retiro en Agencia
        public Agencia idAgenciaOrigen { get; set; }   // null si es domicilio del cliente
    }
}