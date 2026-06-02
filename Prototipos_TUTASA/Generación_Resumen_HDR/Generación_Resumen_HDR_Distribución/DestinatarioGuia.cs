namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class DestinatarioGuia
    {
        public string Destinatario { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public DestinatarioGuia()
        {
            Destinatario = string.Empty;
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
