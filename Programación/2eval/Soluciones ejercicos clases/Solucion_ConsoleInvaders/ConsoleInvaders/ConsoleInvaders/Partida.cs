using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleInvaders
{
    /* Clase para gestionar la partida principal del juego Console Invaders */
    class Partida
    {
        // Lanza la partida principal, dibujando las naves y enemigos e interactuando con el usuario (recogiendo los movimientos de la nave y demás)
        // Devuelve los puntos obtenidos
        public int Lanzar()
        {
            // =============== Creamos y colocamos en las posiciones iniciales cada elemento del juego ===================

            // Marcador
            Marcador m = new Marcador(0, 3);

            // Nave protagonista
            Nave n = new Nave(40, 20);
            n.Dibujar();

            // Bloque de enemigos
            BloqueDeEnemigos enemigos = new BloqueDeEnemigos();
            enemigos.Dibujar();

            // Torres defensivas
            TorreDefensiva[] torres = new TorreDefensiva[4];
            for (int i = 0; i < torres.Length; i++)
            {
                torres[i] = new TorreDefensiva();
                torres[i].MoverA(10 + 17 * i, 15);
                torres[i].Dibujar();
            }

            // Ovni superior
            Ovni o = new Ovni();
            o.MoverA(0, 1);

            // Disparo de la nave (inicialmente inactivo hasta que se dispare)
            Disparo d = new Disparo();
            d.SetActivo(false);

            // Disparo de los enemigos (podría ser un array con varios, pero por simplificar lo dejamos en uno cada vez)
            Disparo de = new Disparo();
            de.SetActivo(false);

            // Pulsación de teclado del usuario
            ConsoleKeyInfo tecla = new ConsoleKeyInfo(); ;


            // =============== Bucle del juego ===================

            do
            {
                // Para que el juego no vaya muy rápido, lo dormimos 100 ms entre iteración e iteración
                Thread.Sleep(100);

                // Movemos la nave principal o disparamos sólo si pulsamos una tecla
                if (Console.KeyAvailable)
                {
                    // Recogemos pulsación de tecla del usuario
                    tecla = Console.ReadKey();

                    // Movemos la nave y/o disparamos si es el caso
                    if (tecla.Key == ConsoleKey.LeftArrow)
                    {
                        n.MoverIzquierda();
                    }
                    else if (tecla.Key == ConsoleKey.RightArrow)
                    {
                        n.MoverDerecha();
                    }
                    else if (tecla.Key == ConsoleKey.Spacebar)
                    {
                        // Disparo de la nave
                        if (!d.GetActivo())
                        {
                            d.MoverA(n.GetX(), n.GetY());
                            d.SetActivo(true);
                        }
                    }
                }

                // El resto de movimientos del juego (disparos, enemigos, etc) es independiente de si pulsamos o no una tecla

                // Movemos los enemigos
                enemigos.Mover();
                enemigos.Dibujar();

                // Intentamos generar un disparo enemigo si no hay ninguno activo
                if (!de.GetActivo())
                {
                    int x, y;
                    enemigos.IntentarDisparo(out x, out y);
                    if (x >= 0 && y >= 0)
                    {
                        de.MoverA(x, y);
                        de.SetActivo(true);
                    }

                }

                // Movemos el disparo enemigo activo
                if (de.GetActivo())
                {
                    de.MoverA(de.GetX(), de.GetY() + 1);
                    de.Dibujar();
                }

                // Comprobamos colisiones con la nave y quitamos vida si choca
                if (de.ColisionaCon(n))
                {
                    m.DescontarVida();
                    de.SetActivo(false);
                    // Dibujamos una "X" roja en el lugar de la nave y la mostramos durante un segundo
                    ConsoleColor c = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(n.GetX(), n.GetY());
                    Console.Write("><");
                    Console.ForegroundColor = c;
                    Thread.Sleep(1000);         
                }

                // Comprobamos colisiones con las torres defensivas y las destruimos parcialmente si toca (eliminando el disparo enemigo en ese caso)
                for (int i = 0; i < torres.Length; i++ )
                {
                    if (torres[i].ColisionaCon(de))
                        de.SetActivo(false);
                }

                // Si el disparo enemigo llega al borde inferior, desaparece
                if (de.GetY() >= 23)
                {
                    de.SetActivo(false);
                }

                // Intentamos activar el ovni si no lo está, y lo movemos si lo está
                if (o.GetActivo())
                {
                    o.Mover();
                    o.Dibujar();
                }
                else
                {
                    o.IntentarActivacion();
                    if (o.GetActivo())
                    {
                        o.MoverA(0, 1);
                        o.Dibujar();
                    }
                }

                // Dibujamos la nave y su disparo (si está activo)
                n.Dibujar();
                if (d.GetActivo())
                {
                    d.MoverA(d.GetX(), d.GetY() - 1);

                    // Si llegamos arriba del todo, desactivamos el disparo
                    if (d.GetY() <= 0)
                        d.SetActivo(false);

                    // Comprobamos colisiones con ovni
                    else if (d.ColisionaCon(o))
                    {
                        m.IncrementarPuntos(50);
                        d.SetActivo(false);
                        o.SetActivo(false);
                    }
                    // Comprobamos colisiones con el bloque de enemigos
                    else if (enemigos.ComprobarColisiones(d))
                    {
                        m.IncrementarPuntos(10);
                        d.SetActivo(false);
                    }

                    // Comprobamos colisiones con torres
                    else
                    {
                        for (int i = 0; i < torres.Length; i++)
                        {
                            if (torres[i].ColisionaCon(d))
                                d.SetActivo(false);
                        }
                    }
                    
                    // Si el disparo sigue activo, lo dibujamos
                    if (d.GetActivo())
                        d.Dibujar();
                }

                // Dibujamos las torres
                for (int i = 0; i < torres.Length; i++)
                {
                    torres[i].Dibujar();
                }

                // Mostramos los puntos en la parte inferior
                Console.SetCursorPosition(1, 23);
                m.Dibujar();

            } while ((tecla == null || tecla.Key != ConsoleKey.Escape) && m.GetVidas() > 0);

            // Devolvemos los puntos obtenidos para añadirlos al ranking desde la clase Juego
            return m.GetPuntos();
        }
    }
}
