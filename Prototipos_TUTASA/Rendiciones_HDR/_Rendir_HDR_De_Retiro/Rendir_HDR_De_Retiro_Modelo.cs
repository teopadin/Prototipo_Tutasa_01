using System;
using System.Collections.Generic;
using System.Text;
using Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class Rendir_HDR_De_Retiro_Modelo
    {
        private List<Fletero> fleteros = new List<Fletero>
        {
            new Fletero { Id = 1, Nombre = "Juan",    Apellido = "Perez"     },
            new Fletero { Id = 2, Nombre = "Maria",   Apellido = "Gomez"     },
            new Fletero { Id = 3, Nombre = "Carlos",  Apellido = "Rodriguez" },
            new Fletero { Id = 4, Nombre = "Lucia",   Apellido = "Fernandez" },
            new Fletero { Id = 5, Nombre = "Roberto", Apellido = "Lopez"     }
        };

        private List<HDRRetiro> hdrs = new List<HDRRetiro>
        {
            // Juan Perez (Id 1) - 3 HDR pendientes
            new HDRRetiro { NroHDR = 2001, IdFletero = 1, Remitente = "Empresa ABC S.A.",   Calle = "Av. Corrientes", Altura = 1234, CP = "1043", Estado = EstadoHDR.EnCurso  },
            new HDRRetiro { NroHDR = 2002, IdFletero = 1, Remitente = "Distribuidora XYZ",  Calle = "Lavalle",        Altura = 567,  CP = "1047", Estado = EstadoHDR.EnCurso  },
            new HDRRetiro { NroHDR = 2003, IdFletero = 1, Remitente = "Importadora Sur",    Calle = "Florida",        Altura = 890,  CP = "1005", Estado = EstadoHDR.Recibida },

            // Maria Gomez (Id 2) - 2 HDR pendientes
            new HDRRetiro { NroHDR = 2004, IdFletero = 2, Remitente = "Logistica Norte",    Calle = "Santa Fe",       Altura = 2345, CP = "1123", Estado = EstadoHDR.EnCurso  },
            new HDRRetiro { NroHDR = 2005, IdFletero = 2, Remitente = "Comercial Este",     Calle = "Cordoba",        Altura = 678,  CP = "1054", Estado = EstadoHDR.Recibida },

            // Carlos Rodriguez (Id 3) - 4 HDR pendientes
            new HDRRetiro { NroHDR = 2006, IdFletero = 3, Remitente = "Empresa DEF S.R.L.", Calle = "Rivadavia",      Altura = 4567, CP = "1407", Estado = EstadoHDR.EnCurso  },
            new HDRRetiro { NroHDR = 2007, IdFletero = 3, Remitente = "Distribuidora ABC",  Calle = "Belgrano",       Altura = 1100, CP = "1092", Estado = EstadoHDR.EnCurso  },
            new HDRRetiro { NroHDR = 2008, IdFletero = 3, Remitente = "Importadora Norte",  Calle = "Callao",         Altura = 230,  CP = "1022", Estado = EstadoHDR.Recibida },
            new HDRRetiro { NroHDR = 2009, IdFletero = 3, Remitente = "Comercial Sur",      Calle = "Pueyrredon",     Altura = 1500, CP = "1118", Estado = EstadoHDR.EnCurso  },

            // Lucia Fernandez (Id 4) - 2 HDR pendientes
            new HDRRetiro { NroHDR = 2010, IdFletero = 4, Remitente = "Empresa GHI S.A.",   Calle = "Pueyrredon",     Altura = 1500, CP = "1118", Estado = EstadoHDR.EnCurso  },
            new HDRRetiro { NroHDR = 2011, IdFletero = 4, Remitente = "Logistica Central",  Calle = "Scalabrini",     Altura = 980,  CP = "1414", Estado = EstadoHDR.Recibida },

            // Roberto Lopez (Id 5) - SIN HDR para probar el mensaje
        };

        internal List<Fletero> ObtenerFleteros()
        {
            return fleteros;
        }

        internal List<HDRRetiro> ObtenerHDRsPorFletero(int idFletero)
        {
            var resultado = new List<HDRRetiro>();
            foreach (var hdr in hdrs)
            {
                if (hdr.IdFletero == idFletero &&
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

        internal bool AplicarEstado(HDRRetiro hdr, bool cumplida, MotivoNoCumplidaRetiro? motivo)
        {
            if (!cumplida && motivo == null)
            {
                MessageBox.Show("Debe seleccionar un motivo para marcar la HDR como No Cumplida.");
                return false;
            }

            if (cumplida)
            {
                hdr.Estado = EstadoHDR.Cumplida;
                hdr.MotivoNoCumplida = null;
            }
            else
            {
                hdr.Estado = EstadoHDR.NoCumplida;
                hdr.MotivoNoCumplida = motivo;
            }
            return true;
        }

        internal bool RegistrarRendicion(List<HDRRetiro> hdrsDeLaLista)
        {
            foreach (var hdr in hdrsDeLaLista)
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
