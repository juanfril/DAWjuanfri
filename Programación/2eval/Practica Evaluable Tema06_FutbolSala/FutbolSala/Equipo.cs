using System;

namespace FutbolSala
{
    class Equipo
    {
        private string nombre;
        private Jugador[] jugadores;

        public string Nombre { get => nombre; set => nombre = value; }
        public Jugador[] Jugadores { get => jugadores; set => jugadores = value; }

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.jugadores = new Jugador[Constants.MAX_JUGADORES];
        }
/*
        // Método para añadir los porteros (en posiciones 0, 9)
        public bool AddJugador(Portero portero, byte posicion)
        {
            bool resultado = false;
            if (posicion == 0 || posicion == 9)
            {
                jugadores[posicion] = portero;
                resultado=true;
            }
            return resultado;
        }

        // Método para añadir los defensas (en posiciones 1, 2, 5, 6)
        public bool AddJugador(Defensa defensa, byte posicion)
        {
            bool resultado = false;

            if (posicion == 1 || posicion == 2 || posicion == 5 || posicion == 6)
            {
                jugadores[posicion] = defensa;
                resultado = true;
            }
            return resultado;
        }

        // Método para añadir los defensas (en posiciones 3, 4, 7, 8)
        public bool AddJugador(Delantero delantero, byte posicion)
        {
            bool resultado = false;

            if (posicion == 3 || posicion == 4 || posicion == 7 || posicion == 8)
            {
                jugadores[posicion] = delantero;
                resultado = true;
            }
            return resultado;
        }
*/
        public void Mostrar()
        {
            Console.WriteLine("\nEquipo " + Nombre);
            foreach (Jugador jugador in jugadores)
                Console.WriteLine(jugador.ToString());
        }

        public void MostrarEstadisticas()
        {
            Console.WriteLine("Estadísticas del equipo " + Nombre);
            foreach (Jugador jugador in jugadores)
                Console.WriteLine(jugador.MostrarResumen());
            Console.WriteLine();
        }
        public int Marcador()
        {
            int result = 0;
            foreach (Jugador jugador in Jugadores)
                result += jugador.Goles;

            return result;
        }
    }
}
