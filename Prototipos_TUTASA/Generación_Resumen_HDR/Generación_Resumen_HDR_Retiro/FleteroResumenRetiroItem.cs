namespace Prototipos_TUTASA
{
    internal class FleteroResumenRetiroItem
    {
        public FleteroResumenRetiro Fletero { get; }

        public FleteroResumenRetiroItem(FleteroResumenRetiro fletero)
        {
            Fletero = fletero;
        }

        public override string ToString()
        {
            return $"{Fletero.Nombre} {Fletero.Apellido}";
        }
    }
}
