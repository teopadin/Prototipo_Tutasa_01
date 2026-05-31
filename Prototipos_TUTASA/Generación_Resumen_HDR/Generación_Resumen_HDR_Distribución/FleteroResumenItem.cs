using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;

namespace Prototipos_TUTASA
{
    internal class FleteroResumenItem
    {
        public TransportistaLocalEntidad Fletero { get; }

        public FleteroResumenItem(TransportistaLocalEntidad fletero)
        {
            Fletero = fletero;
        }

        public override string ToString()
        {
            return $"{Fletero.Nombre} {Fletero.Apellido}";
        }
    }
}
