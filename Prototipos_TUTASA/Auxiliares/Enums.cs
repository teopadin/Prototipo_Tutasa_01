namespace Prototipos_TUTASA.Auxiliares;

internal enum TiposBultoEnum { S, M, L, XL }

internal enum TipoImposicionEnum { CallCenter, Agencia, CD }

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

internal enum ModalidadEntregaEnum { EntregaDomicilio, EntregaAgencia, EntregaCD }

internal enum EstadoHojaDeRutaEnum { Generada, EnCurso, Recibida, Cumplida, NoCumplida }

internal enum MotivoNoCumplidaRetiroEnum
{
    ClienteAusente,
    EncomiendaNoPreparada,
    DiscrepanciaConGuia,
    Otro
}

internal enum MotivoNoCumplidaDistribucionEnum
{
    DestinatarioAusente,
    DireccionIncorrecta,
    AgenciaCerrada,
    RechazoDeEncomienda
}

internal enum TipoArrendamientoEnum { A, B, C, D }

internal enum TipoCostoExtraEnum { RetiroDomicilio, EntregaDomicilio, EntregaAgencia }

internal enum EstadoCuentaCorrienteEnum { SaldoAdeudado, SaldoAFavor, SinSaldo }
