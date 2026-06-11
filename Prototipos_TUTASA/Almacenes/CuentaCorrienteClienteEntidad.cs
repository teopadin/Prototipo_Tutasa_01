using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class CuentaCorrienteClienteEntidad
{
    public int idCliente { get; set; }
    public decimal saldoActual { get; set; }
    public EstadoCuentaCorrienteEnum estadoCuenta { get; set; }
}
