using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class HistorialEstadoGuia
{
    public DateTime FechaCambio { get; set; }
    public EstadoGuiaEnum Estado { get; set; }
    public string Donde { get; set; }
}
