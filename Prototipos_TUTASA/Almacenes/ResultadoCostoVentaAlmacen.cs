using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class ResultadoCostoVentaAlmacen
{
    private const string Archivo = "ResultadosCostoVenta.json";
    private static List<ResultadoCostoVentaEntidad> resultados = new();

    static ResultadoCostoVentaAlmacen() { resultados = AlmacenJson.Cargar<ResultadoCostoVentaEntidad>(Archivo); }

    public static List<ResultadoCostoVentaEntidad> ObtenerTodos() { return resultados; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, resultados); }
}
