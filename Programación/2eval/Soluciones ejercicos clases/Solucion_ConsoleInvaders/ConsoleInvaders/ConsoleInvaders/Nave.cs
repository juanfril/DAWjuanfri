using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Nave principal del juego. Subtipo de Sprite */
    class Nave : Sprite
    {
        // Constructor por defecto
        public Nave(): this(40, 20)
        {
            MoverA(40, 20);
        }

        // Constructor para establecer la posición
        public Nave(int cx, int cy)
        {
            imagen = "/\\";
            MoverA(cx, cy);
        }

        // Mueve el objeto 1 unidades a la izquierda (el enunciado decía 10 unidades, pero refiriéndose a pantalla completa, no a modo consola)
        public void MoverIzquierda()
        {
            MoverA(x - 1, y);
        }

        // Mueve el objeto 1 unidades a la derecha (el enunciado decía 10 unidades, pero refiriéndose a pantalla completa, no a modo consola)
        public void MoverDerecha()
        {
            MoverA(x + 1, y);
        }

        // Redefinición del método Dibujar
        public override void Dibujar()
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            base.Dibujar();
            Console.ForegroundColor = c;
        }
    }
}
