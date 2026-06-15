using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_De_Distribucion
{
    internal class ModeloGenerarHDRDistribucion
    {
        public CentroDistribucion CdEmisor { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public List<Agencia> Agencias { get; set; }
        public List<Guia> Guias { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public bool Actualizando { get; set; } = false;

        public ModeloGenerarHDRDistribucion()
        {
            List<CentroDistribucionEntidad> cdsArchivo = LeerJson<List<CentroDistribucionEntidad>>("CentrosDeDistribucion.json");
            List<AgenciaEntidad> agenciasArchivo = LeerJson<List<AgenciaEntidad>>("Agencias.json");
            List<TransportistaLocalEntidad> transportistasArchivo = LeerJson<List<TransportistaLocalEntidad>>("TransportistasLocales.json");
            List<GuiaEntidad> guiasArchivo = LeerJson<List<GuiaEntidad>>("Guias.json");

            CentrosDeDistribucion = new List<CentroDistribucion>();
            foreach (var cd in cdsArchivo)
            {
                CentrosDeDistribucion.Add(new CentroDistribucion
                {
                    idCD = cd.idCD,
                    nombre = cd.nombre
                });
            }

            CdEmisor = BuscarCD(Program.CodigoCDActual);
            if (CdEmisor == null && CentrosDeDistribucion.Count > 0)
            {
                CdEmisor = CentrosDeDistribucion[0];
            }

            Agencias = new List<Agencia>();
            foreach (var ag in agenciasArchivo)
            {
                Agencias.Add(new Agencia
                {
                    idAgencia = ag.idAgencia,
                    razonSocial = ag.razonSocial,
                    calle = ag.calle,
                    altura = ag.altura,
                    piso = ag.piso,
                    codigoPostal = ag.codigoPostal,
                    ciudad = ag.ciudad,
                    idCD = ag.idCD
                });
            }

            Transportistas = new List<TransportistaLocal>();
            foreach (var t in transportistasArchivo)
            {
                Transportistas.Add(new TransportistaLocal
                {
                    dniTransportista = t.dniTransportista,
                    nombre = t.nombre,
                    apellido = t.apellido,
                    idCD = t.idCD,
                    HdrAsignadas = t.HdrAsignadas
                });
            }

            Guias = new List<Guia>();
            foreach (var g in guiasArchivo)
            {
                bool esEnCDDestino = g.estado == Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnCDDestino &&
                                     g.idCDDestino == CdEmisor.idCD;

                bool esAdmitidaLocal = g.estado == Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Admitida &&
                                       g.idCDOrigen == CdEmisor.idCD &&
                                       g.idCDDestino == CdEmisor.idCD;

                if (!esEnCDDestino && !esAdmitidaLocal)
                {
                    continue;
                }

                Guias.Add(new Guia
                {
                    NroGuia = g.NroGuia,
                    modalidadEntrega = ConvertirModalidadEntrega(g.modalidadEntrega),
                    estado = ConvertirEstadoGuia(g.estado),
                    idCDOrigen = g.idCDOrigen,
                    idCDDestino = g.idCDDestino,
                    Destinatario = new DestinatarioGuia
                    {
                        Dni = g.Destinatario.Dni,
                        nombre = g.Destinatario.nombre,
                        apellido = g.Destinatario.apellido,
                        calle = g.Destinatario.calle,
                        altura = g.Destinatario.altura,
                        piso = g.Destinatario.piso,
                        codigoPostal = g.Destinatario.codigoPostal,
                        ciudad = g.Destinatario.ciudad
                    },
                    idAgenciaDestino = g.idAgenciaDestino == 0 ? (int?)null : g.idAgenciaDestino
                });
            }
        }

        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (var cd in CentrosDeDistribucion)
                if (cd.idCD == idCD) return cd;

            return null;
        }

        public Agencia BuscarAgencia(int idAgencia)
        {
            foreach (var agencia in Agencias)
                if (agencia.idAgencia == idAgencia) return agencia;

            return null;
        }

        private GuiaEntidad BuscarGuiaEntidad(List<GuiaEntidad> guiasArchivo, string nroGuia)
        {
            foreach (var g in guiasArchivo)
                if (g.NroGuia == nroGuia) return g;

            return null;
        }

        private TransportistaLocalEntidad BuscarTransportistaEntidad(List<TransportistaLocalEntidad> transportistasArchivo, int dni)
        {
            foreach (var t in transportistasArchivo)
                if (t.dniTransportista == dni) return t;

            return null;
        }

        private int ProximoNroHDR(List<HojaDeRutaDistribucionEntidad> hojasArchivo)
        {
            int max = 0;

            foreach (var hdr in hojasArchivo)
                if (hdr.NroHDR > max) max = hdr.NroHDR;

            return max + 1;
        }

        public HojaDeRutaDistribucionEntidad GenerarHDR(List<Guia> guias, TransportistaLocal transportista, DateTime fecha)
        {
            List<HojaDeRutaDistribucionEntidad> hojasArchivo = LeerJson<List<HojaDeRutaDistribucionEntidad>>("HojasDeRutaDistribucion.json");
            List<GuiaEntidad> guiasArchivo = LeerJson<List<GuiaEntidad>>("Guias.json");
            List<TransportistaLocalEntidad> transportistasArchivo = LeerJson<List<TransportistaLocalEntidad>>("TransportistasLocales.json");

            var nuevaHDR = new HojaDeRutaDistribucionEntidad();
            nuevaHDR.NroHDR = ProximoNroHDR(hojasArchivo);
            nuevaHDR.Fecha = fecha;
            nuevaHDR.estado = Prototipos_TUTASA.Auxiliares.EstadoHojaDeRutaEnum.Generada;
            nuevaHDR.dniTransportistaAsignado = transportista.dniTransportista;
            nuevaHDR.motivoNoCumplida = Prototipos_TUTASA.Auxiliares.MotivoNoCumplidaDistribucionEnum.DestinatarioAusente;

            Guia guiaRef = guias[0];

            if (guiaRef.modalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
            {
                nuevaHDR.Calle = guiaRef.Destinatario.calle;
                nuevaHDR.Altura = guiaRef.Destinatario.altura;
                nuevaHDR.Piso = guiaRef.Destinatario.piso;
                nuevaHDR.CodigoPostal = guiaRef.Destinatario.codigoPostal;
                nuevaHDR.Destinatario = guiaRef.Destinatario.nombre + " " + guiaRef.Destinatario.apellido;
                nuevaHDR.idAgenciaDestino = null;
            }
            else
            {
                Agencia agencia = BuscarAgencia(guiaRef.idAgenciaDestino.Value);

                nuevaHDR.Calle = agencia.calle;
                nuevaHDR.Altura = agencia.altura;
                nuevaHDR.Piso = agencia.piso;
                nuevaHDR.CodigoPostal = agencia.codigoPostal;
                nuevaHDR.Destinatario = agencia.razonSocial;
                nuevaHDR.idAgenciaDestino = agencia.idAgencia;
            }

            foreach (var guia in guias)
            {
                nuevaHDR.DetalleGuias.Add(guia.NroGuia);

                guia.estado = EstadoGuiaEnum.EnDistribucion;

                GuiaEntidad guiaEntidad = BuscarGuiaEntidad(guiasArchivo, guia.NroGuia);
                if (guiaEntidad != null)
                {
                    guiaEntidad.estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnDistribucion;

                    guiaEntidad.Historial.Add(new HistorialEstadoGuia
                    {
                        FechaCambio = DateTime.Today,
                        Estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.EnDistribucion,
                        Donde = CdEmisor.nombre
                    });
                }
            }

            transportista.HdrAsignadas++;

            TransportistaLocalEntidad transportistaEntidad = BuscarTransportistaEntidad(transportistasArchivo, transportista.dniTransportista);
            if (transportistaEntidad != null)
            {
                transportistaEntidad.HdrAsignadas++;
            }

            hojasArchivo.Add(nuevaHDR);

            HojaDeRutaDistribucionAlmacen.hojasDeRutaDistribucion = hojasArchivo;
            GuiaAlmacen.Guias = guiasArchivo;
            TransportistaLocalAlmacen.transportistas = transportistasArchivo;

            GuardarJson("HojasDeRutaDistribucion.json", hojasArchivo);
            GuardarJson("Guias.json", guiasArchivo);
            GuardarJson("TransportistasLocales.json", transportistasArchivo);

            return nuevaHDR;
        }

        private ModalidadEntregaEnum ConvertirModalidadEntrega(Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum modalidad)
        {
            return (ModalidadEntregaEnum)Enum.Parse(typeof(ModalidadEntregaEnum), modalidad.ToString());
        }

        private EstadoGuiaEnum ConvertirEstadoGuia(Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum estado)
        {
            return (EstadoGuiaEnum)Enum.Parse(typeof(EstadoGuiaEnum), estado.ToString());
        }

        private T LeerJson<T>(string nombreArchivo) where T : new()
        {
            string ruta = Path.Combine(ObtenerCarpetaDatos(), nombreArchivo);

            if (!File.Exists(ruta))
            {
                return new T();
            }

            string json = File.ReadAllText(ruta);
            T datos = JsonSerializer.Deserialize<T>(json, ObtenerOpcionesJson());

            if (datos == null)
            {
                return new T();
            }

            return datos;
        }

        private void GuardarJson<T>(string nombreArchivo, T datos)
        {
            string carpetaDatos = ObtenerCarpetaDatos();

            if (!Directory.Exists(carpetaDatos))
            {
                Directory.CreateDirectory(carpetaDatos);
            }

            string ruta = Path.Combine(carpetaDatos, nombreArchivo);
            string json = JsonSerializer.Serialize(datos, ObtenerOpcionesJson());

            File.WriteAllText(ruta, json);
        }

        private JsonSerializerOptions ObtenerOpcionesJson()
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            opciones.Converters.Add(new JsonStringEnumConverter());

            return opciones;
        }

        private string ObtenerCarpetaDatos()
        {
            DirectoryInfo directorio = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            while (directorio != null)
            {
                string archivoProyecto = Path.Combine(directorio.FullName, "Prototipos_TUTASA.csproj");

                if (File.Exists(archivoProyecto))
                {
                    return Path.Combine(directorio.FullName, "DATOS");
                }

                directorio = directorio.Parent;
            }

            directorio = new DirectoryInfo(Directory.GetCurrentDirectory());

            while (directorio != null)
            {
                string archivoProyecto = Path.Combine(directorio.FullName, "Prototipos_TUTASA.csproj");

                if (File.Exists(archivoProyecto))
                {
                    return Path.Combine(directorio.FullName, "DATOS");
                }

                directorio = directorio.Parent;
            }

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATOS");
        }
    }
}