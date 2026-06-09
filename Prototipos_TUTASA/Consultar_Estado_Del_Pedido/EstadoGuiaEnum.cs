using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Consultar_Estado_Del_Pedido
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
