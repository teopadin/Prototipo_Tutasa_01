namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class DestinatarioGuia
    {
        public int Dni { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public DestinatarioGuia()
        {
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
