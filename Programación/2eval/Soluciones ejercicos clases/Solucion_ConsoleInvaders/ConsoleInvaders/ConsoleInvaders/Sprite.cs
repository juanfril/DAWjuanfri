using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Clase para representar todas las naves del juego (principal y enemigos) */
    class Sprite
    {
        // Coordenada X (entre 0 y 1023 para pantallas completas, entre 0 y 79 para consola) 
        protected int x;
        // Coordenada Y (entre 0 y 767 para pantallas completas, entre 0 y 24 para consola)
        protected int y;
        // Sprite o imagen de la nave, formada por caracteres
        protected string imagen;

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

        // Obtiene la imagen de la nave
        public string GetImagen()
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

        // Establece la imagen de la nave
        public void SetImagen(string img)
        {
            imagen = img;
        }

       
        // Mover la nave a una nueva posición (cx, cy)
        // cx debe estar entre 0 y 78 caracteres de ancho (para que quepan los dos símbolos de la imagen), y la cy entre 0 y 24 caracteres de alto
        public void MoverA(int cx, int cy)
        {
            int longitud = 2;
            if (imagen != null)
                longitud = imagen.Length;
            if (cx >= 0 && cx <= 79 - longitud && cy >= 0 && cy <= 24)
            {
                // Borramos la nave de la posición actual (dibujando dos espacios)
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < longitud; i++)
                    Console.Write(" ");
                // Movemos a esas coordenadas, una vez comprobado que son correctas
                SetX(cx);
                SetY(cy);
            }
        }

        // Dibujar la nave en sus coordenadas actuales
        public virtual void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(imagen);
        }

        // Detecta si el sprite actual colisiona con el que se pasa como parámetro (útil para disparos chocando con naves)
        public bool ColisionaCon(Sprite s)
        {
            // Si alguno de los dos sprites no existe, no hay colisión
            if (GetImagen() == null || s.GetImagen() == null)
                return false;

            // Consideramos los tamaños de cada sprite para ver si colisionan horizontalmente
            int tam1 = GetImagen().Length;
            int tam2 = s.GetImagen().Length;

            // Colisionarán en horizontal si uno de los sprites está contenido entre la coordenada X y la coordenada X + el tamaño del sprite del otro
            bool colisionX = (GetX() <= s.GetX() && GetX() + tam1 >= s.GetX()) || (s.GetX() <= GetX() && s.GetX() + tam2 >= GetX());
            bool colisionY = GetY() == s.GetY();

            return colisionX && colisionY;
        }
    }
}
