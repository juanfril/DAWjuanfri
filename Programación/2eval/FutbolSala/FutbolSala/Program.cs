using System;

namespace FutbolSala
{
    class Program
    {
        static void Main()
        {
            string modoJuego = PedirDatos.PedirModoJuego();
            byte numeroJugadas = PedirDatos.PedirNumeroJugadas();
            Equipo equipo1 = PedirDatos.PedirEquipo1();
            Portero portero = new Portero();
            Defensa defensa = new Defensa();
            Delantero delantero = new Delantero();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce nombre para el jugador {0}", i+1);
                if (i == 0 || i == 9)
                    portero.Nombre = Console.ReadLine();
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Nombre = Console.ReadLine();
                else
                    delantero.Nombre = Console.ReadLine();

                Console.WriteLine("Introduce un dorsal para el jugador {0}", i+1);
                if (i == 0 || i == 9)
                    portero.Dorsal = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Dorsal = Convert.ToByte(Console.ReadLine());
                else
                    delantero.Dorsal = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce altura para el jugador {0}", i+1);
                if (i == 0 || i == 9)
                    portero.Altura = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Altura = Convert.ToByte(Console.ReadLine());
                else
                    delantero.Altura = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce capacidad defensiva" +
                    " para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.Defensa = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Defensa = Convert.ToByte(Console.ReadLine());
                else
                    delantero.Defensa = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce capacidad atacante " +
                    "para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.Ataque = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Ataque = Convert.ToByte(Console.ReadLine());
                else
                    delantero.Ataque = Convert.ToByte(Console.ReadLine());

                if (i == 0 || i == 9)
                    equipo1.jugadores[i] = portero;
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    equipo1.jugadores[i] = defensa;
                else
                    equipo1.jugadores[i] = delantero;
            }
            equipo1.MostrarJugadores();
        }
    }
}
