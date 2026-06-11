using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CuentaCorrienteClienteAlmacen
{
    private static List<CuentaCorrienteClienteEntidad> cuentasCorrientes = new();

    static CuentaCorrienteClienteAlmacen()
    {
        if (File.Exists("DATOS/CuentasCorrientesClientes.json"))
        {
            string json = File.ReadAllText("DATOS/CuentasCorrientesClientes.json");
            cuentasCorrientes = JsonSerializer.Deserialize<List<CuentaCorrienteClienteEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(cuentasCorrientes);
        File.WriteAllText("DATOS/CuentasCorrientesClientes.json", json);
    }
}
