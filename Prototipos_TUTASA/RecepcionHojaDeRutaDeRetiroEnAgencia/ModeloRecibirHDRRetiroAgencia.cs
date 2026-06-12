using Prototipos_TUTASA.Generación_HDR.Generación_Hoja_De_Ruta_Retiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipos_TUTASA.RecepcionHojaDeRutaDeRetiroEnAgencia
{
    internal class ModeloRecibirHDRRetiroAgencia
    {
        public Agencia AgenciaLogueada { get; set; }

        public HojaDeRutaRetiro HdrActual { get; set; }

        public List<HojaDeRutaRetiro> HojasDeRutaRetiro { get; set; }
        public List<TransportistaLocal> Transportistas { get; set; }
        public List<Guia> Guias { get; set; }
        public List<Agencia> Agencias { get; set; }

        public ModeloRecibirHDRRetiroAgencia()
        {

            // Transportistas

            var t1 = new TransportistaLocal
            {
                dniTransportistaAsignado= 21412444,
                nombre = "Carlos",
                apellido = "Gomez"
            };

            var t2 = new TransportistaLocal
            {
                dniTransportistaAsignado = 22443311,
                nombre = "Laura",
                apellido = "Martinez"
            };

            Transportistas = new List<TransportistaLocal>
            {
                 t1,
                 t2
            };


            // Agencias
            var agencia1 = new Agencia
            {
                idAgencia = 1,
                razonSocial = "Agencia Norte SA"
            };

            var agencia2 = new Agencia
            {
                idAgencia = 2,
                razonSocial = "Agencia Sur SRL"
            };

            AgenciaLogueada = agencia1;
            
            Agencias = new List<Agencia>
            {
                agencia1,
                agencia2
            };

            // Guías
            var guia1 = new Guia
            {
                NroGuia = "A001-0001",
                TipoBulto = TiposBultoEnum.S,
                idAgenciaOrigen = agencia1.idAgencia
            };

            var guia2 = new Guia
            {
                NroGuia = "A001-0002",
                TipoBulto = TiposBultoEnum.XL,
                idAgenciaOrigen = agencia1.idAgencia
            };

            var guia3 = new Guia
            {
                NroGuia = "A002-0001",
                TipoBulto = TiposBultoEnum.M,
                idAgenciaOrigen = agencia2.idAgencia
            };
            Guias = new List<Guia>
            {
                    guia1,
                    guia2,
                    guia3
            };
            // HDR válida
            var hdr1 = new HojaDeRutaRetiro
            {
                NroHDR = 1001,
                idAgenciaOrigen = agencia1.idAgencia,
                dniTransportistaAsignado = t1.dniTransportistaAsignado,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<string>
                {
                    guia1.NroGuia,
                    guia2.NroGuia
                }
            };

            // HDR de otra agencia
            var hdr2 = new HojaDeRutaRetiro
            {
                NroHDR = 1002,
                idAgenciaOrigen = agencia2.idAgencia,
                dniTransportistaAsignado = t2.dniTransportistaAsignado,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<string>
                {
                    guia3.NroGuia   
                }
            };

            // HDR ya recibida
            var hdr3 = new HojaDeRutaRetiro
            {
                NroHDR = 1003,
                Fecha = new DateTime(2026, 5, 25),
                idAgenciaOrigen = agencia1.idAgencia,
                dniTransportistaAsignado = t1.dniTransportistaAsignado,
                estado = EstadoHojaDeRutaEnum.Recibida,
                DetalleGuias = new List<string>
                {
                    guia1.NroGuia
                }
            };
            HojasDeRutaRetiro = new List<HojaDeRutaRetiro>
            {
                hdr1,
                hdr2,
                hdr3
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
