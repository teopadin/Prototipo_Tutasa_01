using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class FacturaAlmacen
{
    private const string Archivo = "DATOS/Facturas.json";
    private static List<FacturaEntidad> facturas = new();

    static FacturaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            facturas = JsonSerializer.Deserialize<List<FacturaEntidad>>(json) ?? new();
        }
    }

    public static List<FacturaEntidad> ObtenerTodos() { return facturas; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(facturas);
        File.WriteAllText(Archivo, json);
    }
}
