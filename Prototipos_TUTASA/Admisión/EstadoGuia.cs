using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    public enum EstadoGuia
    {
        Impuesta,
        PendienteDeRetiroPorTransportista,
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
