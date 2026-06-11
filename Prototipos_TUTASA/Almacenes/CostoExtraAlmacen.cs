namespace Prototipos_TUTASA.Almacenes;

internal static class CostoExtraAlmacen
{
    private const string Archivo = "CostosExtra.json";
    private static List<CostoExtraEntidad> costosExtra = new();

    static CostoExtraAlmacen() { costosExtra = AlmacenJson.Cargar<CostoExtraEntidad>(Archivo); }

    public static List<CostoExtraEntidad> ObtenerTodos() { return costosExtra; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, costosExtra); }
}
