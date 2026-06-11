namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    using System;

    public class Guia
    {
        public string NroGuia { get; set; }
        public EstadoGuiaEnum estado { get; set; }
        public Agencia idAgenciaDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }
    }
}