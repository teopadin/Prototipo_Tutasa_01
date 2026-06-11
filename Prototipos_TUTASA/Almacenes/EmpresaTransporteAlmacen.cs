namespace Prototipos_TUTASA.Almacenes;

internal static class EmpresaTransporteAlmacen
{
    private const string Archivo = "EmpresasTransporte.json";
    private static List<EmpresaTransporteEntidad> empresas = new();

    static EmpresaTransporteAlmacen() { empresas = AlmacenJson.Cargar<EmpresaTransporteEntidad>(Archivo); }

    public static List<EmpresaTransporteEntidad> ObtenerTodos() { return empresas; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, empresas); }
}
