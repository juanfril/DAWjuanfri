using System;
using System.Collections.Generic;

namespace Pila5
{
    class Program
    {
        static void Main()
        {
            Stack<int> miPila = new Stack<int>();
            int numero;
            Console.WriteLine("Introduzca 5 números");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduzca número {0}", i);
                miPila.Push(Convert.ToInt32(Console.ReadLine()));
            }

            while(miPila.Count > 0)
            {
                numero = miPila.Pop();
                Console.WriteLine(numero);
            }
        }
    }
}
