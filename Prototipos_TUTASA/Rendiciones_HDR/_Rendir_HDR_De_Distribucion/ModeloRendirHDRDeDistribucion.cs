using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{

    internal class Rendir_HDR_De_Distribucion_Modelo
    {
        private HojaDeRutaDistribucion hdrSeleccionada = null;

        private List<TransportistaLocal> transportistas = new List<TransportistaLocal>
        {
            new TransportistaLocal { DniTransportista = 11111111, Nombre = "Juan",    Apellido = "Perez"     },
            new TransportistaLocal { DniTransportista = 22222222, Nombre = "Maria",   Apellido = "Gomez"     },
            new TransportistaLocal { DniTransportista = 33333333, Nombre = "Carlos",  Apellido = "Rodriguez" },
            new TransportistaLocal { DniTransportista = 44444444, Nombre = "Lucia",   Apellido = "Fernandez" },
            new TransportistaLocal { DniTransportista = 55555555, Nombre = "Roberto", Apellido = "Lopez"     }
        };

        private List<HojaDeRutaDistribucion> hdrs = new List<HojaDeRutaDistribucion>
        {
            new HojaDeRutaDistribucion { NroHDR = 1001, DniTransportistaAsignado = 11111111, Destinatario = "Ana Garcia",     Calle = "Av. Corrientes", Altura = 1234, Piso = "1",  CP = "1043", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1002, DniTransportistaAsignado = 11111111, Destinatario = "Pedro Suarez",   Calle = "Lavalle",        Altura = 567,  Piso = "3",  CP = "1047", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1003, DniTransportistaAsignado = 11111111, Destinatario = "Laura Martinez", Calle = "Florida",        Altura = 890,  Piso = "PB", CP = "1005", Estado = EstadoHojaDeRutaEnum.Recibida },
            new HojaDeRutaDistribucion { NroHDR = 1004, DniTransportistaAsignado = 22222222, Destinatario = "Diego Ramirez",  Calle = "Santa Fe",       Altura = 2345, Piso = "2",  CP = "1123", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1005, DniTransportistaAsignado = 22222222, Destinatario = "Sofia Torres",   Calle = "Cordoba",        Altura = 678,  Piso = "4",  CP = "1054", Estado = EstadoHojaDeRutaEnum.Recibida },
            new HojaDeRutaDistribucion { NroHDR = 1006, DniTransportistaAsignado = 33333333, Destinatario = "Martin Diaz",    Calle = "Rivadavia",      Altura = 4567, Piso = "5",  CP = "1407", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1007, DniTransportistaAsignado = 33333333, Destinatario = "Carla Romero",   Calle = "Belgrano",       Altura = 1100, Piso = "PB", CP = "1092", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1008, DniTransportistaAsignado = 33333333, Destinatario = "Hugo Pereyra",   Calle = "Callao",         Altura = 230,  Piso = "1",  CP = "1022", Estado = EstadoHojaDeRutaEnum.Recibida },
            new HojaDeRutaDistribucion { NroHDR = 1009, DniTransportistaAsignado = 33333333, Destinatario = "Elena Vidal",    Calle = "Pueyrredon",     Altura = 1500, Piso = "2",  CP = "1118", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1010, DniTransportistaAsignado = 44444444, Destinatario = "Jorge Acosta",   Calle = "Pueyrredon",     Altura = 1500, Piso = "3",  CP = "1118", Estado = EstadoHojaDeRutaEnum.EnCurso  },
            new HojaDeRutaDistribucion { NroHDR = 1011, DniTransportistaAsignado = 44444444, Destinatario = "Paula Mendez",   Calle = "Scalabrini",     Altura = 980,  Piso = "PB", CP = "1414", Estado = EstadoHojaDeRutaEnum.Recibida },
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

        internal List<HojaDeRutaDistribucion> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HojaDeRutaDistribucion>();
            foreach (var hdr in hdrs)
            {
                if (hdr.DniTransportistaAsignado == dniTransportista &&
                    (hdr.Estado == EstadoHojaDeRutaEnum.EnCurso || hdr.Estado == EstadoHojaDeRutaEnum.Recibida))
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
                hdrSeleccionada.Estado = EstadoHojaDeRutaEnum.Cumplida;
                hdrSeleccionada.MotivoNoCumplida = null;
            }
            else
            {
                hdrSeleccionada.Estado = EstadoHojaDeRutaEnum.NoCumplida;
                hdrSeleccionada.MotivoNoCumplida = motivo;
            }
            return true;
        }

        internal bool RegistrarRendicion(List<HojaDeRutaDistribucion> lista)
        {
            foreach (var hdr in lista)
            {
                if (hdr.Estado != EstadoHojaDeRutaEnum.Cumplida && hdr.Estado != EstadoHojaDeRutaEnum.NoCumplida)
                {
                    MessageBox.Show("Debe aplicar un estado a todas las HDR antes de registrar la rendicion.");
                    return false;
                }
            }
            return true;
        }
    }
}