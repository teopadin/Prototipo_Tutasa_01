using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class HojaDeRutaRetiroEntidad
{
    public int NroHDR { get; set; }
    public DateTime Fecha { get; set; }
    public EstadoHojaDeRutaEnum estado { get; set; }
    public int dniTransportistaAsignado { get; set; }
    public int? idAgenciaOrigen { get; set; }
    public string Calle { get; set; } = string.Empty;
    public int Altura { get; set; }
    public string Piso { get; set; } = string.Empty;
    public string CodigoPostal { get; set; } = string.Empty;
    public string Remitente { get; set; } = string.Empty;
    public List<string> DetalleGuias { get; set; } = new();
    public MotivoNoCumplidaRetiroEnum motivoNoCumplida { get; set; }
}
