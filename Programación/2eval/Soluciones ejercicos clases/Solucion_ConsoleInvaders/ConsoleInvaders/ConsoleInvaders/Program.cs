using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Clase principal para lanzar el juego de ConsoleInvaders */
    class Program
    {
        static void Main(string[] args)
        {
            Juego j = new Juego();
            j.Lanzar();
        }
    }
}
