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
    public partial class G5_FormRegistrarCliente : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public G5_FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void G5_btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.G5_Nombre = G5_txtNombreCliente.Text;
            c.G5_DNI = Validacion.ValidarDNI(G5_txtDNI.Text);
            c.G5_celular = Validacion.ValidarCelular(G5_txtCelular.Text);
            listaClientes.Add(c);
        }
    }
}
