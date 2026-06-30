using System;
using System.Collections.Generic;
using System.Linq;
using Prototipos_TUTASA.Almacenes;
using EstadoGuiaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum;
using EstadoHojaDeRutaAlmacen = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum;
using ModalidadEntregaAlmacen = Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum;
using TipoBultoAlmacen = Prototipos_TUTASA.Auxiliares.TiposBultoEnum;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        public List<ServicioMediaDistancia> Servicios { get; set; }
        public ServicioMediaDistancia ServicioActual { get; set; }
        public List<EmpresaTransporte> Empresas { get; set; }
        public List<HojaDeRutaTransporte> HDRs { get; set; }
        public List<Guia> Guias { get; set; }
        public List<CentroDistribucion> CDs { get; set; }
        public List<Cliente> Clientes { get; set; }

        public ModeloDespachoServiciosMediaDistancia()
        {
            CargarCentrosDeDistribucion();
            CargarEmpresas();
            CargarClientes();
            CargarGuias();
            CargarHDRs();
            CargarServicios();
        }

        private void CargarCentrosDeDistribucion()
        {
            CDs = new List<CentroDistribucion>();
            foreach (var cdEntidad in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                CDs.Add(new CentroDistribucion
                {
                    idCD = cdEntidad.idCD,
                    nombre = cdEntidad.nombre
                });
            }
        }

        private void CargarEmpresas()
        {
            Empresas = new List<EmpresaTransporte>();
            foreach (var empresaEntidad in EmpresaTransporteAlmacen.empresas)
            {
                Empresas.Add(new EmpresaTransporte
                {
                    idEmpresa = empresaEntidad.idEmpresa,
                    razonSocial = empresaEntidad.razonSocial
                });
            }
        }

        private void CargarClientes()
        {
            Clientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                Clientes.Add(new Cliente
                {
                    idCliente = clienteEntidad.idCliente,
                    razonSocial = clienteEntidad.razonSocial
                });
            }
        }

        private void CargarGuias()
        {
            Guias = new List<Guia>();
            foreach (var guiaEntidad in GuiaAlmacen.Guias)
            {
                Guias.Add(new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    IdCliente = guiaEntidad.IdCliente,
                    TipoBulto = ConvertirTipoBulto(guiaEntidad.TipoBulto),
                    EquivalenteS = guiaEntidad.EquivalenteS,
                    estado = ConvertirEstadoGuia(guiaEntidad.estado),
                    Destinatario = new DestinatarioGuia
                    {
                        nombre = guiaEntidad.Destinatario.nombre,
                        apellido = guiaEntidad.Destinatario.apellido
                    }
                });
            }
        }

        private void CargarHDRs()
        {
            HDRs = new List<HojaDeRutaTransporte>();
            foreach (var hdrEntidad in HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte)
            {
                HDRs.Add(new HojaDeRutaTransporte
                {
                    NroHDR = hdrEntidad.nroHDR,
                    idServicio = hdrEntidad.idServicio,
                    idCDDestino = hdrEntidad.idCDDestino,
                    fechaGeneracion = hdrEntidad.fechaGeneracion,
                    estado = ConvertirEstadoHojaDeRuta(hdrEntidad.estado),
                    DetalleGuias = new List<string>(hdrEntidad.DetalleGuias)
                });
            }
        }

        private void CargarServicios()
        {
            Servicios = new List<ServicioMediaDistancia>();
            foreach (var servicioEntidad in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
            {
                Servicios.Add(new ServicioMediaDistancia
                {
                    idServicio = servicioEntidad.idServicio,
                    idEmpresa = servicioEntidad.idEmpresa,
                    fechaLlegada = servicioEntidad.fechaLlegada,
                    fechaRecepcion = servicioEntidad.fechaRecepcion,
                    idCDOrigen = servicioEntidad.idCDOrigen,
                    idCDDestino = servicioEntidad.idCDDestino,
                    DetalleHDRs = new List<int>(servicioEntidad.DetalleHDRs)
                });
            }
        }

        public EmpresaTransporte BuscarEmpresa(int idEmpresa) => Empresas.FirstOrDefault(e => e.idEmpresa == idEmpresa);
        public HojaDeRutaTransporte BuscarHDR(int nroHDR) => HDRs.FirstOrDefault(h => h.NroHDR == nroHDR);
        public Guia BuscarGuia(string nroGuia) => Guias.FirstOrDefault(g => g.NroGuia == nroGuia);
        public CentroDistribucion BuscarCD(int idCD) => CDs.FirstOrDefault(c => c.idCD == idCD);
        public Cliente BuscarCliente(int idCliente) => Clientes.FirstOrDefault(c => c.idCliente == idCliente);

        public int CalcularBultosEnS(ServicioMediaDistancia servicio)
        {
            int total = 0;
            foreach (int nroHDR in servicio.DetalleHDRs)
            {
                HojaDeRutaTransporte hdr = BuscarHDR(nroHDR);
                if (hdr == null) continue;
                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia g = BuscarGuia(nroGuia);
                    if (g != null) total += g.EquivalenteS;
                }
            }
            return total;
        }

        public int CalcularTotalBultos(ServicioMediaDistancia servicio)
        {
            int total = 0;
            foreach (int nroHDR in servicio.DetalleHDRs)
            {
                HojaDeRutaTransporte hdr = BuscarHDR(nroHDR);
                if (hdr != null) total += hdr.DetalleGuias.Count;
            }
            return total;
        }

        public int CalcularTotalGeneralPendiente()
        {
            int total = 0;
            foreach (var s in Servicios.FindAll(s => s.fechaLlegada == null && s.fechaRecepcion == null))
            {
                total += CalcularTotalBultos(s);
            }
            return total;
        }

        public void ConfirmarDespacho()
        {
            DateTime fechaDespacho = DateTime.Now;
            string lugarDespacho = ObtenerLugarDespacho();

            ServicioActual.fechaLlegada = fechaDespacho;

            var servicioAlmacen = ServicioMediaDistanciaAlmacen.serviciosMediaDistancia
                .FirstOrDefault(s => s.idServicio == ServicioActual.idServicio);
            if (servicioAlmacen != null)
                servicioAlmacen.fechaLlegada = fechaDespacho;

            foreach (int nroHDR in ServicioActual.DetalleHDRs)
            {
                HojaDeRutaTransporte hdr = BuscarHDR(nroHDR);
                if (hdr == null) continue;

                hdr.estado = EstadoHojaDeRutaEnum.EnCurso;

                var hdrAlmacen = HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte
                    .FirstOrDefault(h => h.nroHDR == nroHDR);
                if (hdrAlmacen != null)
                    hdrAlmacen.estado = EstadoHojaDeRutaAlmacen.EnCurso;

                foreach (string nroGuia in hdr.DetalleGuias)
                {
                    Guia g = BuscarGuia(nroGuia);
                    if (g != null) g.estado = EstadoGuiaEnum.EnTransito;

                    var guiaAlmacen = GuiaAlmacen.Guias.FirstOrDefault(gua => gua.NroGuia == nroGuia);
                    if (guiaAlmacen == null) continue;

                    Auxiliares.EstadoGuiaEnum estadoAnterior = guiaAlmacen.estado;
                    guiaAlmacen.estado = Auxiliares.EstadoGuiaEnum.EnTransito;

                    if (guiaAlmacen.estado == estadoAnterior)
                    {
                        continue;
                    }

                    if (guiaAlmacen.Historial == null)
                    {
                        guiaAlmacen.Historial = new List<HistorialEstadoGuia>();
                    }

                    guiaAlmacen.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = fechaDespacho,
                        Estado = guiaAlmacen.estado,
                        Donde = lugarDespacho
                    });
                }
            }

            ServicioMediaDistanciaAlmacen.Guardar();
            HojaDeRutaTransporteAlmacen.Guardar();
            GuiaAlmacen.Guardar();
        }

        private static string ObtenerLugarDespacho()
        {
            CentroDistribucionEntidad cdActual = CentroDistribucionAlmacen.CentrosDeDistribucion
                .FirstOrDefault(cd => cd.idCD == Program.CodigoCDActual);

            return cdActual?.nombre ?? string.Empty;
        }
        private static TiposBultoEnum ConvertirTipoBulto(TipoBultoAlmacen t)
        {
            return t switch
            {
                TipoBultoAlmacen.S => TiposBultoEnum.S,
                TipoBultoAlmacen.M => TiposBultoEnum.M,
                TipoBultoAlmacen.L => TiposBultoEnum.L,
                TipoBultoAlmacen.XL => TiposBultoEnum.XL,
                _ => TiposBultoEnum.S
            };
        }

        private static EstadoGuiaEnum ConvertirEstadoGuia(EstadoGuiaAlmacen e)
        {
            return e switch
            {
                EstadoGuiaAlmacen.Impuesta => EstadoGuiaEnum.Impuesta,
                EstadoGuiaAlmacen.IncluidaEnHDRRetiro => EstadoGuiaEnum.IncluidaEnHDRRetiro,
                EstadoGuiaAlmacen.Retirada => EstadoGuiaEnum.Retirada,
                EstadoGuiaAlmacen.Admitida => EstadoGuiaEnum.Admitida,
                EstadoGuiaAlmacen.PendienteDeDespacho => EstadoGuiaEnum.PendienteDeDespacho,
                EstadoGuiaAlmacen.EnTransito => EstadoGuiaEnum.EnTransito,
                EstadoGuiaAlmacen.EnCDDestino => EstadoGuiaEnum.EnCDDestino,
                EstadoGuiaAlmacen.EnDistribucion => EstadoGuiaEnum.EnDistribucion,
                EstadoGuiaAlmacen.PendienteDeRetiroEnAgencia => EstadoGuiaEnum.PendienteDeRetiroEnAgencia,
                EstadoGuiaAlmacen.PendienteDeRetiroEnCD => EstadoGuiaEnum.PendienteDeRetiroEnCD,
                EstadoGuiaAlmacen.Entregada => EstadoGuiaEnum.Entregada,
                EstadoGuiaAlmacen.Cancelada => EstadoGuiaEnum.Cancelada,
                _ => EstadoGuiaEnum.Impuesta
            };
        }

        private static EstadoHojaDeRutaEnum ConvertirEstadoHojaDeRuta(EstadoHojaDeRutaAlmacen e)
        {
            return e switch
            {
                EstadoHojaDeRutaAlmacen.Generada => EstadoHojaDeRutaEnum.Generada,
                EstadoHojaDeRutaAlmacen.EnCurso => EstadoHojaDeRutaEnum.EnCurso,
                EstadoHojaDeRutaAlmacen.Recibida => EstadoHojaDeRutaEnum.Recibida,
                EstadoHojaDeRutaAlmacen.Cumplida => EstadoHojaDeRutaEnum.Cumplida,
                EstadoHojaDeRutaAlmacen.NoCumplida => EstadoHojaDeRutaEnum.NoCumplida,
                _ => EstadoHojaDeRutaEnum.Generada
            };
        }
    }
}