namespace Prototipos_TUTASA.ClasesResumenHDRRetiro
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }

        public Cliente()
        {
            Calle = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
