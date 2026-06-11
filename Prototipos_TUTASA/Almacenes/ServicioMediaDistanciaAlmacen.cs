using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class ServicioMediaDistanciaAlmacen
{
    private const string Archivo = "DATOS/ServiciosMediaDistancia.json";
    private static List<ServicioMediaDistanciaEntidad> serviciosMediaDistancia = new();

    static ServicioMediaDistanciaAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            serviciosMediaDistancia = JsonSerializer.Deserialize<List<ServicioMediaDistanciaEntidad>>(json) ?? new();
        }
    }

    public static List<ServicioMediaDistanciaEntidad> ObtenerTodos() { return serviciosMediaDistancia; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(serviciosMediaDistancia);
        File.WriteAllText(Archivo, json);
    }
}
