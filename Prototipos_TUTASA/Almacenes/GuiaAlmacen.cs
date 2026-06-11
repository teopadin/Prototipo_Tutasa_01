using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class GuiaAlmacen
{
    private static List<GuiaEntidad> guias = new();

    static GuiaAlmacen()
    {
        if (File.Exists("DATOS/Guias.json"))
        {
            string json = File.ReadAllText("DATOS/Guias.json");
            guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(guias);
        File.WriteAllText("DATOS/Guias.json", json);
    }
}
