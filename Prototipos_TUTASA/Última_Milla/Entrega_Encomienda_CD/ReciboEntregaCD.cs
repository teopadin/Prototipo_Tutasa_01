using System;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_CD
{
    internal class ReciboEntregaCD
    {
        public int NroRecibo { get; set; }
        public string NroGuia { get; set; } = string.Empty;
        public DateTime FechaEntrega { get; set; }
        public string NombreRetira { get; set; } = string.Empty;
        public string ApellidoRetira { get; set; } = string.Empty;
        public int DniRetira { get; set; }
    }
}
