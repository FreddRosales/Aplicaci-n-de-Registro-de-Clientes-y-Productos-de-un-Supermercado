using EF_FP_G5.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FP_G5.Servicios
{
    public static class Archivos
    {
        public static void GuardarClientes(List<Cliente> G5_Listaclientes)
        { 
            using (StreamWriter sw = new StreamWriter("clientes.txt"))
            {
                foreach (var c in G5_Listaclientes)
                {
                    string linea = $"{c.G5_Nombre},{c.G5_Apellido},{c.G5_DNI},{c.G5_celular}";
                    sw.WriteLine(linea);
                }
            }
        }
        public static void GuardarProductos(List<Producto> G5_Listaproductos) 
        {
            using (StreamWriter sw = new StreamWriter("productos.txt"))
            {
                foreach (var p in G5_Listaproductos)
                {
                    string linea = $"{p.G5_Codigo},{p.G5_Nombre},{p.G5_Categoria},{p.G5_Precio}";
                    sw.WriteLine(linea);
                }
            }
        }
    }
    
}
