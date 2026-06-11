using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class ArrendamientoBodegaAlmacen
{
    private const string Archivo = "ArrendamientosBodega.json";
    private static List<ArrendamientoBodegaEntidad> arrendamientos = new();

    static ArrendamientoBodegaAlmacen() { arrendamientos = AlmacenJson.Cargar<ArrendamientoBodegaEntidad>(Archivo); }

    public static List<ArrendamientoBodegaEntidad> ObtenerTodos() { return arrendamientos; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, arrendamientos); }
}
