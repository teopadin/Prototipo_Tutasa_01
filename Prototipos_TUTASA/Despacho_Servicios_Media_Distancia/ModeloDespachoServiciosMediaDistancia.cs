using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Despacho_Servicios_Media_Distancia
{
    internal class ModeloDespachoServiciosMediaDistancia
    {
        private List<HojaDeRutaTransporte> hdrs;
        private List<ServicioMediaDistancia> servicios;
        private List<EmpresaTransporte> almacenEmpresas;
        private List<Cliente> almacenClientes;
        private List<CentroDistribucion> almacenCDs;
        private List<Guia> almacenGuias;

        public ModeloDespachoServiciosMediaDistancia()
        {
            // 1. Inicializamos y cargamos Empresas de Transporte
            almacenEmpresas = new List<EmpresaTransporte>();
            foreach (var empresaEntidad in EmpresaTransporteAlmacen.empresas)
            {
                almacenEmpresas.Add(new EmpresaTransporte
                {
                    idEmpresa = empresaEntidad.idEmpresa,
                    razonSocial = empresaEntidad.razonSocial
                });
            }

            // 2. Inicializamos y cargamos Clientes
            almacenClientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                almacenClientes.Add(new Cliente
                {
                    idCliente = clienteEntidad.idCliente,
                    razonSocial = clienteEntidad.razonSocial
                });
            }

            // 3. Inicializamos y cargamos Centros de Distribución
            almacenCDs = new List<CentroDistribucion>();
            foreach (var cdEntidad in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                almacenCDs.Add(new CentroDistribucion
                {
                    idCD = cdEntidad.idCD,
                    nombre = cdEntidad.nombre
                });
            }

            // 4. Inicializamos y cargamos Servicios
            servicios = new List<ServicioMediaDistancia>();
            foreach (var servicioEntidad in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia) // <-- Corregido
            {
                servicios.Add(new ServicioMediaDistancia
                {
                    // Nota: Si en tu clase ServicioMediaDistancia (del modelo) idServicio es int, 
                    // dejá el int.Parse. Si lo cambiaste a string, sacale el int.Parse()
                    idServicio = int.Parse(servicioEntidad.idServicio),
                    idEmpresa = servicioEntidad.idEmpresa
                });
            }

            // 5. Inicializamos y cargamos Guías
            almacenGuias = new List<Guia>();
            foreach (var guiaEntidad in GuiaAlmacen.Guias)
            {
                almacenGuias.Add(new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    IdCliente = guiaEntidad.IdCliente,

                    // Le agregamos el casteo explícito a estos dos:
                    TipoBulto = (TiposBultoEnum)guiaEntidad.TipoBulto,
                    estado = (EstadoGuiaEnum)guiaEntidad.estado,

                    EquivalenteS = guiaEntidad.EquivalenteS,
                    Destinatario = new DestinatarioGuia
                    {
                        nombre = guiaEntidad.Destinatario.nombre,
                        apellido = guiaEntidad.Destinatario.apellido
                    }
                });
            }

            // 6. Inicializamos y cargamos Hojas de Ruta Transporte
            hdrs = new List<HojaDeRutaTransporte>();
            foreach (var hdrEntidad in HojaDeRutaTransporteAlmacen.hojasDeRutaTransporte) // <-- Corregido
            {
                var nuevaHDR = new HojaDeRutaTransporte
                {
                    NroHDR = hdrEntidad.nroHDR,

                    // Le agregamos el casteo explícito acá:
                    estado = (EstadoHojaDeRutaEnum)hdrEntidad.estado,

                    idServicio = hdrEntidad.idServicio,
                    idCDDestino = hdrEntidad.idCDDestino,
                    fechaGeneracion = hdrEntidad.fechaGeneracion,
                    DetalleGuias = new List<string>()
                };

                // Pasamos los strings de las guías de la entidad a nuestra HDR local
                if (hdrEntidad.DetalleGuias != null)
                {
                    foreach (var nroGuia in hdrEntidad.DetalleGuias)
                    {
                        nuevaHDR.DetalleGuias.Add(nroGuia);
                    }
                }

                hdrs.Add(nuevaHDR);
            }
        }

        // --- MÉTODOS BUSCADORES (Siguen iguales) ---
        public EmpresaTransporte BuscarEmpresa(int id) => almacenEmpresas.Find(e => e.idEmpresa == id);
        public Cliente BuscarCliente(int id) => almacenClientes.Find(c => c.idCliente == id);
        public CentroDistribucion BuscarCD(int id) => almacenCDs.Find(cd => cd.idCD == id);
        public ServicioMediaDistancia BuscarServicioPorId(int id) => servicios.Find(s => s.idServicio == id);
        public Guia BuscarGuia(string nroGuia) => almacenGuias.Find(g => g.NroGuia == nroGuia);

        // --- MÉTODOS DE LÓGICA (Siguen iguales) ---
        internal List<HojaDeRutaTransporte> ObtenerHDRsPendientes() => hdrs.FindAll(h => h.estado == EstadoHojaDeRutaEnum.Generada);

        internal int CalcularBultosEnS(HojaDeRutaTransporte hdr)
        {
            int total = 0;
            foreach (var nroGuia in hdr.DetalleGuias)
            {
                Guia g = BuscarGuia(nroGuia);
                if (g != null)
                {
                    if (g.TipoBulto == TiposBultoEnum.S) total += 1;
                    else if (g.TipoBulto == TiposBultoEnum.M) total += 2;
                    else if (g.TipoBulto == TiposBultoEnum.L) total += 4;
                    else if (g.TipoBulto == TiposBultoEnum.XL) total += 8;
                }
            }
            return total;
        }

        internal int CalcularTotalBultos(HojaDeRutaTransporte hdr) => hdr?.DetalleGuias.Count ?? 0;

        internal int CalcularTotalGeneralPendiente()
        {
            int acumulador = 0;
            foreach (var h in ObtenerHDRsPendientes()) acumulador += h.DetalleGuias.Count;
            return acumulador;
        }

        internal bool ConfirmarDespacho(HojaDeRutaTransporte hdr)
        {
            if (hdr == null) return false;

            foreach (var nroGuia in hdr.DetalleGuias)
            {
                Guia guiaReal = BuscarGuia(nroGuia);
                if (guiaReal != null)
                {
                    guiaReal.estado = EstadoGuiaEnum.EnTransito;
                }
            }
            hdr.estado = EstadoHojaDeRutaEnum.EnCurso;
            return true;
        }
    }
}