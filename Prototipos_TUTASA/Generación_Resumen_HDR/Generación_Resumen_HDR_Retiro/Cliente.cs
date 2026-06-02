namespace Prototipos_TUTASA.ClasesResumenHDRRetiro
{
    internal class Cliente
    {
        public string Remitente { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public Cliente()
        {
            Remitente = string.Empty;
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
