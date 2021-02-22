using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Personaje principal del juego */
    class Personaje : Sprite
    {
        // Dibujar el personaje en sus coordenadas actuales
        public override void Dibujar()
        {
            imagen = 'X';
            Console.SetCursorPosition(x, y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(imagen);
            Console.ForegroundColor = c;
        }
    }
}
