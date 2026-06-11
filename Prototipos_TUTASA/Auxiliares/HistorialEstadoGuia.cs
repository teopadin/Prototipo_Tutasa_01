namespace Prototipos_TUTASA.Auxiliares;

internal class HistorialEstadoGuia
{
    public DateTime FechaCambio { get; set; }
    public EstadoGuiaEnum Estado { get; set; }
    public string Donde { get; set; } = string.Empty;
}
