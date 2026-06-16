using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal enum EstadoGuiaEnum
    {
        Impuesta,
        IncluidaEnHDRRetiro,
        Retirada,
        Admitida,
        PendienteDeDespacho,
        EnTransito,
        EnCDDestino,
        EnDistribucion,
        PendienteDeRetiroEnAgencia,
        PendienteDeRetiroEnCD,
        Entregada,
        Cancelada
    }
}
