using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipos_TUTASA
{
    public partial class ConsultarEstadoPedido : Form
    {
        public ConsultarEstadoPedido()
        {
            InicializarComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroPedido = txtNumeroPedido.Text.Trim();

            if (string.IsNullOrEmpty(numeroPedido))
            {
                MessageBox.Show("Por favor, ingrese un número de pedido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TODO: Implementar lógica para buscar el estado del pedido
            // Esto debería conectarse a una base de datos o servicio API
            CargarEstadoPedido(numeroPedido);
        }

        private void CargarEstadoPedido(string numeroPedido)
        {
            // Ejemplo de datos (estos deberían venir de una base de datos)
            dgvEstado.Rows.Clear();

            // Simulación de búsqueda
            if (numeroPedido == "0")
            {
                MessageBox.Show("Pedido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar ejemplo de datos
            dgvEstado.Rows.Add(
                numeroPedido,
                DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd"),
                "En Tránsito",
                "El pedido está en camino hacia el destino"
            );
        }
    }
}
