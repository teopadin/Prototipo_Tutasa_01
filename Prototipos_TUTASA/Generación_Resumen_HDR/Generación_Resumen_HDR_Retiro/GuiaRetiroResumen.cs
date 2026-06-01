namespace Prototipos_TUTASA
{
    internal class GuiaRetiroResumen
    {
        public string NroGuia { get; set; }
        public string Remitente { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public GuiaRetiroResumen()
        {
            NroGuia = string.Empty;
            Remitente = string.Empty;
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
