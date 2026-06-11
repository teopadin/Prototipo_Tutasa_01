namespace Prototipos_TUTASA.Almacenes;

internal static class AgenciaAlmacen
{
    private const string Archivo = "Agencias.json";
    private static List<AgenciaEntidad> agencias = new();

    static AgenciaAlmacen() { agencias = AlmacenJson.Cargar<AgenciaEntidad>(Archivo); }

    public static List<AgenciaEntidad> ObtenerTodos() { return agencias; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, agencias); }
}
