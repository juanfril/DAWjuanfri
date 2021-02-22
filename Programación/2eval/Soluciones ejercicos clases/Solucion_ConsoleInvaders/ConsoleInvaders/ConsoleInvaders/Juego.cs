using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Clase Juego para el juego de Console Invaders. Coordina el resto de pantallas. */
    class Juego
    {
        // Lanza el juego en general. Es un bucle que, hasta que elijamos salir con Escape, muestra la pantalla de Bienvenida y luego la Partida para jugar (al pulsar Intro en la bienvenida)
        public void Lanzar()
        {

            Bienvenida b;

            // Ranking de mejores putuaciones
            Ranking r = new Ranking();

            // Puntos de cada partida
            int puntosPartida;

            do
            {
                b = new Bienvenida();
                b.Lanzar(r);
                if (!b.GetSalir())
                {
                    Console.Clear();
                    Partida p = new Partida();
                    puntosPartida = p.Lanzar();
                    r.AnyadirPuntuacion(puntosPartida);
                    Console.Clear();
                }
            } while (!b.GetSalir());
        }
    }
}
