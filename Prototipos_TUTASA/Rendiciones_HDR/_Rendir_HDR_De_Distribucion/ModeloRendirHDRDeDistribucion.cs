using System;
using System.Collections.Generic;
using System.Linq;
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
            DateTime fechaRendicion = DateTime.Now;
            string lugarRendicion = ObtenerLugarRendicion();

            foreach (var hdr in lista)
            {
                if (hdr.estado != EstadoHojaDeRutaEnum.Cumplida && hdr.estado != EstadoHojaDeRutaEnum.NoCumplida)
                {
                    MessageBox.Show("Hay hojas de ruta sin su estado nuevo, completelas para poder registrar la rendicion.");
                    return false;
                }
            }

            // 1) Actualizar copias locales (para que la pantalla refleje el estado)
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

            // 2) Actualizar entidades del almacen (para que persista al Guardar)
            foreach (var hdr in lista)
            {
                var hdrEntidad = HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion
                    .FirstOrDefault(h => h.NroHDR == hdr.NroHDR);

                if (hdrEntidad != null)
                {
                    hdrEntidad.estado = Enum.Parse<Auxiliares.EstadoHojaDeRutaEnum>(hdr.estado.ToString());

                    if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida && hdr.motivoNoCumplida != null)
                    {
                        hdrEntidad.motivoNoCumplida = Enum.Parse<Auxiliares.MotivoNoCumplidaDistribucionEnum>(hdr.motivoNoCumplida.Value.ToString());
                    }
                }

                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    var guiaEntidad = GuiaAlmacen.Guias
                        .FirstOrDefault(g => g.NroGuia == nroGuia);

                    if (guiaEntidad == null) continue;

                    // Solo modificar guías con modalidad EntregaDomicilio
                    if (guiaEntidad.modalidadEntrega != Auxiliares.ModalidadEntregaEnum.EntregaDomicilio)
                        continue;

                    Auxiliares.EstadoGuiaEnum estadoAnterior = guiaEntidad.estado;

                    if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida)
                        guiaEntidad.estado = Auxiliares.EstadoGuiaEnum.Entregada;
                    else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida)
                        guiaEntidad.estado = Auxiliares.EstadoGuiaEnum.EnCDDestino;

                    if (guiaEntidad.estado == estadoAnterior)
                    {
                        continue;
                    }

                    if (guiaEntidad.Historial == null)
                    {
                        guiaEntidad.Historial = new List<HistorialEstadoGuia>();
                    }

                    guiaEntidad.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = fechaRendicion,
                        Estado = guiaEntidad.estado,
                        Donde = lugarRendicion
                    });
                }
            }

            GuiaAlmacen.Guardar();
            HojaDeRutaDistribucionAlmacen.Guardar();

            return true;
        }

        private static string ObtenerLugarRendicion()
        {
            CentroDistribucionEntidad cdActual = CentroDistribucionAlmacen.CentrosDeDistribucion
                .FirstOrDefault(cd => cd.idCD == Program.CodigoCDActual);

            return cdActual?.nombre ?? string.Empty;
        }
    }
}