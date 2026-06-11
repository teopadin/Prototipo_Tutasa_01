using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class TransportistaLocalAlmacen
{
    private const string Archivo = "DATOS/TransportistasLocales.json";
    private static List<TransportistaLocalEntidad> transportistas = new();

    static TransportistaLocalAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            transportistas = JsonSerializer.Deserialize<List<TransportistaLocalEntidad>>(json) ?? new();
        }
    }

    public static List<TransportistaLocalEntidad> ObtenerTodos() { return transportistas; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(transportistas);
        File.WriteAllText(Archivo, json);
    }
}
