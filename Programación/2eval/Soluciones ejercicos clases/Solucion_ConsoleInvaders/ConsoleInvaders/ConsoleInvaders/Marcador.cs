using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Muestra los puntos y las vidas restantes en el juego */
    class Marcador
    {
        // Puntos
        int puntos;

        // Vidas restantes
        int vidas;

        // Constructor
        public Marcador(int p, int v)
        {
            puntos = p;
            vidas = v;
        }

        // Aumenta los puntos la cantidad indicada
        public void IncrementarPuntos(int c)
        {
            puntos += c;
        }

        // Descuenta una vida
        public void DescontarVida()
        {
            vidas--;
        }

        // Obtiene las vidas actuales
        public int GetVidas()
        {
            return vidas;
        }

        // Obtiene los puntos actuales
        public int GetPuntos()
        {
            return puntos;
        }

        // Dibuja los puntos y vidas
        public void Dibujar()
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Puntos: {0} - Vidas: {1}", puntos, vidas);
            Console.ForegroundColor = c;

        }
    }
}
