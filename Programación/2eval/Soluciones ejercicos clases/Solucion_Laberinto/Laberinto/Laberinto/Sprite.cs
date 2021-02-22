using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    /* Clase de la que heredarán todos los personajes del juego (el principal y los enemigos) */
    class Sprite
    {
        // Coordenada X (entre 0 y 1023 para pantallas completas, entre 0 y 79 para consola) 
        protected int x;
        // Coordenada Y (entre 0 y 767 para pantallas completas, entre 0 y 24 para consola)
        protected int y;
        // Sprite o imagen del personaje
        protected char imagen;

        // Obtiene la coordenada X
        public int GetX()
        {
            return x;
        }

        // Obtiene la coordenada Y
        public int GetY()
        {
            return y;
        }

        // Obtiene la imagen del personaje
        public char GetImagen()
        {
            return imagen;
        }

        // Establece la coordenada X
        public void SetX(int cx)
        {
            x = cx;
        }

        // Establece la coordenada Y
        public void SetY(int cy)
        {
            y = cy;
        }

        // Establece la imagen del personaje
        public void SetImagen(char img)
        {
            imagen = img;
        }

        // Mueve el objeto 1 unidades a la izquierda
        public void MoverIzquierda()
        {
            MoverA(x - 1, y);
        }

        // Mueve el objeto 1 unidades a la derecha
        public void MoverDerecha()
        {
            MoverA(x + 1, y);
        }

        // Mueve el objeto 1 unidades hacia arriba
        public void MoverArriba()
        {
            MoverA(x, y - 1);
        }

        // Mueve el objeto 1 unidades hacia abajo
        public void MoverAbajo()
        {
            MoverA(x, y + 1);
        }

        // Mover el personaje a una nueva posición (cx, cy)
        // cx debe estar entre 0 y 79 caracteres de ancho, y la cy entre 0 y 24 caracteres de alto
        public void MoverA(int cx, int cy)
        {
            if (cx >= 0 && cx <= 79 && cy >= 0 && cy <= 24)
            {
                // Borramos el personaje de la posición actual (dibujando dos espacios)
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                // Movemos a esas coordenadas, una vez comprobado que son correctas
                SetX(cx);
                SetY(cy);
            }
        }

        // Dibujar el personaje en sus coordenadas actuales
        public virtual void Dibujar()
        {
            imagen = '+';
            Console.SetCursorPosition(x, y);
            Console.Write(imagen);
        }
    }
}
