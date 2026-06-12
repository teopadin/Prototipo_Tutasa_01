using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeDistribucionEnAgencia
{
    internal class ModeloRecibirHDRDistribucionAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public List<HojaDeRutaDistribucion> HojasDeRutaDistribucion { get; set; }

        public HojaDeRutaDistribucion HdrActual { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public List<Guia> Guias { get; set; }
        public List<Agencia> Agencias { get; set; }

        public ModeloRecibirHDRDistribucionAgencia()
        {
            
            // Agencias
            var agencia1 = new Agencia
            {
                idAgencia = 1,
                razonSocial = "Agencia Norte SA",
            };

            var agencia2 = new Agencia
            {
                idAgencia = 2,
                razonSocial = "Agencia Sur SRL",

            };


            // Simulación operador logueado
            AgenciaLogueada = agencia1;

            Agencias = new List<Agencia>
            {
                agencia1,
                agencia2
            };

            // Transportistas
            var t1 = new TransportistaLocal
            {
                dniTransportistaAsignado = 40497355,
                nombre = "Carlos",
                apellido = "Gomez",
            };

            var t2 = new TransportistaLocal
            {
                dniTransportistaAsignado = 35397312,
                nombre = "Laura",
                apellido = "Martinez",
            };
            
            Transportistas = new List<TransportistaLocal>
            {
                 t1,
                 t2
            };

            // Guías
            var g1 = new Guia
            {
                NroGuia = "GD-0001",
                TipoBulto = TiposBultoEnum.S,
                idAgenciaDestino = agencia1.idAgencia,
                estado = EstadoGuiaEnum.EnDistribucion
            };

            var g2 = new Guia
            {
                NroGuia = "GD-0002",
                TipoBulto = TiposBultoEnum.M,
                idAgenciaDestino = agencia1.idAgencia,
                estado = EstadoGuiaEnum.EnDistribucion
            };

            var g3 = new Guia
            {
                NroGuia = "GD-0003",
                TipoBulto = TiposBultoEnum.L,
                idAgenciaDestino = agencia1.idAgencia,
                estado = EstadoGuiaEnum.EnDistribucion
            };

            var g4 = new Guia
            {
                NroGuia = "GD-0004",
                TipoBulto = TiposBultoEnum.XL,
                idAgenciaDestino = agencia2.idAgencia,
                estado = EstadoGuiaEnum.EnDistribucion
            };
            Guias = new List<Guia>
            {
                g1,
                g2,
                g3,
                g4
            };

            // HDR válida
            var hdr1 = new HojaDeRutaDistribucion
            {
                NroHDR = 1001,
                idAgenciaDestino = agencia1.idAgencia,
                dniTransportistaAsignado = t1.dniTransportistaAsignado,
                DetalleGuias = new List<string>
                {
                    g1.NroGuia,
                    g2.NroGuia
                },
                estado = EstadoHojaDeRutaEnum.EnCurso
            };

            // HDR válida adicional
            var hdr2 = new HojaDeRutaDistribucion
            {
                NroHDR = 1002,
                idAgenciaDestino = agencia1.idAgencia,
                dniTransportistaAsignado = t2.dniTransportistaAsignado,
                DetalleGuias = new List<string>
                {
                    g3.NroGuia
                },
                estado = EstadoHojaDeRutaEnum.EnCurso
            };

            // HDR de otra agencia (Excepción 3)
            var hdr3 = new HojaDeRutaDistribucion
            {
                NroHDR = 1003,
                idAgenciaDestino = agencia2.idAgencia,
                dniTransportistaAsignado = t1.dniTransportistaAsignado,
                DetalleGuias = new List<string>
                {
                    g4.NroGuia
                },
                estado = EstadoHojaDeRutaEnum.EnCurso
            };

            // HDR ya recibida (Excepción 4)
            var hdr4 = new HojaDeRutaDistribucion
            {
                NroHDR = 1004,
                idAgenciaDestino = agencia1.idAgencia,
                dniTransportistaAsignado = t2.dniTransportistaAsignado,
                DetalleGuias = new List<string>
                {
                    g1.NroGuia
                },
                estado = EstadoHojaDeRutaEnum.Recibida,
                Fecha = new DateTime(2026, 5, 25)
            };

            HojasDeRutaDistribucion = new List<HojaDeRutaDistribucion>
            {
                hdr1,
                hdr2,
                hdr3,
                hdr4
            };

        
        }
        public TransportistaLocal BuscarTransportista(int dni)
        {
            return Transportistas.FirstOrDefault(t => t.dniTransportistaAsignado == dni);
        }
        public Guia BuscarGuia(string nroGuia)
        {
            return Guias.FirstOrDefault(g => g.NroGuia == nroGuia);
        }
        public Agencia BuscarAgencia(int? idAgencia)
        {
            return Agencias.FirstOrDefault(a => a.idAgencia == idAgencia);
        }
    }

}
