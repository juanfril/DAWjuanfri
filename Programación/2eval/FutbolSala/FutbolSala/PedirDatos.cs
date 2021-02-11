using System;

namespace FutbolSala
{
    class PedirDatos
    {
        public static string PedirModoJuego()
        {
            string modoJuego = "a";

            Console.WriteLine("Elija el modo de juego " +
                "(\"R\" resumido / \"C\" completo): ");
            try
            {
                modoJuego = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Parámetro incorrecto, por favor" +
                        "introduzca \"R\" resumido / \"C\" completo");
            }

            if (!modoJuego.Equals("R") && !modoJuego.Equals("C"))
                Console.WriteLine("Usted no ha elegido un modo de juego " +
                    "válido");
            
            return modoJuego;
        }

        public byte PedirNumeroJugadas()
        {
            byte numeroJugadas = 0;

            Console.WriteLine("Introduzca un número de jugadas (de 10 a 30)");

            try
            {
                numeroJugadas = Convert.ToByte(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tiene que elegir un número válido" +
                    " (de 10 a 30 jugadas)");
            }
            if (numeroJugadas < 10 && numeroJugadas > 30)
                Console.WriteLine("Usted no ha elegido un número de jugadas " +
                    "válido");

            return numeroJugadas;
        }
        public static Equipo PedirEquipo1()
        {
            Equipo equipo1 = new Equipo();
            Console.WriteLine("Introduzca un nombre para el equipo");
            equipo1.nombreEquipo = Console.ReadLine();

            return equipo1;
        }

        /*public static Portero PedirPortero()
        {
            Portero portero = new Portero();
            Console.WriteLine("Introduzca nombre para el portero");
            portero.Nombre = Console.ReadLine();
            return portero;
        }*/

        public static void PedirJugadores()
        {
            Portero portero = new Portero();
            Defensa defensa = new Defensa();
            Delantero delantero = new Delantero();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce nombre para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.nombre = Console.ReadLine();
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.nombre = Console.ReadLine();
                else
                    delantero.nombre = Console.ReadLine();

                Console.WriteLine("Introduce un dorsal para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.dorsal = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.dorsal = Convert.ToByte(Console.ReadLine());
                else
                    delantero.dorsal = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce altura para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.altura = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.altura = Convert.ToByte(Console.ReadLine());
                else
                    delantero.altura = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce capacidad defensiva" +
                    " para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.defensa = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.defensa = Convert.ToByte(Console.ReadLine());
                else
                    delantero.defensa = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce capacidad atacante " +
                    "para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.ataque = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.ataque = Convert.ToByte(Console.ReadLine());
                else
                    delantero.ataque = Convert.ToByte(Console.ReadLine());

                /*if (i == 0 || i == 9)
                    equipo1.jugadores[i] = portero;
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    equipo1.jugadores[i] = defensa;
                else
                    equipo1.jugadores[i] = delantero;*/
            }
        }
    }
}
