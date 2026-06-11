using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaDistribucionAlmacen
{
    private const string Archivo = "HojasDeRutaDistribucion.json";
    private static List<HojaDeRutaDistribucionEntidad> hojasDeRutaDistribucion = new();

    static HojaDeRutaDistribucionAlmacen() { hojasDeRutaDistribucion = AlmacenJson.Cargar<HojaDeRutaDistribucionEntidad>(Archivo); }

    public static List<HojaDeRutaDistribucionEntidad> ObtenerTodos() { return hojasDeRutaDistribucion; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, hojasDeRutaDistribucion); }
}
