using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CostoExtraAlmacen
{
    public static List<CostoExtraEntidad> costosExtra = new();

    static CostoExtraAlmacen()
    {
        if (File.Exists("DATOS/CostosExtra.json"))
        {
            string json = File.ReadAllText("DATOS/CostosExtra.json");
            costosExtra = JsonSerializer.Deserialize<List<CostoExtraEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(costosExtra);
        File.WriteAllText("DATOS/CostosExtra.json", json);
    }
}
