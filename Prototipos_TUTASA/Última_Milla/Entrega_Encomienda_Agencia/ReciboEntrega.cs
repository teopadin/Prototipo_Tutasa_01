using System;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ReciboEntrega
    {
        public string NroGuia { get; set; } 
        public DateTime FechaEntrega { get; set; }
        public string NombreRetira { get; set; } 
        public string ApellidoRetira { get; set; } 
        public string DniRetira { get; set; } 
        public string Agencia { get; set; } 
    }
}
