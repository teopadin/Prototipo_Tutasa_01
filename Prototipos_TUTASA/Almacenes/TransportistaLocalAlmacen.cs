using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class TransportistaLocalAlmacen
{
    private const string Archivo = "TransportistasLocales.json";
    private static List<TransportistaLocalEntidad> transportistas = new();

    static TransportistaLocalAlmacen() { transportistas = AlmacenJson.Cargar<TransportistaLocalEntidad>(Archivo); }

    public static List<TransportistaLocalEntidad> ObtenerTodos() { return transportistas; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, transportistas); }
}
