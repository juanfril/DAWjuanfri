using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Disparo del enemigo (subtipo de disparo) */
    class DisparoEnemigo : Disparo
    {
        // Dibujar el disparo
        public override void Dibujar()
        {
            imagen = "|";
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            base.Dibujar();
            Console.ForegroundColor = c;
        }
    }
}
