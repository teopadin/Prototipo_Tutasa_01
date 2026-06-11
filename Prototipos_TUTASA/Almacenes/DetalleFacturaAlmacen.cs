using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class DetalleFacturaAlmacen
{
    private const string Archivo = "DATOS/DetallesFactura.json";
    private static List<DetalleFacturaEntidad> detallesFactura = new();

    static DetalleFacturaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            detallesFactura = JsonSerializer.Deserialize<List<DetalleFacturaEntidad>>(json) ?? new();
        }
    }

    public static List<DetalleFacturaEntidad> ObtenerTodos() { return detallesFactura; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(detallesFactura);
        File.WriteAllText(Archivo, json);
    }
}
