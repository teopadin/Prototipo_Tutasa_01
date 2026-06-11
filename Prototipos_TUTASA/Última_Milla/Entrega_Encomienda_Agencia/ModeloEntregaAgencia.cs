using System;
using System.Collections.Generic;
using System.Globalization;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_Agencia
{
    public class ModeloEntregaAgencia
    {
        public Agencia AgenciaActual { get; }
        private readonly List<Guia> guias;

        public ModeloEntregaAgencia()
        {
            var agenciaCapital = new Agencia { idAgencia = 1, razonSocial = "Capital y GBA" };
            var agenciaCentro = new Agencia { idAgencia = 2, razonSocial = "Centro - Córdoba" };

            AgenciaActual = agenciaCapital;

            guias = new List<Guia>
            {
                new Guia
                {
                    NroGuia = "AG01-0001",
                    estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    idAgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioGuia { nombre = "Ana", apellido = "Pérez", Dni = 40123456 }
                },
                new Guia
                {
                    NroGuia = "AG01-0002",
                    estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    idAgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioGuia { nombre = "Juan", apellido = "Rodríguez", Dni = 41234567 }
                },
                new Guia
                {
                    NroGuia = "AG01-0003",
                    estado = EstadoGuiaEnum.Entregada,
                    idAgenciaDestino = agenciaCapital,
                    Destinatario = new DestinatarioGuia { nombre = "María", apellido = "González", Dni = 42345678 }
                },
                new Guia
                {
                    NroGuia = "AG02-0001",
                    estado  = EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                    idAgenciaDestino = agenciaCentro,
                    Destinatario = new DestinatarioGuia { nombre = "Carlos", apellido = "López", Dni = 43567890 }
                }
            };
        }

        public bool BuscarGuia(string nroGuiaTexto, out Guia guiaEncontrada, out string mensaje)
        {
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

            guiaEncontrada = guias.Find(g => string.Equals(g.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase));

            if (guiaEncontrada == null)
            {
                mensaje = "No se encontró una guía con el número ingresado.";
                return false;
            }

            if (guiaEncontrada.idAgenciaDestino == null || guiaEncontrada.Destinatario == null)
            {
                mensaje = "La guía no tiene datos completos para registrar la entrega.";
                return false;
            }

            if (guiaEncontrada.idAgenciaDestino.razonSocial != AgenciaActual.razonSocial)
            {
                mensaje = "La guía ingresada no corresponde a la agencia actual.";
                return false;
            }

            if (guiaEncontrada.estado != EstadoGuiaEnum.PendienteDeRetiroEnAgencia)
            {
                mensaje = "La guía no se encuentra pendiente de retiro en agencia.";
                return false;
            }

            return true;
        }

        public bool RegistrarEntrega(string nroGuiaTexto, string nombreTexto, string apellidoTexto, string dniTexto, bool dniVerificado, out string mensaje)
        {
            mensaje = string.Empty;

            if (!BuscarGuia(nroGuiaTexto, out Guia guia, out string mensajeBusqueda))
            {
                mensaje = mensajeBusqueda;
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

            if (!CoincideDestinatario(guia, nombre, apellido, dni))
            {
                mensaje = "Los datos de quien retira no coinciden con el destinatario de la guía.";
                return false;
            }

            RegistrarEntregaInterna(guia);
            return true;
        }

        private void RegistrarEntregaInterna(Guia guia)
        {
            guia.estado = EstadoGuiaEnum.Entregada;
        }

        private static bool CoincideDestinatario(Guia guia, string nombre, string apellido, int dni)
        {
            return guia.Destinatario.Dni == dni
                && CoincideTexto(guia.Destinatario.nombre, nombre)
                && CoincideTexto(guia.Destinatario.apellido, apellido);
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
