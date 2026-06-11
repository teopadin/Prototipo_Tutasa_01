using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class AgenciaEntidad
{
    public int idAgencia { get; set; }
    public string razonSocial { get; set; } = string.Empty;
    public int idCD { get; set; }
    public string calle { get; set; } = string.Empty;
    public int altura { get; set; }
    public string codigoPostal { get; set; } = string.Empty;
    public string piso { get; set; } = string.Empty;
    public int telefono { get; set; }
    public string ciudad { get; set; } = string.Empty;
    public bool convenioVigente { get; set; }
}
