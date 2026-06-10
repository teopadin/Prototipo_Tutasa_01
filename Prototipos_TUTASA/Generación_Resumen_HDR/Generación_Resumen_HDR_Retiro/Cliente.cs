namespace Prototipos_TUTASA.ClasesResumenHDRRetiro
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public long Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Piso { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }

        public Cliente()
        {
            RazonSocial = string.Empty;
            Telefono = string.Empty;
            Calle = string.Empty;
            Piso = string.Empty;
            Ciudad = string.Empty;
            CodigoPostal = string.Empty;
        }
    }
}
