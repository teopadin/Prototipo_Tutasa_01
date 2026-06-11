using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class ClienteEntidad
{
    public int idCliente { get; set; }
    public long cuit { get; set; }
    public string razonSocial { get; set; }
    public string telefono { get; set; }
    public string calle { get; set; }
    public int altura { get; set; }
    public string piso { get; set; }
    public string ciudad { get; set; }
    public string codigoPostal { get; set; }
}
