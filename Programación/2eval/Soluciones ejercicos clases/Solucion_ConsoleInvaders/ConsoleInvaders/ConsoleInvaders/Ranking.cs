using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInvaders
{
    /* Clase para gestionar un ranking con las X mejores puntuaciones */
    class Ranking
    {
        // Máximo número de puntuaciones a almacenar
        const int MAX_PUNTUACIONES = 5;

        // Array de mejores puntuaciones
        int[] puntos;

        // Número de puntuaciones añadidas al array
        int cantidad;

        // Constructor
        public Ranking()
        {
            // Gestionamos, por ejemplo, un array de 5 puntuaciones
            puntos = new int[MAX_PUNTUACIONES];
            cantidad = 0;
        }

        // Añade una puntuación al ranking (si corresponde)
        public void AnyadirPuntuacion(int nuevaPuntuacion)
        {
            // Guardamos si ha habido cambios en el ranking
            bool hayCambios = false;

            // Si queda hueco, añadimos
            if (cantidad < puntos.Length)
            {
                puntos[cantidad] = nuevaPuntuacion;
                cantidad++;
                hayCambios = true;
            }
            // Si no queda hueco, ponemos al final (donde esta la menor puntuacion, si es mayor que ésta)
            else if (puntos[cantidad - 1] < nuevaPuntuacion)
            {
                puntos[cantidad - 1] = nuevaPuntuacion;
                hayCambios = true;
            }

            // Reordenamos el array de puntos si ha habido cambios
            if (hayCambios)
            {
                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {
                        if (puntos[i] < puntos[j])
                        {
                            int aux = puntos[i];
                            puntos[i] = puntos[j];
                            puntos[j] = aux;
                        }
                    }
                }
            }
        }

        // Muestra el ranking de puntuaciones
        public void Mostrar()
        {
            if (cantidad > 0)
            {
                Console.WriteLine("Ranking de mejores puntuaciones:");
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("* {0}", puntos[i]);
                }
            }
        }
    }
}
