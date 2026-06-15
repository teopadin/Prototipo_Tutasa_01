using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Imposición.Imposición_CD
{
    internal class ModeloImposicionCD
    {
        public List<Cliente> Clientes { get; set; }
        public List<Agencia> Agencias { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public List<Guia> Guias { get; set; }

        public ModeloImposicionCD()
        {
            CentrosDeDistribucion = new List<CentroDistribucion>();
            foreach (var cdEntidad in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                CentrosDeDistribucion.Add(new CentroDistribucion
                {
                    idCD = cdEntidad.idCD,
                    nombre = cdEntidad.nombre
                });
            }

            CdOrigen = BuscarCD(Program.CodigoCDActual);
            if (CdOrigen == null && CentrosDeDistribucion.Count > 0)
            {
                CdOrigen = CentrosDeDistribucion[0];
            }

            Clientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                Clientes.Add(new Cliente
                {
                    razonSocial = clienteEntidad.razonSocial,
                    cuit = clienteEntidad.cuit,
                    telefono = clienteEntidad.telefono,
                    calle = clienteEntidad.calle,
                    altura = clienteEntidad.altura,
                    piso = clienteEntidad.piso,
                    codigoPostal = clienteEntidad.codigoPostal,
                    ciudad = clienteEntidad.ciudad
                });
            }

            Agencias = new List<Agencia>();
            foreach (var agenciaEntidad in AgenciaAlmacen.Agencias)
            {
                Agencias.Add(new Agencia
                {
                    idAgencia = agenciaEntidad.idAgencia,
                    razonSocial = agenciaEntidad.razonSocial,
                    idCD = agenciaEntidad.idCD
                });
            }

            Guias = new List<Guia>();
            foreach (var guiaEntidad in GuiaAlmacen.Guias)
            {
                if (guiaEntidad.TipoImposicion == Prototipos_TUTASA.Auxiliares.TipoImposicionEnum.CD)
                {
                    Guias.Add(new Guia
                    {
                        NroGuia = guiaEntidad.NroGuia
                    });
                }
            }
        }

        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (CentroDistribucion cd in CentrosDeDistribucion)
            {
                if (cd.idCD == idCD)
                    return cd;
            }

            return null;
        }

        public CentroDistribucion ObtenerCentroDistribucionPorCiudad(string ciudad)
        {
            string ciudadNormalizada = (ciudad ?? string.Empty).ToLower();

            if (ciudadNormalizada.Contains("córdoba") || ciudadNormalizada.Contains("cordoba"))
                return CentrosDeDistribucion[1];

            if (ciudadNormalizada.Contains("tucumán") || ciudadNormalizada.Contains("tucuman"))
                return CentrosDeDistribucion[2];

            if (ciudadNormalizada.Contains("corrientes"))
                return CentrosDeDistribucion[3];

            if (ciudadNormalizada.Contains("neuquén") || ciudadNormalizada.Contains("neuquen"))
                return CentrosDeDistribucion[4];

            if (ciudadNormalizada.Contains("viedma"))
                return CentrosDeDistribucion[5];

            return CdOrigen;
        }

        public Guia RegistrarImposicion(
            TipoBultoEnum tipoBulto,
            ModalidadEntregaEnum modalidadEntrega,
            DestinatarioGuia destinatario,
            CentroDistribucion cdDestino,
            Agencia agenciaDestino,
            Cliente cliente)
        {
            List<Prototipos_TUTASA.Almacenes.GuiaEntidad> guiasArchivo = LeerGuiasDesdeArchivo();

            string nroGuia = GenerarNumeroGuia(guiasArchivo);

            Guia guia = new Guia
            {
                NroGuia = nroGuia
            };

            Prototipos_TUTASA.Almacenes.GuiaEntidad guiaEntidad = new Prototipos_TUTASA.Almacenes.GuiaEntidad
            {
                NroGuia = nroGuia,
                IdCliente = ObtenerIdCliente(cliente),
                TipoImposicion = Prototipos_TUTASA.Auxiliares.TipoImposicionEnum.CD,
                idCDOrigen = CdOrigen.idCD,
                idAgenciaOrigen = 0,
                idCDActual = CdOrigen.idCD,
                modalidadEntrega = ConvertirModalidadEntrega(modalidadEntrega),
                idCDDestino = cdDestino != null ? cdDestino.idCD : CdOrigen.idCD,
                idAgenciaDestino = agenciaDestino != null ? agenciaDestino.idAgencia : 0,
                Destinatario = new Prototipos_TUTASA.Almacenes.DestinatarioGuia
                {
                    Dni = destinatario.dni,
                    nombre = destinatario.nombre,
                    apellido = destinatario.apellido,
                    calle = destinatario.calle ?? string.Empty,
                    altura = destinatario.altura,
                    piso = destinatario.piso ?? string.Empty,
                    codigoPostal = destinatario.codigoPostal ?? string.Empty,
                    ciudad = destinatario.ciudad ?? string.Empty,
                    telefono = destinatario.telefono
                },
                TipoBulto = ConvertirTipoBulto(tipoBulto),
                EquivalenteS = ObtenerEquivalenteS(tipoBulto),
                estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Admitida
            };

            guiaEntidad.Historial.Add(new Prototipos_TUTASA.Almacenes.HistorialEstadoGuia
            {
                FechaCambio = DateTime.Today,
                Estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Admitida,
                Donde = CdOrigen.nombre
            });

            guiasArchivo.Add(guiaEntidad);
            GuardarGuiasEnArchivo(guiasArchivo);

            GuiaAlmacen.Guias = guiasArchivo;
            Guias.Add(guia);

            return guia;
        }

        private List<Prototipos_TUTASA.Almacenes.GuiaEntidad> LeerGuiasDesdeArchivo()
        {
            string ruta = ObtenerRutaGuiasJson();

            if (!File.Exists(ruta))
                return new List<Prototipos_TUTASA.Almacenes.GuiaEntidad>();

            string json = File.ReadAllText(ruta);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Prototipos_TUTASA.Almacenes.GuiaEntidad>();

            return JsonSerializer.Deserialize<List<Prototipos_TUTASA.Almacenes.GuiaEntidad>>(json);
        }

        private void GuardarGuiasEnArchivo(List<Prototipos_TUTASA.Almacenes.GuiaEntidad> guias)
        {
            string ruta = ObtenerRutaGuiasJson();

            string json = JsonSerializer.Serialize(guias, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(ruta, json);
        }

        private string ObtenerRutaGuiasJson()
        {
            DirectoryInfo carpeta = new DirectoryInfo(AppContext.BaseDirectory);

            while (carpeta != null)
            {
                string[] archivosProyecto = Directory.GetFiles(carpeta.FullName, "*.csproj");

                if (archivosProyecto.Length > 0)
                {
                    string carpetaDatos = Path.Combine(carpeta.FullName, "DATOS");
                    string ruta = Path.Combine(carpetaDatos, "Guias.json");

                    if (!Directory.Exists(carpetaDatos))
                        Directory.CreateDirectory(carpetaDatos);

                    return ruta;
                }

                carpeta = carpeta.Parent;
            }

            return Path.Combine(AppContext.BaseDirectory, "DATOS", "Guias.json");
        }

        private int ObtenerIdCliente(Cliente cliente)
        {
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                if (clienteEntidad.cuit == cliente.cuit)
                    return clienteEntidad.idCliente;
            }

            return 0;
        }

        private Prototipos_TUTASA.Auxiliares.TiposBultoEnum ConvertirTipoBulto(TipoBultoEnum tipoBulto)
        {
            return (Prototipos_TUTASA.Auxiliares.TiposBultoEnum)Enum.Parse(
                typeof(Prototipos_TUTASA.Auxiliares.TiposBultoEnum),
                tipoBulto.ToString()
            );
        }

        private Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum ConvertirModalidadEntrega(ModalidadEntregaEnum modalidadEntrega)
        {
            return (Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum)Enum.Parse(
                typeof(Prototipos_TUTASA.Auxiliares.ModalidadEntregaEnum),
                modalidadEntrega.ToString()
            );
        }

        private int ObtenerEquivalenteS(TipoBultoEnum tipoBulto)
        {
            if (tipoBulto == TipoBultoEnum.S) return 1;
            if (tipoBulto == TipoBultoEnum.M) return 2;
            if (tipoBulto == TipoBultoEnum.L) return 4;
            if (tipoBulto == TipoBultoEnum.XL) return 8;

            return 1;
        }

        private string GenerarNumeroGuia(List<Prototipos_TUTASA.Almacenes.GuiaEntidad> guias)
        {
            string prefijo = "CD" + CdOrigen.idCD.ToString("00") + "-";
            int mayorNumero = 0;

            foreach (var guiaEntidad in guias)
            {
                if (!guiaEntidad.NroGuia.StartsWith(prefijo))
                    continue;

                string parteNumero = guiaEntidad.NroGuia.Substring(prefijo.Length);

                if (int.TryParse(parteNumero, out int numero) && numero > mayorNumero)
                    mayorNumero = numero;
            }

            return prefijo + (mayorNumero + 1).ToString("0000");
        }
    }
}