using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class TransportistaLocalEntidad
{
    public int dniTransportista { get; set; }
    public string nombre { get; set; } = string.Empty;
    public string apellido { get; set; } = string.Empty;
    public bool contratoVigente { get; set; }
    public int idCD { get; set; }
    public int HdrAsignadas { get; set; }
}
