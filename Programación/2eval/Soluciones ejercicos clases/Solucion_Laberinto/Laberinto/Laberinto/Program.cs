using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Programa principal del juego Laberinto, donde movemos un personaje por un laberinto con paredes, esquivando enemigos */
    class Program
    {
        static void Main(string[] args)
        {
            Juego j = new Juego();
            j.Lanzar();
        }
    }
}
