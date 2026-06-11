using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaDistribucionAlmacen
{
    private const string Archivo = "DATOS/HojasDeRutaDistribucion.json";
    private static List<HojaDeRutaDistribucionEntidad> hojasDeRutaDistribucion = new();

    static HojaDeRutaDistribucionAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            hojasDeRutaDistribucion = JsonSerializer.Deserialize<List<HojaDeRutaDistribucionEntidad>>(json) ?? new();
        }
    }

    public static List<HojaDeRutaDistribucionEntidad> ObtenerTodos() { return hojasDeRutaDistribucion; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(hojasDeRutaDistribucion);
        File.WriteAllText(Archivo, json);
    }
}
