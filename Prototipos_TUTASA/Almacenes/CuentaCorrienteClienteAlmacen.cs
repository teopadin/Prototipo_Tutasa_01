namespace Prototipos_TUTASA.Almacenes;

internal static class CuentaCorrienteClienteAlmacen
{
    private const string Archivo = "CuentasCorrientesClientes.json";
    private static List<CuentaCorrienteClienteEntidad> cuentasCorrientes = new();

    static CuentaCorrienteClienteAlmacen() { cuentasCorrientes = AlmacenJson.Cargar<CuentaCorrienteClienteEntidad>(Archivo); }

    public static List<CuentaCorrienteClienteEntidad> ObtenerTodos() { return cuentasCorrientes; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, cuentasCorrientes); }
}
