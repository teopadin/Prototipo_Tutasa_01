namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ClaseGuia
    {
        public string NroGuia { get; set; } = string.Empty;
        public EstadoGuia Estado { get; set; }
        public ClaseAgencia AgenciaDestino { get; set; }
        public ClaseDestinatario Destinatario { get; set; }
    }
}
