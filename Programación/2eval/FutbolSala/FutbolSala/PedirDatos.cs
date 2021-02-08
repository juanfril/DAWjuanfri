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

        public static byte PedirNumeroJugadas()
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
            equipo1.NombreEquipo = Console.ReadLine();

            return equipo1;
        }

        public static Portero PedirPortero()
        {
            Portero portero = new Portero();
            Console.WriteLine("Introduzca nombre para el portero");
            portero.Nombre = Console.ReadLine();
            return portero;
        }
    }
}
