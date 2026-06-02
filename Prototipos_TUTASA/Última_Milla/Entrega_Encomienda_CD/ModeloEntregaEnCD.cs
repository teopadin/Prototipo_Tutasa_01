using System;
using System.Collections.Generic;
using System.Globalization;

namespace Prototipos_TUTASA.Última_Milla.Entrega_Encomienda_CD
{
    internal class ModeloEntregaEnCD
    {
        private readonly CentroDistribucion cdActual;
        private readonly List<Guia> guias;
        private readonly List<ReciboEntregaCD> recibos = new List<ReciboEntregaCD>();
        private Guia guiaSeleccionada = new Guia();

        public bool HayGuiaSeleccionada { get; private set; }
        public string NroGuiaSeleccionada => HayGuiaSeleccionada ? guiaSeleccionada.NroGuia : string.Empty;
        public string NombreDestinatarioSeleccionado => HayGuiaSeleccionada ? guiaSeleccionada.Destinatario.Nombre : string.Empty;
        public string ApellidoDestinatarioSeleccionado => HayGuiaSeleccionada ? guiaSeleccionada.Destinatario.Apellido : string.Empty;
        public string DniDestinatarioSeleccionado => HayGuiaSeleccionada ? guiaSeleccionada.Destinatario.Dni.ToString() : string.Empty;

        public ModeloEntregaEnCD()
        {
            var cdCapital = new CentroDistribucion { IdCD = 1, Nombre = "Capital y GBA" };
            var cdCentro = new CentroDistribucion { IdCD = 2, Nombre = "Centro - Córdoba" };

            cdActual = cdCapital;

            guias = new List<Guia>
            {
                new Guia
                {
                    NroGuia = "CD02-0002",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnCD,
                    IdCDDestino = cdCapital.IdCD,
                    Destinatario = new DestinatarioGuia { Nombre = "Ana", Apellido = "Pérez", Dni = 40123456 }
                },
                new Guia
                {
                    NroGuia = "CD01-0007",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnCD,
                    IdCDDestino = cdCapital.IdCD,
                    Destinatario = new DestinatarioGuia { Nombre = "Juan", Apellido = "Rodríguez", Dni = 41234567 }
                },
                new Guia
                {
                    NroGuia = "CD03-0001",
                    Estado = EstadoGuiaEnum.EnDistribucion,
                    IdCDDestino = cdCapital.IdCD,
                    Destinatario = new DestinatarioGuia { Nombre = "María", Apellido = "González", Dni = 42345678 }
                },
                new Guia
                {
                    NroGuia = "CD02-0009",
                    Estado = EstadoGuiaEnum.PendienteDeRetiroEnCD,
                    IdCDDestino = cdCentro.IdCD,
                    Destinatario = new DestinatarioGuia { Nombre = "Carlos", Apellido = "López", Dni = 43567890 }
                }
            };
        }

        public bool BuscarGuia(string nroGuiaTexto, out string mensaje)
        {
            LimpiarSeleccion();

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

            if (!BuscarGuiaDisponible(nroGuia, out Guia guia))
            {
                mensaje = "No se encontró una guía con el número ingresado.";
                return false;
            }

            if (guia.IdCDDestino <= 0 || guia.Destinatario == null)
            {
                mensaje = "La guía no tiene datos completos para registrar la entrega.";
                return false;
            }

            if (guia.IdCDDestino != cdActual.IdCD)
            {
                mensaje = "La guía ingresada no corresponde al Centro de Distribución actual.";
                return false;
            }

            if (guia.Estado != EstadoGuiaEnum.PendienteDeRetiroEnCD)
            {
                mensaje = "La guía no se encuentra pendiente de retiro en CD.";
                return false;
            }

            guiaSeleccionada = guia;
            HayGuiaSeleccionada = true;
            mensaje = string.Empty;
            return true;
        }

        public bool RegistrarEntrega(string nroGuiaTexto, string nombreTexto, string apellidoTexto, string dniTexto, bool dniVerificado, out string mensaje, out int nroRecibo)
        {
            mensaje = string.Empty;
            nroRecibo = 0;

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

            ReciboEntregaCD recibo = RegistrarEntregaInterna(nombre, apellido, dni);
            nroRecibo = recibo.NroRecibo;
            return true;
        }

        public void LimpiarSeleccion()
        {
            guiaSeleccionada = new Guia();
            HayGuiaSeleccionada = false;
        }

        private bool BuscarGuiaDisponible(string nroGuia, out Guia guiaEncontrada)
        {
            foreach (Guia guia in guias)
            {
                if (string.Equals(guia.NroGuia, nroGuia, StringComparison.OrdinalIgnoreCase))
                {
                    guiaEncontrada = guia;
                    return true;
                }
            }

            guiaEncontrada = new Guia();
            return false;
        }

        private bool CoincideDestinatario(string nombre, string apellido, int dni)
        {
            return guiaSeleccionada.Destinatario.Dni == dni
                && CoincideTexto(guiaSeleccionada.Destinatario.Nombre, nombre)
                && CoincideTexto(guiaSeleccionada.Destinatario.Apellido, apellido);
        }

        private ReciboEntregaCD RegistrarEntregaInterna(string nombre, string apellido, int dni)
        {
            DateTime fechaEntrega = DateTime.Now;

            var recibo = new ReciboEntregaCD
            {
                NroRecibo = recibos.Count + 1,
                NroGuia = guiaSeleccionada.NroGuia,
                FechaEntrega = fechaEntrega,
                NombreRetira = nombre,
                ApellidoRetira = apellido,
                DniRetira = dni
            };

            guiaSeleccionada.Estado = EstadoGuiaEnum.Entregada;
            guiaSeleccionada.FechaEntrega = fechaEntrega;
            guiaSeleccionada.Historial.Add(new HistorialEstadoGuia
            {
                FechaCambio = fechaEntrega,
                Estado = guiaSeleccionada.Estado
            });
            recibos.Add(recibo);
            return recibo;
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
