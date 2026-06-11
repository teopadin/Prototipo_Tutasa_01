using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class AgenciaEntidad
{
    public int idAgencia { get; set; }
    public string razonSocial { get; set; }
    public int idCD { get; set; }
    public string calle { get; set; }
    public int altura { get; set; }
    public string codigoPostal { get; set; }
    public string piso { get; set; }
    public int telefono { get; set; }
    public string ciudad { get; set; }
    public bool convenioVigente { get; set; }
}
