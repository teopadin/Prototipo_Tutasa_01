using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class CentroDistribucionEntidad
{
    public int idCD { get; set; }
    public string nombre { get; set; } = string.Empty;
    public int altura { get; set; }
    public string piso { get; set; } = string.Empty;
    public string codigoPostal { get; set; } = string.Empty;
    public string calle { get; set; } = string.Empty;
    public string ciudad { get; set; } = string.Empty;
    public int telefono { get; set; }
}
