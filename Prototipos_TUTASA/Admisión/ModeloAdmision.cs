using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.Admisión
{
    internal class ModeloAdmision
    {
        // CD desde el que se realiza la admisión (lo reconoce el sistema)
        private int idCDAdmisionActual = 1;

        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { IdCliente = 100, RazonSocial = "Tecno Distribuciones S.A." },
            new Cliente { IdCliente = 200, RazonSocial = "Importadora del Sur SRL" },
            new Cliente { IdCliente = 300, RazonSocial = "Comercial Norte" }
        };

        private List<CentroDistribucion> cds = new List<CentroDistribucion>
        {
            new CentroDistribucion { IdCD = 1, Nombre = "CD Buenos Aires" },
            new CentroDistribucion { IdCD = 2, Nombre = "CD Córdoba" },
            new CentroDistribucion { IdCD = 3, Nombre = "CD Mendoza" }
        };

        // Tarifas por cliente: precio del flete según cliente, CDOrigen, CDDestino y tipo de bulto
        private List<CuadroTarifario> cuadroTarifario = new List<CuadroTarifario>
        {
            new CuadroTarifario { IdTarifa = 1, IdCDOrigen = 1, IdCDDestino = 2, TipoBulto = TiposBultoEnum.M, PrecioFlete = 1500m },
            new CuadroTarifario { IdTarifa = 2, IdCDOrigen = 1, IdCDDestino = 1, TipoBulto = TiposBultoEnum.S, PrecioFlete = 500m },
            new CuadroTarifario { IdTarifa = 3, IdCDOrigen = 1, IdCDDestino = 1, TipoBulto = TiposBultoEnum.L, PrecioFlete = 1000m },
            new CuadroTarifario { IdTarifa = 4, IdCDOrigen = 1, IdCDDestino = 3, TipoBulto = TiposBultoEnum.XL, PrecioFlete = 3000m }
        };

        // Costos extras fijos del sistema (montos por concepto)
        private List<CostoExtra> costosExtra = new List<CostoExtra>
        {
            new CostoExtra { TipoCostoExtra = TipoCostoExtraEnum.RetiroDomicilio, Monto = 500m },
            new CostoExtra { TipoCostoExtra = TipoCostoExtraEnum.EntregaDomicilio, Monto = 800m },
            new CostoExtra { TipoCostoExtra = TipoCostoExtraEnum.EntregaAgencia, Monto = 400m }
        };

        private List<Guia> guias = new List<Guia>
        {
            // Guía 1: caso general → quedará "Admitida"
            new Guia
            {
                NroGuia = "CD01-0001",
                IdCliente = 100,
                TipoImposicion = TipoImposicionEnum.CallCenter,
                IdCDDestino = 2,
                Destinatario = new DestinatarioGuia { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
                TipoBulto = TiposBultoEnum.M,
                ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio,
                Estado = EstadoGuiaEnum.Retirada
            },
            // Guía 2: caso especial → quedará "Pendiente de retiro en CD"
            new Guia
            {
                NroGuia = "CD01-0002",
                IdCliente = 200,
                TipoImposicion = TipoImposicionEnum.Agencia,
                IdCDDestino = 1,
                Destinatario = new DestinatarioGuia { Dni = 28444555, Nombre = "María", Apellido = "González" },
                TipoBulto = TiposBultoEnum.S,
                ModalidadEntrega = ModalidadEntregaEnum.EntregaCD,
                Estado = EstadoGuiaEnum.Retirada
            },
            // Guía 3: caso general (mismo CD pero no es Retiro en CD)
            new Guia
            {
                NroGuia = "CD01-0003",
                IdCliente = 300,
                TipoImposicion = TipoImposicionEnum.Agencia,
                IdCDDestino = 1,
                Destinatario = new DestinatarioGuia { Dni = 35777888, Nombre = "Carlos", Apellido = "López" },
                TipoBulto = TiposBultoEnum.L,
                ModalidadEntrega = ModalidadEntregaEnum.EntregaDomicilio,
                Estado = EstadoGuiaEnum.Retirada
            },
            // Guía 4: estado distinto a "Retirada" → no se puede admitir
            new Guia
            {
                NroGuia = "CD01-0004",
                IdCliente = 100,
                TipoImposicion = TipoImposicionEnum.CD,
                IdCDDestino = 3,
                Destinatario = new DestinatarioGuia { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
                TipoBulto = TiposBultoEnum.XL,
                ModalidadEntrega = ModalidadEntregaEnum.EntregaAgencia,
                Estado = EstadoGuiaEnum.Admitida
            }
        };

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
                if (cliente.IdCliente == idCliente)
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
                if (cd.IdCD == idCD)
                {
                    return cd;
                }
            }
            return null;
        }

        // Indica si la guía está en un estado que permite ser admitida
        public bool EsAdmisible(Guia guia)
        {
            return guia.Estado == EstadoGuiaEnum.Retirada;
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
                guia.Estado = EstadoGuiaEnum.PendienteDeRetiroEnCD;
            }
            else
            {
                guia.Estado = EstadoGuiaEnum.Admitida;
            }
        }

        // Rechaza la admisión: pasa la guía a "Cancelada"
        public void RechazarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            guia.Estado = EstadoGuiaEnum.Cancelada;
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