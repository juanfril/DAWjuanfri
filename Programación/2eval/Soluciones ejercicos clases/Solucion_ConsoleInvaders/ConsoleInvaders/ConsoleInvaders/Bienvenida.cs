using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Clase para gestionar la pantalla de bienvenida del juego Console Invaders */
    class Bienvenida
    {
        bool salir;

        // Lanza la pantalla de bienvenida, y se guarda si queremos salir o jugar en la variable "salir"
        // Se le pasa un ranking de puntuaciones para mostrar en la página de bienvenida
        public void Lanzar(Ranking r)
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 5; i++)
                Console.WriteLine();
            Console.Write("********************************************************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido a Console Invaders.");                                     
            Console.WriteLine("Pulse Intro para jugar o Esc para salir");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("********************************************************************************");

            Console.ForegroundColor = c;
            Console.SetCursorPosition(0, 12);
            r.Mostrar();

            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
                salir = true;
            else if (tecla.Key == ConsoleKey.Enter)
                salir = false;
            else
            {
                Console.WriteLine("Opción incorrecta. Saliendo del juego");
                salir = true;
            }
        }

        // Obtiene si queremos salir del juego
        public bool GetSalir()
        {
            return salir;
        }
    }
}
