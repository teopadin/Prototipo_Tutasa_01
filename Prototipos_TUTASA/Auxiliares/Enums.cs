using System.Text.Json.Serialization;

namespace Prototipos_TUTASA.Auxiliares;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum TiposBultoEnum { S, M, L, XL }

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum TipoImposicionEnum { CallCenter, Agencia, CD }

[JsonConverter(typeof(JsonStringEnumConverter))]
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

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ModalidadEntregaEnum { EntregaDomicilio, EntregaAgencia, EntregaCD }

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EstadoHojaDeRutaEnum { Generada, EnCurso, Recibida, Cumplida, NoCumplida }

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum MotivoNoCumplidaRetiroEnum
{
    ClienteAusente,
    EncomiendaNoPreparada,
    DiscrepanciaConGuia,
    Otro
}

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum MotivoNoCumplidaDistribucionEnum
{
    DestinatarioAusente,
    DireccionIncorrecta,
    AgenciaCerrada,
    RechazoDeEncomienda
}

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum TipoArrendamientoEnum { A, B, C, D }

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum TipoCostoExtraEnum { RetiroDomicilio, EntregaDomicilio, EntregaAgencia }

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EstadoCuentaCorrienteEnum { SaldoAdeudado, SaldoAFavor, SinSaldo }
