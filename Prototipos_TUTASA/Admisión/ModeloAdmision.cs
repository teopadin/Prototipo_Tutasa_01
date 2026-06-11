using Prototipos_TUTASA.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class ModeloAdmision
    {
        // CD desde el que se realiza la admisión (lo reconoce el sistema)
        private int idCDAdmisionActual = 1;

        private List<Cliente> clientes;

        private List<CentroDistribucion> cds;

        private List<CuadroTarifario> cuadroTarifario;

        private List<CostoExtra> costosExtra;

        private List<Guia> guias;

        public ModeloAdmision()
        {
            clientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                clientes.Add(new Cliente
                {
                    idCliente = clienteEntidad.idCliente,
                    razonSocial = clienteEntidad.razonSocial
                });
            }

            cds = new List<CentroDistribucion>();
            foreach (var cdEntidad in CentroDistribucionAlmacen.CentrosDeDistribucion)
            {
                cds.Add(new CentroDistribucion
                {
                    idCD = cdEntidad.idCD,
                    nombre = cdEntidad.nombre
                });
            }

            cuadroTarifario = new List<CuadroTarifario>();
            foreach (var tarifaEntidad in CuadroTarifarioAlmacen.cuadrosTarifarios)
            {
                cuadroTarifario.Add(new CuadroTarifario
                {
                    IdTarifa = tarifaEntidad.IdTarifa,
                    IdCDOrigen = tarifaEntidad.IdCDOrigen,
                    IdCDDestino = tarifaEntidad.IdCDDestino,
                    TipoBulto = (TiposBultoEnum)tarifaEntidad.TipoBulto,
                    PrecioFlete = tarifaEntidad.PrecioFlete
                });
            }

            costosExtra = new List<CostoExtra>();
            foreach (var costoEntidad in CostoExtraAlmacen.costosExtra)
            {
                costosExtra.Add(new CostoExtra
                {
                    TipoCostoExtra = (TipoCostoExtraEnum)costoEntidad.TipoCostoExtra,
                    Monto = costoEntidad.Monto
                });
            }

            guias = new List<Guia>();
            foreach (var guiaEntidad in GuiaAlmacen.Guias)
            {
                guias.Add(new Guia
                {
                    NroGuia = guiaEntidad.NroGuia,
                    IdCliente = guiaEntidad.IdCliente,
                    TipoImposicion = (TipoImposicionEnum)guiaEntidad.TipoImposicion,
                    IdCDDestino = guiaEntidad.idCDDestino,
                    Destinatario = new DestinatarioGuia
                    {
                        Dni = guiaEntidad.Destinatario.Dni,
                        nombre = guiaEntidad.Destinatario.nombre,
                        apellido = guiaEntidad.Destinatario.apellido
                    },
                    TipoBulto = (TiposBultoEnum)guiaEntidad.TipoBulto,
                    ModalidadEntrega = (ModalidadEntregaEnum)guiaEntidad.modalidadEntrega,
                    estado = (EstadoGuiaEnum)guiaEntidad.estado
                });
            }
        }

        // Busca una guía por su número. Devuelve null si no existe.
        public Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia guia in guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    return guia;
                }
            }
            return null;
        }

        // Busca un cliente por su ID.
        public Cliente BuscarCliente(int idCliente)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.idCliente == idCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        // Busca un CD por su ID.
        public CentroDistribucion BuscarCD(int idCD)
        {
            foreach (CentroDistribucion cd in cds)
            {
                if (cd.idCD == idCD)
                {
                    return cd;
                }
            }
            return null;
        }

        // Indica si la guía está en un estado que permite ser admitida
        public bool EsAdmisible(Guia guia)
        {
            return guia.estado == EstadoGuiaEnum.Retirada;
        }

        // Busca la tarifa por cliente que matchea la combinación cliente/CDOrigen/CDDestino/tipoBulto
        public CuadroTarifario BuscarTarifa(int idCDOrigen, int idCDDestino, TiposBultoEnum tipoBulto)
        {
            foreach (CuadroTarifario tarifa in cuadroTarifario)
            {
                if (
                       tarifa.IdCDOrigen == idCDOrigen
                    && tarifa.IdCDDestino == idCDDestino
                    && tarifa.TipoBulto == tipoBulto)
                {
                    return tarifa;
                }
            }
            return null;
        }

        // Busca el costo extra fijo por tipo
        public CostoExtra BuscarCostoExtra(TipoCostoExtraEnum tipo)
        {
            foreach (CostoExtra costo in costosExtra)
            {
                if (costo.TipoCostoExtra == tipo)
                {
                    return costo;
                }
            }
            return null;
        }

        // Calcula la tarifa total de una guía: flete + extras según TipoImposicion y ModalidadEntrega
        public TarifaCalculadaGuia CalcularTarifa(Guia guia)
        {
            TarifaCalculadaGuia tarifaCalc = new TarifaCalculadaGuia();

            // Flete según combinación cliente/origen/destino/bulto
            CuadroTarifario tarifa = BuscarTarifa(idCDAdmisionActual, guia.IdCDDestino, guia.TipoBulto);
            if (tarifa != null)
            {
                tarifaCalc.PrecioFlete = tarifa.PrecioFlete;
            }

            // Extra retiro a domicilio (solo si la imposición fue por CallCenter)
            if (guia.TipoImposicion == TipoImposicionEnum.CallCenter)
            {
                CostoExtra extraRetiro = BuscarCostoExtra(TipoCostoExtraEnum.RetiroDomicilio);
                if (extraRetiro != null)
                {
                    tarifaCalc.ExtraRetiroDomicilio = extraRetiro.Monto;
                }
            }

            // Extra entrega: solo aplica uno según la modalidad
            if (guia.ModalidadEntrega == ModalidadEntregaEnum.EntregaDomicilio)
            {
                CostoExtra extraEntrega = BuscarCostoExtra(TipoCostoExtraEnum.EntregaDomicilio);
                if (extraEntrega != null)
                {
                    tarifaCalc.ExtraEntregaDomicilio = extraEntrega.Monto;
                }
            }
            else if (guia.ModalidadEntrega == ModalidadEntregaEnum.EntregaAgencia)
            {
                CostoExtra extraEntrega = BuscarCostoExtra(TipoCostoExtraEnum.EntregaAgencia);
                if (extraEntrega != null)
                {
                    tarifaCalc.ExtraEntregaAgencia = extraEntrega.Monto;
                }
            }

            tarifaCalc.TarifaTotal = tarifaCalc.PrecioFlete
                                   + tarifaCalc.ExtraRetiroDomicilio
                                   + tarifaCalc.ExtraEntregaDomicilio
                                   + tarifaCalc.ExtraEntregaAgencia;

            return tarifaCalc;
        }
        // Confirma la admisión de una guía
        public void ConfirmarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            // Calcula y guarda la tarifa en la guía (la pantalla no la muestra pero el sistema la necesita)
            guia.TarifaCalculada = CalcularTarifa(guia);

            // Caso especial: el CD destino es el mismo que el CD de admisión Y modalidad es Retiro en CD
            if (guia.IdCDDestino == idCDAdmisionActual && guia.ModalidadEntrega == ModalidadEntregaEnum.EntregaCD)
            {
                guia.estado = EstadoGuiaEnum.PendienteDeRetiroEnCD;
            }
            else
            {
                guia.estado = EstadoGuiaEnum.Admitida;
            }
        }

        // Rechaza la admisión: pasa la guía a "Cancelada"
        public void RechazarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            guia.estado = EstadoGuiaEnum.Cancelada;
        }

        // Métodos de formato para mostrar en pantalla
        public string TextoBulto(TiposBultoEnum bulto)
        {
            if (bulto == TiposBultoEnum.S) return "S (hasta 2.5 kg)";
            if (bulto == TiposBultoEnum.M) return "M (hasta 5 kg)";
            if (bulto == TiposBultoEnum.L) return "L (hasta 10 kg)";
            if (bulto == TiposBultoEnum.XL) return "XL (hasta 20 kg)";
            return "";
        }

        public string TextoModalidad(ModalidadEntregaEnum modalidad)
        {
            if (modalidad == ModalidadEntregaEnum.EntregaDomicilio) return "Entrega a Domicilio";
            if (modalidad == ModalidadEntregaEnum.EntregaAgencia) return "Entrega en Agencia";
            if (modalidad == ModalidadEntregaEnum.EntregaCD) return "Entrega en CD";
            return "";
        }
    }
}