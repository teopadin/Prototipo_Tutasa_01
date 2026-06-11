using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaDistribucionAlmacen
{
    public static List<HojaDeRutaDistribucionEntidad> hojasDeRutaDistribucion = new();

    static HojaDeRutaDistribucionAlmacen()
    {
        if (File.Exists("DATOS/HojasDeRutaDistribucion.json"))
        {
            string json = File.ReadAllText("DATOS/HojasDeRutaDistribucion.json");
            hojasDeRutaDistribucion = JsonSerializer.Deserialize<List<HojaDeRutaDistribucionEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(hojasDeRutaDistribucion);
        File.WriteAllText("DATOS/HojasDeRutaDistribucion.json", json);
    }
}
