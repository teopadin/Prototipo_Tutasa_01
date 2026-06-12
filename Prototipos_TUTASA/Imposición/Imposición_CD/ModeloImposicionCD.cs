using System;
using System.Collections.Generic;
using System.Text;
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

        public Guia RegistrarImposicion(TipoBultoEnum tipoBulto, ModalidadEntregaEnum modalidadEntrega, DestinatarioGuia destinatario, CentroDistribucion cdDestino, Agencia agenciaDestino)
        {
            Guia guia = new Guia
            {
                NroGuia = GenerarNumeroGuia(),
            };

            Guias.Add(guia);
            return guia;
        }

        private string GenerarNumeroGuia()
        {
            return "CD" + CdOrigen.idCD.ToString("00") + "-" + (Guias.Count + 1).ToString("0000");
        }
    }
}
