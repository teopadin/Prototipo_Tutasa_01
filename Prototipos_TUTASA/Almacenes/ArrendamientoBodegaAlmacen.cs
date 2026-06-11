using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ArrendamientoBodegaAlmacen
{
    private const string Archivo = "DATOS/ArrendamientosBodega.json";
    private static List<ArrendamientoBodegaEntidad> arrendamientos = new();

    static ArrendamientoBodegaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            arrendamientos = JsonSerializer.Deserialize<List<ArrendamientoBodegaEntidad>>(json) ?? new();
        }
    }

    public static List<ArrendamientoBodegaEntidad> ObtenerTodos() { return arrendamientos; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(arrendamientos);
        File.WriteAllText(Archivo, json);
    }
}
