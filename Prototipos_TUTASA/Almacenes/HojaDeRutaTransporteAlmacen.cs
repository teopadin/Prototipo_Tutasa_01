using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaTransporteAlmacen
{
    private const string Archivo = "DATOS/HojasDeRutaTransporte.json";
    private static List<HojaDeRutaTransporteEntidad> hojasDeRutaTransporte = new();

    static HojaDeRutaTransporteAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            hojasDeRutaTransporte = JsonSerializer.Deserialize<List<HojaDeRutaTransporteEntidad>>(json) ?? new();
        }
    }

    public static List<HojaDeRutaTransporteEntidad> ObtenerTodos() { return hojasDeRutaTransporte; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(hojasDeRutaTransporte);
        File.WriteAllText(Archivo, json);
    }
}
