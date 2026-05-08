using System;
using System.Windows.Forms;
using Prototipos_TUTASA.EntregaenCD;
using Prototipos_TUTASA.EntregaenCD_v3;
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
            Application.Run(new resultadocostosvsventas());
        }
    }
}