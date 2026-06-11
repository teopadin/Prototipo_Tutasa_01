using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class GuiaAlmacen
{
    private const string Archivo = "DATOS/Guias.json";
    private static List<GuiaEntidad> guias = new();

    static GuiaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json) ?? new();
        }
    }

    public static List<GuiaEntidad> ObtenerTodos() { return guias; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(guias);
        File.WriteAllText(Archivo, json);
    }
}
