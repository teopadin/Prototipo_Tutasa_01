using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal static class CuadroTarifarioAlmacen
{
    private const string Archivo = "CuadrosTarifarios.json";
    private static List<CuadroTarifarioEntidad> cuadrosTarifarios = new();

    static CuadroTarifarioAlmacen() { cuadrosTarifarios = AlmacenJson.Cargar<CuadroTarifarioEntidad>(Archivo); }

    public static List<CuadroTarifarioEntidad> ObtenerTodos() { return cuadrosTarifarios; }

    public static void Guardar() { AlmacenJson.Guardar(Archivo, cuadrosTarifarios); }
}
