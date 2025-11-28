using EF_FP_G5.Clases;
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
    public partial class G5_FormMostrarClientes : Form
    {
        public G5_FormMostrarClientes()
        {
            InitializeComponent();
        }

        private void G5_FormMostrarClientes_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }
        private void ActualizarListaClientes()
        {
            G5_dgvClientes.DataSource = null;
            G5_dgvClientes.DataSource = Global.listaClientes;
        }
    }
}
