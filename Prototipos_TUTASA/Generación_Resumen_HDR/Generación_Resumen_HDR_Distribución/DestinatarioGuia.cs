namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class DestinatarioGuia
    {
        public int Dni { get; set; }
        public string calle { get; set; }
        public int altura { get; set; }
        public string codigoPostal { get; set; }

        public DestinatarioGuia()
        {
            calle = string.Empty;
            codigoPostal = string.Empty;
        }
    }
}
