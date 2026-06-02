namespace Prototipos_TUTASA
{
    internal class TransportistaLocal
    {
        public int DniTransportista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public TransportistaLocal()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
