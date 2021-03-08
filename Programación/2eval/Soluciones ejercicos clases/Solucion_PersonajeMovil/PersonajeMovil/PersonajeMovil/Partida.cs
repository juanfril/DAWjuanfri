using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    /* Pantalla principal del juego, donde podemos mover al personaje */
    class Partida
    {
        // Lanza la partida principal, dibujando las naves y enemigos e interactuando con el usuario (recogiendo los movimientos de la nave y demás)
        public void Lanzar()
        {
            Personaje p = new Personaje();
            p.MoverA(40, 12);
            p.Dibujar();
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey();
                Console.Clear();
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    p.MoverIzquierda();
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    p.MoverDerecha();
                }
                else if (tecla.Key == ConsoleKey.UpArrow)
                {
                    p.MoverArriba();
                }
                else if (tecla.Key == ConsoleKey.DownArrow)
                {
                    p.MoverAbajo();
                }

                p.Dibujar();
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
