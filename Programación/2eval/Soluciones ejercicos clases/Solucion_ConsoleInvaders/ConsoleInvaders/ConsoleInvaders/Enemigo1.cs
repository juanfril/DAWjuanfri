using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Subtipo de enemigo con imagen propia */
    class Enemigo1 : Enemigo
    {
        // Constructor para indicar las coordenadas
        public Enemigo1(int cx, int cy): base(cx, cy)
        {
            imagen = "][";
        }

        // Redefinición del método Dibujar
        public override void Dibujar()
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            base.Dibujar();
            Console.ForegroundColor = c;
        }
    }
}
