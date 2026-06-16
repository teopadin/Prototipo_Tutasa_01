using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class TarifaTransportistaLocalAlmacen
{
    public static List<TarifaTransportistaLocalEntidad> tarifasTransportistas = new();

    static TarifaTransportistaLocalAlmacen()
    {
        if (File.Exists("DATOS/TarifasTransportistas.json"))
        {
            string json = File.ReadAllText("DATOS/TarifasTransportistas.json");
            tarifasTransportistas = JsonSerializer.Deserialize<List<TarifaTransportistaLocalEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(tarifasTransportistas);
        File.WriteAllText("DATOS/TarifasTransportistas.json", json);
    }
}