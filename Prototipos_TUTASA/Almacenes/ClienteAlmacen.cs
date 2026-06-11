using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ClienteAlmacen
{
    public static List<ClienteEntidad> Clientes = new();

    static ClienteAlmacen()
    {
        if (File.Exists("DATOS/Clientes.json"))
        {
            string json = File.ReadAllText("DATOS/Clientes.json");
            Clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(Clientes);
        File.WriteAllText("DATOS/Clientes.json", json);
    }
}
