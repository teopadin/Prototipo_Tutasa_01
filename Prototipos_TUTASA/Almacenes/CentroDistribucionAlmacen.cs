namespace Prototipos_TUTASA.Almacenes;

internal static class CentroDistribucionAlmacen
{
    private const string Archivo = "CentrosDeDistribucion.json";
    private static List<CentroDistribucionEntidad> centrosDistribucion = new();

    static CentroDistribucionAlmacen() { centrosDistribucion = AlmacenJson.Cargar<CentroDistribucionEntidad>(Archivo); }

    public static List<CentroDistribucionEntidad> ObtenerTodos() { return centrosDistribucion; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, centrosDistribucion); }
}
