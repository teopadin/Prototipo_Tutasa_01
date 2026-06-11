using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Almacenes;

internal class GuiaEntidad
{
    public string NroGuia { get; set; } = string.Empty;
    public int IdCliente { get; set; }
    public TipoImposicionEnum TipoImposicion { get; set; }
    public int idCDOrigen { get; set; }
    public int idAgenciaOrigen { get; set; }
    public int idCDActual { get; set; }
    public ModalidadEntregaEnum modalidadEntrega { get; set; }
    public int idCDDestino { get; set; }
    public int idAgenciaDestino { get; set; }
    public DestinatarioGuia Destinatario { get; set; } = new();
    public TiposBultoEnum TipoBulto { get; set; }
    public int EquivalenteS { get; set; }
    public EstadoGuiaEnum estado { get; set; }
    public List<HistorialEstadoGuia> Historial { get; set; } = new();
    public TarifaCalculadaGuia TarifaCalculada { get; set; } = new();
}
