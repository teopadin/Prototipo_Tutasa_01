using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class CuadroTarifarioAlmacen
{
    public static List<CuadroTarifarioEntidad> cuadrosTarifarios = new();

    static CuadroTarifarioAlmacen()
    {
        if (File.Exists("DATOS/CuadrosTarifarios.json"))
        {
            string json = File.ReadAllText("DATOS/CuadrosTarifarios.json");
            cuadrosTarifarios = JsonSerializer.Deserialize<List<CuadroTarifarioEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(cuadrosTarifarios);
        File.WriteAllText("DATOS/CuadrosTarifarios.json", json);
    }
}
