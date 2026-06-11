using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class DetalleFacturaEntidad
{
    public int idDetalleFactura { get; set; }
    public int nroFactura { get; set; }
    public string nroGuia { get; set; }
    public decimal tarifaCalculada { get; set; }
}
