using System.Text.Json;
using System.Text.Json.Serialization;

namespace Prototipos_TUTASA.Auxiliares;

internal static class AlmacenJson
{
    private static readonly JsonSerializerOptions Opciones = new()
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static List<T> Cargar<T>(string archivo)
    {
        string ruta = ObtenerRuta(archivo);

        if (!File.Exists(ruta))
        {
            return new List<T>();
        }

        string json = File.ReadAllText(ruta);
        return JsonSerializer.Deserialize<List<T>>(json, Opciones) ?? new List<T>();
    }

    public static void Guardar<T>(string archivo, List<T> datos)
    {
        string ruta = ObtenerRuta(archivo);
        Directory.CreateDirectory(Path.GetDirectoryName(ruta)!);

        string json = JsonSerializer.Serialize(datos, Opciones);
        File.WriteAllText(ruta, json);
    }

    private static string ObtenerRuta(string archivo)
    {
        return Path.Combine(AppContext.BaseDirectory, "DATOS", archivo);
    }
}
