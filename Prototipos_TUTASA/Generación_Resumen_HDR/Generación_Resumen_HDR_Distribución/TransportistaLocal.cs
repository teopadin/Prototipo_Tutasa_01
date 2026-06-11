namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class TransportistaLocal
    {
        public int dniTransportista { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public TransportistaLocal()
        {
            nombre = string.Empty;
            apellido = string.Empty;
        }

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }
    }
}
