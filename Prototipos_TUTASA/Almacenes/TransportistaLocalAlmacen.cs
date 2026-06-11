using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class TransportistaLocalAlmacen
{
    private static List<TransportistaLocalEntidad> transportistas = new();

    static TransportistaLocalAlmacen()
    {
        if (File.Exists("DATOS/TransportistasLocales.json"))
        {
            string json = File.ReadAllText("DATOS/TransportistasLocales.json");
            transportistas = JsonSerializer.Deserialize<List<TransportistaLocalEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(transportistas);
        File.WriteAllText("DATOS/TransportistasLocales.json", json);
    }
}
