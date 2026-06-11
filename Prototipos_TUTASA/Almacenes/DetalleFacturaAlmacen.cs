using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class DetalleFacturaAlmacen
{
    public static List<DetalleFacturaEntidad> detallesFactura = new();

    static DetalleFacturaAlmacen()
    {
        if (File.Exists("DATOS/DetallesFactura.json"))
        {
            string json = File.ReadAllText("DATOS/DetallesFactura.json");
            detallesFactura = JsonSerializer.Deserialize<List<DetalleFacturaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(detallesFactura);
        File.WriteAllText("DATOS/DetallesFactura.json", json);
    }
}
