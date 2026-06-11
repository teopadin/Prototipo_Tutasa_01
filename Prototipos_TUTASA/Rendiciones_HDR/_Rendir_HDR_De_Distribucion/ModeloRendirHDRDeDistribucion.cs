using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class Rendir_HDR_De_Distribucion_Modelo
    {
        private HojaDeRutaDistribucion hdrSeleccionada = null;

        private List<TransportistaLocal> transportistas = new List<TransportistaLocal>
    {
        new TransportistaLocal { dniTransportista = 11111111, nombre = "Juan",    apellido = "Perez"     },
        new TransportistaLocal { dniTransportista = 22222222, nombre = "Maria",   apellido = "Gomez"     },
        new TransportistaLocal { dniTransportista = 33333333, nombre = "Carlos",  apellido = "Rodriguez" },
        new TransportistaLocal { dniTransportista = 44444444, nombre = "Lucia",   apellido = "Fernandez" },
        new TransportistaLocal { dniTransportista = 55555555, nombre = "Roberto", apellido = "Lopez"     }
    };

        // Almacén de guías — todas en EnDistribucion porque están en una HDR de distribución
        // Mezcla de modalidades para probar las distintas reglas
        private List<Guia> guias = new List<Guia>
    {
        new Guia { NroGuia = "G-D-001", estado = EstadoGuiaEnum.EnDistribucion,           modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio },
        new Guia { NroGuia = "G-D-002", estado = EstadoGuiaEnum.PendienteDeRetiroEnCD,    modalidadEntrega = ModalidadEntregaEnum.EntregaCD        },
        new Guia { NroGuia = "G-D-003", estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia, modalidadEntrega = ModalidadEntregaEnum.EntregaAgencia },
        new Guia { NroGuia = "G-D-004", estado = EstadoGuiaEnum.EnDistribucion,           modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio },
        new Guia { NroGuia = "G-D-005", estado = EstadoGuiaEnum.EnDistribucion,           modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio },
        new Guia { NroGuia = "G-D-006", estado = EstadoGuiaEnum.PendienteDeRetiroEnCD,    modalidadEntrega = ModalidadEntregaEnum.EntregaCD        },
        new Guia { NroGuia = "G-D-007", estado = EstadoGuiaEnum.EnDistribucion,           modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio },
        new Guia { NroGuia = "G-D-008", estado = EstadoGuiaEnum.PendienteDeRetiroEnAgencia, modalidadEntrega = ModalidadEntregaEnum.EntregaAgencia },
        new Guia { NroGuia = "G-D-009", estado = EstadoGuiaEnum.EnDistribucion,           modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio },
        new Guia { NroGuia = "G-D-010", estado = EstadoGuiaEnum.EnDistribucion,           modalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio }
    };

        private List<HojaDeRutaDistribucion> hdrs = new List<HojaDeRutaDistribucion>
    {
        new HojaDeRutaDistribucion { NroHDR = 1001, dniTransportistaAsignado = 11111111, Destinatario = "Juan Garcia",      Calle = "Av. Corrientes", Altura = 1234, Piso = "1",  CodigoPostal = "1043", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-001" } },
        new HojaDeRutaDistribucion { NroHDR = 1002, dniTransportistaAsignado = 11111111, Destinatario = "Maria Lopez",      Calle = "Lavalle",        Altura = 567,  Piso = "3",  CodigoPostal = "1047", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-002" } },
        new HojaDeRutaDistribucion { NroHDR = 1003, dniTransportistaAsignado = 11111111, Destinatario = "Pedro Ramirez",    Calle = "Florida",        Altura = 890,  Piso = "PB", CodigoPostal = "1005", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-D-003" } },
        new HojaDeRutaDistribucion { NroHDR = 1004, dniTransportistaAsignado = 22222222, Destinatario = "Ana Martinez",     Calle = "Santa Fe",       Altura = 2345, Piso = "2",  CodigoPostal = "1123", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-004" } },
        new HojaDeRutaDistribucion { NroHDR = 1005, dniTransportistaAsignado = 22222222, Destinatario = "Carlos Sosa",      Calle = "Cordoba",        Altura = 678,  Piso = "4",  CodigoPostal = "1054", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-D-005" } },
        new HojaDeRutaDistribucion { NroHDR = 1006, dniTransportistaAsignado = 33333333, Destinatario = "Laura Diaz",       Calle = "Rivadavia",      Altura = 4567, Piso = "5",  CodigoPostal = "1407", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-006" } },
        new HojaDeRutaDistribucion { NroHDR = 1007, dniTransportistaAsignado = 33333333, Destinatario = "Roberto Gomez",    Calle = "Belgrano",       Altura = 1100, Piso = "PB", CodigoPostal = "1092", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-007" } },
        new HojaDeRutaDistribucion { NroHDR = 1008, dniTransportistaAsignado = 33333333, Destinatario = "Sofia Fernandez",  Calle = "Callao",         Altura = 230,  Piso = "1",  CodigoPostal = "1022", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-D-008" } },
        new HojaDeRutaDistribucion { NroHDR = 1009, dniTransportistaAsignado = 33333333, Destinatario = "Diego Castro",     Calle = "Pueyrredon",     Altura = 1500, Piso = "3",  CodigoPostal = "1118", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-009" } },
        new HojaDeRutaDistribucion { NroHDR = 1010, dniTransportistaAsignado = 44444444, Destinatario = "Patricia Vega",    Calle = "Scalabrini",     Altura = 980,  Piso = "PB", CodigoPostal = "1414", estado = EstadoHojaDeRutaEnum.EnCurso,  DetalleGuias = new List<string> { "G-D-010" } }
    };

        internal void SetHdrSeleccionada(HojaDeRutaDistribucion hdr)
        {
            hdrSeleccionada = hdr;
        }

        internal HojaDeRutaDistribucion GetHdrSeleccionada()
        {
            return hdrSeleccionada;
        }

        internal List<TransportistaLocal> ObtenerTransportistas()
        {
            return transportistas;
        }

        internal TransportistaLocal BuscarTransportista(int dni)
        {
            foreach (TransportistaLocal t in transportistas)
            {
                if (t.dniTransportista == dni) return t;
            }
            return null;
        }

        internal HojaDeRutaDistribucion BuscarHDR(int nroHDR)
        {
            foreach (HojaDeRutaDistribucion hdr in hdrs)
            {
                if (hdr.NroHDR == nroHDR) return hdr;
            }
            return null;
        }

        internal Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia g in guias)
            {
                if (g.NroGuia == nroGuia) return g;
            }
            return null;
        }

        internal List<HojaDeRutaDistribucion> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HojaDeRutaDistribucion>();
            foreach (var hdr in hdrs)
            {
                if (hdr.dniTransportistaAsignado == dniTransportista &&
                    (hdr.estado == EstadoHojaDeRutaEnum.EnCurso || hdr.estado == EstadoHojaDeRutaEnum.Recibida))
                {
                    resultado.Add(hdr);
                }
            }
            return resultado;
        }

        internal List<MotivoNoCumplidaDistribucionEnum> ObtenerMotivos()
        {
            return new List<MotivoNoCumplidaDistribucionEnum>
        {
            MotivoNoCumplidaDistribucionEnum.DestinatarioAusente,
            MotivoNoCumplidaDistribucionEnum.DireccionIncorrecta,
            MotivoNoCumplidaDistribucionEnum.AgenciaCerrada,
            MotivoNoCumplidaDistribucionEnum.RechazoDeEncomienda
        };
        }

        internal bool AplicarEstado(bool cumplida, MotivoNoCumplidaDistribucionEnum? motivo)
        {
            if (!cumplida && motivo == null)
            {
                MessageBox.Show("Debe seleccionar un motivo para marcar la HDR como No Cumplida.");
                return false;
            }

            if (cumplida)
            {
                hdrSeleccionada.estado = EstadoHojaDeRutaEnum.Cumplida;
                hdrSeleccionada.motivoNoCumplida = null;
            }
            else
            {
                hdrSeleccionada.estado = EstadoHojaDeRutaEnum.NoCumplida;
                hdrSeleccionada.motivoNoCumplida = motivo;
            }
            return true;
        }

        internal bool RegistrarRendicion(List<HojaDeRutaDistribucion> lista)
        {
            foreach (var hdr in lista)
            {
                if (hdr.estado != EstadoHojaDeRutaEnum.Cumplida && hdr.estado != EstadoHojaDeRutaEnum.NoCumplida)
                {
                    MessageBox.Show("Debe aplicar un estado a todas las HDR antes de registrar la rendicion.");
                    return false;
                }
            }

            // Cambiar el estado de las guías según el estado final de la HDR y la modalidad de cada guía
            foreach (var hdr in lista)
            {
                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia g = BuscarGuia(nroGuia);
                    if (g == null) continue;

                    // Solo las guías con modalidad EntregaDomicilio cambian de estado.
                    // Las de EntregaCD y EntregaAgencia ya estaban en su estado final (PendienteDeRetiroEnCD / PendienteDeRetiroEnAgencia) y no cambian.
                    if (g.modalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
                    {
                        if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida)
                        {
                            g.estado = EstadoGuiaEnum.Entregada;
                        }
                        else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida)
                        {
                            g.estado = EstadoGuiaEnum.EnCDDestino;
                        }
                    }
                }
            }

            return true;
        }
    }
}