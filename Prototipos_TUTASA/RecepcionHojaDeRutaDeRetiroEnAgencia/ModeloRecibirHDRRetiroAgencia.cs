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

        public ModeloRecibirHDRRetiroAgencia()
        {

            // Transportistas
            var t1 = new TransportistaLocal
            {
                nombre = "Carlos",
                apellido = "Gomez"
            };

            var t2 = new TransportistaLocal
            {
                nombre = "Laura",
                apellido = "Martinez"
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

            // Guías
            var guia1 = new Guia
            {
                NroGuia = "A001-0001",
                TipoBulto = TiposBultoEnum.S,
                AgenciaGuia = agencia1
            };

            var guia2 = new Guia
            {
                NroGuia = "A001-0002",
                TipoBulto = TiposBultoEnum.XL,
                AgenciaGuia = agencia1
            };

            var guia3 = new Guia
            {
                NroGuia = "A002-0001",
                TipoBulto = TiposBultoEnum.M,
                AgenciaGuia = agencia2
            };

            // HDR válida
            var hdr1 = new HojaDeRutaRetiro
            {
                NroHDR = 1001,
                AgenciaHDR = agencia1,
                Transportista = t1,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<Guia>
                {
                    guia1,
                    guia2
                }
            };

            // HDR de otra agencia
            var hdr2 = new HojaDeRutaRetiro
            {
                NroHDR = 1002,
                AgenciaHDR = agencia2,
                Transportista = t2,
                estado = EstadoHojaDeRutaEnum.EnCurso,
                DetalleGuias = new List<Guia>
                {
                    guia3
                }
            };

            // HDR ya recibida
            var hdr3 = new HojaDeRutaRetiro
            {
                NroHDR = 1003,
                Fecha = new DateTime(2026, 5, 25),
                AgenciaHDR = agencia1,
                Transportista = t1,
                estado = EstadoHojaDeRutaEnum.Recibida,
                DetalleGuias = new List<Guia>
                {
                    guia1
                }
            };
            HojasDeRutaRetiro = new List<HojaDeRutaRetiro>
            {
                hdr1,
                hdr2,
                hdr3
            };
        }
    }
}
