using System;

namespace FutbolSala
{
    class Equipo
    {
        protected const byte MAXJUGADORES = 10;
        protected Jugador[] jugadores = new Jugador[MAXJUGADORES];
        private string nombreEquipo;

        public string NombreEquipo
        {
            get => nombreEquipo;
            set
            {
                if(string.IsNullOrEmpty(value))
                    nombreEquipo = "";
                else
                    nombreEquipo = value;
            }
        }
        public Jugador[] Jugadores
        {
            get => jugadores;
            set => jugadores = value;
        }

        public Equipo()
        {
            NombreEquipo = "Genérico";

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
                Console.WriteLine("{0}. {1} ({2}) ha marcado {3} goles",
                    jugador.Dorsal, jugador.Nombre,jugador.GetType() ,jugador.Goles);
            }
        }
        public byte Marcador()
        {
            byte goles = 0;

            foreach (var jugador in jugadores)
            {
                goles += jugador.Goles; 
            }
            return goles;
        }
    }
}
