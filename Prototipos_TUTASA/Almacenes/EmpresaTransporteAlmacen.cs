using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class EmpresaTransporteAlmacen
{
    private const string Archivo = "DATOS/EmpresasTransporte.json";
    private static List<EmpresaTransporteEntidad> empresas = new();

    static EmpresaTransporteAlmacen()
    {
        if (File.Exists(Archivo))
        {
            string json = File.ReadAllText(Archivo);
            empresas = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json) ?? new();
        }
    }

    public static List<EmpresaTransporteEntidad> ObtenerTodos() { return empresas; }

    public static void Guardar()
    {
        Directory.CreateDirectory("DATOS");
        string json = JsonSerializer.Serialize(empresas);
        File.WriteAllText(Archivo, json);
    }
}
