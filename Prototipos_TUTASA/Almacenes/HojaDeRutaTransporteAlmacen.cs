using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaTransporteAlmacen
{
    private const string Archivo = "HojasDeRutaTransporte.json";
    private static List<HojaDeRutaTransporteEntidad> hojasDeRutaTransporte = new();

    static HojaDeRutaTransporteAlmacen() { hojasDeRutaTransporte = AlmacenJson.Cargar<HojaDeRutaTransporteEntidad>(Archivo); }

    public static List<HojaDeRutaTransporteEntidad> ObtenerTodos() { return hojasDeRutaTransporte; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, hojasDeRutaTransporte); }
}
