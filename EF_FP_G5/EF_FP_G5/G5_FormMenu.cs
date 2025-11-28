using EF_FP_G5.Clases;
using EF_FP_G5.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_G5
{
    public partial class G5_FormMenu : Form
    {
        public G5_FormMenu()
        {
            InitializeComponent();
        }
        private void G5_btnRegistrar_Click(object sender, EventArgs e)
        {
            new G5_FormRegistrarCliente().ShowDialog();
        }

        private void G5_btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            new G5_FormRegistrarProducto().ShowDialog();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            new G5_FormMostrarClientes().ShowDialog();
        }

        private void G5_btnMostrarProductos_Click(object sender, EventArgs e)
        {
            new G5_FormMostrarProductos().ShowDialog();

        }

        private void G5_btnAsignarProducto_Click(object sender, EventArgs e)
        {
            new G5_FormAsignarProducto().ShowDialog();
        }

    }
}
