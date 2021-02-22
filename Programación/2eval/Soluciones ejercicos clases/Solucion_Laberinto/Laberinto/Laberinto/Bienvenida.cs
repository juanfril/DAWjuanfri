using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Pantalla de bienvenida del juego */
    class Bienvenida
    {
        bool salir;

        // Lanza la pantalla de bienvenida, y se guarda si queremos salir o jugar en la variable "salir"
        public void Lanzar()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
                Console.WriteLine();
            for (int i = 0; i < 80; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.WriteLine("Bienvenido a Laberinto.\nPulse Intro para jugar o cualquier otra tecla para salir");
            Console.WriteLine();
            for (int i = 0; i < 80; i++)
                Console.Write("*");

            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
                salir = false;
            else
                salir = true;
        }

        // Obtiene si queremos salir del juego
        public bool GetSalir()
        {
            return salir;
        }
    }
}
