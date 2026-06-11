using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class HojaDeRutaTransporteEntidad
{
    public int nroHDR { get; set; }
    public DateTime fechaGeneracion { get; set; }
    public int idCDOrigen { get; set; }
    public int idCDDestino { get; set; }
    public EstadoHojaDeRutaEnum estado { get; set; }
    public string idServicio { get; set; }
    public List<string> DetalleGuias { get; set; } = new();
}
