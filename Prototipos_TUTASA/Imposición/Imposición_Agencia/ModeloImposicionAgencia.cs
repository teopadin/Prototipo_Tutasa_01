using System;
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

            AgenciaOperadora = null;
            foreach (Agencia agencia in Agencias)
            {
                if (agencia.idAgencia == Program.CodigoAgenciaActual)
                {
                    AgenciaOperadora = agencia;
                    break;
                }
            }

            if (AgenciaOperadora == null && Agencias.Count > 0)
            {
                AgenciaOperadora = Agencias[0];
            }

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

        public Guia RegistrarImposicion(
            TipoBultoEnum tipoBulto,
            ModalidadEntregaEnum modalidadEntrega,
            DestinatarioGuia destinatario,
            CentroDistribucion cdDestino,
            Agencia agenciaDestino,
            Cliente cliente)
        {
            string nroGuia = GenerarNumeroGuia(GuiaAlmacen.Guias);

            Guia guia = new Guia
            {
                NroGuia = nroGuia
            };

            Prototipos_TUTASA.Almacenes.GuiaEntidad guiaEntidad = new Prototipos_TUTASA.Almacenes.GuiaEntidad
            {
                NroGuia = nroGuia,
                IdCliente = ObtenerIdCliente(cliente),
                TipoImposicion = Prototipos_TUTASA.Auxiliares.TipoImposicionEnum.Agencia,
                idCDOrigen = CdOrigen.idCD,
                idAgenciaOrigen = AgenciaOperadora.idAgencia,
                idCDActual = CdOrigen.idCD,
                modalidadEntrega = ConvertirModalidadEntrega(modalidadEntrega),
                idCDDestino = cdDestino != null ? cdDestino.idCD : CdOrigen.idCD,
                idAgenciaDestino = agenciaDestino != null ? agenciaDestino.idAgencia : 0,
                Destinatario = new Prototipos_TUTASA.Almacenes.DestinatarioGuia
                {
                    Dni = destinatario.Dni,
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
                estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Impuesta
            };

            guiaEntidad.Historial.Add(new Prototipos_TUTASA.Almacenes.HistorialEstadoGuia
            {
                FechaCambio = DateTime.Today,
                Estado = Prototipos_TUTASA.Auxiliares.EstadoGuiaEnum.Impuesta,
                Donde = AgenciaOperadora.razonSocial
            });

            GuiaAlmacen.Guias.Add(guiaEntidad);
            Guias.Add(guia);

            return guia;
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
            string prefijo = "AG" + AgenciaOperadora.idAgencia.ToString("000") + "-";
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