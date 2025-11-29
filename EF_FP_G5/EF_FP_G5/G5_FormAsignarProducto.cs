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
    public partial class G5_FormAsignarProducto : Form
    {
        public G5_FormAsignarProducto()
        {
            InitializeComponent();
        }

        private void G5_FormAsignarProducto_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
        }
        private void CargarClientes()
        {
            G5_cmbBoxCliente.Items.Clear();
            foreach(var c in Global.listaClientes)
            {
                G5_cmbBoxCliente.Items.Add($"{c.G5_NombreC}");
            }
        }
        private void CargarProductos()
        {
            G5_cmbBoxOpcProduc.Items.Clear();
            foreach (var p in Global.listaProductos)
            { 
                G5_cmbBoxOpcProduc.Items.Add($"{p.G5_Nombrep}");
            }
        }

        private void G5_btnPrecio_Click(object sender, EventArgs e)
        {
            int index = G5_cmbBoxOpcProduc.SelectedIndex;
            if(index < 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            Producto p = Global.listaProductos[index];

            G5_lblAsigPrecio.Text = $" s/. {p.G5_Preciop}";
        }

        private void G5_btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar A = new Asignar();
                A.G5_NombreA = G5_cmbBoxCliente.Text;
                A.G5_ProductoA = G5_cmbBoxOpcProduc.Text;

                int cantidad = int.Parse(G5_txtcantidad.Text);
                double precio = double.Parse(G5_lblAsigPrecio.Text.Replace("s/. ", "").Trim());
                double total = precio * cantidad;

                A.G5_CantidadA = cantidad.ToString();
                A.G5_TotalA = total.ToString("F2");

                G5_lblTotal.Text = $"s/. {total:F2}";

                Global.listaAsignar.Add(A);
                Archivos.GuardarAsignaciones(Global.listaAsignar); 

                MessageBox.Show("Producto asignado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
