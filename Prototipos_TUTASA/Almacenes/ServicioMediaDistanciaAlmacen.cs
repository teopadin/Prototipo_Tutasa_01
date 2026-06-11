using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ServicioMediaDistanciaAlmacen
{
    public static List<ServicioMediaDistanciaEntidad> serviciosMediaDistancia = new();

    static ServicioMediaDistanciaAlmacen()
    {
        if (File.Exists("DATOS/ServiciosMediaDistancia.json"))
        {
            string json = File.ReadAllText("DATOS/ServiciosMediaDistancia.json");
            serviciosMediaDistancia = JsonSerializer.Deserialize<List<ServicioMediaDistanciaEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(serviciosMediaDistancia);
        File.WriteAllText("DATOS/ServiciosMediaDistancia.json", json);
    }
}
