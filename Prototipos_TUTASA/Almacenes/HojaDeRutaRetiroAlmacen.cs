using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaRetiroAlmacen
{
    private const string Archivo = "DATOS/HojasDeRutaRetiro.json";
    private static List<HojaDeRutaRetiroEntidad> hojasDeRutaRetiro = new();

    static HojaDeRutaRetiroAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            hojasDeRutaRetiro = JsonSerializer.Deserialize<List<HojaDeRutaRetiroEntidad>>(json) ?? new();
        }
    }

    public static List<HojaDeRutaRetiroEntidad> ObtenerTodos() { return hojasDeRutaRetiro; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(hojasDeRutaRetiro);
        File.WriteAllText(Archivo, json);
    }
}
