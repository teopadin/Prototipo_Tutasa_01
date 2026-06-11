namespace Prototipos_TUTASA.Almacenes;

internal static class ServicioMediaDistanciaAlmacen
{
    private const string Archivo = "ServiciosMediaDistancia.json";
    private static List<ServicioMediaDistanciaEntidad> serviciosMediaDistancia = new();

    static ServicioMediaDistanciaAlmacen() { serviciosMediaDistancia = AlmacenJson.Cargar<ServicioMediaDistanciaEntidad>(Archivo); }

    public static List<ServicioMediaDistanciaEntidad> ObtenerTodos() { return serviciosMediaDistancia; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, serviciosMediaDistancia); }
}
