using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Mapa con las paredes y obstáculos del juego */
    class Laberinto
    {
        private StringBuilder[] mapa = {
                                     new StringBuilder("********************************************************************************"),
                                     new StringBuilder("*                *                                      *                      *"),
                                     new StringBuilder("*                *                                      *                      *"),
                                     new StringBuilder("*                *                                      *                      *"),
                                     new StringBuilder("*                *                                      *                      *"),
                                     new StringBuilder("*                *                                      *                      *"),
                                     new StringBuilder("*                *                                      *                      *"),
                                     new StringBuilder("*                *                                      ***********            *"),
                                     new StringBuilder("*                *                                                             *"),
                                     new StringBuilder("*                *                                                             *"),
                                     new StringBuilder("*                *                                                             *"),
                                     new StringBuilder("*                *                                                             *"),
                                     new StringBuilder("*                *                          *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("****************************                *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("*                                           *                                  *"),
                                     new StringBuilder("********************************************************************************")
                                 };

        // Dibuja el laberinto
        public void Dibujar()
        {
            Console.Clear();
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < mapa.Length; i++)
                Console.Write(mapa[i]);
            Console.ForegroundColor = c;
        }

        // Comprueba si un personaje puede moverse a la posición (x, y) indicada, o si hay alguna pared u obstáculo
        public bool PuedeMoverse(int x, int y)
        {
            return x >= 0 && x <= 79 && y >= 0 && y <= 23 && mapa[y][x] != '*';
        }

        // Obtiene una posicion del mapa del laberinto
        public char GetPosicionMapa(int x, int y)
        {
            if (x >= 0 && x <= 79 && y >= 0 && y <= 23)
                return mapa[y][x];
            else
                return Convert.ToChar(0);
        }

        // Establece una posición del mapa del laberinto
        public void SetPosicionMapa(int x, int y, char c)
        {
            if (x >= 0 && x <= 79 && y >= 0 && y <= 23)
                mapa[y][x] = c;
        }
    }
}
