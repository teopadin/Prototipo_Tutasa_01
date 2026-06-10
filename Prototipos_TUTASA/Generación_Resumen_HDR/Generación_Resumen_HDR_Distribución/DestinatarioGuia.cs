namespace Prototipos_TUTASA.ClasesResumenHDRDistribucion
{
    internal class DestinatarioGuia
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Piso { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }

        public DestinatarioGuia()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Calle = string.Empty;
            Piso = string.Empty;
            CodigoPostal = string.Empty;
            Ciudad = string.Empty;
        }
    }
}
