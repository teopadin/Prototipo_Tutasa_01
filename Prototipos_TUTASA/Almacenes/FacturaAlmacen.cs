using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class FacturaAlmacen
{
    private const string Archivo = "Facturas.json";
    private static List<FacturaEntidad> facturas = new();

    static FacturaAlmacen() { facturas = AlmacenJson.Cargar<FacturaEntidad>(Archivo); }

    public static List<FacturaEntidad> ObtenerTodos() { return facturas; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, facturas); }
}
