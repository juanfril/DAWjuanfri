using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Tipo especial de enemigo que aparece ocasionalmente por la parte superior de la pantalla */
    class Ovni : Enemigo
    {
        // Para generar números aleatorios y activar o no el ovni
        Random r = new Random();

        // Constructor
        public Ovni()
        {
            imagen = "[-]";
        }

        // Genera un número aleatorio que decide si activa o no el ovni
        public void IntentarActivacion()
        {
            int num = r.Next(0, 10);
            // Hacemos que, por ejemplo, el ovni se active sólo el 10% de las veces
            if (num == 0)
                activo = true;
        }

        // Mueve el ovni una posición a la derecha
        public void Mover()
        {
            if (GetX() < 78 - imagen.Length)
                MoverA(GetX() + 1, GetY());
            else
                SetActivo(false);
        }

        // Redefinición del método Dibujar para el ovni
        // Redefinición del método Dibujar
        public override void Dibujar()
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            base.Dibujar();
            Console.ForegroundColor = c;
        }

    }
}
