using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class ClienteEntidad
{
    public int idCliente { get; set; }
    public long cuit { get; set; }
    public string razonSocial { get; set; } = string.Empty;
    public string telefono { get; set; } = string.Empty;
    public string calle { get; set; } = string.Empty;
    public int altura { get; set; }
    public string piso { get; set; } = string.Empty;
    public string ciudad { get; set; } = string.Empty;
    public string codigoPostal { get; set; } = string.Empty;
}
