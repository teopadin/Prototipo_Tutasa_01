using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CostoExtraAlmacen
{
    private const string Archivo = "DATOS/CostosExtra.json";
    private static List<CostoExtraEntidad> costosExtra = new();

    static CostoExtraAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            costosExtra = JsonSerializer.Deserialize<List<CostoExtraEntidad>>(json) ?? new();
        }
    }

    public static List<CostoExtraEntidad> ObtenerTodos() { return costosExtra; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(costosExtra);
        File.WriteAllText(Archivo, json);
    }
}
