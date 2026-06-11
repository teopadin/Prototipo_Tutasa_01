using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ResultadoCostoVentaAlmacen
{
    private const string Archivo = "DATOS/ResultadosCostoVenta.json";
    private static List<ResultadoCostoVentaEntidad> resultados = new();

    static ResultadoCostoVentaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            resultados = JsonSerializer.Deserialize<List<ResultadoCostoVentaEntidad>>(json) ?? new();
        }
    }

    public static List<ResultadoCostoVentaEntidad> ObtenerTodos() { return resultados; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(resultados);
        File.WriteAllText(Archivo, json);
    }
}
