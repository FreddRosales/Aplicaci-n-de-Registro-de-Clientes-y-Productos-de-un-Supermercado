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
    public partial class G5_FormMostrarProductos : Form
    {
        public G5_FormMostrarProductos()
        {
            InitializeComponent();
        }

        private void G5_btnMostrarProducto_Click(object sender, EventArgs e)
        {
            G5_FormMostrarProductos f = new G5_FormMostrarProductos();
            f.ShowDialog();
        }
       
    }
}
