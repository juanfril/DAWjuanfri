/*
 Juan Fco. Losa Márquez
 Practica Evaluable Tema 7
 Apartado 1 si / no / parcialmente
 Apartado 2 si / no / parcialmente
 Apartado 3 si / no / parcialmente
 Apartado 4 si / no / parcialmente
 Apartado 5 si / no / parcialmente
 Apartado 6 si / no / parcialmente
 Apartado 7 si / no / parcialmente
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

            Console.ReadKey();
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
                        break;
                    case 4:
                        string codigo;

                        do
                        {
                            catalogo.ListarCatalogo();
                            Console.WriteLine("Introduzca el código del producto a borrar " +
                                "(No puede dejar el campo vacío)");
                            codigo = Console.ReadLine();

                        } while (String.IsNullOrEmpty(codigo));

                        if(catalogo.EliminarProducto(codigo))
                            Console.WriteLine("El producto se ha eliminado correctamente");
                        else
                            Console.WriteLine("No se ha podido eliminar el producto");
                        Console.ReadKey();
                        break;
                    case 5:

                        break;
                    case 6:

                        float precioTotal = catalogo.CalcularTotal(carro);
                        Console.WriteLine("\n El precio total del carro es {0}", precioTotal);

                        break;
                    case 7:

                        break;
                    default:
                        Console.WriteLine("Tiene que escoger una opción válida del menu");
                        break;
                }
            } while (opcion != 1);
        }
    }
}
