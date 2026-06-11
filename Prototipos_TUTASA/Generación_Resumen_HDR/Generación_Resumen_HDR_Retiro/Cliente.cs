namespace Prototipos_TUTASA.ClasesResumenHDRRetiro
{
    internal class Cliente
    {
        public int idCliente { get; set; }
        public string calle { get; set; }
        public int altura { get; set; }
        public string codigoPostal { get; set; }

        public Cliente()
        {
            calle = string.Empty;
            codigoPostal = string.Empty;
        }
    }
}
