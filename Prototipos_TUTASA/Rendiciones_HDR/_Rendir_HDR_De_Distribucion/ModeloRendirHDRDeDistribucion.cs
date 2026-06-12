using System.Collections.Generic;
using System.Windows.Forms;
using Prototipos_TUTASA.Almacenes;
using Prototipos_TUTASA.Auxiliares;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Distribucion
{
    internal class Rendir_HDR_De_Distribucion_Modelo
    {
        private HojaDeRutaDistribucion hdrSeleccionada = null;

        public List<TransportistaLocal> Transportistas { get; set; }
        public List<HojaDeRutaDistribucion> Hdrs { get; set; }
        public List<Guia> Guias { get; set; }

        public Rendir_HDR_De_Distribucion_Modelo()
        {
            Transportistas = new List<TransportistaLocal>();
            foreach (var t in TransportistaLocalAlmacen.transportistas)
            {
                Transportistas.Add(new TransportistaLocal
                {
                    dniTransportista = t.dniTransportista,
                    nombre = t.nombre,
                    apellido = t.apellido
                });
            }

            Guias = new List<Guia>();
            foreach (var g in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = g.NroGuia,
                    estado = (EstadoGuiaEnum)(int)g.estado,
                    modalidadEntrega = (ModalidadEntregaEnum)(int)g.modalidadEntrega
                });
            }

            Hdrs = new List<HojaDeRutaDistribucion>();
            foreach (var hdr in HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion)
            {
                Hdrs.Add(new HojaDeRutaDistribucion
                {
                    NroHDR = hdr.NroHDR,
                    dniTransportistaAsignado = hdr.dniTransportistaAsignado,
                    Destinatario = hdr.Destinatario,
                    Calle = hdr.Calle,
                    Altura = hdr.Altura,
                    Piso = hdr.Piso,
                    CodigoPostal = hdr.CodigoPostal,
                    estado = (EstadoHojaDeRutaEnum)(int)hdr.estado,
                    DetalleGuias = hdr.DetalleGuias
                });
            }
        }

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
            return Transportistas;
        }

        internal TransportistaLocal BuscarTransportista(int dni)
        {
            foreach (TransportistaLocal t in Transportistas)
            {
                if (t.dniTransportista == dni) return t;
            }
            return null;
        }

        internal HojaDeRutaDistribucion BuscarHDR(int nroHDR)
        {
            foreach (HojaDeRutaDistribucion hdr in Hdrs)
            {
                if (hdr.NroHDR == nroHDR) return hdr;
            }
            return null;
        }

        internal Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia g in Guias)
            {
                if (g.NroGuia == nroGuia) return g;
            }
            return null;
        }

        internal List<HojaDeRutaDistribucion> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HojaDeRutaDistribucion>();
            foreach (var hdr in Hdrs)
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

            foreach (var hdr in lista)
            {
                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia g = BuscarGuia(nroGuia);
                    if (g == null) continue;

                    if (g.modalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
                    {
                        if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida)
                            g.estado = EstadoGuiaEnum.Entregada;
                        else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida)
                            g.estado = EstadoGuiaEnum.EnCDDestino;
                    }
                }
            }

            GuiaAlmacen.Guardar();
            HojaDeRutaDistribucionAlmacen.Guardar();

            return true;
        }
    }
}