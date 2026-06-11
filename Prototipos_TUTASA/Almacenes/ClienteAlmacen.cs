using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ClienteAlmacen
{
    private static List<ClienteEntidad> clientes = new();

    static ClienteAlmacen()
    {
        if (File.Exists("DATOS/Clientes.json"))
        {
            string json = File.ReadAllText("DATOS/Clientes.json");
            clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(clientes);
        File.WriteAllText("DATOS/Clientes.json", json);
    }
}
