using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class FacturaAlmacen
{
    private static List<FacturaEntidad> facturas = new();

    static FacturaAlmacen()
    {
        if (File.Exists("DATOS/Facturas.json"))
        {
            string json = File.ReadAllText("DATOS/Facturas.json");
            facturas = JsonSerializer.Deserialize<List<FacturaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(facturas);
        File.WriteAllText("DATOS/Facturas.json", json);
    }
}
