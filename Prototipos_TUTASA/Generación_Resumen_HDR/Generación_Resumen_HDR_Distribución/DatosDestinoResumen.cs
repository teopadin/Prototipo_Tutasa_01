namespace Prototipos_TUTASA
{
    internal class DatosDestinoResumen
    {
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public string ClaveDomicilio
        {
            get { return $"{Calle}|{Altura}|{CodigoPostal}".ToUpperInvariant(); }
        }

        public DatosDestinoResumen()
        {
            Nombre = string.Empty;
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
