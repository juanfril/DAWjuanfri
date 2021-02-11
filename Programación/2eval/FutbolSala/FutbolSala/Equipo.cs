using System;

namespace FutbolSala
{
    class Equipo
    {
        protected const byte MAXJUGADORES = 10;
        public Jugador[] jugadores = new Jugador[MAXJUGADORES];

        public string nombreEquipo { get; set; }
        //public Jugador[] Jugadores { get; set; }

        public Equipo()
        {
            nombreEquipo = "Local";

            for (int i = 0; i < MAXJUGADORES; i++)
            {
                if (i == 0 || i == MAXJUGADORES - 1)
                    jugadores[i] = new Portero();

                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    jugadores[i] = new Defensa();

                else
                    jugadores[i] = new Delantero();
            }
        }
        public void MostrarJugadores()
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador);
            }
        }
        public void MostrarEstadisticas()
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine("{0}. {1} ha marcado {2} goles",
                    jugador.dorsal, jugador.nombre, jugador.goles);
            }
        }
        public byte Marcador()
        {
            byte goles = 0;

            foreach (var jugador in jugadores)
            {
                goles += jugador.goles; 
            }
            return goles;
        }
    }
}
