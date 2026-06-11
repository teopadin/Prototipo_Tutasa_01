using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class AgenciaAlmacen
{
    public static List<AgenciaEntidad> Agencias = new();

    static AgenciaAlmacen()
    {
        if (File.Exists("DATOS/Agencias.json"))
        {
            string json = File.ReadAllText("DATOS/Agencias.json");
            Agencias = JsonSerializer.Deserialize<List<AgenciaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(Agencias);
        File.WriteAllText("DATOS/Agencias.json", json);
    }
}
