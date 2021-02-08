using System;

namespace FutbolSala
{
    class Equipo
    {
        const byte MAXJUGADORES = 10;
        private string nombreEquipo;
        private Jugador[] jugadores = new Jugador[MAXJUGADORES];

        public string NombreEquipo { get; set; }

        public Equipo()
        {
            nombreEquipo = "Equipo rojo";

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

    }
}
