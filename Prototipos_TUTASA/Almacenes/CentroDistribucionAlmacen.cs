using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CentroDistribucionAlmacen
{
    public static List<CentroDistribucionEntidad> CentrosDeDistribucion = new();

    static CentroDistribucionAlmacen()
    {
        if (File.Exists("DATOS/CentrosDeDistribucion.json"))
        {
            string json = File.ReadAllText("DATOS/CentrosDeDistribucion.json");
            CentrosDeDistribucion = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(CentrosDeDistribucion);
        File.WriteAllText("DATOS/CentrosDeDistribucion.json", json);
    }
}
