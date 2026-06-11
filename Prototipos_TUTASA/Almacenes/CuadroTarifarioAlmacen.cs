using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CuadroTarifarioAlmacen
{
    private const string Archivo = "DATOS/CuadrosTarifarios.json";
    private static List<CuadroTarifarioEntidad> cuadrosTarifarios = new();

    static CuadroTarifarioAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            cuadrosTarifarios = JsonSerializer.Deserialize<List<CuadroTarifarioEntidad>>(json) ?? new();
        }
    }

    public static List<CuadroTarifarioEntidad> ObtenerTodos() { return cuadrosTarifarios; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(cuadrosTarifarios);
        File.WriteAllText(Archivo, json);
    }
}
