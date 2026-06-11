using System.Collections.Generic;
using Prototipos_TUTASA.Almacenes;

namespace Prototipos_TUTASA.Imposición.Imposición_Agencia
{
    internal class ModeloImposicionAgencia
    {
        public List<Cliente> Clientes { get; set; }
        public List<Agencia> Agencias { get; set; }
        public List<CentroDistribucion> CentrosDeDistribucion { get; set; }
        public Agencia AgenciaOperadora { get; set; }
        public CentroDistribucion CdOrigen { get; set; }
        public List<Guia> Guias { get; set; }

        public ModeloImposicionAgencia()
        {
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

            CentrosDeDistribucion = new List<CentroDistribucion>();
            foreach (var cdEntidad in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                CentrosDeDistribucion.Add(new CentroDistribucion
                {
                    idCD = cdEntidad.idCD,
                    nombre = cdEntidad.nombre
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

            AgenciaOperadora = Agencias.Count > 0 ? Agencias[0] : null;
            CdOrigen = AgenciaOperadora != null ? BuscarCD(AgenciaOperadora.idCD) : null;

            Guias = new List<Guia>();
            if (AgenciaOperadora != null)
            {
                foreach (var guiaEntidad in GuiaAlmacen.Guias)
                {
                    if (guiaEntidad.idAgenciaOrigen == AgenciaOperadora.idAgencia)
                    {
                        Guias.Add(new Guia
                        {
                            NroGuia = guiaEntidad.NroGuia
                        });
                    }
                }
            }
        }

        public Guia RegistrarImposicion()
        {
            Guia guia = new Guia
            {
                NroGuia = GenerarNumeroGuia()
            };

            Guias.Add(guia);

            return guia;
        }

        private string GenerarNumeroGuia()
        {
            int proximoNumero = Guias.Count + 1;

            return "AG" + AgenciaOperadora.idAgencia.ToString("000") + "-" + proximoNumero.ToString("0000");
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
    }
}
