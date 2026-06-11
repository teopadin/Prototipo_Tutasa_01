using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class GuiaAlmacen
{
    public static List<GuiaEntidad> Guias = new();

    static GuiaAlmacen()
    {
        if (File.Exists("DATOS/Guias.json"))
        {
            string json = File.ReadAllText("DATOS/Guias.json");
            Guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(Guias);
        File.WriteAllText("DATOS/Guias.json", json);
    }
}
