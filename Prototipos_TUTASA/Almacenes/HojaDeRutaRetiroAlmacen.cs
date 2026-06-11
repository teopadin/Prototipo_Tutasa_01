using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaRetiroAlmacen
{
    public static List<HojaDeRutaRetiroEntidad> hojasDeRutaRetiro = new();

    static HojaDeRutaRetiroAlmacen()
    {
        if (File.Exists("DATOS/HojasDeRutaRetiro.json"))
        {
            string json = File.ReadAllText("DATOS/HojasDeRutaRetiro.json");
            hojasDeRutaRetiro = JsonSerializer.Deserialize<List<HojaDeRutaRetiroEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(hojasDeRutaRetiro);
        File.WriteAllText("DATOS/HojasDeRutaRetiro.json", json);
    }
}
