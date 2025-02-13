using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LINQ_CI
{
    public class Productos
    {
        public List<Producto> ListaProductos()
        {
            return new List<Producto>
           {
            new Producto {Id=1, Nombre="Laptop", Descripcion="Laptop de alta gama", Precio=999.99m * 61.57m, Stock=9, Categoria="Electrónica", FechaCreacion= new DateTime(2022, 12, 20)},
            new Producto {Id=2, Nombre="Smartphone", Descripcion="Smartphone con cámara de 108MP", Precio=799.99m * 61.57m, Stock=150, Categoria="Electrónica", FechaCreacion= new DateTime(2022, 12, 20)},
            new Producto {Id=3, Nombre="Tablet", Descripcion="Tablet con pantalla de 10 pulgadas", Precio=299.99m * 61.57m, Stock=200, Categoria="Electrónica", FechaCreacion=DateTime.Now},
            new Producto {Id=4, Nombre="Monitor", Descripcion="Monitor 4K de 27 pulgadas", Precio=399.99m * 61.57m, Stock=75, Categoria="Electrónica", FechaCreacion=DateTime.Now},
            new Producto {Id=5, Nombre="Teclado", Descripcion="Teclado mecánico retroiluminado", Precio=89.99m * 61.57m, Stock=120, Categoria="Accesorios", FechaCreacion=DateTime.Now},
            new Producto {Id=6, Nombre="Ratón", Descripcion="Ratón inalámbrico ergonómico", Precio=1.99m * 61.57m, Stock=180, Categoria="Accesorios", FechaCreacion=DateTime.Now},
            new Producto {Id=7, Nombre="Impresora", Descripcion="Impresora multifunción", Precio=129.99m * 61.57m, Stock=5, Categoria="Oficina", FechaCreacion=DateTime.Now},
            new Producto {Id=8, Nombre="Auriculares", Descripcion="Auriculares con cancelación de ruido", Precio=199.99m * 61.57m, Stock=90, Categoria="Audio", FechaCreacion=DateTime.Now},
            new Producto {Id=9, Nombre="Altavoces", Descripcion="Altavoces Bluetooth portátiles", Precio=59.99m * 61.57m, Stock=140, Categoria="Audio", FechaCreacion=DateTime.Now},
            new Producto {Id=10, Nombre="Cámara", Descripcion="Cámara digital de 24MP", Precio=499.99m * 61.57m, Stock=30, Categoria="Fotografía", FechaCreacion=DateTime.Now},
            new Producto {Id=11, Nombre="Televisor", Descripcion="Televisor OLED de 55 pulgadas", Precio=1299.99m * 61.57m, Stock=25, Categoria="Electrónica", FechaCreacion=DateTime.Now},
            new Producto {Id=12, Nombre="Consola", Descripcion="Consola de videojuegos de última generación", Precio=499.99m * 61.57m, Stock=80, Categoria="Juegos", FechaCreacion=DateTime.Now},
            new Producto {Id=13, Nombre="Router", Descripcion="Router Wi-Fi 6", Precio=149.99m * 61.57m, Stock=110, Categoria="Electrónica", FechaCreacion=DateTime.Now},
            new Producto {Id=14, Nombre="Disco Duro", Descripcion="Disco duro externo de 2TB", Precio=89.99m * 61.57m, Stock=130, Categoria="Almacenamiento", FechaCreacion=DateTime.Now},
            new Producto {Id=15, Nombre="Memoria USB", Descripcion="Memoria USB de 128GB", Precio=29.99m * 61.57m, Stock=250, Categoria="Almacenamiento", FechaCreacion=DateTime.Now},
            new Producto {Id=16, Nombre="Proyector", Descripcion="Proyector portátil", Precio=299.99m * 61.57m, Stock=40, Categoria="Electrónica", FechaCreacion=DateTime.Now},
            new Producto {Id=17, Nombre="Microondas", Descripcion="Microondas con grill", Precio=199.99m * 61.57m, Stock=7, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=18, Nombre="Refrigerador", Descripcion="Refrigerador de doble puerta", Precio=899.99m * 61.57m, Stock=20, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=19, Nombre="Lavadora", Descripcion="Lavadora de carga frontal", Precio=499.99m * 61.57m, Stock=35, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=20, Nombre="Secadora", Descripcion="Secadora de ropa", Precio=399.99m * 61.57m, Stock=45, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=21, Nombre="Aspiradora", Descripcion="Aspiradora sin bolsa", Precio=149.99m * 61.57m, Stock=85, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=22, Nombre="Cafetera", Descripcion="Cafetera de cápsulas", Precio=99.99m * 61.57m, Stock=95, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=23, Nombre="Tostadora", Descripcion="Tostadora de 4 rebanadas", Precio=49.99m * 61.57m, Stock=100, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=24, Nombre="Licuadora", Descripcion="Licuadora de alta potencia", Precio=79.99m * 61.57m, Stock=60, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=25, Nombre="Batidora", Descripcion="Batidora de mano", Precio=39.99m * 61.57m, Stock=110, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=26, Nombre="Ventilador", Descripcion="Ventilador de torre", Precio=69.99m * 61.57m, Stock=90, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=27, Nombre="Aire Acondicionado", Descripcion="Aire acondicionado portátil", Precio=299.99m * 61.57m, Stock=50, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=28, Nombre="Calefactor", Descripcion="Calefactor eléctrico", Precio=59.99m * 61.57m, Stock=80, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=29, Nombre="Horno", Descripcion="Horno eléctrico", Precio=199.99m * 61.57m, Stock=55, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=30, Nombre="Placa de Inducción", Descripcion="Placa de inducción portátil", Precio=149.99m * 61.57m, Stock=65, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=31, Nombre="Freidora", Descripcion="Freidora de aire", Precio=129.99m * 61.57m, Stock=75, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=32, Nombre="Plancha", Descripcion="Plancha de vapor", Precio=49.99m * 61.57m, Stock=100, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=33, Nombre="Secador de Pelo", Descripcion="Secador de pelo profesional", Precio=79.99m * 61.57m, Stock=90, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=34, Nombre="Cepillo Eléctrico", Descripcion="Cepillo de dientes eléctrico", Precio=39.99m * 61.57m, Stock=120, Categoria="Electrodomésticos", FechaCreacion=DateTime.Now},
            new Producto {Id=35, Nombre="Cámara Web", Descripcion = "Cámara web HD", Precio = 3000.00m, Stock = 50, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=36, Nombre="Auriculares Sony", Descripcion = "Auriculares con micrófono", Precio = 3500.00m, Stock = 70, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=37, Nombre="Tablet Samsung", Descripcion = "Tablet de 10 pulgadas", Precio = 20000.00m, Stock = 30, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=38, Nombre="Smartphone Xiaomi", Descripcion = "Smartphone de 64GB", Precio = 15000.00m, Stock = 40, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=39, Nombre="Cargador Portátil", Descripcion = "Cargador portátil de 10000mAh", Precio = 2500.00m, Stock = 100, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=40, Nombre="Cable HDMI", Descripcion = "Cable HDMI de 2 metros", Precio = 500.00m, Stock = 150, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=41, Nombre="SSD Kingston", Descripcion = "SSD de 240GB", Precio = 3500.00m, Stock = 60, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=42, Nombre="Tarjeta Gráfica", Descripcion = "Tarjeta gráfica NVIDIA", Precio = 45000.00m, Stock = 20, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=43, Nombre="Fuente de Poder", Descripcion = "Fuente de poder de 600W", Precio = 3000.00m, Stock = 40, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=44, Nombre="Placa Base", Descripcion = "Placa base ATX", Precio = 8000.00m, Stock = 30, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=45, Nombre="Memoria RAM", Descripcion = "Memoria RAM de 8GB", Precio = 2500.00m, Stock = 100, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=46, Nombre="Ventilador CPU", Descripcion = "Ventilador para CPU", Precio = 1500.00m, Stock = 50, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=47, Nombre="Case para PC", Descripcion = "Case ATX con ventana", Precio = 5000.00m, Stock = 8, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=48, Nombre="Switch de Red", Descripcion = "Switch de 8 puertos", Precio = 2000.00m, Stock = 40, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=49, Nombre="Adaptador USB", Descripcion = "Adaptador USB a Ethernet", Precio = 800.00m, Stock = 100, Categoria = "Informática", FechaCreacion = DateTime.Now },
            new Producto {Id=50, Nombre="Impresora 3D", Descripcion = "Impresora 3D de resina", Precio = 35000.00m, Stock = 6, Categoria = "Informática", FechaCreacion = DateTime.Now }
          };
        }
    }
}