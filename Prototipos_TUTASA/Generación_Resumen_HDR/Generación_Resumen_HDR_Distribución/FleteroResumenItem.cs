namespace Prototipos_TUTASA
{
    internal class FleteroResumenItem
    {
        public FleteroResumen Fletero { get; }

        public FleteroResumenItem(FleteroResumen fletero)
        {
            Fletero = fletero;
        }

        public override string ToString()
        {
            return $"{Fletero.Nombre} {Fletero.Apellido}";
        }
    }
}
