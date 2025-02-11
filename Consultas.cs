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

            //EJERCICIOS

            // 1. Obtener todos los productos de la lista.

            //Console.WriteLine("\n1. Obtener todos los productos de la lista:\n");

            //foreach (var item in lista)
            //{
            //    Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 2. Obtener los nombres de todos los productos.

            //Console.WriteLine("\n2. Obtener los nombres de todos los productos:\n");

            //foreach (var item in lista)
            //{
            //    Console.WriteLine($"{item.Nombre}");
            //}

            //---

            // 3. Obtener los productos cuyo precio sea mayor a 500.

            //Console.WriteLine("\n3. Obtener los productos cuyo precio sea mayor a 500:\n");

            //foreach (var item in lista.Where(p => p.Precio > 500))
            //{
            //    Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 4. Obtener los productos con stock menor a 10.

            //Console.WriteLine("\n4. Obtener los productos con stock menor a 10:\n");

            //foreach (var item in lista.Where(s => s.Stock < 10))
            //{
            //    Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            //5.Obtener los productos de la categoría "Electrónica".

            //Console.WriteLine("\n5. Obtener los productos de la categoría 'Electrónica':\n");

            // foreach (var item in lista.Where(c => c.Categoria.Contains("Electrónica")))
            // {
            //     Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            // }

            //---

            // 6. Obtener los productos cuyo nombre comience con la letra 'L'.

            //Console.WriteLine("\n6. Obtener los productos cuyo nombre comience con la letra 'L':\n");

            //foreach (var item in lista.Where(l => l.Nombre.StartsWith("L")))
            //{
            //    Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 7. Obtener los productos cuyo precio esté entre 100 y 500.

            //Console.WriteLine("\n7. Obtener los productos cuyo precio esté entre 100 y 500:\n");

            //foreach (var item in lista.Where(p => p.Precio >= 100 && p.Precio <= 500).ToList())
            //{
            //    Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 8. Obtener los productos ordenados por precio ascendente.

            Console.WriteLine("\n8. Obtener los productos ordenados por precio ascendente:\n");

            foreach (var item in lista.OrderBy(p=>p.Precio))
            {
                Console.WriteLine($"\n{item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            }
        }
    }
}