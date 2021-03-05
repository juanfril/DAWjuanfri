using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Clase que coordina el resto de pantallas del juego */
    class Juego
    {
        // Lanza el juego en general. Es un bucle que, hasta que elijamos salir, muestra la pantalla de Bienvenida, luego la Partida para jugar (al pulsar Intro en la bienvenida) y finalmente los créditos (al pulsar Escape en la partida)
        public void Lanzar()
        {

            Bienvenida b = new Bienvenida();
            Creditos c = new Creditos();

            do
            {
                b.Lanzar();
                if (!b.GetSalir())
                {
                    Console.Clear();
                    Partida p = new Partida();
                    p.Lanzar();
                    Console.Clear();
                    c.Lanzar();
                }
            } while (!b.GetSalir() && !c.GetSalir());
        }
    }
}
