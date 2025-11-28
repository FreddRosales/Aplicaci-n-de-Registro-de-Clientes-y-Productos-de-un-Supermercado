using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FP_G5.Clases
{
    public class Cliente
    {
        public string G5_Nombre { get; set; }
        public string G5_Apellido { get; set; }
        public string G5_DNI { get; set; }
        public string G5_celular { get; set; }
        public List<Producto> G5_ListaProductosComprados { get; set; } = new List<Producto>();

        public double TotalGastado()
        {
            double total = 0;
            foreach(var p in G5_ListaProductosComprados)
                total += p.G5_Precio;
            return total;
        }
    }
}
