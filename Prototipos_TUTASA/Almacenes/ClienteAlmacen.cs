using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ClienteAlmacen
{
    private const string Archivo = "DATOS/Clientes.json";
    private static List<ClienteEntidad> clientes = new();

    static ClienteAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json) ?? new();
        }
    }

    public static List<ClienteEntidad> ObtenerTodos() { return clientes; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(clientes);
        File.WriteAllText(Archivo, json);
    }
}
