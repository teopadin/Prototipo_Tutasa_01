using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.Almacenes;
using EstadoGuiaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum;
using EstadoHojaDeRutaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum;
using ModalidadEntregaAlmacen = Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum;
using TipoBultoAlmacen = Prototipos_TUTASA.Auxiliares.TiposBultoEnum;

namespace Prototipos_TUTASA.RecepcionMediaDistancia
{
    internal class ModeloRecibirServicioMediaDistancia
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public ServicioMediaDistancia ServicioActual { get; set; }
        public List<EmpresaTransporte> Empresas { get; set; }
        public List<HojaDeRutaTransporte> HDRs { get; set; }
        public List<Guia> Guias { get; set; }
        public List<CentroDistribucion> CDs { get; set; }

        public ModeloRecibirServicioMediaDistancia() 
        {
            CargarCentrosDeDistribucion();
            CargarEmpresas();
            CargarGuias();
            CargarHDRs();
            CargarServicios();

        }

        private void CargarCentrosDeDistribucion()
        {
            CDs = new List<CentroDistribucion>();

            foreach (CentroDistribucionEntidad cdEntidad in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                CDs.Add(new CentroDistribucion
                {
                    idCD = cdEntidad.idCD,
                    nombre = cdEntidad.nombre
                });
            }

            CdEmisor = BuscarCD(Program.CodigoCDActual);

            if (CdEmisor == null && CDs.Count > 0)
            {
                CdEmisor = CDs[0];
            }
        }

        private void CargarEmpresas()
        {
            Empresas = new List<EmpresaTransporte>();

            foreach (EmpresaTransporteEntidad empresaEntidad in EmpresaTransporteAlmacen.empresas)
            {
                Empresas.Add(new EmpresaTransporte
                {
                    idEmpresa = empresaEntidad.idEmpresa,
                    razonSocial = empresaEntidad.razonSocial
                });
            }
        }

