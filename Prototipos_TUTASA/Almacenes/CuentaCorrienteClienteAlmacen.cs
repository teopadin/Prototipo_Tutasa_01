using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CuentaCorrienteClienteAlmacen
{
    private const string Archivo = "DATOS/CuentasCorrientesClientes.json";
    private static List<CuentaCorrienteClienteEntidad> cuentasCorrientes = new();

    static CuentaCorrienteClienteAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            cuentasCorrientes = JsonSerializer.Deserialize<List<CuentaCorrienteClienteEntidad>>(json) ?? new();
        }
    }

    public static List<CuentaCorrienteClienteEntidad> ObtenerTodos() { return cuentasCorrientes; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(cuentasCorrientes);
        File.WriteAllText(Archivo, json);
    }
}
