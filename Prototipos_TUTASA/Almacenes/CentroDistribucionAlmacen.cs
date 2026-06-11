using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CentroDistribucionAlmacen
{
    private const string Archivo = "DATOS/CentrosDeDistribucion.json";
    private static List<CentroDistribucionEntidad> centrosDistribucion = new();

    static CentroDistribucionAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            centrosDistribucion = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json) ?? new();
        }
    }

    public static List<CentroDistribucionEntidad> ObtenerTodos() { return centrosDistribucion; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(centrosDistribucion);
        File.WriteAllText(Archivo, json);
    }
}
