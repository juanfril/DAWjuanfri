using System;
using System.Collections.Generic;

namespace TiendaInformatica
{
    /*
     * Programa principal con el menú para altas de productos y gestión del carro de la compra
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();
            List<string> miLista = new List<string>();

            string opcion, codigo;
            float precioTotal;
            byte tipo;

            do
            {
                Console.Clear();

                Console.WriteLine("Menú ");
                Console.WriteLine("====");
                Console.WriteLine();
                Console.WriteLine("1 - Salir del programa");
                Console.WriteLine("2 - Nuevo producto");
                Console.WriteLine("3 - Listar productos");
                Console.WriteLine("4 - Eliminar producto");
                Console.WriteLine();
                Console.WriteLine("5 - Añadir producto al carro");
                Console.WriteLine("6 - Ver total");
                Console.WriteLine("7 - Vaciar carro");
                Console.WriteLine("\nElige una opcion:");

                opcion = Console.ReadLine();

                Console.Clear();

                switch (opcion)
                {
                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Indica el tipo de Producto pulsando el número correspondiente:");
                            Console.WriteLine("1 - Periférico  |  2 - Portátil  |  3 - Otro Componente");
                            Console.WriteLine();
                        } while (!Byte.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 3);

                        ProductoInformatico nuevoProd = rellenarDatos(tipo);
                        
                        if (catalogo.NuevoProducto(nuevoProd))
                        {
                            Console.WriteLine("Producto añadido!");
                        }
                        else
                        {
                            Console.WriteLine("Ha ocurrido un error. No se ha añadido el producto");
                        }

                        break;

                    case "3":

                        catalogo.ListarCatalogo();
                        break;

                    case "4":

                        Console.WriteLine("Introduce el código del producto a eliminar;");
                        codigo = Console.ReadLine();

                        if (catalogo.EliminarProducto(codigo))
                        {
                            Console.WriteLine("Producto borrado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Error al borrar producto");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Introduce el código del producto:");
                        codigo = Console.ReadLine();

                        if (catalogo.ObtenerProducto(codigo) != null)
                        {
                            miLista.Add(codigo);
                            Console.WriteLine("Producto añadido al carro");
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe en el catálogo");
                        }

                        break;

                    case "6":

                        Console.WriteLine("Contenido del carro:");
                        Console.WriteLine();
                        for (int i = 0; i < miLista.Count; i++)
                        {
                            catalogo.Productos[miLista[i]].Mostrar();
                            Console.WriteLine();
                        }
                        precioTotal = catalogo.CalcularTotal(miLista);
                        Console.WriteLine();
                        Console.WriteLine("Precio total: " + precioTotal +" eur");
                        break;

                    case "7":

                        miLista.Clear();
                        Console.WriteLine("Carro vaciado");
                        break;
                }

                Console.WriteLine("Pulse Intro para continuar...");
                Console.ReadLine();

            } while (opcion != "1");

        }

        // Método auxiliar para pedir los datos de los Productos Informáticos y devolver el producto relleno
        private static ProductoInformatico rellenarDatos(byte tipo)
        {
            string codigo, marca, modelo, nombre, descripcion, conexion;
            short ram, disco;
            float precio, pulgadas;

            Console.Write("Código alfanumérico:");
            codigo = Console.ReadLine();
            Console.Write("Marca:");
            marca = Console.ReadLine();
            Console.Write("Modelo:");
            modelo = Console.ReadLine();
            Console.Write("Precio (con decimales):");
            while (!Single.TryParse(Console.ReadLine(), out precio)) ;

            if (tipo == 1)
            {
                Console.Write("Nombre del periférico:");
                nombre = Console.ReadLine();
                Console.Write("Conexión:");
                conexion = Console.ReadLine();

                return new Periferico(codigo, marca, modelo, precio, nombre, conexion);
            }
            else if (tipo == 2)
            {
                Console.Write("Pulgadas de monitor:");
                while (!Single.TryParse(Console.ReadLine(), out pulgadas)) ;
                Console.Write("RAM (GB):");
                while (!Int16.TryParse(Console.ReadLine(), out ram)) ;
                Console.Write("Disco duro (GB):");
                while (!Int16.TryParse(Console.ReadLine(), out disco)) ;

                return new Portatil(codigo, marca, modelo, precio, pulgadas, ram, disco);
            }
            else
            {
                Console.Write("Nombre del producto:");
                nombre = Console.ReadLine();
                Console.Write("Descripcion:");
                descripcion = Console.ReadLine();

                return new Otros(codigo, marca, modelo, precio, nombre, descripcion);
            }
        }                                
    }
}
