using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class DetalleFacturaAlmacen
{
    private const string Archivo = "DetallesFactura.json";
    private static List<DetalleFacturaEntidad> detallesFactura = new();

    static DetalleFacturaAlmacen() { detallesFactura = AlmacenJson.Cargar<DetalleFacturaEntidad>(Archivo); }

    public static List<DetalleFacturaEntidad> ObtenerTodos() { return detallesFactura; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, detallesFactura); }
}
