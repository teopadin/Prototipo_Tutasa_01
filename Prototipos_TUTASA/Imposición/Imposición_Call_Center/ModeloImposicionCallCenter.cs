using System;
using System.Collections.Generic;
using System.Text;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Imposición.ImposicionCallCenter_v2
{
    internal class ModeloImposicionCallCenter

        {
            public List<Cliente> Clientes { get; set; }
            public List<Agencia> Agencias { get; set; }
            public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
            public List<Guia> Guias { get; set; }

        public ModeloImposicionCallCenter()
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
                    Piso = clienteEntidad.piso,
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
                if (guiaEntidad.TipoImposicion == Prototipos_TUTASA.Auxiliares.TipoImposicionEnum.CallCenter)
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
        public Guia RegistrarImposicion(TipoBultoEnum tipoBulto, ModalidadEntregaEnum modalidadEntrega, DestinatarioGuia destinatario, CentroDistribucion cdOrigen, CentroDistribucion cdDestino, Agencia agenciaDestino)
        {
            Guia guia = new Guia
            {
                NroGuia = GenerarNumeroGuia(cdOrigen),
            };

            Guias.Add(guia);

            return guia;
        }

        private string GenerarNumeroGuia(CentroDistribucion cdOrigen)
        {
            return "CD" + cdOrigen.idCD.ToString("00") + "-" + (Guias.Count + 1).ToString("0000");
        }
    }
}
