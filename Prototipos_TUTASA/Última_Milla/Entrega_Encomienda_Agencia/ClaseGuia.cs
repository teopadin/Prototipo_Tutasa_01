namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ClaseGuia
    {
        public string NroGuia { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public ClaseAgencia AgenciaGuia { get; set; }
        public ClaseDestinatarioGuia DestinatarioGuia { get; set; }
        public ClaseAgencia AgenciaDestino { get; set; }
        public ClaseDestinatarioGuia Destinatario { get; set; }
    }
}