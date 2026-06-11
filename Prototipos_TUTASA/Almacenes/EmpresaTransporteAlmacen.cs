using System.Text.Json;

namespace Prototipos_TUTASA.Almacenes;

internal static class EmpresaTransporteAlmacen
{
    private static List<EmpresaTransporteEntidad> empresas = new();

    static EmpresaTransporteAlmacen()
    {
        if (File.Exists("DATOS/EmpresasTransporte.json"))
        {
            string json = File.ReadAllText("DATOS/EmpresasTransporte.json");
            empresas = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json);
        }
    }

    public static void Guardar()
    {
        string json = JsonSerializer.Serialize(empresas);
        File.WriteAllText("DATOS/EmpresasTransporte.json", json);
    }
}
