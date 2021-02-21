using System;

namespace FutbolSala
{
    class PedirDatos
    {
        /*public static string PedirModoJuego()
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
        }*/

        /*public static byte PedirNumeroJugadas()
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
        }*/
        public static Equipo PedirEquipo()
        {
            Equipo equipo = new Equipo();
            Console.WriteLine("Introduzca un nombre para el equipo");
            equipo.NombreEquipo = Console.ReadLine();

            return equipo;
        }

        public static void PedirJugadores()
        {
            Portero portero = new Portero();
            Defensa defensa = new Defensa();
            Delantero delantero = new Delantero();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce nombre para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.Nombre = Console.ReadLine();
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Nombre = Console.ReadLine();
                else
                    delantero.Nombre = Console.ReadLine();

                Console.WriteLine("Introduce un dorsal para el jugador {0}", i + 1);
                if (i == 0 || i == 9)
                    portero.Dorsal = Convert.ToByte(Console.ReadLine());
                else if ((i > 0 && i < 3) || (i > 4 && i < 7))
                    defensa.Dorsal = Convert.ToByte(Console.ReadLine());
                else
                    delantero.Dorsal = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduce altura para el jugador {0}", i + 1);
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
