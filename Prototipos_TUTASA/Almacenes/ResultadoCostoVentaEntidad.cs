using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class ResultadoCostoVentaEntidad
{
    public int idEmpresa { get; set; }
    public DateTime periodo { get; set; }
    public decimal ventas { get; set; }
    public decimal costos { get; set; }
    public decimal resultado { get; set; }
}
