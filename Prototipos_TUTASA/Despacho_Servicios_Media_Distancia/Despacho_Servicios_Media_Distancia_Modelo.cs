using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class Despacho_Servicios_Media_Distancia_Modelo
    {

        // DATOS DE PRUEBA
        private List<HDRTransporte> hdrs = new List<HDRTransporte>
        {
            new HDRTransporte
            {
                NroHDR = 3001,
                CdDestino = "CD Cordoba Centro",
                Empresa = "Transportes del Centro S.A.",
                IdServicio = "SRV-101",
                Estado = EstadoHDRTransporte.Generada,
                Guias = new List<GuiaDespacho>
                {
                    new GuiaDespacho { NroGuia = 5001, Remitente = "Empresa ABC S.A.",   Destinatario = "Juan Perez",     TipoBulto = "S" },
                    new GuiaDespacho { NroGuia = 5002, Remitente = "Distribuidora XYZ",  Destinatario = "Maria Gomez",    TipoBulto = "M" },
                    new GuiaDespacho { NroGuia = 5003, Remitente = "Importadora Sur",    Destinatario = "Carlos Diaz",    TipoBulto = "L" }
                }
            },
            new HDRTransporte
            {
                NroHDR = 3002,
                CdDestino = "CD Rosario Norte",
                Empresa = "Omnibus Andesmar S.R.L.",
                IdServicio = "SRV-202",
                Estado = EstadoHDRTransporte.Generada,
                Guias = new List<GuiaDespacho>
                {
                    new GuiaDespacho { NroGuia = 5004, Remitente = "Logistica Norte",    Destinatario = "Ana Suarez",     TipoBulto = "S"  },
                    new GuiaDespacho { NroGuia = 5005, Remitente = "Comercial Este",     Destinatario = "Pedro Ramirez",  TipoBulto = "XL" }
                }
            },
            new HDRTransporte
            {
                NroHDR = 3003,
                CdDestino = "CD Mendoza Sur",
                Empresa = "Via Bariloche S.A.",
                IdServicio = "SRV-303",
                Estado = EstadoHDRTransporte.Generada,
                Guias = new List<GuiaDespacho>
                {
                    new GuiaDespacho { NroGuia = 5006, Remitente = "Empresa DEF S.R.L.", Destinatario = "Sofia Torres",   TipoBulto = "M" },
                    new GuiaDespacho { NroGuia = 5007, Remitente = "Distribuidora ABC",  Destinatario = "Diego Martinez", TipoBulto = "M" },
                    new GuiaDespacho { NroGuia = 5008, Remitente = "Importadora Norte",  Destinatario = "Laura Romero",   TipoBulto = "L" },
                    new GuiaDespacho { NroGuia = 5009, Remitente = "Comercial Sur",      Destinatario = "Martin Acosta",  TipoBulto = "S" }
                }
            },
            new HDRTransporte
            {
                NroHDR = 3004,
                CdDestino = "CD Tucuman Centro",
                Empresa = "Flecha Bus S.A.",
                IdServicio = "SRV-404",
                Estado = EstadoHDRTransporte.Generada,
                Guias = new List<GuiaDespacho>
                {
                    new GuiaDespacho { NroGuia = 5010, Remitente = "Empresa GHI S.A.",   Destinatario = "Hugo Pereyra",   TipoBulto = "XL" },
                    new GuiaDespacho { NroGuia = 5011, Remitente = "Logistica Central",  Destinatario = "Elena Vidal",    TipoBulto = "S"  }
                }
            },
            new HDRTransporte
            {
                NroHDR = 3005,
                CdDestino = "CD Salta Capital",
                Empresa = "Cata Internacional",
                IdServicio = "SRV-505",
                Estado = EstadoHDRTransporte.Generada,
                Guias = new List<GuiaDespacho>
                {
                    new GuiaDespacho { NroGuia = 5012, Remitente = "Empresa JKL S.A.", Destinatario = "Jorge Mendez", TipoBulto = "M" }
                }
            }
        };

        // METODOS QUE USA EL FORM

        internal List<HDRTransporte> ObtenerHDRsPendientes()
        {
            var resultado = new List<HDRTransporte>();
            foreach (var hdr in hdrs)
            {
                if (hdr.Estado == EstadoHDRTransporte.Generada)
                {
                    resultado.Add(hdr);
                }
            }
            return resultado;
        }

        // Convierte tipos de bulto a equivalente en S: S=1, M=2, L=4, XL=8
        internal int CalcularBultosEnS(HDRTransporte hdr)
        {
            int total = 0;
            foreach (var g in hdr.Guias)
            {
                if (g.TipoBulto == "S") total += 1;
                else if (g.TipoBulto == "M") total += 2;
                else if (g.TipoBulto == "L") total += 4;
                else if (g.TipoBulto == "XL") total += 8;
            }
            return total;
        }

        internal int CalcularTotalBultos(HDRTransporte hdr)
        {
            return hdr.Guias.Count;
        }

        internal bool ConfirmarDespacho(HDRTransporte hdr)
        {
            // Validaciones de negocio
            if (hdr == null)
            {
                MessageBox.Show("Debe seleccionar una HDR de Transporte.");
                return false;
            }

            if (hdr.Guias.Count == 0)
            {
                MessageBox.Show("La HDR seleccionada no tiene guias para despachar.");
                return false;
            }

            if (hdr.Estado != EstadoHDRTransporte.Generada)
            {
                MessageBox.Show("La HDR no esta en estado Generada, no se puede despachar.");
                return false;
            }

            // Aplicar cambio de estado
            hdr.Estado = EstadoHDRTransporte.Despachada;
            return true;
        }
    }
}
