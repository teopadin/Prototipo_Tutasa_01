using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class AgenciaAlmacen
{
    private const string Archivo = "DATOS/Agencias.json";
    private static List<AgenciaEntidad> agencias = new();

    static AgenciaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            agencias = JsonSerializer.Deserialize<List<AgenciaEntidad>>(json) ?? new();
        }
    }

    public static List<AgenciaEntidad> ObtenerTodos() { return agencias; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(agencias);
        File.WriteAllText(Archivo, json);
    }
}
