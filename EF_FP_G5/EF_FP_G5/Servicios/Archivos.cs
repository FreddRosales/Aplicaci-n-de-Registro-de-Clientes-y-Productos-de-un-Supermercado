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
                    string linea = $"{c.G5_NombreC} / {c.G5_DNIC} / {c.G5_celularC}";
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
                    string linea = $"{p.G5_Codigop} / {p.G5_Nombrep} / {p.G5_Categoriap} / {p.G5_Preciop}";
                    sw.WriteLine(linea);
                }
            }
        }
        public static void GuardarAsignaciones(List<Asignar> G5_ListaAsignar)
        {
            using (StreamWriter sw = new StreamWriter("asignar.txt"))
            {
                foreach (var A in G5_ListaAsignar)
                {
                    string linea = $"{A.G5_NombreA} / {A.G5_ProductoA} / {A.G5_CantidadA} / {A.G5_TotalA}";
                    sw.WriteLine(linea);
                }
            }
        }
        public static void CargarClientes()
        {
            Global.listaClientes.Clear();
            if (!File.Exists("clientes.txt")) return;

            foreach (var linea in File.ReadAllLines("clientes.txt"))
            {
                var partes = linea.Split('/');
                Cliente c = new Cliente
                {
                    G5_NombreC = partes[0].Trim(),
                    G5_DNIC = partes[1].Trim(),
                    G5_celularC = partes[2].Trim()
                };
                Global.listaClientes.Add(c);
            }
        }

        public static void CargarProductos()
        {
            Global.listaProductos.Clear();
            if (!File.Exists("productos.txt")) return;

            foreach (var linea in File.ReadAllLines("productos.txt"))
            {
                var partes = linea.Split('/');
                Producto p = new Producto
                {
                    G5_Codigop = partes[0].Trim(),
                    G5_Nombrep = partes[1].Trim(),
                    G5_Categoriap = partes[2].Trim(),
                    G5_Preciop = double.Parse(partes[3].Trim())
                };
                Global.listaProductos.Add(p);
            }
        }
        public static void CargarAsignaciones()
        {
            Global.listaAsignar.Clear();
            if (!File.Exists("asignar.txt")) return;

            foreach (var linea in File.ReadAllLines("asignar.txt"))
            {
                var partes = linea.Split('/');
                Asignar a = new Asignar
                {
                    G5_NombreA = partes[0].Trim(),
                    G5_ProductoA = partes[1].Trim(),
                    G5_CantidadA = partes[2].Trim(),
                    G5_TotalA = partes[3].Trim()
                };
                Global.listaAsignar.Add(a);
            }
        }
    }

   }
