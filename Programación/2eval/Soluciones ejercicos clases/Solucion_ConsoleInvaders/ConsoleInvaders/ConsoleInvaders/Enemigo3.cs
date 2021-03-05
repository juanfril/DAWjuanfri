using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Otro subtipo de enemigo con imagen propia */
    class Enemigo3 : Enemigo
    {
         // Constructor para indicar las coordenadas
        public Enemigo3(int cx, int cy): base(cx, cy)
        {
            imagen = ")(";
        }

        // Redefinición del método Dibujar
        public override void Dibujar()
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Dibujar();
            Console.ForegroundColor = c;
        }

    }
}
