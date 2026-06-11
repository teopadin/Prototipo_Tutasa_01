using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ArrendamientoBodegaAlmacen
{
    public static List<ArrendamientoBodegaEntidad> arrendamientos = new();

    static ArrendamientoBodegaAlmacen()
    {
        if (File.Exists("DATOS/ArrendamientosBodega.json"))
        {
            string json = File.ReadAllText("DATOS/ArrendamientosBodega.json");
            arrendamientos = JsonSerializer.Deserialize<List<ArrendamientoBodegaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(arrendamientos);
        File.WriteAllText("DATOS/ArrendamientosBodega.json", json);
    }
}
