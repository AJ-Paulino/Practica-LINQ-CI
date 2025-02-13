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
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
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
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 4. Obtener los productos con stock menor a 10.

            //Console.WriteLine("\n4. Obtener los productos con stock menor a 10:\n");

            //foreach (var item in lista.Where(s => s.Stock < 10))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            //5.Obtener los productos de la categoría "Electrónica".

            //Console.WriteLine("\n5. Obtener los productos de la categoría 'Electrónica':\n");

            // foreach (var item in lista.Where(c => c.Categoria.Contains("Electrónica")))
            // {
            //     Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            // }

            //---

            // 6. Obtener los productos cuyo nombre comience con la letra 'L'.

            //Console.WriteLine("\n6. Obtener los productos cuyo nombre comience con la letra 'L':\n");

            //foreach (var item in lista.Where(l => l.Nombre.StartsWith("L")))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 7. Obtener los productos cuyo precio esté entre 100 y 500.

            //Console.WriteLine("\n7. Obtener los productos cuyo precio esté entre 100 y 500:\n");

            //foreach (var item in lista.Where(p => p.Precio >= 100 && p.Precio <= 500).ToList())
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 8. Obtener los productos ordenados por precio ascendente.

            //Console.WriteLine("\n8. Obtener los productos ordenados por precio ascendente:\n");

            //foreach (var item in lista.OrderBy(p=>p.Precio))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 9. Obtener los productos ordenados por precio descendente.

            //Console.WriteLine("\n9. Obtener los productos ordenados por precio descendente:\n");

            //foreach (var item in lista.OrderByDescending(p => p.Precio))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 10. Obtener los productos ordenados por nombre en orden alfabético.

            //Console.WriteLine("\n10. Obtener los productos ordenados por nombre en orden alfabético:\n");

            //foreach (var item in lista.OrderBy(n => n.Nombre))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 11. Obtener los productos ordenados por stock de mayor a menor.

            //Console.WriteLine("\n11. Obtener los productos ordenados por stock de mayor a menor:\n");

            //foreach (var item in lista.OrderByDescending(s => s.Stock))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 12. Obtener los primeros 5 productos más caros.

            //Console.WriteLine("\n12. Obtener los primeros 5 productos más caros:\n");

            //foreach (var item in lista.OrderByDescending(p => p.Precio).Take(5))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 13. Obtener los 10 productos con menor stock.

            //Console.WriteLine("\n13. Obtener los 10 productos con menor stock:\n");

            //foreach (var item in lista.OrderBy(s => s.Stock).Take(10))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 14. Obtener la cantidad total de productos en la lista.

            //Console.WriteLine("\n14. Obtener la cantidad total de productos en la lista:\n");

            //var total = lista.Count();

            //Console.WriteLine($"\nCantidad total de productos en la lista: {total}");

            //---

            // 15. Obtener la suma de todos los precios de los productos.

            //Console.WriteLine("\n15. Obtener la suma de todos los precios de los productos:\n");

            //var sumaTotal = lista.Sum(p => p.Precio);

            //Console.WriteLine($"\nSumatoria total de los precios de los productos: {Math.Round(sumaTotal, 2)} RD$");

            //---

            // 16. Obtener el precio promedio de los productos.

            //Console.WriteLine("\n16. Obtener el precio promedio de los productos:\n");

            //var preciosPromedio = lista.Average(p => p.Precio);

            //Console.WriteLine($"\nEl promedio de los precios de los productos: {Math.Round(preciosPromedio, 2)} RD$");

            //---

            // 17. Obtener el producto más caro.

            //Console.WriteLine("\n17. Obtener el producto más caro:\n");

            //foreach (var item in lista.OrderByDescending(p => p.Precio).Take(1))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 18. Obtener el producto más barato.

            //Console.WriteLine("\n18. Obtener el producto más barato:\n");

            //foreach (var item in lista.OrderBy(p => p.Precio).Take(1))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 19. Verificar si hay algún producto con precio mayor a 1000.

            //Console.WriteLine("\n19. Verificar si hay algún producto con precio mayor a 1000:\n");

            //if(lista.Any(p=>p.Precio>30))
            //{
            //    Console.WriteLine("\nProductos que tienen un precio mayor a 1000:");

            //    foreach (var item in lista.Where(p => p.Precio > 1000))
            //    {
            //        Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nNo hay productos con un precio mayor a 1000");
            //}

            //---

            // 20. Verificar si todos los productos tienen stock mayor a 5.

            //if (lista.Any(s => s.Stock> 5))
            //{
            //    Console.WriteLine("\nTodos los productos tienen stock mayor a 5.");                                
            //}
            //else
            //{
            //    Console.WriteLine("\nProductos que tienen stock menor a 5:");

            //    foreach (var item in lista.Where(s => s.Stock < 5))
            //    {
            //        Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //    }
            //}

            //---

            // 21. Contar cuántos productos hay en la categoría "Audio".

            //Console.WriteLine("\nContar cuántos productos hay en la categoría 'Audio':\n");

            //var totalAudio = lista.Count(c => c.Categoria.Contains("Audio"));

            //Console.WriteLine($"\nHay un total de {totalAudio} productos en la categoría 'Audio':");

            //foreach (var item in lista.Where(c => c.Categoria.Contains("Audio")))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 22. Agrupar los productos por categoría.

            //Console.WriteLine("\n22. Agrupar los productos por categoría:\n");

            //var grupoCategoria = lista.GroupBy(c => c.Categoria).ToList();

            //foreach (var grupo in grupoCategoria)
            //{
            //    Console.WriteLine($"\n\n\n\n\nCategoría: {grupo.Key}");

            //    foreach (var item in grupo)
            //    {
            //        Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");

            //    }
            //}

            //---

            // 23. Obtener la categoría con más productos.

            //Console.WriteLine("\n23. Obtener la categoría con más productos:\n");

            //var grupoMayor = lista.GroupBy(c => c.Categoria).OrderByDescending(n => n.Count()).FirstOrDefault();

            //Console.WriteLine($"\nEl grupo con más integrantes es: {grupoMayor!.Key}." +
            //    $"\nCon un total de {grupoMayor.Count()} productos.");

            //---

            // 24. Obtener el stock total de todos los productos.

            //Console.WriteLine("\n24. Obtener el stock total de todos los productos:\n");

            //var stockTotal = lista.Sum(s => s.Stock);

            //Console.WriteLine($"\nStock total de todos los productos: {stockTotal}");

            //---

            // 25. Obtener el producto con el nombre más largo.

            //Console.WriteLine("\n25. Obtener el producto con el nombre más largo:\n");

            //var nombreLargo = lista.OrderByDescending(n => n.Nombre.Length).FirstOrDefault();

            //Console.WriteLine("\nProducto con el nombre más largo: " +
            //    $"\nID: {nombreLargo!.Id} {nombreLargo.Nombre} -{nombreLargo.Descripcion}. " +
            //    $"Precio: {Math.Round(nombreLargo.Precio, 2)} RD$. Stock: {nombreLargo.Stock} " +
            //    $"-{nombreLargo.Categoria}- Registrado: {nombreLargo.FechaCreacion}");

            //---

            // 26. Obtener el producto con la descripción más corta.

            //Console.WriteLine("\n26. Obtener el producto con la descripción más corta:\n");

            //var descripcionCorta = lista.OrderBy(d => d.Descripcion.Length).FirstOrDefault();

            //Console.WriteLine($"\nProducto con la descripción más corta:\n" +
            //    $"\nID: {descripcionCorta!.Id} -{descripcionCorta.Nombre} -Descripción: {descripcionCorta.Descripcion}. " +
            //    $"Precio: {Math.Round(descripcionCorta.Precio, 2)} RD$. Stock: {descripcionCorta.Stock} " +
            //    $"-{descripcionCorta.Categoria}- Registrado: {descripcionCorta.FechaCreacion}");

            //---

            // 27. Filtrar los productos cuya descripción contenga la palabra "pantalla".

            //Console.WriteLine("\n27. Filtrar los productos cuya descripción contenga la palabra 'pantalla':\n");

            //foreach (var item in lista.Where(d => d.Descripcion.Contains("pantalla")))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".

            //Console.WriteLine("\n28. Obtener el promedio de stock de los productos de la categoría 'Almacenamiento':\n");

            //var item = lista.Where(c => c.Categoria.Contains("Almacenamiento"));
            //var stockPromedioAlmacenamiento = lista.Average(s => s.Stock);

            //Console.WriteLine($"\nEl promedio de stock en los productos para almacenamiento: {stockPromedioAlmacenamiento}");

            //---

            // 29. Obtener los productos creados en una fecha específica (20/12/2022).

            //Console.WriteLine("\n29. Obtener los productos creados en una fecha específica (20/12/2022):\n");

            //foreach (var item in lista.Where(f => f.FechaCreacion.Date == new DateTime(2022, 12, 20)))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 30. Obtener los productos cuya ID sea par.

            //Console.WriteLine("\n30. Obtener los productos cuya ID sea par:\n");

            //foreach (var item in lista.Where(i => i.Id % 2 == 0))
            //{
            //    Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            //}

            //---

            // 31. Obtener los productos cuya ID sea impar.

            Console.WriteLine("\n31. Obtener los productos cuya ID sea impar:\n");

            foreach (var item in lista.Where(i => i.Id % 2 != 0))
            {
                Console.WriteLine($"\nID: {item.Id} {item.Nombre} -{item.Descripcion}. Precio: {Math.Round(item.Precio, 2)} RD$. Stock: {item.Stock} -{item.Categoria}- Registrado: {item.FechaCreacion}");
            }
        }
    }
}