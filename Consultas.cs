using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LINQ_CI
{
    public class Consultas
    {
        public void consulta(List<Producto> productos)
        {
            foreach (var item in productos)
            {
                Console.WriteLine(item);
            }

            throw new NotImplementedException();

        }
    }
}