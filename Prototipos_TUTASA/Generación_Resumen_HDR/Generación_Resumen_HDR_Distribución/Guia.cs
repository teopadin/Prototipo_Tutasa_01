namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public string Destinatario { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public Guia()
        {
            NroGuia = string.Empty;
            Destinatario = string.Empty;
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
