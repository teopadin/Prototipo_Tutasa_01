using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;

namespace Prototipos_TUTASA
{
    internal class FleteroResumenRetiroItem
    {
        public TransportistaLocalEntidad Fletero { get; }

        public FleteroResumenRetiroItem(TransportistaLocalEntidad fletero)
        {
            Fletero = fletero;
        }

        public override string ToString()
        {
            return $"{Fletero.Nombre} {Fletero.Apellido}";
        }
    }
}
