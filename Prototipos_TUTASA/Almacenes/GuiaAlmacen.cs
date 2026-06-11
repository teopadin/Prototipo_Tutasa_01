using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class GuiaAlmacen
{
    private const string Archivo = "Guias.json";
    private static List<GuiaEntidad> guias = new();

    static GuiaAlmacen() { guias = AlmacenJson.Cargar<GuiaEntidad>(Archivo); }

    public static List<GuiaEntidad> ObtenerTodos() { return guias; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, guias); }
}
