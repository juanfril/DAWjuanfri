using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Clase para representar los disparos de las naves */
    class Disparo : Sprite
    {
        bool activo;

        // Establecer el disparo como activo o no
        public void SetActivo(bool a)
        {
            activo = a;
        }

        // Obtener si el disparo está activo o no
        public bool GetActivo()
        {
            return activo;
        }

        // Dibujar el disparo
        public override void Dibujar()
        {
            imagen = "|";
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Dibujar();
            Console.ForegroundColor = c;
        }
    }
}
