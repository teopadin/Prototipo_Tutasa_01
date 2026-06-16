using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ComisionAgenciaAlmacen
{
    public static List<ComisionAgenciaEntidad> comisionesAgencias = new();

    static ComisionAgenciaAlmacen()
    {
        if (File.Exists("DATOS/ComisionesAgencias.json"))
        {
            string json = File.ReadAllText("DATOS/ComisionesAgencias.json");
            comisionesAgencias = JsonSerializer.Deserialize<List<ComisionAgenciaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(comisionesAgencias);
        File.WriteAllText("DATOS/ComisionesAgencias.json", json);
    }
}