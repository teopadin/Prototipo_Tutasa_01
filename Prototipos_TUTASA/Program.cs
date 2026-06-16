using System;
using System.Windows.Forms;
using Prototipos_TUTASA.ImposiciónCallCenter_v2;
using Prototipos_TUTASA.Rendiciones_HDR;
using Prototipos_TUTASA.ResultadoCostoVSVentas_v2;
using Prototipos_TUTASA.HojaDeRutaDeDistribucion;
using Prototipos_TUTASA.HojaDeRutaRetiro;
using Prototipos_TUTASA.Generación_Hoja_De_Ruta_De_Transporte;
using Prototipos_TUTASA.Despacho_Servicios_Media_Distancia;
using Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia;
using Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia;
using Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia;
using Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_CD;
using Prototipos_TUTASA.RecepcionMediaDistancia;

namespace Prototipos_TUTASA
{
    internal static class Program
    {
        public static int CodigoCDActual { get; set; } = 1;
        public static int CodigoAgenciaActual { get; set; } = 1;
        public static bool IniciaDesdeAgencia { get; set; } = false;
        public static DateTime FechaPrueba { get; set; } = new DateTime(2026, 6, 12);

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Prototipos_TUTASA.ImposiciónAgencia_v2.ImposicionAgencia_v2());
            //Application.Run(new Prototipos_TUTASA.ImposiciónCallCenter_v2.ImposicionCallCenter_v2());
            //Application.Run(new Prototipos_TUTASA.ImposiciónCD_V2.ImposiciónCD_V2());
            //Application.Run(new GeneracionHojaDeRutaRetiro());
            //Application.Run(new Resumen_HDR_Retiro());
            //Application.Run(new Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia.Recepcion_HDR_Retiro_Agencia());
            //Application.Run(new Rendir_HDR_De_Retiro());
            //Application.Run(new Admisión.Admisión());
            //Application.Run(new GenerarHojaDeRutaDeTransporte());
            //Application.Run(new Despacho_Servicios_Media_Distancia.Despacho_Servicios_Media_Distancia());
            //Application.Run(new Prototipos_TUTASA.RecepcionMediaDistancia.RecepcionMediaDistancia());
            //Application.Run(new HojaDeRutaDeDistribucionDestinatario());
            //Application.Run(new Generacion_Resumen_HDR_Distribucion());
            //Application.Run(new Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia.Recepcion_HDR_Distribucion_Agencia());
            //Application.Run(new Prototipos_TUTASA.Rendiciones_HDR.Rendir_HDR_De_Distribucion());
            //Application.Run(new EntregaEncomiendaCD());
            //Application.Run(new ConsultarEstadoDelPedido_v2.ConsultarEstadoDelPedido());
            //Application.Run(new resultadocostosvsventas());
            //Application.Run(new Prototipos_TUTASA.Admisión_CallCenteryAgencia_v2.EstadoCuentaCorrienteXCliente_v2.EstadoCuentaCorrienteXCliente());
            Application.Run(new Menu());
        }
    }
}
