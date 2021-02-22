using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Pantalla principal del juego, donde podemos mover al personaje */
    class Partida
    {
        // Genera una posición inicial válida donde colocar a cada personaje o enemigo del juego (fuera de otros personajes y de paredes)
        private void GeneraPosicionInicial(Laberinto l, Random r, out int cx, out int cy)
        {
            do
            {
                cx = r.Next(0, 80);
                cy = r.Next(0, 24);
            } while (l.GetPosicionMapa(cx, cy) != ' ');
        }

        // Comprueba si el personaje colisiona con algún enemigo
        private bool ColisionEnemigo(Personaje p, Enemigo[] e)
        {
            for (int i = 0; i < e.Length; i++)
                if (e[i].GetX() == p.GetX() && e[i].GetY() == p.GetY())
                    return true;
            return false;
        }

        // Lanza la partida principal, dibujando las naves y enemigos e interactuando con el usuario (recogiendo los movimientos de la nave y demás)
        public void Lanzar()
        {
            Personaje p = new Personaje();
            Laberinto l = new Laberinto();
            Random r = new Random();
            Enemigo[] e = new Enemigo[3];
            int xIni, yIni;
            int vidas = 3;
            ConsoleKeyInfo tecla;

            // Colocamos los personajes en posiciones iniciales
            GeneraPosicionInicial(l, r, out xIni, out yIni);
            p.MoverA(xIni, yIni);
            l.SetPosicionMapa(xIni, yIni, p.GetImagen());

            e[0] = new Enemigo();
            GeneraPosicionInicial(l, r, out xIni, out yIni);
            e[0].MoverA(xIni, yIni);
            l.SetPosicionMapa(xIni, yIni, e[0].GetImagen());

            e[1] = new Enemigo();
            GeneraPosicionInicial(l, r, out xIni, out yIni);
            e[1].MoverA(xIni, yIni);
            l.SetPosicionMapa(xIni, yIni, e[1].GetImagen());

            e[2] = new Enemigo();
            GeneraPosicionInicial(l, r, out xIni, out yIni);
            e[2].MoverA(xIni, yIni);
            l.SetPosicionMapa(xIni, yIni, e[2].GetImagen());
            
            do
            {
                // Primero dibujamos el laberinto
                l.Dibujar();
                
                // Mostramos las vidas al final
                ConsoleColor c = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Vidas: {0}", vidas);
                Console.ForegroundColor = c;

                // Dibujamos personaje y enemigos
                p.Dibujar();
                for (int i = 0; i < e.Length; i++)
                    e[i].Dibujar();

                // Leemos movimiento del personaje
                tecla = Console.ReadKey();

                // Borramos las posiciones previas de los personajes
                l.SetPosicionMapa(p.GetX(), p.GetY(), ' ');
                for (int i = 0; i < e.Length; i++)
                    l.SetPosicionMapa(e[i].GetX(), e[i].GetY(), ' ');

                // Movemos enemigos
                for (int i = 0; i < e.Length; i++)
                {
                    if (l.PuedeMoverse(e[i].GetX() + e[i].GetDireccion(), e[i].GetY()))
                    {
                        e[i].MoverA(e[i].GetX() + e[i].GetDireccion(), e[i].GetY());
                        l.SetPosicionMapa(e[i].GetX(), e[i].GetY(), e[i].GetImagen());
                    }
                    else
                        e[i].CambiaDireccion();
                }

                // Movemos el personaje principal en la dirección solicitada
                if (tecla.Key == ConsoleKey.LeftArrow && l.PuedeMoverse(p.GetX() - 1, p.GetY()))
                {
                    p.MoverIzquierda();
                }
                else if (tecla.Key == ConsoleKey.RightArrow && l.PuedeMoverse(p.GetX() + 1, p.GetY()))
                {
                    p.MoverDerecha();
                }
                else if (tecla.Key == ConsoleKey.UpArrow && l.PuedeMoverse(p.GetX(), p.GetY() - 1))
                {
                    p.MoverArriba();
                }
                else if (tecla.Key == ConsoleKey.DownArrow && l.PuedeMoverse(p.GetX(), p.GetY() + 1))
                {
                    p.MoverAbajo();
                }

                if (ColisionEnemigo(p, e))
                {
                    // Perdemos una vida y nos recolocamos en otro lado
                    vidas--;
                    GeneraPosicionInicial(l, r, out xIni, out yIni);
                    p.MoverA(xIni, yIni);
                    l.SetPosicionMapa(xIni, yIni, p.GetImagen());
                }
                    

            } while (tecla.Key != ConsoleKey.Escape && vidas > 0);
        }
    }
}
