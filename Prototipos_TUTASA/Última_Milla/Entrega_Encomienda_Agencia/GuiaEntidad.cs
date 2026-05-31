namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class GuiaEntidad
    {
        public string NroGuia { get; set; } = string.Empty;
        public EstadoGuia Estado { get; set; }
        public AgenciaEntidad AgenciaDestino { get; set; } = null;
        public DestinatarioEntidad Destinatario { get; set; } = null;
    }
}
