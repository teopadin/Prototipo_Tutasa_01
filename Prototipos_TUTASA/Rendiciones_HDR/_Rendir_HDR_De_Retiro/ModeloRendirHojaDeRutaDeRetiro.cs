using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class ModeloRendirHojaDeRutaDeRetiro
    {
        private HojaDeRutaRetiro hdrSeleccionada = null;

        private List<TransportistaLocal> transportistas = new List<TransportistaLocal>
    {
        new TransportistaLocal { dniTransportista = 11111111, nombre = "Juan",    apellido = "Perez"     },
        new TransportistaLocal { dniTransportista = 22222222, nombre = "Maria",   apellido = "Gomez"     },
        new TransportistaLocal { dniTransportista = 33333333, nombre = "Carlos",  apellido = "Rodriguez" },
        new TransportistaLocal { dniTransportista = 44444444, nombre = "Lucia",   apellido = "Fernandez" },
        new TransportistaLocal { dniTransportista = 55555555, nombre = "Roberto", apellido = "Lopez"     }
    };

        // Almacén de guías — todas con estado IncluidaEnHDRRetiro porque ya están asignadas a una HDR de retiro
        private List<Guia> guias = new List<Guia>
    {
        new Guia { NroGuia = "G-R-001", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-002", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-003", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-004", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-005", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-006", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-007", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-008", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-009", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro },
        new Guia { NroGuia = "G-R-010", estado = EstadoGuiaEnum.IncluidaEnHDRRetiro }
    };

        private List<HojaDeRutaRetiro> hdrs = new List<HojaDeRutaRetiro>
    {
        new HojaDeRutaRetiro { NroHDR = 2001, dniTransportistaAsignado = 11111111, Remitente = "Empresa ABC S.A.",   Calle = "Av. Corrientes", Altura = 1234, Piso = "1",  CodigoPostal = "1043", estado = EstadoHojaDeRutaEnum.Recibida,  DetalleGuias = new List<string> { "G-R-001" } },
        new HojaDeRutaRetiro { NroHDR = 2002, dniTransportistaAsignado = 11111111, Remitente = "Distribuidora XYZ",  Calle = "Lavalle",        Altura = 567,  Piso = "3",  CodigoPostal = "1047", estado = EstadoHojaDeRutaEnum.Recibida,  DetalleGuias = new List<string> { "G-R-002" } },
        new HojaDeRutaRetiro { NroHDR = 2003, dniTransportistaAsignado = 11111111, Remitente = "Importadora Sur",    Calle = "Florida",        Altura = 890,  Piso = "PB", CodigoPostal = "1005", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-R-003" } },
        new HojaDeRutaRetiro { NroHDR = 2004, dniTransportistaAsignado = 22222222, Remitente = "Logistica Norte",    Calle = "Santa Fe",       Altura = 2345, Piso = "2",  CodigoPostal = "1123", estado = EstadoHojaDeRutaEnum.Recibida,  DetalleGuias = new List<string> { "G-R-004" } },
        new HojaDeRutaRetiro { NroHDR = 2005, dniTransportistaAsignado = 22222222, Remitente = "Comercial Este",     Calle = "Cordoba",        Altura = 678,  Piso = "4",  CodigoPostal = "1054", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-R-005" } },
        new HojaDeRutaRetiro { NroHDR = 2006, dniTransportistaAsignado = 33333333, Remitente = "Empresa DEF S.R.L.", Calle = "Rivadavia",      Altura = 4567, Piso = "5",  CodigoPostal = "1407", estado = EstadoHojaDeRutaEnum.Recibida,  DetalleGuias = new List<string> { "G-R-006" } },
        new HojaDeRutaRetiro { NroHDR = 2007, dniTransportistaAsignado = 33333333, Remitente = "Distribuidora ABC",  Calle = "Belgrano",       Altura = 1100, Piso = "PB", CodigoPostal = "1092", estado = EstadoHojaDeRutaEnum.Recibida,  DetalleGuias = new List<string> { "G-R-007" } },
        new HojaDeRutaRetiro { NroHDR = 2008, dniTransportistaAsignado = 33333333, Remitente = "Importadora Norte",  Calle = "Callao",         Altura = 230,  Piso = "1",  CodigoPostal = "1022", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-R-008" } },
        new HojaDeRutaRetiro { NroHDR = 2009, dniTransportistaAsignado = 44444444, Remitente = "Empresa GHI S.A.",   Calle = "Pueyrredon",     Altura = 1500, Piso = "3",  CodigoPostal = "1118", estado = EstadoHojaDeRutaEnum.Recibida,  DetalleGuias = new List<string> { "G-R-009" } },
        new HojaDeRutaRetiro { NroHDR = 2010, dniTransportistaAsignado = 44444444, Remitente = "Logistica Central",  Calle = "Scalabrini",     Altura = 980,  Piso = "PB", CodigoPostal = "1414", estado = EstadoHojaDeRutaEnum.Recibida, DetalleGuias = new List<string> { "G-R-010" } }
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

        internal TransportistaLocal BuscarTransportista(int dni)
        {
            foreach (TransportistaLocal t in transportistas)
            {
                if (t.dniTransportista == dni) return t;
            }
            return null;
        }

        internal HojaDeRutaRetiro BuscarHDR(int nroHDR)
        {
            foreach (HojaDeRutaRetiro hdr in hdrs)
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

        internal List<HojaDeRutaRetiro> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HojaDeRutaRetiro>();
            foreach (var hdr in hdrs)
            {
                if (hdr.dniTransportistaAsignado == dniTransportista &&
                    (hdr.estado == EstadoHojaDeRutaEnum.Recibida || hdr.estado == EstadoHojaDeRutaEnum.Recibida))
                {
                    resultado.Add(hdr);
                }
            }
            return resultado;
        }

        internal List<MotivoNoCumplidaRetiroEnum> ObtenerMotivos()
        {
            return new List<MotivoNoCumplidaRetiroEnum>
        {
            MotivoNoCumplidaRetiroEnum.ClienteAusente,
            MotivoNoCumplidaRetiroEnum.EncomiendaNoPreparada,
            MotivoNoCumplidaRetiroEnum.DiscrepanciaConGuia,
            MotivoNoCumplidaRetiroEnum.Otro
        };
        }

        internal bool AplicarEstado(bool cumplida, MotivoNoCumplidaRetiroEnum? motivo)
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

        internal bool RegistrarRendicion(List<HojaDeRutaRetiro> lista)
        {
            foreach (var hdr in lista)
            {
                if (hdr.estado != EstadoHojaDeRutaEnum.Cumplida && hdr.estado != EstadoHojaDeRutaEnum.NoCumplida)
                {
                    MessageBox.Show("Debe aplicar un estado a todas las HDR antes de registrar la rendicion.");
                    return false;
                }
            }

            // Cambiar el estado de las guías según el estado final de cada HDR
            foreach (var hdr in lista)
            {
                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia g = BuscarGuia(nroGuia);
                    if (g == null) continue;

                    if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida)
                    {
                        g.estado = EstadoGuiaEnum.Retirada;
                    }
                    else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida)
                    {
                        g.estado = EstadoGuiaEnum.Impuesta;
                    }
                }
            }

            return true;
        }
    }
}