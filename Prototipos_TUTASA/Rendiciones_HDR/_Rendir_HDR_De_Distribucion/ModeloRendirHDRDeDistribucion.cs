using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class ModeloRendirHDRDeDistribucion
    {
        // DATOS DE PRUEBA (despues se reemplazan por almacenes)
        private List<TransportistaLocal> fleteros = new List<TransportistaLocal>
        {
            new TransportistaLocal { Id = 1, Nombre = "Juan",    Apellido = "Perez"    },
            new TransportistaLocal { Id = 2, Nombre = "Maria",   Apellido = "Gomez"    },
            new TransportistaLocal { Id = 3, Nombre = "Carlos",  Apellido = "Rodriguez"},
            new TransportistaLocal { Id = 4, Nombre = "Lucia",   Apellido = "Fernandez"},
            new TransportistaLocal { Id = 5, Nombre = "Roberto", Apellido = "Lopez"    }
        };

        private List<HDRDistribucion> hdrs = new List<HDRDistribucion>
        {
            // Juan Perez (Id 1) - tiene 3 HDR pendientes
            new HDRDistribucion { NroHDR = 1001, IdFletero = 1, Destinatario = "Ana Garcia",     Calle = "Av. Corrientes", Altura = 1234, CP = "1043", Estado = EstadoHDR.EnCurso  },
            new HDRDistribucion { NroHDR = 1002, IdFletero = 1, Destinatario = "Pedro Suarez",   Calle = "Lavalle",        Altura = 567,  CP = "1047", Estado = EstadoHDR.EnCurso  },
            new HDRDistribucion { NroHDR = 1003, IdFletero = 1, Destinatario = "Laura Martinez", Calle = "Florida",        Altura = 890,  CP = "1005", Estado = EstadoHDR.Recibida },

            // Maria Gomez (Id 2) - tiene 2 HDR pendientes
            new HDRDistribucion { NroHDR = 1004, IdFletero = 2, Destinatario = "Diego Ramirez",  Calle = "Santa Fe",       Altura = 2345, CP = "1123", Estado = EstadoHDR.EnCurso  },
            new HDRDistribucion { NroHDR = 1005, IdFletero = 2, Destinatario = "Sofia Torres",   Calle = "Cordoba",        Altura = 678,  CP = "1054", Estado = EstadoHDR.Recibida },

            // Carlos Rodriguez (Id 3) - tiene 4 HDR pendientes
            new HDRDistribucion { NroHDR = 1006, IdFletero = 3, Destinatario = "Martin Diaz",    Calle = "Rivadavia",      Altura = 4567, CP = "1407", Estado = EstadoHDR.EnCurso  },
            new HDRDistribucion { NroHDR = 1007, IdFletero = 3, Destinatario = "Carla Romero",   Calle = "Belgrano",       Altura = 1100, CP = "1092", Estado = EstadoHDR.EnCurso  },
            new HDRDistribucion { NroHDR = 1008, IdFletero = 3, Destinatario = "Hugo Pereyra",   Calle = "Callao",         Altura = 230,  CP = "1022", Estado = EstadoHDR.Recibida },
            new HDRDistribucion { NroHDR = 1009, IdFletero = 3, Destinatario = "Elena Vidal",    Calle = "Pueyrredon",     Altura = 1500, CP = "1118", Estado = EstadoHDR.EnCurso  },

            // Lucia Fernandez (Id 4) - tiene 2 HDR pendientes
            new HDRDistribucion { NroHDR = 1010, IdFletero = 4, Destinatario = "Jorge Acosta",   Calle = "Pueyrredon",     Altura = 1500, CP = "1118", Estado = EstadoHDR.EnCurso  },
            new HDRDistribucion { NroHDR = 1011, IdFletero = 4, Destinatario = "Paula Mendez",   Calle = "Scalabrini",     Altura = 980,  CP = "1414", Estado = EstadoHDR.Recibida },

            // Roberto Lopez (Id 5) - SIN HDR pendientes (para probar el caso "no tiene HDR")
        };

        // METODOS QUE USA EL FORM

        internal List<TransportistaLocal> ObtenerFleteros()
        {
            return fleteros;
        }

        internal List<HDRDistribucion> ObtenerHDRsPorFletero(int idFletero)
        {
            var resultado = new List<HDRDistribucion>();
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

        internal bool AplicarEstado(HDRDistribucion hdr, bool cumplida, MotivoNoCumplidaDistribucion? motivo)
        {
            // Validaciones
            if (!cumplida && motivo == null)
            {
                MessageBox.Show("Debe seleccionar un motivo para marcar la HDR como No Cumplida.");
                return false;
            }

            // Aplicar
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

        internal bool RegistrarRendicion(List<HDRDistribucion> hdrsDeLaLista)
        {
            // Validar que TODAS hayan sido marcadas
            foreach (var hdr in hdrsDeLaLista)
            {
                if (hdr.Estado != EstadoHDR.Cumplida && hdr.Estado != EstadoHDR.NoCumplida)
                {
                    MessageBox.Show("Debe aplicar un estado a todas las HDR antes de registrar la rendicion.");
                    return false;
                }
            }

            // Aca despues vamos a persistir en almacenes
            return true;
        }
    }
}
