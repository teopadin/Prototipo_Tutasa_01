using Prototipos_TUTASA.Consultar_Estado_Del_Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA.ConsultarEstadoDelPedido_v2
{
    public partial class ConsultarEstadoDelPedido : Form
    {
        private ModeloConsultarEstadoDelPedido modelo = new ModeloConsultarEstadoDelPedido();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroGuia = txtNroGuia.Text;

            if (nroGuia == "")
            {
                MessageBox.Show("Debe ingresar un número de guía");
                return;
            }

            List<HistorialEstadoGuia> historial = modelo.ConsultarEstado(nroGuia);

            if (historial == null)
            {
                MessageBox.Show("La guía N° " + nroGuia + " no existe");
                lstHistorial.Items.Clear();
                return;
            }

            lstHistorial.Items.Clear();
            foreach (HistorialEstadoGuia item in historial)
            {
                ListViewItem fila = new ListViewItem(item.FechaCambio.ToShortDateString());
                fila.SubItems.Add(nroGuia);
                fila.SubItems.Add(modelo.TextoEstado(item.Estado));
                fila.SubItems.Add(modelo.TextoUbicacion(item.Donde));
                lstHistorial.Items.Add(fila);
            }
        }
        public ConsultarEstadoDelPedido()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
