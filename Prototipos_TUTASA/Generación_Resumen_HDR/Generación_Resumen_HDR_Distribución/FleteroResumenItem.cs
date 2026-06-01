using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion;

namespace Prototipos_TUTASA
{
    internal class FleteroResumenItem
    {
        public TransportistaLocal Fletero { get; }

        public FleteroResumenItem(TransportistaLocal fletero)
        {
            Fletero = fletero;
        }

        public override string ToString()
        {
            return $"{Fletero.Nombre} {Fletero.Apellido}";
        }
    }
}
