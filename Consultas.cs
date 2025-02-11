using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LINQ_CI
{
    public class Consultas
    {
        public void Consulta(Productos productos)
        {                        
            List<Producto> lista = productos.ListaProductos();

            foreach (var item in lista)
            {
                Console.WriteLine($"prueba {item.Id}");
            }
        }
    }
}