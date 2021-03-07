using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    /* Pantalla de créditos al finalizar el juego */
    class Creditos
    {
        bool salir;

        // Lanza la pantalla de créditos, y se guarda si queremos salir o volver al inicio en la variable "salir"
        public void Lanzar()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
                Console.WriteLine();
            for (int i = 0; i < 80; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.WriteLine("Juego desarrollado por Ignacio Iborra Baeza. Pulsa Intro para volver al Inicio o cualquier otra tecla para salir");
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
