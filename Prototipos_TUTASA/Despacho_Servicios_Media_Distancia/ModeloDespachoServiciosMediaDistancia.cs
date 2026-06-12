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
        public List<ServicioMediaDistancia> servicios { get; set; }
        public List<HojaDeRutaTransporte> hdrs { get; set; }
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
            foreach (var servicioEntidad in ServicioMediaDistanciaAlmacen.serviciosMediaDistancia)
            {
                servicios.Add(new ServicioMediaDistancia
                {
                    idServicio = int.Parse(servicioEntidad.idServicio),
                    idEmpresa = servicioEntidad.idEmpresa,

                    // AGREGAR ESTA LÍNEA:
                    fechaLlegada = servicioEntidad.fechaLlegada
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
        public ServicioMediaDistancia BuscarServicioPorId(string id)
        {
            return servicios.FirstOrDefault(s => s.idServicio.ToString() == id);
        }
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

        public bool ConfirmarDespacho(HojaDeRutaTransporte hdr)
        {
            try
            {
                // 1. Buscamos el servicio asociado a esta HDR en nuestra lista en memoria
                var servicioLocal = servicios.FirstOrDefault(s => s.idServicio.ToString() == hdr.idServicio);

                if (servicioLocal != null)
                {
                    // Le asignamos la fecha de llegada confirmando el despacho
                    servicioLocal.fechaLlegada = DateTime.Now;
                }

                // 2. Buscamos la entidad original del Almacén para impactar el JSON global del grupo
                var entidadAlmacen = Prototipos_TUTASA.Almacenes.ServicioMediaDistanciaAlmacen.serviciosMediaDistancia
                    .FirstOrDefault(x => x.idServicio == hdr.idServicio);

                if (entidadAlmacen != null)
                {
                    entidadAlmacen.fechaLlegada = DateTime.Now;
                }

                // 3. Guardamos los cambios de manera persistente en el archivo ServiciosMediaDistancia.json
                Prototipos_TUTASA.Almacenes.ServicioMediaDistanciaAlmacen.Guardar();

                // (Acá podés agregar también lógica para cambiar el estado de la HDR o de las Guías si lo necesitan)

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}