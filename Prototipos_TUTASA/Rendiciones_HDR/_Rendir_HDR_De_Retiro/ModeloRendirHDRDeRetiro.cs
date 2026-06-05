using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class ModeloRendirHDRDeRetiro
    {
        private HojaDeRutaRetiro hdrSeleccionada = null;

        private List<TransportistaLocal> transportistas = new List<TransportistaLocal>
        {
            new TransportistaLocal { DniTransportista = 11111111, Nombre = "Juan",    Apellido = "Perez"     },
            new TransportistaLocal { DniTransportista = 22222222, Nombre = "Maria",   Apellido = "Gomez"     },
            new TransportistaLocal { DniTransportista = 33333333, Nombre = "Carlos",  Apellido = "Rodriguez" },
            new TransportistaLocal { DniTransportista = 44444444, Nombre = "Lucia",   Apellido = "Fernandez" },
            new TransportistaLocal { DniTransportista = 55555555, Nombre = "Roberto", Apellido = "Lopez"     }
        };

        private List<HojaDeRutaRetiro> hdrs = new List<HojaDeRutaRetiro>
        {
            new HojaDeRutaRetiro { NroHDR = 2001, DniTransportistaAsignado = 11111111, Remitente = "Empresa ABC S.A.",   Calle = "Av. Corrientes", Altura = 1234, Piso = "1",  CP = "1043", Estado = EstadoHDR.EnCurso  },
            new HojaDeRutaRetiro { NroHDR = 2002, DniTransportistaAsignado = 11111111, Remitente = "Distribuidora XYZ",  Calle = "Lavalle",        Altura = 567,  Piso = "3",  CP = "1047", Estado = EstadoHDR.EnCurso  },
            new HojaDeRutaRetiro { NroHDR = 2003, DniTransportistaAsignado = 11111111, Remitente = "Importadora Sur",    Calle = "Florida",        Altura = 890,  Piso = "PB", CP = "1005", Estado = EstadoHDR.Recibida },
            new HojaDeRutaRetiro { NroHDR = 2004, DniTransportistaAsignado = 22222222, Remitente = "Logistica Norte",    Calle = "Santa Fe",       Altura = 2345, Piso = "2",  CP = "1123", Estado = EstadoHDR.EnCurso  },
            new HojaDeRutaRetiro { NroHDR = 2005, DniTransportistaAsignado = 22222222, Remitente = "Comercial Este",     Calle = "Cordoba",        Altura = 678,  Piso = "4",  CP = "1054", Estado = EstadoHDR.Recibida },
            new HojaDeRutaRetiro { NroHDR = 2006, DniTransportistaAsignado = 33333333, Remitente = "Empresa DEF S.R.L.", Calle = "Rivadavia",      Altura = 4567, Piso = "5",  CP = "1407", Estado = EstadoHDR.EnCurso  },
            new HojaDeRutaRetiro { NroHDR = 2007, DniTransportistaAsignado = 33333333, Remitente = "Distribuidora ABC",  Calle = "Belgrano",       Altura = 1100, Piso = "PB", CP = "1092", Estado = EstadoHDR.EnCurso  },
            new HojaDeRutaRetiro { NroHDR = 2008, DniTransportistaAsignado = 33333333, Remitente = "Importadora Norte",  Calle = "Callao",         Altura = 230,  Piso = "1",  CP = "1022", Estado = EstadoHDR.Recibida },
            new HojaDeRutaRetiro { NroHDR = 2009, DniTransportistaAsignado = 44444444, Remitente = "Empresa GHI S.A.",   Calle = "Pueyrredon",     Altura = 1500, Piso = "3",  CP = "1118", Estado = EstadoHDR.EnCurso  },
            new HojaDeRutaRetiro { NroHDR = 2010, DniTransportistaAsignado = 44444444, Remitente = "Logistica Central",  Calle = "Scalabrini",     Altura = 980,  Piso = "PB", CP = "1414", Estado = EstadoHDR.Recibida },
            // Roberto Lopez (55555555) sin HDR para probar el mensaje
        };

        internal void SetHdrSeleccionada(HojaDeRutaRetiro hdr)
        {
            hdrSeleccionada = hdr;
        }

        internal HojaDeRutaRetiro GetHdrSeleccionada()
        {
            return hdrSeleccionada;
        }

        internal List<TransportistaLocal> ObtenerTransportistas()
        {
            return transportistas;
        }

        internal List<HojaDeRutaRetiro> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HojaDeRutaRetiro>();
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

        internal List<MotivoNoCumplidaRetiro> ObtenerMotivos()
        {
            return new List<MotivoNoCumplidaRetiro>
            {
                MotivoNoCumplidaRetiro.ClienteAusente,
                MotivoNoCumplidaRetiro.EncomiendaNoPreparada,
                MotivoNoCumplidaRetiro.DiscrepanciaConGuia,
                MotivoNoCumplidaRetiro.Otro
            };
        }

        internal bool AplicarEstado(bool cumplida, MotivoNoCumplidaRetiro? motivo)
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

        internal bool RegistrarRendicion(List<HojaDeRutaRetiro> lista)
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