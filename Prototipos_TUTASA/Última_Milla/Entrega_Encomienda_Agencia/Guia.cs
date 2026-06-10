namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    using System;

    public class Guia
    {
        public string NroGuia { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public Agencia AgenciaDestino { get; set; }
        public DestinatarioGuia Destinatario { get; set; }
    }
}