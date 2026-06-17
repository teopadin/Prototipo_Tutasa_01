using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Prototipos_TUTASA.Almacenes;
using EstadoGuiaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ModeloEntregaAgencia
    {
        public Agencia AgenciaActual { get; }
        private readonly List<Guia> guias;
        private readonly List<GuiaEntidad> guiasEntidad;
        private Guia guiaSeleccionada = new Guia();
        private GuiaEntidad guiaEntidadSeleccionada = new GuiaEntidad();

        public bool HayGuiaSeleccionada { get; private set; }

        public ModeloEntregaAgencia()
        {
            AgenciaEntidad agenciaEntidadActual = AgenciaAlmacen.Agencias
                .FirstOrDefault(a => a.idAgencia == Program.CodigoAgenciaActual);

            if (agenciaEntidadActual == null && AgenciaAlmacen.Agencias.Count > 0)
            {
                agenciaEntidadActual = AgenciaAlmacen.Agencias[0];
            }

            AgenciaActual = agenciaEntidadActual != null
                ? new Agencia
                {
                    idAgencia = agenciaEntidadActual.idAgencia,
                    razonSocial = agenciaEntidadActual.razonSocial
                }
                : null;

            guias = new List<Guia>();
            guiasEntidad = new List<GuiaEntidad>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.Guias)
            {
                guiasEntidad.Add(guiaEntidad);
                guias.Add(ConvertirGuia(guiaEntidad));
            }
        }

        public bool BuscarGuia(string nroGuiaTexto, out Guia guiaEncontrada, out string mensaje)
        {
            LimpiarSeleccion();
            guiaEncontrada = null;
            mensaje = string.Empty;

            string nroGuia = nroGuiaTexto.Trim();
            if (string.IsNullOrWhiteSpace(nroGuia))
            {
                mensaje = "Debe ingresar un número de guía.";
                return false;
            }

            if (!EsFormatoGuiaValido(nroGuia))
            {
                mensaje = "El número de guía debe tener un formato válido, por ejemplo CD02-0002, AG01-0001 o A001-0001.";
                return false;
            }

            if (!BuscarGuiaDisponible(nroGuia, out Guia guia, out GuiaEntidad guiaEntidad))
            {
                mensaje = "No se encontró una guía con el número ingresado.";
                return false;
            }

            if (guia.Destinatario == null)
            {
                mensaje = "La guía no tiene datos completos para registrar la entrega.";
                return false;
            }

            if (AgenciaActual == null || guia.idAgenciaDestino != AgenciaActual.idAgencia)
            {
                mensaje = "La guía ingresada no corresponde a la agencia actual.";
                return false;
            }

            if (guia.estado != EstadoGuiaEnum.PendienteDeRetiroEnAgencia)
            {
                mensaje = "La guía no se encuentra pendiente de retiro en agencia.";
                return false;
            }

            guiaSeleccionada = guia;
            guiaEntidadSeleccionada = guiaEntidad;
            HayGuiaSeleccionada = true;
            guiaEncontrada = guiaSeleccionada;
            return true;
        }

        public bool RegistrarEntrega(string nroGuiaTexto, string nombreTexto, string apellidoTexto, string dniTexto, bool dniVerificado, out string mensaje)
        {
            mensaje = string.Empty;

            if (!HayGuiaSeleccionada)
            {
                mensaje = "Debe buscar una guía válida antes de registrar la entrega.";
                return false;
            }

            if (!string.Equals(guiaSeleccionada.NroGuia, nroGuiaTexto.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                mensaje = "Debe volver a buscar la guía antes de registrar la entrega.";
                return false;
            }

            string nombre = nombreTexto.Trim();
            string apellido = apellidoTexto.Trim();
            string dniIngresado = dniTexto.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dniIngresado))
            {
                mensaje = "Debe completar nombre, apellido y DNI de quien retira.";
                return false;
            }

            if (!EsDniValido(dniIngresado, out int dni))
            {
                mensaje = "El DNI ingresado no tiene un formato válido.";
                return false;
            }

            if (!dniVerificado)
            {
                mensaje = "Debe confirmar que el documento de identidad fue presentado y verificado.";
                return false;
            }

            if (!CoincideDestinatario(nombre, apellido, dni))
            {
                mensaje = "Los datos de quien retira no coinciden con el destinatario de la guía.";
                return false;
            }

            RegistrarEntregaInterna();
            return true;
        }

        public void LimpiarSeleccion()
        {
            guiaSeleccionada = new Guia();
            guiaEntidadSeleccionada = new GuiaEntidad();
            HayGuiaSeleccionada = false;
        }

        private bool BuscarGuiaDisponible(string nroGuia, out Guia guiaEncontrada, out GuiaEntidad guiaEntidadEncontrada)
        {
            for (int i = 0; i < guias.Count; i++)
            {
                Guia guia = guias[i];
                if (string.Equals(guia.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase))
                {
                    guiaEncontrada = guia;
                    guiaEntidadEncontrada = guiasEntidad[i];
                    return true;
                }
            }

            guiaEncontrada = new Guia();
            guiaEntidadEncontrada = new GuiaEntidad();
            return false;
        }

        private bool CoincideDestinatario(string nombre, string apellido, int dni)
        {
            return guiaSeleccionada.Destinatario.Dni == dni
                && CoincideTexto(guiaSeleccionada.Destinatario.nombre, nombre)
                && CoincideTexto(guiaSeleccionada.Destinatario.apellido, apellido);
        }

        private void RegistrarEntregaInterna()
        {
            DateTime fechaEntrega = DateTime.Now;

            guiaSeleccionada.estado = EstadoGuiaEnum.Entregada;

            guiaEntidadSeleccionada.estado = EstadoGuiaAlmacen.Entregada;
            guiaEntidadSeleccionada.Historial.Add(new HistorialEstadoGuia
            {
                FechaCambio = fechaEntrega,
                Estado = EstadoGuiaAlmacen.Entregada,
                Donde = AgenciaActual?.razonSocial ?? string.Empty
            });

            GuiaAlmacen.Guardar();
        }

        private static Guia ConvertirGuia(GuiaEntidad guiaEntidad)
        {
            return new Guia
            {
                NroGuia = guiaEntidad.NroGuia,
                estado = ConvertirEstado(guiaEntidad.estado),
                idAgenciaDestino = guiaEntidad.idAgenciaDestino,
                Destinatario = guiaEntidad.Destinatario == null
                    ? null
                    : new DestinatarioGuia
                    {
                        nombre = guiaEntidad.Destinatario.nombre,
                        apellido = guiaEntidad.Destinatario.apellido,
                        Dni = guiaEntidad.Destinatario.Dni
                    }
            };
        }

        private static EstadoGuiaEnum ConvertirEstado(EstadoGuiaAlmacen estado)
        {
            switch (estado)
            {
                case EstadoGuiaAlmacen.PendienteDeRetiroEnAgencia:
                    return EstadoGuiaEnum.PendienteDeRetiroEnAgencia;
                case EstadoGuiaAlmacen.Entregada:
                    return EstadoGuiaEnum.Entregada;
                default:
                    return EstadoGuiaEnum.PendienteDeRetiroEnAgencia;
            }
        }

        private static bool CoincideTexto(string textoRegistrado, string textoIngresado)
        {
            return CultureInfo.CurrentCulture.CompareInfo.Compare(
                textoRegistrado.Trim(),
                textoIngresado.Trim(),
                CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0;
        }

        private static bool EsDniValido(string dniTexto, out int dni)
        {
            dni = 0;

            if (dniTexto.Length < 7 || dniTexto.Length > 8)
            {
                return false;
            }

            foreach (char caracter in dniTexto)
            {
                if (!char.IsDigit(caracter))
                {
                    return false;
                }
            }

            return int.TryParse(dniTexto, out dni) && dni > 0;
        }

        private static bool EsFormatoGuiaValido(string nroGuia)
        {
            if (nroGuia.Length != 9 || nroGuia[4] != '-')
            {
                return false;
            }

            int cantidadLetras = 0;
            while (cantidadLetras < 4 && EsLetraAscii(nroGuia[cantidadLetras]))
            {
                cantidadLetras++;
            }

            if (cantidadLetras < 1 || cantidadLetras > 2)
            {
                return false;
            }

            for (int i = cantidadLetras; i < 4; i++)
            {
                if (!char.IsDigit(nroGuia[i]))
                {
                    return false;
                }
            }

            for (int i = 5; i < nroGuia.Length; i++)
            {
                if (!char.IsDigit(nroGuia[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool EsLetraAscii(char caracter)
        {
            return (caracter >= 'A' && caracter <= 'Z')
                || (caracter >= 'a' && caracter <= 'z');
        }
    }
}
