using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public int IdCliente { get; set; }
        public TipoImposicion TipoImposicion { get; set; }
        public int IdCDDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }
        public TiposBulto TipoBulto { get; set; }
        public ModalidadEntrega ModalidadEntrega { get; set; }
        public EstadoGuia Estado { get; set; }
        public TarifaCalculadaGuia TarifaCalculada { get; set; }
    }
}