using System;
using System.Windows.Forms;
using Prototipos_TUTASA.ImposiciónCallCenter_v2;
using Prototipos_TUTASA.Rendiciones_HDR;
using Prototipos_TUTASA.ResultadoCostoVSVentas_v2;
using Prototipos_TUTASA.HojaDeRutaDeDistribucion;
using Prototipos_TUTASA.HojaDeRutaRetiro;
using Prototipos_TUTASA.Generación_Hoja_De_Ruta_De_Transporte;
using Prototipos_TUTASA.Despacho_Servicios_Media_Distancia;

namespace Prototipos_TUTASA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new ConsultarEstadoDelPedido_v2.ConsultarEstadoDelPedido());
            //Application.Run(new Admisión.Admisión());
            //Application.Run(new Rendir_HDR_De_Retiro());
            Application.Run(new HojaDeRutaDeDistribucionDestinatario());
            //Application.Run(new GeneracionHojaDeRutaRetiro());
            //Application.Run(new GenerarHojaDeRutaDeTransporte());
            //Application.Run(new EntregaEncomiendaCD());
            //Application.Run(new Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia.EntregaAgencia());
            //Application.Run(new Prototipos_TUTASA.Despacho_Servicios_Media_Distancia.Despacho_Servicios_Media_Distancia());
            Application.Run(new Despacho_Servicios_Media_Distancia.Despacho_Servicios_Media_Distancia());

        }
    }
}