using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ResultadoCostoVentaAlmacen
{
    public static List<ResultadoCostoVentaEntidad> resultados = new();

    static ResultadoCostoVentaAlmacen()
    {
        if (File.Exists("DATOS/ResultadosCostoVenta.json"))
        {
            string json = File.ReadAllText("DATOS/ResultadosCostoVenta.json");
            resultados = JsonSerializer.Deserialize<List<ResultadoCostoVentaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(resultados);
        File.WriteAllText("DATOS/ResultadosCostoVenta.json", json);
    }
}
