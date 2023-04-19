using PrimerParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Hardcodeo
    {
        public static void HardcodearProductos(List<Producto> productos)
        {
            Random random = new Random();
            productos.Add(new Producto("Cereales", random.Next(1,100), random.Next(200,500)));
            productos.Add(new Producto("Papas fritas", random.Next(1, 100), random.Next(200, 500)));
            productos.Add(new Producto("Chocolate", random.Next(1, 100), random.Next(200, 500)));
        }
    }
}
