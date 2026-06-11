using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class CuadroTarifarioEntidad
{
    public int IdTarifa { get; set; }
    public int IdCDOrigen { get; set; }
    public int IdCDDestino { get; set; }
    public TiposBultoEnum TipoBulto { get; set; }
    public decimal PrecioFlete { get; set; }
}
