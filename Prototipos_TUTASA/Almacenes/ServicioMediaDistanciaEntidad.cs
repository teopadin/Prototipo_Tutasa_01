using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class ServicioMediaDistanciaEntidad
{
    public string idServicio { get; set; }
    public int idEmpresa { get; set; }
    public DateTime fechaSalida { get; set; }
    public DateTime? fechaLlegada { get; set; }
    public DateTime? fechaRecepcion { get; set; }
    public int capacidadDisponible { get; set; }
    public int idCDOrigen { get; set; }
    public int idCDDestino { get; set; }
    public List<int> DetalleHDRs { get; set; } = new();
    public TipoArrendamientoEnum tipoArrendamiento { get; set; }
}
