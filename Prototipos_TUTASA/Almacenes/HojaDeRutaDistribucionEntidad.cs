using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class HojaDeRutaDistribucionEntidad
{
    public int NroHDR { get; set; }
    public DateTime Fecha { get; set; }
    public EstadoHojaDeRutaEnum estado { get; set; }
    public int dniTransportistaAsignado { get; set; }
    public string Calle { get; set; }
    public int Altura { get; set; }
    public string Piso { get; set; }
    public string CodigoPostal { get; set; }
    public string Destinatario { get; set; }
    public List<string> DetalleGuias { get; set; } = new();
    public MotivoNoCumplidaDistribucionEnum motivoNoCumplida { get; set; }
}
