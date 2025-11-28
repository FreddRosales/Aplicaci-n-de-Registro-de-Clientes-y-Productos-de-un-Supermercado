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
    public partial class G5_FormRegistrarProducto : Form
    {
        public G5_FormRegistrarProducto()
        {
            InitializeComponent();
        }

        
        private void G5_btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.G5_Codigo = G5_txtCodigo.Text;
            p.G5_Nombre = G5_txtNombreProducto.Text;
            p.G5_Categoria = G5_cmboxCategoria.Text;
            p.G5_Precio = double.Parse(G5_txtPrecioProducto.Text);

            Global.listaProductos.Add(p);
            Archivos.GuardarClientes(Global.listaClientes);
            MessageBox.Show("Producto registrado con éxito");
        }
        
    }

}
