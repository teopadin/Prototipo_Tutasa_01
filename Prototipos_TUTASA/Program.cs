using System;
using System.Windows.Forms;
using Prototipos_TUTASA.EntregaenCD;
using Prototipos_TUTASA.EntregaenCD_v3;
using Prototipos_TUTASA.ImposiciónCallCenter_v2;
using Prototipos_TUTASA.ResultadoCostoVSVentas_v2;

namespace Prototipos_TUTASA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ConsultarEstadoDelPedido_v2.ConsultarEstadoDelPedido());
            Application.Run(new Admisión.Admisión());

            //// !!!!! LEER :) !!!!!
            //// Cada uno debería agregar su Run abajo de los que ya están para probar sus pantallas, cuando corra el programa va a correr primero la primera pantalla y asi,
            //// las van cerrando y se abre la siguiente. Cuando terminemos las ponemos en orden :) 
        }
    }
}