using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class ClienteAlmacen
{
    private const string Archivo = "Clientes.json";
    private static List<ClienteEntidad> clientes = new();

    static ClienteAlmacen() { clientes = AlmacenJson.Cargar<ClienteEntidad>(Archivo); }

    public static List<ClienteEntidad> ObtenerTodos() { return clientes; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, clientes); }
}