        private void CargarGuias()
        {
            Guias = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    TipoBulto = ConvertirTipoBulto(guiaEntidad.TipoBulto),
                    modalidadEntrega = ConvertirModalidadEntrega(guiaEntidad.modalidadEntrega),
                    estado = ConvertirEstadoGuia(guiaEntidad.estado),
                    idCDOrigen = guiaEntidad.idCDOrigen,
                    idCDActual = guiaEntidad.idCDActual,
                    idCDDestino = guiaEntidad.idCDDestino
                });
            }
        }

        private void CargarHDRs()
        {
            HDRs = new List<HojaDeRutaTransporte>();

            foreach (HojaDeRutaTransporteEntidad hdrEntidad in HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte)
            {
                HDRs.Add(new HojaDeRutaTransporte
                {
                    NroHDR = hdrEntidad.nroHDR,
                    estado = ConvertirEstadoHojaDeRuta(hdrEntidad.estado),
                    DetalleGuias = new List<string>(hdrEntidad.DetalleGuias)
                });
            }
        }

        private void CargarServicios()
        {
            Servicios = new List<ServicioMediaDistancia>();

            foreach (ServicioMediaDistanciaEntidad servicioEntidad in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
            {
                Servicios.Add(new ServicioMediaDistancia
                {
                    idServicio = servicioEntidad.idServicio,
                    idEmpresa = servicioEntidad.idEmpresa,
                    fechaLlegada = servicioEntidad.fechaLlegada,
                    fechaRecepcion = servicioEntidad.fechaRecepcion == DateTime.MinValue ? null : servicioEntidad.fechaRecepcion,
                    DetalleHDRs = ObtenerDetalleHDRs(servicioEntidad)
                });
            }
        }

        private static List<int> ObtenerDetalleHDRs(ServicioMediaDistanciaEntidad servicioEntidad)
        {
            List<int> detalleHDRs = new List<int>();

            foreach (int nroHDR in servicioEntidad.DetalleHDRs)
            {
                if (!detalleHDRs.Contains(nroHDR))
                {
                    detalleHDRs.Add(nroHDR);
                }
            }

            foreach (HojaDeRutaTransporteEntidad hdrEntidad in HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte)
            {
                if (hdrEntidad.idServicio == servicioEntidad.idServicio && !detalleHDRs.Contains(hdrEntidad.nroHDR))
                {
                    detalleHDRs.Add(hdrEntidad.nroHDR);
                }
            }

            return detalleHDRs;
        }

        public EmpresaTransporte BuscarEmpresa(int idEmpresa)
        {
            return Empresas.FirstOrDefault(e => e.idEmpresa == idEmpresa);
        }
        public HojaDeRutaTransporte BuscarHDR(int nroHDR)
        {
            return HDRs.FirstOrDefault(h => h.NroHDR == nroHDR);
        }
        public Guia BuscarGuia(string nroGuia)
        {
            return Guias.FirstOrDefault(g => g.NroGuia == nroGuia);
        }
        public CentroDistribucion BuscarCD(int idCD)
        {
            return CDs.FirstOrDefault(c => c.idCD == idCD);
        }

        public void ConfirmarRecepcion()
        {
            if (ServicioActual == null)
            {
                return;
            }

            DateTime fechaRecepcion = DateTime.Now;

            // DTO (para la pantalla)
            ServicioActual.fechaRecepcion = fechaRecepcion;

            // Servicio: entidad real del Almacén
            ServicioMediaDistanciaEntidad servicioEntidad = ServicioMediaDistanciaAlmacen.serviciosMediaDistancia
                .FirstOrDefault(s => s.idServicio == ServicioActual.idServicio);

            if (servicioEntidad != null)
            {
                servicioEntidad.fechaRecepcion = fechaRecepcion;
            }

            foreach (int nroHDR in ServicioActual.DetalleHDRs)
            {
                // HDR DTO
                HojaDeRutaTransporte hdrDto = BuscarHDR(nroHDR);
                if (hdrDto != null)
                {
                    hdrDto.estado = EstadoHojaDeRutaEnum.Recibida;
                }

                // HDR entidad real
                HojaDeRutaTransporteEntidad hdrEntidad = HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte
                    .FirstOrDefault(h => h.nroHDR == nroHDR);

                if (hdrEntidad == null)
                {
                    continue;
                }

                hdrEntidad.estado = EstadoHojaDeRutaAlmacen.Recibida;

                foreach (string nroGuia in hdrEntidad.DetalleGuias)
                {
                    GuiaEntidad guiaEntidad = GuiaAlmacen.Guias
                        .FirstOrDefault(g => g.NroGuia == nroGuia);

                    if (guiaEntidad == null)
                    {
                        continue;
                    }

                    EstadoGuiaAlmacen nuevoEstado = DeterminarEstadoGuia(guiaEntidad);

                    guiaEntidad.estado = nuevoEstado;

                    guiaEntidad.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = fechaRecepcion,
                        Estado = nuevoEstado,
                        Donde = CdEmisor.nombre
                    });

                    // DTO (para la pantalla)
                    Guia guiaDto = BuscarGuia(nroGuia);
                    if (guiaDto != null)
                    {
                        guiaDto.estado = ConvertirEstadoGuia(nuevoEstado);
                    }
                }
            }

            GuiaAlmacen.Guardar();
            HojaDeRutaTransporteAlmacen.Guardar();
            ServicioMediaDistanciaAlmacen.Guardar();
        }

        private static EstadoGuiaAlmacen DeterminarEstadoGuia(GuiaEntidad guiaEntidad)
        {
            if (guiaEntidad.idCDActual == guiaEntidad.idCDDestino)
            {
                if (guiaEntidad.modalidadEntrega == ModalidadEntregaAlmacen.EntregaCD)
                {
                    return EstadoGuiaAlmacen.PendienteDeRetiroEnCD;
                }

                return EstadoGuiaAlmacen.EnCDDestino;
            }

            return EstadoGuiaAlmacen.Admitida;
        }

        private static TiposBultoEnum ConvertirTipoBulto(TipoBultoAlmacen tipoBulto)
        {
            return tipoBulto switch
            {
                TipoBultoAlmacen.M => TiposBultoEnum.M,
                TipoBultoAlmacen.L => TiposBultoEnum.L,
                TipoBultoAlmacen.XL => TiposBultoEnum.XL,
                _ => TiposBultoEnum.S
            };
        }

        private static ModalidadEntregaEnum ConvertirModalidadEntrega(ModalidadEntregaAlmacen modalidadEntrega)
        {
            return modalidadEntrega switch
            {
                ModalidadEntregaAlmacen.EntregaAgencia => ModalidadEntregaEnum.EntregaAgencia,
                ModalidadEntregaAlmacen.EntregaCD => ModalidadEntregaEnum.EntregaCD,
                _ => ModalidadEntregaEnum.EntregaDomicilio
            };
        }

        private static EstadoGuiaEnum ConvertirEstadoGuia(EstadoGuiaAlmacen estado)
        {
            return estado switch
            {
                EstadoGuiaAlmacen.EnTransito => EstadoGuiaEnum.EnTransito,
                EstadoGuiaAlmacen.EnCDDestino => EstadoGuiaEnum.EnCDDestino,
                EstadoGuiaAlmacen.PendienteDeRetiroEnCD => EstadoGuiaEnum.PendienteDeRetiroEnCD,
                _ => EstadoGuiaEnum.Admitida
            };
        }

        private static EstadoHojaDeRutaEnum ConvertirEstadoHojaDeRuta(EstadoHojaDeRutaAlmacen estado)
        {
            if (estado == EstadoHojaDeRutaAlmacen.Recibida)
            {
                return EstadoHojaDeRutaEnum.Recibida;
            }

            return EstadoHojaDeRutaEnum.EnCurso;
        }

    }
}
