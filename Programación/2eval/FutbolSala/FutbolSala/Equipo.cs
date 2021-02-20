using System;

namespace FutbolSala
{
    class Equipo
    {
        protected const byte MAXJUGADORES = 10;
        protected Jugador[] jugadores = new Jugador[MAXJUGADORES];

        public string NombreEquipo
        {
            get => NombreEquipo;
            set
            {
                try
                {
                    NombreEquipo = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("El parámetro introducido no es correcto");
                }
            }
        }
        public Jugador[] Jugadores { get; set; }

        public Equipo()
        {
            NombreEquipo = "Local";

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
                    jugador.Dorsal, jugador.Nombre, jugador.Goles);
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
