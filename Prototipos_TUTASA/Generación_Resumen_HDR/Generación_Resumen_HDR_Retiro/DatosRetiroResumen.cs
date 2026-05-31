namespace Prototipos_TUTASA
{
    internal class DatosRetiroResumen
    {
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public string ClaveDomicilio
        {
            get { return $"{Calle}|{Altura}|{CodigoPostal}".ToUpperInvariant(); }
        }

        public DatosRetiroResumen()
        {
            Nombre = string.Empty;
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
