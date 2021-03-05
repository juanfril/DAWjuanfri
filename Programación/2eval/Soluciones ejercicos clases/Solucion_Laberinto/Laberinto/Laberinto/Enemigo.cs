using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Enemigos del juego */
    class Enemigo : Sprite
    {
        // Dirección de avance del enemigo (+1 hacia la derecha, -1 hacia la izquierda)
        int direccion = 1; 

        // Cambia la dirección de avance
        public void CambiaDireccion()
        {
            direccion = -direccion;
        }

        // Obtiene la direccion actual
        public int GetDireccion()
        {
            return direccion;
        }

        // Dibujar el enemigo en sus coordenadas actuales
        public override void Dibujar()
        {
            imagen = '$';
            Console.SetCursorPosition(x, y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(imagen);
            Console.ForegroundColor = c;
        }
    }
}
