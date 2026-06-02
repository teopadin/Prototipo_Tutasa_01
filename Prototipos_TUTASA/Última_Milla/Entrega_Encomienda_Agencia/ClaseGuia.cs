namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ClaseGuia
    {
        public string NroGuia { get; set; } = string.Empty;
        public EstadoGuia Estado { get; set; }
        public ClaseAgencia AgenciaGuia { get; set; }
        public ClaseDestinatarioGuia DestinatarioGuia { get; set; }
    }
}
