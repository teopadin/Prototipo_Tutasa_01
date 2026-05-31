using System;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ReciboEntregaEntidad
    {
        public string NroGuia { get; set; } = string.Empty;
        public DateTime FechaEntrega { get; set; }
        public string NombreRetira { get; set; } = string.Empty;
        public string ApellidoRetira { get; set; } = string.Empty;
        public string DniRetira { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
    }
}
