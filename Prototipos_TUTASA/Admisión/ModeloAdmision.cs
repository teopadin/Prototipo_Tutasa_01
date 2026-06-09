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
        private List<TarifaPorCliente> tarifasPorCliente = new List<TarifaPorCliente>
        {
            new TarifaPorCliente { IdTarifa = 1, IdCliente = 100, IdCDOrigen = 1, IdCDDestino = 2, TipoBulto = TiposBulto.M, PrecioFlete = 1500m },
            new TarifaPorCliente { IdTarifa = 2, IdCliente = 200, IdCDOrigen = 1, IdCDDestino = 1, TipoBulto = TiposBulto.S, PrecioFlete = 500m },
            new TarifaPorCliente { IdTarifa = 3, IdCliente = 300, IdCDOrigen = 1, IdCDDestino = 1, TipoBulto = TiposBulto.L, PrecioFlete = 1000m },
            new TarifaPorCliente { IdTarifa = 4, IdCliente = 100, IdCDOrigen = 1, IdCDDestino = 3, TipoBulto = TiposBulto.XL, PrecioFlete = 3000m }
        };

        // Costos extras fijos del sistema (montos por concepto)
        private List<CostoExtra> costosExtra = new List<CostoExtra>
        {
            new CostoExtra { IdCostoExtra = 1, Tipo = TipoCostoExtra.RetiroDomicilio, Monto = 500m },
            new CostoExtra { IdCostoExtra = 2, Tipo = TipoCostoExtra.EntregaDomicilio, Monto = 800m },
            new CostoExtra { IdCostoExtra = 3, Tipo = TipoCostoExtra.EntregaAgencia, Monto = 400m }
        };

        private List<Guia> guias = new List<Guia>
        {
            // Guía 1: caso general → quedará "Admitida"
            new Guia
            {
                NroGuia = "CD01-0001",
                IdCliente = 100,
                TipoImposicion = TipoImposicion.CallCenter,
                IdCDDestino = 2,
                Destinatario = new DestinatarioGuia { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
                TipoBulto = TiposBulto.M,
                ModalidadEntrega = ModalidadEntrega.EntregaDomicilio,
                Estado = EstadoGuia.Retirada
            },
            // Guía 2: caso especial → quedará "Pendiente de retiro en CD"
            new Guia
            {
                NroGuia = "CD01-0002",
                IdCliente = 200,
                TipoImposicion = TipoImposicion.Agencia,
                IdCDDestino = 1,
                Destinatario = new DestinatarioGuia { Dni = 28444555, Nombre = "María", Apellido = "González" },
                TipoBulto = TiposBulto.S,
                ModalidadEntrega = ModalidadEntrega.EntregaCD,
                Estado = EstadoGuia.Retirada
            },
            // Guía 3: caso general (mismo CD pero no es Retiro en CD)
            new Guia
            {
                NroGuia = "CD01-0003",
                IdCliente = 300,
                TipoImposicion = TipoImposicion.Agencia,
                IdCDDestino = 1,
                Destinatario = new DestinatarioGuia { Dni = 35777888, Nombre = "Carlos", Apellido = "López" },
                TipoBulto = TiposBulto.L,
                ModalidadEntrega = ModalidadEntrega.EntregaDomicilio,
                Estado = EstadoGuia.Retirada
            },
            // Guía 4: estado distinto a "Retirada" → no se puede admitir
            new Guia
            {
                NroGuia = "CD01-0004",
                IdCliente = 100,
                TipoImposicion = TipoImposicion.CD,
                IdCDDestino = 3,
                Destinatario = new DestinatarioGuia { Dni = 30111222, Nombre = "Juan", Apellido = "Pérez" },
                TipoBulto = TiposBulto.XL,
                ModalidadEntrega = ModalidadEntrega.EntregaAgencia,
                Estado = EstadoGuia.Admitida
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
            return guia.Estado == EstadoGuia.Retirada;
        }

        // Busca la tarifa por cliente que matchea la combinación cliente/CDOrigen/CDDestino/tipoBulto
        public TarifaPorCliente BuscarTarifa(int idCliente, int idCDOrigen, int idCDDestino, TiposBulto tipoBulto)
        {
            foreach (TarifaPorCliente tarifa in tarifasPorCliente)
            {
                if (tarifa.IdCliente == idCliente
                    && tarifa.IdCDOrigen == idCDOrigen
                    && tarifa.IdCDDestino == idCDDestino
                    && tarifa.TipoBulto == tipoBulto)
                {
                    return tarifa;
                }
            }
            return null;
        }

        // Busca el costo extra fijo por tipo
        public CostoExtra BuscarCostoExtra(TipoCostoExtra tipo)
        {
            foreach (CostoExtra costo in costosExtra)
            {
                if (costo.Tipo == tipo)
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
            TarifaPorCliente tarifa = BuscarTarifa(guia.IdCliente, idCDAdmisionActual, guia.IdCDDestino, guia.TipoBulto);
            if (tarifa != null)
            {
                tarifaCalc.PrecioFlete = tarifa.PrecioFlete;
            }

            // Extra retiro a domicilio (solo si la imposición fue por CallCenter)
            if (guia.TipoImposicion == TipoImposicion.CallCenter)
            {
                CostoExtra extraRetiro = BuscarCostoExtra(TipoCostoExtra.RetiroDomicilio);
                if (extraRetiro != null)
                {
                    tarifaCalc.ExtraRetiroDomicilio = extraRetiro.Monto;
                }
            }

            // Extra entrega: solo aplica uno según la modalidad
            if (guia.ModalidadEntrega == ModalidadEntrega.EntregaDomicilio)
            {
                CostoExtra extraEntrega = BuscarCostoExtra(TipoCostoExtra.EntregaDomicilio);
                if (extraEntrega != null)
                {
                    tarifaCalc.ExtraEntregaDomicilio = extraEntrega.Monto;
                }
            }
            else if (guia.ModalidadEntrega == ModalidadEntrega.EntregaAgencia)
            {
                CostoExtra extraEntrega = BuscarCostoExtra(TipoCostoExtra.EntregaAgencia);
                if (extraEntrega != null)
                {
                    tarifaCalc.ExtraEntregaAgencia = extraEntrega.Monto;
                }
            }
            // Si es EntregaCD no aplica ningún extra de entrega

            // Total
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
            if (guia.IdCDDestino == idCDAdmisionActual && guia.ModalidadEntrega == ModalidadEntrega.EntregaCD)
            {
                guia.Estado = EstadoGuia.PendienteDeRetiroEnCD;
            }
            else
            {
                guia.Estado = EstadoGuia.Admitida;
            }
        }

        // Rechaza la admisión: pasa la guía a "Cancelada"
        public void RechazarAdmision(string nroGuia, DateTime fechaAdmision)
        {
            Guia guia = BuscarGuia(nroGuia);
            if (guia == null) return;

            guia.Estado = EstadoGuia.Cancelada;
        }

        // Métodos de formato para mostrar en pantalla
        public string TextoBulto(TiposBulto bulto)
        {
            if (bulto == TiposBulto.S) return "S (hasta 2.5 kg)";
            if (bulto == TiposBulto.M) return "M (hasta 5 kg)";
            if (bulto == TiposBulto.L) return "L (hasta 10 kg)";
            if (bulto == TiposBulto.XL) return "XL (hasta 20 kg)";
            return "";
        }

        public string TextoModalidad(ModalidadEntrega modalidad)
        {
            if (modalidad == ModalidadEntrega.EntregaDomicilio) return "Entrega a Domicilio";
            if (modalidad == ModalidadEntrega.EntregaAgencia) return "Entrega en Agencia";
            if (modalidad == ModalidadEntrega.EntregaCD) return "Entrega en CD";
            return "";
        }
    }
}