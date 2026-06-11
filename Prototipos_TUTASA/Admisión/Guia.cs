using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public int IdCliente { get; set; }
        public TipoImposicionEnum TipoImposicion { get; set; }
        public int IdCDDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }
        public TiposBultoEnum TipoBulto { get; set; }
        public ModalidadEntregaEnum ModalidadEntrega { get; set; }
        public EstadoGuiaEnum estado { get; set; }
        public TarifaCalculadaGuia TarifaCalculada { get; set; }
    }
}