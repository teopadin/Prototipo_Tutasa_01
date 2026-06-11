using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class FacturaEntidad
{
    public int nroFactura { get; set; }
    public DateTime fechaEmision { get; set; }
    public int idCliente { get; set; }
    public List<string> DetalleFactura { get; set; } = new();
    public decimal importeTotal { get; set; }
}
