using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class EmpresaTransporteEntidad
{
    public int idEmpresa { get; set; }
    public string razonSocial { get; set; } = string.Empty;
    public bool convenioVigente { get; set; }
}
