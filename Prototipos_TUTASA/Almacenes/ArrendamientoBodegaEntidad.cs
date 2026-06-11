using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class ArrendamientoBodegaEntidad
{
    public int idArrendamiento { get; set; }
    public int idEmpresa { get; set; }
    public DateTime periodo { get; set; }
    public decimal importeMensual { get; set; }
}
