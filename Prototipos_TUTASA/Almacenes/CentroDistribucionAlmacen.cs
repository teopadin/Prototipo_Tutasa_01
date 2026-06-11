using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CentroDistribucionAlmacen
{
    private static List<CentroDistribucionEntidad> centrosDistribucion = new();

    static CentroDistribucionAlmacen()
    {
        if (File.Exists("DATOS/CentrosDeDistribucion.json"))
        {
            string json = File.ReadAllText("DATOS/CentrosDeDistribucion.json");
            centrosDistribucion = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(centrosDistribucion);
        File.WriteAllText("DATOS/CentrosDeDistribucion.json", json);
    }
}
