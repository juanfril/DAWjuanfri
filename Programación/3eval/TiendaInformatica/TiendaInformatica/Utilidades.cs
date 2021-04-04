using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TiendaInformatica
{
    class Utilidades
    {
        public static bool ComprobarCadena(string mensaje)
        {
            bool error = false;
            string texto;

            do
            {
                Console.WriteLine(mensaje + " ");
                texto = Console.ReadLine();

                if (String.IsNullOrEmpty(texto))
                {
                    error = true;
                    Console.WriteLine("No puede dejar el campo vacío");
                }
            }while(error)


            return error;
        }
        public static bool ComprobarNumeroEntero(string mensaje)
        {
            bool error = false;
            int numero;

            Console.WriteLine(mensaje + " ");
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("El valor introducido tiene que ser un número mayor que 0.");
            }

            if (numero <= 0) //Este bloque a lo mejor tengo que meterlo dentro del try
            {
                error = true;
                Console.WriteLine("El número introducido tiene que ser mayor de 0.");
            }

            return error;
        }
        public static bool ComprobarCodigo(string mensaje, SortedList catalogo)
        {
            bool error = false;
            string texto;

            do
            {
                Console.WriteLine(mensaje + " ");
                texto = Console.ReadLine();

                if (String.IsNullOrEmpty(texto || catalogo.ContainsKey(texto))
                {
                    error = true;
                    Console.WriteLine("Error, no puede dejar el campo vacío o repetir código de producto");
                }
            } while (error)


            return error;
        }
    }
}
