using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class AgenciaAlmacen
{
    private static List<AgenciaEntidad> agencias = new();

    static AgenciaAlmacen()
    {
        if (File.Exists("DATOS/Agencias.json"))
        {
            string json = File.ReadAllText("DATOS/Agencias.json");
            agencias = JsonSerializer.Deserialize<List<AgenciaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(agencias);
        File.WriteAllText("DATOS/Agencias.json", json);
    }
}
