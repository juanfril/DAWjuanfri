/*
 Juan Fco. Losa Márquez
 Practica Evaluable Tema 7
 Apartado 1 si
 Apartado 2 si
 Apartado 3 si
 Apartado 4 si
 Apartado 5 si
 Apartado 6 si
 Apartado 7 si
 */

using System;
using System.Collections.Generic;

namespace TiendaInformatica
{
    class Program
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n| TIENDA DE INFORMATICA \n");
            Console.WriteLine("| Escoja una opción");
            Console.WriteLine("| 1. Salir del programa");
            Console.WriteLine("| 2. Nuevo producto");
            Console.WriteLine("| 3. Listar productos");
            Console.WriteLine("| 4. Eliminar producto");
            Console.WriteLine("| 5. Añadir producto al carro");
            Console.WriteLine("| 6. Ver total");
            Console.WriteLine("| 7. Vaciar carro");
            Console.WriteLine("|\n Introduzca un número del 1 al 7");
        }

        public static void CrearProducto(byte opcion, Catalogo catalogo)
        {
            ProductoInformatico producto;
            float decimalAuxiliar;

            Console.Clear();

            if(opcion == 1)
            {
                producto = CrearComponentes();
            }
            else if(opcion == 2)
            {
                producto = CrearPortatiles();
            }
            else
            {
                producto = CrearPerifericos();
            }

            Console.WriteLine("Introduzca código de identificación");
            producto.Codigo = Console.ReadLine();
            Console.WriteLine("Introduzca marca");
            producto.Marca = Console.ReadLine();
            Console.WriteLine("Introduzca modelo");
            producto.Modelo = Console.ReadLine();
            do
            {
                Console.WriteLine("Introduzca precio (número, acepta decimales)");

            } while (!Single.TryParse(Console.ReadLine(), out decimalAuxiliar));

            producto.Precio = decimalAuxiliar;

            if (catalogo.NuevoProducto(producto))
                Console.WriteLine("Producto añadido correctamente");
            else
                Console.WriteLine("No se ha podido añadir el producto," +
                    " revise los datos e intentelo de nuevo.");

            Utilidades.Pausa();
        }
        public static Componentes CrearComponentes()
        {
            Componentes producto = new Componentes();

            Console.WriteLine("Introduzca nombre");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca descripción");
            producto.Descripcion = Console.ReadLine();

            return producto;
        }

        public static Portatiles CrearPortatiles()
        {
            Portatiles producto = new Portatiles();
            bool correcto = false;

            while (!correcto)
            {
                try
                {
                    Console.WriteLine("Introduzca tamaño de la pantalla");
                    producto.TamanyoPantalla = Convert.ToSingle(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tiene que introducir un número");
                }
            }
            correcto = false;

            while (!correcto)
            {
                try
                {
                    Console.WriteLine("Introduzca memoria ram");
                    producto.Ram = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tiene que introducir un número");
                }
            }
            correcto = false;

            while (!correcto)
            {
                try
                {
                    Console.WriteLine("Introduzca memoria tamaño del disco duro");
                    producto.DiscoDuro = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tiene que introducir un número");
                }
            }
            return producto;
        }
        public static Perifericos CrearPerifericos()
        {
            Perifericos producto = new Perifericos();

            Console.WriteLine("Introduzca nombre");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca conexión");
            producto.Conexion = Console.ReadLine();

            return producto;
        }

        static void Main()
        {
            List<string> carro = new List<string>();
            Catalogo catalogo = new Catalogo();

            byte opcion;
            byte opcionNuevo;
            string añadirCarro;
            string borrarCarro;

            do
            {
                MostrarMenu();
                if(!byte.TryParse(Console.ReadLine(), out opcion))
                    Console.WriteLine("Tiene que elegir un número del 1 al 7");

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Gracias por utilizar nuestro servicio!");
                        break;
                    case 2:
                    
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n| TIENDA DE INFORMATICA \n");
                            Console.WriteLine("| Escoja tipo de producto a crear");
                            Console.WriteLine("| 1. Componentes");
                            Console.WriteLine("| 2. Portátiles");
                            Console.WriteLine("| 3. Periféricos");
                            Console.WriteLine("|\n Introduzca un número del 1 al 3");

                        } while (!byte.TryParse(Console.ReadLine(), out opcionNuevo));

                        if (opcionNuevo > 0 && opcionNuevo < 4)
                            CrearProducto(opcionNuevo, catalogo);

                        break;
                    case 3:
                        catalogo.ListarCatalogo();
                        Utilidades.Pausa();

                        break;
                    case 4:
                        do
                        {
                            Console.Clear();
                            catalogo.ListarCatalogo();
                            Console.WriteLine("Introduzca el código del producto a borrar " +
                                "(No puede dejar el campo vacío)");
                            borrarCarro = Console.ReadLine();

                        } while (String.IsNullOrEmpty(borrarCarro));

                        if(catalogo.EliminarProducto(borrarCarro))
                            Console.WriteLine("El producto se ha eliminado correctamente");
                        else
                            Console.WriteLine("No se ha podido eliminar el producto");
                            Utilidades.Pausa();
                        break;
                    case 5:
                        do
                        {
                            Console.Clear();
                            catalogo.ListarCatalogo();
                            Console.WriteLine("\n" +
                                "Introduzca el código del producto a añadir " +
                                "(No puede dejar el campo vacío)");
                            añadirCarro = Console.ReadLine();

                        } while (String.IsNullOrEmpty(añadirCarro));

                        if(catalogo.ObtenerProducto(añadirCarro) == null)
                            Console.WriteLine("Artículo no encontrado");
                        else
                        {
                            carro.Add(añadirCarro);
                            Console.WriteLine("Artículo añadido correctamente");
                        }
                        Utilidades.Pausa();

                        break;
                    case 6:
                        float precioTotal = catalogo.CalcularTotal(carro);
                        Console.WriteLine("\n El precio total del carro es {0}", precioTotal);
                        Utilidades.Pausa();
                        break;
                    case 7:
                        carro.Clear();
                        Console.WriteLine("\nCarro vacío");
                        Utilidades.Pausa();
                        break;
                    default:
                        Console.WriteLine("\nTiene que escoger una opción válida del menu");
                        break;
                }
            } while (opcion != 1);
        }
    }
}
