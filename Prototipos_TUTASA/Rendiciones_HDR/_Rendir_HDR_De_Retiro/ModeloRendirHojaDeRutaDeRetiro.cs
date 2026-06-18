using System.Collections.Generic;
using System.Windows.Forms;
using Prototipos_TUTASA.Almacenes;
using System;

namespace Prototipos_TUTASA.Rendiciones_HDR._Rendir_HDR_De_Retiro
{
    internal class ModeloRendirHojaDeRutaDeRetiro
    {
        private HojaDeRutaRetiro hdrSeleccionada = null;

        public List<TransportistaLocal> Transportistas { get; set; }
        public List<HojaDeRutaRetiro> Hdrs { get; set; }
        public List<Guia> Guias { get; set; }

        public ModeloRendirHojaDeRutaDeRetiro()
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
                    estado = (EstadoGuiaEnum)(int)g.estado
                });
            }

            Hdrs = new List<HojaDeRutaRetiro>();
            foreach (var hdr in HojaDeRutaRetiroAlmacen.hojasDeRutaRetiro)
            {
                Hdrs.Add(new HojaDeRutaRetiro
                {
                    NroHDR = hdr.NroHDR,
                    dniTransportistaAsignado = hdr.dniTransportistaAsignado,
                    idAgenciaOrigen = hdr.idAgenciaOrigen,
                    Remitente = hdr.Remitente,
                    Calle = hdr.Calle,
                    Altura = hdr.Altura,
                    Piso = hdr.Piso,
                    CodigoPostal = hdr.CodigoPostal,
                    estado = (EstadoHojaDeRutaEnum)(int)hdr.estado,
                    DetalleGuias = hdr.DetalleGuias
                });
            }
        }

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

        internal HojaDeRutaRetiro BuscarHDR(int nroHDR)
        {
            foreach (HojaDeRutaRetiro hdr in Hdrs)
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

        internal List<HojaDeRutaRetiro> ObtenerHDRsPorTransportista(int dniTransportista)
        {
            var resultado = new List<HojaDeRutaRetiro>();
            foreach (var hdr in Hdrs)
            {
                if (hdr.dniTransportistaAsignado == dniTransportista &&
                    hdr.estado == EstadoHojaDeRutaEnum.Recibida)
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

                    if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida)
                        g.estado = EstadoGuiaEnum.Retirada;
                    else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida)
                        g.estado = EstadoGuiaEnum.Impuesta;
                }
            }

            // 2) Actualizar entidades del almacen (para que persista al Guardar)
            foreach (var hdr in lista)
            {
                var hdrEntidad = HojaDeRutaRetiroAlmacen.hojasDeRutaRetiro
                    .FirstOrDefault(h => h.NroHDR == hdr.NroHDR);

                if (hdrEntidad != null)
                {
                    hdrEntidad.estado = Enum.Parse<Auxiliares.EstadoHojaDeRutaEnum>(hdr.estado.ToString());

                    if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida && hdr.motivoNoCumplida != null)
                    {
                        hdrEntidad.motivoNoCumplida = Enum.Parse<Auxiliares.MotivoNoCumplidaRetiroEnum>(hdr.motivoNoCumplida.Value.ToString());
                    }
                }

                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    var guiaEntidad = GuiaAlmacen.Guias
                        .FirstOrDefault(g => g.NroGuia == nroGuia);

                    if (guiaEntidad != null)
                    {
                        if (hdr.estado == EstadoHojaDeRutaEnum.Cumplida)
                            guiaEntidad.estado = Auxiliares.EstadoGuiaEnum.Retirada;
                        else if (hdr.estado == EstadoHojaDeRutaEnum.NoCumplida)
                            guiaEntidad.estado = Auxiliares.EstadoGuiaEnum.Impuesta;
                    }
                }
            }

            GuiaAlmacen.Guardar();
            HojaDeRutaRetiroAlmacen.Guardar();

            return true;
        }
    }
}