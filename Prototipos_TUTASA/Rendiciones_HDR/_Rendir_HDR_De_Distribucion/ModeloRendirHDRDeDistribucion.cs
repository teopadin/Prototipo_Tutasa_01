using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{

    internal class Rendir_HDR_De_Distribucion_Modelo
    {
        private HDRDistribucion hdrSeleccionada = null;

        private List<TransportistaLocal> transportistas = new List<TransportistaLocal>
        {
            new TransportistaLocal { DniTransportista = 11111111, Nombre = "Juan",    Apellido = "Perez"     },
            new TransportistaLocal { DniTransportista = 22222222, Nombre = "Maria",   Apellido = "Gomez"     },
            new TransportistaLocal { DniTransportista = 33333333, Nombre = "Carlos",  Apellido = "Rodriguez" },
            new TransportistaLocal { DniTransportista = 44444444, Nombre = "Lucia",   Apellido = "Fernandez" },
            new TransportistaLocal { DniTransportista = 55555555, Nombre = "Roberto", Apellido = "Lopez"     }
        };

        private List<HDRDistribucion> hdrs = new List<HDRDistribucion>
        {
            new HDRDistribucion
            {
                NroHDR = 1001, DniTransportistaAsignado = 11111111, Estado = EstadoHDR.EnCurso,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Ana Garcia",     Calle = "Av. Corrientes", Altura = 1234, CP = "1043" },
                    new DetalleGuiasADistribuir { Destinatario = "Pedro Suarez",   Calle = "Lavalle",        Altura = 567,  CP = "1047" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1002, DniTransportistaAsignado = 11111111, Estado = EstadoHDR.EnCurso,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Laura Martinez", Calle = "Florida",    Altura = 890,  CP = "1005" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1003, DniTransportistaAsignado = 11111111, Estado = EstadoHDR.Recibida,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Diego Ramirez",  Calle = "Santa Fe",   Altura = 2345, CP = "1123" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1004, DniTransportistaAsignado = 22222222, Estado = EstadoHDR.EnCurso,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Sofia Torres",   Calle = "Cordoba",    Altura = 678,  CP = "1054" },
                    new DetalleGuiasADistribuir { Destinatario = "Martin Diaz",    Calle = "Rivadavia",  Altura = 4567, CP = "1407" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1005, DniTransportistaAsignado = 22222222, Estado = EstadoHDR.Recibida,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Carla Romero",   Calle = "Belgrano",   Altura = 1100, CP = "1092" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1006, DniTransportistaAsignado = 33333333, Estado = EstadoHDR.EnCurso,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Hugo Pereyra",   Calle = "Callao",     Altura = 230,  CP = "1022" },
                    new DetalleGuiasADistribuir { Destinatario = "Elena Vidal",    Calle = "Pueyrredon", Altura = 1500, CP = "1118" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1007, DniTransportistaAsignado = 33333333, Estado = EstadoHDR.EnCurso,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Jorge Acosta",   Calle = "Pueyrredon", Altura = 1500, CP = "1118" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1008, DniTransportistaAsignado = 44444444, Estado = EstadoHDR.EnCurso,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Paula Mendez",   Calle = "Scalabrini", Altura = 980,  CP = "1414" }
                }
            },
            new HDRDistribucion
            {
                NroHDR = 1009, DniTransportistaAsignado = 44444444, Estado = EstadoHDR.Recibida,
                DetalleGuias = new List<DetalleGuiasADistribuir>
                {
                    new DetalleGuiasADistribuir { Destinatario = "Lucia Peralta",  Calle = "Callao",     Altura = 450,  CP = "1022" }
                }
            },
            // Roberto Lopez (55555555) sin HDR para probar el mensaje
        };

        internal void SetHdrSeleccionada(HDRDistribucion hdr)
        {
            hdrSeleccionada = hdr;
        }

        internal HDRDistribucion GetHdrSeleccionada()
        {
            return hdrSeleccionada;
        }

        internal List<TransportistaLocal> ObtenerTransportistas()
        {
            return transportistas;
        }

        internal List<HDRDistribucion> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HDRDistribucion>();
            foreach (var hdr in hdrs)
            {
                if (hdr.DniTransportistaAsignado == dniTransportista &&
                    (hdr.Estado == EstadoHDR.EnCurso || hdr.Estado == EstadoHDR.Recibida))
                {
                    resultado.Add(hdr);
                }
            }
            return resultado;
        }

        internal List<MotivoNoCumplidaDistribucion> ObtenerMotivos()
        {
            return new List<MotivoNoCumplidaDistribucion>
            {
                MotivoNoCumplidaDistribucion.DestinatarioAusente,
                MotivoNoCumplidaDistribucion.DireccionIncorrecta,
                MotivoNoCumplidaDistribucion.AgenciaCerrada,
                MotivoNoCumplidaDistribucion.RechazoDeEncomienda
            };
        }

        internal bool AplicarEstado(bool cumplida, MotivoNoCumplidaDistribucion? motivo)
        {
            if (!cumplida && motivo == null)
            {
                MessageBox.Show("Debe seleccionar un motivo para marcar la HDR como No Cumplida.");
                return false;
            }

            if (cumplida)
            {
                hdrSeleccionada.Estado = EstadoHDR.Cumplida;
                hdrSeleccionada.MotivoNoCumplida = null;
            }
            else
            {
                hdrSeleccionada.Estado = EstadoHDR.NoCumplida;
                hdrSeleccionada.MotivoNoCumplida = motivo;
            }
            return true;
        }

        internal bool RegistrarRendicion(List<HDRDistribucion> lista)
        {
            foreach (var hdr in lista)
            {
                if (hdr.Estado != EstadoHDR.Cumplida && hdr.Estado != EstadoHDR.NoCumplida)
                {
                    MessageBox.Show("Debe aplicar un estado a todas las HDR antes de registrar la rendicion.");
                    return false;
                }
            }
            return true;
        }
    }
}