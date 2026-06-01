using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class ModeloRendirHDRDeRetiro
    {
        // DATOS DE PRUEBA (despues se reemplazan por almacenes)
        private HDRRetiro hdrSeleccionada = null;

        private List<TransportistaLocal> transportistas = new List<TransportistaLocal>
        {
            new TransportistaLocal { DniTransportista = 11111111, Nombre = "Juan",    Apellido = "Perez"     },
            new TransportistaLocal { DniTransportista = 22222222, Nombre = "Maria",   Apellido = "Gomez"     },
            new TransportistaLocal { DniTransportista = 33333333, Nombre = "Carlos",  Apellido = "Rodriguez" },
            new TransportistaLocal { DniTransportista = 44444444, Nombre = "Lucia",   Apellido = "Fernandez" },
            new TransportistaLocal { DniTransportista = 55555555, Nombre = "Roberto", Apellido = "Lopez"     }
        };

        private List<HDRRetiro> hdrs = new List<HDRRetiro>
        {
            new HDRRetiro
            {
                NroHDR = 2001, DniTransportistaAsignado = 11111111, Estado = EstadoHDR.EnCurso,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Empresa ABC S.A.",  Calle = "Av. Corrientes", Altura = 1234, CP = "1043" },
                    new DetalleGuiasARetirar { Remitente = "Distribuidora XYZ", Calle = "Lavalle",        Altura = 567,  CP = "1047" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2002, DniTransportistaAsignado = 11111111, Estado = EstadoHDR.EnCurso,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Importadora Sur",   Calle = "Florida",    Altura = 890,  CP = "1005" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2003, DniTransportistaAsignado = 11111111, Estado = EstadoHDR.Recibida,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Logistica Norte",   Calle = "Santa Fe",   Altura = 2345, CP = "1123" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2004, DniTransportistaAsignado = 22222222, Estado = EstadoHDR.EnCurso,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Comercial Este",    Calle = "Cordoba",    Altura = 678,  CP = "1054" },
                    new DetalleGuiasARetirar { Remitente = "Empresa DEF S.R.L.", Calle = "Rivadavia", Altura = 4567, CP = "1407" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2005, DniTransportistaAsignado = 22222222, Estado = EstadoHDR.Recibida,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Distribuidora ABC", Calle = "Belgrano",   Altura = 1100, CP = "1092" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2006, DniTransportistaAsignado = 33333333, Estado = EstadoHDR.EnCurso,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Importadora Norte", Calle = "Callao",     Altura = 230,  CP = "1022" },
                    new DetalleGuiasARetirar { Remitente = "Comercial Sur",     Calle = "Pueyrredon", Altura = 1500, CP = "1118" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2007, DniTransportistaAsignado = 33333333, Estado = EstadoHDR.EnCurso,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Empresa GHI S.A.", Calle = "Scalabrini", Altura = 980, CP = "1414" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2008, DniTransportistaAsignado = 44444444, Estado = EstadoHDR.EnCurso,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Logistica Central", Calle = "Callao",    Altura = 450,  CP = "1022" }
                }
            },
            new HDRRetiro
            {
                NroHDR = 2009, DniTransportistaAsignado = 44444444, Estado = EstadoHDR.Recibida,
                Detalles = new List<DetalleGuiasARetirar>
                {
                    new DetalleGuiasARetirar { Remitente = "Empresa JKL S.A.", Calle = "Florida",    Altura = 320,  CP = "1005" }
                }
            },
            // Roberto Lopez (55555555) sin HDR para probar el mensaje
        };

        internal void SetHdrSeleccionada(HDRRetiro hdr)
        {
            hdrSeleccionada = hdr;
        }

        internal HDRRetiro GetHdrSeleccionada()
        {
            return hdrSeleccionada;
        }

        internal List<TransportistaLocal> ObtenerTransportistas()
        {
            return transportistas;
        }

        internal List<HDRRetiro> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HDRRetiro>();
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

        internal bool RegistrarRendicion(List<HDRRetiro> lista)
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