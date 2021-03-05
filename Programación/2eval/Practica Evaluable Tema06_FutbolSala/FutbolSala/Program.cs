using System;

namespace FutbolSala
{
    static class Constants
    {
        public const int MAX_JUGADORES = 10;
        public static readonly string[] TipoJugador = { "Portero", "Defensa", "Delantero" };
    }

    class Program
    {
        const int nEQUIPOS = 2;

        static void Pausa(string mensaje)
        {
            Console.WriteLine();
            Console.WriteLine(mensaje + " ");
            Console.ReadKey();
            Console.WriteLine();
        }

        private static bool esValidoArgs(string[] args)
        {
            bool esValidoNumJugadas = false;
            int numJugadas;

            if (args.Length == 2 && (args[0] == "R" || args[0] == "C"))
            {
                if (Int32.TryParse(args[1], out numJugadas) && (numJugadas >= 10 && numJugadas <= 30))
                {
                    esValidoNumJugadas = true;
                }
            }
            return esValidoNumJugadas;
        }

        static void Main(string[] args)
        {
            Equipo[] equipos = new Equipo[nEQUIPOS];
            Partido partido;
            string modo, jugada;
            int numJugadas;
            byte turno;

            if (!esValidoArgs(args))
            {
                Console.WriteLine();
                Console.WriteLine("Parámetros incorrectos");
                Console.WriteLine("Indique el modo de juego \"Resumido (R)\" o \"Completo (C)\" y el número de jugadas, entre 10 y 30");
                Console.WriteLine();
                Console.WriteLine("Por ejemplo:");
                Console.WriteLine("FutbolSala R 20");
                Console.WriteLine("FutbolSala C 15");
            }
            else
            {
                modo = args[0];
                Int32.TryParse(args[1], out numJugadas);

                equipos[0] = GestionEquipo.CrearEquipo(1);
                Console.WriteLine();
                equipos[1] = GestionEquipo.CrearEquipo(2);

                partido = new Partido(equipos[0], equipos[1]);

                equipos[0].Mostrar();
                Console.WriteLine();
                equipos[1].Mostrar();

                Pausa("Pulsa una tecla para continuar");

                // Jugadas por turnos
                turno = (byte)(Partido.random.Next(0, 2));

                for (int i = 0; i < numJugadas; i++)
                {
                    jugada = partido.Jugada((byte)(turno + 1));
                    if (modo == "C")
                        Console.WriteLine(jugada);
                    turno = (byte)((turno + 1) % 2);
                }

                Console.WriteLine();
                Console.WriteLine(equipos[0].Nombre + " " + equipos[0].Marcador() + " - " + equipos[1].Marcador() + " " + equipos[1].Nombre);
                if (modo == "R")
                {
                    Console.WriteLine();
                    Console.WriteLine("Estadísticas");
                    Console.WriteLine("------------");
                    Console.WriteLine();

                    for (int i = 0; i < nEQUIPOS; i++)
                        equipos[i].MostrarEstadisticas();
                }

                Pausa("Pulse una tecla para finalizar ... ");
            }
        }
    }
}
