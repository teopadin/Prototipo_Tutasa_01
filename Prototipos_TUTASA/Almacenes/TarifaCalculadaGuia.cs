namespace Prototipos_TUTASA.Almacenes;

internal class TarifaCalculadaGuia
{
    public decimal PrecioFlete { get; set; }
    public decimal ExtraRetiroDomicilio { get; set; }
    public decimal ExtraEntregaDomicilio { get; set; }
    public decimal ExtraEntregaAgencia { get; set; }
    public decimal TarifaTotal { get; set; }

        // Cargos a pagar por TUTASA (nuevos)
    public decimal CostoFleteroRetiro { get; set; }
    public decimal CostoFleteroDistribucion { get; set; }
    public decimal ComisionAgenciaOrigen { get; set; }
    public decimal ComisionAgenciaDestino { get; set; }
    public decimal TotalCostosEmpresa { get; set; }
}
