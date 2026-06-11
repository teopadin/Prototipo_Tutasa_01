using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaTransporteAlmacen
{
    private static List<HojaDeRutaTransporteEntidad> hojasDeRutaTransporte = new();

    static HojaDeRutaTransporteAlmacen()
    {
        if (File.Exists("DATOS/HojasDeRutaTransporte.json"))
        {
            string json = File.ReadAllText("DATOS/HojasDeRutaTransporte.json");
            hojasDeRutaTransporte = JsonSerializer.Deserialize<List<HojaDeRutaTransporteEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(hojasDeRutaTransporte);
        File.WriteAllText("DATOS/HojasDeRutaTransporte.json", json);
    }
}
