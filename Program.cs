using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Json;

namespace Practica_LINQ_CI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos productos = new Productos();
            Consultas consultas = new Consultas();

            consultas.Consulta(productos);
        }
    }
}