namespace Prototipos_TUTASA.Almacenes;

internal static class HojaDeRutaRetiroAlmacen
{
    private const string Archivo = "HojasDeRutaRetiro.json";
    private static List<HojaDeRutaRetiroEntidad> hojasDeRutaRetiro = new();

    static HojaDeRutaRetiroAlmacen() { hojasDeRutaRetiro = AlmacenJson.Cargar<HojaDeRutaRetiroEntidad>(Archivo); }

    public static List<HojaDeRutaRetiroEntidad> ObtenerTodos() { return hojasDeRutaRetiro; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, hojasDeRutaRetiro); }
}
